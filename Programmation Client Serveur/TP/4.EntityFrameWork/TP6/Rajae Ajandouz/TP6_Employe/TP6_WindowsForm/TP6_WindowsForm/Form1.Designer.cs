namespace TP6_WindowsForm
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
            this.text_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnRech = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_catg = new System.Windows.Forms.TextBox();
            this.text_rech = new System.Windows.Forms.TextBox();
            this.text_titre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_id
            // 
            this.text_id.Location = new System.Drawing.Point(121, 24);
            this.text_id.Name = "text_id";
            this.text_id.Size = new System.Drawing.Size(195, 20);
            this.text_id.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "idEmploye";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(532, 166);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(97, 33);
            this.btnAnnuler.TabIndex = 21;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(365, 156);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(97, 33);
            this.btnMod.TabIndex = 20;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(532, 16);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(97, 33);
            this.btnSup.TabIndex = 19;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(551, 432);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(97, 33);
            this.btnFermer.TabIndex = 18;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnRech
            // 
            this.btnRech.Location = new System.Drawing.Point(366, 84);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(97, 33);
            this.btnRech.TabIndex = 22;
            this.btnRech.Text = "Rechercher";
            this.btnRech.UseVisualStyleBackColor = true;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(365, 21);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 33);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(120, 173);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(195, 20);
            this.text_nom.TabIndex = 16;
            // 
            // text_catg
            // 
            this.text_catg.Location = new System.Drawing.Point(135, 124);
            this.text_catg.Name = "text_catg";
            this.text_catg.Size = new System.Drawing.Size(195, 20);
            this.text_catg.TabIndex = 15;
            // 
            // text_rech
            // 
            this.text_rech.Location = new System.Drawing.Point(487, 91);
            this.text_rech.Name = "text_rech";
            this.text_rech.Size = new System.Drawing.Size(161, 20);
            this.text_rech.TabIndex = 14;
            // 
            // text_titre
            // 
            this.text_titre.Location = new System.Drawing.Point(120, 71);
            this.text_titre.Name = "text_titre";
            this.text_titre.Size = new System.Drawing.Size(195, 20);
            this.text_titre.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "adress";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "PRenom_Employe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-4, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "NOM_EMPOYE:";
            // 
            // dataGV1
            // 
            this.dataGV1.AllowUserToAddRows = false;
            this.dataGV1.AllowUserToDeleteRows = false;
            this.dataGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGV1.Location = new System.Drawing.Point(14, 245);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.ReadOnly = true;
            this.dataGV1.Size = new System.Drawing.Size(449, 182);
            this.dataGV1.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Titre";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Categorie";
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Nom_auteur";
            this.Column4.HeaderText = "Adress";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 485);
            this.Controls.Add(this.text_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.text_catg);
            this.Controls.Add(this.text_rech);
            this.Controls.Add(this.text_titre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_catg;
        private System.Windows.Forms.TextBox text_rech;
        private System.Windows.Forms.TextBox text_titre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGV1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

