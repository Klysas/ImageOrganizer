using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageOrganizer
{
	public partial class ImageBlockControl : UserControl
	{
		#region Private variables

		private ImagePairControl[] _list = new ImagePairControl[10];



		public ImagePairControl[] ImagePairControls
		{
			get
			{
				return _list;
			}
		}

		#endregion

		#region Public constructors

		public ImageBlockControl()
		{
			InitializeComponent();

			for (int i = 0; i < 10; i++)
			{
				var control = new ImagePairControl();

				control.Index = i + 1;
				control.Location = new Point(0, 0 + (i*control.Height));

				this.Controls.Add(control);
				_list[i] = control;
			}
		}

		#endregion

		#region Public methods

		public void Clear()
		{
			foreach (var item in _list)
			{
				item.Clear();
			}
		}

		#endregion
	}
}
