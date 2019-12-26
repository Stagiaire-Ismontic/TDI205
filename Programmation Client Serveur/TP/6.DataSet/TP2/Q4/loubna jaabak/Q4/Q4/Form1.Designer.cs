namespace Q4
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
            this.but_Rechercher = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.editeurByNameRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlivreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurByNameRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.idlivreDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.editeurByNameRowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(446, 263);
            this.dataGridView1.TabIndex = 0;
            // 
            // but_Rechercher
            // 
            this.but_Rechercher.Location = new System.Drawing.Point(296, 16);
            this.but_Rechercher.Name = "but_Rechercher";
            this.but_Rechercher.Size = new System.Drawing.Size(96, 42);
            this.but_Rechercher.TabIndex = 1;
            this.but_Rechercher.Text = "Rechercher";
            this.but_Rechercher.UseVisualStyleBackColor = true;
            this.but_Rechercher.Click += new System.EventHandler(this.but_Rechercher_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // text_Nom
            // 
            this.text_Nom.Location = new System.Drawing.Point(77, 13);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(123, 20);
            this.text_Nom.TabIndex = 3;
            // 
            // editeurByNameRowBindingSource
            // 
            this.editeurByNameRowBindingSource.DataSource = typeof(Q4.DS.EditeurByNameRow);
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // idlivreDataGridViewTextBoxColumn
            // 
            this.idlivreDataGridViewTextBoxColumn.DataPropertyName = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.HeaderText = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.Name = "idlivreDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "Titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "Titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 362);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_Rechercher);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurByNameRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button but_Rechercher;
        private System.Windows.Forms.BindingSource editeurByNameRowBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlivreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
    }
}

