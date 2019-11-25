namespace Gestion_des_livre
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
            this.dataGV1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_rech = new System.Windows.Forms.TextBox();
            this.text_groupe = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnRech = new System.Windows.Forms.Button();
            this.btnMod = new System.Windows.Forms.Button();
            this.bSuivant = new System.Windows.Forms.Button();
            this.bFin = new System.Windows.Forms.Button();
            this.bDebut = new System.Windows.Forms.Button();
            this.bPrecedant = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.text_prenom = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_Afficher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGV1.Location = new System.Drawing.Point(14, 213);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.ReadOnly = true;
            this.dataGV1.Size = new System.Drawing.Size(449, 182);
            this.dataGV1.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "ID Stagiaire";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prenom";
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Groupe";
            this.Column4.HeaderText = "Groupe";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom Stagiaire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Prenom Stagiaire";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Groupe Stagiaire";
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(137, 42);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(195, 20);
            this.text_nom.TabIndex = 2;
            // 
            // text_rech
            // 
            this.text_rech.Location = new System.Drawing.Point(469, 106);
            this.text_rech.Name = "text_rech";
            this.text_rech.Size = new System.Drawing.Size(161, 20);
            this.text_rech.TabIndex = 2;
            // 
            // text_groupe
            // 
            this.text_groupe.Location = new System.Drawing.Point(137, 144);
            this.text_groupe.Name = "text_groupe";
            this.text_groupe.Size = new System.Drawing.Size(195, 20);
            this.text_groupe.TabIndex = 2;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(366, 12);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(97, 33);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSup
            // 
            this.btnSup.Location = new System.Drawing.Point(514, 147);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(97, 33);
            this.btnSup.TabIndex = 3;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnRech
            // 
            this.btnRech.Location = new System.Drawing.Point(366, 99);
            this.btnRech.Name = "btnRech";
            this.btnRech.Size = new System.Drawing.Size(97, 33);
            this.btnRech.TabIndex = 3;
            this.btnRech.Text = "Rechercher";
            this.btnRech.UseVisualStyleBackColor = true;
            this.btnRech.Click += new System.EventHandler(this.btnRech_Click);
            // 
            // btnMod
            // 
            this.btnMod.Location = new System.Drawing.Point(366, 147);
            this.btnMod.Name = "btnMod";
            this.btnMod.Size = new System.Drawing.Size(97, 33);
            this.btnMod.TabIndex = 3;
            this.btnMod.Text = "Modifier";
            this.btnMod.UseVisualStyleBackColor = true;
            this.btnMod.Click += new System.EventHandler(this.btnMod_Click);
            // 
            // bSuivant
            // 
            this.bSuivant.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSuivant.Location = new System.Drawing.Point(273, 412);
            this.bSuivant.Name = "bSuivant";
            this.bSuivant.Size = new System.Drawing.Size(97, 33);
            this.bSuivant.TabIndex = 3;
            this.bSuivant.Text = ">>>";
            this.bSuivant.UseVisualStyleBackColor = true;
            this.bSuivant.Click += new System.EventHandler(this.bSuivant_Click);
            // 
            // bFin
            // 
            this.bFin.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFin.Location = new System.Drawing.Point(406, 411);
            this.bFin.Name = "bFin";
            this.bFin.Size = new System.Drawing.Size(97, 33);
            this.bFin.TabIndex = 3;
            this.bFin.Text = "--->";
            this.bFin.UseVisualStyleBackColor = true;
            this.bFin.Click += new System.EventHandler(this.bFin_Click);
            // 
            // bDebut
            // 
            this.bDebut.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDebut.Location = new System.Drawing.Point(21, 412);
            this.bDebut.Name = "bDebut";
            this.bDebut.Size = new System.Drawing.Size(97, 33);
            this.bDebut.TabIndex = 3;
            this.bDebut.Text = "<---";
            this.bDebut.UseVisualStyleBackColor = true;
            this.bDebut.Click += new System.EventHandler(this.bDebut_Click);
            // 
            // bPrecedant
            // 
            this.bPrecedant.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrecedant.Location = new System.Drawing.Point(154, 411);
            this.bPrecedant.Name = "bPrecedant";
            this.bPrecedant.Size = new System.Drawing.Size(97, 33);
            this.bPrecedant.TabIndex = 3;
            this.bPrecedant.Text = "<<<";
            this.bPrecedant.UseVisualStyleBackColor = true;
            this.bPrecedant.Click += new System.EventHandler(this.bPrecedant_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(551, 438);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(97, 33);
            this.btnFermer.TabIndex = 3;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(551, 384);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(97, 33);
            this.btnAnnuler.TabIndex = 3;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // text_prenom
            // 
            this.text_prenom.Location = new System.Drawing.Point(137, 95);
            this.text_prenom.Name = "text_prenom";
            this.text_prenom.Size = new System.Drawing.Size(195, 20);
            this.text_prenom.TabIndex = 2;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ID.Location = new System.Drawing.Point(534, 285);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(25, 25);
            this.label_ID.TabIndex = 1;
            this.label_ID.Text = "0";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(476, 248);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(173, 20);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Nombre de Stagiaire";
            // 
            // btn_Afficher
            // 
            this.btn_Afficher.Location = new System.Drawing.Point(366, 51);
            this.btn_Afficher.Name = "btn_Afficher";
            this.btn_Afficher.Size = new System.Drawing.Size(92, 33);
            this.btn_Afficher.TabIndex = 5;
            this.btn_Afficher.Text = "Afficher";
            this.btn_Afficher.UseVisualStyleBackColor = true;
            this.btn_Afficher.Click += new System.EventHandler(this.btn_Afficher_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 483);
            this.Controls.Add(this.btn_Afficher);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.bPrecedant);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.bFin);
            this.Controls.Add(this.btnMod);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.bDebut);
            this.Controls.Add(this.bSuivant);
            this.Controls.Add(this.btnRech);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.text_groupe);
            this.Controls.Add(this.text_prenom);
            this.Controls.Add(this.text_rech);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.label_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGV1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_rech;
        private System.Windows.Forms.TextBox text_groupe;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnRech;
        private System.Windows.Forms.Button btnMod;
        private System.Windows.Forms.Button bSuivant;
        private System.Windows.Forms.Button bFin;
        private System.Windows.Forms.Button bDebut;
        private System.Windows.Forms.Button bPrecedant;
        private System.Windows.Forms.Button btnFermer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.TextBox text_prenom;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_Afficher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}

