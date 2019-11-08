namespace AppGestionStagiaires.PackageGroupe
{
    partial class FormGroupeUpdate
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nomLabel;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.btMiseAjour = new System.Windows.Forms.Button();
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(24, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(19, 13);
            idLabel.TabIndex = 1;
            idLabel.Text = "Id:";
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(24, 41);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 3;
            nomLabel.Text = "Nom:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(62, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataSource = typeof(AppGestionStagiaires.PackageGroupe.Groupe);
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.groupeBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(62, 38);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // btMiseAjour
            // 
            this.btMiseAjour.Location = new System.Drawing.Point(62, 77);
            this.btMiseAjour.Name = "btMiseAjour";
            this.btMiseAjour.Size = new System.Drawing.Size(75, 23);
            this.btMiseAjour.TabIndex = 5;
            this.btMiseAjour.Text = "Mise à jour";
            this.btMiseAjour.UseVisualStyleBackColor = true;
            this.btMiseAjour.Click += new System.EventHandler(this.btMiseAjour_Click);
            // 
            // FormGroupeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 121);
            this.Controls.Add(this.btMiseAjour);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Name = "FormGroupeUpdate";
            this.Text = "FormGroupeUpdate";
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource groupeBindingSource;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button btMiseAjour;
    }
}