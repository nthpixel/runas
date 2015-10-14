using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using System.IO;
using System.Configuration;

namespace RunAs
{
	public partial class RunAs : Form
	{
		public List<App> Apps;
		public List<Credential> Creds;

		public RunAs()
		{
			InitializeComponent();
			Apps = new List<App>();
			Creds = new List<Credential>();

			foreach (var a in ConfigurationSettings.AppSettings["apps"].Split(",".ToCharArray()))
			{
				string[] info = a.Split("|".ToCharArray());
				Apps.Add(new App(){
					Name = info[0],
					Path = info[1].Replace("\r", "").Replace("\n", "").Replace("\t", "")
				});
			}

			ddlApps.DataSource = Apps;
			ddlApps.DisplayMember = "Name";
			ddlApps.ValueMember = "Path";
			

			foreach (var c in ConfigurationSettings.AppSettings["creds"].Split(",".ToCharArray()))
			{
				string[] info = c.Split("|".ToCharArray());
				Creds.Add(new Credential()
				{
					Domain = info[0],
					UserName = info[1],
					Password = info[2].Replace("\r", "").Replace("\n", "").Replace("\t", "")
				});
			}

			ddlCreds.DataSource = Creds;
			ddlCreds.DisplayMember = "FullUserName";
			ddlCreds.ValueMember = "Password";
		}

		private void btRun_Click(object sender, EventArgs e)
		{
			App app = (App)ddlApps.SelectedItem;
			Credential cred = (Credential)ddlCreds.SelectedItem;

			//ProcessImpersonator.ImpersonateProcess_NetCredentials(App, "REDMOND", "apportsa", "Un@v1s1on");
			ProcessImpersonator.ImpersonateProcess_NetCredentials(app.Path, cred.Domain, cred.UserName, cred.Password);

		}

		public class ProcessImpersonator
		{
			[Flags]
			enum LogonFlags
			{
				LOGON_WITH_PROFILE = 0x00000001,
				LOGON_NETCREDENTIALS_ONLY = 0x00000002
			}

			[Flags]
			enum CreationFlags
			{
				CREATE_SUSPENDED = 0x00000004,
				CREATE_NEW_CONSOLE = 0x00000010,
				CREATE_NEW_PROCESS_GROUP = 0x00000200,
				CREATE_UNICODE_ENVIRONMENT = 0x00000400,
				CREATE_SEPARATE_WOW_VDM = 0x00000800,
				CREATE_DEFAULT_ERROR_MODE = 0x04000000,
			}

			[StructLayout(LayoutKind.Sequential)]
			struct ProcessInfo
			{
				public IntPtr hProcess;
				public IntPtr hThread;
				public uint dwProcessId;
				public uint dwThreadId;
			}

			[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
			struct StartupInfo
			{
				public int cb;
				public string reserved1;
				public string desktop;
				public string title;
				public uint dwX;
				public uint dwY;
				public uint dwXSize;
				public uint dwYSize;
				public uint dwXCountChars;
				public uint dwYCountChars;
				public uint dwFillAttribute;
				public uint dwFlags;
				public ushort wShowWindow;
				public short reserved2;
				public int reserved3;
				public IntPtr hStdInput;
				public IntPtr hStdOutput;
				public IntPtr hStdError;
			}

			[DllImport("advapi32.dll", CharSet = CharSet.Unicode, ExactSpelling = true,
			 SetLastError = true)]
			static extern bool CreateProcessWithLogonW(
				string principal,
				string authority,
				string password,
				LogonFlags logonFlags,
				string appName,
				string cmdLine,
				CreationFlags creationFlags,
				IntPtr environmentBlock,
				string currentDirectory,
				ref StartupInfo startupInfo,
				out ProcessInfo processInfo);

			[DllImport("kernel32.dll")]
			static extern bool CloseHandle(IntPtr h);

			///  
			/// This will use the Logon_NetCredentials_only value.  
			/// Usefull for inter-domain scenario without trust relationship  
			/// but the system does not validate the credentials.  
			///  
			public static void ImpersonateProcess_NetCredentials(string appPath, string domain,
				string user, string password)
			{
				ImpersonateProcess(appPath, domain, user, password,
				 LogonFlags.LOGON_NETCREDENTIALS_ONLY);
			}

			///  
			/// This will use the Logon_With_Profile value.  
			/// Useful to get the identity of an user in the same domain.  
			///  
			public static void ImpersonateProcess_WithProfile(string appPath, string domain,
				string user, string password)
			{
				ImpersonateProcess(appPath, domain, user, password, LogonFlags.LOGON_WITH_PROFILE);
			}

			///  
			/// Call CreateProcessWithLogonW  
			///  
			private static void ImpersonateProcess(string appPath, string domain, string user,
				string password, LogonFlags lf)
			{
				StartupInfo si = new StartupInfo();
				si.cb = Marshal.SizeOf(typeof(StartupInfo));
				ProcessInfo pi = new ProcessInfo();

				//  
				if (CreateProcessWithLogonW(user, domain, password,
				lf,
				appPath, null,
				0, IntPtr.Zero, null,
				ref si, out pi))
				{
					CloseHandle(pi.hProcess);
					CloseHandle(pi.hThread);
				}
				else
				{
					throw new System.ComponentModel.Win32Exception(Marshal.GetLastWin32Error());
				}
			}
		}

        private void applicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmApplications apps = new frmApplications();
            apps.ShowDialog();
        }
	}

	public struct App
	{
		public string Name { get; set; }
		public string Path { get; set; }
	}

	public struct Credential
	{
		public string Domain { get; set; }
		public string UserName { get; set; }
		public string Password { get; set; }
		public string FullUserName
		{
			get
			{
				return Domain + @"\" + UserName;
			}
		}
	}
}
