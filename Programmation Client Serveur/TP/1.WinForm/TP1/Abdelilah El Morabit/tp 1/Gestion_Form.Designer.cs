namespace tp_1
{
	partial class Gestion_Form
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
			this.btnGstT = new System.Windows.Forms.Button();
			this.btnGstP = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnGstT
			// 
			this.btnGstT.Location = new System.Drawing.Point(12, 49);
			this.btnGstT.Name = "btnGstT";
			this.btnGstT.Size = new System.Drawing.Size(104, 23);
			this.btnGstT.TabIndex = 0;
			this.btnGstT.Text = "Gestion Teams";
			this.btnGstT.UseVisualStyleBackColor = true;
			this.btnGstT.Click += new System.EventHandler(this.btnGstT_Click);
			// 
			// btnGstP
			// 
			this.btnGstP.Location = new System.Drawing.Point(137, 49);
			this.btnGstP.Name = "btnGstP";
			this.btnGstP.Size = new System.Drawing.Size(95, 23);
			this.btnGstP.TabIndex = 1;
			this.btnGstP.Text = "Gestion Players";
			this.btnGstP.UseVisualStyleBackColor = true;
			this.btnGstP.Click += new System.EventHandler(this.btnGstP_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(97, 22);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Gestion :";
			// 
			// Gestion_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 134);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnGstP);
			this.Controls.Add(this.btnGstT);
			this.Name = "Gestion_Form";
			this.Text = "Gestion_Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnGstT;
		private System.Windows.Forms.Button btnGstP;
		private System.Windows.Forms.Label label1;
	}
}