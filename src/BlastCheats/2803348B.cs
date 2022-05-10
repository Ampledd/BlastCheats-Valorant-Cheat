using System;
using System.Runtime.InteropServices;

// Token: 0x02000044 RID: 68
public class 2803348B
{
	// Token: 0x06000368 RID: 872 RVA: 0x00E66C48 File Offset: 0x00E63048
	public 2803348B()
	{
		if (2803348B.46023FF1 == null)
		{
			2803348B.46023FF1 = new uint[256];
			for (int i = 0; i < 256; i++)
			{
				uint num = (uint)i;
				for (int j = 0; j < 8; j++)
				{
					if ((num & 1U) == 1U)
					{
						num = (num >> 1 ^ 3988292384U);
					}
					else
					{
						num >>= 1;
					}
				}
				2803348B.46023FF1[i] = num;
			}
		}
	}

	// Token: 0x06000369 RID: 873 RVA: 0x00E66CC4 File Offset: 0x00E630C4
	public uint 726E1D86(IntPtr 006833F4, uint 2AAD6098)
	{
		uint num = 0U;
		int num2 = 0;
		while ((long)num2 < (long)((ulong)2AAD6098))
		{
			num = (2803348B.46023FF1[(int)(((uint)Marshal.ReadByte(new IntPtr(006833F4.ToInt64() + (long)num2)) ^ num) & 255U)] ^ num >> 8);
			num2++;
		}
		return ~num;
	}

	// Token: 0x040002D3 RID: 723
	private static uint[] 46023FF1;
}
