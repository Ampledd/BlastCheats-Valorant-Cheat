using System;
using System.IO;

// Token: 0x0200003E RID: 62
public class 6AAD6420
{
	// Token: 0x0600034C RID: 844 RVA: 0x00E65F10 File Offset: 0x00E62310
	public 6AAD6420()
	{
		this.28FE6B66 = uint.MaxValue;
		int num = 0;
		while ((long)num < 4L)
		{
			this.33EB7BB2[num] = new 082B7F7D(6);
			num++;
		}
	}

	// Token: 0x0600034D RID: 845 RVA: 0x00E66008 File Offset: 0x00E62408
	private void 47B1116D(uint 0B693B89)
	{
		if (this.28FE6B66 != 0B693B89)
		{
			this.28FE6B66 = 0B693B89;
			this.0F3636DF = Math.Max(this.28FE6B66, 1U);
			uint 67351E5A = Math.Max(this.0F3636DF, 4096U);
			this.29D241D5.3F3C22F9(67351E5A);
		}
	}

	// Token: 0x0600034E RID: 846 RVA: 0x00E66058 File Offset: 0x00E62458
	private void 6A5F42C9(int 53037FB6, int 202F0B3C)
	{
		if (53037FB6 > 8)
		{
			throw new ArgumentException("lp > 8");
		}
		if (202F0B3C > 8)
		{
			throw new ArgumentException("lc > 8");
		}
		this.64026379.78D843F1(53037FB6, 202F0B3C);
	}

	// Token: 0x0600034F RID: 847 RVA: 0x00E6608C File Offset: 0x00E6248C
	private void 3EBC6E7A(int 64184D26)
	{
		if (64184D26 > 4)
		{
			throw new ArgumentException("pb > Base.KNumPosStatesBitsMax");
		}
		uint num = 1U << 64184D26;
		this.3E6D5AA5.4B1F1712(num);
		this.09F667C5.4B1F1712(num);
		this.4A0667DC = num - 1U;
	}

	// Token: 0x06000350 RID: 848 RVA: 0x00E660D4 File Offset: 0x00E624D4
	private void 1AEB2F47(Stream 32077275, Stream 36672391)
	{
		this.3B6D74F1.43190D96(32077275);
		this.29D241D5.65B8774B(36672391, false);
		for (uint num = 0U; num < 12U; num += 1U)
		{
			for (uint num2 = 0U; num2 <= this.4A0667DC; num2 += 1U)
			{
				uint num3 = (num << 4) + num2;
				this.53ED590E[(int)num3].5DDF611C();
				this.7DB80CA0[(int)num3].5DDF611C();
			}
			this.5560277B[(int)num].5DDF611C();
			this.5D6472A9[(int)num].5DDF611C();
			this.1ACD03B3[(int)num].5DDF611C();
			this.197A496B[(int)num].5DDF611C();
		}
		this.64026379.37440BA5();
		for (uint num = 0U; num < 4U; num += 1U)
		{
			this.33EB7BB2[(int)num].30D86004();
		}
		for (uint num = 0U; num < 114U; num += 1U)
		{
			this.7E556FB5[(int)num].5DDF611C();
		}
		this.3E6D5AA5.73E7780B();
		this.09F667C5.73E7780B();
		this.5A2D1FAB.30D86004();
	}

