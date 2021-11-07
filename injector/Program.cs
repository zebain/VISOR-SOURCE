using System;
using System.Windows.Forms;
using KeyAuth;

namespace injector
{
	// Token: 0x02000009 RID: 9
	internal static class Program
	{
		// Token: 0x06000064 RID: 100 RVA: 0x0000947D File Offset: 0x0000767D
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login());
		}

		// Token: 0x0400007B RID: 123
		public static string GameFolder;
	}
}
