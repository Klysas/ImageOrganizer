﻿using Neurotec.Images;
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
		SettingsForm Settings;
		
		#region Public constructors

		public MainForm()
		{
			InitializeComponent();

			Settings = new SettingsForm();
		}

		#endregion

		#region Private methods

		private void TSBtn_ClearImages_Click(object sender, EventArgs e)
		{
			ImageBlockControl_1.Clear();
		}

		private void BtnClick_ClearImages(object sender, EventArgs e)
		{
			
		}

		private void TSBtn_SaveImages_Click(object sender, EventArgs e)
		{
			if (TxtBox_Name.Text != string.Empty)
			{
				//string directory = Path.GetDirectoryName(Properties.Settings.Default.PATH_IMAGE_SAVING_DIR + "\\");
				//if (directory == null)
				//{
				//	MessageBox.Show("Directory path is incorrect.");
				//	return;
				//}

				//if (!Directory.Exists(directory))
				//{
				//	Console.WriteLine("Directory created: "+ directory);
				//	Directory.CreateDirectory(directory);
				//}

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

		#endregion
	}
}
