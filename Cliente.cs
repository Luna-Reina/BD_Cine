using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Cliente : Form
    {
        bool editar = false;

        public Cliente()
        {
            InitializeComponent();
            obtenerDatos();
            reestablecerBotones();
        }

        public void limpiarCampos()
        {
            txtIDCliente.Text = "";
            txtIDCiudad.Text = "";
            txtNombre.Text = "";
            txtCelular.Text = "";
            txtCorreo.Text = "";
        }

        public void reestablecerBotones()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            this.editar = false;

            txtIDCliente.Enabled = false;
            txtIDCiudad.Enabled = false;
            txtNombre.Enabled = false;
            txtCelular.Enabled = false;
            txtCorreo.Enabled = false;

            dgvCliente.Enabled = true;
        }

        public void habilitarEscribir()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtIDCliente.Enabled = !this.editar;
            txtIDCiudad.Enabled = true;
            txtNombre.Enabled = true;
            txtCelular.Enabled = true;
            txtCorreo.Enabled = true;

            dgvCliente.Enabled = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.editar = false;
            limpiarCampos();
            habilitarEscribir();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIDCliente.Text))
            {
                MessageBox.Show("Selecciona un cliente de la tabla antes de editar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.editar = true;
            habilitarEscribir();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cancelar la operación?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                reestablecerBotones();
                limpiarCampos();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnObtener_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        public void obtenerDatos()
        {
            dgvCliente.SelectionChanged -= dgvCliente_SelectionChanged;
            try
            {
                using (SqlConnection connection = new Conexion().ObtenerConexion())
                {
                    connection.Open();
                    string consulta = "SELECT IDCliente AS [ID], IDCiudad AS [Ciudad], " +
                        "Nombre, Celular, Correo FROM dbo.Cliente";

                    DataTable dtCliente = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(consulta, connection))
                    {
                        da.Fill(dtCliente);
                    }
                    dgvCliente.DataSource = dtCliente;
                }
                dgvCliente.ClearSelection();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvCliente.SelectionChanged += dgvCliente_SelectionChanged;
            }
        }

        private void dgvCliente_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCliente.SelectedRows[0];

                txtIDCliente.Text = row.Cells["ID"].Value?.ToString();
                txtIDCiudad.Text = row.Cells["Ciudad"].Value?.ToString();
                txtNombre.Text = row.Cells["Nombre"].Value?.ToString();
                txtCelular.Text = row.Cells["Celular"].Value?.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value?.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idCliente;
            if (!int.TryParse(txtIDCliente.Text, out idCliente))
            {
                MessageBox.Show("El ID debe ser un número.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool esEdicion = this.editar;
            bool exito = false;

            try
            {
                using (SqlConnection connection = new Conexion().ObtenerConexion())
                {
                    connection.Open();

                    string query;
                    if (!esEdicion)
                    {
                        query = "INSERT INTO Cliente (IDCliente, IDCiudad, Nombre, Celular, Correo) " +
                            "VALUES (@IDCliente, @IDCiudad, @Nombre, @Celular, @Correo)";
                    }
                    else
                    {
                        query = "UPDATE Cliente SET IDCiudad = @IDCiudad, Nombre = @Nombre, " +
                            "Celular = @Celular, Correo = @Correo WHERE IDCliente = @IDCliente";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", idCliente);
                        cmd.Parameters.AddWithValue("@IDCiudad", txtIDCiudad.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Celular", txtCelular.Text);
                        cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text);

                        int renglonesAfectados = cmd.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            string mensaje = esEdicion
                                ? "Registro actualizado correctamente."
                                : "Registro guardado correctamente.";
                            MessageBox.Show(mensaje, "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            exito = true;
                        }
                        else
                        {
                            MessageBox.Show("No se pudo guardar el registro.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (exito)
            {
                reestablecerBotones();
                limpiarCampos();
                obtenerDatos();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idCliente;
            if (!int.TryParse(txtIDCliente.Text, out idCliente))
            {
                MessageBox.Show("Selecciona un cliente de la tabla antes de eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este cliente?",
                "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using (SqlConnection connection = new Conexion().ObtenerConexion())
                {
                    connection.Open();
                    string query = "DELETE FROM Cliente WHERE IDCliente = @IDCliente";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDCliente", idCliente);
                        int renglonesAfectados = cmd.ExecuteNonQuery();
                        if (renglonesAfectados > 0)
                        {
                            MessageBox.Show("Registro eliminado correctamente.", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No se pudo eliminar el registro.", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                limpiarCampos();
                obtenerDatos();
            }
        }
    }
}