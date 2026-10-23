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
            obtenerDatos();
            llenarComboFuncion();
            llenarComboCliente();
            llenarComboBoleto();
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
            if (dgvVenta.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvVenta.SelectedRows[0];
                txtIDVenta.Text = row.Cells["ID Venta"].Value?.ToString();
                txtPrecio.Text = row.Cells["Precio Venta"].Value?.ToString();
                if (row.Cells["IDCliente"].Value != null && row.Cells["IDCliente"].Value != DBNull.Value)
                {
                    cmbCliente.SelectedValue = Convert.ToInt32(row.Cells["IDCliente"].Value);
                }
                else
                {
                    cmbCliente.SelectedIndex = -1;
                }
                if (row.Cells["IDFuncion"].Value != null && row.Cells["IDFuncion"].Value != DBNull.Value)
                {
                    cmbFuncion.SelectedValue = Convert.ToInt32(row.Cells["IDFuncion"].Value);
                }
                else
                {
                    cmbFuncion.SelectedIndex = -1;
                }
                if (row.Cells["IDTipoBoleto"].Value != null && row.Cells["IDTipoBoleto"].Value != DBNull.Value)
                {
                    cmbBoleto.SelectedValue = Convert.ToInt32(row.Cells["IDTipoBoleto"].Value);
                }
                else
                {
                    cmbBoleto.SelectedIndex = -1;
                }
            }
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
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dgvVenta.DataSource = dt;
                        dgvVenta.Columns["IDCliente"].Visible = false;
                        dgvVenta.Columns["IDFuncion"].Visible = false;
                        dgvVenta.Columns["IDTipoBoleto"].Visible = false;
                    }

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

        public void llenarComboFuncion()
        {
            try
            {
                cmbFuncion.DataSource = null;

                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IDFuncion FROM dbo.Funcion ORDER BY IDFuncion ASC";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        cmbFuncion.ValueMember = "IDFuncion";
                        cmbFuncion.DisplayMember = "IDFuncion";
                        cmbFuncion.DataSource = dt;
                    }
                }

                cmbFuncion.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ComboBox de Funciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarComboCliente()
        {
            try
            {
                cmbCliente.DataSource = null;

                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IDCliente, Nombre FROM dbo.Cliente";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        cmbCliente.ValueMember = "IDCliente";
                        cmbCliente.DisplayMember = "Nombre";
                        cmbCliente.DataSource = dt;
                    }
                }

                cmbCliente.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ComboBox de Funciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarComboBoleto()
        {
            try
            {
                cmbBoleto.DataSource = null;

                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "SELECT IDTipoBoleto, Clave FROM dbo.TipoBoleto";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }

                        cmbBoleto.ValueMember = "IDTipoBoleto";
                        cmbBoleto.DisplayMember = "Clave";
                        cmbBoleto.DataSource = dt;
                    }
                }

                cmbBoleto.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el ComboBox de Funciones: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void cmbBoleto_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBoleto.SelectedIndex >= 0)
            {
                if (cmbBoleto.SelectedIndex == 0)
                {
                    txtPrecio.Text = "84";
                }
                if (cmbBoleto.SelectedIndex == 1)
                {
                    txtPrecio.Text = "67";
                }
                if (cmbBoleto.SelectedIndex == 2)
                {
                    txtPrecio.Text = "70";
                }
            }
            else
            {
                txtPrecio.Text = string.Empty;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "";

                    if (!this.editar)
                    {
                        query = @"INSERT INTO dbo.Venta (IDCliente, IDFuncion, IDTipoBoleto, Precio) 
                          VALUES (@IDCliente, @IDFuncion, @IDTipoBoleto, @Precio)";
                    }
                    else
                    {
                        query = @"UPDATE dbo.Venta 
                          SET IDCliente = @IDCliente, 
                              IDFuncion = @IDFuncion, 
                              IDTipoBoleto = @IDTipoBoleto, 
                              Precio = @Precio 
                          WHERE IDVenta = @IDVenta";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", Convert.ToInt32(cmbCliente.SelectedValue));
                        cmd.Parameters.AddWithValue("@IDFuncion", Convert.ToInt32(cmbFuncion.SelectedValue));
                        cmd.Parameters.AddWithValue("@IDTipoBoleto", Convert.ToInt32(cmbBoleto.SelectedValue));
                        cmd.Parameters.AddWithValue("@Precio", txtPrecio.Text);

                        if (this.editar)
                        {
                            cmd.Parameters.AddWithValue("@IDVenta", Convert.ToInt32(txtIDVenta.Text));
                        }

                        int lineasAfectadas = cmd.ExecuteNonQuery();

                        if (lineasAfectadas > 0)
                        {
                            MessageBox.Show("Consulta realizada con exito", "Exito", MessageBoxButtons.OK);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                obtenerDatos();
                reestablecerBotones();
                limpiarTodo();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvVenta.SelectedRows.Count != 1)
            {
                MessageBox.Show("Por favor, seleccione un registro de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("¿Seguro que desea eliminar este registro?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No) {
                return;
            }
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string query = "DELETE FROM dbo.Venta WHERE IDVenta = @IDVenta";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@IDVenta", Convert.ToInt32(txtIDVenta.Text));

                        int lineasAfectadas = cmd.ExecuteNonQuery();

                        if (lineasAfectadas > 0)
                        {
                            MessageBox.Show("Venta eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                obtenerDatos();
                reestablecerBotones();
                limpiarTodo();
            }
        }
    }//close partial class


}
