namespace ImageOrganizer
{
	partial class ImagePairControl
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
			this.GrpBox_Main = new System.Windows.Forms.GroupBox();
			this.ImageControl_Right = new ImageOrganizer.ImageControl(ImageControl.Position.RIGHT);
			this.ImageControl_Left = new ImageOrganizer.ImageControl(ImageControl.Position.LEFT);
			this.GrpBox_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// GrpBox_Main
			// 
			this.GrpBox_Main.Controls.Add(this.ImageControl_Right);
			this.GrpBox_Main.Controls.Add(this.ImageControl_Left);
			this.GrpBox_Main.Location = new System.Drawing.Point(0, 0);
			this.GrpBox_Main.Name = "GrpBox_Main";
			this.GrpBox_Main.Size = new System.Drawing.Size(799, 286);
			this.GrpBox_Main.TabIndex = 0;
			this.GrpBox_Main.TabStop = false;
			this.GrpBox_Main.Text = "TEXT";
			// 
			// ImageControl_Right
			// 
			this.ImageControl_Right.AllowDrop = true;
			this.ImageControl_Right.Location = new System.Drawing.Point(402, 19);
			this.ImageControl_Right.Name = "ImageControl_Right";
			this.ImageControl_Right.Size = new System.Drawing.Size(391, 258);
			this.ImageControl_Right.TabIndex = 1;
			// 
			// ImageControl_Left
			// 
			this.ImageControl_Left.AllowDrop = true;
			this.ImageControl_Left.Location = new System.Drawing.Point(3, 19);
			this.ImageControl_Left.Name = "ImageControl_Left";
			this.ImageControl_Left.Size = new System.Drawing.Size(392, 258);
			this.ImageControl_Left.TabIndex = 0;
			// 
			// ImagePairControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GrpBox_Main);
			this.Name = "ImagePairControl";
			this.Size = new System.Drawing.Size(802, 291);
			this.GrpBox_Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GrpBox_Main;
		private ImageControl ImageControl_Left;
		private ImageControl ImageControl_Right;
	}
}
