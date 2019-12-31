namespace Q4_Tp2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.but_Recherche = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.employeByNomRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salairebaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeByNomRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.salairebaseDataGridViewTextBoxColumn,
            this.idEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.employeByNomRowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(22, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // but_Recherche
            // 
            this.but_Recherche.Location = new System.Drawing.Point(682, 136);
            this.but_Recherche.Name = "but_Recherche";
            this.but_Recherche.Size = new System.Drawing.Size(87, 71);
            this.but_Recherche.TabIndex = 1;
            this.but_Recherche.Text = "Rechercher";
            this.but_Recherche.UseVisualStyleBackColor = true;
            this.but_Recherche.Click += new System.EventHandler(this.but_Recherche_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // text_Nom
            // 
            this.text_Nom.Location = new System.Drawing.Point(633, 29);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(136, 20);
            this.text_Nom.TabIndex = 3;
            // 
            // employeByNomRowBindingSource
            // 
            this.employeByNomRowBindingSource.DataSource = typeof(Q4_Tp2.DSempxsd.EmployeByNomRow);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            // 
            // salairebaseDataGridViewTextBoxColumn
            // 
            this.salairebaseDataGridViewTextBoxColumn.DataPropertyName = "salairebase";
            this.salairebaseDataGridViewTextBoxColumn.HeaderText = "salairebase";
            this.salairebaseDataGridViewTextBoxColumn.Name = "salairebaseDataGridViewTextBoxColumn";
            // 
            // idEDataGridViewTextBoxColumn
            // 
            this.idEDataGridViewTextBoxColumn.DataPropertyName = "idE";
            this.idEDataGridViewTextBoxColumn.HeaderText = "idE";
            this.idEDataGridViewTextBoxColumn.Name = "idEDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 369);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Recherche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeByNomRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Recherche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salairebaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource employeByNomRowBindingSource;
    }
}

