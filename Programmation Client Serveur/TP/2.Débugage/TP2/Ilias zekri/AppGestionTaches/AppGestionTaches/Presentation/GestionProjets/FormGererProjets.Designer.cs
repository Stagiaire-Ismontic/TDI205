namespace AppGestionTaches.Presentation.GestionProjets
{
    partial class FormGererProjets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_Titre = new System.Windows.Forms.TextBox();
            this.Txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_date_Creation = new System.Windows.Forms.Label();
            this.lbl_date_Modification = new System.Windows.Forms.Label();
            this.Btn_Debut = new System.Windows.Forms.Button();
            this.Btn_Precedant = new System.Windows.Forms.Button();
            this.Btn_Suivant = new System.Windows.Forms.Button();
            this.Btn_Fin = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Btn_Nouveau = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewProjets = new System.Windows.Forms.DataGridView();
            this.Titre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCreation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupebox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjets)).BeginInit();
            this.groupebox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "DateCreation";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DateModification";
            // 
            // Txt_Titre
            // 
            this.Txt_Titre.Location = new System.Drawing.Point(106, 27);
            this.Txt_Titre.Name = "Txt_Titre";
            this.Txt_Titre.Size = new System.Drawing.Size(421, 20);
            this.Txt_Titre.TabIndex = 4;
            // 
            // Txt_Description
            // 
            this.Txt_Description.Location = new System.Drawing.Point(106, 57);
            this.Txt_Description.Multiline = true;
            this.Txt_Description.Name = "Txt_Description";
            this.Txt_Description.Size = new System.Drawing.Size(421, 95);
            this.Txt_Description.TabIndex = 5;
            // 
            // lbl_date_Creation
            // 
            this.lbl_date_Creation.AutoSize = true;
            this.lbl_date_Creation.Location = new System.Drawing.Point(118, 165);
            this.lbl_date_Creation.Name = "lbl_date_Creation";
            this.lbl_date_Creation.Size = new System.Drawing.Size(10, 13);
            this.lbl_date_Creation.TabIndex = 6;
            this.lbl_date_Creation.Text = "-";
            // 
            // lbl_date_Modification
            // 
            this.lbl_date_Modification.AutoSize = true;
            this.lbl_date_Modification.Location = new System.Drawing.Point(118, 196);
            this.lbl_date_Modification.Name = "lbl_date_Modification";
            this.lbl_date_Modification.Size = new System.Drawing.Size(10, 13);
            this.lbl_date_Modification.TabIndex = 7;
            this.lbl_date_Modification.Text = "-";
            // 
            // Btn_Debut
            // 
            this.Btn_Debut.Location = new System.Drawing.Point(16, 22);
            this.Btn_Debut.Name = "Btn_Debut";
            this.Btn_Debut.Size = new System.Drawing.Size(75, 23);
            this.Btn_Debut.TabIndex = 8;
            this.Btn_Debut.Text = "Debut";
            this.Btn_Debut.UseVisualStyleBackColor = true;
            this.Btn_Debut.Click += new System.EventHandler(this.Btn_Debut_Click);
            // 
            // Btn_Precedant
            // 
            this.Btn_Precedant.Location = new System.Drawing.Point(97, 22);
            this.Btn_Precedant.Name = "Btn_Precedant";
            this.Btn_Precedant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Precedant.TabIndex = 9;
            this.Btn_Precedant.Text = "Precedant";
            this.Btn_Precedant.UseVisualStyleBackColor = true;
            this.Btn_Precedant.Click += new System.EventHandler(this.Btn_Precedant_Click);
            // 
            // Btn_Suivant
            // 
            this.Btn_Suivant.Location = new System.Drawing.Point(178, 22);
            this.Btn_Suivant.Name = "Btn_Suivant";
            this.Btn_Suivant.Size = new System.Drawing.Size(75, 23);
            this.Btn_Suivant.TabIndex = 10;
            this.Btn_Suivant.Text = "Suivant";
            this.Btn_Suivant.UseVisualStyleBackColor = true;
            this.Btn_Suivant.Click += new System.EventHandler(this.Btn_Suivant_Click);
            // 
            // Btn_Fin
            // 
            this.Btn_Fin.Location = new System.Drawing.Point(260, 21);
            this.Btn_Fin.Name = "Btn_Fin";
            this.Btn_Fin.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fin.TabIndex = 11;
            this.Btn_Fin.Text = "Fin";
            this.Btn_Fin.UseVisualStyleBackColor = true;
            this.Btn_Fin.Click += new System.EventHandler(this.Btn_Fin_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(598, 124);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modifier.TabIndex = 12;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.Location = new System.Drawing.Point(598, 85);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Enregistrer.TabIndex = 13;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Btn_Nouveau
            // 
            this.Btn_Nouveau.Location = new System.Drawing.Point(598, 44);
            this.Btn_Nouveau.Name = "Btn_Nouveau";
            this.Btn_Nouveau.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nouveau.TabIndex = 14;
            this.Btn_Nouveau.Text = "Nouveau";
            this.Btn_Nouveau.UseVisualStyleBackColor = true;
            this.Btn_Nouveau.Click += new System.EventHandler(this.Btn_Nouveau_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Location = new System.Drawing.Point(598, 159);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Supprimer.TabIndex = 15;
            this.Btn_Supprimer.Text = "Supprimer";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Titre);
            this.groupBox1.Controls.Add(this.Txt_Description);
            this.groupBox1.Controls.Add(this.lbl_date_Creation);
            this.groupBox1.Controls.Add(this.lbl_date_Modification);
            this.groupBox1.Location = new System.Drawing.Point(12, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(549, 225);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Projet";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(351, 26);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(10, 13);
            this.lbl_Id.TabIndex = 17;
            this.lbl_Id.Text = "-";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Debut);
            this.groupBox2.Controls.Add(this.lbl_Id);
            this.groupBox2.Controls.Add(this.Btn_Precedant);
            this.groupBox2.Controls.Add(this.Btn_Suivant);
            this.groupBox2.Controls.Add(this.Btn_Fin);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(399, 63);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Navigation";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // dataGridViewProjets
            // 
            this.dataGridViewProjets.AllowUserToAddRows = false;
            this.dataGridViewProjets.AllowUserToDeleteRows = false;
            this.dataGridViewProjets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProjets.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titre,
            this.Description,
            this.DateCreation});
            this.dataGridViewProjets.Location = new System.Drawing.Point(6, 34);
            this.dataGridViewProjets.Name = "dataGridViewProjets";
            this.dataGridViewProjets.ReadOnly = true;
            this.dataGridViewProjets.Size = new System.Drawing.Size(649, 195);
            this.dataGridViewProjets.TabIndex = 20;
            this.dataGridViewProjets.SelectionChanged += new System.EventHandler(this.dataGridViewProjets_SelectionChanged);
            this.dataGridViewProjets.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridViewProjets_MouseClick);
            // 
            // Titre
            // 
            this.Titre.DataPropertyName = "Titre";
            this.Titre.HeaderText = "Nom de Projets";
            this.Titre.Name = "Titre";
            this.Titre.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 300;
            // 
            // DateCreation
            // 
            this.DateCreation.DataPropertyName = "DateCreation1";
            this.DateCreation.HeaderText = "Date de Creation";
            this.DateCreation.Name = "DateCreation";
            this.DateCreation.ReadOnly = true;
            this.DateCreation.Width = 200;
            // 
            // groupebox3
            // 
            this.groupebox3.Controls.Add(this.dataGridViewProjets);
            this.groupebox3.Location = new System.Drawing.Point(12, 334);
            this.groupebox3.Name = "groupebox3";
            this.groupebox3.Size = new System.Drawing.Size(661, 229);
            this.groupebox3.TabIndex = 21;
            this.groupebox3.TabStop = false;
            this.groupebox3.Text = "Projets";
            // 
            // FormGererProjets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 575);
            this.Controls.Add(this.groupebox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_Supprimer);
            this.Controls.Add(this.Btn_Nouveau);
            this.Controls.Add(this.Btn_Enregistrer);
            this.Controls.Add(this.Btn_Modifier);
            this.Name = "FormGererProjets";
            this.Text = "Gerer les projets";
            this.Load += new System.EventHandler(this.FormGererProjets_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProjets)).EndInit();
            this.groupebox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_Titre;
        private System.Windows.Forms.TextBox Txt_Description;
        private System.Windows.Forms.Label lbl_date_Creation;
        private System.Windows.Forms.Label lbl_date_Modification;
        private System.Windows.Forms.Button Btn_Debut;
        private System.Windows.Forms.Button Btn_Precedant;
        private System.Windows.Forms.Button Btn_Suivant;
        private System.Windows.Forms.Button Btn_Fin;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Button Btn_Nouveau;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewProjets;
        private System.Windows.Forms.GroupBox groupebox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateCreation;
    }
}