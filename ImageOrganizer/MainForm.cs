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
				//TODO: remove images from directory for UserName.
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

	}
}
