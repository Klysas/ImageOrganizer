using Neurotec.Biometrics.Gui;
namespace ImageOrganizer
{
	partial class ImageControl
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
			this.Btn_LoadImage = new System.Windows.Forms.Button();
			this._irisView = new Neurotec.Biometrics.Gui.NIrisView();
			this.GrpBox_Main.SuspendLayout();
			this.SuspendLayout();
			// 
			// GrpBox_Main
			// 
			this.GrpBox_Main.Controls.Add(this.Btn_LoadImage);
			this.GrpBox_Main.Controls.Add(this._irisView);
			this.GrpBox_Main.Location = new System.Drawing.Point(3, 0);
			this.GrpBox_Main.Name = "GrpBox_Main";
			this.GrpBox_Main.Size = new System.Drawing.Size(381, 255);
			this.GrpBox_Main.TabIndex = 0;
			this.GrpBox_Main.TabStop = false;
			this.GrpBox_Main.Text = "TEXT";
			// 
			// Btn_LoadImage
			// 
			this.Btn_LoadImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.Btn_LoadImage.Location = new System.Drawing.Point(260, 19);
			this.Btn_LoadImage.Name = "Btn_LoadImage";
			this.Btn_LoadImage.Size = new System.Drawing.Size(115, 127);
			this.Btn_LoadImage.TabIndex = 1;
			this.Btn_LoadImage.Text = "Load Image";
			this.Btn_LoadImage.UseVisualStyleBackColor = true;
			this.Btn_LoadImage.Click += new System.EventHandler(this.Btn_LoadImage_Click);
			// 
			// _irisView
			// 
			this._irisView.BackColor = System.Drawing.SystemColors.Control;
			this._irisView.InnerBoundaryColor = System.Drawing.Color.Red;
			this._irisView.InnerBoundaryWidth = 2;
			this._irisView.Iris = null;
			this._irisView.Location = new System.Drawing.Point(6, 19);
			this._irisView.Name = "_irisView";
			this._irisView.OuterBoundaryColor = System.Drawing.Color.GreenYellow;
			this._irisView.OuterBoundaryWidth = 2;
			this._irisView.Size = new System.Drawing.Size(248, 230);
			this._irisView.TabIndex = 0;
			// 
			// ImageControl
			// 
			this.AllowDrop = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.GrpBox_Main);
			this.Name = "ImageControl";
			this.Size = new System.Drawing.Size(387, 258);
			this.GrpBox_Main.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox GrpBox_Main;
		private NIrisView _irisView;
		private System.Windows.Forms.Button Btn_LoadImage;
	}
}