	// Token: 0x06000351 RID: 849 RVA: 0x00E66204 File Offset: 0x00E62604
	public void 7F1B1B1A(Stream 17021A14, Stream 0E1B3A03, long 5F4871B0)
	{
		this.1AEB2F47(17021A14, 0E1B3A03);
		4AB0072B.3D147436 3D = default(4AB0072B.3D147436);
		3D.50D15C2F();
		uint num = 0U;
		uint num2 = 0U;
		uint num3 = 0U;
		uint num4 = 0U;
		ulong num5 = 0UL;
		if (num5 < (ulong)5F4871B0)
		{
			if (this.53ED590E[(int)((int)3D.259A40C1 << 4)].706B4E1B(this.3B6D74F1) != 0U)
			{
				throw new InvalidDataException("IsMatchDecoders");
			}
			3D.20F67EAE();
			byte 512F7D = this.64026379.1B09455A(this.3B6D74F1, 0U, 0);
			this.29D241D5.43233F98(512F7D);
			num5 += 1UL;
		}
		while (num5 < (ulong)5F4871B0)
		{
			uint num6 = (uint)num5 & this.4A0667DC;
			if (this.53ED590E[(int)((3D.259A40C1 << 4) + num6)].706B4E1B(this.3B6D74F1) == 0U)
			{
				byte b = this.29D241D5.73FC08B9(0U);
				byte 512F7D2;
				if (!3D.54732526())
				{
					512F7D2 = this.64026379.50F6632A(this.3B6D74F1, (uint)num5, b, this.29D241D5.73FC08B9(num));
				}
				else
				{
					512F7D2 = this.64026379.1B09455A(this.3B6D74F1, (uint)num5, b);
				}
				this.29D241D5.43233F98(512F7D2);
				3D.20F67EAE();
				num5 += 1UL;
			}
			else
			{
				uint num8;
				if (this.5560277B[(int)3D.259A40C1].706B4E1B(this.3B6D74F1) == 1U)
				{
					if (this.5D6472A9[(int)3D.259A40C1].706B4E1B(this.3B6D74F1) == 0U)
					{
						if (this.7DB80CA0[(int)((3D.259A40C1 << 4) + num6)].706B4E1B(this.3B6D74F1) == 0U)
						{
							3D.71BC10F9();
							this.29D241D5.43233F98(this.29D241D5.73FC08B9(num));
							num5 += 1UL;
							continue;
						}
					}
					else
					{
						uint num7;
						if (this.1ACD03B3[(int)3D.259A40C1].706B4E1B(this.3B6D74F1) == 0U)
						{
							num7 = num2;
						}
						else
						{
							if (this.197A496B[(int)3D.259A40C1].706B4E1B(this.3B6D74F1) == 0U)
							{
								num7 = num3;
							}
							else
							{
								num7 = num4;
								num4 = num3;
							}
							num3 = num2;
						}
						num2 = num;
						num = num7;
					}
					num8 = this.09F667C5.45A810E0(this.3B6D74F1, num6) + 2U;
					3D.13FB6A74();
				}
				else
				{
					num4 = num3;
					num3 = num2;
					num2 = num;
					num8 = 2U + this.3E6D5AA5.45A810E0(this.3B6D74F1, num6);
					3D.7F4C1655();
					uint num9 = this.33EB7BB2[(int)4AB0072B.6A7A05FC(num8)].2D360830(this.3B6D74F1);
					if (num9 >= 4U)
					{
						int num10 = (int)((num9 >> 1) - 1U);
						num = (2U | (num9 & 1U)) << num10;
						if (num9 < 14U)
						{
							num += 082B7F7D.15693F03(this.7E556FB5, num - num9 - 1U, this.3B6D74F1, num10);
						}
						else
						{
							num += this.3B6D74F1.79122D94(num10 - 4) << 4;
							num += this.5A2D1FAB.7780110B(this.3B6D74F1);
						}
					}
					else
					{
						num = num9;
					}
				}
				if ((ulong)num >= (ulong)this.29D241D5.64C33804 + num5 || num >= this.0F3636DF)
				{
					if (num != 4294967295U)
					{
						throw new InvalidDataException("rep0");
					}
					break;
				}
				else
				{
					this.29D241D5.334E7561(num, num8);
					num5 += (ulong)num8;
				}
			}
		}
		this.29D241D5.618B080F();
		this.29D241D5.0A0E3C7A();
		this.3B6D74F1.03A24326();
	}

	// Token: 0x06000352 RID: 850 RVA: 0x00E66598 File Offset: 0x00E62998
	public void 4E1963D5(byte[] 7C417DE0)
	{
		if (7C417DE0.Length < 5)
		{
			throw new ArgumentException("properties.Length < 5");
		}
		int 202F0B3C = (int)(7C417DE0[0] % 9);
		byte b = 7C417DE0[0] / 9;
		int 53037FB = (int)(b % 5);
		int num = (int)(b / 5);
		if (num > 4)
		{
			throw new ArgumentException("pb > Base.kNumPosStatesBitsMax");
		}
		uint num2 = 0U;
		for (int i = 0; i < 4; i++)
		{
			num2 += (uint)((uint)7C417DE0[1 + i] << i * 8);
		}
		this.47B1116D(num2);
		this.6A5F42C9(53037FB, 202F0B3C);
		this.3EBC6E7A(num);
	}

