namespace TP2
{
    partial class Gestion_Editeur
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
            this.text_Rech_edt = new System.Windows.Forms.TextBox();
            this.btn_rehce_edt = new System.Windows.Forms.Button();
            this.btnQtr = new System.Windows.Forms.Button();
            this.dataGV_edt = new System.Windows.Forms.DataGridView();
            this.editeurRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroinscriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idlivreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_edt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurRowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // text_Rech_edt
            // 
            this.text_Rech_edt.Location = new System.Drawing.Point(28, 22);
            this.text_Rech_edt.Name = "text_Rech_edt";
            this.text_Rech_edt.Size = new System.Drawing.Size(158, 20);
            this.text_Rech_edt.TabIndex = 0;
            // 
            // btn_rehce_edt
            // 
            this.btn_rehce_edt.Location = new System.Drawing.Point(241, 12);
            this.btn_rehce_edt.Name = "btn_rehce_edt";
            this.btn_rehce_edt.Size = new System.Drawing.Size(95, 32);
            this.btn_rehce_edt.TabIndex = 1;
            this.btn_rehce_edt.Text = "Rechercher";
            this.btn_rehce_edt.UseVisualStyleBackColor = true;
            this.btn_rehce_edt.Click += new System.EventHandler(this.btn_rehce_edt_Click);
            // 
            // btnQtr
            // 
            this.btnQtr.Location = new System.Drawing.Point(481, 275);
            this.btnQtr.Name = "btnQtr";
            this.btnQtr.Size = new System.Drawing.Size(95, 32);
            this.btnQtr.TabIndex = 1;
            this.btnQtr.Text = "Quitter";
            this.btnQtr.UseVisualStyleBackColor = true;
            this.btnQtr.Click += new System.EventHandler(this.btnQtr_Click);
            // 
            // dataGV_edt
            // 
            this.dataGV_edt.AutoGenerateColumns = false;
            this.dataGV_edt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV_edt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.numeroinscriptionDataGridViewTextBoxColumn,
            this.idlivreDataGridViewTextBoxColumn});
            this.dataGV_edt.DataSource = this.editeurRowBindingSource;
            this.dataGV_edt.Location = new System.Drawing.Point(12, 72);
            this.dataGV_edt.Name = "dataGV_edt";
            this.dataGV_edt.Size = new System.Drawing.Size(544, 165);
            this.dataGV_edt.TabIndex = 2;
            // 
            // editeurRowBindingSource
            // 
            this.editeurRowBindingSource.DataSource = typeof(TP2.DataSet1.editeurRow);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // numeroinscriptionDataGridViewTextBoxColumn
            // 
            this.numeroinscriptionDataGridViewTextBoxColumn.DataPropertyName = "numero_inscription";
            this.numeroinscriptionDataGridViewTextBoxColumn.HeaderText = "numero_inscription";
            this.numeroinscriptionDataGridViewTextBoxColumn.Name = "numeroinscriptionDataGridViewTextBoxColumn";
            // 
            // idlivreDataGridViewTextBoxColumn
            // 
            this.idlivreDataGridViewTextBoxColumn.DataPropertyName = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.HeaderText = "id_livre";
            this.idlivreDataGridViewTextBoxColumn.Name = "idlivreDataGridViewTextBoxColumn";
            // 
            // Gestion_Editeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 319);
            this.Controls.Add(this.dataGV_edt);
            this.Controls.Add(this.btnQtr);
            this.Controls.Add(this.btn_rehce_edt);
            this.Controls.Add(this.text_Rech_edt);
            this.Name = "Gestion_Editeur";
            this.Text = "Gestion_Editeur";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV_edt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editeurRowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_Rech_edt;
        private System.Windows.Forms.Button btn_rehce_edt;
        private System.Windows.Forms.Button btnQtr;
        private System.Windows.Forms.DataGridView dataGV_edt;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroinscriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlivreDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource editeurRowBindingSource;
    }
}