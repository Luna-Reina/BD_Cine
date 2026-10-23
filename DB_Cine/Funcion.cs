using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Funcion : Form
    {
        bool editar = false;

        public Funcion()
        {
            InitializeComponent();
            obtenerDatos();
            reestablecerBotones();
        }

        public void limpiarCampos()
        {
            txtIDFuncion.Text = "";
            txtIDPelicula.Text = "";
            txtIDSala.Text = "";
        }

        public void reestablecerBotones()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            this.editar = false;

            txtIDFuncion.Enabled = false;
            txtIDPelicula.Enabled = false;
            txtIDSala.Enabled = false;
            dtFecha.Enabled = false;
            dtHora.Enabled = false;

            dgvFuncion.Enabled = true;
        }

        public void habilitarEscribir()
        {
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtIDFuncion.Enabled = !this.editar;
            txtIDPelicula.Enabled = true;
            txtIDSala.Enabled = true;
            dtFecha.Enabled = true;
            dtHora.Enabled = true;

            dgvFuncion.Enabled = false;
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
            if (string.IsNullOrWhiteSpace(txtIDFuncion.Text))
            {
                MessageBox.Show("Selecciona una función de la tabla antes de editar.",
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
            dgvFuncion.SelectionChanged -= dgvFuncion_SelectionChanged;
            try
            {
                using (SqlConnection connection = new Conexion().ObtenerConexion())
                {
                    connection.Open();
                    string consulta = "SELECT IDFuncion AS [ID], IDPelicula AS [Pelicula], " +
                        "IDSala AS [Sala], Fecha, Hora FROM dbo.Funcion";

                    DataTable dtFuncion = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(consulta, connection))
                    {
                        da.Fill(dtFuncion);
                    }
                    dgvFuncion.DataSource = dtFuncion;
                }
                dgvFuncion.ClearSelection();
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvFuncion.SelectionChanged += dgvFuncion_SelectionChanged;
            }
        }

        private void dgvFuncion_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFuncion.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvFuncion.SelectedRows[0];

                txtIDFuncion.Text = row.Cells["ID"].Value?.ToString();
                txtIDPelicula.Text = row.Cells["Pelicula"].Value?.ToString();
                txtIDSala.Text = row.Cells["Sala"].Value?.ToString();
                dtFecha.Value = Convert.ToDateTime(row.Cells["Fecha"].Value);
                dtHora.Value = Convert.ToDateTime(row.Cells["Hora"].Value.ToString());
            }
        }

        private void dgvFuncion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int idFuncion;
            if (!int.TryParse(txtIDFuncion.Text, out idFuncion))
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
                        query = "INSERT INTO Funcion (IDFuncion, IDPelicula, IDSala, Fecha, Hora) " +
                            "VALUES (@IDFuncion, @IDPelicula, @IDSala, @Fecha, @Hora)";
                    }
                    else
                    {
                        query = "UPDATE Funcion SET IDPelicula = @IDPelicula, IDSala = @IDSala, " +
                            "Fecha = @Fecha, Hora = @Hora WHERE IDFuncion = @IDFuncion";
                    }

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDFuncion", idFuncion);
                        cmd.Parameters.AddWithValue("@IDPelicula", txtIDPelicula.Text);
                        cmd.Parameters.AddWithValue("@IDSala", txtIDSala.Text);
                        cmd.Parameters.AddWithValue("@Fecha", dtFecha.Value);
                        cmd.Parameters.AddWithValue("@Hora", dtHora.Value);

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
            int idFuncion;
            if (!int.TryParse(txtIDFuncion.Text, out idFuncion))
            {
                MessageBox.Show("Selecciona una función de la tabla antes de eliminar.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show("¿Está seguro de eliminar esta función?",
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
                    string query = "DELETE FROM Funcion WHERE IDFuncion = @IDFuncion";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@IDFuncion", idFuncion);
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
    }//Close Class
}//Close Namespace