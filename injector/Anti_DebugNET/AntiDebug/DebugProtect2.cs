using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Anti_DebugNET.Utils;
using Anti_DebugNET.Utils.WinStructs;

namespace Anti_DebugNET.AntiDebug
{
	// Token: 0x02000015 RID: 21
	internal class DebugProtect2
	{
		// Token: 0x06000093 RID: 147
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQueryInformationProcess([In] IntPtr ProcessHandle, [In] PROCESSINFOCLASS ProcessInformationClass, out IntPtr ProcessInformation, [In] int ProcessInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000094 RID: 148
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtClose([In] IntPtr Handle);

		// Token: 0x06000095 RID: 149
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtRemoveProcessDebug(IntPtr ProcessHandle, IntPtr DebugObjectHandle);

		// Token: 0x06000096 RID: 150
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtSetInformationDebugObject([In] IntPtr DebugObjectHandle, [In] DebugObjectInformationClass DebugObjectInformationClass, [In] IntPtr DebugObjectInformation, [In] int DebugObjectInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000097 RID: 151
		[DllImport("ntdll.dll", ExactSpelling = true, SetLastError = true)]
		internal static extern NtStatus NtQuerySystemInformation([In] SYSTEM_INFORMATION_CLASS SystemInformationClass, IntPtr SystemInformation, [In] int SystemInformationLength, [Optional] out int ReturnLength);

		// Token: 0x06000098 RID: 152 RVA: 0x00009CAC File Offset: 0x00007EAC
		public static int PerformChecks()
		{
			bool flag = DebugProtect2.CheckDebugPort() == 1;
			int result;
			if (flag)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("CheckDebugPort: HIT");
				result = 1;
			}
			else
			{
				bool flag2 = DebugProtect2.CheckKernelDebugInformation();
				if (flag2)
				{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("CheckKernelDebugInformation: HIT");
					result = 1;
				}
				else
				{
					bool flag3 = DebugProtect2.DetachFromDebuggerProcess();
					if (flag3)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.WriteLine("DetachFromDebuggerProcess: HIT");
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

		// Token: 0x06000099 RID: 153 RVA: 0x00009D28 File Offset: 0x00007F28
		private static int CheckDebugPort()
		{
			IntPtr intPtr = new IntPtr(0);
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugPort, out intPtr, Marshal.SizeOf<IntPtr>(intPtr), out num);
			bool flag = ntStatus == NtStatus.Success;
			if (flag)
			{
				bool flag2 = intPtr == new IntPtr(-1);
				if (flag2)
				{
					Console.WriteLine("DebugPort : {0:X}", intPtr);
					return 1;
				}
			}
			return 0;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00009D98 File Offset: 0x00007F98
		private unsafe static bool DetachFromDebuggerProcess()
		{
			IntPtr invalid_HANDLE_VALUE = DebugProtect2.INVALID_HANDLE_VALUE;
			uint structure = 0U;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQueryInformationProcess(Process.GetCurrentProcess().Handle, PROCESSINFOCLASS.ProcessDebugObjectHandle, out invalid_HANDLE_VALUE, IntPtr.Size, out num);
			bool flag = ntStatus > NtStatus.Success;
			bool result;
			if (flag)
			{
				result = false;
			}
			else
			{
				int num2;
				ntStatus = DebugProtect2.NtSetInformationDebugObject(invalid_HANDLE_VALUE, DebugObjectInformationClass.DebugObjectFlags, new IntPtr((void*)(&structure)), Marshal.SizeOf<uint>(structure), out num2);
				bool flag2 = ntStatus > NtStatus.Success;
				if (flag2)
				{
					result = false;
				}
				else
				{
					ntStatus = DebugProtect2.NtRemoveProcessDebug(Process.GetCurrentProcess().Handle, invalid_HANDLE_VALUE);
					bool flag3 = ntStatus > NtStatus.Success;
					if (flag3)
					{
						result = false;
					}
					else
					{
						ntStatus = DebugProtect2.NtClose(invalid_HANDLE_VALUE);
						bool flag4 = ntStatus > NtStatus.Success;
						result = !flag4;
					}
				}
			}
			return result;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009E44 File Offset: 0x00008044
		private unsafe static bool CheckKernelDebugInformation()
		{
			SYSTEM_KERNEL_DEBUGGER_INFORMATION system_KERNEL_DEBUGGER_INFORMATION;
			int num;
			NtStatus ntStatus = DebugProtect2.NtQuerySystemInformation(SYSTEM_INFORMATION_CLASS.SystemKernelDebuggerInformation, new IntPtr((void*)(&system_KERNEL_DEBUGGER_INFORMATION)), Marshal.SizeOf<SYSTEM_KERNEL_DEBUGGER_INFORMATION>(system_KERNEL_DEBUGGER_INFORMATION), out num);
			bool flag = ntStatus == NtStatus.Success;
			if (flag)
			{
				bool flag2 = system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerEnabled && !system_KERNEL_DEBUGGER_INFORMATION.KernelDebuggerNotPresent;
				if (flag2)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x040002E4 RID: 740
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1);
	}
}
