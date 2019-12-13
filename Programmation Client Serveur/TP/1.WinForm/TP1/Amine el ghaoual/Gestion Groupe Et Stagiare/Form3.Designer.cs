namespace Gestion_GrpEtStg
{
    partial class Form3
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
            this.groupeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionStagiaireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupeToolStripMenuItem,
            this.gestionStagiaireToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupeToolStripMenuItem
            // 
            this.groupeToolStripMenuItem.Name = "groupeToolStripMenuItem";
            this.groupeToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.groupeToolStripMenuItem.Text = "GestionGroupe";
            this.groupeToolStripMenuItem.Click += new System.EventHandler(this.groupeToolStripMenuItem_Click);
            // 
            // gestionStagiaireToolStripMenuItem
            // 
            this.gestionStagiaireToolStripMenuItem.Name = "gestionStagiaireToolStripMenuItem";
            this.gestionStagiaireToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.gestionStagiaireToolStripMenuItem.Text = "GestionStagiaire";
            this.gestionStagiaireToolStripMenuItem.Click += new System.EventHandler(this.gestionStagiaireToolStripMenuItem_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 240);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionStagiaireToolStripMenuItem;
    }
}