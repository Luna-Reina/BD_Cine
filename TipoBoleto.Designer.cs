namespace DB_Cine
{
    partial class TipoBoleto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipoBoleto));
            dgvTipoBoleto = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtenerDatos = new ToolStripButton();
            btnSalir = new ToolStripButton();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            txtIdTipoBoleto = new TextBox();
            txtClave = new TextBox();
            txtDescripcion = new TextBox();
            txtPrecio = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvTipoBoleto).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvTipoBoleto
            // 
            dgvTipoBoleto.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoBoleto.Location = new Point(43, 88);
            dgvTipoBoleto.Name = "dgvTipoBoleto";
            dgvTipoBoleto.RowHeadersWidth = 62;
            dgvTipoBoleto.Size = new Size(675, 339);
            dgvTipoBoleto.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(921, 34);
            toolStrip1.TabIndex = 15;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.ImageTransparentColor = Color.Magenta;
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(88, 29);
            btnNuevo.Text = "Nuevo";
            // 
            // btnEditar
            // 
            btnEditar.Image = (Image)resources.GetObject("btnEditar.Image");
            btnEditar.ImageTransparentColor = Color.Magenta;
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(81, 29);
            btnEditar.Text = "Editar";
            // 
            // btnEliminar
            // 
            btnEliminar.Image = (Image)resources.GetObject("btnEliminar.Image");
            btnEliminar.ImageTransparentColor = Color.Magenta;
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(98, 29);
            btnEliminar.Text = "Eliminar";
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageTransparentColor = Color.Magenta;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(102, 29);
            btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            btnGuardar.Enabled = false;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageTransparentColor = Color.Magenta;
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(99, 29);
            btnGuardar.Text = "Guardar";
            // 
            // btnObtenerDatos
            // 
            btnObtenerDatos.Image = (Image)resources.GetObject("btnObtenerDatos.Image");
            btnObtenerDatos.ImageTransparentColor = Color.Magenta;
            btnObtenerDatos.Name = "btnObtenerDatos";
            btnObtenerDatos.Size = new Size(153, 29);
            btnObtenerDatos.Text = "Obtener Datos";
            // 
            // btnSalir
            // 
            btnSalir.Alignment = ToolStripItemAlignment.Right;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.ImageTransparentColor = Color.Magenta;
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(69, 29);
            btnSalir.Text = "Salir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 590);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 17;
            label2.Text = "Clave";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 510);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 16;
            label1.Text = "ID Tipo Boleto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(464, 594);
            label4.Name = "label4";
            label4.Size = new Size(60, 25);
            label4.TabIndex = 19;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(464, 516);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 18;
            label3.Text = "Descripción";
            // 
            // txtIdTipoBoleto
            // 
            txtIdTipoBoleto.Location = new Point(185, 510);
            txtIdTipoBoleto.Name = "txtIdTipoBoleto";
            txtIdTipoBoleto.Size = new Size(189, 31);
            txtIdTipoBoleto.TabIndex = 20;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(185, 587);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(189, 31);
            txtClave.TabIndex = 21;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(603, 507);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(212, 31);
            txtDescripcion.TabIndex = 22;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(603, 594);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(212, 31);
            txtPrecio.TabIndex = 23;
            // 
            // TipoBoleto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 730);
            Controls.Add(txtPrecio);
            Controls.Add(txtDescripcion);
            Controls.Add(txtClave);
            Controls.Add(txtIdTipoBoleto);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvTipoBoleto);
            Name = "TipoBoleto";
            Text = "TipoBoleto";
            Load += this.TipoBoleto_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTipoBoleto).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvTipoBoleto;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnObtenerDatos;
        private ToolStripButton btnSalir;
        private Label label2;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox txtIdTipoBoleto;
        private TextBox txtClave;
        private TextBox txtDescripcion;
        private TextBox txtPrecio;
    }
}