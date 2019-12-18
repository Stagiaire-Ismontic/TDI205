namespace CRUD
{
    partial class Gestion_Club
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
            this.btn_gstEntraineur = new System.Windows.Forms.Button();
            this.btn_GestSalle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_gstEntraineur
            // 
            this.btn_gstEntraineur.Location = new System.Drawing.Point(60, 168);
            this.btn_gstEntraineur.Name = "btn_gstEntraineur";
            this.btn_gstEntraineur.Size = new System.Drawing.Size(156, 44);
            this.btn_gstEntraineur.TabIndex = 0;
            this.btn_gstEntraineur.Text = "Gestion Entraineur";
            this.btn_gstEntraineur.UseVisualStyleBackColor = true;
            this.btn_gstEntraineur.Click += new System.EventHandler(this.btn_gstEntraineur_Click);
            // 
            // btn_GestSalle
            // 
            this.btn_GestSalle.Location = new System.Drawing.Point(253, 168);
            this.btn_GestSalle.Name = "btn_GestSalle";
            this.btn_GestSalle.Size = new System.Drawing.Size(156, 44);
            this.btn_GestSalle.TabIndex = 1;
            this.btn_GestSalle.Text = "Gestion Salle";
            this.btn_GestSalle.UseVisualStyleBackColor = true;
            this.btn_GestSalle.Click += new System.EventHandler(this.btn_GestSalle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(183, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion du Club";
            // 
            // Gestion_Club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 360);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_GestSalle);
            this.Controls.Add(this.btn_gstEntraineur);
            this.Name = "Gestion_Club";
            this.Text = "Gestion_Club";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gstEntraineur;
        private System.Windows.Forms.Button btn_GestSalle;
        private System.Windows.Forms.Label label1;
    }
}