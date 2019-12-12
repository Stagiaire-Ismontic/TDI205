namespace CrudWin
{
    partial class Application
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDesGroupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesGroupesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(444, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDesGroupesToolStripMenuItem
            // 
            this.gestionDesGroupesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupesToolStripMenuItem});
            this.gestionDesGroupesToolStripMenuItem.Name = "gestionDesGroupesToolStripMenuItem";
            this.gestionDesGroupesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.gestionDesGroupesToolStripMenuItem.Text = "Stagiaires";
            // 
            // groupesToolStripMenuItem
            // 
            this.groupesToolStripMenuItem.Name = "groupesToolStripMenuItem";
            this.groupesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.groupesToolStripMenuItem.Text = "Groupes";
            this.groupesToolStripMenuItem.Click += new System.EventHandler(this.groupesToolStripMenuItem_Click);
            // 
            // Application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 198);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Application";
            this.Text = "Trainee Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDesGroupesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupesToolStripMenuItem;
    }
}

