namespace TP1
{
    partial class MenuApplication
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
            this.gestionDesIndividusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesStagiairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesIndividusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesIndividusToolStripMenuItem
            // 
            this.gestionDesIndividusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesStagiairesToolStripMenuItem,
            this.gestionDesGroupesToolStripMenuItem});
            this.gestionDesIndividusToolStripMenuItem.Name = "gestionDesIndividusToolStripMenuItem";
            this.gestionDesIndividusToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.gestionDesIndividusToolStripMenuItem.Text = "Gestion des individus";
            // 
            // gestionDesStagiairesToolStripMenuItem
            // 
            this.gestionDesStagiairesToolStripMenuItem.Name = "gestionDesStagiairesToolStripMenuItem";
            this.gestionDesStagiairesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesStagiairesToolStripMenuItem.Text = "Gestion des stagiaires";
            this.gestionDesStagiairesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesStagiairesToolStripMenuItem_Click);
            // 
            // gestionDesGroupesToolStripMenuItem
            // 
            this.gestionDesGroupesToolStripMenuItem.Name = "gestionDesGroupesToolStripMenuItem";
            this.gestionDesGroupesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.gestionDesGroupesToolStripMenuItem.Text = "Gestion des Groupes";
            this.gestionDesGroupesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesGroupesToolStripMenuItem_Click);
            // 
            // MenuApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuApplication";
            this.Text = "Menu Application";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesIndividusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesStagiairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesGroupesToolStripMenuItem;
    }
}

