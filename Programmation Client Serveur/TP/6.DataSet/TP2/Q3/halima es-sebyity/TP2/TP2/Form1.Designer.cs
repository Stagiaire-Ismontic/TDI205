namespace TP2
{
    partial class Form1
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
            this.gestionBibliothequeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editeurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionBibliothequeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionBibliothequeToolStripMenuItem
            // 
            this.gestionBibliothequeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livreToolStripMenuItem,
            this.editeurToolStripMenuItem});
            this.gestionBibliothequeToolStripMenuItem.Name = "gestionBibliothequeToolStripMenuItem";
            this.gestionBibliothequeToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.gestionBibliothequeToolStripMenuItem.Text = "Gestion Bibliotheque";
            // 
            // livreToolStripMenuItem
            // 
            this.livreToolStripMenuItem.Name = "livreToolStripMenuItem";
            this.livreToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.livreToolStripMenuItem.Text = "Livre";
            this.livreToolStripMenuItem.Click += new System.EventHandler(this.livreToolStripMenuItem_Click);
            // 
            // editeurToolStripMenuItem
            // 
            this.editeurToolStripMenuItem.Name = "editeurToolStripMenuItem";
            this.editeurToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editeurToolStripMenuItem.Text = "Editeur";
            this.editeurToolStripMenuItem.Click += new System.EventHandler(this.editeurToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionBibliothequeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editeurToolStripMenuItem;
    }
}

