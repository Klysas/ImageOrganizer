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
			}
		}
		
		void MainForm_Shown(object sender, EventArgs e)
		{
			if (UserName == null || UserName.Equals(string.Empty)) InputName.ShowDialog();
		}

		private void TSBtn_ClearImages_Click(object sender, EventArgs e)
		{
			ImageBlockControl_1.Clear();
			//TODO: remove images from directory(with confirmation).
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
