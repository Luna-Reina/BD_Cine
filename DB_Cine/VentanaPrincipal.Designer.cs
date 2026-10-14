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
            géneroToolStripMenuItem = new ToolStripMenuItem();
            clasificaciónToolStripMenuItem = new ToolStripMenuItem();
            películaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { catalogoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1004, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // catalogoToolStripMenuItem
            // 
            catalogoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { géneroToolStripMenuItem, clasificaciónToolStripMenuItem, películaToolStripMenuItem });
            catalogoToolStripMenuItem.Name = "catalogoToolStripMenuItem";
            catalogoToolStripMenuItem.Size = new Size(84, 24);
            catalogoToolStripMenuItem.Text = "Catalogo";
            // 
            // géneroToolStripMenuItem
            // 
            géneroToolStripMenuItem.Name = "géneroToolStripMenuItem";
            géneroToolStripMenuItem.Size = new Size(224, 26);
            géneroToolStripMenuItem.Text = "Género";
            géneroToolStripMenuItem.Click += géneroToolStripMenuItem_Click;
            // 
            // clasificaciónToolStripMenuItem
            // 
            clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            clasificaciónToolStripMenuItem.Size = new Size(224, 26);
            clasificaciónToolStripMenuItem.Text = "Clasificación";
            clasificaciónToolStripMenuItem.Click += clasificaciónToolStripMenuItem_Click;
            // 
            // películaToolStripMenuItem
            // 
            películaToolStripMenuItem.Name = "películaToolStripMenuItem";
            películaToolStripMenuItem.Size = new Size(224, 26);
            películaToolStripMenuItem.Text = "Película";
            películaToolStripMenuItem.Click += películaToolStripMenuItem_Click;
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "VentanaPrincipal";
            Text = "Ventana Principal";
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
    }
}
