namespace TP2_DataSet_ApplForm
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_idd = new System.Windows.Forms.TextBox();
            this.text_NomAut = new System.Windows.Forms.TextBox();
            this.combo_categ = new System.Windows.Forms.ComboBox();
            this.text_titre = new System.Windows.Forms.TextBox();
            this.btn_debut = new System.Windows.Forms.Button();
            this.btn_precedent = new System.Windows.Forms.Button();
            this.btn_suivant = new System.Windows.Forms.Button();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_dernier = new System.Windows.Forms.Button();
            this.livreRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new TP2_DataSet_ApplForm.DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categorieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomauteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Livre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Titre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Categorie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nom auteur";
            // 
            // text_idd
            // 
            this.text_idd.Location = new System.Drawing.Point(86, 22);
            this.text_idd.Name = "text_idd";
            this.text_idd.Size = new System.Drawing.Size(106, 20);
            this.text_idd.TabIndex = 1;
            // 
            // text_NomAut
            // 
            this.text_NomAut.Location = new System.Drawing.Point(86, 140);
            this.text_NomAut.Name = "text_NomAut";
            this.text_NomAut.Size = new System.Drawing.Size(106, 20);
            this.text_NomAut.TabIndex = 1;
            // 
            // combo_categ
            // 
            this.combo_categ.FormattingEnabled = true;
            this.combo_categ.Location = new System.Drawing.Point(86, 106);
            this.combo_categ.Name = "combo_categ";
            this.combo_categ.Size = new System.Drawing.Size(106, 21);
            this.combo_categ.TabIndex = 2;
            // 
            // text_titre
            // 
            this.text_titre.Location = new System.Drawing.Point(86, 62);
            this.text_titre.Name = "text_titre";
            this.text_titre.Size = new System.Drawing.Size(106, 20);
            this.text_titre.TabIndex = 1;
            // 
            // btn_debut
            // 
            this.btn_debut.Location = new System.Drawing.Point(12, 180);
            this.btn_debut.Name = "btn_debut";
            this.btn_debut.Size = new System.Drawing.Size(87, 35);
            this.btn_debut.TabIndex = 3;
            this.btn_debut.Text = "Debut";
            this.btn_debut.UseVisualStyleBackColor = true;
            this.btn_debut.Click += new System.EventHandler(this.btn_debut_Click);
            // 
            // btn_precedent
            // 
            this.btn_precedent.Location = new System.Drawing.Point(118, 180);
            this.btn_precedent.Name = "btn_precedent";
            this.btn_precedent.Size = new System.Drawing.Size(87, 35);
            this.btn_precedent.TabIndex = 3;
            this.btn_precedent.Text = "Precedent";
            this.btn_precedent.UseVisualStyleBackColor = true;
            this.btn_precedent.Click += new System.EventHandler(this.btn_precedent_Click);
            // 
            // btn_suivant
            // 
            this.btn_suivant.Location = new System.Drawing.Point(231, 180);
            this.btn_suivant.Name = "btn_suivant";
            this.btn_suivant.Size = new System.Drawing.Size(87, 35);
            this.btn_suivant.TabIndex = 3;
            this.btn_suivant.Text = "Suivant";
            this.btn_suivant.UseVisualStyleBackColor = true;
            this.btn_suivant.Click += new System.EventHandler(this.btn_suivant_Click);
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(211, 36);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(87, 39);
            this.btn_Ajouter.TabIndex = 3;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(211, 109);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(87, 39);
            this.btn_modifier.TabIndex = 3;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(321, 109);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(87, 39);
            this.btn_rechercher.TabIndex = 3;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(321, 36);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(87, 39);
            this.btn_supprimer.TabIndex = 3;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_dernier
            // 
            this.btn_dernier.Location = new System.Drawing.Point(335, 180);
            this.btn_dernier.Name = "btn_dernier";
            this.btn_dernier.Size = new System.Drawing.Size(87, 35);
            this.btn_dernier.TabIndex = 3;
            this.btn_dernier.Text = "Dernier";
            this.btn_dernier.UseVisualStyleBackColor = true;
            this.btn_dernier.Click += new System.EventHandler(this.btn_dernier_Click);
            // 
            // livreRowBindingSource
            // 
            this.livreRowBindingSource.DataSource = typeof(TP2_DataSet_ApplForm.DataSet1.LivreRow);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titreDataGridViewTextBoxColumn,
            this.categorieDataGridViewTextBoxColumn,
            this.nomauteurDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(15, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(449, 154);
            this.dataGridView1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(TP2_DataSet_ApplForm.DataSet1.LivreRow);
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
            // nomauteurDataGridViewTextBoxColumn
            // 
            this.nomauteurDataGridViewTextBoxColumn.DataPropertyName = "nom_auteur";
            this.nomauteurDataGridViewTextBoxColumn.HeaderText = "nom_auteur";
            this.nomauteurDataGridViewTextBoxColumn.Name = "nomauteurDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 389);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_dernier);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.btn_suivant);
            this.Controls.Add(this.btn_precedent);
            this.Controls.Add(this.btn_debut);
            this.Controls.Add(this.combo_categ);
            this.Controls.Add(this.text_NomAut);
            this.Controls.Add(this.text_titre);
            this.Controls.Add(this.text_idd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.livreRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox text_idd;
        private System.Windows.Forms.TextBox text_NomAut;
        private System.Windows.Forms.ComboBox combo_categ;
        private System.Windows.Forms.TextBox text_titre;
        private System.Windows.Forms.Button btn_debut;
        private System.Windows.Forms.Button btn_precedent;
        private System.Windows.Forms.Button btn_suivant;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_dernier;
        private System.Windows.Forms.BindingSource livreRowBindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categorieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomauteurDataGridViewTextBoxColumn;
    }
}

