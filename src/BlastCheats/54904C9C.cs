using System;

// Token: 0x02000045 RID: 69
public class 54904C9C
{
	// Token: 0x0600036A RID: 874 RVA: 0x00E66D10 File Offset: 0x00E63110
	public 54904C9C()
	{
		this.63394DC1 = 975858191U;
	}

	// Token: 0x0600036B RID: 875 RVA: 0x00E66D24 File Offset: 0x00E63124
	public uint 4B3041F7(uint 520C20C0)
	{
		uint num = 520C20C0 ^ this.63394DC1;
		this.63394DC1 = (7F3A42CD.2E8E4C8D(this.63394DC1, 7) ^ num);
		return num;
	}

	// Token: 0x040002D4 RID: 724
	private uint 63394DC1;
}
