using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000011 RID: 17
	[Flags]
	public enum ThreadAccess
	{
		// Token: 0x040002D5 RID: 725
		TERMINATE = 1,
		// Token: 0x040002D6 RID: 726
		SUSPEND_RESUME = 2,
		// Token: 0x040002D7 RID: 727
		GET_CONTEXT = 8,
		// Token: 0x040002D8 RID: 728
		SET_CONTEXT = 16,
		// Token: 0x040002D9 RID: 729
		SET_INFORMATION = 32,
		// Token: 0x040002DA RID: 730
		QUERY_INFORMATION = 64,
		// Token: 0x040002DB RID: 731
		SET_THREAD_TOKEN = 128,
		// Token: 0x040002DC RID: 732
		IMPERSONATE = 256,
		// Token: 0x040002DD RID: 733
		DIRECT_IMPERSONATION = 512
	}
}
