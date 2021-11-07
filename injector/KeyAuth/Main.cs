using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace KeyAuth
{
	// Token: 0x02000006 RID: 6
	public partial class Main : Form
	{
		// Token: 0x0600002D RID: 45 RVA: 0x000050AB File Offset: 0x000032AB
		public Main()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000050C3 File Offset: 0x000032C3
		private void siticoneControlBox1_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000050D0 File Offset: 0x000032D0
		private void Main_Load(object sender, EventArgs e)
		{
			this.key.Text = "Username: " + Login.KeyAuthApp.user_data.username;
			this.expiry.Text = "Expiry: " + this.UnixTimeToDateTime(long.Parse(Login.KeyAuthApp.user_data.subscriptions[0].expiry)).ToString();
			this.subscription.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005178 File Offset: 0x00003378
		public DateTime UnixTimeToDateTime(long unixtime)
		{
			DateTime result = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local);
			result = result.AddSeconds((double)unixtime).ToLocalTime();
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000051B0 File Offset: 0x000033B0
		private void subscription_Click(object sender, EventArgs e)
		{
		}
	}
}
