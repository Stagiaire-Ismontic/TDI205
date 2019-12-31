namespace WindowsF
{
    partial class Commande
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherSansJointureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherAvecJointureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboProduit = new System.Windows.Forms.ComboBox();
            this.produitRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtPrix = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.TxtDescription = new System.Windows.Forms.TextBox();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnNouveau = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCommandeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prixDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.produitRowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnFin = new System.Windows.Forms.Button();
            this.BtnPresident = new System.Windows.Forms.Button();
            this.BtnSuivant = new System.Windows.Forms.Button();
            this.BtnDebut = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionCommandeToolStripMenuItem,
            this.afficherSansJointureToolStripMenuItem,
            this.afficherAvecJointureToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(659, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(140, 21);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            // 
            // afficherSansJointureToolStripMenuItem
            // 
            this.afficherSansJointureToolStripMenuItem.Name = "afficherSansJointureToolStripMenuItem";
            this.afficherSansJointureToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.afficherSansJointureToolStripMenuItem.Text = "Afficher sans jointure";
            this.afficherSansJointureToolStripMenuItem.Click += new System.EventHandler(this.afficherSansJointureToolStripMenuItem_Click);
            // 
            // afficherAvecJointureToolStripMenuItem
            // 
            this.afficherAvecJointureToolStripMenuItem.Name = "afficherAvecJointureToolStripMenuItem";
            this.afficherAvecJointureToolStripMenuItem.Size = new System.Drawing.Size(152, 21);
            this.afficherAvecJointureToolStripMenuItem.Text = "Afficher avec jointure";
            this.afficherAvecJointureToolStripMenuItem.Click += new System.EventHandler(this.afficherAvecJointureToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Produit";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboProduit);
            this.groupBox1.Controls.Add(this.TxtPrix);
            this.groupBox1.Controls.Add(this.TxtDescription);
            this.groupBox1.Controls.Add(this.TxtId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gray;
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 171);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Commande";
            // 
            // ComboProduit
            // 
            this.ComboProduit.DataSource = this.produitRowBindingSource;
            this.ComboProduit.DisplayMember = "Nom";
            this.ComboProduit.FormattingEnabled = true;
            this.ComboProduit.Location = new System.Drawing.Point(121, 130);
            this.ComboProduit.Name = "ComboProduit";
            this.ComboProduit.Size = new System.Drawing.Size(298, 24);
            this.ComboProduit.TabIndex = 8;
            this.ComboProduit.ValueMember = "IdProduit";
            this.ComboProduit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboProduit_KeyPress);
            // 
            // produitRowBindingSource
            // 
            this.produitRowBindingSource.DataSource = typeof(WindowsF.Data.ProduitRow);
            // 
            // TxtPrix
            // 
            this.TxtPrix.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Prix", true));
            this.TxtPrix.Location = new System.Drawing.Point(121, 103);
            this.TxtPrix.Name = "TxtPrix";
            this.TxtPrix.Size = new System.Drawing.Size(298, 22);
            this.TxtPrix.TabIndex = 7;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = typeof(WindowsF.Data.CommandeRow);
            // 
            // TxtDescription
            // 
            this.TxtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "Descriptions", true));
            this.TxtDescription.Location = new System.Drawing.Point(121, 48);
            this.TxtDescription.Multiline = true;
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Size = new System.Drawing.Size(298, 49);
            this.TxtDescription.TabIndex = 6;
            // 
            // TxtId
            // 
            this.TxtId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IdCommande", true));
            this.TxtId.Location = new System.Drawing.Point(121, 22);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(298, 22);
            this.TxtId.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnNouveau);
            this.groupBox2.Controls.Add(this.BtnSupprimer);
            this.groupBox2.Controls.Add(this.BtnModifier);
            this.groupBox2.Controls.Add(this.BtnAjouter);
            this.groupBox2.Location = new System.Drawing.Point(496, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 171);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // BtnNouveau
            // 
            this.BtnNouveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNouveau.ForeColor = System.Drawing.Color.Gray;
            this.BtnNouveau.Location = new System.Drawing.Point(6, 128);
            this.BtnNouveau.Name = "BtnNouveau";
            this.BtnNouveau.Size = new System.Drawing.Size(103, 31);
            this.BtnNouveau.TabIndex = 3;
            this.BtnNouveau.Text = "Vide";
            this.BtnNouveau.UseVisualStyleBackColor = true;
            this.BtnNouveau.Click += new System.EventHandler(this.BtnNouveau_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.Gray;
            this.BtnSupprimer.Location = new System.Drawing.Point(6, 91);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(103, 31);
            this.BtnSupprimer.TabIndex = 2;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = true;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.Gray;
            this.BtnModifier.Location = new System.Drawing.Point(6, 55);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(103, 31);
            this.BtnModifier.TabIndex = 1;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = true;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.Gray;
            this.BtnAjouter.Location = new System.Drawing.Point(6, 18);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(103, 31);
            this.BtnAjouter.TabIndex = 0;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = true;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
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
            this.prixDataGridViewTextBoxColumn,
            this.produitRowDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 215);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(459, 171);
            this.dataGridView1.TabIndex = 7;
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
            // 
            // prixDataGridViewTextBoxColumn
            // 
            this.prixDataGridViewTextBoxColumn.DataPropertyName = "Prix";
            this.prixDataGridViewTextBoxColumn.HeaderText = "Prix";
            this.prixDataGridViewTextBoxColumn.Name = "prixDataGridViewTextBoxColumn";
            this.prixDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // produitRowDataGridViewTextBoxColumn
            // 
            this.produitRowDataGridViewTextBoxColumn.DataPropertyName = "ProduitRow";
            this.produitRowDataGridViewTextBoxColumn.HeaderText = "Produit";
            this.produitRowDataGridViewTextBoxColumn.Name = "produitRowDataGridViewTextBoxColumn";
            this.produitRowDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnFin);
            this.groupBox3.Controls.Add(this.BtnPresident);
            this.groupBox3.Controls.Add(this.BtnSuivant);
            this.groupBox3.Controls.Add(this.BtnDebut);
            this.groupBox3.Location = new System.Drawing.Point(496, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 171);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // BtnFin
            // 
            this.BtnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFin.ForeColor = System.Drawing.Color.Gray;
            this.BtnFin.Location = new System.Drawing.Point(6, 128);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(103, 31);
            this.BtnFin.TabIndex = 3;
            this.BtnFin.Text = "Fin";
            this.BtnFin.UseVisualStyleBackColor = true;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // BtnPresident
            // 
            this.BtnPresident.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPresident.ForeColor = System.Drawing.Color.Gray;
            this.BtnPresident.Location = new System.Drawing.Point(6, 91);
            this.BtnPresident.Name = "BtnPresident";
            this.BtnPresident.Size = new System.Drawing.Size(103, 31);
            this.BtnPresident.TabIndex = 2;
            this.BtnPresident.Text = "President";
            this.BtnPresident.UseVisualStyleBackColor = true;
            this.BtnPresident.Click += new System.EventHandler(this.BtnPresident_Click);
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuivant.ForeColor = System.Drawing.Color.Gray;
            this.BtnSuivant.Location = new System.Drawing.Point(6, 55);
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(103, 31);
            this.BtnSuivant.TabIndex = 1;
            this.BtnSuivant.Text = "Suivant";
            this.BtnSuivant.UseVisualStyleBackColor = true;
            this.BtnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // BtnDebut
            // 
            this.BtnDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDebut.ForeColor = System.Drawing.Color.Gray;
            this.BtnDebut.Location = new System.Drawing.Point(6, 18);
            this.BtnDebut.Name = "BtnDebut";
            this.BtnDebut.Size = new System.Drawing.Size(103, 31);
            this.BtnDebut.TabIndex = 0;
            this.BtnDebut.Text = "Debut";
            this.BtnDebut.UseVisualStyleBackColor = true;
            this.BtnDebut.Click += new System.EventHandler(this.BtnDebut_Click);
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 412);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Commande";
            this.Text = "Commande";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.produitRowBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherSansJointureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherAvecJointureToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboProduit;
        private System.Windows.Forms.TextBox TxtPrix;
        private System.Windows.Forms.TextBox TxtDescription;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnNouveau;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommandeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prixDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn produitRowDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.Button BtnPresident;
        private System.Windows.Forms.Button BtnSuivant;
        private System.Windows.Forms.Button BtnDebut;
        private System.Windows.Forms.BindingSource produitRowBindingSource;
    }
}

