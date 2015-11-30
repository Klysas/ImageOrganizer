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
		//========================================================
		//	Private variables
		//========================================================

		private ImagePairControl[] _list;

		//========================================================
		//	Constructors
		//========================================================

		public ImageBlockControl()
		{
			InitializeComponent();

			_list = new ImagePairControl[10];
			for (int i = 0; i < 10; i++)
			{
				var control = new ImagePairControl();

				control.Index = i + 1;
				control.Location = new Point(0, 0 + (i*control.Height));

				this.Controls.Add(control);
				_list[i] = control;
			}
		}

		//========================================================
		//	Public properties
		//========================================================

		public ImagePairControl[] ImagePairControls
		{
			get
			{
				return _list;
			}
		}

		//========================================================
		//	Public methods
		//========================================================

		public void Clear()
		{
			foreach (var item in _list)
			{
				item.Clear();
			}
		}

		/// <summary>
		/// Gives ImagePairControl by its index.
		/// </summary>
		/// <param name="index">Values 1..10</param>
		/// <returns></returns>
		public ImagePairControl getImagePairControl(int index)
		{
			if (index < 1 || index > 10)
			{
				throw new ArgumentOutOfRangeException("Index interval should be [1,10]. Value: " + index);
			}
			ImagePairControl control = _list[index - 1];

			if(control.Index != index)
			{
				foreach (var item in _list)
				{
					if (item.Index == index)
					{
						control = item;
						break;
					}
				}
			}
			return control;
		}
	}
}
