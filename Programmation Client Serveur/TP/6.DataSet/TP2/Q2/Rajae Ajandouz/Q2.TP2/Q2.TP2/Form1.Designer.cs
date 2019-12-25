namespace Q2.TP2
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
            this.TId = new System.Windows.Forms.TextBox();
            this.TNom = new System.Windows.Forms.TextBox();
            this.TPrenom = new System.Windows.Forms.TextBox();
            this.TAdress = new System.Windows.Forms.TextBox();
            this.Debut = new System.Windows.Forms.Button();
            this.Précédent = new System.Windows.Forms.Button();
            this.Suivant = new System.Windows.Forms.Button();
            this.Fin = new System.Windows.Forms.Button();
            this.Ajouter = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Adress";
            // 
            // TId
            // 
            this.TId.Location = new System.Drawing.Point(57, 0);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(100, 20);
            this.TId.TabIndex = 4;
            // 
            // TNom
            // 
            this.TNom.Location = new System.Drawing.Point(57, 31);
            this.TNom.Name = "TNom";
            this.TNom.Size = new System.Drawing.Size(100, 20);
            this.TNom.TabIndex = 5;
            // 
            // TPrenom
            // 
            this.TPrenom.Location = new System.Drawing.Point(57, 71);
            this.TPrenom.Name = "TPrenom";
            this.TPrenom.Size = new System.Drawing.Size(100, 20);
            this.TPrenom.TabIndex = 6;
            // 
            // TAdress
            // 
            this.TAdress.Location = new System.Drawing.Point(57, 109);
            this.TAdress.Name = "TAdress";
            this.TAdress.Size = new System.Drawing.Size(100, 20);
            this.TAdress.TabIndex = 7;
            // 
            // Debut
            // 
            this.Debut.Location = new System.Drawing.Point(12, 175);
            this.Debut.Name = "Debut";
            this.Debut.Size = new System.Drawing.Size(75, 23);
            this.Debut.TabIndex = 8;
            this.Debut.Text = "Debut";
            this.Debut.UseVisualStyleBackColor = true;
            this.Debut.Click += new System.EventHandler(this.Debut_Click);
            // 
            // Précédent
            // 
            this.Précédent.Location = new System.Drawing.Point(106, 175);
            this.Précédent.Name = "Précédent";
            this.Précédent.Size = new System.Drawing.Size(75, 23);
            this.Précédent.TabIndex = 9;
            this.Précédent.Text = "Precedent";
            this.Précédent.UseVisualStyleBackColor = true;
            this.Précédent.Click += new System.EventHandler(this.Précédent_Click);
            // 
            // Suivant
            // 
            this.Suivant.Location = new System.Drawing.Point(205, 175);
            this.Suivant.Name = "Suivant";
            this.Suivant.Size = new System.Drawing.Size(75, 23);
            this.Suivant.TabIndex = 10;
            this.Suivant.Text = "Suivant";
            this.Suivant.UseVisualStyleBackColor = true;
            this.Suivant.Click += new System.EventHandler(this.Suivant_Click);
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(286, 175);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(75, 23);
            this.Fin.TabIndex = 11;
            this.Fin.Text = "Fin";
            this.Fin.UseVisualStyleBackColor = true;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // Ajouter
            // 
            this.Ajouter.Location = new System.Drawing.Point(286, 34);
            this.Ajouter.Name = "Ajouter";
            this.Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Ajouter.TabIndex = 13;
            this.Ajouter.Text = "Ajjouter";
            this.Ajouter.UseVisualStyleBackColor = true;
            this.Ajouter.Click += new System.EventHandler(this.Ajouter_Click);
            // 
            // Modifier
            // 
            this.Modifier.Location = new System.Drawing.Point(286, 80);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(75, 23);
            this.Modifier.TabIndex = 14;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = true;
            this.Modifier.Click += new System.EventHandler(this.Modifier_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(286, 125);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Supprimer.TabIndex = 15;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.Supprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(397, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 150);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(Q2.TP2.Empl.EmployeRow);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 431);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Supprimer);
            this.Controls.Add(this.Modifier);
            this.Controls.Add(this.Ajouter);
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.Suivant);
            this.Controls.Add(this.Précédent);
            this.Controls.Add(this.Debut);
            this.Controls.Add(this.TAdress);
            this.Controls.Add(this.TPrenom);
            this.Controls.Add(this.TNom);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TId;
        private System.Windows.Forms.TextBox TNom;
        private System.Windows.Forms.TextBox TPrenom;
        private System.Windows.Forms.TextBox TAdress;
        private System.Windows.Forms.Button Debut;
        private System.Windows.Forms.Button Précédent;
        private System.Windows.Forms.Button Suivant;
        private System.Windows.Forms.Button Fin;
        private System.Windows.Forms.Button Ajouter;
        private System.Windows.Forms.Button Modifier;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
    }
}

