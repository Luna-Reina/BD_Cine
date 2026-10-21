using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Cine
{
    public partial class CiudadEstado : Form
    {
        bool editar = false;
        bool ciudad = false;
        bool estado = false;

        public CiudadEstado()
        {
            InitializeComponent();
            obtenerDatos();
            llenarComboBoxEstado();
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
            try
            {
                dgvCiudades.SelectionChanged -= dgvCiudades_SelectionChanged;

                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string consulta = @"SELECT 
                                    C.IDCiudad AS [ID],
                                    C.NombreCiudad AS [Ciudad],
                                    C.SiglasCiudad AS [Siglas],
                                    C.ClaveCiudad AS [Clave],
                                    E.IDEstado AS [IDEstado],
                                    E.NombreEstado AS [Estado],
                                    E.SiglaEstado AS [SiglaEstado],
                                    E.ClaveEstado AS [ClaveEstado]
                                FROM dbo.Ciudad C
                                INNER JOIN dbo.Estado E ON C.IDEstado = E.IDEstado";

                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        dgvCiudades.DataSource = dt;
                    }
                }

                if (dgvCiudades.Columns["IDEstado"] != null) dgvCiudades.Columns["IDEstado"].Visible = false;
                if (dgvCiudades.Columns["SiglaEstado"] != null) dgvCiudades.Columns["SiglaEstado"].Visible = false;
                if (dgvCiudades.Columns["ClaveEstado"] != null) dgvCiudades.Columns["ClaveEstado"].Visible = false;

                dgvCiudades.ClearSelection();
                limpiarTodo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            }
        }

        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCiudades.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvCiudades.SelectedRows[0];

                txtIdCiudad.Text = row.Cells["ID"].Value?.ToString();
                txtNombreCiudad.Text = row.Cells["Ciudad"].Value?.ToString();
                txtClaveCiudad.Text = row.Cells["Clave"].Value?.ToString();

                // Seleccionamos el estado según el nombre de la columna "Estado" del DataGridView
                cmbEstado.Text = row.Cells["Estado"].Value?.ToString();

                txtIdEstado.Text = row.Cells["IDEstado"].Value?.ToString();
                txtNombreEstado.Text = row.Cells["Estado"].Value?.ToString();
                txtSiglasEstado.Text = row.Cells["SiglaEstado"].Value?.ToString();
                txtClaveEstado.Text = row.Cells["ClaveEstado"].Value?.ToString();
            }
        }

        public void reestablecerBotones()
        {
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            btnEditar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            txtNombreCiudad.Enabled = false;
            txtClaveCiudad.Enabled = false;
            cmbEstado.Enabled = false;

            this.editar = false;
            this.ciudad = false;
            this.estado = false;

            txtClaveEstado.Enabled = false;
            txtSiglasEstado.Enabled = false;
            txtNombreEstado.Enabled = false;
        }

        public void limpiarTodo()
        {
            txtIdEstado.Text = string.Empty;
            txtIdCiudad.Text = string.Empty;
            txtClaveEstado.Text = string.Empty;
            txtClaveCiudad.Text = string.Empty;
            txtNombreCiudad.Text = string.Empty;
            txtNombreEstado.Text = string.Empty;
            txtSiglasEstado.Text = string.Empty;
            cmbEstado.SelectedIndex = -1;
        }

        public void habilitarCiudad()
        {
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtNombreCiudad.Enabled = true;
            txtClaveCiudad.Enabled = true;
            cmbEstado.Enabled = true;

            this.ciudad = true;
        }

        public void habilitarEstado()
        {
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = false;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtClaveEstado.Enabled = true;
            txtSiglasEstado.Enabled = true;
            txtNombreEstado.Enabled = true;

            this.estado = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Seguro que desea cancelar la consulta", "Confirmacion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
            {
                return;
            }

            reestablecerBotones();
            limpiarTodo();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea rellenar una Ciudad?", "¿Ciudad?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                limpiarTodo();
                reestablecerBotones();
                habilitarCiudad();
                return;
            }
            if (MessageBox.Show("¿Desea rellenar un Estado?", "¿Estado?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                limpiarTodo();
                reestablecerBotones();
                habilitarEstado();
                return;
            }

            MessageBox.Show("No hubo selección, se cancela nuevo registro", "Cancelacion", MessageBoxButtons.OK);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea editar \"Ciudad\"?", "¿Ciudad?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                habilitarCiudad();
                return;
            }
            if (MessageBox.Show("¿Desea editar \"Estado\"?", "¿Estado?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                habilitarEstado();
                return;
            }
            MessageBox.Show("Debe de elegir editar ciudad o estado", "Cancelación", MessageBoxButtons.OK);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.ciudad)
            {
                if (string.IsNullOrWhiteSpace(txtNombreCiudad.Text) || cmbEstado.SelectedIndex == -1)
                {
                    MessageBox.Show("Por favor, ingrese el nombre de la ciudad y seleccione un Estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int.TryParse(txtClaveCiudad.Text.Trim(), out int claveCiudadNum); //se asegura de que sea un int

                try
                {
                    using (SqlConnection conn = new Conexion().ObtenerConexion())
                    {
                        conn.Open();
                        string query = "";

                        if (!this.editar)//nuevo registro
                        {
                            query = @"INSERT INTO dbo.Ciudad (IDEstado, SiglasCiudad, ClaveCiudad, NombreCiudad) 
                              VALUES (@IDEstado, @Siglas, @Clave, @Nombre)";
                        }
                        else//Update
                        {
                            query = @"UPDATE dbo.Ciudad 
                              SET IDEstado = @IDEstado, 
                                  SiglasCiudad = @Siglas, 
                                  ClaveCiudad = @Clave, 
                                  NombreCiudad = @Nombre 
                              WHERE IDCiudad = @IDCiudad";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@IDEstado", cmbEstado.SelectedValue);

                            string siglas = txtNombreCiudad.Text.Trim().Length >= 3
                                ? txtNombreCiudad.Text.Trim().Substring(0, 3).ToUpper()
                                : txtNombreCiudad.Text.Trim().ToUpper(); //se me olvido poner un txtsiglasCiudad y ya se me hizo más facil buscar como poner siglas automaticas

                            cmd.Parameters.AddWithValue("@Siglas", siglas);
                            cmd.Parameters.AddWithValue("@Clave", claveCiudadNum);
                            cmd.Parameters.AddWithValue("@Nombre", txtNombreCiudad.Text.Trim());

                            if (this.editar)
                            {
                                cmd.Parameters.AddWithValue("@IDCiudad", Convert.ToInt32(txtIdCiudad.Text));
                            }

                            int renglonesAfectados = cmd.ExecuteNonQuery();

                            if (renglonesAfectados > 0)
                            {
                                string msj = this.editar ? "Ciudad actualizada correctamente." : "Ciudad registrada correctamente.";
                                MessageBox.Show(msj, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar la Ciudad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    obtenerDatos();
                    reestablecerBotones();
                    limpiarTodo();
                }
            }
            else if (this.estado)
            {
                if (string.IsNullOrWhiteSpace(txtNombreEstado.Text))
                {
                    MessageBox.Show("Por favor, ingrese el nombre del Estado.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int.TryParse(txtClaveEstado.Text.Trim(), out int claveEstadoNum);

                try
                {
                    using (SqlConnection conn = new Conexion().ObtenerConexion())
                    {
                        conn.Open();
                        string query = "";

                        if (!this.editar)//nuevo registro
                        {
                            query = @"INSERT INTO dbo.Estado (NombreEstado, SiglaEstado, ClaveEstado) 
                              VALUES (@Nombre, @Sigla, @Clave)";
                        }
                        else//update
                        {
                            query = @"UPDATE dbo.Estado 
                              SET NombreEstado = @Nombre, 
                                  SiglaEstado = @Sigla, 
                                  ClaveEstado = @Clave 
                              WHERE IDEstado = @IDEstado";
                        }

                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Nombre", txtNombreEstado.Text.Trim());
                            cmd.Parameters.AddWithValue("@Sigla", txtSiglasEstado.Text.Trim().ToUpper());
                            cmd.Parameters.AddWithValue("@Clave", claveEstadoNum);

                            if (this.editar)
                            {
                                cmd.Parameters.AddWithValue("@IDEstado", Convert.ToInt32(txtIdEstado.Text));
                            }

                            int renglonesAfectados = cmd.ExecuteNonQuery();

                            if (renglonesAfectados > 0)
                            {
                                string msj = this.editar ? "Estado actualizado correctamente." : "Estado registrado correctamente.";
                                MessageBox.Show(msj, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar el Estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    llenarComboBoxEstado(); // Refresca el ComboBox por si se agregó/editó un Estado
                    obtenerDatos();
                    reestablecerBotones();
                    limpiarTodo();
                }
            }
        }

        public void llenarComboBoxEstado()
        {
            try
            {
                cmbEstado.DataSource = null;
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    String query = "SELECT IDEstado, NombreEstado FROM dbo.Estado";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dt);
                        }
                        cmbEstado.DataSource = dt;
                        cmbEstado.ValueMember = "IDEstado";
                        cmbEstado.DisplayMember = "NombreEstado";
                        cmbEstado.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo llenar debido a error: " + e.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult opcion = MessageBox.Show(
                "¿Desea eliminar la CIUDAD seleccionada?\n\n(Haga clic en 'Sí' para Ciudad, 'No' para intentar eliminar Estado)",
                "Confirmar Eliminación",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question);

            if (opcion == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtIdCiudad.Text))
                {
                    MessageBox.Show("Por favor, seleccione una ciudad de la lista para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult confirmar = MessageBox.Show(
                    $"¿Está seguro de eliminar la ciudad '{txtNombreCiudad.Text}'?",
                    "Atención",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmar == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new Conexion().ObtenerConexion())
                        {
                            conn.Open();
                            string query = "DELETE FROM dbo.Ciudad WHERE IDCiudad = @IDCiudad";

                            using (SqlCommand cmd = new SqlCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@IDCiudad", Convert.ToInt32(txtIdCiudad.Text));

                                int lineasAfectadas = cmd.ExecuteNonQuery();

                                if (lineasAfectadas > 0)
                                {
                                    MessageBox.Show("Ciudad eliminada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        // Manejo de errores por relaciones con otras tablas (Clave Foránea)
                        if (ex.Number == 547)
                        {
                            MessageBox.Show("No se puede eliminar la ciudad porque está relacionada con otros registros (ej. cines o direcciones).", "Conflicto de Integridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        }
                        else
                        {
                            MessageBox.Show("Error al eliminar la ciudad: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    finally
                    {
                        obtenerDatos();
                        reestablecerBotones();
                        limpiarTodo();
                    }
                }
            }
            else if (opcion == DialogResult.No)
            {
                DialogResult opcionEstado = MessageBox.Show(
                    "¿Desea eliminar el ESTADO seleccionado?",
                    "Confirmar Eliminación de Estado",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (opcionEstado == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtIdEstado.Text))
                    {
                        MessageBox.Show("Por favor, seleccione un registro para obtener el ID del estado a eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    DialogResult confirmar = MessageBox.Show(
                        $"¿Está seguro de eliminar el estado '{txtNombreEstado.Text}'?\n\nNOTA: Si el estado tiene ciudades vinculadas, SQL Server no permitirá eliminarlo.",
                        "Atención",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning);

                    if (confirmar == DialogResult.Yes)
                    {
                        try
                        {
                            using (SqlConnection conn = new Conexion().ObtenerConexion())
                            {
                                conn.Open();
                                string query = "DELETE FROM dbo.Estado WHERE IDEstado = @IDEstado";

                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@IDEstado", Convert.ToInt32(txtIdEstado.Text));

                                    int lineasAfectadas = cmd.ExecuteNonQuery();

                                    if (lineasAfectadas > 0)
                                    {
                                        MessageBox.Show("Estado eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                }
                            }
                        }
                        catch (SqlException ex)
                        {
                            // Manejo del error 547: Foreign Key constraint info dada por gemini
                            if (ex.Number == 547)
                            {
                                MessageBox.Show("No se puede eliminar el estado porque existen ciudades registradas que dependen de él.", "Conflicto de Integridad", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                            else
                            {
                                MessageBox.Show("Error al eliminar el estado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        finally
                        {
                            llenarComboBoxEstado();
                            obtenerDatos();
                            reestablecerBotones();
                            limpiarTodo();
                        }
                    }
                }
            }
        }
    }
}
