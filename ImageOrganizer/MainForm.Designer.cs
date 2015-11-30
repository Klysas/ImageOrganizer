namespace ImageOrganizer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.TxtBox_Name = new System.Windows.Forms.TextBox();
			this.ToolStrip_Menu = new System.Windows.Forms.ToolStrip();
			this.TSBtn_SaveImages = new System.Windows.Forms.ToolStripButton();
			this.TSBtn_ClearImages = new System.Windows.Forms.ToolStripButton();
			this.TSBtn_Settings = new System.Windows.Forms.ToolStripButton();
			this.Lbl_Name = new System.Windows.Forms.Label();
			this.ImageBlockControl_1 = new ImageOrganizer.ImageBlockControl();
			this.TSBtn_New = new System.Windows.Forms.ToolStripButton();
			this.ToolStrip_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// TxtBox_Name
			// 
			this.TxtBox_Name.Location = new System.Drawing.Point(57, 28);
			this.TxtBox_Name.Name = "TxtBox_Name";
			this.TxtBox_Name.Size = new System.Drawing.Size(122, 20);
			this.TxtBox_Name.TabIndex = 4;
			// 
			// ToolStrip_Menu
			// 
			this.ToolStrip_Menu.CanOverflow = false;
			this.ToolStrip_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSBtn_New,
            this.TSBtn_SaveImages,
            this.TSBtn_ClearImages,
            this.TSBtn_Settings});
			this.ToolStrip_Menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
			this.ToolStrip_Menu.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip_Menu.Name = "ToolStrip_Menu";
			this.ToolStrip_Menu.Size = new System.Drawing.Size(799, 25);
			this.ToolStrip_Menu.TabIndex = 5;
			// 
			// TSBtn_SaveImages
			// 
			this.TSBtn_SaveImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TSBtn_SaveImages.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_SaveImages.Image")));
			this.TSBtn_SaveImages.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBtn_SaveImages.Name = "TSBtn_SaveImages";
			this.TSBtn_SaveImages.Size = new System.Drawing.Size(76, 22);
			this.TSBtn_SaveImages.Text = "Save images";
			this.TSBtn_SaveImages.Click += new System.EventHandler(this.TSBtn_SaveImages_Click);
			// 
			// TSBtn_ClearImages
			// 
			this.TSBtn_ClearImages.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TSBtn_ClearImages.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_ClearImages.Image")));
			this.TSBtn_ClearImages.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBtn_ClearImages.Name = "TSBtn_ClearImages";
			this.TSBtn_ClearImages.Size = new System.Drawing.Size(79, 22);
			this.TSBtn_ClearImages.Text = "Clear images";
			this.TSBtn_ClearImages.Click += new System.EventHandler(this.TSBtn_ClearImages_Click);
			// 
			// TSBtn_Settings
			// 
			this.TSBtn_Settings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TSBtn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_Settings.Image")));
			this.TSBtn_Settings.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBtn_Settings.Name = "TSBtn_Settings";
			this.TSBtn_Settings.Size = new System.Drawing.Size(53, 22);
			this.TSBtn_Settings.Text = "Settings";
			this.TSBtn_Settings.Click += new System.EventHandler(this.TSBtn_Settings_Click);
			// 
			// Lbl_Name
			// 
			this.Lbl_Name.AutoSize = true;
			this.Lbl_Name.Location = new System.Drawing.Point(13, 31);
			this.Lbl_Name.Name = "Lbl_Name";
			this.Lbl_Name.Size = new System.Drawing.Size(38, 13);
			this.Lbl_Name.TabIndex = 6;
			this.Lbl_Name.Text = "Name:";
			// 
			// ImageBlockControl_1
			// 
			this.ImageBlockControl_1.AllowDrop = true;
			this.ImageBlockControl_1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.ImageBlockControl_1.AutoScroll = true;
			this.ImageBlockControl_1.Location = new System.Drawing.Point(12, 65);
			this.ImageBlockControl_1.Name = "ImageBlockControl_1";
			this.ImageBlockControl_1.Size = new System.Drawing.Size(775, 338);
			this.ImageBlockControl_1.TabIndex = 0;
			// 
			// TSBtn_New
			// 
			this.TSBtn_New.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.TSBtn_New.Image = ((System.Drawing.Image)(resources.GetObject("TSBtn_New.Image")));
			this.TSBtn_New.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.TSBtn_New.Margin = new System.Windows.Forms.Padding(12, 1, 0, 2);
			this.TSBtn_New.Name = "TSBtn_New";
			this.TSBtn_New.Size = new System.Drawing.Size(35, 22);
			this.TSBtn_New.Text = "New";
			this.TSBtn_New.Click += new System.EventHandler(this.TSBtn_New_Click);
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(799, 415);
			this.Controls.Add(this.Lbl_Name);
			this.Controls.Add(this.ToolStrip_Menu);
			this.Controls.Add(this.TxtBox_Name);
			this.Controls.Add(this.ImageBlockControl_1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Organizer";
			this.ToolStrip_Menu.ResumeLayout(false);
			this.ToolStrip_Menu.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ImageBlockControl ImageBlockControl_1;
		private System.Windows.Forms.TextBox TxtBox_Name;
		private System.Windows.Forms.ToolStrip ToolStrip_Menu;
		private System.Windows.Forms.ToolStripButton TSBtn_Settings;
		private System.Windows.Forms.ToolStripButton TSBtn_SaveImages;
		private System.Windows.Forms.ToolStripButton TSBtn_ClearImages;
		private System.Windows.Forms.Label Lbl_Name;
		private System.Windows.Forms.ToolStripButton TSBtn_New;


	}
}

