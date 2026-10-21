namespace DB_Cine
{
    partial class CiudadEstado
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CiudadEstado));
            dgvCiudades = new DataGridView();
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
            txtIdEstado = new TextBox();
            txtSiglasEstado = new TextBox();
            txtClaveEstado = new TextBox();
            txtNombreEstado = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbEstado = new ComboBox();
            txtIdCiudad = new TextBox();
            txtClaveCiudad = new TextBox();
            txtNombreCiudad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvCiudades
            // 
            dgvCiudades.AllowUserToAddRows = false;
            dgvCiudades.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCiudades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCiudades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvCiudades.DefaultCellStyle = dataGridViewCellStyle2;
            dgvCiudades.Location = new Point(3, 22);
            dgvCiudades.Margin = new Padding(3, 2, 3, 2);
            dgvCiudades.Name = "dgvCiudades";
            dgvCiudades.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvCiudades.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvCiudades.RowHeadersWidth = 51;
            dgvCiudades.Size = new Size(1009, 149);
            dgvCiudades.TabIndex = 0;
            dgvCiudades.SelectionChanged += dgvCiudades_SelectionChanged;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnNuevo, btnEditar, btnEliminar, btnCancelar, btnGuardar, btnObtenerDatos, btnSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1022, 27);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 236);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Siglas Estado: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 262);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 3;
            label2.Text = "Clave Estado: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 287);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 4;
            label3.Text = "Nombre Estado:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 208);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 5;
            label4.Text = "id Estado";
            // 
            // txtIdEstado
            // 
            txtIdEstado.Location = new Point(104, 202);
            txtIdEstado.Margin = new Padding(3, 2, 3, 2);
            txtIdEstado.Name = "txtIdEstado";
            txtIdEstado.ReadOnly = true;
            txtIdEstado.Size = new Size(110, 23);
            txtIdEstado.TabIndex = 6;
            // 
            // txtSiglasEstado
            // 
            txtSiglasEstado.Enabled = false;
            txtSiglasEstado.Location = new Point(104, 230);
            txtSiglasEstado.Margin = new Padding(3, 2, 3, 2);
            txtSiglasEstado.Name = "txtSiglasEstado";
            txtSiglasEstado.Size = new Size(110, 23);
            txtSiglasEstado.TabIndex = 7;
            // 
            // txtClaveEstado
            // 
            txtClaveEstado.Enabled = false;
            txtClaveEstado.Location = new Point(104, 260);
            txtClaveEstado.Margin = new Padding(3, 2, 3, 2);
            txtClaveEstado.Name = "txtClaveEstado";
            txtClaveEstado.Size = new Size(110, 23);
            txtClaveEstado.TabIndex = 8;
            // 
            // txtNombreEstado
            // 
            txtNombreEstado.Enabled = false;
            txtNombreEstado.Location = new Point(104, 285);
            txtNombreEstado.Margin = new Padding(3, 2, 3, 2);
            txtNombreEstado.Name = "txtNombreEstado";
            txtNombreEstado.Size = new Size(110, 23);
            txtNombreEstado.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 203);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 10;
            label5.Text = "Id Ciudad";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(424, 230);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 11;
            label6.Text = "Estado";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 262);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 12;
            label7.Text = "Clave de Ciudad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(423, 290);
            label8.Name = "label8";
            label8.Size = new Size(92, 15);
            label8.TabIndex = 13;
            label8.Text = "Nombre Ciudad";
            // 
            // cmbEstado
            // 
            cmbEstado.Enabled = false;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(535, 233);
            cmbEstado.Margin = new Padding(3, 2, 3, 2);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(133, 23);
            cmbEstado.TabIndex = 14;
            // 
            // txtIdCiudad
            // 
            txtIdCiudad.Location = new Point(535, 202);
            txtIdCiudad.Margin = new Padding(3, 2, 3, 2);
            txtIdCiudad.Name = "txtIdCiudad";
            txtIdCiudad.ReadOnly = true;
            txtIdCiudad.Size = new Size(110, 23);
            txtIdCiudad.TabIndex = 15;
            // 
            // txtClaveCiudad
            // 
            txtClaveCiudad.Enabled = false;
            txtClaveCiudad.Location = new Point(535, 260);
            txtClaveCiudad.Margin = new Padding(3, 2, 3, 2);
            txtClaveCiudad.Name = "txtClaveCiudad";
            txtClaveCiudad.Size = new Size(110, 23);
            txtClaveCiudad.TabIndex = 16;
            // 
            // txtNombreCiudad
            // 
            txtNombreCiudad.Enabled = false;
            txtNombreCiudad.Location = new Point(535, 287);
            txtNombreCiudad.Margin = new Padding(3, 2, 3, 2);
            txtNombreCiudad.Name = "txtNombreCiudad";
            txtNombreCiudad.Size = new Size(110, 23);
            txtNombreCiudad.TabIndex = 17;
            // 
            // CiudadEstado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 338);
            Controls.Add(txtNombreCiudad);
            Controls.Add(txtClaveCiudad);
            Controls.Add(txtIdCiudad);
            Controls.Add(cmbEstado);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtNombreEstado);
            Controls.Add(txtClaveEstado);
            Controls.Add(txtSiglasEstado);
            Controls.Add(txtIdEstado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Controls.Add(dgvCiudades);
            Margin = new Padding(3, 2, 3, 2);
            Name = "CiudadEstado";
            Text = "CiudadEstado";
            ((System.ComponentModel.ISupportInitialize)dgvCiudades).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCiudades;
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
        private TextBox txtIdEstado;
        private TextBox txtSiglasEstado;
        private TextBox txtClaveEstado;
        private TextBox txtNombreEstado;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbEstado;
        private TextBox txtIdCiudad;
        private TextBox txtClaveCiudad;
        private TextBox txtNombreCiudad;
    }
}