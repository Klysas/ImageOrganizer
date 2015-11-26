using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ImageOrganizer
{
	public partial class SettingsControl : UserControl
	{
		public SettingsControl()
		{
			InitializeComponent();

			//Update settings
			UpdateUI();
			UpdateSettings();
		}

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			(this.Parent as Form).Close();
		}

		private void Btn_Save_Click(object sender, EventArgs e)
		{
			//TODO: validate input before saving to settings.
			// Save settings.
			var str = TxtBox_TargetDirOnPC.Text.Trim();
			if (IsValid(str))
			{
				Properties.Settings.Default.PATH_PC_TARGET_DIR = str;
			}

			Properties.Settings.Default.PATH_PHONE_TARGET_DIR = TxtBox_TargetDirOnPhone.Text.Trim();

			str = TxtBox_ImagesSavingDirectory.Text.Trim();
			if (IsValid(str))
			{
				Properties.Settings.Default.PATH_IMAGE_SAVING_DIR = str;
			}
			Properties.Settings.Default.Save();

			UpdateSettings();

			(this.Parent as Form).Close();
		}

		private bool IsValid(string str)
		{
			return (str != string.Empty && Path.GetDirectoryName(str) != null);
		}

		private void UpdateSettings()
		{
			PhoneScript.TargetDirectoryOnPC = Properties.Settings.Default.PATH_PC_TARGET_DIR;
			PhoneScript.TargetDirectoryOnPhone = Properties.Settings.Default.PATH_PHONE_TARGET_DIR;
		}

		public void UpdateUI()
		{
			TxtBox_TargetDirOnPC.Text = Properties.Settings.Default.PATH_PC_TARGET_DIR;
			TxtBox_TargetDirOnPhone.Text = Properties.Settings.Default.PATH_PHONE_TARGET_DIR;
			TxtBox_ImagesSavingDirectory.Text = Properties.Settings.Default.PATH_IMAGE_SAVING_DIR;
		}
	}
}
