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
		public MainForm()
		{
			InitializeComponent();


			//Process proc = new Process();
			//proc.StartInfo.FileName = @"C:\Users\martynasv\AppData\Local\Android\sdk\platform-tools\adb.exe";
			//proc.StartInfo.Arguments = "devices";
			//proc.StartInfo.CreateNoWindow = true;
			//proc.StartInfo.RedirectStandardOutput = true;
			//proc.StartInfo.UseShellExecute = false;
			//proc.Start();

			//while (!proc.StandardOutput.EndOfStream)
			//{
			//	string line = proc.StandardOutput.ReadLine();
			//	// do something with line
			//	Console.WriteLine(line);
			//}



			//FileSystemWatcher watcher = new FileSystemWatcher(@"XT1032\Internal storage\DCIM\Camera");
			//watcher.Created += watcher_Created;

		}

		//static void watcher_Created(object sender, FileSystemEventArgs e)
		//{
		//	Console.WriteLine(e.FullPath);
		//}

		private void BtnClick_SaveImages(object sender, EventArgs e)
		{

		}

		private void BtnClick_ClearImages(object sender, EventArgs e)
		{
			imageBlockControl1.Clear();
		}
	}
}
