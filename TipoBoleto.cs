using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class TipoBoleto : Form
    {
        // conexion SQL
        private string conexionString = @"Server=KAROLI\DS3;Database=Cine;Trusted_Connection=True;TrustServerCertificate=True;";
        private bool esNuevo = false;

        public TipoBoleto()
        {
            InitializeComponent();

            
            this.Load += TipoBoleto_Load;

            btnNuevo.Click += btnNuevo_Click;
            btnEditar.Click += btnEditar_Click;
            btnEliminar.Click += btnEliminar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            btnSalir.Click += btnSalir_Click;

            dgvTipoBoleto.CellClick += dgvTipoBoleto_CellClick;
        }

        private void TipoBoleto_Load(object sender, EventArgs e)
        {
            DeshabilitarCampos();
            ObtenerDatos();
        }

   
        private void LimpiarCampos()
        {
            txtIdTipoBoleto.Clear();
            txtClave.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
        }

        private void HabilitarCampos(bool habilitar)
        {
            txtClave.Enabled = habilitar;
            txtDescripcion.Enabled = habilitar;
            txtPrecio.Enabled = habilitar;

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
            txtIdTipoBoleto.Enabled = false; // El ID de TipoBoleto se mantiene deshabilitado
        }


        private void ObtenerDatos()
        {
            using (SqlConnection con = new SqlConnection(conexionString))
            {
                try
                {
                    string query = "SELECT IDTipoBoleto, Clave, Descripcion, Precio FROM TipoBoleto";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvTipoBoleto.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void dgvTipoBoleto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvTipoBoleto.Rows[e.RowIndex];

                txtIdTipoBoleto.Text = fila.Cells["IDTipoBoleto"].Value?.ToString() ?? "";
                txtClave.Text = fila.Cells["Clave"].Value?.ToString() ?? "";
                txtDescripcion.Text = fila.Cells["Descripcion"].Value?.ToString() ?? "";
                txtPrecio.Text = fila.Cells["Precio"].Value?.ToString() ?? "";
            }
        }

        // --- EVENTOS DE BOTONES ---

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
            if (string.IsNullOrEmpty(txtIdTipoBoleto.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        // --- OPERACIONES: CREATE & UPDATE (Guardar) ---
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, llene todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), out decimal precio))
            {
                MessageBox.Show("El precio debe ser un número decimal válido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                        
                        string query = "INSERT INTO TipoBoleto (Clave, Descripcion, Precio) VALUES (@Clave, @Descripcion, @Precio)";
                        cmd = new SqlCommand(query, con);
                    }
                    else
                    {
                     
                        string query = "UPDATE TipoBoleto SET Clave = @Clave, Descripcion = @Descripcion, Precio = @Precio WHERE IDTipoBoleto = @Id";
                        cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdTipoBoleto.Text));
                    }

                    cmd.Parameters.AddWithValue("@Clave", txtClave.Text.Trim());
                    cmd.Parameters.AddWithValue("@Descripcion", txtDescripcion.Text.Trim());
                    cmd.Parameters.AddWithValue("@Precio", precio);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            if (string.IsNullOrEmpty(txtIdTipoBoleto.Text))
            {
                MessageBox.Show("Seleccione un registro de la tabla para eliminar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este tipo de boleto?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacion == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection(conexionString))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM TipoBoleto WHERE IDTipoBoleto = @Id";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtIdTipoBoleto.Text));

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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