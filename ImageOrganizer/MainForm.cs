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

		private NameForm InputName;

		//========================================================
		//	Constructors
		//========================================================

		public MainForm()
		{
			InitializeComponent();
			UserName = string.Empty;

			Settings = new SettingsForm();
			InputName = new NameForm();

			InputName.FormClosed += InputName_FormClosed;
			this.Shown += MainForm_Shown;
		}

		//========================================================
		//	Private events
		//========================================================

		void InputName_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (InputName.DialogResult == System.Windows.Forms.DialogResult.OK)
			{
				UserName = InputName.Name;
				TSLbl_Name.Text = string.Format("Name: {0}", UserName);
				ImageBlockControl_1.Clear();

				if(UserExists(UserName) 
					&& (MessageBox.Show("User already exists, do you want to load saved images?", string.Empty, MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes))
				{
					LoadUserImages();
				}
			}
			else if ((InputName.DialogResult == System.Windows.Forms.DialogResult.Cancel) && (UserName.Equals(string.Empty)))
			{
				this.Close();
			}
		}
		
		void MainForm_Shown(object sender, EventArgs e)
		{
			if (UserName == null || UserName.Equals(string.Empty)) InputName.ShowDialog();
		}

		private void TSBtn_ClearImages_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show(string.Format("Do you want to delete all files for '{0}'", UserName), string.Empty,MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
			{
				try
				{
					Utils.DeleteDirectory(Properties.Settings.Default.PATH_IMAGE_SAVING_DIR + "\\" + UserName);
				}
				catch (DirectoryNotFoundException)
				{
					return;
				}
				catch (IOException ex)
				{
					MessageBox.Show(ex.ToString(), string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			ImageBlockControl_1.Clear();
		}

		private void TSBtn_New_Click(object sender, EventArgs e)
		{
			InputName.ShowDialog();
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

		private bool UserExists(string name)
		{
			if(Directory.GetDirectories(Properties.Settings.Default.PATH_IMAGE_SAVING_DIR, name).Length > 0) return true;
			return false;
		}

		private void LoadUserImages()
		{
			var files = Directory.GetFiles(Properties.Settings.Default.PATH_IMAGE_SAVING_DIR + "\\" + UserName);

			int index, position;
			foreach (string file in files)
			{
				ExtractValuesFromFileName(Path.GetFileNameWithoutExtension(file), out index, out position);
				if (index != 0 && position != 0)
				{
					var pairControl = ImageBlockControl_1.getImagePairControl(index);

					ImageControl control = null;
					switch ((Position)position)
					{
						case Position.LEFT: control = pairControl.Left;
							break;
						case Position.RIGHT: control = pairControl.Right;
							break;
					}

					if (control != null)
					{
						control.Image = NImage.FromFile(file);
					}
				}
			}
		}

		private void ExtractValuesFromFileName(string fileName, out int index, out int position)
		{
			index = position = 0; // Default values.

			var values = fileName.Split('_');
			if (values != null && values.Length == 3)
			{
				position = int.Parse(values[1]);
				index = int.Parse(values[2]);
			}
		}
	}
}
