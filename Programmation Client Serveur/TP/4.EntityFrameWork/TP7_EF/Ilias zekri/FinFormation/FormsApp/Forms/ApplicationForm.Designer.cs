namespace FormsApp.Forms
{
    partial class ApplicationForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewQuartier = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomQuartierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuartierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource333 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnFermer = new System.Windows.Forms.Button();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPopulation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboVille = new System.Windows.Forms.ComboBox();
            this.villeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TxtTotalQuartier = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionDseQuqrtierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesVillesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesRegionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rechercheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnFin = new System.Windows.Forms.Button();
            this.BtnDebut = new System.Windows.Forms.Button();
            this.BtnSuivant = new System.Windows.Forms.Button();
            this.btnPrecedent = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource333)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewQuartier);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(10, 231);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 185);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List des Ville";
            // 
            // dataGridViewQuartier
            // 
            this.dataGridViewQuartier.AllowUserToAddRows = false;
            this.dataGridViewQuartier.AllowUserToDeleteRows = false;
            this.dataGridViewQuartier.AutoGenerateColumns = false;
            this.dataGridViewQuartier.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataGridViewQuartier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewQuartier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomQuartierDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.totalQuartierDataGridViewTextBoxColumn});
            this.dataGridViewQuartier.DataSource = this.bindingSource333;
            this.dataGridViewQuartier.Location = new System.Drawing.Point(6, 19);
            this.dataGridViewQuartier.Name = "dataGridViewQuartier";
            this.dataGridViewQuartier.ReadOnly = true;
            this.dataGridViewQuartier.Size = new System.Drawing.Size(557, 160);
            this.dataGridViewQuartier.TabIndex = 5;
            this.dataGridViewQuartier.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewQuartier_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomQuartierDataGridViewTextBoxColumn
            // 
            this.nomQuartierDataGridViewTextBoxColumn.DataPropertyName = "NomQuartier";
            this.nomQuartierDataGridViewTextBoxColumn.HeaderText = "NomQuartier";
            this.nomQuartierDataGridViewTextBoxColumn.Name = "nomQuartierDataGridViewTextBoxColumn";
            this.nomQuartierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalQuartierDataGridViewTextBoxColumn
            // 
            this.totalQuartierDataGridViewTextBoxColumn.DataPropertyName = "TotalQuartier";
            this.totalQuartierDataGridViewTextBoxColumn.HeaderText = "N° Quartier";
            this.totalQuartierDataGridViewTextBoxColumn.Name = "totalQuartierDataGridViewTextBoxColumn";
            this.totalQuartierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource333
            // 
            this.bindingSource333.DataSource = typeof(FormsApp.Classes.Quartier);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Silver;
            this.groupBox2.Controls.Add(this.BtnFermer);
            this.groupBox2.Controls.Add(this.BtnAjouter);
            this.groupBox2.Controls.Add(this.BtnSupprimer);
            this.groupBox2.Controls.Add(this.BtnModifier);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(462, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 194);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // BtnFermer
            // 
            this.BtnFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFermer.ForeColor = System.Drawing.Color.Black;
            this.BtnFermer.Location = new System.Drawing.Point(6, 142);
            this.BtnFermer.Name = "BtnFermer";
            this.BtnFermer.Size = new System.Drawing.Size(100, 35);
            this.BtnFermer.TabIndex = 4;
            this.BtnFermer.Text = "Fermer";
            this.BtnFermer.UseVisualStyleBackColor = false;
            this.BtnFermer.Click += new System.EventHandler(this.BtnFermer_Click);
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.Black;
            this.BtnAjouter.Location = new System.Drawing.Point(6, 19);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(100, 35);
            this.BtnAjouter.TabIndex = 1;
            this.BtnAjouter.Text = "Ajouter";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.Black;
            this.BtnSupprimer.Location = new System.Drawing.Point(5, 101);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(100, 35);
            this.BtnSupprimer.TabIndex = 3;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.Black;
            this.BtnModifier.Location = new System.Drawing.Point(6, 60);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(100, 35);
            this.BtnModifier.TabIndex = 2;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.UseVisualStyleBackColor = false;
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtPopulation);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboVille);
            this.groupBox1.Controls.Add(this.TxtTotalQuartier);
            this.groupBox1.Controls.Add(this.TxtNom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 194);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quartier";
            // 
            // TxtPopulation
            // 
            this.TxtPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPopulation.Location = new System.Drawing.Point(126, 91);
            this.TxtPopulation.Name = "TxtPopulation";
            this.TxtPopulation.Size = new System.Drawing.Size(292, 24);
            this.TxtPopulation.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "N° Quartier";
            // 
            // TxtCode
            // 
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.Location = new System.Drawing.Point(126, 33);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Size = new System.Drawing.Size(292, 24);
            this.TxtCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Code";
            // 
            // ComboVille
            // 
            this.ComboVille.DataSource = this.villeBindingSource;
            this.ComboVille.DisplayMember = "NomVille";
            this.ComboVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboVille.FormattingEnabled = true;
            this.ComboVille.Location = new System.Drawing.Point(126, 123);
            this.ComboVille.Name = "ComboVille";
            this.ComboVille.Size = new System.Drawing.Size(292, 26);
            this.ComboVille.TabIndex = 7;
            this.ComboVille.ValueMember = "Id";
            this.ComboVille.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboVille_MouseClick);
            // 
            // villeBindingSource
            // 
            this.villeBindingSource.DataSource = typeof(FormsApp.Classes.Ville);
            // 
            // TxtTotalQuartier
            // 
            this.TxtTotalQuartier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalQuartier.Location = new System.Drawing.Point(126, 157);
            this.TxtTotalQuartier.Name = "TxtTotalQuartier";
            this.TxtTotalQuartier.Size = new System.Drawing.Size(292, 24);
            this.TxtTotalQuartier.TabIndex = 5;
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(126, 62);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(292, 24);
            this.TxtNom.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ville";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.Font = new System.Drawing.Font("Book Antiqua", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDseQuqrtierToolStripMenuItem,
            this.gestionDesVillesToolStripMenuItem,
            this.gestionDesRegionsToolStripMenuItem,
            this.rechercheToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(593, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionDseQuqrtierToolStripMenuItem
            // 
            this.gestionDseQuqrtierToolStripMenuItem.Name = "gestionDseQuqrtierToolStripMenuItem";
            this.gestionDseQuqrtierToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.gestionDseQuqrtierToolStripMenuItem.Text = "Gestion des Quartiers";
            // 
            // gestionDesVillesToolStripMenuItem
            // 
            this.gestionDesVillesToolStripMenuItem.Name = "gestionDesVillesToolStripMenuItem";
            this.gestionDesVillesToolStripMenuItem.Size = new System.Drawing.Size(147, 24);
            this.gestionDesVillesToolStripMenuItem.Text = "Gestion des Villes";
            this.gestionDesVillesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesVillesToolStripMenuItem_Click);
            // 
            // gestionDesRegionsToolStripMenuItem
            // 
            this.gestionDesRegionsToolStripMenuItem.Name = "gestionDesRegionsToolStripMenuItem";
            this.gestionDesRegionsToolStripMenuItem.Size = new System.Drawing.Size(164, 24);
            this.gestionDesRegionsToolStripMenuItem.Text = "Gestion des Regions";
            this.gestionDesRegionsToolStripMenuItem.Click += new System.EventHandler(this.gestionDesRegionsToolStripMenuItem_Click);
            // 
            // rechercheToolStripMenuItem
            // 
            this.rechercheToolStripMenuItem.Name = "rechercheToolStripMenuItem";
            this.rechercheToolStripMenuItem.Size = new System.Drawing.Size(92, 24);
            this.rechercheToolStripMenuItem.Text = "Recherche";
            this.rechercheToolStripMenuItem.Click += new System.EventHandler(this.rechercheToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnFin);
            this.groupBox4.Controls.Add(this.BtnDebut);
            this.groupBox4.Controls.Add(this.BtnSuivant);
            this.groupBox4.Controls.Add(this.btnPrecedent);
            this.groupBox4.Location = new System.Drawing.Point(10, 421);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(569, 66);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            // 
            // BtnFin
            // 
            this.BtnFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFin.ForeColor = System.Drawing.Color.Black;
            this.BtnFin.Location = new System.Drawing.Point(452, 19);
            this.BtnFin.Name = "BtnFin";
            this.BtnFin.Size = new System.Drawing.Size(100, 35);
            this.BtnFin.TabIndex = 4;
            this.BtnFin.Text = "Fin";
            this.BtnFin.UseVisualStyleBackColor = false;
            this.BtnFin.Click += new System.EventHandler(this.BtnFin_Click);
            // 
            // BtnDebut
            // 
            this.BtnDebut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnDebut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDebut.ForeColor = System.Drawing.Color.Black;
            this.BtnDebut.Location = new System.Drawing.Point(6, 19);
            this.BtnDebut.Name = "BtnDebut";
            this.BtnDebut.Size = new System.Drawing.Size(100, 35);
            this.BtnDebut.TabIndex = 1;
            this.BtnDebut.Text = "Debut";
            this.BtnDebut.UseVisualStyleBackColor = false;
            this.BtnDebut.Click += new System.EventHandler(this.BtnDebut_Click);
            // 
            // BtnSuivant
            // 
            this.BtnSuivant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnSuivant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSuivant.ForeColor = System.Drawing.Color.Black;
            this.BtnSuivant.Location = new System.Drawing.Point(304, 19);
            this.BtnSuivant.Name = "BtnSuivant";
            this.BtnSuivant.Size = new System.Drawing.Size(100, 35);
            this.BtnSuivant.TabIndex = 3;
            this.BtnSuivant.Text = "Suivant";
            this.BtnSuivant.UseVisualStyleBackColor = false;
            this.BtnSuivant.Click += new System.EventHandler(this.BtnSuivant_Click);
            // 
            // btnPrecedent
            // 
            this.btnPrecedent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrecedent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecedent.ForeColor = System.Drawing.Color.Black;
            this.btnPrecedent.Location = new System.Drawing.Point(147, 19);
            this.btnPrecedent.Name = "btnPrecedent";
            this.btnPrecedent.Size = new System.Drawing.Size(100, 35);
            this.btnPrecedent.TabIndex = 2;
            this.btnPrecedent.Text = "Precedent";
            this.btnPrecedent.UseVisualStyleBackColor = false;
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(593, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ApplicationForm";
            this.Text = "ApplicationForm";
            this.Load += new System.EventHandler(this.ApplicationForm_Load_1);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewQuartier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource333)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.villeBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewQuartier;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboVille;
        private System.Windows.Forms.TextBox TxtTotalQuartier;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnFermer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionDseQuqrtierToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtPopulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeQuartierDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource333;
        private System.Windows.Forms.BindingSource villeBindingSource;
        private System.Windows.Forms.ToolStripMenuItem gestionDesVillesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesRegionsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnFin;
        private System.Windows.Forms.Button BtnDebut;
        private System.Windows.Forms.Button BtnSuivant;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomQuartierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuartierDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem rechercheToolStripMenuItem;
    }
}