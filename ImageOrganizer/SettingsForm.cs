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
	public partial class SettingsForm : Form
	{
		//========================================================
		//	Constructors
		//========================================================
		
		public SettingsForm()
		{
			InitializeComponent();

			this.Shown += SettingsForm_Shown;

			UpdateSettings();
		}

		//========================================================
		//	Private events
		//========================================================

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			// PC directory.
			var str = TxtBox_TargetDirOnPC.Text.Trim();
			if (IsValid(str))
			{
				if (!Directory.Exists(str)) Directory.CreateDirectory(str);
				Properties.Settings.Default.PATH_PC_TARGET_DIR = str;
			}

			// Phone directory.
			Properties.Settings.Default.PATH_PHONE_TARGET_DIR = TxtBox_TargetDirOnPhone.Text.Trim();

			// Image saving directory.
			str = TxtBox_ImagesSavingDirectory.Text.Trim();
			if (IsValid(str))
			{
				if (!Directory.Exists(str)) Directory.CreateDirectory(str);
				Properties.Settings.Default.PATH_IMAGE_SAVING_DIR = str;
			}

			Properties.Settings.Default.Save();
			UpdateSettings();
			this.Close();
		}

		private void SettingsForm_Shown(object sender, EventArgs e)
		{
			UpdateUI();
		}

		//========================================================
		//	Private methods
		//========================================================

		private bool IsValid(string str)
		{
			return (str != string.Empty && Path.GetDirectoryName(str) != null);
		}

		private void UpdateSettings()
		{
			PhoneScript.TargetDirectoryOnPC = Properties.Settings.Default.PATH_PC_TARGET_DIR;
			PhoneScript.TargetDirectoryOnPhone = Properties.Settings.Default.PATH_PHONE_TARGET_DIR;
		}

		/// <summary>
		/// Updates TextBoxes with according Settings values.
		/// </summary>
		private void UpdateUI()
		{
			TxtBox_TargetDirOnPC.Text = Properties.Settings.Default.PATH_PC_TARGET_DIR;
			TxtBox_TargetDirOnPhone.Text = Properties.Settings.Default.PATH_PHONE_TARGET_DIR;
			TxtBox_ImagesSavingDirectory.Text = Properties.Settings.Default.PATH_IMAGE_SAVING_DIR;
		}
	}
}
