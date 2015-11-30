using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOrganizer
{
	class Utils
	{
		/// <summary>
		/// Deletes directory with all contained subdirectories and files.
		/// </summary>
		/// <param name="directory">Directory path to delete.</param>
		public static void DeleteDirectory(string directory)
		{
			string[] files = Directory.GetFiles(directory);
			string[] dirs = Directory.GetDirectories(directory);

			foreach (string file in files)
			{
				File.SetAttributes(file, FileAttributes.Normal);
				File.Delete(file);
			}

			foreach (string dir in dirs)
			{
				DeleteDirectory(dir);
			}

			Directory.Delete(directory, false);
		}
	}
}
