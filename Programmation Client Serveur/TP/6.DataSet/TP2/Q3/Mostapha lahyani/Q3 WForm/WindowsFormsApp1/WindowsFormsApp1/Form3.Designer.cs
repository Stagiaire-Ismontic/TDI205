namespace WindowsFormsApp1
{
    partial class Form3
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtRechercher = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.clientCommandRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idCommandDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commandNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCommandRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCommandDataGridViewTextBoxColumn,
            this.idClientDataGridViewTextBoxColumn,
            this.commandNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.clientCommandRowBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 96);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(344, 120);
            this.dataGridView2.TabIndex = 4;
            // 
            // txtRechercher
            // 
            this.txtRechercher.Location = new System.Drawing.Point(149, 57);
            this.txtRechercher.Name = "txtRechercher";
            this.txtRechercher.Size = new System.Drawing.Size(100, 20);
            this.txtRechercher.TabIndex = 6;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(41, 54);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 5;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // clientCommandRowBindingSource
            // 
            this.clientCommandRowBindingSource.DataSource = typeof(WindowsFormsApp1.DS.ClientCommandRow);
            // 
            // idCommandDataGridViewTextBoxColumn
            // 
            this.idCommandDataGridViewTextBoxColumn.DataPropertyName = "idCommand";
            this.idCommandDataGridViewTextBoxColumn.HeaderText = "idCommand";
            this.idCommandDataGridViewTextBoxColumn.Name = "idCommandDataGridViewTextBoxColumn";
            this.idCommandDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClientDataGridViewTextBoxColumn
            // 
            this.idClientDataGridViewTextBoxColumn.DataPropertyName = "idClient";
            this.idClientDataGridViewTextBoxColumn.HeaderText = "idClient";
            this.idClientDataGridViewTextBoxColumn.Name = "idClientDataGridViewTextBoxColumn";
            this.idClientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commandNameDataGridViewTextBoxColumn
            // 
            this.commandNameDataGridViewTextBoxColumn.DataPropertyName = "CommandName";
            this.commandNameDataGridViewTextBoxColumn.HeaderText = "CommandName";
            this.commandNameDataGridViewTextBoxColumn.Name = "commandNameDataGridViewTextBoxColumn";
            this.commandNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtRechercher);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientCommandRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCommandDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commandNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource clientCommandRowBindingSource;
        private System.Windows.Forms.TextBox txtRechercher;
        private System.Windows.Forms.Button btnRechercher;
    }
}