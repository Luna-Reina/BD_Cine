using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
            dgvSala.Enabled = true;
            dgvSala.SelectionChanged -= dgvSala_SelectionChanged;
            dgvSala.SelectionChanged += dgvSala_SelectionChanged;

            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            this.editar = false;

            txtAsientos.Enabled = false;
            txtNumeroSala.Enabled = false;
            txtTipoSala.Enabled = false;
            cmbSucursal.Enabled = false;
        }

        public void habilitarEscribir()
        {
            dgvSala.Enabled = false;
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
                dgvSala.SelectionChanged -= dgvSala_SelectionChanged;
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    String query = @"SELECT S.IDSala
                                      ,S.IDSucursal AS IDSucursal
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

                        if (dgvSala.Columns["IDSucursal"] != null)
                        {
                            dgvSala.Columns["IDSucursal"].Visible = false;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectarse: " + ex.Message);
            }
            finally
            {
                dgvSala.SelectionChanged += dgvSala_SelectionChanged;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count == 1)
            {
                this.editar = true;
                habilitarEscribir();
                MessageBox.Show("Estás en el modo de edición", "Notificación", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Debe de tener solo un renglon seleccionado");
            }
        }

        private void dgvSala_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSala.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvSala.SelectedRows[0];

                txtIdSala.Text = row.Cells["IDSala"].Value.ToString();
                cmbSucursal.SelectedValue = row.Cells["IDSucursal"].Value;
                txtNumeroSala.Text = row.Cells["NumeroSala"].Value.ToString();
                txtTipoSala.Text = row.Cells["TipoSala"].Value.ToString();
                txtAsientos.Text = row.Cells["CantidadAsientos"].Value.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar operación?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Se detuvo la cancelación", "Mensaje", MessageBoxButtons.OK);
                return;
            }

            limpiar();
            reestablecerBotones();
            MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "";
                    if (!this.editar) //Nuevo Resgistro
                    {
                        query = @"INSERT INTO dbo.Sala
                                       (IDSucursal
                                       ,NumeroSala
                                       ,TipoSala
                                       ,CantidadAsientos)
                                 VALUES
                                       (@IDSucursal
                                       ,@NumeroSala
                                       ,@TipoSala
                                       ,@CantidadAsientos)";
                    }
                    else
                    {  //Update
                        query = @"UPDATE dbo.Sala
                                   SET IDSucursal = @IDSucursal
                                      ,NumeroSala = @NumeroSala
                                      ,TipoSala = @TipoSala
                                      ,CantidadAsientos = @CantidadAsientos
                                 WHERE IDSala= @IDSala";
                    }
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSucursal", cmbSucursal.SelectedValue);
                        cmd.Parameters.AddWithValue("@NumeroSala", txtNumeroSala.Text);
                        cmd.Parameters.AddWithValue("@TipoSala", txtTipoSala.Text);
                        cmd.Parameters.AddWithValue("@CantidadAsientos", Convert.ToInt32(txtAsientos.Text));
                        if (this.editar)
                        {
                            cmd.Parameters.AddWithValue("@IDSala", Convert.ToInt32(txtIdSala.Text));
                        }
                        int renglonesAfectados = cmd.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Consulta realizada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar ejecución: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obtenerDatos();
                reestablecerBotones();
                limpiar();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar este registro?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Se canceló la eliminación");
                return;
            }

            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = @"DELETE FROM dbo.Sala WHERE IDSala = @IDSala";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDSala", Convert.ToInt32(txtIdSala.Text));

                        int renglonesAfectados = cmd.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Consulta realizada con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar consulta: " + ex.Message);
            }
            finally
            {
                obtenerDatos();
                limpiar();
                reestablecerBotones();
            }

        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void Sala_Load(object sender, EventArgs e)
        {

        }
    }
}
