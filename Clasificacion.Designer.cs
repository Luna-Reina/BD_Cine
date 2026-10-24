namespace DB_Cine
{
    partial class Clasificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clasificacion));
            dgvClasificacion = new DataGridView();
            toolStrip1 = new ToolStrip();
            btnNuevo = new ToolStripButton();
            btnEditar = new ToolStripButton();
            btnEliminar = new ToolStripButton();
            btnCancelar = new ToolStripButton();
            btnGuardar = new ToolStripButton();
            btnObtenerDatos = new ToolStripButton();
            btnSalir = new ToolStripButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtIdClasificacion = new TextBox();
            txtClave = new TextBox();
            txtDescripcion = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvClasificacion
            // 
            dgvClasificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClasificacion.Location = new Point(49, 74);
            dgvClasificacion.Name = "dgvClasificacion";
            dgvClasificacion.RowHeadersWidth = 62;
            dgvClasificacion.Size = new Size(724, 382);
            dgvClasificacion.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Padding = new Padding(0, 0, 3, 0);
            toolStrip1.Size = new Size(1063, 34);
            toolStrip1.TabIndex = 13;
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
            btnSalir.Click += this.btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 529);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 14;
            label1.Text = "ID Clasificación";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 600);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 15;
            label2.Text = "Clave";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(450, 532);
            label3.Name = "label3";
            label3.Size = new Size(104, 25);
            label3.TabIndex = 16;
            label3.Text = "Descripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(450, 610);
            label4.Name = "label4";
            label4.Size = new Size(188, 25);
            label4.TabIndex = 17;
            label4.Text = "Fecha y Hora Creación";
            // 
            // txtIdClasificacion
            // 
            txtIdClasificacion.Location = new Point(200, 526);
            txtIdClasificacion.Name = "txtIdClasificacion";
            txtIdClasificacion.Size = new Size(188, 31);
            txtIdClasificacion.TabIndex = 18;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(200, 604);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(188, 31);
            txtClave.TabIndex = 19;
      
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(657, 529);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(344, 31);
            txtDescripcion.TabIndex = 20;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(657, 610);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(344, 31);
            dateTimePicker1.TabIndex = 21;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(657, 659);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(344, 31);
            dateTimePicker2.TabIndex = 22;
            // 
            // Clasificacion
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1063, 727);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtDescripcion);
            Controls.Add(txtClave);
            Controls.Add(txtIdClasificacion);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvClasificacion);
            Name = "Clasificacion";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvClasificacion).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClasificacion;
        private ToolStrip toolStrip1;
        private ToolStripButton btnNuevo;
        private ToolStripButton btnEditar;
        private ToolStripButton btnEliminar;
        private ToolStripButton btnCancelar;
        private ToolStripButton btnGuardar;
        private ToolStripButton btnObtenerDatos;
        private ToolStripButton btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtIdClasificacion;
        private TextBox txtClave;
        private TextBox txtDescripcion;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}