	// Token: 0x040002AD RID: 685
	private uint 20FE5BE6 = 1U;

	// Token: 0x040002AE RID: 686
	private readonly 6A10248A 29D241D5 = new 6A10248A();

	// Token: 0x040002AF RID: 687
	private readonly 676900C5 3B6D74F1 = new 676900C5();

	// Token: 0x040002B0 RID: 688
	private readonly 37386292[] 53ED590E = new 37386292[192];

	// Token: 0x040002B1 RID: 689
	private readonly 37386292[] 5560277B = new 37386292[12];

	// Token: 0x040002B2 RID: 690
	private readonly 37386292[] 5D6472A9 = new 37386292[12];

	// Token: 0x040002B3 RID: 691
	private readonly 37386292[] 1ACD03B3 = new 37386292[12];

	// Token: 0x040002B4 RID: 692
	private readonly 37386292[] 197A496B = new 37386292[12];

	// Token: 0x040002B5 RID: 693
	private readonly 37386292[] 7DB80CA0 = new 37386292[192];

	// Token: 0x040002B6 RID: 694
	private readonly 082B7F7D[] 33EB7BB2 = new 082B7F7D[4];

	// Token: 0x040002B7 RID: 695
	private readonly 37386292[] 7E556FB5 = new 37386292[114];

	// Token: 0x040002B8 RID: 696
	private 082B7F7D 5A2D1FAB = new 082B7F7D(4);

	// Token: 0x040002B9 RID: 697
	private readonly 6AAD6420.7D3533CC 3E6D5AA5 = new 6AAD6420.7D3533CC();

	// Token: 0x040002BA RID: 698
	private readonly 6AAD6420.7D3533CC 09F667C5 = new 6AAD6420.7D3533CC();

	// Token: 0x040002BB RID: 699
	private readonly 6AAD6420.2B7B49F4 64026379 = new 6AAD6420.2B7B49F4();

	// Token: 0x040002BC RID: 700
	private uint 28FE6B66;

	// Token: 0x040002BD RID: 701
	private uint 0F3636DF;

	// Token: 0x040002BE RID: 702
	private uint 4A0667DC;

