namespace ImageOrganizer
{
	partial class NameForm
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
			this.TxtBox_Name = new System.Windows.Forms.TextBox();
			this.Lbl_Name = new System.Windows.Forms.Label();
			this.Btn_Ok = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TxtBox_Name
			// 
			this.TxtBox_Name.Location = new System.Drawing.Point(56, 6);
			this.TxtBox_Name.Name = "TxtBox_Name";
			this.TxtBox_Name.Size = new System.Drawing.Size(138, 20);
			this.TxtBox_Name.TabIndex = 0;
			// 
			// Lbl_Name
			// 
			this.Lbl_Name.AutoSize = true;
			this.Lbl_Name.Location = new System.Drawing.Point(12, 9);
			this.Lbl_Name.Name = "Lbl_Name";
			this.Lbl_Name.Size = new System.Drawing.Size(38, 13);
			this.Lbl_Name.TabIndex = 1;
			this.Lbl_Name.Text = "Name:";
			// 
			// Btn_Ok
			// 
			this.Btn_Ok.Location = new System.Drawing.Point(12, 32);
			this.Btn_Ok.Name = "Btn_Ok";
			this.Btn_Ok.Size = new System.Drawing.Size(75, 23);
			this.Btn_Ok.TabIndex = 2;
			this.Btn_Ok.Text = "OK";
			this.Btn_Ok.UseVisualStyleBackColor = true;
			this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(116, 32);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 3;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// NameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(203, 63);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Ok);
			this.Controls.Add(this.Lbl_Name);
			this.Controls.Add(this.TxtBox_Name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "NameForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Input name";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TxtBox_Name;
		private System.Windows.Forms.Label Lbl_Name;
		private System.Windows.Forms.Button Btn_Ok;
		private System.Windows.Forms.Button Btn_Cancel;
	}
}