namespace GestionStockLINQ
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
            this.btn_rechercher = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_afficher = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_nouveau = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_quantite = new System.Windows.Forms.TextBox();
            this.txt_prixu = new System.Windows.Forms.TextBox();
            this.txt_designation = new System.Windows.Forms.TextBox();
            this.txt_codearticle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Location = new System.Drawing.Point(342, 322);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Size = new System.Drawing.Size(129, 37);
            this.btn_rechercher.TabIndex = 20;
            this.btn_rechercher.Text = "Rechercher";
            this.btn_rechercher.UseVisualStyleBackColor = true;
            this.btn_rechercher.Click += new System.EventHandler(this.Btn_rechercher_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(1129, 409);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(129, 38);
            this.btn_fermer.TabIndex = 14;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.Btn_fermer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(342, 277);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(129, 38);
            this.btn_supprimer.TabIndex = 15;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.Btn_supprimer_Click);
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(207, 277);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(129, 38);
            this.btn_ajouter.TabIndex = 16;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.Btn_ajouter_Click);
            // 
            // btn_afficher
            // 
            this.btn_afficher.Location = new System.Drawing.Point(207, 321);
            this.btn_afficher.Name = "btn_afficher";
            this.btn_afficher.Size = new System.Drawing.Size(129, 38);
            this.btn_afficher.TabIndex = 17;
            this.btn_afficher.Text = "Afficher";
            this.btn_afficher.UseVisualStyleBackColor = true;
            this.btn_afficher.Click += new System.EventHandler(this.Btn_afficher_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(72, 321);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(129, 38);
            this.btn_modifier.TabIndex = 18;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.Btn_modifier_Click);
            // 
            // btn_nouveau
            // 
            this.btn_nouveau.Location = new System.Drawing.Point(72, 277);
            this.btn_nouveau.Name = "btn_nouveau";
            this.btn_nouveau.Size = new System.Drawing.Size(129, 38);
            this.btn_nouveau.TabIndex = 19;
            this.btn_nouveau.Text = "Nouveau";
            this.btn_nouveau.UseVisualStyleBackColor = true;
            this.btn_nouveau.Click += new System.EventHandler(this.Btn_nouveau_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(555, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(703, 319);
            this.dataGridView1.TabIndex = 13;
            // 
            // txt_quantite
            // 
            this.txt_quantite.Location = new System.Drawing.Point(302, 197);
            this.txt_quantite.Name = "txt_quantite";
            this.txt_quantite.Size = new System.Drawing.Size(169, 27);
            this.txt_quantite.TabIndex = 9;
            // 
            // txt_prixu
            // 
            this.txt_prixu.Location = new System.Drawing.Point(302, 143);
            this.txt_prixu.Name = "txt_prixu";
            this.txt_prixu.Size = new System.Drawing.Size(169, 27);
            this.txt_prixu.TabIndex = 10;
            // 
            // txt_designation
            // 
            this.txt_designation.Location = new System.Drawing.Point(302, 88);
            this.txt_designation.Name = "txt_designation";
            this.txt_designation.Size = new System.Drawing.Size(169, 27);
            this.txt_designation.TabIndex = 11;
            // 
            // txt_codearticle
            // 
            this.txt_codearticle.Location = new System.Drawing.Point(302, 34);
            this.txt_codearticle.Name = "txt_codearticle";
            this.txt_codearticle.Size = new System.Drawing.Size(169, 27);
            this.txt_codearticle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Quantite  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(108, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prix U.T :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Designation :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Code d\'Article :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 459);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.btn_afficher);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_nouveau);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_quantite);
            this.Controls.Add(this.txt_prixu);
            this.Controls.Add(this.txt_designation);
            this.Controls.Add(this.txt_codearticle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_rechercher;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_afficher;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_nouveau;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_quantite;
        private System.Windows.Forms.TextBox txt_prixu;
        private System.Windows.Forms.TextBox txt_designation;
        private System.Windows.Forms.TextBox txt_codearticle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

