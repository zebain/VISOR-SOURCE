using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000016 RID: 22
	internal class DebugProtect3
	{
		// Token: 0x0600009E RID: 158
		[DllImport("ntdll.dll")]
		internal static extern NtStatus NtSetInformationThread(IntPtr ThreadHandle, ThreadInformationClass ThreadInformationClass, IntPtr ThreadInformation, int ThreadInformationLength);

		// Token: 0x0600009F RID: 159
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x060000A0 RID: 160
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x060000A1 RID: 161
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x060000A2 RID: 162
		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		private static extern bool CloseHandle(IntPtr handle);

		// Token: 0x060000A3 RID: 163 RVA: 0x00009EB4 File Offset: 0x000080B4
		public static void HideOSThreads()
		{
			ProcessThreadCollection threads = Process.GetCurrentProcess().Threads;
			foreach (object obj in threads)
			{
				ProcessThread processThread = (ProcessThread)obj;
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("[GetOSThreads]: thread.Id {0:X}", processThread.Id);
				IntPtr intPtr = DebugProtect3.OpenThread(ThreadAccess.SET_INFORMATION, false, (uint)processThread.Id);
				bool flag = intPtr == IntPtr.Zero;
				if (flag)
				{
					Console.ForegroundColor = ConsoleColor.Yellow;
					Console.WriteLine("[GetOSThreads]: skipped thread.Id {0:X}", processThread.Id);
				}
				else
				{
					bool flag2 = DebugProtect3.HideFromDebugger(intPtr);
					if (flag2)
					{
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine("[GetOSThreads]: thread.Id {0:X} hidden from debbuger.", processThread.Id);
					}
					DebugProtect3.CloseHandle(intPtr);
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009FAC File Offset: 0x000081AC
		public static bool HideFromDebugger(IntPtr Handle)
		{
			NtStatus ntStatus = DebugProtect3.NtSetInformationThread(Handle, ThreadInformationClass.ThreadHideFromDebugger, IntPtr.Zero, 0);
			return ntStatus == NtStatus.Success;
		}
	}
}
