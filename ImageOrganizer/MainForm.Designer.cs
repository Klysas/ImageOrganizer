﻿namespace ImageOrganizer
{
	partial class MainForm
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
			this.TxtBox_DatabasePath = new System.Windows.Forms.TextBox();
			this.Btn_SaveImages = new System.Windows.Forms.Button();
			this.Btn_ClearImages = new System.Windows.Forms.Button();
			this.TxtBox_Name = new System.Windows.Forms.TextBox();
			this.ImageBlockControl_1 = new ImageOrganizer.ImageBlockControl();
			this.SuspendLayout();
			// 
			// TxtBox_DatabasePath
			// 
			this.TxtBox_DatabasePath.Location = new System.Drawing.Point(12, 13);
			this.TxtBox_DatabasePath.Name = "TxtBox_DatabasePath";
			this.TxtBox_DatabasePath.Size = new System.Drawing.Size(230, 20);
			this.TxtBox_DatabasePath.TabIndex = 1;
			this.TxtBox_DatabasePath.Text = "C:\\";
			// 
			// Btn_SaveImages
			// 
			this.Btn_SaveImages.Location = new System.Drawing.Point(248, 13);
			this.Btn_SaveImages.Name = "Btn_SaveImages";
			this.Btn_SaveImages.Size = new System.Drawing.Size(81, 23);
			this.Btn_SaveImages.TabIndex = 2;
			this.Btn_SaveImages.Text = "Save Images";
			this.Btn_SaveImages.UseVisualStyleBackColor = true;
			this.Btn_SaveImages.Click += new System.EventHandler(this.BtnClick_SaveImages);
			// 
			// Btn_ClearImages
			// 
			this.Btn_ClearImages.Location = new System.Drawing.Point(335, 13);
			this.Btn_ClearImages.Name = "Btn_ClearImages";
			this.Btn_ClearImages.Size = new System.Drawing.Size(96, 23);
			this.Btn_ClearImages.TabIndex = 3;
			this.Btn_ClearImages.Text = "Clear All Images";
			this.Btn_ClearImages.UseVisualStyleBackColor = true;
			this.Btn_ClearImages.Click += new System.EventHandler(this.BtnClick_ClearImages);
			// 
			// TxtBox_Name
			// 
			this.TxtBox_Name.Location = new System.Drawing.Point(438, 15);
			this.TxtBox_Name.Name = "TxtBox_Name";
			this.TxtBox_Name.Size = new System.Drawing.Size(100, 20);
			this.TxtBox_Name.TabIndex = 4;
			// 
			// ImageBlockControl_1
			// 
			this.ImageBlockControl_1.AllowDrop = true;
			this.ImageBlockControl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImageBlockControl_1.AutoScroll = true;
			this.ImageBlockControl_1.Location = new System.Drawing.Point(12, 51);
			this.ImageBlockControl_1.Name = "ImageBlockControl_1";
			this.ImageBlockControl_1.Size = new System.Drawing.Size(643, 270);
			this.ImageBlockControl_1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(667, 333);
			this.Controls.Add(this.TxtBox_Name);
			this.Controls.Add(this.Btn_ClearImages);
			this.Controls.Add(this.Btn_SaveImages);
			this.Controls.Add(this.TxtBox_DatabasePath);
			this.Controls.Add(this.ImageBlockControl_1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Organizer";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ImageBlockControl ImageBlockControl_1;
		private System.Windows.Forms.TextBox TxtBox_DatabasePath;
		private System.Windows.Forms.Button Btn_SaveImages;
		private System.Windows.Forms.Button Btn_ClearImages;
		private System.Windows.Forms.TextBox TxtBox_Name;


	}
}
