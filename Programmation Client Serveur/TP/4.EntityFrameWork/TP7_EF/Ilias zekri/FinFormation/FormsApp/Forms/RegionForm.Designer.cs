namespace FormsApp.Forms
{
    partial class RegionForm
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
            this.dataGridViewRegion = new System.Windows.Forms.DataGridView();
            this.bindingSource10 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnSupprimer = new System.Windows.Forms.Button();
            this.BtnModifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtPopulation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtTotalVille = new System.Windows.Forms.TextBox();
            this.TxtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalRegionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource10)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewRegion);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(16, 183);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(569, 185);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "List des Ville";
            // 
            // dataGridViewRegion
            // 
            this.dataGridViewRegion.AllowUserToAddRows = false;
            this.dataGridViewRegion.AllowUserToDeleteRows = false;
            this.dataGridViewRegion.AutoGenerateColumns = false;
            this.dataGridViewRegion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomRegionDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn,
            this.totalRegionDataGridViewTextBoxColumn});
            this.dataGridViewRegion.DataSource = this.bindingSource10;
            this.dataGridViewRegion.Location = new System.Drawing.Point(6, 21);
            this.dataGridViewRegion.Name = "dataGridViewRegion";
            this.dataGridViewRegion.ReadOnly = true;
            this.dataGridViewRegion.Size = new System.Drawing.Size(557, 158);
            this.dataGridViewRegion.TabIndex = 5;
            this.dataGridViewRegion.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegion_CellDoubleClick);
            // 
            // bindingSource10
            // 
            this.bindingSource10.DataSource = typeof(FormsApp.Classes.Region);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnAjouter);
            this.groupBox2.Controls.Add(this.BtnSupprimer);
            this.groupBox2.Controls.Add(this.BtnModifier);
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(117, 165);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.BackColor = System.Drawing.Color.Gray;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.ForeColor = System.Drawing.Color.White;
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
            this.BtnSupprimer.BackColor = System.Drawing.Color.Gray;
            this.BtnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSupprimer.ForeColor = System.Drawing.Color.White;
            this.BtnSupprimer.Location = new System.Drawing.Point(6, 123);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(100, 35);
            this.BtnSupprimer.TabIndex = 3;
            this.BtnSupprimer.Text = "Supprimer";
            this.BtnSupprimer.UseVisualStyleBackColor = false;
            this.BtnSupprimer.Click += new System.EventHandler(this.BtnSupprimer_Click);
            // 
            // BtnModifier
            // 
            this.BtnModifier.BackColor = System.Drawing.Color.Gray;
            this.BtnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.Location = new System.Drawing.Point(6, 69);
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
            this.groupBox1.Controls.Add(this.TxtCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TxtTotalVille);
            this.groupBox1.Controls.Add(this.TxtNom);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 165);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Region";
            // 
            // TxtPopulation
            // 
            this.TxtPopulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPopulation.Location = new System.Drawing.Point(126, 128);
            this.TxtPopulation.Name = "TxtPopulation";
            this.TxtPopulation.Size = new System.Drawing.Size(292, 24);
            this.TxtPopulation.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Population";
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
            // TxtTotalVille
            // 
            this.TxtTotalVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalVille.Location = new System.Drawing.Point(126, 97);
            this.TxtTotalVille.Name = "TxtTotalVille";
            this.TxtTotalVille.Size = new System.Drawing.Size(292, 24);
            this.TxtTotalVille.TabIndex = 5;
            // 
            // TxtNom
            // 
            this.TxtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNom.Location = new System.Drawing.Point(126, 67);
            this.TxtNom.Name = "TxtNom";
            this.TxtNom.Size = new System.Drawing.Size(292, 24);
            this.TxtNom.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N° Region";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom";
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Code Region";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomRegionDataGridViewTextBoxColumn
            // 
            this.nomRegionDataGridViewTextBoxColumn.DataPropertyName = "NomRegion";
            this.nomRegionDataGridViewTextBoxColumn.HeaderText = "NomRegion";
            this.nomRegionDataGridViewTextBoxColumn.Name = "nomRegionDataGridViewTextBoxColumn";
            this.nomRegionDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomRegionDataGridViewTextBoxColumn.Width = 140;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.ReadOnly = true;
            this.populationDataGridViewTextBoxColumn.Width = 140;
            // 
            // totalRegionDataGridViewTextBoxColumn
            // 
            this.totalRegionDataGridViewTextBoxColumn.DataPropertyName = "TotalRegion";
            this.totalRegionDataGridViewTextBoxColumn.HeaderText = "N° Region";
            this.totalRegionDataGridViewTextBoxColumn.Name = "totalRegionDataGridViewTextBoxColumn";
            this.totalRegionDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalRegionDataGridViewTextBoxColumn.Width = 130;
            // 
            // RegionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 372);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegionForm";
            this.Text = "RegionForm";
            this.Load += new System.EventHandler(this.RegionForm_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource10)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewRegion;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.Button BtnSupprimer;
        private System.Windows.Forms.Button BtnModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtTotalVille;
        private System.Windows.Forms.TextBox TxtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSource10;
        private System.Windows.Forms.TextBox TxtPopulation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomRegionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalRegionDataGridViewTextBoxColumn;
    }
}