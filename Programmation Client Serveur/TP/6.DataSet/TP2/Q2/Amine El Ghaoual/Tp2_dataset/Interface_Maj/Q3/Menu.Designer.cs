namespace Interface_Maj
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionPersoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersoneToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gsClasseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPersoneToolStripMenuItem,
            this.gsClasseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionPersoneToolStripMenuItem
            // 
            this.gestionPersoneToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionPersoneToolStripMenuItem1,
            this.gestionClasseToolStripMenuItem});
            this.gestionPersoneToolStripMenuItem.Name = "gestionPersoneToolStripMenuItem";
            this.gestionPersoneToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.gestionPersoneToolStripMenuItem.Text = "GestionInviduel";
            // 
            // gestionPersoneToolStripMenuItem1
            // 
            this.gestionPersoneToolStripMenuItem1.Name = "gestionPersoneToolStripMenuItem1";
            this.gestionPersoneToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.gestionPersoneToolStripMenuItem1.Text = "GestionClasse";
            this.gestionPersoneToolStripMenuItem1.Click += new System.EventHandler(this.gestionPersoneToolStripMenuItem1_Click);
            // 
            // gestionClasseToolStripMenuItem
            // 
            this.gestionClasseToolStripMenuItem.Name = "gestionClasseToolStripMenuItem";
            this.gestionClasseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestionClasseToolStripMenuItem.Text = "GestionPersone";
            this.gestionClasseToolStripMenuItem.Click += new System.EventHandler(this.gestionClasseToolStripMenuItem_Click);
            // 
            // gsClasseToolStripMenuItem
            // 
            this.gsClasseToolStripMenuItem.Name = "gsClasseToolStripMenuItem";
            this.gsClasseToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.gsClasseToolStripMenuItem.Text = "GsClasse";
            this.gsClasseToolStripMenuItem.Click += new System.EventHandler(this.gsClasseToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionPersoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPersoneToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gestionClasseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gsClasseToolStripMenuItem;
    }
}