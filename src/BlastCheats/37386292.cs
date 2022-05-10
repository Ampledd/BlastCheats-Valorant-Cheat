using System;

// Token: 0x02000040 RID: 64
internal struct 37386292
{
	// Token: 0x06000357 RID: 855 RVA: 0x00E66708 File Offset: 0x00E62B08
	public void 5DDF611C()
	{
		this.2AA82BC3 = 1024U;
	}

	// Token: 0x06000358 RID: 856 RVA: 0x00E66718 File Offset: 0x00E62B18
	public uint 706B4E1B(676900C5 4E210EFF)
	{
		uint num = (4E210EFF.3C923A66 >> 11) * this.2AA82BC3;
		if (4E210EFF.2BE14F3B < num)
		{
			4E210EFF.3C923A66 = num;
			this.2AA82BC3 += 2048U - this.2AA82BC3 >> 5;
			if (4E210EFF.3C923A66 < 16777216U)
			{
				4E210EFF.2BE14F3B = (4E210EFF.2BE14F3B << 8 | (uint)((byte)4E210EFF.13B838D4.ReadByte()));
				4E210EFF.3C923A66 <<= 8;
			}
			return 0U;
		}
		4E210EFF.3C923A66 -= num;
		4E210EFF.2BE14F3B -= num;
		this.2AA82BC3 -= this.2AA82BC3 >> 5;
		if (4E210EFF.3C923A66 < 16777216U)
		{
			4E210EFF.2BE14F3B = (4E210EFF.2BE14F3B << 8 | (uint)((byte)4E210EFF.13B838D4.ReadByte()));
			4E210EFF.3C923A66 <<= 8;
		}
		return 1U;
	}

	// Token: 0x040002C4 RID: 708
	private const int 250446C7 = 11;

	// Token: 0x040002C5 RID: 709
	private const uint 2CF9731D = 2048U;

	// Token: 0x040002C6 RID: 710
	private const int 64F77747 = 5;

	// Token: 0x040002C7 RID: 711
	private uint 2AA82BC3;
}
