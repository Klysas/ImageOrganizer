using Neurotec.Images;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOrganizer
{
	public partial class MainForm : Form
	{
		//========================================================
		//	Private variables
		//========================================================

		private SettingsForm Settings;

		//========================================================
		//	Constructors
		//========================================================

		public MainForm()
		{
			InitializeComponent();

			Settings = new SettingsForm();
			UserName = "some";
		}

		//========================================================
		//	Private events
		//========================================================

		private void TSBtn_ClearImages_Click(object sender, EventArgs e)
		{
			ImageBlockControl_1.Clear();
		}

		private void TSBtn_SaveImages_Click(object sender, EventArgs e)
		{
			if (TxtBox_Name.Text != string.Empty)
			{
				//Check if all images are loaded
				foreach (var item in ImageBlockControl_1.ImagePairControls)
				{
					if (!item.Left.IsImageLoaded() || !item.Right.IsImageLoaded())
					{
						MessageBox.Show("Not all images are loaded.");
						return;
					}
				}
				SaveImages();
			}
		}

		private void TSBtn_Settings_Click(object sender, EventArgs e)
		{
			Settings.ShowDialog();
		}

		//========================================================
		//	Public static properties
		//========================================================

		public static string UserName
		{
			get;
			private set;
		}

		//========================================================
		//	Private methods
		//========================================================

		private void SaveImages()
		{
			string directory = Path.GetDirectoryName(Properties.Settings.Default.PATH_IMAGE_SAVING_DIR + "\\");
			foreach (var pairControl in ImageBlockControl_1.ImagePairControls)
			{
				string path = directory + "\\" + string.Format("{0}_{1}_{2}{3}", TxtBox_Name.Text.Trim(), 1, pairControl.Index, pairControl.Right.ImageExtension);
				pairControl.Right.Image.Save(path);
				path = directory + "\\" + string.Format("{0}_{1}_{2}{3}", TxtBox_Name.Text.Trim(), 2, pairControl.Index, pairControl.Left.ImageExtension);
				pairControl.Left.Image.Save(path);
			}
		}
	}
}
