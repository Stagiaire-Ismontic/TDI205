namespace tp1gestionbudget
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnmodifer = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtcin = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtprenom = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prenom,
            this.ID,
            this.Age,
            this.CIN,
            this.Email});
            this.dataGridView1.Location = new System.Drawing.Point(298, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(777, 234);
            this.dataGridView1.TabIndex = 35;
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.MinimumWidth = 8;
            this.Nom.Name = "Nom";
            this.Nom.Width = 150;
            // 
            // Prenom
            // 
            this.Prenom.HeaderText = "Prenom";
            this.Prenom.MinimumWidth = 8;
            this.Prenom.Name = "Prenom";
            this.Prenom.Width = 150;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // CIN
            // 
            this.CIN.HeaderText = "CIN";
            this.CIN.MinimumWidth = 8;
            this.CIN.Name = "CIN";
            this.CIN.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 150;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(70, 178);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 26);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(298, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(780, 192);
            this.panel1.TabIndex = 49;
            // 
            // btnmodifer
            // 
            this.btnmodifer.Location = new System.Drawing.Point(141, 342);
            this.btnmodifer.Name = "btnmodifer";
            this.btnmodifer.Size = new System.Drawing.Size(97, 34);
            this.btnmodifer.TabIndex = 48;
            this.btnmodifer.Text = "Modifier";
            this.btnmodifer.UseVisualStyleBackColor = true;
            this.btnmodifer.Click += new System.EventHandler(this.btnmodifer_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(30, 341);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(105, 34);
            this.btnajouter.TabIndex = 47;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 46;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 45;
            this.label5.Text = "CIN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 44;
            this.label4.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 43;
            this.label3.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prenom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 41;
            this.label1.Text = "Nom";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(97, 270);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(151, 26);
            this.txtemail.TabIndex = 40;
            // 
            // txtcin
            // 
            this.txtcin.Location = new System.Drawing.Point(96, 220);
            this.txtcin.Name = "txtcin";
            this.txtcin.Size = new System.Drawing.Size(151, 26);
            this.txtcin.TabIndex = 39;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(97, 124);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(151, 26);
            this.txtId.TabIndex = 38;
            // 
            // txtprenom
            // 
            this.txtprenom.Location = new System.Drawing.Point(97, 80);
            this.txtprenom.Name = "txtprenom";
            this.txtprenom.Size = new System.Drawing.Size(151, 26);
            this.txtprenom.TabIndex = 37;
            // 
            // txtnom
            // 
            this.txtnom.Location = new System.Drawing.Point(97, 33);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(151, 26);
            this.txtnom.TabIndex = 36;
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(141, 392);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(97, 33);
            this.btnafficher.TabIndex = 52;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(30, 391);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(105, 34);
            this.btnsupprimer.TabIndex = 51;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.btnafficher);
            this.Controls.Add(this.btnsupprimer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnmodifer);
            this.Controls.Add(this.btnajouter);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtcin);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtprenom);
            this.Controls.Add(this.txtnom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnmodifer;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtcin;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtprenom;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnsupprimer;
    }
}

