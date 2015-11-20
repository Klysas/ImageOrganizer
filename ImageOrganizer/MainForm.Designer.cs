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
			this.imageBlockControl1 = new ImageOrganizer.ImageBlockControl();
			this.SuspendLayout();
			// 
			// imageBlockControl1
			// 
			this.imageBlockControl1.AllowDrop = true;
			this.imageBlockControl1.Location = new System.Drawing.Point(13, 13);
			this.imageBlockControl1.Name = "imageBlockControl1";
			this.imageBlockControl1.Size = new System.Drawing.Size(804, 573);
			this.imageBlockControl1.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(667, 333);
			this.Controls.Add(this.imageBlockControl1);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Image Organizer";
			this.ResumeLayout(false);

		}

		#endregion

		private ImageBlockControl imageBlockControl1;


	}
}

