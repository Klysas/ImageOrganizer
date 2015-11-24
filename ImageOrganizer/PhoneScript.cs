using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageOrganizer
{
	class PhoneScript
	{
		#region Private static variables

		private static Process _downloadPicturesProc;

		private static Process _deletePicturesProc;

		private static string _targetDirectoryOnPC = string.Empty;

		private static string _targetDirectoryOnPhone = string.Empty;

		#endregion

		#region Public static properties

		/// <summary>
		/// [GET/SET] Directory on pc.
		/// </summary>
		public static string TargetDirectoryOnPC
		{
			get
			{
				return _targetDirectoryOnPC;
			}
			set
			{
				if (value != string.Empty)
				{
					_targetDirectoryOnPC = value.Trim();
					if (_downloadPicturesProc != null)
					{
						UpdateDownloadPicturesProcessInfo(_downloadPicturesProc.StartInfo);
					}
				}
			}
		}

		/// <summary>
		/// [GET/SET] Directory on android device.
		/// </summary>
		public static string TargetDirectoryOnPhone
		{
			get
			{
				return _targetDirectoryOnPhone;
			}
			set
			{
				if (value != string.Empty)
				{
					_targetDirectoryOnPhone = value.Trim();
					if (_deletePicturesProc != null)
					{
						UpdateDownloadPicturesProcessInfo(_deletePicturesProc.StartInfo);
					}
					if (_downloadPicturesProc != null)
					{
						UpdateDownloadPicturesProcessInfo(_downloadPicturesProc.StartInfo);
					}
				}
			}
		}

		#endregion

		#region Private static methods

		private static void CreateDownloadPicturesProcess()
		{
			if (_downloadPicturesProc == null && _targetDirectoryOnPhone != string.Empty && _targetDirectoryOnPC != string.Empty)
			{
				ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
				UpdateDownloadPicturesProcessInfo(processInfo);
				processInfo.CreateNoWindow = true;
				processInfo.UseShellExecute = false;
				_downloadPicturesProc = new Process();
				_downloadPicturesProc.StartInfo = processInfo;
			}
		}

		private static void CreateDeletePicturesProcess()
		{
			if (_deletePicturesProc == null && _targetDirectoryOnPhone != string.Empty)
			{
				ProcessStartInfo processInfo = new ProcessStartInfo("cmd.exe");
				UpdateDeletePicturesProcessInfo(processInfo);
				processInfo.CreateNoWindow = true;
				processInfo.UseShellExecute = false;
				_deletePicturesProc = new Process();
				_deletePicturesProc.StartInfo = processInfo;
			}
		}

		private static void UpdateDownloadPicturesProcessInfo(ProcessStartInfo info)
		{
			info.Arguments = string.Format("/C adb pull {0} {1}", _targetDirectoryOnPhone, _targetDirectoryOnPC);
		}

		private static void UpdateDeletePicturesProcessInfo(ProcessStartInfo info)
		{
			info.Arguments = string.Format("/C adb shell \"rm -r {0}\"", _targetDirectoryOnPhone);
		}

		#endregion

		/// <summary>
		/// Deletes TargetDirectoryOnPhone and all its' content.
		/// </summary>
		public static void DeleteDirectoryOnPhone()
		{
			CreateDeletePicturesProcess();
			if (_deletePicturesProc != null)
			{
				_deletePicturesProc.Start();
				_deletePicturesProc.WaitForExit();
			}
		}

		/// <summary>
		/// Downloads all files from TargetDirectoryOnPhone to TargetDirectoryOnPC.
		/// </summary>
		public static void DownloadFilesFromPhone()
		{
			CreateDownloadPicturesProcess();
			if (_downloadPicturesProc != null)
			{
				_downloadPicturesProc.Start();
				_downloadPicturesProc.WaitForExit();
			}
		}

		private static void Execute()
		{
			//int exitCode;
			//ProcessStartInfo processInfo;
			//Process process;

			//processInfo = new ProcessStartInfo(@"c:\Users\martynasv\Desktop\CopyAndRemoveFromPhone.bat");
			//processInfo.CreateNoWindow = true;
			//processInfo.UseShellExecute = false;
			//// *** Redirect the output ***
			////processInfo.RedirectStandardError = true;
			////processInfo.RedirectStandardOutput = true;

			//process = Process.Start(processInfo);
			//process.WaitForExit();

			//// *** Read the streams ***
			//// Warning: This approach can lead to deadlocks, see Edit #2
			////string output = process.StandardOutput.ReadToEnd();
			////string error = process.StandardError.ReadToEnd();

			//exitCode = process.ExitCode;

			////Console.WriteLine("output>>" + (String.IsNullOrEmpty(output) ? "(none)" : output));
			////Console.WriteLine("error>>" + (String.IsNullOrEmpty(error) ? "(none)" : error));
			////Console.WriteLine("ExitCode: " + exitCode.ToString(), "ExecuteCommand");

			//process.Close();
		}
	}
}
