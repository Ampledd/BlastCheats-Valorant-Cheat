using System;
using System.Runtime.InteropServices;

// Token: 0x0200004A RID: 74
internal static class 474A1F71
{
	// Token: 0x060003E4 RID: 996
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFile", SetLastError = true)]
	public static extern IntPtr 64450A1F(string 4AB95C30, int 57293B51, int 26111CDA, IntPtr 5D530F9F, int 370279AE, int 6C1D76AA, IntPtr 3DEA4E24);

	// Token: 0x060003E5 RID: 997
	[DllImport("kernel32", CharSet = CharSet.Auto, EntryPoint = "CreateFileMapping", SetLastError = true)]
	public static extern IntPtr 670522A7(IntPtr 5B7469B8, IntPtr 0BBE30EB, 474A1F71.575758F2 0A982120, int 354D6A23, int 4D7B5C18, string 0BC919CD);

	// Token: 0x060003E6 RID: 998
	[DllImport("kernel32", EntryPoint = "MapViewOfFile", SetLastError = true)]
	public static extern IntPtr 038E4458(IntPtr 496A5AC8, 474A1F71.076D520A 7E832280, int 04EE3EA3, int 49F62C5D, IntPtr 2EF544F6);

	// Token: 0x060003E7 RID: 999
	[DllImport("kernel32", EntryPoint = "UnmapViewOfFile", SetLastError = true)]
	public static extern bool 04A564D2(IntPtr 18075445);

	// Token: 0x060003E8 RID: 1000
	[DllImport("kernel32", EntryPoint = "CloseHandle", SetLastError = true)]
	public static extern bool 3C8F25BB(IntPtr 612D0FC1);

	// Token: 0x060003E9 RID: 1001
	[DllImport("kernel32", EntryPoint = "GetFileSize", SetLastError = true)]
	public static extern uint 4D7F4F0A(IntPtr 758B5B49, IntPtr 61B170C7);

	// Token: 0x060003EA RID: 1002
	[DllImport("kernel32", EntryPoint = "VirtualAlloc", SetLastError = true)]
	public static extern IntPtr 37D96D4B(IntPtr 410A6A61, UIntPtr 27E76AE1, 474A1F71.1DC9365B 76C23E61, 474A1F71.575758F2 28A85D97);

	// Token: 0x060003EB RID: 1003
	[DllImport("kernel32", EntryPoint = "VirtualFree", SetLastError = true)]
	public static extern bool 14C6408E(IntPtr 7DEF502A, uint 2DA20EF1, uint 5B4A4D1D);

	// Token: 0x060003EC RID: 1004
	[DllImport("kernel32", EntryPoint = "VirtualProtect", SetLastError = true)]
	public static extern bool 297F7102(IntPtr 3BFB078B, UIntPtr 6CD073D6, 474A1F71.575758F2 4E3774E8, out 474A1F71.575758F2 12C42916);

	// Token: 0x060003ED RID: 1005
	[DllImport("kernel32", EntryPoint = "IsDebuggerPresent")]
	public static extern bool 58BC2E44();

	// Token: 0x060003EE RID: 1006
	[DllImport("kernel32", EntryPoint = "CheckRemoteDebuggerPresent")]
	public static extern bool 5777162F();

	// Token: 0x060003EF RID: 1007
	[DllImport("kernel32", EntryPoint = "EnumSystemFirmwareTables", SetLastError = true)]
	public static extern uint 440271C7(uint 655C0608, IntPtr 69F75900, uint 3554763D);

	// Token: 0x060003F0 RID: 1008
	[DllImport("kernel32", EntryPoint = "GetSystemFirmwareTable", SetLastError = true)]
	public static extern uint 232E7D81(uint 7B477889, uint 70923A3A, IntPtr 04663B2A, uint 76F9036D);

	// Token: 0x060003F1 RID: 1009
	[DllImport("ntdll", EntryPoint = "NtQueryInformationProcess")]
	public static extern int 06E035ED(IntPtr 3DDD50D7, int 6BF90D8F, IntPtr 42504035, uint 77FB6A79, out uint 7B033108);

	// Token: 0x040002E7 RID: 743
	public const int 38FF4039 = -2147483648;

	// Token: 0x040002E8 RID: 744
	public const int 359D3AEA = 3;

	// Token: 0x040002E9 RID: 745
	public const int 26832D65 = 128;

	// Token: 0x040002EA RID: 746
	public const int 472C0C43 = 1;

	// Token: 0x040002EB RID: 747
	public const int 6CA747AF = 2;

	// Token: 0x040002EC RID: 748
	public static readonly IntPtr 606A7D75 = new IntPtr(-1);

	// Token: 0x040002ED RID: 749
	public static readonly IntPtr 029068BA = IntPtr.Zero;

	// Token: 0x040002EE RID: 750
	public static readonly IntPtr 773F6457 = new IntPtr(-1);

	// Token: 0x02000070 RID: 112
	public enum 1DC9365B : uint
	{
		// Token: 0x04000327 RID: 807
		504364CD = 4096U,
		// Token: 0x04000328 RID: 808
		44FA60C7 = 8192U
	}

	// Token: 0x02000071 RID: 113
	public enum 575758F2 : uint
	{
		// Token: 0x0400032A RID: 810
		22016CDF = 1U,
		// Token: 0x0400032B RID: 811
		4567641A,
		// Token: 0x0400032C RID: 812
		540A114B = 4U,
		// Token: 0x0400032D RID: 813
		1EC82144 = 8U,
		// Token: 0x0400032E RID: 814
		68E874E8 = 16U,
		// Token: 0x0400032F RID: 815
		77904D4F = 32U,
		// Token: 0x04000330 RID: 816
		7DE035F4 = 64U,
		// Token: 0x04000331 RID: 817
		52D60583 = 256U
	}

	// Token: 0x02000072 RID: 114
	public enum 076D520A : uint
	{
		// Token: 0x04000333 RID: 819
		75E5483F = 1U,
		// Token: 0x04000334 RID: 820
		05602822,
		// Token: 0x04000335 RID: 821
		0D5A216A = 4U,
		// Token: 0x04000336 RID: 822
		55817615 = 31U
	}
}
