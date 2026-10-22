using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Venta : Form
    {
        bool editar = false;
        public Venta()
        {
            InitializeComponent();
        }

        public void reestablecerBotones()
        {
            dgvVenta.Enabled = true;
            dgvVenta.SelectionChanged -= dgvVenta_SelectionChanged;
            dgvVenta.SelectionChanged += dgvVenta_SelectionChanged;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            this.editar = false;

            cmbBoleto.Enabled = false;
            cmbCliente.Enabled = false;
            cmbFuncion.Enabled = false;
        }

        public void habilitarEscribir()
        {
            dgvVenta.Enabled = false;

            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            cmbBoleto.Enabled = true;
            cmbCliente.Enabled = true;
            cmbFuncion.Enabled = true;
        }

        public void limpiarTodo()
        {
            txtIDVenta.Text = string.Empty;
            txtPrecio.Text = string.Empty;
            cmbBoleto.SelectedIndex = -1;
            cmbCliente.SelectedIndex = -1;
            cmbFuncion.SelectedIndex = -1;
        }

        private void dgvVenta_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            limpiarTodo();
            habilitarEscribir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count != 1)
            {
                MessageBox.Show("Debe de tener un renglón, uno solamente");
                return;
            }
            habilitarEscribir();
            this.editar = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea cancelar operación?", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("Se detuvo la cancelación", "Mensaje", MessageBoxButtons.OK);
                return;
            }

            limpiarTodo();
            reestablecerBotones();
            MessageBox.Show("Operación cancelada", "Cancelación", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void obtenerDatos()
        {
            try
            {
                dgvVenta.SelectionChanged -= dgvVenta_SelectionChanged;
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    string query = @"SELECT 
                                        V.IDVenta AS [ID Venta],
                                        V.IDCliente AS [IDCliente],
                                        C.Nombre AS [Cliente],
                                        V.IDFuncion AS [IDFuncion],
                                        F.Fecha AS [Fecha Función],
                                        F.Hora AS [Hora Función],
                                        V.IDTipoBoleto AS [IDTipoBoleto],
                                        TB.Clave AS [Tipo Boleto],
                                        V.Precio AS [Precio Venta]
                                    FROM dbo.Venta V
                                    INNER JOIN dbo.Cliente C ON V.IDCliente = C.IDCliente
                                    INNER JOIN dbo.Funcion F ON V.IDFuncion = F.IDFuncion
                                    INNER JOIN dbo.TipoBoleto TB ON V.IDTipoBoleto = TB.IDTipoBoleto";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
            finally
            {
                dgvVenta.SelectionChanged += dgvVenta_SelectionChanged;
            }
        }

        private void Venta_Load(object sender, EventArgs e)
        {

        }
    }//close partial class


}
