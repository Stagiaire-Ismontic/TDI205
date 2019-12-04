namespace Gestion_Editeurs
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
            this.txt_ID_Editeur = new System.Windows.Forms.Label();
            this.txt_nom_Editeur = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Ajouter = new System.Windows.Forms.Button();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.btn_Vider = new System.Windows.Forms.Button();
            this.btn_Modifier = new System.Windows.Forms.Button();
            this.btn_rech = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.txt_cat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_ID_Editeur
            // 
            this.txt_ID_Editeur.AutoSize = true;
            this.txt_ID_Editeur.Location = new System.Drawing.Point(13, 25);
            this.txt_ID_Editeur.Name = "txt_ID_Editeur";
            this.txt_ID_Editeur.Size = new System.Drawing.Size(57, 13);
            this.txt_ID_Editeur.TabIndex = 0;
            this.txt_ID_Editeur.Text = "ID_Editeur";
            // 
            // txt_nom_Editeur
            // 
            this.txt_nom_Editeur.AutoSize = true;
            this.txt_nom_Editeur.Location = new System.Drawing.Point(13, 68);
            this.txt_nom_Editeur.Name = "txt_nom_Editeur";
            this.txt_nom_Editeur.Size = new System.Drawing.Size(68, 13);
            this.txt_nom_Editeur.TabIndex = 1;
            this.txt_nom_Editeur.Text = "Nom_Editeur";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(87, 25);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 3;
            // 
            // txt_Nom
            // 
            this.txt_Nom.Location = new System.Drawing.Point(87, 61);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(100, 20);
            this.txt_Nom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Categorie";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(316, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(419, 198);
            this.dataGridView1.TabIndex = 8;
            // 
            // btn_Ajouter
            // 
            this.btn_Ajouter.Location = new System.Drawing.Point(16, 250);
            this.btn_Ajouter.Name = "btn_Ajouter";
            this.btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.btn_Ajouter.TabIndex = 9;
            this.btn_Ajouter.Text = "Ajouter";
            this.btn_Ajouter.UseVisualStyleBackColor = true;
            this.btn_Ajouter.Click += new System.EventHandler(this.btn_Ajouter_Click);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.Location = new System.Drawing.Point(112, 250);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(75, 23);
            this.btn_Enregistrer.TabIndex = 10;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = true;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(16, 294);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(75, 23);
            this.btn_supprimer.TabIndex = 11;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_Vider
            // 
            this.btn_Vider.Location = new System.Drawing.Point(112, 293);
            this.btn_Vider.Name = "btn_Vider";
            this.btn_Vider.Size = new System.Drawing.Size(75, 23);
            this.btn_Vider.TabIndex = 12;
            this.btn_Vider.Text = "Vider";
            this.btn_Vider.UseVisualStyleBackColor = true;
            this.btn_Vider.Click += new System.EventHandler(this.btn_Vider_Click);
            // 
            // btn_Modifier
            // 
            this.btn_Modifier.Location = new System.Drawing.Point(16, 341);
            this.btn_Modifier.Name = "btn_Modifier";
            this.btn_Modifier.Size = new System.Drawing.Size(75, 23);
            this.btn_Modifier.TabIndex = 13;
            this.btn_Modifier.Text = "Modifier";
            this.btn_Modifier.UseVisualStyleBackColor = true;
            this.btn_Modifier.Click += new System.EventHandler(this.btn_Modifier_Click);
            // 
            // btn_rech
            // 
            this.btn_rech.Location = new System.Drawing.Point(112, 341);
            this.btn_rech.Name = "btn_rech";
            this.btn_rech.Size = new System.Drawing.Size(75, 23);
            this.btn_rech.TabIndex = 16;
            this.btn_rech.Text = "Rechercher";
            this.btn_rech.UseVisualStyleBackColor = true;
            this.btn_rech.Click += new System.EventHandler(this.btn_rech_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.Location = new System.Drawing.Point(202, 294);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(75, 23);
            this.btn_quitter.TabIndex = 17;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = true;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // txt_cat
            // 
            this.txt_cat.Location = new System.Drawing.Point(87, 100);
            this.txt_cat.Name = "txt_cat";
            this.txt_cat.Size = new System.Drawing.Size(100, 20);
            this.txt_cat.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 416);
            this.Controls.Add(this.txt_cat);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_rech);
            this.Controls.Add(this.btn_Modifier);
            this.Controls.Add(this.btn_Vider);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.btn_Ajouter);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_nom_Editeur);
            this.Controls.Add(this.txt_ID_Editeur);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_ID_Editeur;
        private System.Windows.Forms.Label txt_nom_Editeur;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Ajouter;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button btn_Vider;
        private System.Windows.Forms.Button btn_Modifier;
        private System.Windows.Forms.Button btn_rech;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.TextBox txt_cat;
    }
}

