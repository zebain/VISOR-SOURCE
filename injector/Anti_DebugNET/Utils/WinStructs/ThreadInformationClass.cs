using System;

namespace Anti_DebugNET.Utils.WinStructs
{
	// Token: 0x02000010 RID: 16
	public enum ThreadInformationClass
	{
		// Token: 0x040002AD RID: 685
		ThreadBasicInformation,
		// Token: 0x040002AE RID: 686
		ThreadTimes,
		// Token: 0x040002AF RID: 687
		ThreadPriority,
		// Token: 0x040002B0 RID: 688
		ThreadBasePriority,
		// Token: 0x040002B1 RID: 689
		ThreadAffinityMask,
		// Token: 0x040002B2 RID: 690
		ThreadImpersonationToken,
		// Token: 0x040002B3 RID: 691
		ThreadDescriptorTableEntry,
		// Token: 0x040002B4 RID: 692
		ThreadEnableAlignmentFaultFixup,
		// Token: 0x040002B5 RID: 693
		ThreadEventPair_Reusable,
		// Token: 0x040002B6 RID: 694
		ThreadQuerySetWin32StartAddress,
		// Token: 0x040002B7 RID: 695
		ThreadZeroTlsCell,
		// Token: 0x040002B8 RID: 696
		ThreadPerformanceCount,
		// Token: 0x040002B9 RID: 697
		ThreadAmILastThread,
		// Token: 0x040002BA RID: 698
		ThreadIdealProcessor,
		// Token: 0x040002BB RID: 699
		ThreadPriorityBoost,
		// Token: 0x040002BC RID: 700
		ThreadSetTlsArrayAddress,
		// Token: 0x040002BD RID: 701
		ThreadIsIoPending,
		// Token: 0x040002BE RID: 702
		ThreadHideFromDebugger,
		// Token: 0x040002BF RID: 703
		ThreadBreakOnTermination,
		// Token: 0x040002C0 RID: 704
		ThreadSwitchLegacyState,
		// Token: 0x040002C1 RID: 705
		ThreadIsTerminated,
		// Token: 0x040002C2 RID: 706
		ThreadLastSystemCall,
		// Token: 0x040002C3 RID: 707
		ThreadIoPriority,
		// Token: 0x040002C4 RID: 708
		ThreadCycleTime,
		// Token: 0x040002C5 RID: 709
		ThreadPagePriority,
		// Token: 0x040002C6 RID: 710
		ThreadActualBasePriority,
		// Token: 0x040002C7 RID: 711
		ThreadTebInformation,
		// Token: 0x040002C8 RID: 712
		ThreadCSwitchMon,
		// Token: 0x040002C9 RID: 713
		ThreadCSwitchPmu,
		// Token: 0x040002CA RID: 714
		ThreadWow64Context,
		// Token: 0x040002CB RID: 715
		ThreadGroupInformation,
		// Token: 0x040002CC RID: 716
		ThreadUmsInformation,
		// Token: 0x040002CD RID: 717
		ThreadCounterProfiling,
		// Token: 0x040002CE RID: 718
		ThreadIdealProcessorEx,
		// Token: 0x040002CF RID: 719
		ThreadCpuAccountingInformation,
		// Token: 0x040002D0 RID: 720
		ThreadSuspendCount,
		// Token: 0x040002D1 RID: 721
		ThreadDescription = 38,
		// Token: 0x040002D2 RID: 722
		ThreadActualGroupAffinity = 41,
		// Token: 0x040002D3 RID: 723
		ThreadDynamicCodePolicy
	}
}
