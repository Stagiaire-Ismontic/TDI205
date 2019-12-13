namespace WindowsFormsApplication1
{
    partial class Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_num = new System.Windows.Forms.TextBox();
            this.text_nom = new System.Windows.Forms.TextBox();
            this.text_nbStg = new System.Windows.Forms.TextBox();
            this.btn_ajouter = new System.Windows.Forms.Button();
            this.btn_rech = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_annuler = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.text_recherche = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpB1 = new System.Windows.Forms.GroupBox();
            this.btn_appliquer = new System.Windows.Forms.Button();
            this.btnAnuler2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNb2 = new System.Windows.Forms.TextBox();
            this.textNom2 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.text_mod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.gpB1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom de Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre de Stag";
            // 
            // text_num
            // 
            this.text_num.Location = new System.Drawing.Point(175, 23);
            this.text_num.Margin = new System.Windows.Forms.Padding(4);
            this.text_num.Name = "text_num";
            this.text_num.Size = new System.Drawing.Size(189, 22);
            this.text_num.TabIndex = 3;
            // 
            // text_nom
            // 
            this.text_nom.Location = new System.Drawing.Point(176, 61);
            this.text_nom.Margin = new System.Windows.Forms.Padding(4);
            this.text_nom.Name = "text_nom";
            this.text_nom.Size = new System.Drawing.Size(189, 22);
            this.text_nom.TabIndex = 3;
            // 
            // text_nbStg
            // 
            this.text_nbStg.Location = new System.Drawing.Point(175, 102);
            this.text_nbStg.Margin = new System.Windows.Forms.Padding(4);
            this.text_nbStg.Name = "text_nbStg";
            this.text_nbStg.Size = new System.Drawing.Size(189, 22);
            this.text_nbStg.TabIndex = 3;
            // 
            // btn_ajouter
            // 
            this.btn_ajouter.Location = new System.Drawing.Point(385, 23);
            this.btn_ajouter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajouter.Name = "btn_ajouter";
            this.btn_ajouter.Size = new System.Drawing.Size(115, 44);
            this.btn_ajouter.TabIndex = 4;
            this.btn_ajouter.Text = "Ajouter";
            this.btn_ajouter.UseVisualStyleBackColor = true;
            this.btn_ajouter.Click += new System.EventHandler(this.btn_ajouter_Click);
            // 
            // btn_rech
            // 
            this.btn_rech.Location = new System.Drawing.Point(375, 96);
            this.btn_rech.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rech.Name = "btn_rech";
            this.btn_rech.Size = new System.Drawing.Size(109, 44);
            this.btn_rech.TabIndex = 4;
            this.btn_rech.Text = "Rechercher";
            this.btn_rech.UseVisualStyleBackColor = true;
            this.btn_rech.Click += new System.EventHandler(this.btn_rech_Click);
            // 
            // btn_mod
            // 
            this.btn_mod.Location = new System.Drawing.Point(375, 172);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(91, 44);
            this.btn_mod.TabIndex = 4;
            this.btn_mod.Text = "Modifier";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.btn_mod_Click);
            // 
            // btn_supp
            // 
            this.btn_supp.Location = new System.Drawing.Point(385, 254);
            this.btn_supp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(136, 44);
            this.btn_supp.TabIndex = 4;
            this.btn_supp.Text = "Supprimer";
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.Click += new System.EventHandler(this.btn_supp_Click);
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGV.Location = new System.Drawing.Point(9, 188);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.Size = new System.Drawing.Size(346, 238);
            this.dataGV.TabIndex = 5;
            this.dataGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numero Group";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nom Group";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Stg";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // btn_annuler
            // 
            this.btn_annuler.Location = new System.Drawing.Point(385, 316);
            this.btn_annuler.Margin = new System.Windows.Forms.Padding(4);
            this.btn_annuler.Name = "btn_annuler";
            this.btn_annuler.Size = new System.Drawing.Size(136, 44);
            this.btn_annuler.TabIndex = 4;
            this.btn_annuler.Text = "Annuler";
            this.btn_annuler.UseVisualStyleBackColor = true;
            this.btn_annuler.Click += new System.EventHandler(this.btn_annuler_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.Location = new System.Drawing.Point(385, 368);
            this.btn_fermer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(136, 44);
            this.btn_fermer.TabIndex = 4;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = true;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // text_recherche
            // 
            this.text_recherche.Location = new System.Drawing.Point(663, 102);
            this.text_recherche.Margin = new System.Windows.Forms.Padding(4);
            this.text_recherche.Name = "text_recherche";
            this.text_recherche.Size = new System.Drawing.Size(112, 22);
            this.text_recherche.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(514, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Zone de recherche";
            // 
            // gpB1
            // 
            this.gpB1.Controls.Add(this.btn_appliquer);
            this.gpB1.Controls.Add(this.btnAnuler2);
            this.gpB1.Controls.Add(this.label7);
            this.gpB1.Controls.Add(this.label6);
            this.gpB1.Controls.Add(this.label5);
            this.gpB1.Controls.Add(this.textNb2);
            this.gpB1.Controls.Add(this.textNom2);
            this.gpB1.Controls.Add(this.textNum2);
            this.gpB1.Location = new System.Drawing.Point(537, 212);
            this.gpB1.Name = "gpB1";
            this.gpB1.Size = new System.Drawing.Size(244, 214);
            this.gpB1.TabIndex = 7;
            this.gpB1.TabStop = false;
            this.gpB1.Visible = false;
            // 
            // btn_appliquer
            // 
            this.btn_appliquer.Location = new System.Drawing.Point(25, 169);
            this.btn_appliquer.Name = "btn_appliquer";
            this.btn_appliquer.Size = new System.Drawing.Size(93, 39);
            this.btn_appliquer.TabIndex = 8;
            this.btn_appliquer.Text = "Appliquer";
            this.btn_appliquer.UseVisualStyleBackColor = true;
            this.btn_appliquer.Click += new System.EventHandler(this.btn_appliquer_Click);
            // 
            // btnAnuler2
            // 
            this.btnAnuler2.Location = new System.Drawing.Point(134, 169);
            this.btnAnuler2.Name = "btnAnuler2";
            this.btnAnuler2.Size = new System.Drawing.Size(93, 39);
            this.btnAnuler2.TabIndex = 8;
            this.btnAnuler2.Text = "Annuler";
            this.btnAnuler2.UseVisualStyleBackColor = true;
            this.btnAnuler2.Click += new System.EventHandler(this.btnAnuler2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nom2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "NBStag";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Numero2";
            // 
            // textNb2
            // 
            this.textNb2.Location = new System.Drawing.Point(95, 126);
            this.textNb2.Margin = new System.Windows.Forms.Padding(4);
            this.textNb2.Name = "textNb2";
            this.textNb2.Size = new System.Drawing.Size(132, 22);
            this.textNb2.TabIndex = 4;
            // 
            // textNom2
            // 
            this.textNom2.Location = new System.Drawing.Point(95, 84);
            this.textNom2.Margin = new System.Windows.Forms.Padding(4);
            this.textNom2.Name = "textNom2";
            this.textNom2.Size = new System.Drawing.Size(132, 22);
            this.textNom2.TabIndex = 5;
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(95, 36);
            this.textNum2.Margin = new System.Windows.Forms.Padding(4);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(132, 22);
            this.textNum2.TabIndex = 6;
            // 
            // text_mod
            // 
            this.text_mod.Location = new System.Drawing.Point(663, 183);
            this.text_mod.Margin = new System.Windows.Forms.Padding(4);
            this.text_mod.Name = "text_mod";
            this.text_mod.Size = new System.Drawing.Size(108, 22);
            this.text_mod.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = " recherche pour Modifier";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 453);
            this.Controls.Add(this.gpB1);
            this.Controls.Add(this.text_mod);
            this.Controls.Add(this.text_recherche);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_annuler);
            this.Controls.Add(this.btn_supp);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_rech);
            this.Controls.Add(this.btn_ajouter);
            this.Controls.Add(this.text_nbStg);
            this.Controls.Add(this.text_nom);
            this.Controls.Add(this.text_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.gpB1.ResumeLayout(false);
            this.gpB1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_num;
        private System.Windows.Forms.TextBox text_nom;
        private System.Windows.Forms.TextBox text_nbStg;
        private System.Windows.Forms.Button btn_ajouter;
        private System.Windows.Forms.Button btn_rech;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_annuler;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.TextBox text_recherche;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gpB1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNb2;
        private System.Windows.Forms.TextBox textNom2;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox text_mod;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_appliquer;
        private System.Windows.Forms.Button btnAnuler2;
    }
}

