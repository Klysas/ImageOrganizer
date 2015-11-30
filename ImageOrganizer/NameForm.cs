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
	public partial class NameForm : Form
	{
		//========================================================
		//	Constructors
		//========================================================
		
		public NameForm()
		{
			InitializeComponent();

			this.Shown += NameForm_Shown;
		}

		//========================================================
		//	Private events
		//========================================================

		private void Btn_Cancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void Btn_Ok_Click(object sender, EventArgs e)
		{
			string name = TxtBox_Name.Text.Trim();

			if (name.Equals(string.Empty))
			{
				MessageBox.Show("Name is empty. Input name.");
				return;
			}

			Name = name;
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		void NameForm_Shown(object sender, EventArgs e)
		{
			TxtBox_Name.Text = string.Empty;
			TxtBox_Name.Focus();
		}

		//========================================================
		//	Public properties
		//========================================================

		public string Name
		{
			get;
			private set;
		}

	}
}
