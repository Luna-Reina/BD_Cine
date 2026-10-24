using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DB_Cine
{
    public partial class Pelicula : Form
    {
        bool editar = false;
        public Pelicula()
        {
            InitializeComponent();
            obtenerDatos();
            llenarComboBoxGenero();
            llenarComboBoxClasificacion();
            reestablecerBotones();
        }

        //Clear the text fields and reset the ComboBox selections
        public void Limpiar()
        {
            txtNombrePelicula.Text = "";
            txtDuracion.Text = "";
            txtIDPelicula.Text = "";
            cbGenero.SelectedIndex = -1;
            cbClasificacion.SelectedIndex = -1;
        }

        //Reset the buttons to their default state and disable the text fields and ComboBoxes
        public void reestablecerBotones()
        {
            dgvPeliculas.Enabled = true;

            dgvPeliculas.SelectionChanged -= dgvPeliculas_SelectionChanged;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;

            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

            this.editar = false;

            txtDuracion.Enabled = false;
            txtNombrePelicula.Enabled = false;
            cbGenero.Enabled = false;
            cbClasificacion.Enabled = false;
        }

        //Enable the text fields and ComboBoxes for editing and disable the buttons (Nuevo, Editar, Eliminar)
        public void habilitarEscribir()
        {
            dgvPeliculas.Enabled = false;

            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            txtDuracion.Enabled = true;
            txtNombrePelicula.Enabled = true;
            cbGenero.Enabled = true;
            cbClasificacion.Enabled = true;

        }

        //Prepare the text fields and ComboBoxes for a new record entry
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.editar = false;
            Limpiar();
            habilitarEscribir();
        }

        //Reset everything to its default settings and clear the text fields and Comboboxes.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de cancelar la operación?",
                "Cancelar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                reestablecerBotones();
                Limpiar();
            }
        }

        //Close the current Windows
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Method used to fill the DGV with data from de database.
        public void obtenerDatos()
        {
            try
            {
                dgvPeliculas.SelectionChanged -= dgvPeliculas_SelectionChanged;
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string consulta = "SELECT P.IDPelicula AS [ID]," +
                        "P.NombrePelicula AS [Película], P.Duracion AS [Duración (min)], G.NombreGenero AS [Género]," +
                        "C.Clave AS [Clasificación]\r\n  FROM dbo.Pelicula P\r\n  " +
                        "INNER JOIN Genero G ON P.IDGenero = G.IDGenero\r\n  " +
                        "INNER JOIN Clasificacion C ON P.IDClasificacion = C.IDClasificacion";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        DataTable dtPelicula = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtPelicula);
                        }
                        dgvPeliculas.DataSource = dtPelicula;
                    }

                }
                dgvPeliculas.ClearSelection();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener los datos: " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            }
        }

        /*method used to fill CMB Genero with data from the database
        it save the value member as the id and the display member as the name of the genre 
        */
        public void llenarComboBoxGenero()
        {
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string consulta = "SELECT IDGenero, NombreGenero FROM Genero";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        DataTable dtGenero = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtGenero);
                        }
                        cbGenero.DataSource = dtGenero;
                        cbGenero.DisplayMember = "NombreGenero";
                        cbGenero.ValueMember = "IDGenero";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de Género: " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Fill the combobox Clasificacion in the same way as LlenarComboBoxGenero does with cbGenero
        public void llenarComboBoxClasificacion()
        {
            try
            {
                using (SqlConnection conn = new Conexion().ObtenerConexion())
                {
                    conn.Open();
                    string consulta = "SELECT IDClasificacion, Clave FROM Clasificacion";
                    using (SqlCommand cmd = new SqlCommand(consulta, conn))
                    {
                        DataTable dtClaficacion = new DataTable();
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            da.Fill(dtClaficacion);
                        }
                        cbClasificacion.DataSource = dtClaficacion;
                        cbClasificacion.ValueMember = "IDClasificacion";
                        cbClasificacion.DisplayMember = "Clave";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al llenar el ComboBox de Clasificación: " +
                    ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            obtenerDatos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count != 1) {
                MessageBox.Show("Debe de tener un renglón seleccionado, uno y solo uno");
                return;
            }
            this.editar = true;
            habilitarEscribir();
        }

        private void dgvPeliculas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPeliculas.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvPeliculas.SelectedRows[0];

                txtIDPelicula.Text = row.Cells["ID"].Value?.ToString();
                txtNombrePelicula.Text = row.Cells["Película"].Value?.ToString();
                txtDuracion.Text = row.Cells["Duración (min)"].Value?.ToString();
                cbGenero.Text = row.Cells["Género"].Value?.ToString();
                cbClasificacion.Text = row.Cells["Clasificación"].Value?.ToString();
            }

        }

        //method to save or update the record in the database
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!this.editar)
            {
                try
                {
                    using (SqlConnection conn = new Conexion().ObtenerConexion())
                    {
                        conn.Open();
                        string query = "INSERT INTO Pelicula(NombrePelicula, Duracion, IDGenero, IDClasificacion) " +
                            "VALUES (@NombrePelicula, @Duracion, @IDGenero, @IDClasificacion)";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@NombrePelicula", txtNombrePelicula.Text);
                            cmd.Parameters.AddWithValue("@Duracion", txtDuracion.Text);
                            cmd.Parameters.AddWithValue("@IDGenero", cbGenero.SelectedValue);
                            cmd.Parameters.AddWithValue("@IDClasificacion", cbClasificacion.SelectedValue);
                            int renglonesAfectados = cmd.ExecuteNonQuery();
                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al guardar los datos: " +
                        ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reestablecerBotones();
                    Limpiar();
                    obtenerDatos();
                }
            }//close new record
            if (this.editar)
            {
                try
                {
                    using (SqlConnection conn = new Conexion().ObtenerConexion())
                    {
                        conn.Open();
                        string query = "UPDATE Pelicula SET NombrePelicula = @NombrePelicula, Duracion = @Duracion, " +
                            "IDGenero = @IDGenero, IDClasificacion = @IDClasificacion WHERE IDPelicula = @IDPelicula";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@NombrePelicula", txtNombrePelicula.Text);
                            cmd.Parameters.AddWithValue("@Duracion", txtDuracion.Text);
                            cmd.Parameters.AddWithValue("@IDGenero", cbGenero.SelectedValue);
                            cmd.Parameters.AddWithValue("@IDClasificacion", cbClasificacion.SelectedValue);
                            cmd.Parameters.AddWithValue("@IDPelicula", txtIDPelicula.Text);
                            int renglonesAfectados = cmd.ExecuteNonQuery();
                            if (renglonesAfectados > 0)
                            {
                                MessageBox.Show("Registro actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("No se pudo actualizar el registro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar los datos: " +
                        ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    reestablecerBotones();
                    Limpiar();
                    obtenerDatos();
                }
            }//close edit record
        }

        private void Pelicula_Load(object sender, EventArgs e)
        {

        }

        private void txtIDPelicula_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbClasificacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}