using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Sala : Form
    {
        bool editar = false;
        public Sala()
        {
            InitializeComponent();
            obtenerDatos();
            llenarcomboBoxSucursal();
        }

        public void reestablecerBotones()
        {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            this.editar = false;
        }

        public void habilitarEscribir()
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            txtAsientos.Enabled = true;
            txtNumeroSala.Enabled = true;
            txtTipoSala.Enabled = true;
            cmbSucursal.Enabled = true;
        }

        public void limpiar()
        {
            txtAsientos.Text = string.Empty;
            txtIdSala.Text = string.Empty;
            txtNumeroSala.Text = string.Empty;
            txtTipoSala.Text = string.Empty;
            cmbSucursal.SelectedIndex = -1;
        }

        public void obtenerDatos()
        {
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    String query = @"SELECT S.IDSala
                                      ,SU.Nombre AS NombreSucursal
                                      ,S.NumeroSala
                                      ,S.TipoSala
                                      ,S.CantidadAsientos
                                  FROM dbo.Sala S
                                  INNER JOIN Sucursal SU ON SU.IDSucursal = S.IDSucursal";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dgvSala.DataSource = dt;

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse: " + ex.Message);
            }
        }

        public void llenarcomboBoxSucursal()
        {
            try
            {
                cmbSucursal.DataSource = null;
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    String query = @"SELECT IDSucursal, Nombre FROM Sucursal";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        cmbSucursal.ValueMember = "IDSucursal";
                        cmbSucursal.DisplayMember = "Nombre";
                        cmbSucursal.DataSource = dt;
                    }

                }
                cmbSucursal.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el combo box: " + ex.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            reestablecerBotones();
            limpiar();
            habilitarEscribir();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
