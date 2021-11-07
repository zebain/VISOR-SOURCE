using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using injector.Properties;
using Siticone.UI.WinForms;

namespace injector
{
	// Token: 0x02000008 RID: 8
	public partial class Help : Form
	{
		// Token: 0x0600005E RID: 94 RVA: 0x00008490 File Offset: 0x00006690
		public Help()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000084A8 File Offset: 0x000066A8
		private void Help_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000084AB File Offset: 0x000066AB
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000084AE File Offset: 0x000066AE
		private void button3_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
