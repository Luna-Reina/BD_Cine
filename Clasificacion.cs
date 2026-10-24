using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Clasificacion : Form
    {

        //conexion SQL
        private string conexionString = @"Server=KAROLI\DS3;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool esNuevo = false;

   
        public Clasificacion()
        {
            InitializeComponent();

            // Enlazar evento Load del formulario
            this.Load += Clasificacion_Load;

            // Enlazar botones manualmente
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            btnSalir.Click += btnSalir_Click;

            // Enlazar evento de selección en la tabla
            dgvClasificacion.CellClick += dgvClasificaciones_CellClick;
        }
        private void Clasificacion_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            ObtenerDatos();
        }

        private void LimpiarCampos()
        {
            txtIdClasificacion.Clear();
            txtClave.Clear();
            txtDescripcion.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtClave.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            dateTimePicker1.Enabled = habilitar;
            dateTimePicker2.Enabled = habilitar;

            btnGuardar.Enabled = habilitar;
            btnCancelar.Enabled = habilitar;

            btnNuevo.Enabled = !habilitar;
            btnEditar.Enabled = !habilitar;
            btnEliminar.Enabled = !habilitar;
            btnObtenerDatos.Enabled = !habilitar;
        }

        private void DeshabilitarCampos()
        {
            HabilitarCampos(false);
            txtIdClasificacion.Enabled = false;
        }

        private void ObtenerDatos()
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    string query = "SELECT IdClasificacion, Clave, Descripcion, FecharHoraCreacion FROM Clasificacion";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvClasificacion.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvClasificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClasificacion.Rows[e.RowIndex];
                txtIdClasificacion.Text = fila.Cells["IdClasificacion"].Value?.ToString() ?? "";
                txtClave.Text = fila.Cells["Clave"].Value?.ToString() ?? "";
                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";

                if (DateTime.TryParse(fila.Cells["FecharHoraCreacion"].Value?.ToString(), out DateTime fecha))
                {
                    dateTimePicker1.Value = fecha;
                    dateTimePicker2.Value = fecha;
                }
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarCampos();
            HabilitarCampos(true);
            txtClave.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdClasificacion.Text))
            {
                MessageBox.Show("Seleccione un registro para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            esNuevo = false;
            HabilitarCampos(true);
            txtClave.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text) || string.IsNullOrWhiteSpace(txtDescripcion.Text))
            {
                MessageBox.Show("Por favor, llene los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaHoraCompleta = dateTimePicker1.Value.Date.Add(dateTimePicker2.Value.TimeOfDay);

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd;

                    if (esNuevo)
                    {
                        string query = "INSERT INTO Clasificacion (Clave, Descripcion, FecharHoraCreacion) VALUES (@Clave, @Descripcion, @FechaHora)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        string query = "UPDATE Clasificacion SET Clave = @Clave, Descripcion = @Descripcion, FecharHoraCreacion = @FechaHora WHERE IdClasificacion = @Id";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdClasificacion.Text));
                    }

                    cmd.Parameters.AddWithValue("@Clave", txtClave.Text.Trim());
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaHora", fechaHoraCompleta);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Guardado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                    DeshabilitarCampos();
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdClasificacion.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta clasificación?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Clasificacion WHERE IdClasificacion = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdClasificacion.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eliminado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCampos();
                        DeshabilitarCampos();
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}