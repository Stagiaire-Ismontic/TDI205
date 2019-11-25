namespace AppGestionStagiaires.PackageGroupe
{
    partial class FormGroupe
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.brEnregistrer = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(69, 21);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(69, 47);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(107, 18);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(107, 44);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // brEnregistrer
            // 
            this.brEnregistrer.Location = new System.Drawing.Point(107, 86);
            this.brEnregistrer.Name = "brEnregistrer";
            this.brEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.brEnregistrer.TabIndex = 5;
            this.brEnregistrer.Text = "Enregistrer";
            this.brEnregistrer.UseVisualStyleBackColor = true;
            this.brEnregistrer.Click += new System.EventHandler(this.brEnregistrer_Click);
            // 
            // FormGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 127);
            this.Controls.Add(this.brEnregistrer);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Name = "FormGroupe";
            this.Text = "FormGroupe";
            this.Load += new System.EventHandler(this.FormGroupe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button brEnregistrer;
    }
}