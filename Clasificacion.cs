using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Clasificacion : Form
    {
        // Conexión a SQL
        private string conexionString = @"Server=KAROLI\DS3;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool esNuevo = false;

        public Clasificacion()
        {
            InitializeComponent();

            // Vincular eventos manualmente
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            btnSalir.Click += btnSalir_Click;
            dgvClasificacion.CellClick += dgvClasificaciones_CellClick;
        }

        private void Clasificacion_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            ObtenerDatos();
        }

        private void LimpiarCampos()
        {
            IDClas.Clear();
            claveClas.Clear();
            descripcionClas.Clear();
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void HabilitarCampos(bool habilitar)
        {
            claveClas.Enabled = habilitar;
            descripcionClas.Enabled = habilitar;
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
            IDClas.Enabled = false; // El ID debe estar deshabilitado
        }

        // DataGridView (Cargar datos)
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
                    MessageBox.Show("Error al cargar los datos: " + ex.Message);
                }
            }
        }

        // Seleccionar filas en DataGridView
        private void dgvClasificaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvClasificacion.Rows[e.RowIndex];
                IDClas.Text = fila.Cells["IdClasificacion"].Value.ToString();
                claveClas.Text = fila.Cells["Clave"].Value.ToString();
                descripcionClas.Text = fila.Cells["Descripcion"].Value.ToString();

                if (DateTime.TryParse(fila.Cells["FecharHoraCreacion"].Value.ToString(), out DateTime fechaGuardada))
                {
                    dateTimePicker1.Value = fechaGuardada;
                    dateTimePicker2.Value = fechaGuardada;
                }
            }
        }

        // --- EVENTOS DE BOTONES ---

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarCampos();
            HabilitarCampos(true);
            claveClas.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDClas.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para editar.");
                return;
            }
            esNuevo = false;
            HabilitarCampos(true);
            claveClas.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDClas.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.");
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Desea eliminar?", "Confirmar la eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Clasificacion WHERE IdClasificacion = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(IDClas.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro eliminado correctamente");

                        LimpiarCampos();
                        DeshabilitarCampos();
                        ObtenerDatos();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar: " + ex.Message);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(claveClas.Text) || string.IsNullOrWhiteSpace(descripcionClas.Text))
            {
                MessageBox.Show("Llene los campos obligatorios (Clave y Descripción).");
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
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(IDClas.Text));
                    }

                    cmd.Parameters.AddWithValue("@Clave", claveClas.Text.Trim());
                    cmd.Parameters.AddWithValue("@Descripcion", descripcionClas.Text.Trim());
                    cmd.Parameters.AddWithValue("@FechaHora", fechaHoraCompleta);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado!");

                    LimpiarCampos();
                    DeshabilitarCampos();
                    ObtenerDatos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar: " + ex.Message);
                }
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ObtenerDatos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}