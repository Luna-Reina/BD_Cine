using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class Sucursal : Form
    {
        private string conexionString = @"Server=KAROLI\DS3;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool esNuevo = false;

        public Sucursal()
        {
            InitializeComponent();
            // Enlazar evento de carga del formulario
            this.Load += Sucursal_Load;

            // Enlazar eventos de clic para cada botón
            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            btnSalir.Click += btnSalir_Click;

            // Enlazar selección de filas en la tabla
            dgvSucursal.CellClick += dgvSucursal_CellClick;
        }

        private void Sucursal_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            ObtenerDatos();
        }

        private void LimpiarCampos()
        {
            txtIdSucursal.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtIdCiudad.Clear();
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtNombre.Enabled = habilitar;
            txtDireccion.Enabled = habilitar;
            txtIdCiudad.Enabled = habilitar;

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
            txtIdSucursal.Enabled = false;
        }

        private void ObtenerDatos()
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    string query = "SELECT IDSucursal, Nombre, Direccion, IDCiudad FROM Sucursal";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvSucursal.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvSucursal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvSucursal.Rows[e.RowIndex];
                txtIdSucursal.Text = fila.Cells["IDSucursal"].Value?.ToString() ?? "";
                txtNombre.Text = fila.Cells["Nombre"].Value?.ToString() ?? "";
                txtDireccion.Text = fila.Cells["Direccion"].Value?.ToString() ?? "";
                txtIdCiudad.Text = fila.Cells["IDCiudad"].Value?.ToString() ?? "";
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e) => ObtenerDatos();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            esNuevo = true;
            LimpiarCampos();
            HabilitarCampos(true);
            txtNombre.Focus();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtIdSucursal.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            esNuevo = false;
            HabilitarCampos(true);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            DeshabilitarCampos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtIdCiudad.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtIdCiudad.Text.Trim(), out int idCiudad))
            {
                MessageBox.Show("El ID de la Ciudad debe ser un número entero válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd;

                    if (esNuevo)
                    {
                        string query = "INSERT INTO Sucursal (Nombre, Direccion, IDCiudad) VALUES (@Nombre, @Direccion, @IDCiudad)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                        string query = "UPDATE Sucursal SET Nombre = @Nombre, Direccion = @Direccion, IDCiudad = @IDCiudad WHERE IDSucursal = @Id";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdSucursal.Text));
                    }

                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text.Trim());
                    cmd.Parameters.AddWithValue("@IDCiudad", idCiudad);

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
            if (string.IsNullOrEmpty(txtIdSucursal.Text))
            {
                MessageBox.Show("Seleccione un registro para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar esta sucursal?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Sucursal WHERE IDSucursal = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdSucursal.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void btnSalir_Click(object sender, EventArgs e) => this.Close();
    }
}