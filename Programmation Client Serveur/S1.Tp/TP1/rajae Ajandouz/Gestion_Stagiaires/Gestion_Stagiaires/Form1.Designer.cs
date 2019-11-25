namespace Gestion_Stagiaires
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
            this.button_Ajt = new System.Windows.Forms.Button();
            this.button_Aff = new System.Windows.Forms.Button();
            this.button_NV = new System.Windows.Forms.Button();
            this.button_Rech = new System.Windows.Forms.Button();
            this.button_Mod = new System.Windows.Forms.Button();
            this.button_Sup = new System.Windows.Forms.Button();
            this.textId = new System.Windows.Forms.TextBox();
            this.textNom = new System.Windows.Forms.TextBox();
            this.textPrenom = new System.Windows.Forms.TextBox();
            this.texttel = new System.Windows.Forms.TextBox();
            this.textemail = new System.Windows.Forms.TextBox();
            this.textDatN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Ajt
            // 
            this.button_Ajt.Location = new System.Drawing.Point(703, 12);
            this.button_Ajt.Name = "button_Ajt";
            this.button_Ajt.Size = new System.Drawing.Size(75, 23);
            this.button_Ajt.TabIndex = 0;
            this.button_Ajt.Text = "Ajouter";
            this.button_Ajt.UseVisualStyleBackColor = true;
            this.button_Ajt.Click += new System.EventHandler(this.button_Ajt_Click);
            // 
            // button_Aff
            // 
            this.button_Aff.Location = new System.Drawing.Point(703, 55);
            this.button_Aff.Name = "button_Aff";
            this.button_Aff.Size = new System.Drawing.Size(75, 23);
            this.button_Aff.TabIndex = 1;
            this.button_Aff.Text = "afficher";
            this.button_Aff.UseVisualStyleBackColor = true;
            this.button_Aff.Click += new System.EventHandler(this.button_Aff_Click);
            // 
            // button_NV
            // 
            this.button_NV.Location = new System.Drawing.Point(703, 99);
            this.button_NV.Name = "button_NV";
            this.button_NV.Size = new System.Drawing.Size(75, 23);
            this.button_NV.TabIndex = 2;
            this.button_NV.Text = "Nouveau";
            this.button_NV.UseVisualStyleBackColor = true;
            this.button_NV.Click += new System.EventHandler(this.button_NV_Click);
            // 
            // button_Rech
            // 
            this.button_Rech.Location = new System.Drawing.Point(703, 142);
            this.button_Rech.Name = "button_Rech";
            this.button_Rech.Size = new System.Drawing.Size(75, 23);
            this.button_Rech.TabIndex = 3;
            this.button_Rech.Text = "Rechercher";
            this.button_Rech.UseVisualStyleBackColor = true;
            // 
            // button_Mod
            // 
            this.button_Mod.Location = new System.Drawing.Point(703, 183);
            this.button_Mod.Name = "button_Mod";
            this.button_Mod.Size = new System.Drawing.Size(75, 23);
            this.button_Mod.TabIndex = 4;
            this.button_Mod.Text = "Modifier";
            this.button_Mod.UseVisualStyleBackColor = true;
            // 
            // button_Sup
            // 
            this.button_Sup.Location = new System.Drawing.Point(703, 222);
            this.button_Sup.Name = "button_Sup";
            this.button_Sup.Size = new System.Drawing.Size(75, 23);
            this.button_Sup.TabIndex = 5;
            this.button_Sup.Text = "Supprimer";
            this.button_Sup.UseVisualStyleBackColor = true;
            this.button_Sup.Click += new System.EventHandler(this.button_Sup_Click);
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(108, 15);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(100, 20);
            this.textId.TabIndex = 6;
            // 
            // textNom
            // 
            this.textNom.Location = new System.Drawing.Point(108, 55);
            this.textNom.Name = "textNom";
            this.textNom.Size = new System.Drawing.Size(100, 20);
            this.textNom.TabIndex = 7;
            // 
            // textPrenom
            // 
            this.textPrenom.Location = new System.Drawing.Point(108, 90);
            this.textPrenom.Name = "textPrenom";
            this.textPrenom.Size = new System.Drawing.Size(100, 20);
            this.textPrenom.TabIndex = 8;
            // 
            // texttel
            // 
            this.texttel.Location = new System.Drawing.Point(108, 125);
            this.texttel.Name = "texttel";
            this.texttel.Size = new System.Drawing.Size(100, 20);
            this.texttel.TabIndex = 9;
            // 
            // textemail
            // 
            this.textemail.Location = new System.Drawing.Point(108, 160);
            this.textemail.Name = "textemail";
            this.textemail.Size = new System.Drawing.Size(100, 20);
            this.textemail.TabIndex = 10;
            // 
            // textDatN
            // 
            this.textDatN.Location = new System.Drawing.Point(108, 196);
            this.textDatN.Name = "textDatN";
            this.textDatN.Size = new System.Drawing.Size(100, 20);
            this.textDatN.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nom:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Prenom:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tel:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 203);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Datenais";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(15, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(618, 150);
            this.dataGridView1.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Nom";
            this.Column2.HeaderText = "Nom";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Prenom";
            this.Column3.HeaderText = "Prenom";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Tel";
            this.Column4.HeaderText = "Tel";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "email";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Datnais";
            this.Column6.HeaderText = "datnais";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textDatN);
            this.Controls.Add(this.textemail);
            this.Controls.Add(this.texttel);
            this.Controls.Add(this.textPrenom);
            this.Controls.Add(this.textNom);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.button_Sup);
            this.Controls.Add(this.button_Mod);
            this.Controls.Add(this.button_Rech);
            this.Controls.Add(this.button_NV);
            this.Controls.Add(this.button_Aff);
            this.Controls.Add(this.button_Ajt);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Ajt;
        private System.Windows.Forms.Button button_Aff;
        private System.Windows.Forms.Button button_NV;
        private System.Windows.Forms.Button button_Rech;
        private System.Windows.Forms.Button button_Mod;
        private System.Windows.Forms.Button button_Sup;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.TextBox textNom;
        private System.Windows.Forms.TextBox textPrenom;
        private System.Windows.Forms.TextBox texttel;
        private System.Windows.Forms.TextBox textemail;
        private System.Windows.Forms.TextBox textDatN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}

