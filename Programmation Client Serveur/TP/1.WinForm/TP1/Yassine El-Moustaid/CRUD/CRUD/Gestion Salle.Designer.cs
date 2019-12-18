namespace CRUD
{
    partial class Gestion_Salle
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_modifier = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.txt_IDSALLE = new System.Windows.Forms.TextBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_SALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPTION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID SALLE ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "DESCRIPTION";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(483, 54);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(104, 31);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Ajouter";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_modifier
            // 
            this.btn_modifier.Location = new System.Drawing.Point(483, 101);
            this.btn_modifier.Name = "btn_modifier";
            this.btn_modifier.Size = new System.Drawing.Size(104, 31);
            this.btn_modifier.TabIndex = 3;
            this.btn_modifier.Text = "Modifier";
            this.btn_modifier.UseVisualStyleBackColor = true;
            this.btn_modifier.Click += new System.EventHandler(this.btn_modifier_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Location = new System.Drawing.Point(483, 154);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(104, 31);
            this.btn_supprimer.TabIndex = 4;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = true;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // txt_IDSALLE
            // 
            this.txt_IDSALLE.Location = new System.Drawing.Point(207, 54);
            this.txt_IDSALLE.Name = "txt_IDSALLE";
            this.txt_IDSALLE.Size = new System.Drawing.Size(154, 22);
            this.txt_IDSALLE.TabIndex = 5;
            // 
            // txt_description
            // 
            this.txt_description.Location = new System.Drawing.Point(207, 101);
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(154, 22);
            this.txt_description.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_SALLE,
            this.DESCRIPTION});
            this.dataGridView1.Location = new System.Drawing.Point(48, 251);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(539, 176);
            this.dataGridView1.TabIndex = 7;
            // 
            // ID_SALLE
            // 
            this.ID_SALLE.HeaderText = "ID SALLE";
            this.ID_SALLE.Name = "ID_SALLE";
            // 
            // DESCRIPTION
            // 
            this.DESCRIPTION.HeaderText = "DESCRIPTION";
            this.DESCRIPTION.Name = "DESCRIPTION";
            // 
            // Gestion_Salle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 463);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.txt_IDSALLE);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_modifier);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Gestion_Salle";
            this.Text = "Gestion Salle";
            this.Load += new System.EventHandler(this.Gestion_Salle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_modifier;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.TextBox txt_IDSALLE;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_SALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPTION;
    }
}