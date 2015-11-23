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
		ImagePairControl[] _list = new ImagePairControl[10];

		public ImageBlockControl()
		{
			InitializeComponent();

			for (int i = 0; i < 10; i++)
			{
				var item = new ImagePairControl();
				this.Controls.Add(item);
				item.Index = i + 1;
				item.Location = new Point(0, 0 + (i*item.Height));
				_list[i] = item;
			}
		}

		public ImagePairControl[] ImagePairControls
		{
			get
			{
				return _list;
			}
		}

		public void Clear()
		{
			foreach (var item in _list)
			{
				item.Clear();
			}
		}
	}
}
