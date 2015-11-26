namespace ImageOrganizer
{
	partial class SettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Lbl_TargetDirectoryOnPc = new System.Windows.Forms.Label();
			this.Lbl_TargetDirectoryOnPhone = new System.Windows.Forms.Label();
			this.TxtBox_TargetDirOnPC = new System.Windows.Forms.TextBox();
			this.TxtBox_TargetDirOnPhone = new System.Windows.Forms.TextBox();
			this.Btn_Save = new System.Windows.Forms.Button();
			this.Btn_Cancel = new System.Windows.Forms.Button();
			this.Lbl_ImageSavingDirectory = new System.Windows.Forms.Label();
			this.TxtBox_ImagesSavingDirectory = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// Lbl_TargetDirectoryOnPc
			// 
			this.Lbl_TargetDirectoryOnPc.AutoSize = true;
			this.Lbl_TargetDirectoryOnPc.Location = new System.Drawing.Point(3, 7);
			this.Lbl_TargetDirectoryOnPc.Name = "Lbl_TargetDirectoryOnPc";
			this.Lbl_TargetDirectoryOnPc.Size = new System.Drawing.Size(67, 13);
			this.Lbl_TargetDirectoryOnPc.TabIndex = 0;
			this.Lbl_TargetDirectoryOnPc.Text = "PC directory:";
			// 
			// Lbl_TargetDirectoryOnPhone
			// 
			this.Lbl_TargetDirectoryOnPhone.AutoSize = true;
			this.Lbl_TargetDirectoryOnPhone.Location = new System.Drawing.Point(3, 33);
			this.Lbl_TargetDirectoryOnPhone.Name = "Lbl_TargetDirectoryOnPhone";
			this.Lbl_TargetDirectoryOnPhone.Size = new System.Drawing.Size(84, 13);
			this.Lbl_TargetDirectoryOnPhone.TabIndex = 1;
			this.Lbl_TargetDirectoryOnPhone.Text = "Phone directory:";
			// 
			// TxtBox_TargetDirOnPC
			// 
			this.TxtBox_TargetDirOnPC.Location = new System.Drawing.Point(130, 3);
			this.TxtBox_TargetDirOnPC.Name = "TxtBox_TargetDirOnPC";
			this.TxtBox_TargetDirOnPC.Size = new System.Drawing.Size(144, 20);
			this.TxtBox_TargetDirOnPC.TabIndex = 2;
			// 
			// TxtBox_TargetDirOnPhone
			// 
			this.TxtBox_TargetDirOnPhone.Location = new System.Drawing.Point(130, 30);
			this.TxtBox_TargetDirOnPhone.Name = "TxtBox_TargetDirOnPhone";
			this.TxtBox_TargetDirOnPhone.Size = new System.Drawing.Size(144, 20);
			this.TxtBox_TargetDirOnPhone.TabIndex = 3;
			// 
			// Btn_Save
			// 
			this.Btn_Save.Location = new System.Drawing.Point(61, 228);
			this.Btn_Save.Name = "Btn_Save";
			this.Btn_Save.Size = new System.Drawing.Size(75, 23);
			this.Btn_Save.TabIndex = 4;
			this.Btn_Save.Text = "Save";
			this.Btn_Save.UseVisualStyleBackColor = true;
			this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
			// 
			// Btn_Cancel
			// 
			this.Btn_Cancel.Location = new System.Drawing.Point(156, 228);
			this.Btn_Cancel.Name = "Btn_Cancel";
			this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
			this.Btn_Cancel.TabIndex = 5;
			this.Btn_Cancel.Text = "Cancel";
			this.Btn_Cancel.UseVisualStyleBackColor = true;
			this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
			// 
			// Lbl_ImageSavingDirectory
			// 
			this.Lbl_ImageSavingDirectory.AutoSize = true;
			this.Lbl_ImageSavingDirectory.Location = new System.Drawing.Point(3, 77);
			this.Lbl_ImageSavingDirectory.Name = "Lbl_ImageSavingDirectory";
			this.Lbl_ImageSavingDirectory.Size = new System.Drawing.Size(121, 13);
			this.Lbl_ImageSavingDirectory.TabIndex = 6;
			this.Lbl_ImageSavingDirectory.Text = "Images saving directory:";
			// 
			// TxtBox_ImagesSavingDirectory
			// 
			this.TxtBox_ImagesSavingDirectory.Location = new System.Drawing.Point(130, 74);
			this.TxtBox_ImagesSavingDirectory.Name = "TxtBox_ImagesSavingDirectory";
			this.TxtBox_ImagesSavingDirectory.Size = new System.Drawing.Size(144, 20);
			this.TxtBox_ImagesSavingDirectory.TabIndex = 7;
			// 
			// SettingsControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.TxtBox_ImagesSavingDirectory);
			this.Controls.Add(this.Lbl_ImageSavingDirectory);
			this.Controls.Add(this.Btn_Cancel);
			this.Controls.Add(this.Btn_Save);
			this.Controls.Add(this.TxtBox_TargetDirOnPhone);
			this.Controls.Add(this.TxtBox_TargetDirOnPC);
			this.Controls.Add(this.Lbl_TargetDirectoryOnPhone);
			this.Controls.Add(this.Lbl_TargetDirectoryOnPc);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(288, 261);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Lbl_TargetDirectoryOnPc;
		private System.Windows.Forms.Label Lbl_TargetDirectoryOnPhone;
		private System.Windows.Forms.TextBox TxtBox_TargetDirOnPC;
		private System.Windows.Forms.TextBox TxtBox_TargetDirOnPhone;
		private System.Windows.Forms.Button Btn_Save;
		private System.Windows.Forms.Button Btn_Cancel;
		private System.Windows.Forms.Label Lbl_ImageSavingDirectory;
		private System.Windows.Forms.TextBox TxtBox_ImagesSavingDirectory;
	}
}
