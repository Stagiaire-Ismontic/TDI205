namespace Syndic.Presentation
{
    partial class Ville
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
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.txtNew = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvRgionView = new System.Windows.Forms.DataGridView();
            this.txtCancel = new System.Windows.Forms.Button();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtTotalVille = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_region = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRgionView)).BeginInit();
            this.SuspendLayout();
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.DarkRed;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(605, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 38);
            this.button6.TabIndex = 43;
            this.button6.Text = "Supprimer";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(310, 145);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 42;
            this.button4.Text = "Début";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(391, 145);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Précedent";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(513, 145);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "Suivant";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(594, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "Fin";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblPos
            // 
            this.lblPos.AutoSize = true;
            this.lblPos.Location = new System.Drawing.Point(472, 150);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(35, 13);
            this.lblPos.TabIndex = 38;
            this.lblPos.Text = "label6";
            // 
            // txtNew
            // 
            this.txtNew.Location = new System.Drawing.Point(526, -35);
            this.txtNew.Name = "txtNew";
            this.txtNew.Size = new System.Drawing.Size(75, 23);
            this.txtNew.TabIndex = 37;
            this.txtNew.Text = "Nouveau";
            this.txtNew.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, -30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Liste des region :";
            // 
            // dgvRgionView
            // 
            this.dgvRgionView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRgionView.Location = new System.Drawing.Point(288, 12);
            this.dgvRgionView.Name = "dgvRgionView";
            this.dgvRgionView.Size = new System.Drawing.Size(398, 127);
            this.dgvRgionView.TabIndex = 35;
            this.dgvRgionView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRgionView_CellMouseClick);
            // 
            // txtCancel
            // 
            this.txtCancel.Location = new System.Drawing.Point(159, 99);
            this.txtCancel.Name = "txtCancel";
            this.txtCancel.Size = new System.Drawing.Size(75, 23);
            this.txtCancel.TabIndex = 34;
            this.txtCancel.Text = "Annuler";
            this.txtCancel.UseVisualStyleBackColor = true;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(78, 99);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(75, 23);
            this.txtSave.TabIndex = 33;
            this.txtSave.Text = "Enregistrer";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // txtTotalVille
            // 
            this.txtTotalVille.Location = new System.Drawing.Point(78, 73);
            this.txtTotalVille.Name = "txtTotalVille";
            this.txtTotalVille.Size = new System.Drawing.Size(156, 20);
            this.txtTotalVille.TabIndex = 32;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 20);
            this.txtName.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-76, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Total region";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-76, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Population total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-76, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nom de region";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Nom de ville";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Region";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Total_ville";
            // 
            // cb_region
            // 
            this.cb_region.FormattingEnabled = true;
            this.cb_region.Location = new System.Drawing.Point(78, 43);
            this.cb_region.Name = "cb_region";
            this.cb_region.Size = new System.Drawing.Size(156, 21);
            this.cb_region.TabIndex = 47;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(113, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ville
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 280);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_region);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.txtNew);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRgionView);
            this.Controls.Add(this.txtCancel);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.txtTotalVille);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ville";
            this.Text = "Ville";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRgionView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button txtNew;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvRgionView;
        private System.Windows.Forms.Button txtCancel;
        private System.Windows.Forms.Button txtSave;
        private System.Windows.Forms.TextBox txtTotalVille;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_region;
        private System.Windows.Forms.Button button1;
    }
}