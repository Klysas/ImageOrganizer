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
	public partial class ImagePairControl : UserControl
	{


		private int _index;



		public int Index
		{
			get
			{
				return _index;
			}
			set
			{
				_index = value;
				GrpBox_Main.Text = string.Format("Index: {0}", _index);
			}
		}

		public ImageControl Left
		{
			get
			{
				return ImageControl_Left;
			}
		}

		public ImageControl Right
		{
			get
			{
				return ImageControl_Right;
			}
		}


		public ImagePairControl()
		{
			InitializeComponent();
		}




		public void Clear()
		{
			ImageControl_Left.Clear();
			ImageControl_Right.Clear();
		}

	}
}
