namespace Q2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.text_Nom = new System.Windows.Forms.TextBox();
            this.text_Cat = new System.Windows.Forms.TextBox();
            this.but_Ajouter = new System.Windows.Forms.Button();
            this.but_Modifier = new System.Windows.Forms.Button();
            this.but_Supprimer = new System.Windows.Forms.Button();
            this.but_Precedent = new System.Windows.Forms.Button();
            this.but_Debut = new System.Windows.Forms.Button();
            this.but_Suivant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlivreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livreRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.combo_livre = new System.Windows.Forms.ComboBox();
            this.livreRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.but_Fin = new System.Windows.Forms.Button();
            this.but_Quitter = new System.Windows.Forms.Button();
            this.but_Nouveau = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "id_livre";
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(70, 9);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(100, 20);
            this.text_Id.TabIndex = 4;
            // 
            // text_Nom
            // 
            this.text_Nom.Location = new System.Drawing.Point(70, 38);
            this.text_Nom.Name = "text_Nom";
            this.text_Nom.Size = new System.Drawing.Size(100, 20);
            this.text_Nom.TabIndex = 5;
            // 
            // text_Cat
            // 
            this.text_Cat.Location = new System.Drawing.Point(70, 70);
            this.text_Cat.Name = "text_Cat";
            this.text_Cat.Size = new System.Drawing.Size(100, 20);
            this.text_Cat.TabIndex = 6;
            // 
            // but_Ajouter
            // 
            this.but_Ajouter.Location = new System.Drawing.Point(488, 60);
            this.but_Ajouter.Name = "but_Ajouter";
            this.but_Ajouter.Size = new System.Drawing.Size(75, 38);
            this.but_Ajouter.TabIndex = 8;
            this.but_Ajouter.Text = "Ajouter";
            this.but_Ajouter.UseVisualStyleBackColor = true;
            this.but_Ajouter.Click += new System.EventHandler(this.but_Ajouter_Click);
            // 
            // but_Modifier
            // 
            this.but_Modifier.Location = new System.Drawing.Point(488, 12);
            this.but_Modifier.Name = "but_Modifier";
            this.but_Modifier.Size = new System.Drawing.Size(75, 38);
            this.but_Modifier.TabIndex = 9;
            this.but_Modifier.Text = "Modifier";
            this.but_Modifier.UseVisualStyleBackColor = true;
            this.but_Modifier.Click += new System.EventHandler(this.but_Modifier_Click);
            // 
            // but_Supprimer
            // 
            this.but_Supprimer.Location = new System.Drawing.Point(569, 59);
            this.but_Supprimer.Name = "but_Supprimer";
            this.but_Supprimer.Size = new System.Drawing.Size(75, 40);
            this.but_Supprimer.TabIndex = 10;
            this.but_Supprimer.Text = "Supprimer";
            this.but_Supprimer.UseVisualStyleBackColor = true;
            this.but_Supprimer.Click += new System.EventHandler(this.but_Supprimer_Click);
            // 
            // but_Precedent
            // 
            this.but_Precedent.Location = new System.Drawing.Point(650, 9);
            this.but_Precedent.Name = "but_Precedent";
            this.but_Precedent.Size = new System.Drawing.Size(75, 38);
            this.but_Precedent.TabIndex = 11;
            this.but_Precedent.Text = "Precedent";
            this.but_Precedent.UseVisualStyleBackColor = true;
            this.but_Precedent.Click += new System.EventHandler(this.but_Precedent_Click);
            // 
            // but_Debut
            // 
            this.but_Debut.Location = new System.Drawing.Point(407, 9);
            this.but_Debut.Name = "but_Debut";
            this.but_Debut.Size = new System.Drawing.Size(75, 38);
            this.but_Debut.TabIndex = 12;
            this.but_Debut.Text = "Debut";
            this.but_Debut.UseVisualStyleBackColor = true;
            this.but_Debut.Click += new System.EventHandler(this.but_Debut_Click);
            // 
            // but_Suivant
            // 
            this.but_Suivant.Location = new System.Drawing.Point(569, 9);
            this.but_Suivant.Name = "but_Suivant";
            this.but_Suivant.Size = new System.Drawing.Size(75, 38);
            this.but_Suivant.TabIndex = 13;
            this.but_Suivant.Text = "Suivant";
            this.but_Suivant.UseVisualStyleBackColor = true;
            this.but_Suivant.Click += new System.EventHandler(this.but_Suivant_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.idlivreDataGridViewTextBoxColumn,
            this.livreRowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(19, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 263);
            this.dataGridView1.TabIndex = 14;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // categorieDataGridViewTextBoxColumn
            // 
            this.categorieDataGridViewTextBoxColumn.DataPropertyName = "categorie";
            this.categorieDataGridViewTextBoxColumn.HeaderText = "categorie";
            this.categorieDataGridViewTextBoxColumn.Name = "categorieDataGridViewTextBoxColumn";
            // 
            // idlivreDataGridViewTextBoxColumn
            // 
            this.idlivreDataGridViewTextBoxColumn.DataPropertyName = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.HeaderText = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.Name = "idlivreDataGridViewTextBoxColumn";
            // 
            // livreRowDataGridViewTextBoxColumn
            // 
            this.livreRowDataGridViewTextBoxColumn.DataPropertyName = "LivreRow";
            this.livreRowDataGridViewTextBoxColumn.HeaderText = "LivreRow";
            this.livreRowDataGridViewTextBoxColumn.Name = "livreRowDataGridViewTextBoxColumn";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Q2.DataSetEditeur.EditeurRow);
            // 
            // combo_livre
            // 
            this.combo_livre.DataSource = this.livreRowBindingSource;
            this.combo_livre.DisplayMember = "id";
            this.combo_livre.FormattingEnabled = true;
            this.combo_livre.Location = new System.Drawing.Point(70, 114);
            this.combo_livre.Name = "combo_livre";
            this.combo_livre.Size = new System.Drawing.Size(121, 21);
            this.combo_livre.TabIndex = 15;
            this.combo_livre.ValueMember = "Titre";
            // 
            // livreRowBindingSource
            // 
            this.livreRowBindingSource.DataSource = typeof(Q2.DataSetEditeur.LivreRow);
            // 
            // but_Fin
            // 
            this.but_Fin.Location = new System.Drawing.Point(407, 60);
            this.but_Fin.Name = "but_Fin";
            this.but_Fin.Size = new System.Drawing.Size(75, 38);
            this.but_Fin.TabIndex = 16;
            this.but_Fin.Text = "Fin";
            this.but_Fin.UseVisualStyleBackColor = true;
            this.but_Fin.Click += new System.EventHandler(this.but_Fin_Click);
            // 
            // but_Quitter
            // 
            this.but_Quitter.Location = new System.Drawing.Point(650, 60);
            this.but_Quitter.Name = "but_Quitter";
            this.but_Quitter.Size = new System.Drawing.Size(75, 38);
            this.but_Quitter.TabIndex = 17;
            this.but_Quitter.Text = "Quitter";
            this.but_Quitter.UseVisualStyleBackColor = true;
            this.but_Quitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // but_Nouveau
            // 
            this.but_Nouveau.Location = new System.Drawing.Point(650, 114);
            this.but_Nouveau.Name = "but_Nouveau";
            this.but_Nouveau.Size = new System.Drawing.Size(75, 35);
            this.but_Nouveau.TabIndex = 18;
            this.but_Nouveau.Text = "Nouveau";
            this.but_Nouveau.UseVisualStyleBackColor = true;
            this.but_Nouveau.Click += new System.EventHandler(this.but_Nouveau_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 441);
            this.Controls.Add(this.but_Nouveau);
            this.Controls.Add(this.but_Quitter);
            this.Controls.Add(this.but_Fin);
            this.Controls.Add(this.combo_livre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.but_Suivant);
            this.Controls.Add(this.but_Debut);
            this.Controls.Add(this.but_Precedent);
            this.Controls.Add(this.but_Supprimer);
            this.Controls.Add(this.but_Modifier);
            this.Controls.Add(this.but_Ajouter);
            this.Controls.Add(this.text_Cat);
            this.Controls.Add(this.text_Nom);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.TextBox text_Nom;
        private System.Windows.Forms.TextBox text_Cat;
        private System.Windows.Forms.Button but_Ajouter;
        private System.Windows.Forms.Button but_Modifier;
        private System.Windows.Forms.Button but_Supprimer;
        private System.Windows.Forms.Button but_Precedent;
        private System.Windows.Forms.Button but_Debut;
        private System.Windows.Forms.Button but_Suivant;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox combo_livre;
        private System.Windows.Forms.Button but_Fin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlivreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livreRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource livreRowBindingSource;
        private System.Windows.Forms.Button but_Quitter;
        private System.Windows.Forms.Button but_Nouveau;
    }
}

