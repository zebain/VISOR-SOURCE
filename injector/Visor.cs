using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Management;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injector.Properties;
using KeyAuth;
using Siticone.UI.WinForms;

namespace injector
{
	// Token: 0x02000007 RID: 7
	public partial class Visor : Form
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00005AC4 File Offset: 0x00003CC4
		public Visor()
		{
			this.InitializeComponent();
			WebClient webClient = new WebClient();
			bool flag = !webClient.DownloadString("https://pastebin.com/raw/RpAr4zBy").Contains("40.0");
			if (flag)
			{
				bool flag2 = MessageBox.Show("Visor Has An Update Or Updating look for Announcments in Discord", "Visor", MessageBoxButtons.OK, MessageBoxIcon.Question) == DialogResult.OK;
				if (flag2)
				{
					using (new WebClient())
					{
						Process.Start("https://disk.yandex.ru/d/-KegJ9bZrHa_ow");
						Application.Exit();
					}
				}
			}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005B5C File Offset: 0x00003D5C
		private void button1_Click(object sender, EventArgs e)
		{
			int millisecondsTimeout = (int)this.numericUpDown1.Value;
			Thread.Sleep(millisecondsTimeout);
			Console.Beep();
			string path = Path.Combine(this.textBox1.Text, "shaders");
			bool @checked = this.radioButton1.Checked;
			if (@checked)
			{
				File.WriteAllBytes(path, Resources.XRAY232R32R23R32FFF2F);
				this.Status.Text = "Status: Injected X-RAY";
			}
			bool checked2 = this.radioButton2.Checked;
			if (checked2)
			{
				File.WriteAllBytes(path, Resources.BAPEF87HFEW78F87FHWF8W);
				this.Status.Text = "Status: Injected Blue/Pink";
			}
			bool checked3 = this.radioButton3.Checked;
			if (checked3)
			{
				File.WriteAllBytes(path, Resources.TRGHEUFHFIUWFUWIFHWUFHIU);
				this.Status.Text = "Status: Injected Testing";
			}
			bool checked4 = this.radioButton4.Checked;
			if (checked4)
			{
				File.WriteAllBytes(path, Resources.RAG439343348U9JOIJIOJ30J0);
				this.Status.Text = "Status: Injected Red/Green";
			}
			bool checked5 = this.radioButton5.Checked;
			if (checked5)
			{
				File.WriteAllBytes(path, Resources.GGRUGRGRUDGIRDGRDGRG78R8G7);
				this.Status.Text = "Status: Inject Red/X-RAY";
			}
			bool checked6 = this.radioButton6.Checked;
			if (checked6)
			{
				File.WriteAllBytes(path, Resources.GREENANDPURPLE);
				this.Status.Text = "Status: Inject Green/Purple";
			}
			Thread.Sleep(100);
			this.button1.Enabled = false;
			Thread.Sleep(1000);
			DialogResult dialogResult = MessageBox.Show("Press OK When Fully Loaded Into The Game.\n\nIf Click Cancel It Will Auto Clear Your Logs But Will Have To Check Integrity Again (Only do this if injection faild)", this.label3.Text, MessageBoxButtons.OKCancel);
			bool flag = dialogResult == DialogResult.OK;
			bool flag2 = flag;
			if (flag2)
			{
				string text = "bin/shaders";
				string str = this.textBox1.Text + "/";
				File.Delete(this.textBox1.Text + "/shaders");
				File.Copy(text, str + Path.GetFileName(text));
				Thread.Sleep(200);
				Application.Exit();
			}
			bool flag3 = dialogResult == DialogResult.Cancel;
			bool flag4 = flag3;
			if (flag4)
			{
				this.Status.Text = "Status: Injection Faild";
				string text2 = this.textBox2.Text;
				string tempPath = Path.GetTempPath();
				DirectoryInfo directoryInfo = new DirectoryInfo(text2);
				IEnumerable<FileInfo> enumerable = directoryInfo.EnumerateFiles();
				IEnumerable<DirectoryInfo> enumerable2 = directoryInfo.EnumerateDirectories();
				foreach (FileInfo fileInfo in enumerable)
				{
					fileInfo.Delete();
				}
				foreach (DirectoryInfo directoryInfo2 in enumerable2)
				{
					directoryInfo2.Delete(true);
				}
				string text3 = "bin/shaders";
				string str2 = this.textBox1.Text + "/";
				File.Delete(this.textBox1.Text + "/shaders");
				File.Copy(text3, str2 + Path.GetFileName(text3));
				this.button1.Enabled = true;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00005EA8 File Offset: 0x000040A8
		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005EAB File Offset: 0x000040AB
		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005EAE File Offset: 0x000040AE
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005EB1 File Offset: 0x000040B1
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005EB4 File Offset: 0x000040B4
		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005EB8 File Offset: 0x000040B8
		private string identifier(string wmiClass, string wmiProperty)
		{
			string text = "";
			ManagementClass managementClass = new ManagementClass(wmiClass);
			ManagementObjectCollection instances = managementClass.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in instances)
			{
				ManagementObject managementObject = (ManagementObject)managementBaseObject;
				bool flag = text == "";
				if (flag)
				{
					try
					{
						text = managementObject[wmiProperty].ToString();
						break;
					}
					catch
					{
					}
				}
			}
			return text;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005F54 File Offset: 0x00004154
		private void Form1_Load(object sender, EventArgs e)
		{
			string text = this.identifier("Win32_DiskDrive", "Model");
			string text2 = this.identifier("Win32_DiskDrive", "Manufacturer");
			string text3 = this.identifier("Win32_DiskDrive", "Signature");
			string text4 = this.identifier("Win32_DiskDrive", "TotalHeads");
			this.key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
			this.expiry.Text = "Expiry: " + this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString();
			this.subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
			Thread.Sleep(2000);
			this.Text = Settings.Default.Directory;
			this.textBox1.Text = Settings.Default.Directory;
			this.Text = Settings.Default.Clearlog;
			this.textBox2.Text = Settings.Default.Clearlog;
			this.Text = Settings.Default.NorecoilDirectory;
			this.Norecoil.Text = Settings.Default.NorecoilDirectory;
			bool flag = this.textBox1.Text.Contains("E");
			if (flag)
			{
				this.label2.Visible = true;
				this.button5.Enabled = true;
				this.button7.Enabled = true;
				this.radioButton1.Enabled = true;
				this.radioButton3.Enabled = true;
				this.radioButton2.Enabled = true;
				this.radioButton4.Enabled = true;
				this.radioButton5.Enabled = true;
				this.radioButton6.Enabled = true;
			}
			else
			{
				this.label2.Visible = false;
				this.button5.Enabled = false;
				this.radioButton1.Enabled = false;
				this.radioButton3.Enabled = false;
				this.radioButton2.Enabled = false;
				this.radioButton4.Enabled = false;
				this.radioButton5.Enabled = false;
				this.button7.Enabled = false;
				this.radioButton6.Enabled = false;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000061CC File Offset: 0x000043CC
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00006204 File Offset: 0x00004404
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			Settings.Default.Directory = this.textBox1.Text;
			Settings.Default.Clearlog = this.textBox2.Text;
			Settings.Default.NorecoilDirectory = this.Norecoil.Text;
			Settings.Default.Save();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00006264 File Offset: 0x00004464
		private void button2_Click(object sender, EventArgs e)
		{
			this.folderBrowserDialog1.ShowDialog();
			Program.GameFolder = this.folderBrowserDialog1.SelectedPath;
			this.textBox1.Text = this.folderBrowserDialog1.SelectedPath + "/EscapeFromTarkov_Data/StreamingAssets/Windows";
			this.textBox2.Text = this.folderBrowserDialog1.SelectedPath + "/Logs/";
			this.Norecoil.Text = this.folderBrowserDialog1.SelectedPath + "/EscapeFromTarkov_Data/StreamingAssets/Windows/assets/content/commonprefabs";
			bool flag = !File.Exists(Program.GameFolder + "\\EscapeFromTarkov.exe");
			if (flag)
			{
				MessageBox.Show("Cannot find Escapefromtarkov.exe", "File Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				this.label2.Visible = true;
				this.button5.Enabled = true;
				this.button7.Enabled = true;
				this.radioButton1.Enabled = true;
				this.radioButton3.Enabled = true;
				this.radioButton2.Enabled = true;
				this.radioButton4.Enabled = true;
				this.radioButton5.Enabled = true;
				this.radioButton6.Enabled = true;
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000639A File Offset: 0x0000459A
		private void textBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000639D File Offset: 0x0000459D
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000063A0 File Offset: 0x000045A0
		private void textBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000063A3 File Offset: 0x000045A3
		private void button3_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000063AC File Offset: 0x000045AC
		private void button4_Click(object sender, EventArgs e)
		{
			Help help = new Help();
			help.Show();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000063C8 File Offset: 0x000045C8
		private void button5_Click(object sender, EventArgs e)
		{
			string text = this.textBox2.Text;
			string tempPath = Path.GetTempPath();
			DirectoryInfo directoryInfo = new DirectoryInfo(text);
			IEnumerable<FileInfo> enumerable = directoryInfo.EnumerateFiles();
			IEnumerable<DirectoryInfo> enumerable2 = directoryInfo.EnumerateDirectories();
			foreach (FileInfo fileInfo in enumerable)
			{
				fileInfo.Delete();
			}
			foreach (DirectoryInfo directoryInfo2 in enumerable2)
			{
				directoryInfo2.Delete(true);
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006488 File Offset: 0x00004688
		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			this.label3.Text = "Visor Version: Pink/Blue";
			this.button1.Enabled = true;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000064A9 File Offset: 0x000046A9
		private void groupBox5_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x000064AC File Offset: 0x000046AC
		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.label3.Text = "Visor Version: X-RAY";
			this.button1.Enabled = true;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000064CD File Offset: 0x000046CD
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000064D0 File Offset: 0x000046D0
		private void expiry_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000064D3 File Offset: 0x000046D3
		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			this.button1.Enabled = true;
			this.label3.Text = "Visor Version: Testing";
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000064F4 File Offset: 0x000046F4
		private void radioButton4_CheckedChanged(object sender, EventArgs e)
		{
			this.label3.Text = "Visor Version: Red/Green";
			this.button1.Enabled = true;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00006515 File Offset: 0x00004715
		private void label1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006518 File Offset: 0x00004718
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000651B File Offset: 0x0000471B
		private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006520 File Offset: 0x00004720
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				bool flag = process.ProcessName == "x64dbg";
				bool flag2 = process.ProcessName == "x32dbg";
				bool flag3 = flag && flag2;
				if (flag3)
				{
					process.Kill();
				}
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00006583 File Offset: 0x00004783
		private void bunifuSwitch1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006586 File Offset: 0x00004786
		private void checkBox1_CheckedChanged_2(object sender, EventArgs e)
		{
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00006589 File Offset: 0x00004789
		private void radioButton5_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000658C File Offset: 0x0000478C
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000658F File Offset: 0x0000478F
		private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
		{
			this.label3.Text = "Visor Version: Red/X-RAY";
			this.button1.Enabled = true;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x000065B0 File Offset: 0x000047B0
		private void button6_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000065B3 File Offset: 0x000047B3
		private void button6_Click_1(object sender, EventArgs e)
		{
			MessageBox.Show("This Project was created By: Shturman#8821 and only me\n Send me ur Discord user and a suprise awaits", "You have Found the Hidden Message Visor Volt");
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000065C6 File Offset: 0x000047C6
		private void textBox2_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000065CC File Offset: 0x000047CC
		private void button7_Click(object sender, EventArgs e)
		{
			string path = Path.Combine(this.Norecoil.Text, "playersuperior.bundle");
			File.WriteAllBytes(path, Resources.playersuperior);
			DialogResult dialogResult = MessageBox.Show("If you just want norecoil just close the injecter and have fun\n if your injecting chams inject NoRecoil first then inject the chams", "INFO", MessageBoxButtons.OK);
			bool flag = dialogResult == DialogResult.OK;
			bool flag2 = flag;
			if (flag2)
			{
				Thread.Sleep(1000);
				this.button7.Text = "Ready";
				this.button7.Enabled = false;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006646 File Offset: 0x00004846
		private void radioButton6_CheckedChanged(object sender, EventArgs e)
		{
			this.label3.Text = "Visor Version: Green/Purple";
			this.button1.Enabled = true;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006667 File Offset: 0x00004867
		private void DiskInfo_TextChanged(object sender, EventArgs e)
		{
		}
	}
}
