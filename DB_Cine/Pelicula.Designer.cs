namespace DB_Cine
{
    partial class Pelicula
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pelicula));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtenerDatos = new ToolStripButton();
            btnSalir = new ToolStripButton();
            dgvPeliculas = new DataGridView();
            txtIDPelicula = new TextBox();
            txtNombrePelicula = new TextBox();
            txtDuracion = new TextBox();
            cbGenero = new ComboBox();
            cbClasificacion = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(738, 27);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(66, 24);
            btnNuevo.Text = "Nuevo";
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(61, 24);
            btnEditar.Text = "Editar";
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(74, 24);
            btnEliminar.Text = "Eliminar";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(77, 24);
            btnCancelar.Text = "Cancelar";
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(73, 24);
            btnGuardar.Text = "Guardar";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Image = (Image)resources.GetObject("btnObtenerDatos.Image");
            btnObtenerDatos.ImageTransparentColor = Color.Magenta;
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(107, 24);
            btnObtenerDatos.Text = "Obtener Datos";
            btnObtenerDatos.Click += btnObtenerDatos_Click;
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageTransparentColor = Color.Magenta;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(53, 24);
            btnSalir.Text = "Salir";
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvPeliculas
            // 
            dgvPeliculas.AllowUserToAddRows = false;
            dgvPeliculas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPeliculas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPeliculas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPeliculas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPeliculas.Location = new Point(17, 39);
            dgvPeliculas.Margin = new Padding(3, 2, 3, 2);
            dgvPeliculas.Name = "dgvPeliculas";
            dgvPeliculas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPeliculas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPeliculas.RowHeadersWidth = 51;
            dgvPeliculas.Size = new Size(693, 252);
            dgvPeliculas.TabIndex = 1;
            dgvPeliculas.SelectionChanged += dgvPeliculas_SelectionChanged;
            // 
            // txtIDPelicula
            // 
            txtIDPelicula.Location = new Point(101, 319);
            txtIDPelicula.Margin = new Padding(3, 2, 3, 2);
            txtIDPelicula.Name = "txtIDPelicula";
            txtIDPelicula.ReadOnly = true;
            txtIDPelicula.Size = new Size(133, 23);
            txtIDPelicula.TabIndex = 2;
            txtIDPelicula.TextChanged += txtIDPelicula_TextChanged;
            // 
            // txtNombrePelicula
            // 
            txtNombrePelicula.Enabled = false;
            txtNombrePelicula.Location = new Point(101, 359);
            txtNombrePelicula.Margin = new Padding(3, 2, 3, 2);
            txtNombrePelicula.Name = "txtNombrePelicula";
            txtNombrePelicula.Size = new Size(133, 23);
            txtNombrePelicula.TabIndex = 3;
            txtNombrePelicula.TextChanged += this.txtNombrePelicula_TextChanged;
            // 
            // txtDuracion
            // 
            txtDuracion.Enabled = false;
            txtDuracion.Location = new Point(330, 320);
            txtDuracion.Margin = new Padding(3, 2, 3, 2);
            txtDuracion.Name = "txtDuracion";
            txtDuracion.Size = new Size(133, 23);
            txtDuracion.TabIndex = 4;
            // 
            // cbGenero
            // 
            cbGenero.Enabled = false;
            cbGenero.FormattingEnabled = true;
            cbGenero.Location = new Point(330, 359);
            cbGenero.Margin = new Padding(3, 2, 3, 2);
            cbGenero.Name = "cbGenero";
            cbGenero.Size = new Size(133, 23);
            cbGenero.TabIndex = 5;
            // 
            // cbClasificacion
            // 
            cbClasificacion.Enabled = false;
            cbClasificacion.FormattingEnabled = true;
            cbClasificacion.Location = new Point(577, 356);
            cbClasificacion.Margin = new Padding(3, 2, 3, 2);
            cbClasificacion.Name = "cbClasificacion";
            cbClasificacion.Size = new Size(133, 23);
            cbClasificacion.TabIndex = 6;
            cbClasificacion.SelectedIndexChanged += cbClasificacion_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 323);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 7;
            label1.Text = "ID Película";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 362);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 320);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 9;
            label3.Text = "Duración";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(258, 359);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Género";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(488, 359);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 11;
            label5.Text = "Clasificación";
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(738, 414);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbClasificacion);
            Controls.Add(cbGenero);
            Controls.Add(txtDuracion);
            Controls.Add(txtNombrePelicula);
            Controls.Add(txtIDPelicula);
            Controls.Add(dgvPeliculas);
            Controls.Add(toolStrip1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Pelicula";
            Text = "Pelicula";
            Load += Pelicula_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPeliculas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnEditar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnObtenerDatos;
        private ToolStripButton btnSalir;
        private DataGridView dgvPeliculas;
        private TextBox txtIDPelicula;
        private TextBox txtNombrePelicula;
        private TextBox txtDuracion;
        private ComboBox cbGenero;
        private ComboBox cbClasificacion;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}