namespace Q3
{
    partial class Editeurs
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Ajouter = new System.Windows.Forms.Button();
            this.but_Supprimer = new System.Windows.Forms.Button();
            this.but_Modifier = new System.Windows.Forms.Button();
            this.but_Rechercher = new System.Windows.Forms.Button();
            this.textBox_Recherche = new System.Windows.Forms.TextBox();
            this.editeurRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(537, 271);
            this.dataGridView1.TabIndex = 0;
            // 
            // but_Ajouter
            // 
            this.but_Ajouter.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Ajouter.Location = new System.Drawing.Point(661, 40);
            this.but_Ajouter.Name = "but_Ajouter";
            this.but_Ajouter.Size = new System.Drawing.Size(75, 56);
            this.but_Ajouter.TabIndex = 1;
            this.but_Ajouter.Text = "Ajouter";
            this.but_Ajouter.UseVisualStyleBackColor = false;
            // 
            // but_Supprimer
            // 
            this.but_Supprimer.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Supprimer.Location = new System.Drawing.Point(557, 124);
            this.but_Supprimer.Name = "but_Supprimer";
            this.but_Supprimer.Size = new System.Drawing.Size(75, 55);
            this.but_Supprimer.TabIndex = 2;
            this.but_Supprimer.Text = "Supprimer";
            this.but_Supprimer.UseVisualStyleBackColor = false;
            // 
            // but_Modifier
            // 
            this.but_Modifier.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Modifier.Location = new System.Drawing.Point(661, 124);
            this.but_Modifier.Name = "but_Modifier";
            this.but_Modifier.Size = new System.Drawing.Size(75, 55);
            this.but_Modifier.TabIndex = 3;
            this.but_Modifier.Text = "Modifier";
            this.but_Modifier.UseVisualStyleBackColor = false;
            // 
            // but_Rechercher
            // 
            this.but_Rechercher.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.but_Rechercher.Location = new System.Drawing.Point(557, 40);
            this.but_Rechercher.Name = "but_Rechercher";
            this.but_Rechercher.Size = new System.Drawing.Size(75, 56);
            this.but_Rechercher.TabIndex = 4;
            this.but_Rechercher.Text = "Rechercher";
            this.but_Rechercher.UseVisualStyleBackColor = false;
            this.but_Rechercher.Click += new System.EventHandler(this.but_Rechercher_Click);
            // 
            // textBox_Recherche
            // 
            this.textBox_Recherche.Location = new System.Drawing.Point(154, 12);
            this.textBox_Recherche.Name = "textBox_Recherche";
            this.textBox_Recherche.Size = new System.Drawing.Size(141, 20);
            this.textBox_Recherche.TabIndex = 5;
            // 
            // editeurRowBindingSource
            // 
            this.editeurRowBindingSource.DataSource = typeof(Q3.DS.EditeurRow);
            // 
            // Editeurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 323);
            this.Controls.Add(this.textBox_Recherche);
            this.Controls.Add(this.but_Rechercher);
            this.Controls.Add(this.but_Modifier);
            this.Controls.Add(this.but_Supprimer);
            this.Controls.Add(this.but_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Editeurs";
            this.Text = "Editeurs";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Ajouter;
        private System.Windows.Forms.Button but_Supprimer;
        private System.Windows.Forms.Button but_Modifier;
        private System.Windows.Forms.Button but_Rechercher;
        private System.Windows.Forms.TextBox textBox_Recherche;
        private System.Windows.Forms.BindingSource editeurRowBindingSource;
    }
}