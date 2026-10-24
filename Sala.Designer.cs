namespace DB_Cine
{
    partial class Sala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sala));
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtenerDatos = new ToolStripButton();
            btnSalir = new ToolStripButton();
            dgvSala = new DataGridView();
            txtTipoSala = new TextBox();
            txtNumeroSala = new TextBox();
            txtIdSala = new TextBox();
            cmbSucursal = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            txtAsientos = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSala).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(729, 27);
            toolStrip1.TabIndex = 1;
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
            // dgvSala
            // 
            dgvSala.AllowUserToAddRows = false;
            dgvSala.AllowUserToDeleteRows = false;
            dgvSala.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSala.Location = new Point(26, 37);
            dgvSala.Name = "dgvSala";
            dgvSala.ReadOnly = true;
            dgvSala.Size = new Size(678, 227);
            dgvSala.TabIndex = 2;
            dgvSala.SelectionChanged += dgvSala_SelectionChanged;
            // 
            // txtTipoSala
            // 
            txtTipoSala.Enabled = false;
            txtTipoSala.Location = new Point(428, 282);
            txtTipoSala.Margin = new Padding(3, 2, 3, 2);
            txtTipoSala.Name = "txtTipoSala";
            txtTipoSala.Size = new Size(110, 23);
            txtTipoSala.TabIndex = 25;
            // 
            // txtNumeroSala
            // 
            txtNumeroSala.Enabled = false;
            txtNumeroSala.Location = new Point(139, 375);
            txtNumeroSala.Margin = new Padding(3, 2, 3, 2);
            txtNumeroSala.Name = "txtNumeroSala";
            txtNumeroSala.Size = new Size(110, 23);
            txtNumeroSala.TabIndex = 24;
            // 
            // txtIdSala
            // 
            txtIdSala.Location = new Point(139, 294);
            txtIdSala.Margin = new Padding(3, 2, 3, 2);
            txtIdSala.Name = "txtIdSala";
            txtIdSala.ReadOnly = true;
            txtIdSala.Size = new Size(120, 23);
            txtIdSala.TabIndex = 23;
            // 
            // cmbSucursal
            // 
            cmbSucursal.Enabled = false;
            cmbSucursal.FormattingEnabled = true;
            cmbSucursal.Location = new Point(139, 337);
            cmbSucursal.Margin = new Padding(3, 2, 3, 2);
            cmbSucursal.Name = "cmbSucursal";
            cmbSucursal.Size = new Size(133, 23);
            cmbSucursal.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(316, 285);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 21;
            label8.Text = "Tipo de Sala";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 377);
            label7.Name = "label7";
            label7.Size = new Size(75, 15);
            label7.TabIndex = 20;
            label7.Text = "Numero Sala";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 334);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 19;
            label6.Text = "Sucursal";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 295);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 18;
            label5.Text = "Id Sala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(318, 317);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 26;
            label1.Text = "Numero de Asientos";
            // 
            // txtAsientos
            // 
            txtAsientos.Enabled = false;
            txtAsientos.Location = new Point(448, 310);
            txtAsientos.Name = "txtAsientos";
            txtAsientos.Size = new Size(100, 23);
            txtAsientos.TabIndex = 27;
            // 
            // Sala
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 423);
            Controls.Add(txtAsientos);
            Controls.Add(label1);
            Controls.Add(txtTipoSala);
            Controls.Add(txtNumeroSala);
            Controls.Add(txtIdSala);
            Controls.Add(cmbSucursal);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(dgvSala);
            Controls.Add(toolStrip1);
            Name = "Sala";
            Text = "Sala";
            Load += Sala_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSala).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnObtenerDatos;
        private ToolStripButton btnSalir;
        private DataGridView dgvSala;
        private TextBox txtTipoSala;
        private TextBox txtNumeroSala;
        private TextBox txtIdSala;
        private ComboBox cmbSucursal;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox txtAsientos;
    }
}