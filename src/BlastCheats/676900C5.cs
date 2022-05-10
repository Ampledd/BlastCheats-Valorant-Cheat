using System;
using System.IO;

// Token: 0x0200003F RID: 63
internal class 676900C5
{
	// Token: 0x06000353 RID: 851 RVA: 0x00E66620 File Offset: 0x00E62A20
	public void 43190D96(Stream 32300F24)
	{
		this.13B838D4 = 32300F24;
		this.2BE14F3B = 0U;
		this.3C923A66 = uint.MaxValue;
		for (int i = 0; i < 5; i++)
		{
			this.2BE14F3B = (this.2BE14F3B << 8 | (uint)((byte)this.13B838D4.ReadByte()));
		}
	}

	// Token: 0x06000354 RID: 852 RVA: 0x00E66670 File Offset: 0x00E62A70
	public void 03A24326()
	{
		this.13B838D4 = null;
	}

	// Token: 0x06000355 RID: 853 RVA: 0x00E6667C File Offset: 0x00E62A7C
	public uint 79122D94(int 045E5B1C)
	{
		uint num = this.3C923A66;
		uint num2 = this.2BE14F3B;
		uint num3 = 0U;
		for (int i = 045E5B1C; i > 0; i--)
		{
			num >>= 1;
			uint num4 = num2 - num >> 31;
			num2 -= (num & num4 - 1U);
			num3 = (num3 << 1 | 1U - num4);
			if (num < 16777216U)
			{
				num2 = (num2 << 8 | (uint)((byte)this.13B838D4.ReadByte()));
				num <<= 8;
			}
		}
		this.3C923A66 = num;
		this.2BE14F3B = num2;
		return num3;
	}

	// Token: 0x040002BF RID: 703
	private uint 63915458 = 1U;

	// Token: 0x040002C0 RID: 704
	public const uint 130355AF = 16777216U;

	// Token: 0x040002C1 RID: 705
	public uint 3C923A66;

	// Token: 0x040002C2 RID: 706
	public uint 2BE14F3B;

	// Token: 0x040002C3 RID: 707
	public Stream 13B838D4;
}
