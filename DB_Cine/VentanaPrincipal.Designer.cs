namespace DB_Cine
{
    partial class VentanaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            catalogoToolStripMenuItem = new ToolStripMenuItem();
            clasificaciónToolStripMenuItem = new ToolStripMenuItem();
            géneroToolStripMenuItem = new ToolStripMenuItem();
            películaToolStripMenuItem = new ToolStripMenuItem();
            sucursalToolStripMenuItem = new ToolStripMenuItem();
            salaToolStripMenuItem = new ToolStripMenuItem();
            tipoBoletoToolStripMenuItem = new ToolStripMenuItem();
            ciudadTrabajoToolStripMenuItem = new ToolStripMenuItem();
            funciónToolStripMenuItem = new ToolStripMenuItem();
            clienteToolStripMenuItem = new ToolStripMenuItem();
            ventaToolStripMenuItem1 = new ToolStripMenuItem();
            ventaToolStripMenuItem = new ToolStripMenuItem();
            detalleVentaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem, ventaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(729, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { clasificaciónToolStripMenuItem, géneroToolStripMenuItem, películaToolStripMenuItem, sucursalToolStripMenuItem, salaToolStripMenuItem, tipoBoletoToolStripMenuItem, ciudadTrabajoToolStripMenuItem, funciónToolStripMenuItem, clienteToolStripMenuItem, ventaToolStripMenuItem1 });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(67, 20);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // clasificaciónToolStripMenuItem
            // 
            clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            clasificaciónToolStripMenuItem.Size = new Size(152, 22);
            clasificaciónToolStripMenuItem.Text = "Clasificación";
            clasificaciónToolStripMenuItem.Click += clasificaciónToolStripMenuItem_Click;
            // 
            // géneroToolStripMenuItem
            // 
            géneroToolStripMenuItem.Name = "géneroToolStripMenuItem";
            géneroToolStripMenuItem.Size = new Size(152, 22);
            géneroToolStripMenuItem.Text = "Género";
            géneroToolStripMenuItem.Click += géneroToolStripMenuItem_Click;
            // 
            // películaToolStripMenuItem
            // 
            películaToolStripMenuItem.Name = "películaToolStripMenuItem";
            películaToolStripMenuItem.Size = new Size(152, 22);
            películaToolStripMenuItem.Text = "Película";
            películaToolStripMenuItem.Click += películaToolStripMenuItem_Click;
            // 
            // sucursalToolStripMenuItem
            // 
            sucursalToolStripMenuItem.Name = "sucursalToolStripMenuItem";
            sucursalToolStripMenuItem.Size = new Size(152, 22);
            sucursalToolStripMenuItem.Text = "Sucursal";
            sucursalToolStripMenuItem.Click += sucursalToolStripMenuItem_Click;
            // 
            // salaToolStripMenuItem
            // 
            salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            salaToolStripMenuItem.Size = new Size(152, 22);
            salaToolStripMenuItem.Text = "Sala";
            salaToolStripMenuItem.Click += salaToolStripMenuItem_Click;
            // 
            // tipoBoletoToolStripMenuItem
            // 
            tipoBoletoToolStripMenuItem.Name = "tipoBoletoToolStripMenuItem";
            tipoBoletoToolStripMenuItem.Size = new Size(152, 22);
            tipoBoletoToolStripMenuItem.Text = "Tipo Boleto";
            tipoBoletoToolStripMenuItem.Click += tipoBoletoToolStripMenuItem_Click;
            // 
            // ciudadTrabajoToolStripMenuItem
            // 
            ciudadTrabajoToolStripMenuItem.Name = "ciudadTrabajoToolStripMenuItem";
            ciudadTrabajoToolStripMenuItem.Size = new Size(152, 22);
            ciudadTrabajoToolStripMenuItem.Text = "Ciudad-Estado";
            ciudadTrabajoToolStripMenuItem.Click += ciudadEstadoToolStripMenuItem_Click;
            // 
            // funciónToolStripMenuItem
            // 
            funciónToolStripMenuItem.Name = "funciónToolStripMenuItem";
            funciónToolStripMenuItem.Size = new Size(152, 22);
            funciónToolStripMenuItem.Text = "Función";
            funciónToolStripMenuItem.Click += funciónToolStripMenuItem_Click;
            // 
            // clienteToolStripMenuItem
            // 
            clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            clienteToolStripMenuItem.Size = new Size(152, 22);
            clienteToolStripMenuItem.Text = "Cliente";
            clienteToolStripMenuItem.Click += clienteToolStripMenuItem_Click;
            // 
            // ventaToolStripMenuItem1
            // 
            ventaToolStripMenuItem1.Name = "ventaToolStripMenuItem1";
            ventaToolStripMenuItem1.Size = new Size(152, 22);
            ventaToolStripMenuItem1.Text = "Venta";
            ventaToolStripMenuItem1.Click += ventaToolStripMenuItem1_Click;
            // 
            // ventaToolStripMenuItem
            // 
            ventaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { detalleVentaToolStripMenuItem });
            ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            ventaToolStripMenuItem.Size = new Size(48, 20);
            ventaToolStripMenuItem.Text = "Venta";
            // 
            // detalleVentaToolStripMenuItem
            // 
            detalleVentaToolStripMenuItem.Name = "detalleVentaToolStripMenuItem";
            detalleVentaToolStripMenuItem.Size = new Size(142, 22);
            detalleVentaToolStripMenuItem.Text = "Detalle Venta";
            detalleVentaToolStripMenuItem.Click += detalleVentaToolStripMenuItem_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 423);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 2, 3, 2);
            Name = "VentanaPrincipal";
            Text = "☆ Ventana Principal ☆";
            Load += VentanaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem catalogoToolStripMenuItem;
        private ToolStripMenuItem géneroToolStripMenuItem;
        private ToolStripMenuItem clasificaciónToolStripMenuItem;
        private ToolStripMenuItem películaToolStripMenuItem;
        private ToolStripMenuItem ciudadTrabajoToolStripMenuItem;
        private ToolStripMenuItem salaToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem;
        private ToolStripMenuItem detalleVentaToolStripMenuItem;
        private ToolStripMenuItem sucursalToolStripMenuItem;
        private ToolStripMenuItem tipoBoletoToolStripMenuItem;
        private ToolStripMenuItem funciónToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem ventaToolStripMenuItem1;
    }
}
