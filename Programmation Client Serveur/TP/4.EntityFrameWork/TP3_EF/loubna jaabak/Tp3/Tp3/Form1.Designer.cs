namespace Tp3
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
            this.btn_QUITTER = new System.Windows.Forms.Button();
            this.BTN_VIDER = new System.Windows.Forms.Button();
            this.btn_RECHERCHER = new System.Windows.Forms.Button();
            this.btn_MODIFIER = new System.Windows.Forms.Button();
            this.btn_Supprimer = new System.Windows.Forms.Button();
            this.btn_AJOUTER = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_CATEGORIE = new System.Windows.Forms.TextBox();
            this.txt_NOMedit = new System.Windows.Forms.TextBox();
            this.txt_idEdit = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_Livre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_QUITTER
            // 
            this.btn_QUITTER.Location = new System.Drawing.Point(125, 286);
            this.btn_QUITTER.Name = "btn_QUITTER";
            this.btn_QUITTER.Size = new System.Drawing.Size(91, 23);
            this.btn_QUITTER.TabIndex = 24;
            this.btn_QUITTER.Text = "QUITTER";
            this.btn_QUITTER.UseVisualStyleBackColor = true;
            this.btn_QUITTER.Click += new System.EventHandler(this.btn_QUITTER_Click);
            // 
            // BTN_VIDER
            // 
            this.BTN_VIDER.Location = new System.Drawing.Point(13, 285);
            this.BTN_VIDER.Name = "BTN_VIDER";
            this.BTN_VIDER.Size = new System.Drawing.Size(91, 23);
            this.BTN_VIDER.TabIndex = 23;
            this.BTN_VIDER.Text = "VIDER";
            this.BTN_VIDER.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BTN_VIDER.UseVisualStyleBackColor = true;
            this.BTN_VIDER.Click += new System.EventHandler(this.BTN_VIDER_Click);
            // 
            // btn_RECHERCHER
            // 
            this.btn_RECHERCHER.Location = new System.Drawing.Point(125, 256);
            this.btn_RECHERCHER.Name = "btn_RECHERCHER";
            this.btn_RECHERCHER.Size = new System.Drawing.Size(91, 23);
            this.btn_RECHERCHER.TabIndex = 22;
            this.btn_RECHERCHER.Text = "RECHERCHER";
            this.btn_RECHERCHER.UseVisualStyleBackColor = true;
            this.btn_RECHERCHER.Click += new System.EventHandler(this.btn_RECHERCHER_Click);
            // 
            // btn_MODIFIER
            // 
            this.btn_MODIFIER.Location = new System.Drawing.Point(13, 256);
            this.btn_MODIFIER.Name = "btn_MODIFIER";
            this.btn_MODIFIER.Size = new System.Drawing.Size(91, 23);
            this.btn_MODIFIER.TabIndex = 21;
            this.btn_MODIFIER.Text = "MODIFIER";
            this.btn_MODIFIER.UseVisualStyleBackColor = true;
            this.btn_MODIFIER.Click += new System.EventHandler(this.btn_MODIFIER_Click);
            // 
            // btn_Supprimer
            // 
            this.btn_Supprimer.Location = new System.Drawing.Point(13, 226);
            this.btn_Supprimer.Name = "btn_Supprimer";
            this.btn_Supprimer.Size = new System.Drawing.Size(91, 23);
            this.btn_Supprimer.TabIndex = 20;
            this.btn_Supprimer.Text = "SUPPRIMER";
            this.btn_Supprimer.UseVisualStyleBackColor = true;
            this.btn_Supprimer.Click += new System.EventHandler(this.btn_Supprimer_Click);
            // 
            // btn_AJOUTER
            // 
            this.btn_AJOUTER.Location = new System.Drawing.Point(125, 226);
            this.btn_AJOUTER.Name = "btn_AJOUTER";
            this.btn_AJOUTER.Size = new System.Drawing.Size(91, 23);
            this.btn_AJOUTER.TabIndex = 19;
            this.btn_AJOUTER.Text = "AJOUTER";
            this.btn_AJOUTER.UseVisualStyleBackColor = true;
            this.btn_AJOUTER.Click += new System.EventHandler(this.btn_AJOUTER_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "CATEGORIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // txt_CATEGORIE
            // 
            this.txt_CATEGORIE.Location = new System.Drawing.Point(142, 115);
            this.txt_CATEGORIE.Name = "txt_CATEGORIE";
            this.txt_CATEGORIE.Size = new System.Drawing.Size(100, 20);
            this.txt_CATEGORIE.TabIndex = 15;
            // 
            // txt_NOMedit
            // 
            this.txt_NOMedit.Location = new System.Drawing.Point(142, 71);
            this.txt_NOMedit.Name = "txt_NOMedit";
            this.txt_NOMedit.Size = new System.Drawing.Size(100, 20);
            this.txt_NOMedit.TabIndex = 14;
            // 
            // txt_idEdit
            // 
            this.txt_idEdit.Location = new System.Drawing.Point(142, 33);
            this.txt_idEdit.Name = "txt_idEdit";
            this.txt_idEdit.Size = new System.Drawing.Size(100, 20);
            this.txt_idEdit.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(248, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(488, 372);
            this.dataGridView1.TabIndex = 25;
            // 
            // txt_Livre
            // 
            this.txt_Livre.Location = new System.Drawing.Point(142, 152);
            this.txt_Livre.Name = "txt_Livre";
            this.txt_Livre.Size = new System.Drawing.Size(100, 20);
            this.txt_Livre.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "id_livre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Livre);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_QUITTER);
            this.Controls.Add(this.BTN_VIDER);
            this.Controls.Add(this.btn_RECHERCHER);
            this.Controls.Add(this.btn_MODIFIER);
            this.Controls.Add(this.btn_Supprimer);
            this.Controls.Add(this.btn_AJOUTER);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_CATEGORIE);
            this.Controls.Add(this.txt_NOMedit);
            this.Controls.Add(this.txt_idEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_QUITTER;
        private System.Windows.Forms.Button BTN_VIDER;
        private System.Windows.Forms.Button btn_RECHERCHER;
        private System.Windows.Forms.Button btn_MODIFIER;
        private System.Windows.Forms.Button btn_Supprimer;
        private System.Windows.Forms.Button btn_AJOUTER;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_CATEGORIE;
        private System.Windows.Forms.TextBox txt_NOMedit;
        private System.Windows.Forms.TextBox txt_idEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt_Livre;
        private System.Windows.Forms.Label label4;
    }
}

