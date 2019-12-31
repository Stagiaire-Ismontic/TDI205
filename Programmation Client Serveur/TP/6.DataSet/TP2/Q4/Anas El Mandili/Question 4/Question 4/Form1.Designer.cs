namespace Question_4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.etudiant1RowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.etudiantIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etudiantPhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.etablissIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant1RowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.etudiantIdDataGridViewTextBoxColumn,
            this.etudiantNameDataGridViewTextBoxColumn,
            this.etudiantPhoneDataGridViewTextBoxColumn,
            this.etablissIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.etudiant1RowBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(167, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rechercher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // etudiant1RowBindingSource
            // 
            this.etudiant1RowBindingSource.DataSource = typeof(Question_4.MyDS.Etudiant1Row);
            // 
            // etudiantIdDataGridViewTextBoxColumn
            // 
            this.etudiantIdDataGridViewTextBoxColumn.DataPropertyName = "Etudiant_Id";
            this.etudiantIdDataGridViewTextBoxColumn.HeaderText = "Etudiant_Id";
            this.etudiantIdDataGridViewTextBoxColumn.Name = "etudiantIdDataGridViewTextBoxColumn";
            // 
            // etudiantNameDataGridViewTextBoxColumn
            // 
            this.etudiantNameDataGridViewTextBoxColumn.DataPropertyName = "Etudiant_Name";
            this.etudiantNameDataGridViewTextBoxColumn.HeaderText = "Etudiant_Name";
            this.etudiantNameDataGridViewTextBoxColumn.Name = "etudiantNameDataGridViewTextBoxColumn";
            // 
            // etudiantPhoneDataGridViewTextBoxColumn
            // 
            this.etudiantPhoneDataGridViewTextBoxColumn.DataPropertyName = "Etudiant_Phone";
            this.etudiantPhoneDataGridViewTextBoxColumn.HeaderText = "Etudiant_Phone";
            this.etudiantPhoneDataGridViewTextBoxColumn.Name = "etudiantPhoneDataGridViewTextBoxColumn";
            // 
            // etablissIdDataGridViewTextBoxColumn
            // 
            this.etablissIdDataGridViewTextBoxColumn.DataPropertyName = "Etabliss_Id";
            this.etablissIdDataGridViewTextBoxColumn.HeaderText = "Etabliss_Id";
            this.etablissIdDataGridViewTextBoxColumn.Name = "etablissIdDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 259);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.etudiant1RowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource etudiant1RowBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etudiantPhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn etablissIdDataGridViewTextBoxColumn;
    }
}

