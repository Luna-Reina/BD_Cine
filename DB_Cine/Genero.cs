using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Genero : Form
    {
        bool editar = false;

        public Genero()
        {
            InitializeComponent();
            obtenerDatos();
            reestablecerBotones();
        }

        public void limpiarCampos()
        {
            txtIDGenero.Text = "";
            txtNombreGenero.Text = "";
            txtDescripcion.Text = "";
        }

        public void reestablecerBotones()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            this.editar = false;

            txtIDGenero.Enabled = false;
            txtNombreGenero.Enabled = false;
            txtDescripcion.Enabled = false;

            dgvGenero.Enabled = true;
        }

        public void habilitarEscribir()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtIDGenero.Enabled = !this.editar;
            txtNombreGenero.Enabled = true;
            txtDescripcion.Enabled = true;

            dgvGenero.Enabled = false;
        }

        private void Genero_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgvGenero_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtIDGenero.Text))
            {
                MessageBox.Show("Selecciona un género de la tabla antes de editar.",
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

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        public void obtenerDatos()
        {

            dgvGenero.SelectionChanged -= dgvGenero_SelectionChanged;
            try
            {
                using (SqlConnection connection = new Conexion().ObtenerConexion())
                {
                    connection.Open();
                    string consulta = "SELECT IDGenero AS [ID], NombreGenero AS [Nombre], " +
                        "Descripcion AS [Descripción] FROM dbo.Genero";

                    DataTable dtGenero = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(consulta, connection))
                    {
                        da.Fill(dtGenero);
                    }
                    dgvGenero.DataSource = dtGenero;
                }
                dgvGenero.ClearSelection();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvGenero.SelectionChanged += dgvGenero_SelectionChanged;
            }
        }

        private void dgvGenero_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvGenero.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvGenero.SelectedRows[0];

                txtIDGenero.Text = row.Cells["ID"].Value?.ToString();
                txtNombreGenero.Text = row.Cells["Nombre"].Value?.ToString();
                txtDescripcion.Text = row.Cells["Descripción"].Value?.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreGenero.Text))
            {
                MessageBox.Show("Escribe el nombre del género.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idGenero;
            if (!int.TryParse(txtIDGenero.Text, out idGenero))
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
                        query = "INSERT INTO Genero (IDGenero, NombreGenero, Descripcion) " +
                            "VALUES (@IDGenero, @NombreGenero, @Descripcion)";
                    }
                    else
                    {
                        query = "UPDATE Genero SET NombreGenero = @NombreGenero, " +
                            "Descripcion = @Descripcion WHERE IDGenero = @IDGenero";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDGenero", idGenero);
                        cmd.Parameters.AddWithValue("@NombreGenero", txtNombreGenero.Text);
                        cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text);

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
            int idGenero;
            if (!int.TryParse(txtIDGenero.Text, out idGenero))
            {
                MessageBox.Show("Selecciona un género de la tabla antes de eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar este género?",
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
                    string query = "DELETE FROM Genero WHERE IDGenero = @IDGenero";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDGenero", idGenero);
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