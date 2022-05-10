using System;
using System.Diagnostics;

// Token: 0x02000003 RID: 3
internal static class Sandboxie
{
	// Token: 0x0600000A RID: 10 RVA: 0x000024E4 File Offset: 0x000008E4
	private static IntPtr GetModuleHandle(string libName)
	{
		foreach (object obj in Process.GetCurrentProcess().Modules)
		{
			ProcessModule processModule = (ProcessModule)obj;
			bool flag = processModule.ModuleName.ToLower().Contains(libName.ToLower());
			if (flag)
			{
				return processModule.BaseAddress;
			}
		}
		return IntPtr.Zero;
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000256C File Offset: 0x0000096C
	internal static bool IsSandboxie()
	{
		return Sandboxie.GetModuleHandle("SbieDll.dll") != IntPtr.Zero;
	}
}
