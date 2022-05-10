using System;

// Token: 0x02000041 RID: 65
internal struct 082B7F7D
{
	// Token: 0x06000359 RID: 857 RVA: 0x00E6680C File Offset: 0x00E62C0C
	public 082B7F7D(int 610715AF)
	{
		this.0A657121 = 610715AF;
		this.08D3147F = new 37386292[1 << 610715AF];
	}

	// Token: 0x0600035A RID: 858 RVA: 0x00E66828 File Offset: 0x00E62C28
	public void 30D86004()
	{
		uint num = 1U;
		while ((ulong)num < (ulong)(1L << (this.0A657121 & 31)))
		{
			this.08D3147F[(int)num].5DDF611C();
			num += 1U;
		}
	}

	// Token: 0x0600035B RID: 859 RVA: 0x00E66864 File Offset: 0x00E62C64
	public uint 2D360830(676900C5 020C4EA8)
	{
		uint num = 1U;
		for (int i = this.0A657121; i > 0; i--)
		{
			num = (num << 1) + this.08D3147F[(int)num].706B4E1B(020C4EA8);
		}
		return num - (1U << this.0A657121);
	}

	// Token: 0x0600035C RID: 860 RVA: 0x00E668B0 File Offset: 0x00E62CB0
	public uint 7780110B(676900C5 61AC7448)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < this.0A657121; i++)
		{
			uint num3 = this.08D3147F[(int)num].706B4E1B(61AC7448);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x0600035D RID: 861 RVA: 0x00E66900 File Offset: 0x00E62D00
	public static uint 15693F03(37386292[] 76EA2751, uint 76250EC1, 676900C5 06112B67, int 6D8654EF)
	{
		uint num = 1U;
		uint num2 = 0U;
		for (int i = 0; i < 6D8654EF; i++)
		{
			uint num3 = 76EA2751[(int)(76250EC1 + num)].706B4E1B(06112B67);
			num <<= 1;
			num += num3;
			num2 |= num3 << i;
		}
		return num2;
	}

	// Token: 0x040002C8 RID: 712
	private readonly 37386292[] 08D3147F;

	// Token: 0x040002C9 RID: 713
	private readonly int 0A657121;
}
