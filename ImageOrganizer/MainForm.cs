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

		private int _index = 0;

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
			this.KeyPreview = true;
			this.KeyDown += MainForm_KeyDown;
			
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
				_index = 0;

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
			UpdateUI();
		}

		void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			Console.WriteLine(e.KeyCode);
			if (e.KeyCode == Keys.Enter && !e.Control) // SPACE
			{
				if (IsImageLoaded())
				{
					_index++;
				}
				LoadImage();
			}
			if (e.KeyCode == Keys.Space && e.Control) // CONTROL + SPACE
			{
				LoadImage();
			}
			if (e.KeyCode == Keys.End) // END
			{
				if(_index < 19)
					_index++;
			}
			if (e.KeyCode == Keys.Delete) // DELETE
			{
				if(_index > 0)
					_index--;
			}
			UpdateUI();
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
			_index = 0;
			UpdateUI();
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

		private void UpdateUI()
		{
			for (int i = 1; i <= 10; i++)
			{
				ImageBlockControl_1.getImagePairControl(i).Right.SetGroupBGColor(System.Drawing.SystemColors.Control);
				ImageBlockControl_1.getImagePairControl(i).Left.SetGroupBGColor(System.Drawing.SystemColors.Control);
			}

			switch (_index % 2)
			{
				case 0:
					{
						ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Right.SetGroupBGColor(System.Drawing.SystemColors.ControlDark);
						ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Right.Focus();
					}
					break;
				case 1:
					{
						ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Left.SetGroupBGColor(System.Drawing.SystemColors.ControlDark);
						ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Left.Focus();
					}
					break;
			}
		}

		private bool IsImageLoaded()
		{
			switch (_index % 2)
			{
				case 0: return ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Right.IsImageLoaded();
				case 1: return ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Left.IsImageLoaded();
				default: return false;
			}
		}

		private bool LoadImage()
		{
			switch (_index % 2)
			{
				case 0: return ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Right.LoadImage();
				case 1: return ImageBlockControl_1.getImagePairControl((_index / 2) + 1).Left.LoadImage();
				default: return false;
			}
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
			
			// Updates index position.
			_index = -1;
			for (int i = 1; i <= 10; i++)
			{
				if (ImageBlockControl_1.getImagePairControl(i).Right.IsImageLoaded())
				{
					_index++;
				}
				else
				{
					break;
				}
				if (ImageBlockControl_1.getImagePairControl(i).Left.IsImageLoaded()) 
				{
					_index++;
				}
				else
				{
					break;
				}
			}
			if (_index == -1) _index++;
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
