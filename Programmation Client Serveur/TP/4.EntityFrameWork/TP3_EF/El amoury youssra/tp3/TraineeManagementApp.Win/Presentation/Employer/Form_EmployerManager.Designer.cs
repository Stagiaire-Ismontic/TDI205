namespace CrudWin.Entities
{
    partial class Form_EmployerManager
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
            this.EmployerDataGridView = new System.Windows.Forms.DataGridView();
            this.EmployerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btAjouter = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btMettreAjour = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployerDataGridView
            // 
            this.EmployerDataGridView.AutoGenerateColumns = false;
            this.EmployerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmployerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Nom,
            this.Column1});
            this.EmployerDataGridView.DataSource = this.EmployerBindingSource;
            this.EmployerDataGridView.Location = new System.Drawing.Point(12, 92);
            this.EmployerDataGridView.Name = "EmployerDataGridView";
            this.EmployerDataGridView.Size = new System.Drawing.Size(318, 220);
            this.EmployerDataGridView.TabIndex = 1;
            // 
            // EmployerBindingSource
            // 
            this.EmployerBindingSource.DataSource = typeof(CrudWin.Entities.Employer);
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
            // Nom
            // 
            this.Nom.DataPropertyName = "Nom";
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Prenom";
            this.Column1.HeaderText = "Prenom";
            this.Column1.Name = "Column1";
            // 
            // Form_EmployerManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 353);
            this.Controls.Add(this.btMettreAjour);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.EmployerDataGridView);
            this.Name = "Form_EmployerManager";
            this.Text = "FormGestionEmployer";
            this.Load += new System.EventHandler(this.FormGestionEmployer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EmployerDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource EmployerBindingSource;
        private System.Windows.Forms.DataGridView EmployerDataGridView;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btMettreAjour;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}