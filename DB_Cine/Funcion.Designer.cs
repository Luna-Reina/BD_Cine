namespace DB_Cine
{
    partial class Funcion
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Funcion));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtIDFuncion = new TextBox();
            dgvFuncion = new DataGridView();
            label4 = new Label();
            txtIDPelicula = new TextBox();
            label5 = new Label();
            txtIDSala = new TextBox();
            dtFecha = new DateTimePicker();
            timer1 = new System.Windows.Forms.Timer(components);
            dtHora = new DateTimePicker();
            toolStrip2 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtener = new ToolStripButton();
            btnSalir = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).BeginInit();
            toolStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(461, 366);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 29;
            label3.Text = "Hora";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 410);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 28;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 366);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 27;
            label1.Text = "ID Función";
            // 
            // txtIDFuncion
            // 
            txtIDFuncion.Location = new Point(92, 362);
            txtIDFuncion.Margin = new Padding(3, 2, 3, 2);
            txtIDFuncion.Name = "txtIDFuncion";
            txtIDFuncion.ReadOnly = true;
            txtIDFuncion.Size = new Size(133, 23);
            txtIDFuncion.TabIndex = 25;
            // 
            // dgvFuncion
            // 
            dgvFuncion.AllowUserToAddRows = false;
            dgvFuncion.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvFuncion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvFuncion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvFuncion.DefaultCellStyle = dataGridViewCellStyle5;
            dgvFuncion.Location = new Point(28, 45);
            dgvFuncion.Margin = new Padding(3, 2, 3, 2);
            dgvFuncion.Name = "dgvFuncion";
            dgvFuncion.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dgvFuncion.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dgvFuncion.RowHeadersWidth = 51;
            dgvFuncion.Size = new Size(652, 294);
            dgvFuncion.TabIndex = 24;
            dgvFuncion.CellContentClick += dgvFuncion_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 410);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 32;
            label4.Text = "ID Película";
            // 
            // txtIDPelicula
            // 
            txtIDPelicula.Location = new Point(92, 406);
            txtIDPelicula.Margin = new Padding(3, 2, 3, 2);
            txtIDPelicula.Name = "txtIDPelicula";
            txtIDPelicula.ReadOnly = true;
            txtIDPelicula.Size = new Size(133, 23);
            txtIDPelicula.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(253, 365);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 34;
            label5.Text = "ID Sala";
            // 
            // txtIDSala
            // 
            txtIDSala.Location = new Point(310, 362);
            txtIDSala.Margin = new Padding(3, 2, 3, 2);
            txtIDSala.Name = "txtIDSala";
            txtIDSala.ReadOnly = true;
            txtIDSala.Size = new Size(133, 23);
            txtIDSala.TabIndex = 33;
            // 
            // dtFecha
            // 
            dtFecha.Format = DateTimePickerFormat.Short;
            dtFecha.Location = new Point(310, 404);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(133, 23);
            dtFecha.TabIndex = 35;
            // 
            // dtHora
            // 
            dtHora.Format = DateTimePickerFormat.Time;
            dtHora.Location = new Point(511, 362);
            dtHora.Name = "dtHora";
            dtHora.Size = new Size(133, 23);
            dtHora.TabIndex = 36;
            // 
            // toolStrip2
            // 
            toolStrip2.ImageScalingSize = new Size(20, 20);
            toolStrip2.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtener, btnSalir });
            toolStrip2.Location = new Point(0, 0);
            toolStrip2.Name = "toolStrip2";
            toolStrip2.Size = new Size(729, 27);
            toolStrip2.TabIndex = 37;
            toolStrip2.Text = "toolStrip2";
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
            btnEliminar.Click += btnEliminar_Click;
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
            // btnObtener
            // 
            btnObtener.Image = (Image)resources.GetObject("btnObtener.Image");
            btnObtener.ImageTransparentColor = Color.Magenta;
            btnObtener.Name = "btnObtener";
            btnObtener.Size = new Size(107, 24);
            btnObtener.Text = "Obtener Datos";
            btnObtener.Click += btnObtener_Click;
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
            // Funcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 423);
            Controls.Add(toolStrip2);
            Controls.Add(dtHora);
            Controls.Add(dtFecha);
            Controls.Add(label5);
            Controls.Add(txtIDSala);
            Controls.Add(label4);
            Controls.Add(txtIDPelicula);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtIDFuncion);
            Controls.Add(dgvFuncion);
            Name = "Funcion";
            Text = "☆ Funcion";
            ((System.ComponentModel.ISupportInitialize)dgvFuncion).EndInit();
            toolStrip2.ResumeLayout(false);
            toolStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtIDFuncion;
        private DataGridView dgvFuncion;
        private Label label4;
        private TextBox txtIDPelicula;
        private Label label5;
        private TextBox txtIDSala;
        private DateTimePicker dtFecha;
        private System.Windows.Forms.Timer timer1;
        private DateTimePicker dtHora;
        private ToolStrip toolStrip2;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnObtener;
        private ToolStripButton btnSalir;
    }
}