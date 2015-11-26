using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOrganizer
{
	public partial class SettingsForm : Form
	{
		public SettingsForm()
		{
			InitializeComponent();
			this.Shown += SettingsForm_Shown;
		}

		void SettingsForm_Shown(object sender, EventArgs e)
		{
			settingsControl1.UpdateUI();
		}
	}
}
