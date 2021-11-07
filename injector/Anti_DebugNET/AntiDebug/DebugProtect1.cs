using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000014 RID: 20
	internal class DebugProtect1
	{
		// Token: 0x0600008C RID: 140
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, [MarshalAs(UnmanagedType.Bool)] ref bool isDebuggerPresent);

		// Token: 0x0600008D RID: 141
		[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool IsDebuggerPresent();

		// Token: 0x0600008E RID: 142 RVA: 0x00009BA8 File Offset: 0x00007DA8
		public static int PerformChecks()
		{
			bool flag = DebugProtect1.CheckDebuggerManagedPresent() == 1;
			int result;
			if (flag)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebuggerManagedPresent: HIT");
				result = 1;
			}
			else
			{
				bool flag2 = DebugProtect1.CheckDebuggerUnmanagedPresent() == 1;
				if (flag2)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("CheckDebuggerUnmanagedPresent: HIT");
					result = 1;
				}
				else
				{
					bool flag3 = DebugProtect1.CheckRemoteDebugger() == 1;
					if (flag3)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("CheckRemoteDebugger: HIT");
						result = 1;
					}
					else
					{
						result = 0;
					}
				}
			}
			return result;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009C28 File Offset: 0x00007E28
		private static int CheckDebuggerManagedPresent()
		{
			bool isAttached = Debugger.IsAttached;
			int result;
			if (isAttached)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009C4C File Offset: 0x00007E4C
		private static int CheckDebuggerUnmanagedPresent()
		{
			bool flag = DebugProtect1.IsDebuggerPresent();
			int result;
			if (flag)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009C70 File Offset: 0x00007E70
		private static int CheckRemoteDebugger()
		{
			bool flag = false;
			bool flag2 = DebugProtect1.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref flag);
			bool flag3 = flag2 && flag;
			int result;
			if (flag3)
			{
				result = 1;
			}
			else
			{
				result = 0;
			}
			return result;
		}
	}
}
