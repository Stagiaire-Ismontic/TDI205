namespace InterfaceMisAjour
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
            this.Nom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.CmbEntreprise = new System.Windows.Forms.ComboBox();
            this.entrepriseRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btDebut = new System.Windows.Forms.Button();
            this.btPrecedent = new System.Windows.Forms.Button();
            this.btSuivant = new System.Windows.Forms.Button();
            this.BtFin = new System.Windows.Forms.Button();
            this.BtAjouter = new System.Windows.Forms.Button();
            this.BtModifier = new System.Windows.Forms.Button();
            this.BtSupprimer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entrepriseRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtNouveau = new System.Windows.Forms.Button();
            this.txtNomR = new System.Windows.Forms.TextBox();
            this.BTChercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-49, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // Nom
            // 
            this.Nom.AutoSize = true;
            this.Nom.Location = new System.Drawing.Point(-49, 359);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(29, 13);
            this.Nom.TabIndex = 2;
            this.Nom.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-49, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-42, 425);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Entreprise";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(41, 304);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(124, 20);
            this.txtId.TabIndex = 5;
            // 
            // txtNom
            // 
            this.txtNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Nom", true));
            this.txtNom.Location = new System.Drawing.Point(41, 341);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(124, 20);
            this.txtNom.TabIndex = 6;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(InterfaceMisAjour.DS.EmployerRow);
            // 
            // txtPrenom
            // 
            this.txtPrenom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "prenom", true));
            this.txtPrenom.Location = new System.Drawing.Point(41, 375);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(124, 20);
            this.txtPrenom.TabIndex = 7;
            // 
            // CmbEntreprise
            // 
            this.CmbEntreprise.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bindingSource1, "IdEntreprise", true));
            this.CmbEntreprise.DataSource = this.entrepriseRowBindingSource;
            this.CmbEntreprise.DisplayMember = "Nom";
            this.CmbEntreprise.FormattingEnabled = true;
            this.CmbEntreprise.Location = new System.Drawing.Point(41, 407);
            this.CmbEntreprise.Name = "CmbEntreprise";
            this.CmbEntreprise.Size = new System.Drawing.Size(124, 21);
            this.CmbEntreprise.TabIndex = 8;
            this.CmbEntreprise.ValueMember = "Id";
            // 
            // entrepriseRowBindingSource
            // 
            this.entrepriseRowBindingSource.DataSource = typeof(InterfaceMisAjour.DS.EntrepriseRow);
            // 
            // btDebut
            // 
            this.btDebut.Location = new System.Drawing.Point(18, 252);
            this.btDebut.Name = "btDebut";
            this.btDebut.Size = new System.Drawing.Size(75, 23);
            this.btDebut.TabIndex = 9;
            this.btDebut.Text = "Debut";
            this.btDebut.UseVisualStyleBackColor = true;
            this.btDebut.Click += new System.EventHandler(this.btDebut_Click);
            // 
            // btPrecedent
            // 
            this.btPrecedent.Location = new System.Drawing.Point(112, 252);
            this.btPrecedent.Name = "btPrecedent";
            this.btPrecedent.Size = new System.Drawing.Size(75, 23);
            this.btPrecedent.TabIndex = 10;
            this.btPrecedent.Text = "precedent";
            this.btPrecedent.UseVisualStyleBackColor = true;
            this.btPrecedent.Click += new System.EventHandler(this.btPrecedent_Click);
            // 
            // btSuivant
            // 
            this.btSuivant.Location = new System.Drawing.Point(205, 252);
            this.btSuivant.Name = "btSuivant";
            this.btSuivant.Size = new System.Drawing.Size(75, 23);
            this.btSuivant.TabIndex = 11;
            this.btSuivant.Text = "Suivant";
            this.btSuivant.UseVisualStyleBackColor = true;
            this.btSuivant.Click += new System.EventHandler(this.btSuivant_Click);
            // 
            // BtFin
            // 
            this.BtFin.Location = new System.Drawing.Point(295, 252);
            this.BtFin.Name = "BtFin";
            this.BtFin.Size = new System.Drawing.Size(75, 23);
            this.BtFin.TabIndex = 12;
            this.BtFin.Text = "Fin";
            this.BtFin.UseVisualStyleBackColor = true;
            this.BtFin.Click += new System.EventHandler(this.BtFin_Click);
            // 
            // BtAjouter
            // 
            this.BtAjouter.Location = new System.Drawing.Point(263, 299);
            this.BtAjouter.Name = "BtAjouter";
            this.BtAjouter.Size = new System.Drawing.Size(109, 25);
            this.BtAjouter.TabIndex = 13;
            this.BtAjouter.Text = "Ajouter";
            this.BtAjouter.UseVisualStyleBackColor = true;
            this.BtAjouter.Click += new System.EventHandler(this.BtAjouter_Click);
            // 
            // BtModifier
            // 
            this.BtModifier.Location = new System.Drawing.Point(264, 335);
            this.BtModifier.Name = "BtModifier";
            this.BtModifier.Size = new System.Drawing.Size(109, 25);
            this.BtModifier.TabIndex = 14;
            this.BtModifier.Text = "Modifier";
            this.BtModifier.UseVisualStyleBackColor = true;
            this.BtModifier.Click += new System.EventHandler(this.BtModifier_Click);
            // 
            // BtSupprimer
            // 
            this.BtSupprimer.Location = new System.Drawing.Point(263, 375);
            this.BtSupprimer.Name = "BtSupprimer";
            this.BtSupprimer.Size = new System.Drawing.Size(109, 25);
            this.BtSupprimer.TabIndex = 15;
            this.BtSupprimer.Text = "Supprimer";
            this.BtSupprimer.UseVisualStyleBackColor = true;
            this.BtSupprimer.Click += new System.EventHandler(this.BtSupprimer_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.entrepriseRowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 149);
            this.dataGridView1.TabIndex = 17;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // entrepriseRowDataGridViewTextBoxColumn
            // 
            this.entrepriseRowDataGridViewTextBoxColumn.DataPropertyName = "EntrepriseRow";
            this.entrepriseRowDataGridViewTextBoxColumn.HeaderText = "EntrepriseRow";
            this.entrepriseRowDataGridViewTextBoxColumn.Name = "entrepriseRowDataGridViewTextBoxColumn";
            // 
            // BtNouveau
            // 
            this.BtNouveau.Location = new System.Drawing.Point(264, 410);
            this.BtNouveau.Name = "BtNouveau";
            this.BtNouveau.Size = new System.Drawing.Size(109, 25);
            this.BtNouveau.TabIndex = 18;
            this.BtNouveau.Text = "Nouveau";
            this.BtNouveau.UseVisualStyleBackColor = true;
            this.BtNouveau.Click += new System.EventHandler(this.BtNouveau_Click);
            // 
            // txtNomR
            // 
            this.txtNomR.Location = new System.Drawing.Point(28, 29);
            this.txtNomR.Name = "txtNomR";
            this.txtNomR.Size = new System.Drawing.Size(137, 20);
            this.txtNomR.TabIndex = 19;
            // 
            // BTChercher
            // 
            this.BTChercher.Location = new System.Drawing.Point(205, 26);
            this.BTChercher.Name = "BTChercher";
            this.BTChercher.Size = new System.Drawing.Size(124, 25);
            this.BTChercher.TabIndex = 20;
            this.BTChercher.Text = "Chercher";
            this.BTChercher.UseVisualStyleBackColor = true;
            this.BTChercher.Click += new System.EventHandler(this.BTChercher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 449);
            this.Controls.Add(this.BTChercher);
            this.Controls.Add(this.txtNomR);
            this.Controls.Add(this.BtNouveau);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtSupprimer);
            this.Controls.Add(this.BtModifier);
            this.Controls.Add(this.BtAjouter);
            this.Controls.Add(this.BtFin);
            this.Controls.Add(this.btSuivant);
            this.Controls.Add(this.btPrecedent);
            this.Controls.Add(this.btDebut);
            this.Controls.Add(this.CmbEntreprise);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entrepriseRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Nom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.ComboBox CmbEntreprise;
        private System.Windows.Forms.Button btDebut;
        private System.Windows.Forms.Button btPrecedent;
        private System.Windows.Forms.Button btSuivant;
        private System.Windows.Forms.Button BtFin;
        private System.Windows.Forms.Button BtAjouter;
        private System.Windows.Forms.Button BtModifier;
        private System.Windows.Forms.Button BtSupprimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entrepriseRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource entrepriseRowBindingSource;
        private System.Windows.Forms.Button BtNouveau;
        private System.Windows.Forms.TextBox txtNomR;
        private System.Windows.Forms.Button BTChercher;
    }
}