	// Token: 0x0200004D RID: 77
	private class 7D3533CC
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x00E75730 File Offset: 0x00E71B30
		public void 4B1F1712(uint 0C79559C)
		{
			for (uint num = this.433A424B; num < 0C79559C; num += 1U)
			{
				this.6779389F[(int)num] = new 082B7F7D(3);
				this.6C6B33FB[(int)num] = new 082B7F7D(3);
			}
			this.433A424B = 0C79559C;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00E75780 File Offset: 0x00E71B80
		public void 73E7780B()
		{
			this.28185950.5DDF611C();
			for (uint num = 0U; num < this.433A424B; num += 1U)
			{
				this.6779389F[(int)num].30D86004();
				this.6C6B33FB[(int)num].30D86004();
			}
			this.44715864.5DDF611C();
			this.6A5E3E30.30D86004();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00E757E8 File Offset: 0x00E71BE8
		public uint 45A810E0(676900C5 0B5F27C5, uint 05F34BFC)
		{
			if (this.28185950.706B4E1B(0B5F27C5) == 0U)
			{
				return this.6779389F[(int)05F34BFC].2D360830(0B5F27C5);
			}
			uint num = 8U;
			if (this.44715864.706B4E1B(0B5F27C5) == 0U)
			{
				num += this.6C6B33FB[(int)05F34BFC].2D360830(0B5F27C5);
			}
			else
			{
				num += 8U;
				num += this.6A5E3E30.2D360830(0B5F27C5);
			}
			return num;
		}

		// Token: 0x040002F2 RID: 754
		private 37386292 28185950;

		// Token: 0x040002F3 RID: 755
		private 37386292 44715864;

		// Token: 0x040002F4 RID: 756
		private readonly 082B7F7D[] 6779389F = new 082B7F7D[16];

		// Token: 0x040002F5 RID: 757
		private readonly 082B7F7D[] 6C6B33FB = new 082B7F7D[16];

		// Token: 0x040002F6 RID: 758
		private 082B7F7D 6A5E3E30 = new 082B7F7D(8);

		// Token: 0x040002F7 RID: 759
		private uint 433A424B;
	}

	// Token: 0x0200004E RID: 78
	private class 2B7B49F4
	{
		// Token: 0x060003FD RID: 1021 RVA: 0x00E7588C File Offset: 0x00E71C8C
		public void 78D843F1(int 4F661C59, int 51FF273E)
		{
			if (this.1B486EB9 != null && this.0A4B7B93 == 51FF273E && this.0AB067AE == 4F661C59)
			{
				return;
			}
			this.0AB067AE = 4F661C59;
			this.581F3D3A = (1U << 4F661C59) - 1U;
			this.0A4B7B93 = 51FF273E;
			uint num = 1U << this.0A4B7B93 + this.0AB067AE;
			this.1B486EB9 = new 6AAD6420.2B7B49F4.0BE246DE[num];
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.1B486EB9[(int)num2].7B2257DB();
			}
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00E7591C File Offset: 0x00E71D1C
		public void 37440BA5()
		{
			uint num = 1U << this.0A4B7B93 + this.0AB067AE;
			for (uint num2 = 0U; num2 < num; num2 += 1U)
			{
				this.1B486EB9[(int)num2].198E3F8E();
			}
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00E75960 File Offset: 0x00E71D60
		private uint 3EE82199(uint 21DA6C2C, byte 23342ED5)
		{
			return ((21DA6C2C & this.581F3D3A) << this.0A4B7B93) + (uint)(23342ED5 >> 8 - this.0A4B7B93);
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00E75984 File Offset: 0x00E71D84
		public byte 1B09455A(676900C5 61B64FF7, uint 17FB514A, byte 54395608)
		{
			return this.1B486EB9[(int)this.3EE82199(17FB514A, 54395608)].74336A88(61B64FF7);
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00E759A0 File Offset: 0x00E71DA0
		public byte 50F6632A(676900C5 2B376C86, uint 33F911B0, byte 19C92573, byte 3F847F51)
		{
			return this.1B486EB9[(int)this.3EE82199(33F911B0, 19C92573)].722F64F6(2B376C86, 3F847F51);
		}

		// Token: 0x040002F8 RID: 760
		private uint 06570CB3 = 1U;

		// Token: 0x040002F9 RID: 761
		private 6AAD6420.2B7B49F4.0BE246DE[] 1B486EB9;

		// Token: 0x040002FA RID: 762
		private int 0A4B7B93;

		// Token: 0x040002FB RID: 763
		private int 0AB067AE;

		// Token: 0x040002FC RID: 764
		private uint 581F3D3A;

		// Token: 0x02000075 RID: 117
		private struct 0BE246DE
		{
			// Token: 0x06000589 RID: 1417 RVA: 0x00E7AEEC File Offset: 0x00E772EC
			public void 7B2257DB()
			{
				this.7E560F13 = new 37386292[768];
			}

			// Token: 0x0600058A RID: 1418 RVA: 0x00E7AF00 File Offset: 0x00E77300
			public void 198E3F8E()
			{
				for (int i = 0; i < 768; i++)
				{
					this.7E560F13[i].5DDF611C();
				}
			}

			// Token: 0x0600058B RID: 1419 RVA: 0x00E7AF34 File Offset: 0x00E77334
			public byte 74336A88(676900C5 525C5026)
			{
				uint num = 1U;
				do
				{
					num = (num << 1 | this.7E560F13[(int)num].706B4E1B(525C5026));
				}
				while (num < 256U);
				return (byte)num;
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00E7AF68 File Offset: 0x00E77368
			public byte 722F64F6(676900C5 7F46491F, byte 33D57123)
			{
				uint num = 1U;
				for (;;)
				{
					uint num2 = (uint)(33D57123 >> 7 & 1);
					33D57123 = (byte)(33D57123 << 1);
					uint num3 = this.7E560F13[(int)((1U + num2 << 8) + num)].706B4E1B(7F46491F);
					num = (num << 1 | num3);
					if (num2 != num3)
					{
						break;
					}
					if (num >= 256U)
					{
						goto IL_6B;
					}
				}
				while (num < 256U)
				{
					num = (num << 1 | this.7E560F13[(int)num].706B4E1B(7F46491F));
				}
				IL_6B:
				return (byte)num;
			}

			// Token: 0x04000337 RID: 823
			private 37386292[] 7E560F13;
		}
	}
}
