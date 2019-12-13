namespace CrudWin.Entities
{
    partial class Form_CreateEmployer
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
            System.Windows.Forms.Label label1;
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.brEnregistrer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.PrenomTxtBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            nomLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
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
            // brEnregistrer
            // 
            this.brEnregistrer.Location = new System.Drawing.Point(107, 92);
            this.brEnregistrer.Name = "brEnregistrer";
            this.brEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.brEnregistrer.TabIndex = 5;
            this.brEnregistrer.Text = "Enregistrer";
            this.brEnregistrer.UseVisualStyleBackColor = true;
            this.brEnregistrer.Click += new System.EventHandler(this.brEnregistrer_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(55, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 13);
            label1.TabIndex = 6;
            label1.Text = "Prenom:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(107, 44);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomTextBox.TabIndex = 4;
            // 
            // PrenomTxtBox
            // 
            this.PrenomTxtBox.Location = new System.Drawing.Point(107, 70);
            this.PrenomTxtBox.Multiline = true;
            this.PrenomTxtBox.Name = "PrenomTxtBox";
            this.PrenomTxtBox.Size = new System.Drawing.Size(100, 20);
            this.PrenomTxtBox.TabIndex = 8;
            // 
            // Form_CreateEmployer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 127);
            this.Controls.Add(this.PrenomTxtBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.brEnregistrer);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Name = "Form_CreateEmployer";
            this.Text = "FormEmployer";
            this.Load += new System.EventHandler(this.FormEmployer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button brEnregistrer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox PrenomTxtBox;
    }
}