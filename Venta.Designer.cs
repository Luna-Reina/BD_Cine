namespace DB_Cine
{
    partial class Venta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Venta));
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtenerDatos = new ToolStripButton();
            btnSalir = new ToolStripButton();
            dgvVenta = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCliente = new ComboBox();
            cmbFuncion = new ComboBox();
            cmbBoleto = new ComboBox();
            txtIDVenta = new TextBox();
            txtPrecio = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(729, 27);
            toolStrip1.TabIndex = 2;
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
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Image = (Image)resources.GetObject("btnObtenerDatos.Image");
            btnObtenerDatos.ImageTransparentColor = Color.Magenta;
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(107, 24);
            btnObtenerDatos.Text = "Obtener Datos";
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
            // dgvVenta
            // 
            dgvVenta.AllowUserToAddRows = false;
            dgvVenta.AllowUserToDeleteRows = false;
            dgvVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVenta.Location = new Point(12, 30);
            dgvVenta.Name = "dgvVenta";
            dgvVenta.ReadOnly = true;
            dgvVenta.Size = new Size(776, 227);
            dgvVenta.TabIndex = 3;
            dgvVenta.SelectionChanged += dgvVenta_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 301);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "IDVenta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 328);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 5;
            label2.Text = "Cliente";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 359);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 6;
            label3.Text = "Función";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 389);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 7;
            label4.Text = "Boleto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(306, 301);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(385, 306);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 9;
            label6.Text = "Precio";
            // 
            // cmbCliente
            // 
            cmbCliente.Enabled = false;
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(85, 329);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 10;
            // 
            // cmbFuncion
            // 
            cmbFuncion.Enabled = false;
            cmbFuncion.FormattingEnabled = true;
            cmbFuncion.Location = new Point(85, 356);
            cmbFuncion.Name = "cmbFuncion";
            cmbFuncion.Size = new Size(121, 23);
            cmbFuncion.TabIndex = 11;
            // 
            // cmbBoleto
            // 
            cmbBoleto.Enabled = false;
            cmbBoleto.FormattingEnabled = true;
            cmbBoleto.Location = new Point(85, 389);
            cmbBoleto.Name = "cmbBoleto";
            cmbBoleto.Size = new Size(121, 23);
            cmbBoleto.TabIndex = 12;
            // 
            // txtIDVenta
            // 
            txtIDVenta.Location = new Point(85, 297);
            txtIDVenta.Name = "txtIDVenta";
            txtIDVenta.ReadOnly = true;
            txtIDVenta.Size = new Size(100, 23);
            txtIDVenta.TabIndex = 13;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(440, 301);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.ReadOnly = true;
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 14;
            // 
            // Venta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 423);
            Controls.Add(txtPrecio);
            Controls.Add(txtIDVenta);
            Controls.Add(cmbBoleto);
            Controls.Add(cmbFuncion);
            Controls.Add(cmbCliente);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvVenta);
            Controls.Add(toolStrip1);
            Name = "Venta";
            Text = "☆ Venta";
            Load += Venta_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvVenta).EndInit();
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
        private DataGridView dgvVenta;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCliente;
        private ComboBox cmbFuncion;
        private ComboBox cmbBoleto;
        private TextBox txtIDVenta;
        private TextBox txtPrecio;
    }
}