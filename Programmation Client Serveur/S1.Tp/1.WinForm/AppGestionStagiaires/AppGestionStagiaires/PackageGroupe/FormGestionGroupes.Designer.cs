namespace AppGestionStagiaires.PackageGroupe
{
    partial class FormGestionGroupes
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
            this.groupeDataGridView = new System.Windows.Forms.DataGridView();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btMettreAjour = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupeDataGridView
            // 
            this.groupeDataGridView.AutoGenerateColumns = false;
            this.groupeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.groupeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.groupeDataGridView.DataSource = this.groupeBindingSource;
            this.groupeDataGridView.Location = new System.Drawing.Point(12, 92);
            this.groupeDataGridView.Name = "groupeDataGridView";
            this.groupeDataGridView.Size = new System.Drawing.Size(346, 220);
            this.groupeDataGridView.TabIndex = 1;
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(364, 35);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(75, 23);
            this.btAjouter.TabIndex = 2;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(364, 92);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btSupprimer.TabIndex = 3;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btMettreAjour
            // 
            this.btMettreAjour.Location = new System.Drawing.Point(364, 121);
            this.btMettreAjour.Name = "btMettreAjour";
            this.btMettreAjour.Size = new System.Drawing.Size(75, 23);
            this.btMettreAjour.TabIndex = 4;
            this.btMettreAjour.Text = "Mettre à jour";
            this.btMettreAjour.UseVisualStyleBackColor = true;
            this.btMettreAjour.Click += new System.EventHandler(this.btMettreAjour_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nom";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // groupeBindingSource
            // 
            this.groupeBindingSource.DataSource = typeof(AppGestionStagiaires.PackageGroupe.Groupe);
            // 
            // FormGestionGroupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 353);
            this.Controls.Add(this.btMettreAjour);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.groupeDataGridView);
            this.Name = "FormGestionGroupes";
            this.Text = "FormGestionGroupes";
            this.Load += new System.EventHandler(this.FormGestionGroupes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource groupeBindingSource;
        private System.Windows.Forms.DataGridView groupeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btMettreAjour;

    }
}