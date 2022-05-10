using System;
using System.IO;

// Token: 0x02000042 RID: 66
public class 6A10248A
{
	// Token: 0x0600035E RID: 862 RVA: 0x00E66948 File Offset: 0x00E62D48
	public void 3F3C22F9(uint 67351E5A)
	{
		if (this.0A246E70 != 67351E5A)
		{
			this.11F563FB = new byte[67351E5A];
		}
		this.0A246E70 = 67351E5A;
		this.36EB07C5 = 0U;
		this.60BF47E8 = 0U;
	}

	// Token: 0x0600035F RID: 863 RVA: 0x00E66978 File Offset: 0x00E62D78
	public void 65B8774B(Stream 471150AA, bool 1E1456EA)
	{
		this.0A0E3C7A();
		this.451A2EAE = 471150AA;
		if (!1E1456EA)
		{
			this.60BF47E8 = 0U;
			this.36EB07C5 = 0U;
			this.64C33804 = 0U;
		}
	}

	// Token: 0x06000360 RID: 864 RVA: 0x00E669A4 File Offset: 0x00E62DA4
	public void 0A0E3C7A()
	{
		this.618B080F();
		this.451A2EAE = null;
	}

	// Token: 0x06000361 RID: 865 RVA: 0x00E669B4 File Offset: 0x00E62DB4
	public void 618B080F()
	{
		uint num = this.36EB07C5 - this.60BF47E8;
		if (num == 0U)
		{
			return;
		}
		this.451A2EAE.Write(this.11F563FB, (int)this.60BF47E8, (int)num);
		if (this.36EB07C5 >= this.0A246E70)
		{
			this.36EB07C5 = 0U;
		}
		this.60BF47E8 = this.36EB07C5;
	}

	// Token: 0x06000362 RID: 866 RVA: 0x00E66A14 File Offset: 0x00E62E14
	public void 334E7561(uint 6A1D5492, uint 51766CB3)
	{
		uint num = this.36EB07C5 - 6A1D5492 - 1U;
		if (num >= this.0A246E70)
		{
			num += this.0A246E70;
		}
		while (51766CB3 > 0U)
		{
			if (num >= this.0A246E70)
			{
				num = 0U;
			}
			byte[] array = this.11F563FB;
			uint num2 = this.36EB07C5;
			this.36EB07C5 = num2 + 1U;
			array[(int)num2] = this.11F563FB[(int)num++];
			if (this.36EB07C5 >= this.0A246E70)
			{
				this.618B080F();
			}
			51766CB3 -= 1U;
		}
	}

	// Token: 0x06000363 RID: 867 RVA: 0x00E66A9C File Offset: 0x00E62E9C
	public void 43233F98(byte 512F7D57)
	{
		byte[] array = this.11F563FB;
		uint num = this.36EB07C5;
		this.36EB07C5 = num + 1U;
		array[(int)num] = 512F7D57;
		if (this.36EB07C5 >= this.0A246E70)
		{
			this.618B080F();
		}
	}

	// Token: 0x06000364 RID: 868 RVA: 0x00E66ADC File Offset: 0x00E62EDC
	public byte 73FC08B9(uint 377B2AEB)
	{
		uint num = this.36EB07C5 - 377B2AEB - 1U;
		if (num >= this.0A246E70)
		{
			num += this.0A246E70;
		}
		return this.11F563FB[(int)num];
	}

	// Token: 0x040002CA RID: 714
	private byte[] 11F563FB;

	// Token: 0x040002CB RID: 715
	private uint 36EB07C5;

	// Token: 0x040002CC RID: 716
	private uint 0A246E70;

	// Token: 0x040002CD RID: 717
	private uint 60BF47E8;

	// Token: 0x040002CE RID: 718
	private Stream 451A2EAE;

	// Token: 0x040002CF RID: 719
	private uint 22E47621 = 1U;

	// Token: 0x040002D0 RID: 720
	public uint 64C33804;
}
