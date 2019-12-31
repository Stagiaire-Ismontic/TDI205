namespace WindowsF
{
    partial class AvecJointure
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtRecherche = new System.Windows.Forms.TextBox();
            this.BtnRecherche = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Description";
            // 
            // TxtRecherche
            // 
            this.TxtRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecherche.ForeColor = System.Drawing.Color.Gray;
            this.TxtRecherche.Location = new System.Drawing.Point(125, 33);
            this.TxtRecherche.Multiline = true;
            this.TxtRecherche.Name = "TxtRecherche";
            this.TxtRecherche.Size = new System.Drawing.Size(216, 69);
            this.TxtRecherche.TabIndex = 6;
            // 
            // BtnRecherche
            // 
            this.BtnRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecherche.ForeColor = System.Drawing.Color.Gray;
            this.BtnRecherche.Location = new System.Drawing.Point(367, 33);
            this.BtnRecherche.Name = "BtnRecherche";
            this.BtnRecherche.Size = new System.Drawing.Size(112, 37);
            this.BtnRecherche.TabIndex = 5;
            this.BtnRecherche.Text = "Recherche";
            this.BtnRecherche.UseVisualStyleBackColor = true;
            this.BtnRecherche.Click += new System.EventHandler(this.BtnRecherche_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCommandeDataGridViewTextBoxColumn,
            this.descriptionsDataGridViewTextBoxColumn,
            this.produitRowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(24, 125);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(500, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsF.Data.Select_Descriptions_JointureRow);
            // 
            // idCommandeDataGridViewTextBoxColumn
            // 
            this.idCommandeDataGridViewTextBoxColumn.DataPropertyName = "IdCommande";
            this.idCommandeDataGridViewTextBoxColumn.HeaderText = "IdCommande";
            this.idCommandeDataGridViewTextBoxColumn.Name = "idCommandeDataGridViewTextBoxColumn";
            this.idCommandeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionsDataGridViewTextBoxColumn
            // 
            this.descriptionsDataGridViewTextBoxColumn.DataPropertyName = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.HeaderText = "Descriptions";
            this.descriptionsDataGridViewTextBoxColumn.Name = "descriptionsDataGridViewTextBoxColumn";
            this.descriptionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptionsDataGridViewTextBoxColumn.Width = 250;
            // 
            // produitRowDataGridViewTextBoxColumn
            // 
            this.produitRowDataGridViewTextBoxColumn.DataPropertyName = "ProduitRow";
            this.produitRowDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.produitRowDataGridViewTextBoxColumn.Name = "produitRowDataGridViewTextBoxColumn";
            this.produitRowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AvecJointure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 302);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtRecherche);
            this.Controls.Add(this.BtnRecherche);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AvecJointure";
            this.Text = "Afficher Avec Jointure";
            this.Load += new System.EventHandler(this.AvecJointure_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtRecherche;
        private System.Windows.Forms.Button BtnRecherche;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitRowDataGridViewTextBoxColumn;
    }
}