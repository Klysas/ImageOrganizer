using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Neurotec.Gui;
using Neurotec.Biometrics.Gui;
using Neurotec.Images;
using Neurotec.Biometrics;
using Neurotec.Biometrics.Client;
using Neurotec.Licensing;
using System.Diagnostics;
using System.IO;

namespace ImageOrganizer
{
	//========================================================
	//	Enums
	//========================================================

	public enum Position
	{
		LEFT = 2,
		RIGHT = 1
	}
	
	public partial class ImageControl : UserControl
	{
		//========================================================
		//	Private variables
		//========================================================

		private Position position;

		//========================================================
		//	Constructors
		//========================================================

		public ImageControl(Position position) : this()
		{
			this.position = position;

			GrpBox_Main.Text = this.position == Position.LEFT ? "Left" : "Right";
		}

		public ImageControl()
		{
			InitializeComponent();

			this.DragEnter += EDragEnter;
			this.DragDrop += EDragDrop;
		}

		//========================================================
		//	Private events
		//========================================================

		private void EDragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				e.Effect = DragDropEffects.Copy;
			}
			else
			{
				e.Effect = DragDropEffects.None;
			}
		}

		private void EDragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
			{
				// Gets all paths of files dropped on form.
				var filePaths = (string[])(e.Data.GetData(DataFormats.FileDrop));
				if (filePaths != null && filePaths.Length > 0)
				{
					LoadImage(filePaths[0]);
				}
			}
		}

		private void Btn_LoadImage_Click(object sender, EventArgs e)
		{
			PhoneScript.DownloadFilesFromPhone();
			PhoneScript.DeleteDirectoryOnPhone();

			//Loads image from dir 
			var dir = Path.GetDirectoryName(Properties.Settings.Default.PATH_PC_TARGET_DIR + "\\");
			if (Directory.GetFiles(dir).Length != 0)
			{
				var path = Directory.GetFiles(dir)[0];
				if (path != null)
				{
					LoadImage(path);
					File.Delete(path);
				}
			}
			else
			{
				MessageBox.Show("No files were found.");
			}
		}

		//========================================================
		//	Public properties
		//========================================================

		public NImage Image
		{
			get
			{
				return _irisView.Iris.Image;
			}
			set
			{
				_irisView.Iris = new NIris { Image = value };
			}
		}

		public string ImageExtension
		{
			get;
			private set;
		}

		//========================================================
		//	Private methods
		//========================================================

		private void LoadImage(string file)
		{
			Image = NImage.FromFile(file);
			ImageExtension = Path.GetExtension(file);
			SaveImage();
		}

		/// <summary>
		/// Saves image to "\UserName" directory.
		/// </summary>
		private void SaveImage()
		{
			string userDir = Properties.Settings.Default.PATH_IMAGE_SAVING_DIR + "\\" + MainForm.UserName;
			if (!Directory.Exists(userDir)) Directory.CreateDirectory(userDir);

			Image.Save(userDir + string.Format("\\{0}_{1}_{2}{3}", MainForm.UserName, (int)this.position,
				(this.Parent.Parent as ImagePairControl).Index, ImageExtension));
		}

		//========================================================
		//	Public methods
		//========================================================

		public void Clear()
		{
			if (_irisView.Iris != null)
			{
				var item = _irisView.Iris;
				_irisView.Iris = null;
				item.Dispose();
			}
		}

		public bool IsImageLoaded()
		{
			if (_irisView.Iris != null && _irisView.Iris.Image != null) return true;
			return false;
		}

	}
}
