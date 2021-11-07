using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injector;
using injector.Properties;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000005 RID: 5
	public partial class Login : Form
	{
		// Token: 0x0600001A RID: 26 RVA: 0x00003342 File Offset: 0x00001542
		public Login()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000335A File Offset: 0x0000155A
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003364 File Offset: 0x00001564
		private void Login_Load(object sender, EventArgs e)
		{
			Login.KeyAuthApp.init();
			this.Text = Settings.Default.Login;
			this.username.Text = Settings.Default.Login;
			this.Text = Settings.Default.Password;
			this.password.Text = Settings.Default.Password;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000033CB File Offset: 0x000015CB
		private void UpgradeBtn_Click(object sender, EventArgs e)
		{
			Login.KeyAuthApp.upgrade(this.username.Text, this.key.Text);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000033F0 File Offset: 0x000015F0
		private void LoginBtn_Click(object sender, EventArgs e)
		{
			bool flag = Login.KeyAuthApp.login(this.username.Text, this.password.Text);
			if (flag)
			{
				Visor visor = new Visor();
				visor.Show();
				base.Hide();
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003438 File Offset: 0x00001638
		private void RgstrBtn_Click(object sender, EventArgs e)
		{
			bool flag = Login.KeyAuthApp.register(this.username.Text, this.password.Text, this.key.Text);
			if (flag)
			{
				Main main = new Main();
				main.Show();
				base.Hide();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000348C File Offset: 0x0000168C
		private void LicBtn_Click(object sender, EventArgs e)
		{
			bool flag = Login.KeyAuthApp.license(this.key.Text);
			if (flag)
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000034B5 File Offset: 0x000016B5
		private void key_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000034B8 File Offset: 0x000016B8
		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Login = this.username.Text;
			Settings.Default.Save();
			Settings.Default.Password = this.password.Text;
			Settings.Default.Save();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003508 File Offset: 0x00001708
		private void username_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000350C File Offset: 0x0000170C
		private void FORBADPEOPLE_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "dnSpy";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000355C File Offset: 0x0000175C
		private void FORLOWKEYCHAMS_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "x96dbg";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000035AC File Offset: 0x000017AC
		private void LOWKEYPRITTYASSNGL_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "x32dbg";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000035FC File Offset: 0x000017FC
		private void LowkeyKindaDog_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "x64dbg";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000364C File Offset: 0x0000184C
		private void QWQW_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "ILSpy";
				bool flag2 = flag;
				if (flag2)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000369C File Offset: 0x0000189C
		private void bum_Tick(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "strings";
				bool flag2 = process.ProcessName == "strings64";
				bool flag3 = process.ProcessName == "strings64a";
				bool flag4 = process.ProcessName == "st";
				bool flag5 = flag && flag2 && flag3 && flag4;
				if (flag5)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x0400000D RID: 13
		private static string name = "Escape From Tarkov Visor";

		// Token: 0x0400000E RID: 14
		private static string ownerid = "b906P9YgBQ";

		// Token: 0x0400000F RID: 15
		private static string secret = "d590d69b5fc1001e9e662739a5230858e69bfa80b5b683364c73875e4e060d8a";

		// Token: 0x04000010 RID: 16
		private static string version = "3.0";

		// Token: 0x04000011 RID: 17
		public static api KeyAuthApp = new api(Login.name, Login.ownerid, Login.secret, Login.version);
	}
}
