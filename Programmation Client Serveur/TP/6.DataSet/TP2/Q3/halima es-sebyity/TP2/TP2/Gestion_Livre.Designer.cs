namespace TP2
{
    partial class Gestion_Livre
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
            this.text_reche = new System.Windows.Forms.TextBox();
            this.btn_reche = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // text_reche
            // 
            this.text_reche.Location = new System.Drawing.Point(21, 27);
            this.text_reche.Name = "text_reche";
            this.text_reche.Size = new System.Drawing.Size(137, 20);
            this.text_reche.TabIndex = 0;
            // 
            // btn_reche
            // 
            this.btn_reche.Location = new System.Drawing.Point(210, 19);
            this.btn_reche.Name = "btn_reche";
            this.btn_reche.Size = new System.Drawing.Size(100, 35);
            this.btn_reche.TabIndex = 1;
            this.btn_reche.Text = "Recherche";
            this.btn_reche.UseVisualStyleBackColor = true;
            this.btn_reche.Click += new System.EventHandler(this.btn_reche_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.livreRowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(21, 93);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(346, 170);
            this.dataGridView1.TabIndex = 2;
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(292, 293);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(100, 35);
            this.btn_quitter.TabIndex = 1;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titreDataGridViewTextBoxColumn
            // 
            this.titreDataGridViewTextBoxColumn.DataPropertyName = "titre";
            this.titreDataGridViewTextBoxColumn.HeaderText = "titre";
            this.titreDataGridViewTextBoxColumn.Name = "titreDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // livreRowBindingSource
            // 
            this.livreRowBindingSource.DataSource = typeof(TP2.DataSet1.LivreRow);
            // 
            // Gestion_Livre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 340);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_reche);
            this.Controls.Add(this.text_reche);
            this.Name = "Gestion_Livre";
            this.Text = "Gestion_Livre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_reche;
        private System.Windows.Forms.Button btn_reche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livreRowBindingSource;
    }
}