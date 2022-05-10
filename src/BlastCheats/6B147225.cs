using System;
using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Threading;

// Token: 0x02000049 RID: 73
public class 6B147225
{
	// Token: 0x06000371 RID: 881 RVA: 0x00E67090 File Offset: 0x00E63490
	public 6B147225()
	{
		uint num;
		for (;;)
		{
			IL_00:
			Dictionary<uint, 6B147225.62147124> dictionary = new Dictionary<uint, 6B147225.62147124>();
			num = 538068562U;
			this.01546E90 = dictionary;
			num = 1956080809U + num;
			for (;;)
			{
				IL_19:
				RuntimeTypeHandle handle = typeof(6B147225).TypeHandle;
				num = 1437932837U << (int)num;
				Module module = Type.GetTypeFromHandle(handle).Module;
				num ^= 1899850906U;
				this.64D20DDA = module;
				for (;;)
				{
					IL_44:
					Stack<6B147225.14B354D4> stack = new Stack<6B147225.14B354D4>();
					num = 718866997U << (int)num;
					this.176B51CC = stack;
					num &= 372718953U;
					for (;;)
					{
						IL_65:
						List<6B147225.68EF01A4> list = new List<6B147225.68EF01A4>();
						num >>= 25;
						this.374C66F2 = list;
						for (;;)
						{
							IL_78:
							num = (1273183831U | num);
							List<6B147225.045263C1> list2 = new List<6B147225.045263C1>();
							num = 594374263U + num;
							this.1DD42960 = list2;
							num %= 1289769356U;
							if (num >> 15 == 0U)
							{
								goto IL_00;
							}
							for (;;)
							{
								IL_A7:
								Stack<6B147225.045263C1> stack2 = new Stack<6B147225.045263C1>();
								num -= 1539323050U;
								this.31162A15 = stack2;
								num = 211885283U % num;
								if (num > 821570205U)
								{
									goto IL_00;
								}
								for (;;)
								{
									num |= 1563443400U;
									this.21241E86 = new Stack<int>();
									if (795895393U >= num)
									{
										goto IL_00;
									}
									for (;;)
									{
										this.227B4861 = new List<IntPtr>();
										if (1923682198U / num == 0U)
										{
											goto IL_00;
										}
										num <<= 4;
										base..ctor();
										if (num <= 898189604U)
										{
											goto IL_00;
										}
										num %= 1175145961U;
										num <<= 1;
										Module m = this.64D20DDA;
										num = (1014651866U ^ num);
										IntPtr hinstance = Marshal.GetHINSTANCE(m);
										num = (1955989740U & num);
										IntPtr intPtr = hinstance;
										num |= 1448955773U;
										long num2 = intPtr.ToInt64();
										num = (111693493U ^ num);
										this.5E457DAB = num2;
										if (num < 1746495544U)
										{
											goto IL_00;
										}
										num = 1624454995U + num;
										Dictionary<uint, 6B147225.62147124> dictionary2 = this.01546E90;
										num = 2063478651U << (int)num;
										uint key = num ^ 3623878656U;
										num += 646147036U;
										IntPtr 63FB2F3A = ldftn(65104E65);
										num <<= 6;
										dictionary2[key] = new 6B147225.62147124(this, 63FB2F3A);
										Dictionary<uint, 6B147225.62147124> dictionary3 = this.01546E90;
										num = 1524368099U * num;
										uint key2 = num ^ 2618754305U;
										num *= 1080911040U;
										num /= 935735114U;
										IntPtr 63FB2F3A2 = ldftn(666745F0);
										num -= 1016993243U;
										dictionary3[key2] = new 6B147225.62147124(this, 63FB2F3A2);
										num ^= 43592832U;
										if (num == 1493728046U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary4 = this.01546E90;
										uint key3 = num ^ 3254306471U;
										num %= 1930829548U;
										dictionary4[key3] = new 6B147225.62147124(this.041073EB);
										num = 11541487U / num;
										if (2146705276U < num)
										{
											goto IL_00;
										}
										num /= 1564617540U;
										Dictionary<uint, 6B147225.62147124> dictionary5 = this.01546E90;
										num += 1833921881U;
										uint key4 = num ^ 1833921882U;
										num = 1694772732U << (int)num;
										num = 887386657U >> (int)num;
										6B147225.62147124 value = new 6B147225.62147124(this.00E3065E);
										num = 1641680175U << (int)num;
										dictionary5[key4] = value;
										num = (2103396618U ^ num);
										if (2002081448U * num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary6 = this.01546E90;
										num >>= 27;
										uint key5 = num ^ 19U;
										num %= 371872679U;
										6B147225.62147124 value2 = new 6B147225.62147124(this.33391827);
										num = (883779700U & num);
										dictionary6[key5] = value2;
										Dictionary<uint, 6B147225.62147124> dictionary7 = this.01546E90;
										uint key6 = num + 4294967281U;
										num = (1894524266U & num);
										IntPtr 63FB2F3A3 = ldftn(46675BC7);
										num /= 595881717U;
										dictionary7[key6] = new 6B147225.62147124(this, 63FB2F3A3);
										num %= 143009013U;
										Dictionary<uint, 6B147225.62147124> dictionary8 = this.01546E90;
										uint key7 = num ^ 6U;
										num *= 1488392823U;
										dictionary8[key7] = new 6B147225.62147124(this.73175DAE);
										if (num >= 1173309930U)
										{
											goto IL_00;
										}
										num <<= 26;
										Dictionary<uint, 6B147225.62147124> dictionary9 = this.01546E90;
										uint key8 = num ^ 7U;
										num = 1704213585U + num;
										6B147225.62147124 value3 = new 6B147225.62147124(this.7416593F);
										num = 1963419355U >> (int)num;
										dictionary9[key8] = value3;
										if (num << 26 == 0U)
										{
											goto IL_00;
										}
										num = (200106281U & num);
										Dictionary<uint, 6B147225.62147124> dictionary10 = this.01546E90;
										uint key9 = num + 4294959111U;
										IntPtr 63FB2F3A4 = ldftn(2014144B);
										num = 631836524U + num;
										6B147225.62147124 value4 = new 6B147225.62147124(this, 63FB2F3A4);
										num ^= 1587293163U;
										dictionary10[key9] = value4;
										num = 1428490393U * num;
										Dictionary<uint, 6B147225.62147124> dictionary11 = this.01546E90;
										uint key10 = num ^ 1882317855U;
										num = (115629203U & num);
										6B147225.62147124 value5 = new 6B147225.62147124(this.104C242D);
										num = 1177621128U << (int)num;
										dictionary11[key10] = value5;
										num %= 1091401504U;
										Dictionary<uint, 6B147225.62147124> dictionary12 = this.01546E90;
										num = (151613295U | num);
										uint key11 = num ^ 152825829U;
										num |= 200893175U;
										num -= 1046705316U;
										IntPtr 63FB2F3A5 = ldftn(56C23C40);
										num = 1438733448U >> (int)num;
										6B147225.62147124 value6 = new 6B147225.62147124(this, 63FB2F3A5);
										num = (889289306U | num);
										dictionary12[key11] = value6;
										num %= 688287730U;
										if (1965435854U >> (int)num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary13 = this.01546E90;
										uint key12 = num + 4093965731U;
										num = 1711833040U - num;
										num -= 1142367616U;
										IntPtr 63FB2F3A6 = ldftn(285D09B9);
										num -= 571933103U;
										dictionary13[key12] = new 6B147225.62147124(this, 63FB2F3A6);
										if (num << 25 == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary14 = this.01546E90;
										num += 817178343U;
										uint key13 = num - 613709076U;
										num -= 398133207U;
										num &= 879968785U;
										dictionary14[key13] = new 6B147225.62147124(this.076D5B2A);
										num &= 1779841012U;
										if (num + 620496635U == 0U)
										{
											goto IL_00;
										}
										num = (947223988U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary15 = this.01546E90;
										num = (2053527798U ^ num);
										uint key14 = num ^ 1107502415U;
										num *= 1156343965U;
										dictionary15[key14] = new 6B147225.62147124(this.70114960);
										num = 605305173U + num;
										if (134562322U == num)
										{
											goto IL_00;
										}
										num = 1707374770U + num;
										Dictionary<uint, 6B147225.62147124> dictionary16 = this.01546E90;
										num = 599670216U - num;
										uint key15 = num - 4126990905U;
										IntPtr 63FB2F3A7 = ldftn(3D7E61BB);
										num = 1104347251U % num;
										6B147225.62147124 value7 = new 6B147225.62147124(this, 63FB2F3A7);
										num %= 2036891468U;
										dictionary16[key15] = value7;
										num = 408842201U * num;
										if (1096245482U <= num)
										{
											goto IL_19;
										}
										num &= 1151882444U;
										Dictionary<uint, 6B147225.62147124> dictionary17 = this.01546E90;
										num *= 1736858554U;
										uint key16 = num - 2633258049U;
										num = (2053049957U | num);
										dictionary17[key16] = new 6B147225.62147124(this.2CAF332F);
										Dictionary<uint, 6B147225.62147124> dictionary18 = this.01546E90;
										uint key17 = num ^ 4278148709U;
										num = 1135505912U << (int)num;
										IntPtr 63FB2F3A8 = ldftn(59511227);
										num = 774131390U * num;
										6B147225.62147124 value8 = new 6B147225.62147124(this, 63FB2F3A8);
										num ^= 1522025405U;
										dictionary18[key17] = value8;
										num /= 104147733U;
										if (num > 2094530701U)
										{
											goto IL_00;
										}
										num |= 191655105U;
										Dictionary<uint, 6B147225.62147124> dictionary19 = this.01546E90;
										uint key18 = num + 4103312184U;
										num <<= 12;
										IntPtr 63FB2F3A9 = ldftn(7B3F02E5);
										num *= 1414808762U;
										dictionary19[key18] = new 6B147225.62147124(this, 63FB2F3A9);
										Dictionary<uint, 6B147225.62147124> dictionary20 = this.01546E90;
										num = (1019417743U ^ num);
										uint key19 = num ^ 2002367645U;
										num %= 874277543U;
										6B147225.62147124 value9 = new 6B147225.62147124(this.0B410DF3);
										num -= 1353865980U;
										dictionary20[key19] = value9;
										num ^= 185600305U;
										Dictionary<uint, 6B147225.62147124> dictionary21 = this.01546E90;
										uint key20 = num ^ 3044969831U;
										IntPtr 63FB2F3A10 = ldftn(477F2627);
										num /= 271976500U;
										dictionary21[key20] = new 6B147225.62147124(this, 63FB2F3A10);
										num *= 491788126U;
										Dictionary<uint, 6B147225.62147124> dictionary22 = this.01546E90;
										uint key21 = num + 3180265226U;
										6B147225.62147124 value10 = new 6B147225.62147124(this.63C40051);
										num >>= 28;
										dictionary22[key21] = value10;
										num = 1253455559U + num;
										if (607611107U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary23 = this.01546E90;
										uint key22 = num ^ 1253455582U;
										num = (1702431712U ^ num);
										num = 2127244452U * num;
										IntPtr 63FB2F3A11 = ldftn(1BBE5E66);
										num += 784427136U;
										6B147225.62147124 value11 = new 6B147225.62147124(this, 63FB2F3A11);
										num %= 620394262U;
										dictionary23[key22] = value11;
										num = (796542169U & num);
										Dictionary<uint, 6B147225.62147124> dictionary24 = this.01546E90;
										uint key23 = num ^ 153109534U;
										num = (1112220507U | num);
										num &= 2075162849U;
										IntPtr 63FB2F3A12 = ldftn(65BD5E64);
										num = 546794179U % num;
										6B147225.62147124 value12 = new 6B147225.62147124(this, 63FB2F3A12);
										num /= 811797851U;
										dictionary24[key23] = value12;
										if ((num ^ 1730033455U) == 0U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary25 = this.01546E90;
										num += 1285455208U;
										uint key24 = num - 1285455185U;
										6B147225.62147124 value13 = new 6B147225.62147124(this.19D279C4);
										num >>= 30;
										dictionary25[key24] = value13;
										num -= 680996864U;
										if (num << 8 == 0U)
										{
											goto IL_00;
										}
										num = 622332615U + num;
										Dictionary<uint, 6B147225.62147124> dictionary26 = this.01546E90;
										uint key25 = num ^ 4236303056U;
										num = 803158995U - num;
										dictionary26[key25] = new 6B147225.62147124(this.23C57035);
										if (987967481U < num)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary27 = this.01546E90;
										num = (278670148U ^ num);
										dictionary27[num + 3695031754U] = new 6B147225.62147124(this.636B0497);
										if (num < 610494U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary28 = this.01546E90;
										num = 571819325U - num;
										uint key26 = num ^ 4266851060U;
										num = 1680696697U << (int)num;
										num = 334720398U << (int)num;
										6B147225.62147124 value14 = new 6B147225.62147124(this.57302E15);
										num = 1518561667U * num;
										dictionary28[key26] = value14;
										num *= 738464248U;
										if (num % 489556547U == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary29 = this.01546E90;
										num = (1644328411U | num);
										uint key27 = num ^ 2127296480U;
										num &= 816912470U;
										IntPtr 63FB2F3A13 = ldftn(5605518D);
										num %= 311844970U;
										dictionary29[key27] = new 6B147225.62147124(this, 63FB2F3A13);
										if ((977535258U & num) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary30 = this.01546E90;
										uint key28 = num - 190074722U;
										IntPtr 63FB2F3A14 = ldftn(65FC77CC);
										num = 613233404U % num;
										6B147225.62147124 value15 = new 6B147225.62147124(this, 63FB2F3A14);
										num = 1248536185U / num;
										dictionary30[key28] = value15;
										if (1363158765U <= num)
										{
											goto IL_00;
										}
										num = 1667978517U % num;
										Dictionary<uint, 6B147225.62147124> dictionary31 = this.01546E90;
										uint key29 = num - 4294967284U;
										num /= 721494342U;
										IntPtr 63FB2F3A15 = ldftn(04ED7FCC);
										num = (1216898138U | num);
										dictionary31[key29] = new 6B147225.62147124(this, 63FB2F3A15);
										this.01546E90[num ^ 1216898116U] = new 6B147225.62147124(this.7DA75F08);
										num = (478365284U | num);
										num = 1058493863U - num;
										Dictionary<uint, 6B147225.62147124> dictionary32 = this.01546E90;
										uint key30 = num - 3800821514U;
										num = 109726946U >> (int)num;
										6B147225.62147124 value16 = new 6B147225.62147124(this.04422881);
										num |= 1913204320U;
										dictionary32[key30] = value16;
										num = 1282415417U * num;
										Dictionary<uint, 6B147225.62147124> dictionary33 = this.01546E90;
										num &= 453579164U;
										uint key31 = num + 3874946700U;
										num = 1359042806U * num;
										dictionary33[key31] = new 6B147225.62147124(this.1CF516A9);
										Dictionary<uint, 6B147225.62147124> dictionary34 = this.01546E90;
										num += 1461214670U;
										uint key32 = num ^ 1407107623U;
										num |= 980031475U;
										dictionary34[key32] = new 6B147225.62147124(this.7E752FE0);
										num ^= 1111850721U;
										this.01546E90[num - 968599796U] = new 6B147225.62147124(this.338E7468);
										num -= 934628717U;
										if (777915661U * num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary35 = this.01546E90;
										num += 1497764209U;
										uint key33 = num + 2763232009U;
										num >>= 0;
										dictionary35[key33] = new 6B147225.62147124(this.7DD5082A);
										if (51335079U == num)
										{
											goto IL_00;
										}
										num = 1818495427U + num;
										Dictionary<uint, 6B147225.62147124> dictionary36 = this.01546E90;
										uint key34 = num + 944736583U;
										num <<= 22;
										IntPtr 63FB2F3A16 = ldftn(548B3481);
										num |= 1889560054U;
										dictionary36[key34] = new 6B147225.62147124(this, 63FB2F3A16);
										num |= 393631590U;
										Dictionary<uint, 6B147225.62147124> dictionary37 = this.01546E90;
										uint key35 = num + 134842415U;
										num = 620068745U / num;
										num = 168373041U + num;
										IntPtr 63FB2F3A17 = ldftn(2CF451AF);
										num = (989076744U ^ num);
										dictionary37[key35] = new 6B147225.62147124(this, 63FB2F3A17);
										num = 329320052U + num;
										if (num % 1764968124U == 0U)
										{
											goto IL_00;
										}
										num *= 1066937204U;
										Dictionary<uint, 6B147225.62147124> dictionary38 = this.01546E90;
										num = 1349474359U << (int)num;
										uint key36 = num - 116753226U;
										num = 1672105264U / num;
										num <<= 28;
										dictionary38[key36] = new 6B147225.62147124(this.56AC6F55);
										Dictionary<uint, 6B147225.62147124> dictionary39 = this.01546E90;
										num >>= 16;
										uint key37 = num ^ 57383U;
										num = (688925663U ^ num);
										IntPtr 63FB2F3A18 = ldftn(1CF528B2);
										num = 424946649U - num;
										6B147225.62147124 value17 = new 6B147225.62147124(this, 63FB2F3A18);
										num = (283458862U | num);
										dictionary39[key37] = value17;
										num &= 1717574679U;
										Dictionary<uint, 6B147225.62147124> dictionary40 = this.01546E90;
										uint key38 = num + 2678055954U;
										num |= 1321342354U;
										dictionary40[key38] = new 6B147225.62147124(this.357734FC);
										num = 1081160058U / num;
										if (1401442847U == num)
										{
											goto IL_00;
										}
										num ^= 185337867U;
										Dictionary<uint, 6B147225.62147124> dictionary41 = this.01546E90;
										num -= 1714505824U;
										uint key39 = num + 1529167998U;
										6B147225.62147124 value18 = new 6B147225.62147124(this.73B51109);
										num ^= 2004776218U;
										dictionary41[key39] = value18;
										num >>= 2;
										num = (902390309U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary42 = this.01546E90;
										uint key40 = num - 18894943U;
										num = 1248729172U - num;
										num <<= 21;
										IntPtr 63FB2F3A19 = ldftn(5B1D16EA);
										num = (176895266U | num);
										6B147225.62147124 value19 = new 6B147225.62147124(this, 63FB2F3A19);
										num *= 1121128177U;
										dictionary42[key40] = value19;
										if (num % 1536100924U == 0U)
										{
											goto IL_19;
										}
										num /= 141839089U;
										Dictionary<uint, 6B147225.62147124> dictionary43 = this.01546E90;
										uint key41 = num - 4294967270U;
										num = 1437498343U / num;
										IntPtr 63FB2F3A20 = ldftn(26507E93);
										num = 996294502U + num;
										6B147225.62147124 value20 = new 6B147225.62147124(this, 63FB2F3A20);
										num >>= 3;
										dictionary43[key41] = value20;
										num *= 1065047679U;
										if (772554703U == num)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary44 = this.01546E90;
										uint key42 = num + 857154569U;
										num = 553601193U >> (int)num;
										num = 2101571210U % num;
										dictionary44[key42] = new 6B147225.62147124(this.11222D5E);
										if (1937187008U < num)
										{
											goto IL_19;
										}
										num += 1735864423U;
										Dictionary<uint, 6B147225.62147124> dictionary45 = this.01546E90;
										num = 726169327U / num;
										uint key43 = num + 45U;
										num = 1716719323U - num;
										6B147225.62147124 value21 = new 6B147225.62147124(this.0DCF157D);
										num = 2028936777U - num;
										dictionary45[key43] = value21;
										num = 1955101689U % num;
										Dictionary<uint, 6B147225.62147124> dictionary46 = this.01546E90;
										uint key44 = num ^ 81796939U;
										num /= 572796697U;
										IntPtr 63FB2F3A21 = ldftn(73FC179B);
										num = 750998714U + num;
										dictionary46[key44] = new 6B147225.62147124(this, 63FB2F3A21);
										Dictionary<uint, 6B147225.62147124> dictionary47 = this.01546E90;
										uint key45 = num ^ 750998677U;
										num += 480786043U;
										6B147225.62147124 value22 = new 6B147225.62147124(this.343307D2);
										num = 1023038641U >> (int)num;
										dictionary47[key45] = value22;
										num = 437533218U * num;
										if (1916296U >= num)
										{
											goto IL_00;
										}
										num /= 2063074425U;
										Dictionary<uint, 6B147225.62147124> dictionary48 = this.01546E90;
										num /= 1316253346U;
										uint key46 = num - 4294967248U;
										num = 1682005245U - num;
										6B147225.62147124 value23 = new 6B147225.62147124(this.33190BAC);
										num &= 1876917680U;
										dictionary48[key46] = value23;
										if (num >= 1944788753U)
										{
											break;
										}
										Dictionary<uint, 6B147225.62147124> dictionary49 = this.01546E90;
										uint key47 = num ^ 1682005121U;
										num *= 626080375U;
										dictionary49[key47] = new 6B147225.62147124(this.73290840);
										num <<= 28;
										num /= 1795296925U;
										Dictionary<uint, 6B147225.62147124> dictionary50 = this.01546E90;
										uint key48 = num - 4294967246U;
										num &= 1830552032U;
										num = 486027955U * num;
										IntPtr 63FB2F3A22 = ldftn(33CD2988);
										num /= 1131023542U;
										6B147225.62147124 value24 = new 6B147225.62147124(this, 63FB2F3A22);
										num += 832833750U;
										dictionary50[key48] = value24;
										num *= 2007708547U;
										Dictionary<uint, 6B147225.62147124> dictionary51 = this.01546E90;
										uint key49 = num - 1973757775U;
										num = 314140168U - num;
										num += 378537847U;
										6B147225.62147124 value25 = new 6B147225.62147124(this.62CE50CC);
										num &= 2140432813U;
										dictionary51[key49] = value25;
										num <<= 29;
										if (num < 512519584U)
										{
											goto IL_A7;
										}
										Dictionary<uint, 6B147225.62147124> dictionary52 = this.01546E90;
										num = 593103972U - num;
										uint key50 = num ^ 2203716688U;
										IntPtr 63FB2F3A23 = ldftn(5E2E6EC1);
										num >>= 31;
										6B147225.62147124 value26 = new 6B147225.62147124(this, 63FB2F3A23);
										num = 1512256660U + num;
										dictionary52[key50] = value26;
										num = 1902934338U >> (int)num;
										if (1368095439U < num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary53 = this.01546E90;
										num *= 1048202219U;
										uint key51 = num + 2763327132U;
										num += 349331429U;
										6B147225.62147124 value27 = new 6B147225.62147124(this.0C8C75E3);
										num /= 2117489578U;
										dictionary53[key51] = value27;
										if (num > 918047283U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary54 = this.01546E90;
										num = (1931825046U ^ num);
										uint key52 = num ^ 1931825056U;
										num = (2142855248U & num);
										IntPtr 63FB2F3A24 = ldftn(0B6F1D84);
										num ^= 1068448649U;
										6B147225.62147124 value28 = new 6B147225.62147124(this, 63FB2F3A24);
										num = 737427482U / num;
										dictionary54[key52] = value28;
										num = 1428776084U + num;
										this.01546E90[num + 2866191267U] = new 6B147225.62147124(this.0E0938F5);
										Dictionary<uint, 6B147225.62147124> dictionary55 = this.01546E90;
										num = (1545371637U ^ num);
										uint key53 = num - 154475305U;
										IntPtr 63FB2F3A25 = ldftn(42335B77);
										num = 41813461U * num;
										6B147225.62147124 value29 = new 6B147225.62147124(this, 63FB2F3A25);
										num *= 1405765345U;
										dictionary55[key53] = value29;
										Dictionary<uint, 6B147225.62147124> dictionary56 = this.01546E90;
										num = 2060478369U / num;
										uint key54 = num ^ 57U;
										num = 1257056482U + num;
										IntPtr 63FB2F3A26 = ldftn(794B7588);
										num = 744178940U * num;
										6B147225.62147124 value30 = new 6B147225.62147124(this, 63FB2F3A26);
										num = 1868044820U % num;
										dictionary56[key54] = value30;
										num |= 1606626158U;
										Dictionary<uint, 6B147225.62147124> dictionary57 = this.01546E90;
										uint key55 = num ^ 1609002964U;
										num ^= 1620132941U;
										6B147225.62147124 value31 = new 6B147225.62147124(this.6B7F3AD1);
										num = 1102461215U >> (int)num;
										dictionary57[key55] = value31;
										num *= 31545226U;
										if (num < 516966218U)
										{
											goto IL_19;
										}
										num = 488668753U * num;
										Dictionary<uint, 6B147225.62147124> dictionary58 = this.01546E90;
										uint key56 = num - 57530115U;
										num = 365393445U * num;
										num = 2140699352U >> (int)num;
										IntPtr 63FB2F3A27 = ldftn(084039F9);
										num = 2002139833U * num;
										6B147225.62147124 value32 = new 6B147225.62147124(this, 63FB2F3A27);
										num = 166820725U >> (int)num;
										dictionary58[key56] = value32;
										num = 456150587U % num;
										if (1579820610U < num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary59 = this.01546E90;
										uint key57 = num - 1003U;
										num %= 2008831324U;
										6B147225.62147124 value33 = new 6B147225.62147124(this.7FD16BED);
										num += 1035615588U;
										dictionary59[key57] = value33;
										num = 1815819480U - num;
										if (num == 747587165U)
										{
											goto IL_19;
										}
										num = 471936169U - num;
										Dictionary<uint, 6B147225.62147124> dictionary60 = this.01546E90;
										uint key58 = num - 3986700575U;
										num -= 84296876U;
										num ^= 445060011U;
										IntPtr 63FB2F3A28 = ldftn(7DF54037);
										num += 296223996U;
										dictionary60[key58] = new 6B147225.62147124(this, 63FB2F3A28);
										if (num / 1680354819U != 0U)
										{
											goto IL_00;
										}
										num = (1406285356U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary61 = this.01546E90;
										uint key59 = num ^ 1343543813U;
										num = 1970432056U >> (int)num;
										IntPtr 63FB2F3A29 = ldftn(685A48E2);
										num = (257369352U | num);
										6B147225.62147124 value34 = new 6B147225.62147124(this, 63FB2F3A29);
										num >>= 10;
										dictionary61[key59] = value34;
										num <<= 14;
										if (37052955U == num)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary62 = this.01546E90;
										uint key60 = num - 4117905345U;
										num = 980093145U << (int)num;
										num <<= 11;
										IntPtr 63FB2F3A30 = ldftn(355B0EF2);
										num -= 1240340555U;
										6B147225.62147124 value35 = new 6B147225.62147124(this, 63FB2F3A30);
										num = (528227971U & num);
										dictionary62[key60] = value35;
										if ((1356278219U & num) == 0U)
										{
											goto IL_19;
										}
										num >>= 31;
										this.01546E90[num - 4294967232U] = new 6B147225.62147124(this.340E502E);
										num = 1691291118U - num;
										if (num == 1111886872U)
										{
											goto IL_00;
										}
										num = (1891979585U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary63 = this.01546E90;
										num >>= 29;
										uint key61 = num + 65U;
										num >>= 26;
										num = 1524464049U - num;
										IntPtr 63FB2F3A31 = ldftn(22D146F6);
										num = 1024926144U << (int)num;
										dictionary63[key61] = new 6B147225.62147124(this, 63FB2F3A31);
										Dictionary<uint, 6B147225.62147124> dictionary64 = this.01546E90;
										num = (1133712108U ^ num);
										uint key62 = num - 1249962U;
										num = (688209584U | num);
										6B147225.62147124 value36 = new 6B147225.62147124(this.35E57C7B);
										num &= 1482778846U;
										dictionary64[key62] = value36;
										num = (1762208639U & num);
										Dictionary<uint, 6B147225.62147124> dictionary65 = this.01546E90;
										num %= 1108561995U;
										uint key63 = num + 4160673767U;
										num >>= 15;
										IntPtr 63FB2F3A32 = ldftn(081C3000);
										num ^= 738732903U;
										dictionary65[key63] = new 6B147225.62147124(this, 63FB2F3A32);
										num = 2079983689U << (int)num;
										num = 1137726834U * num;
										Dictionary<uint, 6B147225.62147124> dictionary66 = this.01546E90;
										uint key64 = num - 217952252U;
										num = (29379150U ^ num);
										num = 1259305500U % num;
										6B147225.62147124 value37 = new 6B147225.62147124(this.0F4079E7);
										num = (821590664U ^ num);
										dictionary66[key64] = value37;
										if (224283262U % num == 0U)
										{
											goto IL_00;
										}
										num = (1942706020U | num);
										Dictionary<uint, 6B147225.62147124> dictionary67 = this.01546E90;
										uint key65 = num ^ 2079063867U;
										num = 408116838U << (int)num;
										num <<= 15;
										IntPtr 63FB2F3A33 = ldftn(32024E8A);
										num = 1904347605U - num;
										6B147225.62147124 value38 = new 6B147225.62147124(this, 63FB2F3A33);
										num = (2003065531U | num);
										dictionary67[key65] = value38;
										num %= 548740104U;
										if (1559247591U < num)
										{
											goto IL_A7;
										}
										num >>= 22;
										Dictionary<uint, 6B147225.62147124> dictionary68 = this.01546E90;
										num <<= 14;
										uint key66 = num ^ 1425478U;
										num <<= 27;
										6B147225.62147124 value39 = new 6B147225.62147124(this.5DAD1526);
										num -= 321658018U;
										dictionary68[key66] = value39;
										Dictionary<uint, 6B147225.62147124> dictionary69 = this.01546E90;
										num %= 362877596U;
										uint key67 = num - 344533247U;
										num = 682245318U << (int)num;
										IntPtr 63FB2F3A34 = ldftn(5D4D68BE);
										num /= 122584035U;
										6B147225.62147124 value40 = new 6B147225.62147124(this, 63FB2F3A34);
										num <<= 28;
										dictionary69[key67] = value40;
										if ((num ^ 89349124U) == 0U)
										{
											goto IL_00;
										}
										num = (1366650756U | num);
										Dictionary<uint, 6B147225.62147124> dictionary70 = this.01546E90;
										num = (261575058U & num);
										uint key68 = num ^ 18170312U;
										num >>= 29;
										IntPtr 63FB2F3A35 = ldftn(287533B4);
										num /= 1489967588U;
										6B147225.62147124 value41 = new 6B147225.62147124(this, 63FB2F3A35);
										num ^= 767299085U;
										dictionary70[key68] = value41;
										num /= 2067020839U;
										num <<= 26;
										Dictionary<uint, 6B147225.62147124> dictionary71 = this.01546E90;
										num = (1569013494U & num);
										uint key69 = num ^ 73U;
										num /= 484336939U;
										6B147225.62147124 value42 = new 6B147225.62147124(this.27C365AB);
										num = 1362583078U - num;
										dictionary71[key69] = value42;
										num = 208539664U - num;
										Dictionary<uint, 6B147225.62147124> dictionary72 = this.01546E90;
										uint key70 = num ^ 3140923808U;
										num = 2119201808U << (int)num;
										dictionary72[key70] = new 6B147225.62147124(this.0AD64C7E);
										num <<= 19;
										if (319694818U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary73 = this.01546E90;
										uint key71 = num ^ 75U;
										num -= 479474568U;
										num = 494947759U + num;
										6B147225.62147124 value43 = new 6B147225.62147124(this.6CC86ABB);
										num -= 1509895732U;
										dictionary73[key71] = value43;
										num = 1373067157U >> (int)num;
										if (1090061335U <= num)
										{
											goto IL_19;
										}
										num *= 1260997268U;
										Dictionary<uint, 6B147225.62147124> dictionary74 = this.01546E90;
										uint key72 = num - 2755964220U;
										num = 1921676469U % num;
										num &= 1620591759U;
										IntPtr 63FB2F3A36 = ldftn(429E31B1);
										num -= 26035749U;
										dictionary74[key72] = new 6B147225.62147124(this, 63FB2F3A36);
										if (num <= 828931697U)
										{
											goto IL_00;
										}
										num <<= 14;
										Dictionary<uint, 6B147225.62147124> dictionary75 = this.01546E90;
										uint key73 = num - 3214409651U;
										num |= 117201638U;
										6B147225.62147124 value44 = new 6B147225.62147124(this.56C23C40);
										num += 235616207U;
										dictionary75[key73] = value44;
										num = 948179612U * num;
										Dictionary<uint, 6B147225.62147124> dictionary76 = this.01546E90;
										num = 1474910994U - num;
										uint key74 = num + 4200121736U;
										IntPtr 63FB2F3A37 = ldftn(6CC86ABB);
										num = 459500538U - num;
										dictionary76[key74] = new 6B147225.62147124(this, 63FB2F3A37);
										Dictionary<uint, 6B147225.62147124> dictionary77 = this.01546E90;
										num = 387585120U + num;
										uint key75 = num + 3542727355U;
										IntPtr 63FB2F3A38 = ldftn(477F2627);
										num |= 900093354U;
										6B147225.62147124 value45 = new 6B147225.62147124(this, 63FB2F3A38);
										num = 1806270202U + num;
										dictionary77[key75] = value45;
										num = (1074738820U ^ num);
										if (num >> 4 == 0U)
										{
											goto IL_65;
										}
										Dictionary<uint, 6B147225.62147124> dictionary78 = this.01546E90;
										uint key76 = num ^ 3918586476U;
										num = 1704680680U + num;
										num = 1434128133U + num;
										dictionary78[key76] = new 6B147225.62147124(this.27C365AB);
										num &= 1192384284U;
										num -= 1412577565U;
										Dictionary<uint, 6B147225.62147124> dictionary79 = this.01546E90;
										uint key77 = num - 2949647514U;
										num = 1212379398U % num;
										6B147225.62147124 value46 = new 6B147225.62147124(this.7E752FE0);
										num = 476655671U / num;
										dictionary79[key77] = value46;
										if (num >= 1307471283U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary80 = this.01546E90;
										num = (1118578773U & num);
										uint key78 = num + 82U;
										num *= 52639251U;
										IntPtr 63FB2F3A39 = ldftn(04422881);
										num ^= 845696065U;
										6B147225.62147124 value47 = new 6B147225.62147124(this, 63FB2F3A39);
										num = 1707160524U << (int)num;
										dictionary80[key78] = value47;
										Dictionary<uint, 6B147225.62147124> dictionary81 = this.01546E90;
										num &= 272833009U;
										dictionary81[num ^ 131523U] = new 6B147225.62147124(this.636B0497);
										num = 1463515429U * num;
										num *= 1905337301U;
										Dictionary<uint, 6B147225.62147124> dictionary82 = this.01546E90;
										uint key79 = num ^ 3337083460U;
										num = 704672395U + num;
										num %= 1497518648U;
										dictionary82[key79] = new 6B147225.62147124(this.5DAD1526);
										num ^= 1828926064U;
										if (77689337U > num)
										{
											goto IL_00;
										}
										num = 225206505U * num;
										Dictionary<uint, 6B147225.62147124> dictionary83 = this.01546E90;
										uint key80 = num ^ 3660749958U;
										num *= 2122259886U;
										num *= 423642685U;
										6B147225.62147124 value48 = new 6B147225.62147124(this.63C40051);
										num *= 1465277846U;
										dictionary83[key80] = value48;
										num = (2083157076U & num);
										if (num == 1416368687U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary84 = this.01546E90;
										num = (949566506U ^ num);
										uint key81 = num ^ 11750520U;
										num = (504854456U | num);
										6B147225.62147124 value49 = new 6B147225.62147124(this.59511227);
										num *= 230900449U;
										dictionary84[key81] = value49;
										num = (1076123273U ^ num);
										if (1259170224U >> (int)num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary85 = this.01546E90;
										uint key82 = num - 30676768U;
										IntPtr 63FB2F3A40 = ldftn(27C365AB);
										num = 1585386614U + num;
										dictionary85[key82] = new 6B147225.62147124(this, 63FB2F3A40);
										if (1415328263U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary86 = this.01546E90;
										uint key83 = num ^ 1616063413U;
										num = 444531234U / num;
										6B147225.62147124 value50 = new 6B147225.62147124(this.33CD2988);
										num -= 348412785U;
										dictionary86[key83] = value50;
										num = (1726696567U | num);
										if (num < 291647165U)
										{
											goto IL_00;
										}
										num = 1226442634U - num;
										Dictionary<uint, 6B147225.62147124> dictionary87 = this.01546E90;
										num %= 1378231586U;
										uint key84 = num ^ 116913456U;
										num = 4850308U - num;
										IntPtr 63FB2F3A41 = ldftn(46675BC7);
										num += 685926512U;
										dictionary87[key84] = new 6B147225.62147124(this, 63FB2F3A41);
										num = 2087742239U % num;
										num = 161307207U << (int)num;
										Dictionary<uint, 6B147225.62147124> dictionary88 = this.01546E90;
										uint key85 = num + 1073741914U;
										num &= 632504542U;
										num *= 1869746635U;
										dictionary88[key85] = new 6B147225.62147124(this.357734FC);
										num -= 469053998U;
										num = (1206462077U | num);
										Dictionary<uint, 6B147225.62147124> dictionary89 = this.01546E90;
										uint key86 = num - 3890999204U;
										num = 1134431242U / num;
										IntPtr 63FB2F3A42 = ldftn(2014144B);
										num &= 1966422357U;
										6B147225.62147124 value51 = new 6B147225.62147124(this, 63FB2F3A42);
										num = 2065643433U << (int)num;
										dictionary89[key86] = value51;
										num += 345337824U;
										Dictionary<uint, 6B147225.62147124> dictionary90 = this.01546E90;
										uint key87 = num ^ 2410981333U;
										IntPtr 63FB2F3A43 = ldftn(0DCF157D);
										num = 740296839U * num;
										6B147225.62147124 value52 = new 6B147225.62147124(this, 63FB2F3A43);
										num = (432428587U ^ num);
										dictionary90[key87] = value52;
										num = 1621102585U >> (int)num;
										num = 1132096520U >> (int)num;
										Dictionary<uint, 6B147225.62147124> dictionary91 = this.01546E90;
										uint key88 = num - 1105470U;
										num = 768243654U % num;
										dictionary91[key88] = new 6B147225.62147124(this.477F2627);
										num += 1617916260U;
										if (num > 1773825221U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary92 = this.01546E90;
										uint key89 = num - 1618899098U;
										num = 621629276U << (int)num;
										IntPtr 63FB2F3A44 = ldftn(7DD5082A);
										num = (414804199U & num);
										6B147225.62147124 value53 = new 6B147225.62147124(this, 63FB2F3A44);
										num = 1162809996U * num;
										dictionary92[key89] = value53;
										num /= 728842975U;
										if (1299725143 << (int)num == 0)
										{
											goto IL_00;
										}
										num += 53491958U;
										Dictionary<uint, 6B147225.62147124> dictionary93 = this.01546E90;
										num -= 1548771242U;
										uint key90 = num - 2799687917U;
										num %= 2105214450U;
										IntPtr 63FB2F3A45 = ldftn(27C365AB);
										num ^= 355559488U;
										6B147225.62147124 value54 = new 6B147225.62147124(this, 63FB2F3A45);
										num = 412311306U / num;
										dictionary93[key90] = value54;
										num = (1238590228U | num);
										Dictionary<uint, 6B147225.62147124> dictionary94 = this.01546E90;
										num &= 1764981286U;
										uint key91 = num ^ 1226007140U;
										num = 1072766259U * num;
										num = (1107439834U ^ num);
										dictionary94[key91] = new 6B147225.62147124(this.42335B77);
										num = 782120308U << (int)num;
										this.01546E90[num ^ 1560281185U] = new 6B147225.62147124(this.0C8C75E3);
										if ((449920240U ^ num) == 0U)
										{
											goto IL_19;
										}
										num |= 1312386908U;
										Dictionary<uint, 6B147225.62147124> dictionary95 = this.01546E90;
										uint key92 = num - 1597599482U;
										num %= 218059283U;
										num -= 617563204U;
										IntPtr 63FB2F3A46 = ldftn(27C365AB);
										num <<= 31;
										dictionary95[key92] = new 6B147225.62147124(this, 63FB2F3A46);
										if (2040750646 << (int)num == 0)
										{
											goto IL_19;
										}
										num /= 1555901086U;
										Dictionary<uint, 6B147225.62147124> dictionary96 = this.01546E90;
										uint key93 = num + 98U;
										num = (620183084U & num);
										num <<= 15;
										IntPtr 63FB2F3A47 = ldftn(2014144B);
										num = (189599902U & num);
										6B147225.62147124 value55 = new 6B147225.62147124(this, 63FB2F3A47);
										num = 163857659U >> (int)num;
										dictionary96[key93] = value55;
										num &= 1426873345U;
										Dictionary<uint, 6B147225.62147124> dictionary97 = this.01546E90;
										num = 1260721036U * num;
										uint key94 = num ^ 4270212072U;
										num <<= 26;
										dictionary97[key94] = new 6B147225.62147124(this.104C242D);
										if (167537838 << (int)num == 0)
										{
											goto IL_00;
										}
										num = (1236747429U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary98 = this.01546E90;
										num = 1458666892U >> (int)num;
										uint key95 = num ^ 45583241U;
										num = 1087965211U % num;
										num = 1168051782U - num;
										dictionary98[key95] = new 6B147225.62147124(this.19D279C4);
										if (1712206488U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary99 = this.01546E90;
										num <<= 1;
										uint key96 = num ^ 2257006808U;
										IntPtr 63FB2F3A48 = ldftn(59511227);
										num ^= 928986111U;
										6B147225.62147124 value56 = new 6B147225.62147124(this, 63FB2F3A48);
										num -= 1116941974U;
										dictionary99[key96] = value56;
										num |= 1545554395U;
										if (num < 1825648609U)
										{
											goto IL_00;
										}
										num += 1179255344U;
										Dictionary<uint, 6B147225.62147124> dictionary100 = this.01546E90;
										uint key97 = num ^ 3316244556U;
										num += 961371527U;
										IntPtr 63FB2F3A49 = ldftn(63C40051);
										num -= 1587694147U;
										6B147225.62147124 value57 = new 6B147225.62147124(this, 63FB2F3A49);
										num = 1652508768U * num;
										dictionary100[key97] = value57;
										Dictionary<uint, 6B147225.62147124> dictionary101 = this.01546E90;
										uint key98 = num + 3114041032U;
										num <<= 12;
										6B147225.62147124 value58 = new 6B147225.62147124(this.084039F9);
										num = 423783949U / num;
										dictionary101[key98] = value58;
										num &= 810755560U;
										Dictionary<uint, 6B147225.62147124> dictionary102 = this.01546E90;
										uint key99 = num - 4294967191U;
										IntPtr 63FB2F3A50 = ldftn(7DD5082A);
										num = 1116354314U + num;
										dictionary102[key99] = new 6B147225.62147124(this, 63FB2F3A50);
										if (num - 688135456U == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary103 = this.01546E90;
										num <<= 25;
										uint key100 = num ^ 335544426U;
										num = 1769290853U + num;
										dictionary103[key100] = new 6B147225.62147124(this.104C242D);
										if (383086661U * num == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary104 = this.01546E90;
										num = (1392517866U | num);
										uint key101 = num - 2138390148U;
										num = 714633497U * num;
										dictionary104[key101] = new 6B147225.62147124(this.7DD5082A);
										num ^= 2130659250U;
										Dictionary<uint, 6B147225.62147124> dictionary105 = this.01546E90;
										uint key102 = num ^ 3118326665U;
										num = (483662849U ^ num);
										IntPtr 63FB2F3A51 = ldftn(27C365AB);
										num += 57292790U;
										dictionary105[key102] = new 6B147225.62147124(this, 63FB2F3A51);
										num += 1712655342U;
										Dictionary<uint, 6B147225.62147124> dictionary106 = this.01546E90;
										uint key103 = num ^ 243876773U;
										num += 1405231511U;
										IntPtr 63FB2F3A52 = ldftn(33391827);
										num -= 1327263810U;
										6B147225.62147124 value59 = new 6B147225.62147124(this, 63FB2F3A52);
										num = 1583245605U % num;
										dictionary106[key103] = value59;
										if (num == 1605380563U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary107 = this.01546E90;
										uint key104 = num ^ 295867615U;
										num ^= 139476272U;
										num &= 1592204101U;
										dictionary107[key104] = new 6B147225.62147124(this.1CF516A9);
										if (1558668645U >> (int)num == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary108 = this.01546E90;
										num = (1808599026U | num);
										uint key105 = num - 2079264644U;
										num |= 202116193U;
										IntPtr 63FB2F3A53 = ldftn(7E752FE0);
										num += 1480737781U;
										6B147225.62147124 value60 = new 6B147225.62147124(this, 63FB2F3A53);
										num = 213269349U / num;
										dictionary108[key105] = value60;
										num /= 1924870805U;
										Dictionary<uint, 6B147225.62147124> dictionary109 = this.01546E90;
										uint key106 = num + 112U;
										6B147225.62147124 value61 = new 6B147225.62147124(this.477F2627);
										num = 346110141U >> (int)num;
										dictionary109[key106] = value61;
										num = 291793466U * num;
										num %= 1299909084U;
										Dictionary<uint, 6B147225.62147124> dictionary110 = this.01546E90;
										num *= 663492151U;
										uint key107 = num ^ 1408712047U;
										num = 482296400U / num;
										num += 1061229088U;
										6B147225.62147124 value62 = new 6B147225.62147124(this.19D279C4);
										num %= 210722885U;
										dictionary110[key107] = value62;
										if (num > 560554088U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary111 = this.01546E90;
										num = 1978533218U * num;
										uint key108 = num + 1116696900U;
										num <<= 22;
										num = 636427640U / num;
										IntPtr 63FB2F3A54 = ldftn(794B7588);
										num = 34567249U * num;
										6B147225.62147124 value63 = new 6B147225.62147124(this, 63FB2F3A54);
										num = 1793731182U >> (int)num;
										dictionary111[key108] = value63;
										if ((num ^ 754340281U) == 0U)
										{
											goto IL_78;
										}
										num -= 1582959980U;
										Dictionary<uint, 6B147225.62147124> dictionary112 = this.01546E90;
										num = 1779971863U + num;
										uint key109 = num + 2304224346U;
										num = (309554822U & num);
										dictionary112[key109] = new 6B147225.62147124(this.04ED7FCC);
										num = (1807311815U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary113 = this.01546E90;
										num = 1072327840U >> (int)num;
										uint key110 = num ^ 8377517U;
										IntPtr 63FB2F3A55 = ldftn(59511227);
										num = 16865263U - num;
										dictionary113[key110] = new 6B147225.62147124(this, 63FB2F3A55);
										if (num >= 780163698U)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary114 = this.01546E90;
										uint key111 = num - 8487585U;
										num = (1237133553U & num);
										IntPtr 63FB2F3A56 = ldftn(04ED7FCC);
										num /= 1289880906U;
										6B147225.62147124 value64 = new 6B147225.62147124(this, 63FB2F3A56);
										num = 224669784U << (int)num;
										dictionary114[key111] = value64;
										Dictionary<uint, 6B147225.62147124> dictionary115 = this.01546E90;
										uint key112 = num ^ 224669742U;
										num = 2035967588U + num;
										IntPtr 63FB2F3A57 = ldftn(0E0938F5);
										num = 614627118U << (int)num;
										6B147225.62147124 value65 = new 6B147225.62147124(this, 63FB2F3A57);
										num = 879905795U * num;
										dictionary115[key112] = value65;
										Dictionary<uint, 6B147225.62147124> dictionary116 = this.01546E90;
										uint key113 = num + 1610612855U;
										num = 1849562800U + num;
										num = (171657379U & num);
										IntPtr 63FB2F3A58 = ldftn(104C242D);
										num |= 1886664950U;
										6B147225.62147124 value66 = new 6B147225.62147124(this, 63FB2F3A58);
										num /= 1490575454U;
										dictionary116[key113] = value66;
										num |= 88631732U;
										if (num / 1310395511U != 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary117 = this.01546E90;
										num = 2001168044U + num;
										uint key114 = num ^ 2089799705U;
										num = (1248529943U ^ num);
										6B147225.62147124 value67 = new 6B147225.62147124(this.63C40051);
										num = 1150812631U << (int)num;
										dictionary117[key114] = value67;
										this.01546E90[num ^ 1975517305U] = new 6B147225.62147124(this.27C365AB);
										if (num << 14 != 0U)
										{
											goto IL_A7;
										}
										Dictionary<uint, 6B147225.62147124> dictionary118 = this.01546E90;
										num = (1620143423U | num);
										uint key115 = num - 1976659141U;
										num <<= 6;
										num /= 108799124U;
										dictionary118[key115] = new 6B147225.62147124(this.11222D5E);
										num &= 2059934216U;
										num -= 2025596009U;
										Dictionary<uint, 6B147225.62147124> dictionary119 = this.01546E90;
										num += 872755885U;
										uint key116 = num - 3142127049U;
										num *= 2035224916U;
										num |= 1300722706U;
										dictionary119[key116] = new 6B147225.62147124(this.104C242D);
										num = 1672032691U - num;
										this.01546E90[num ^ 2244066077U] = new 6B147225.62147124(this.04422881);
										num |= 1155088383U;
										if (num << 15 == 0U)
										{
											goto IL_00;
										}
										num *= 74131133U;
										Dictionary<uint, 6B147225.62147124> dictionary120 = this.01546E90;
										num = 1854937152U >> (int)num;
										uint key117 = num ^ 231867253U;
										num >>= 8;
										IntPtr 63FB2F3A59 = ldftn(32024E8A);
										num += 512246895U;
										6B147225.62147124 value68 = new 6B147225.62147124(this, 63FB2F3A59);
										num >>= 1;
										dictionary120[key117] = value68;
										num = 1752572356U - num;
										Dictionary<uint, 6B147225.62147124> dictionary121 = this.01546E90;
										num = 1583119438U % num;
										uint key118 = num ^ 87123389U;
										num = 133972348U / num;
										6B147225.62147124 value69 = new 6B147225.62147124(this.73FC179B);
										num |= 1039684138U;
										dictionary121[key118] = value69;
										if (num >> 1 == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary122 = this.01546E90;
										num >>= 8;
										uint key119 = num - 4061139U;
										num /= 2119063071U;
										num -= 639763977U;
										dictionary122[key119] = new 6B147225.62147124(this.56C23C40);
										if (1125274666 << (int)num == 0)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary123 = this.01546E90;
										uint key120 = num ^ 3655203191U;
										num ^= 1379797549U;
										IntPtr 63FB2F3A60 = ldftn(1CF528B2);
										num += 980365983U;
										6B147225.62147124 value70 = new 6B147225.62147124(this, 63FB2F3A60);
										num /= 818748162U;
										dictionary123[key120] = value70;
										if (1086859519U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary124 = this.01546E90;
										uint key121 = num ^ 133U;
										6B147225.62147124 value71 = new 6B147225.62147124(this.26507E93);
										num >>= 31;
										dictionary124[key121] = value71;
										if (1926704118U < num)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary125 = this.01546E90;
										num = 680943501U >> (int)num;
										uint key122 = num - 680943371U;
										num &= 1075381373U;
										IntPtr 63FB2F3A61 = ldftn(27C365AB);
										num = 774260961U - num;
										6B147225.62147124 value72 = new 6B147225.62147124(this, 63FB2F3A61);
										num %= 1150752051U;
										dictionary125[key122] = value72;
										num = 688007517U % num;
										Dictionary<uint, 6B147225.62147124> dictionary126 = this.01546E90;
										num |= 2134971762U;
										uint key123 = num - 2135112956U;
										num = (2004354101U ^ num);
										num %= 872693710U;
										6B147225.62147124 value73 = new 6B147225.62147124(this.477F2627);
										num = 7604366U - num;
										dictionary126[key123] = value73;
										Dictionary<uint, 6B147225.62147124> dictionary127 = this.01546E90;
										uint key124 = num + 130494784U;
										num >>= 14;
										num |= 296169697U;
										dictionary127[key124] = new 6B147225.62147124(this.7DD5082A);
										if (num - 1929717349U == 0U)
										{
											goto IL_44;
										}
										num = 429751978U % num;
										Dictionary<uint, 6B147225.62147124> dictionary128 = this.01546E90;
										uint key125 = num - 133532994U;
										num = 755893403U >> (int)num;
										num = 1029003980U + num;
										6B147225.62147124 value74 = new 6B147225.62147124(this.084039F9);
										num = 1502248441U % num;
										dictionary128[key125] = value74;
										num = 1452505498U + num;
										if (num % 2027570343U == 0U)
										{
											goto IL_00;
										}
										num &= 78342165U;
										Dictionary<uint, 6B147225.62147124> dictionary129 = this.01546E90;
										num = (890065266U | num);
										uint key126 = num + 3402673936U;
										num &= 1642147840U;
										dictionary129[key126] = new 6B147225.62147124(this.7DA75F08);
										Dictionary<uint, 6B147225.62147124> dictionary130 = this.01546E90;
										uint key127 = num + 3739152519U;
										num = 365575492U * num;
										6B147225.62147124 value75 = new 6B147225.62147124(this.5B1D16EA);
										num = (23161831U | num);
										dictionary130[key127] = value75;
										num >>= 30;
										num ^= 990400567U;
										Dictionary<uint, 6B147225.62147124> dictionary131 = this.01546E90;
										uint key128 = num ^ 990400702U;
										num = 2015496228U / num;
										6B147225.62147124 value76 = new 6B147225.62147124(this.62CE50CC);
										num = 296318400U + num;
										dictionary131[key128] = value76;
										num |= 738930686U;
										num = (564338441U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary132 = this.01546E90;
										num += 222318333U;
										uint key129 = num - 692629355U;
										IntPtr 63FB2F3A62 = ldftn(04ED7FCC);
										num ^= 1975804855U;
										dictionary132[key129] = new 6B147225.62147124(this, 63FB2F3A62);
										num += 1769341002U;
										Dictionary<uint, 6B147225.62147124> dictionary133 = this.01546E90;
										num <<= 14;
										uint key130 = num + 1289535626U;
										num += 144080508U;
										IntPtr 63FB2F3A63 = ldftn(357734FC);
										num ^= 667626806U;
										6B147225.62147124 value77 = new 6B147225.62147124(this, 63FB2F3A63);
										num = 1642941997U + num;
										dictionary133[key130] = value77;
										num <<= 2;
										if ((num ^ 1729063758U) == 0U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary134 = this.01546E90;
										uint key131 = num ^ 4185883991U;
										6B147225.62147124 value78 = new 6B147225.62147124(this.1CF528B2);
										num = (924652375U ^ num);
										dictionary134[key131] = value78;
										num += 1454654827U;
										if ((num ^ 1071461972U) == 0U)
										{
											goto IL_19;
										}
										num = 12721924U - num;
										Dictionary<uint, 6B147225.62147124> dictionary135 = this.01546E90;
										num = 1825405385U - num;
										uint key132 = num ^ 2434938423U;
										num = 1308443137U / num;
										IntPtr 63FB2F3A64 = ldftn(63C40051);
										num = 569051156U + num;
										6B147225.62147124 value79 = new 6B147225.62147124(this, 63FB2F3A64);
										num = 217060832U >> (int)num;
										dictionary135[key132] = value79;
										num |= 1654213940U;
										num = 2020239874U << (int)num;
										Dictionary<uint, 6B147225.62147124> dictionary136 = this.01546E90;
										uint key133 = num ^ 141U;
										6B147225.62147124 value80 = new 6B147225.62147124(this.084039F9);
										num -= 1559302919U;
										dictionary136[key133] = value80;
										num = 1650008405U << (int)num;
										if (289224210U >= num)
										{
											goto IL_65;
										}
										num = 1870687808U + num;
										Dictionary<uint, 6B147225.62147124> dictionary137 = this.01546E90;
										num |= 940462888U;
										uint key134 = num + 3329327398U;
										num += 204103757U;
										6B147225.62147124 value81 = new 6B147225.62147124(this.26507E93);
										num += 1992119125U;
										dictionary137[key134] = value81;
										num |= 1946381871U;
										num = 705379724U % num;
										Dictionary<uint, 6B147225.62147124> dictionary138 = this.01546E90;
										num += 66674296U;
										uint key135 = num ^ 772054155U;
										num >>= 25;
										6B147225.62147124 value82 = new 6B147225.62147124(this.2CF451AF);
										num -= 635326220U;
										dictionary138[key135] = value82;
										num >>= 3;
										if (1465191453U / num == 0U)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary139 = this.01546E90;
										num |= 241723910U;
										uint key136 = num ^ 527204023U;
										num ^= 848391965U;
										num = 182339854U >> (int)num;
										IntPtr 63FB2F3A65 = ldftn(35E57C7B);
										num = 1706588956U >> (int)num;
										dictionary139[key136] = new 6B147225.62147124(this, 63FB2F3A65);
										if (num >= 830372403U)
										{
											goto IL_65;
										}
										num += 2117089360U;
										Dictionary<uint, 6B147225.62147124> dictionary140 = this.01546E90;
										num /= 527650766U;
										uint key137 = num - 4294967155U;
										num = 1385431848U % num;
										6B147225.62147124 value83 = new 6B147225.62147124(this.04ED7FCC);
										num = 1584727573U << (int)num;
										dictionary140[key137] = value83;
										num += 1116406330U;
										if (num <= 729251023U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary141 = this.01546E90;
										num &= 1992368350U;
										uint key138 = num - 536870844U;
										num %= 289746011U;
										IntPtr 63FB2F3A66 = ldftn(63C40051);
										num ^= 604841505U;
										6B147225.62147124 value84 = new 6B147225.62147124(this, 63FB2F3A66);
										num = (175583287U | num);
										dictionary141[key138] = value84;
										num >>= 12;
										if (1018189779U < num)
										{
											goto IL_00;
										}
										num = (567891978U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary142 = this.01546E90;
										num = 1483237415U % num;
										uint key139 = num + 3947857750U;
										num = (1732666414U & num);
										dictionary142[key139] = new 6B147225.62147124(this.73B51109);
										num += 522206143U;
										if (num * 1133723349U == 0U)
										{
											goto IL_19;
										}
										num >>= 6;
										Dictionary<uint, 6B147225.62147124> dictionary143 = this.01546E90;
										num = 70081471U + num;
										uint key140 = num ^ 79290042U;
										num = 525039675U + num;
										num = 171983305U % num;
										IntPtr 63FB2F3A67 = ldftn(1CF516A9);
										num &= 805586938U;
										dictionary143[key140] = new 6B147225.62147124(this, 63FB2F3A67);
										Dictionary<uint, 6B147225.62147124> dictionary144 = this.01546E90;
										uint key141 = num ^ 16733U;
										num >>= 6;
										num = 2120500781U % num;
										IntPtr 63FB2F3A68 = ldftn(04ED7FCC);
										num = (1571951564U ^ num);
										6B147225.62147124 value85 = new 6B147225.62147124(this, 63FB2F3A68);
										num = 934428459U << (int)num;
										dictionary144[key141] = value85;
										num = (1027542581U & num);
										Dictionary<uint, 6B147225.62147124> dictionary145 = this.01546E90;
										num -= 1969246007U;
										uint key142 = num ^ 2412032095U;
										num = 1921647517U >> (int)num;
										IntPtr 63FB2F3A69 = ldftn(5605518D);
										num = 332363982U >> (int)num;
										6B147225.62147124 value86 = new 6B147225.62147124(this, 63FB2F3A69);
										num = (1523594239U ^ num);
										dictionary145[key142] = value86;
										if (977669189U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary146 = this.01546E90;
										num %= 568201284U;
										uint key143 = num + 4035219847U;
										num >>= 26;
										dictionary146[key143] = new 6B147225.62147124(this.73FC179B);
										if (num >= 430980061U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary147 = this.01546E90;
										uint key144 = num ^ 155U;
										num *= 2131709820U;
										6B147225.62147124 value87 = new 6B147225.62147124(this.7DD5082A);
										num = 1760974643U * num;
										dictionary147[key144] = value87;
										num = 924583772U / num;
										num = 842227466U * num;
										Dictionary<uint, 6B147225.62147124> dictionary148 = this.01546E90;
										num &= 1460211790U;
										uint key145 = num + 153U;
										num *= 195191194U;
										num = 1941450822U >> (int)num;
										6B147225.62147124 value88 = new 6B147225.62147124(this.23C57035);
										num = 14436663U / num;
										dictionary148[key145] = value88;
										Dictionary<uint, 6B147225.62147124> dictionary149 = this.01546E90;
										num = 2111118336U + num;
										uint key146 = num + 2183849114U;
										num <<= 3;
										dictionary149[key146] = new 6B147225.62147124(this.548B3481);
										Dictionary<uint, 6B147225.62147124> dictionary150 = this.01546E90;
										num += 49231950U;
										uint key147 = num - 4053276595U;
										num >>= 20;
										IntPtr 63FB2F3A70 = ldftn(7DD5082A);
										num = (260200290U & num);
										6B147225.62147124 value89 = new 6B147225.62147124(this, 63FB2F3A70);
										num |= 587731766U;
										dictionary150[key147] = value89;
										num >>= 2;
										Dictionary<uint, 6B147225.62147124> dictionary151 = this.01546E90;
										num >>= 7;
										uint key148 = num - 1147759U;
										num %= 1435663300U;
										6B147225.62147124 value90 = new 6B147225.62147124(this.084039F9);
										num ^= 1706492162U;
										dictionary151[key148] = value90;
										num |= 245044893U;
										Dictionary<uint, 6B147225.62147124> dictionary152 = this.01546E90;
										uint key149 = num - 1874827008U;
										num = 1735205187U >> (int)num;
										6B147225.62147124 value91 = new 6B147225.62147124(this.04422881);
										num = (1641434714U & num);
										dictionary152[key149] = value91;
										num -= 1843030116U;
										Dictionary<uint, 6B147225.62147124> dictionary153 = this.01546E90;
										uint key150 = num ^ 2451937024U;
										num -= 1957831180U;
										6B147225.62147124 value92 = new 6B147225.62147124(this.7DA75F08);
										num = 1174952288U << (int)num;
										dictionary153[key150] = value92;
										num ^= 1770211566U;
										Dictionary<uint, 6B147225.62147124> dictionary154 = this.01546E90;
										uint key151 = num + 4093425585U;
										num = 2136353623U - num;
										dictionary154[key151] = new 6B147225.62147124(this.59511227);
										if (num < 1304233288U)
										{
											goto IL_00;
										}
										num = 1961380301U << (int)num;
										Dictionary<uint, 6B147225.62147124> dictionary155 = this.01546E90;
										num -= 1522348993U;
										uint key152 = num ^ 1976985247U;
										num |= 1020920563U;
										num = 997463872U >> (int)num;
										IntPtr 63FB2F3A71 = ldftn(35E57C7B);
										num -= 901145514U;
										dictionary155[key152] = new 6B147225.62147124(this, 63FB2F3A71);
										num += 1296312910U;
										if (1460281547U - num == 0U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary156 = this.01546E90;
										uint key153 = num ^ 395167237U;
										IntPtr 63FB2F3A72 = ldftn(04ED7FCC);
										num &= 1167079500U;
										6B147225.62147124 value93 = new 6B147225.62147124(this, 63FB2F3A72);
										num = 669938513U % num;
										dictionary156[key153] = value93;
										Dictionary<uint, 6B147225.62147124> dictionary157 = this.01546E90;
										num &= 170868630U;
										uint key154 = num + 4291939726U;
										num = 1917739549U >> (int)num;
										num /= 1989490353U;
										dictionary157[key154] = new 6B147225.62147124(this.041073EB);
										num >>= 5;
										Dictionary<uint, 6B147225.62147124> dictionary158 = this.01546E90;
										uint key155 = num ^ 163U;
										num = (1092696963U | num);
										num <<= 19;
										6B147225.62147124 value94 = new 6B147225.62147124(this.0B6F1D84);
										num /= 230425447U;
										dictionary158[key155] = value94;
										Dictionary<uint, 6B147225.62147124> dictionary159 = this.01546E90;
										uint key156 = num ^ 180U;
										num = (476473670U & num);
										6B147225.62147124 value95 = new 6B147225.62147124(this.0E0938F5);
										num &= 1833242791U;
										dictionary159[key156] = value95;
										num ^= 1623933035U;
										num |= 449668642U;
										Dictionary<uint, 6B147225.62147124> dictionary160 = this.01546E90;
										uint key157 = num + 2234554938U;
										num = 1261270056U << (int)num;
										IntPtr 63FB2F3A73 = ldftn(04ED7FCC);
										num ^= 1239907874U;
										dictionary160[key157] = new 6B147225.62147124(this, 63FB2F3A73);
										if (351688466U == num)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary161 = this.01546E90;
										uint key158 = num ^ 575028868U;
										num /= 225080209U;
										IntPtr 63FB2F3A74 = ldftn(35E57C7B);
										num >>= 4;
										dictionary161[key158] = new 6B147225.62147124(this, 63FB2F3A74);
										if (1555127414U <= num)
										{
											goto IL_A7;
										}
										Dictionary<uint, 6B147225.62147124> dictionary162 = this.01546E90;
										num = (1296631592U ^ num);
										uint key159 = num ^ 1296631695U;
										6B147225.62147124 value96 = new 6B147225.62147124(this.357734FC);
										num ^= 613892440U;
										dictionary162[key159] = value96;
										if ((1970608945U ^ num) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary163 = this.01546E90;
										num ^= 1575762093U;
										uint key160 = num - 875724341U;
										num *= 550440610U;
										6B147225.62147124 value97 = new 6B147225.62147124(this.63C40051);
										num = 324407413U >> (int)num;
										dictionary163[key160] = value97;
										num <<= 27;
										Dictionary<uint, 6B147225.62147124> dictionary164 = this.01546E90;
										num &= 909777251U;
										uint key161 = num + 3758096553U;
										IntPtr 63FB2F3A75 = ldftn(63C40051);
										num = 645620959U - num;
										6B147225.62147124 value98 = new 6B147225.62147124(this, 63FB2F3A75);
										num ^= 1837333738U;
										dictionary164[key161] = value98;
										Dictionary<uint, 6B147225.62147124> dictionary165 = this.01546E90;
										uint key162 = num + 2483546229U;
										num = 65101336U % num;
										IntPtr 63FB2F3A76 = ldftn(1CF516A9);
										num %= 1827879500U;
										dictionary165[key162] = new 6B147225.62147124(this, 63FB2F3A76);
										if (1184396719U <= num)
										{
											goto IL_78;
										}
										num = 569853105U << (int)num;
										Dictionary<uint, 6B147225.62147124> dictionary166 = this.01546E90;
										uint key163 = num ^ 2969567403U;
										num = 896533884U >> (int)num;
										num |= 1731924786U;
										IntPtr 63FB2F3A77 = ldftn(0E0938F5);
										num %= 928121099U;
										6B147225.62147124 value99 = new 6B147225.62147124(this, 63FB2F3A77);
										num = 1286807688U * num;
										dictionary166[key163] = value99;
										num = 1757611006U + num;
										num ^= 700987159U;
										Dictionary<uint, 6B147225.62147124> dictionary167 = this.01546E90;
										num = 1567508304U << (int)num;
										uint key164 = num - 3700334420U;
										num %= 1665539194U;
										num %= 524493113U;
										6B147225.62147124 value100 = new 6B147225.62147124(this.357734FC);
										num |= 2074503893U;
										dictionary167[key164] = value100;
										num = 409557415U % num;
										num %= 1507599741U;
										Dictionary<uint, 6B147225.62147124> dictionary168 = this.01546E90;
										uint key165 = num - 409557242U;
										num |= 1085699934U;
										num = (133240700U ^ num);
										6B147225.62147124 value101 = new 6B147225.62147124(this.32024E8A);
										num = 502399680U << (int)num;
										dictionary168[key165] = value101;
										Dictionary<uint, 6B147225.62147124> dictionary169 = this.01546E90;
										num ^= 373914231U;
										uint key166 = num ^ 4191775961U;
										num /= 906198698U;
										num = 266543425U << (int)num;
										dictionary169[key166] = new 6B147225.62147124(this.27C365AB);
										num &= 1677087859U;
										Dictionary<uint, 6B147225.62147124> dictionary170 = this.01546E90;
										num <<= 21;
										uint key167 = num - 2181037905U;
										num -= 2008249414U;
										IntPtr 63FB2F3A78 = ldftn(23C57035);
										num = (1790445804U ^ num);
										dictionary170[key167] = new 6B147225.62147124(this, 63FB2F3A78);
										num = (915804864U ^ num);
										if (num == 1309877805U)
										{
											goto IL_00;
										}
										num >>= 30;
										Dictionary<uint, 6B147225.62147124> dictionary171 = this.01546E90;
										uint key168 = num + 175U;
										num ^= 1064186942U;
										IntPtr 63FB2F3A79 = ldftn(7E752FE0);
										num = (1599679812U | num);
										6B147225.62147124 value102 = new 6B147225.62147124(this, 63FB2F3A79);
										num = (198986320U ^ num);
										dictionary171[key168] = value102;
										if (1682777355U >> (int)num == 0U)
										{
											goto IL_19;
										}
										num -= 930563258U;
										Dictionary<uint, 6B147225.62147124> dictionary172 = this.01546E90;
										uint key169 = num + 3268660796U;
										num = 1660491194U >> (int)num;
										IntPtr 63FB2F3A80 = ldftn(32024E8A);
										num = 1743259956U / num;
										6B147225.62147124 value103 = new 6B147225.62147124(this, 63FB2F3A80);
										num -= 993539121U;
										dictionary172[key169] = value103;
										Dictionary<uint, 6B147225.62147124> dictionary173 = this.01546E90;
										num = 567043901U >> (int)num;
										uint key170 = num + 4294690598U;
										num = 813449585U >> (int)num;
										IntPtr 63FB2F3A81 = ldftn(56C23C40);
										num |= 982153293U;
										dictionary173[key170] = new 6B147225.62147124(this, 63FB2F3A81);
										num -= 1433299830U;
										num *= 82642435U;
										Dictionary<uint, 6B147225.62147124> dictionary174 = this.01546E90;
										uint key171 = num ^ 2388412342U;
										num = (489321176U & num);
										6B147225.62147124 value104 = new 6B147225.62147124(this.04422881);
										num |= 470235356U;
										dictionary174[key171] = value104;
										num = (953117418U ^ num);
										Dictionary<uint, 6B147225.62147124> dictionary175 = this.01546E90;
										uint key172 = num - 616566658U;
										num = 1162745940U / num;
										num &= 156567891U;
										IntPtr 63FB2F3A82 = ldftn(42335B77);
										num <<= 31;
										dictionary175[key172] = new 6B147225.62147124(this, 63FB2F3A82);
										if (1103710061U - num == 0U)
										{
											goto IL_44;
										}
										num /= 1269194482U;
										Dictionary<uint, 6B147225.62147124> dictionary176 = this.01546E90;
										num %= 1562652951U;
										uint key173 = num - 4294967116U;
										IntPtr 63FB2F3A83 = ldftn(22D146F6);
										num &= 259331762U;
										dictionary176[key173] = new 6B147225.62147124(this, 63FB2F3A83);
										if ((1107635596U & num) != 0U)
										{
											goto IL_44;
										}
										Dictionary<uint, 6B147225.62147124> dictionary177 = this.01546E90;
										uint key174 = num ^ 182U;
										num = 1942293243U >> (int)num;
										num /= 636042716U;
										IntPtr 63FB2F3A84 = ldftn(0DCF157D);
										num /= 165876852U;
										dictionary177[key174] = new 6B147225.62147124(this, 63FB2F3A84);
										num <<= 6;
										Dictionary<uint, 6B147225.62147124> dictionary178 = this.01546E90;
										uint key175 = num - 4294967113U;
										num = 193151547U - num;
										num >>= 5;
										IntPtr 63FB2F3A85 = ldftn(1CF528B2);
										num = 130749773U - num;
										6B147225.62147124 value105 = new 6B147225.62147124(this, 63FB2F3A85);
										num /= 1815418845U;
										dictionary178[key175] = value105;
										num >>= 16;
										if ((num ^ 1575102104U) == 0U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary179 = this.01546E90;
										uint key176 = num ^ 184U;
										num = 847534948U >> (int)num;
										num = 1454973891U >> (int)num;
										IntPtr 63FB2F3A86 = ldftn(0C8C75E3);
										num = (376766639U & num);
										dictionary179[key176] = new 6B147225.62147124(this, 63FB2F3A86);
										if (139344181U <= num)
										{
											goto IL_65;
										}
										Dictionary<uint, 6B147225.62147124> dictionary180 = this.01546E90;
										uint key177 = num + 4221501581U;
										num -= 346685440U;
										6B147225.62147124 value106 = new 6B147225.62147124(this.1CF528B2);
										num = (1174885218U ^ num);
										dictionary180[key177] = value106;
										if ((1120161481U & num) == 0U)
										{
											goto IL_19;
										}
										num |= 2079133620U;
										Dictionary<uint, 6B147225.62147124> dictionary181 = this.01546E90;
										num /= 1327106915U;
										uint key178 = num - 4294967113U;
										num = 2129139331U % num;
										num = 1258257051U << (int)num;
										6B147225.62147124 value107 = new 6B147225.62147124(this.19D279C4);
										num = 1969774691U * num;
										dictionary181[key178] = value107;
										if ((526850970U ^ num) == 0U)
										{
											goto IL_19;
										}
										num <<= 4;
										Dictionary<uint, 6B147225.62147124> dictionary182 = this.01546E90;
										uint key179 = num ^ 2547072667U;
										num ^= 121729925U;
										6B147225.62147124 value108 = new 6B147225.62147124(this.6CC86ABB);
										num += 36776799U;
										dictionary182[key179] = value108;
										num = 1836666016U - num;
										num &= 2000967441U;
										Dictionary<uint, 6B147225.62147124> dictionary183 = this.01546E90;
										num = 721890507U + num;
										uint key180 = num + 2197061857U;
										IntPtr 63FB2F3A87 = ldftn(340E502E);
										num /= 182727190U;
										6B147225.62147124 value109 = new 6B147225.62147124(this, 63FB2F3A87);
										num *= 672416239U;
										dictionary183[key180] = value109;
										num *= 47464362U;
										if (num == 1630497193U)
										{
											goto IL_00;
										}
										Dictionary<uint, 6B147225.62147124> dictionary184 = this.01546E90;
										uint key181 = num - 3248069141U;
										num = 346444824U - num;
										IntPtr 63FB2F3A88 = ldftn(22D146F6);
										num ^= 848783632U;
										dictionary184[key181] = new 6B147225.62147124(this, 63FB2F3A88);
										num = 743388814U - num;
										Dictionary<uint, 6B147225.62147124> dictionary185 = this.01546E90;
										uint key182 = num + 894212742U;
										num |= 1196381767U;
										IntPtr 63FB2F3A89 = ldftn(0AD64C7E);
										num >>= 11;
										dictionary185[key182] = new 6B147225.62147124(this, 63FB2F3A89);
										Dictionary<uint, 6B147225.62147124> dictionary186 = this.01546E90;
										uint key183 = num - 1703727U;
										6B147225.62147124 value110 = new 6B147225.62147124(this.477F2627);
										num = 1641763187U % num;
										dictionary186[key183] = value110;
										if (num > 590160362U)
										{
											goto IL_19;
										}
										Dictionary<uint, 6B147225.62147124> dictionary187 = this.01546E90;
										uint key184 = num ^ 890345U;
										IntPtr 63FB2F3A90 = ldftn(04422881);
										num -= 160124770U;
										dictionary187[key184] = new 6B147225.62147124(this, 63FB2F3A90);
										if (308827858U < num)
										{
											goto Block_103;
										}
									}
								}
							}
						}
					}
					Block_103:
					num = (1028550904U & num);
					Dictionary<uint, 6B147225.62147124> dictionary188 = this.01546E90;
					num <<= 6;
					uint key185 = num ^ 9449665U;
					num <<= 24;
					IntPtr 63FB2F3A91 = ldftn(2CF451AF);
					num /= 2066635439U;
					dictionary188[key185] = new 6B147225.62147124(this, 63FB2F3A91);
					num = 1682973661U + num;
					Dictionary<uint, 6B147225.62147124> dictionary189 = this.01546E90;
					num = (802706093U | num);
					uint key186 = num ^ 1876456255U;
					num = 295853802U + num;
					num &= 1334979433U;
					IntPtr 63FB2F3A92 = ldftn(2014144B);
					num = (2141158087U ^ num);
					dictionary189[key186] = new 6B147225.62147124(this, 63FB2F3A92);
					if (2079027536 << (int)num == 0)
					{
						break;
					}
					num = 1789395423U - num;
					Dictionary<uint, 6B147225.62147124> dictionary190 = this.01546E90;
					uint key187 = num + 333805450U;
					num = 989596872U / num;
					6B147225.62147124 value111 = new 6B147225.62147124(this.084039F9);
					num = 1813449526U << (int)num;
					dictionary190[key187] = value111;
					num = 1448508336U + num;
					if (num + 1091257183U == 0U)
					{
						goto IL_00;
					}
					Dictionary<uint, 6B147225.62147124> dictionary191 = this.01546E90;
					uint key188 = num ^ 3261957666U;
					num ^= 1141119793U;
					num = (1305482810U & num);
					6B147225.62147124 value112 = new 6B147225.62147124(this.19D279C4);
					num >>= 5;
					dictionary191[key188] = value112;
					num &= 1860664225U;
					Dictionary<uint, 6B147225.62147124> dictionary192 = this.01546E90;
					uint key189 = num + 4292739109U;
					num = (2053075575U ^ num);
					num >>= 4;
					dictionary192[key189] = new 6B147225.62147124(this.0E0938F5);
					if (1519591932U == num)
					{
						break;
					}
					num += 574258991U;
					Dictionary<uint, 6B147225.62147124> dictionary193 = this.01546E90;
					uint key190 = num ^ 702699162U;
					num += 1791898273U;
					IntPtr 63FB2F3A93 = ldftn(32024E8A);
					num >>= 4;
					6B147225.62147124 value113 = new 6B147225.62147124(this, 63FB2F3A93);
					num += 1437355193U;
					dictionary193[key190] = value113;
					num = 1100691931U - num;
					if (num < 1284966970U)
					{
						goto IL_00;
					}
					num -= 1336109328U;
					Dictionary<uint, 6B147225.62147124> dictionary194 = this.01546E90;
					uint key191 = num - 2466282172U;
					num = (166735103U | num);
					6B147225.62147124 value114 = new 6B147225.62147124(this.1CF516A9);
					num = 1343038056U + num;
					dictionary194[key191] = value114;
					if (1779508453U > num)
					{
						break;
					}
					num += 380002855U;
					Dictionary<uint, 6B147225.62147124> dictionary195 = this.01546E90;
					uint key192 = num - 44303302U;
					num %= 397102695U;
					dictionary195[key192] = new 6B147225.62147124(this.27C365AB);
					if (num - 922493901U == 0U)
					{
						goto IL_00;
					}
					Dictionary<uint, 6B147225.62147124> dictionary196 = this.01546E90;
					uint key193 = num ^ 44303431U;
					num = 1804422056U * num;
					dictionary196[key193] = new 6B147225.62147124(this.04ED7FCC);
					if (1426867316U / num != 0U)
					{
						goto IL_00;
					}
					Dictionary<uint, 6B147225.62147124> dictionary197 = this.01546E90;
					num -= 689902949U;
					uint key194 = num + 2213576447U;
					num %= 1676618149U;
					dictionary197[key194] = new 6B147225.62147124(this.0B410DF3);
					num = 103023217U >> (int)num;
					this.01546E90[num ^ 1609922U] = new 6B147225.62147124(this.429E31B1);
					Dictionary<uint, 6B147225.62147124> dictionary198 = this.01546E90;
					num <<= 4;
					uint key195 = num ^ 25755740U;
					num >>= 25;
					IntPtr 63FB2F3A94 = ldftn(22D146F6);
					num = (545265867U & num);
					6B147225.62147124 value115 = new 6B147225.62147124(this, 63FB2F3A94);
					num -= 1431571936U;
					dictionary198[key195] = value115;
					if (809512269U <= num)
					{
						Dictionary<uint, 6B147225.62147124> dictionary199 = this.01546E90;
						uint key196 = num - 2863395155U;
						num = (1407401200U | num);
						IntPtr 63FB2F3A95 = ldftn(5605518D);
						num = (1018452008U & num);
						6B147225.62147124 value116 = new 6B147225.62147124(this, 63FB2F3A95);
						num = 151533916U >> (int)num;
						dictionary199[key196] = value116;
						Dictionary<uint, 6B147225.62147124> dictionary200 = this.01546E90;
						uint key197 = num - 151533710U;
						num *= 1617110373U;
						6B147225.62147124 value117 = new 6B147225.62147124(this.5605518D);
						num += 1031429400U;
						dictionary200[key197] = value117;
						num -= 1821863974U;
						Dictionary<uint, 6B147225.62147124> dictionary201 = this.01546E90;
						num += 62225790U;
						uint key198 = num ^ 1135957875U;
						num = 108483851U % num;
						IntPtr 63FB2F3A96 = ldftn(340E502E);
						num = (935396139U & num);
						6B147225.62147124 value118 = new 6B147225.62147124(this, 63FB2F3A96);
						num = 2046574395U + num;
						dictionary201[key198] = value118;
						Dictionary<uint, 6B147225.62147124> dictionary202 = this.01546E90;
						uint key199 = num ^ 2151497878U;
						IntPtr 63FB2F3A97 = ldftn(477F2627);
						num %= 1045397284U;
						dictionary202[key199] = new 6B147225.62147124(this, 63FB2F3A97);
						Dictionary<uint, 6B147225.62147124> dictionary203 = this.01546E90;
						uint key200 = num ^ 60703023U;
						6B147225.62147124 value119 = new 6B147225.62147124(this.477F2627);
						num = (2036561515U & num);
						dictionary203[key200] = value119;
						num = (2064654454U & num);
						Dictionary<uint, 6B147225.62147124> dictionary204 = this.01546E90;
						num = (2034898235U & num);
						uint key201 = num + 4278190256U;
						num /= 804010717U;
						num <<= 27;
						6B147225.62147124 value120 = new 6B147225.62147124(this.685A48E2);
						num *= 382612579U;
						dictionary204[key201] = value120;
						if (499524787U == num)
						{
							goto IL_00;
						}
						Dictionary<uint, 6B147225.62147124> dictionary205 = this.01546E90;
						uint key202 = num - 4294967085U;
						num &= 501766816U;
						IntPtr 63FB2F3A98 = ldftn(0C8C75E3);
						num = (1003316933U ^ num);
						dictionary205[key202] = new 6B147225.62147124(this, 63FB2F3A98);
						num = (1594556553U | num);
						if (30110392U >= num)
						{
							break;
						}
						num /= 884241604U;
						Dictionary<uint, 6B147225.62147124> dictionary206 = this.01546E90;
						num = 1559917308U % num;
						uint key203 = num + 212U;
						num = (2112123246U | num);
						IntPtr 63FB2F3A99 = ldftn(04422881);
						num &= 1899001585U;
						6B147225.62147124 value121 = new 6B147225.62147124(this, 63FB2F3A99);
						num = 1759930598U / num;
						dictionary206[key203] = value121;
						num /= 830867026U;
						if (1159943546U - num == 0U)
						{
							goto IL_00;
						}
						num <<= 20;
						Dictionary<uint, 6B147225.62147124> dictionary207 = this.01546E90;
						num >>= 26;
						uint key204 = num + 213U;
						num <<= 28;
						num = 1276869445U - num;
						dictionary207[key204] = new 6B147225.62147124(this.04422881);
						num = (2094942868U & num);
						if (num / 2008023111U != 0U)
						{
							break;
						}
						num = 221079722U << (int)num;
						Dictionary<uint, 6B147225.62147124> dictionary208 = this.01546E90;
						num = 883706824U / num;
						uint key205 = num + 214U;
						num = (216157766U | num);
						num = (112423930U & num);
						6B147225.62147124 value122 = new 6B147225.62147124(this.7E752FE0);
						num |= 326137041U;
						dictionary208[key205] = value122;
						num = 233987221U + num;
						this.01546E90[num ^ 635753407U] = new 6B147225.62147124(this.11222D5E);
						num = (1328897768U | num);
						if (2126710961U >> (int)num == 0U)
						{
							goto IL_00;
						}
						num /= 1832609118U;
						Dictionary<uint, 6B147225.62147124> dictionary209 = this.01546E90;
						num <<= 5;
						uint key206 = num ^ 248U;
						num = 2068394445U / num;
						IntPtr 63FB2F3A100 = ldftn(357734FC);
						num = 86209286U / num;
						dictionary209[key206] = new 6B147225.62147124(this, 63FB2F3A100);
						Dictionary<uint, 6B147225.62147124> dictionary210 = this.01546E90;
						uint key207 = num ^ 216U;
						num |= 450118490U;
						dictionary210[key207] = new 6B147225.62147124(this.22D146F6);
						Dictionary<uint, 6B147225.62147124> dictionary211 = this.01546E90;
						num <<= 3;
						uint key208 = num ^ 3600947714U;
						num /= 877927052U;
						6B147225.62147124 value123 = new 6B147225.62147124(this.7416593F);
						num = (1986212377U | num);
						dictionary211[key208] = value123;
						num -= 1956739339U;
						Dictionary<uint, 6B147225.62147124> dictionary212 = this.01546E90;
						num = 103941653U / num;
						uint key209 = num + 216U;
						num &= 731412163U;
						IntPtr 63FB2F3A101 = ldftn(7DA75F08);
						num = 1375554894U >> (int)num;
						dictionary212[key209] = new 6B147225.62147124(this, 63FB2F3A101);
						num /= 1897940185U;
						if ((num & 578965238U) == 0U)
						{
							num = (2062051616U & num);
							Dictionary<uint, 6B147225.62147124> dictionary213 = this.01546E90;
							num = 1795521373U << (int)num;
							uint key210 = num ^ 1795521409U;
							IntPtr 63FB2F3A102 = ldftn(477F2627);
							num = 1777677342U % num;
							6B147225.62147124 value124 = new 6B147225.62147124(this, 63FB2F3A102);
							num = 846221615U - num;
							dictionary213[key210] = value124;
							num = 723193495U * num;
							if ((num ^ 62862146U) == 0U)
							{
								break;
							}
							num %= 659710219U;
							this.01546E90[num ^ 593767693U] = new 6B147225.62147124(this.65BD5E64);
							num %= 1455513313U;
							Dictionary<uint, 6B147225.62147124> dictionary214 = this.01546E90;
							uint key211 = num ^ 593767694U;
							num = 1148681568U + num;
							IntPtr 63FB2F3A103 = ldftn(04ED7FCC);
							num = (1962175114U & num);
							6B147225.62147124 value125 = new 6B147225.62147124(this, 63FB2F3A103);
							num >>= 1;
							dictionary214[key211] = value125;
							num += 1744770005U;
							Dictionary<uint, 6B147225.62147124> dictionary215 = this.01546E90;
							num -= 726210341U;
							uint key212 = num ^ 1864241519U;
							6B147225.62147124 value126 = new 6B147225.62147124(this.73290840);
							num ^= 544635339U;
							dictionary215[key212] = value126;
							num /= 771193008U;
							num = (888102567U | num);
							this.01546E90[num ^ 888102471U] = new 6B147225.62147124(this.04ED7FCC);
							num = (1820745108U | num);
							num = (693992960U & num);
							Dictionary<uint, 6B147225.62147124> dictionary216 = this.01546E90;
							num = 1314005013U << (int)num;
							uint key213 = num + 2980962508U;
							num <<= 10;
							num ^= 1448870381U;
							6B147225.62147124 value127 = new 6B147225.62147124(this.1CF528B2);
							num -= 906446769U;
							dictionary216[key213] = value127;
							if (num * 1676955421U == 0U)
							{
								goto IL_00;
							}
							num |= 2112627047U;
							Dictionary<uint, 6B147225.62147124> dictionary217 = this.01546E90;
							num += 829250148U;
							uint key214 = num ^ 795511041U;
							num = 591071549U / num;
							6B147225.62147124 value128 = new 6B147225.62147124(this.46675BC7);
							num += 569577923U;
							dictionary217[key214] = value128;
							num ^= 1123356479U;
							Dictionary<uint, 6B147225.62147124> dictionary218 = this.01546E90;
							num = 206638886U % num;
							uint key215 = num - 206638659U;
							num = 6505273U + num;
							IntPtr 63FB2F3A104 = ldftn(35E57C7B);
							num %= 1995659062U;
							6B147225.62147124 value129 = new 6B147225.62147124(this, 63FB2F3A104);
							num = (159916713U ^ num);
							dictionary218[key215] = value129;
							if (1598707289U <= num)
							{
								break;
							}
							Dictionary<uint, 6B147225.62147124> dictionary219 = this.01546E90;
							num = 601687928U << (int)num;
							uint key216 = num - 3724541724U;
							num -= 997342932U;
							IntPtr 63FB2F3A105 = ldftn(0C8C75E3);
							num %= 607605451U;
							6B147225.62147124 value130 = new 6B147225.62147124(this, 63FB2F3A105);
							num = (219310337U & num);
							dictionary219[key216] = value130;
							num = (290465300U | num);
							Dictionary<uint, 6B147225.62147124> dictionary220 = this.01546E90;
							uint key217 = num ^ 290481905U;
							num = 1975260220U >> (int)num;
							dictionary220[key217] = new 6B147225.62147124(this.73B51109);
							num >>= 0;
							Dictionary<uint, 6B147225.62147124> dictionary221 = this.01546E90;
							uint key218 = num ^ 1981U;
							IntPtr 63FB2F3A106 = ldftn(46675BC7);
							num %= 1024023912U;
							6B147225.62147124 value131 = new 6B147225.62147124(this, 63FB2F3A106);
							num = 580605351U / num;
							dictionary221[key218] = value131;
							if ((1522797367U ^ num) == 0U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary222 = this.01546E90;
							num += 1069447210U;
							uint key219 = num - 1069755319U;
							num += 1041376090U;
							dictionary222[key219] = new 6B147225.62147124(this.6B7F3AD1);
							num |= 1355483380U;
							Dictionary<uint, 6B147225.62147124> dictionary223 = this.01546E90;
							num ^= 943947683U;
							uint key220 = num ^ 1167863991U;
							num -= 2138071277U;
							6B147225.62147124 value132 = new 6B147225.62147124(this.357734FC);
							num = 1489048054U * num;
							dictionary223[key220] = value132;
							if (num <= 1069048928U)
							{
								goto IL_00;
							}
							num = (1454268806U ^ num);
							Dictionary<uint, 6B147225.62147124> dictionary224 = this.01546E90;
							uint key221 = num ^ 3179251939U;
							IntPtr 63FB2F3A107 = ldftn(338E7468);
							num = 673059543U % num;
							6B147225.62147124 value133 = new 6B147225.62147124(this, 63FB2F3A107);
							num += 490367399U;
							dictionary224[key221] = value133;
							num ^= 461200661U;
							Dictionary<uint, 6B147225.62147124> dictionary225 = this.01546E90;
							uint key222 = num - 1579491457U;
							num >>= 27;
							num /= 1243352586U;
							IntPtr 63FB2F3A108 = ldftn(27C365AB);
							num = (1592657768U ^ num);
							6B147225.62147124 value134 = new 6B147225.62147124(this, 63FB2F3A108);
							num = 1476753134U + num;
							dictionary225[key222] = value134;
							if (num << 18 == 0U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary226 = this.01546E90;
							uint key223 = num + 1225556629U;
							num = (1458062546U | num);
							dictionary226[key223] = new 6B147225.62147124(this.35E57C7B);
							Dictionary<uint, 6B147225.62147124> dictionary227 = this.01546E90;
							uint key224 = num + 151290390U;
							num = 557011370U - num;
							dictionary227[key224] = new 6B147225.62147124(this.5605518D);
							if (num > 2081306391U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary228 = this.01546E90;
							num += 1849326508U;
							uint key225 = num + 1737339501U;
							num |= 318530163U;
							dictionary228[key225] = new 6B147225.62147124(this.3D7E61BB);
							num = 1949321775U << (int)num;
							if (num / 2135231203U != 0U)
							{
								goto IL_00;
							}
							num = 666710228U / num;
							Dictionary<uint, 6B147225.62147124> dictionary229 = this.01546E90;
							num >>= 5;
							uint key226 = num ^ 238U;
							num /= 1042166036U;
							num /= 297822709U;
							6B147225.62147124 value135 = new 6B147225.62147124(this.04422881);
							num |= 272530778U;
							dictionary229[key226] = value135;
							num = 1975321529U / num;
							if (num > 2082476255U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary230 = this.01546E90;
							num = (1757369065U ^ num);
							uint key227 = num + 2537598465U;
							num += 692938654U;
							num = 1895893507U - num;
							dictionary230[key227] = new 6B147225.62147124(this.6CC86ABB);
							num %= 2004578439U;
							Dictionary<uint, 6B147225.62147124> dictionary231 = this.01546E90;
							num /= 2038391604U;
							uint key228 = num ^ 240U;
							num %= 1075007681U;
							num &= 1309868321U;
							IntPtr 63FB2F3A109 = ldftn(104C242D);
							num = (265048041U | num);
							dictionary231[key228] = new 6B147225.62147124(this, 63FB2F3A109);
							num ^= 345536478U;
							if (num >= 2076261882U)
							{
								break;
							}
							Dictionary<uint, 6B147225.62147124> dictionary232 = this.01546E90;
							num >>= 26;
							uint key229 = num ^ 247U;
							num += 780339032U;
							dictionary232[key229] = new 6B147225.62147124(this.63C40051);
							num = (1202868393U ^ num);
							num >>= 17;
							Dictionary<uint, 6B147225.62147124> dictionary233 = this.01546E90;
							uint key230 = num ^ 13418U;
							num = 943941352U * num;
							dictionary233[key230] = new 6B147225.62147124(this.04ED7FCC);
							num = 1231095968U * num;
							if (num << 27 != 0U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary234 = this.01546E90;
							uint key231 = num ^ 2536642803U;
							6B147225.62147124 value136 = new 6B147225.62147124(this.04ED7FCC);
							num ^= 453188762U;
							dictionary234[key231] = value136;
							if (num < 1040349362U)
							{
								goto IL_00;
							}
							Dictionary<uint, 6B147225.62147124> dictionary235 = this.01546E90;
							num <<= 29;
							uint key232 = num - 1073741580U;
							num += 1579551666U;
							6B147225.62147124 value137 = new 6B147225.62147124(this.57302E15);
							num = 1252469561U << (int)num;
							dictionary235[key232] = value137;
							num <<= 22;
							num *= 549281968U;
							Dictionary<uint, 6B147225.62147124> dictionary236 = this.01546E90;
							num /= 1285382866U;
							uint key233 = num - 4294967051U;
							num -= 1017191597U;
							IntPtr 63FB2F3A110 = ldftn(7DD5082A);
							num = (1268410341U & num);
							6B147225.62147124 value138 = new 6B147225.62147124(this, 63FB2F3A110);
							num = (205857495U ^ num);
							dictionary236[key233] = value138;
							num /= 1193148816U;
							Dictionary<uint, 6B147225.62147124> dictionary237 = this.01546E90;
							uint key234 = num + 245U;
							num = (105392441U | num);
							IntPtr 63FB2F3A111 = ldftn(084039F9);
							num += 1880121867U;
							dictionary237[key234] = new 6B147225.62147124(this, 63FB2F3A111);
							num *= 1420456603U;
							Dictionary<uint, 6B147225.62147124> dictionary238 = this.01546E90;
							num >>= 0;
							uint key235 = num + 523724491U;
							num = (1200046825U & num);
							num = 1001586923U / num;
							IntPtr 63FB2F3A112 = ldftn(56AC6F55);
							num = 1261896780U >> (int)num;
							6B147225.62147124 value139 = new 6B147225.62147124(this, 63FB2F3A112);
							num = 623321675U << (int)num;
							dictionary238[key235] = value139;
							num += 211755752U;
							Dictionary<uint, 6B147225.62147124> dictionary239 = this.01546E90;
							num >>= 1;
							uint key236 = num ^ 1063381388U;
							num = 1291652167U << (int)num;
							num += 1381842321U;
							6B147225.62147124 value140 = new 6B147225.62147124(this.477F2627);
							num = 777468831U + num;
							dictionary239[key236] = value140;
							num = (1723875391U ^ num);
							Dictionary<uint, 6B147225.62147124> dictionary240 = this.01546E90;
							num = 1534552523U / num;
							uint key237 = num ^ 251U;
							IntPtr 63FB2F3A113 = ldftn(104C242D);
							num = 122045277U - num;
							dictionary240[key237] = new 6B147225.62147124(this, 63FB2F3A113);
							if (num != 61824366U)
							{
								goto Block_130;
							}
						}
					}
				}
			}
			Block_130:
			Dictionary<uint, 6B147225.62147124> dictionary241 = this.01546E90;
			uint key238 = num - 122045025U;
			num = 430447566U - num;
			IntPtr 63FB2F3A114 = ldftn(7E752FE0);
			num = 854465910U / num;
			dictionary241[key238] = new 6B147225.62147124(this, 63FB2F3A114);
			num += 1685857100U;
			Dictionary<uint, 6B147225.62147124> dictionary242 = this.01546E90;
			num |= 157101375U;
			uint key239 = num + 2458046844U;
			num <<= 18;
			IntPtr 63FB2F3A115 = ldftn(104C242D);
			num |= 610164914U;
			6B147225.62147124 value141 = new 6B147225.62147124(this, 63FB2F3A115);
			num = 1656519021U / num;
			dictionary242[key239] = value141;
			num |= 360342715U;
			if (num / 1812494543U == 0U)
			{
				Dictionary<uint, 6B147225.62147124> dictionary243 = this.01546E90;
				uint key240 = num ^ 360342599U;
				num = 2099146688U + num;
				IntPtr 63FB2F3A116 = ldftn(27C365AB);
				num = 924539280U / num;
				6B147225.62147124 value142 = new 6B147225.62147124(this, 63FB2F3A116);
				num = 714561731U >> (int)num;
				dictionary243[key240] = value142;
				num &= 689776797U;
				if ((503989637U ^ num) != 0U)
				{
					num |= 654194008U;
					Dictionary<uint, 6B147225.62147124> dictionary244 = this.01546E90;
					num |= 1699696077U;
					uint key241 = num ^ 1879014688U;
					IntPtr 63FB2F3A117 = ldftn(04422881);
					num = 2036487472U * num;
					6B147225.62147124 value143 = new 6B147225.62147124(this, 63FB2F3A117);
					num += 1763848511U;
					dictionary244[key241] = value143;
					num = 1641564274U / num;
					if (435887584U >= num)
					{
						Dictionary<uint, 6B147225.62147124> dictionary245 = this.01546E90;
						uint key242 = num ^ 254U;
						num = (1004550109U & num);
						6B147225.62147124 value144 = new 6B147225.62147124(this.7E752FE0);
						num %= 787025245U;
						dictionary245[key242] = value144;
						num = (2054251506U ^ num);
						if (num << 2 != 0U)
						{
							break;
						}
					}
				}
			}
		}
		Dictionary<uint, 6B147225.62147124> dictionary246 = this.01546E90;
		num ^= 1174959132U;
		uint key243 = num ^ 1014568721U;
		num = (780677520U ^ num);
		IntPtr 63FB2F3A118 = ldftn(477F2627);
		num = 1567256297U << (int)num;
		dictionary246[key243] = new 6B147225.62147124(this, 63FB2F3A118);
	}

	// Token: 0x06000372 RID: 882 RVA: 0x00E6B468 File Offset: 0x00E67868
	private void 72160E89(6B147225.68EF01A4 7E485B56)
	{
		uint num = 617903344U;
		Stack<6B147225.14B354D4> stack = this.176B51CC;
		num = 1217401568U << (int)num;
		num = 2041979264U - num;
		6B147225.14B354D4 item = 7E485B56.6991E7AF();
		num = 1606692732U >> (int)num;
		stack.Push(item);
	}

	// Token: 0x06000373 RID: 883 RVA: 0x00E6B4B0 File Offset: 0x00E678B0
	private 6B147225.68EF01A4 114C39DF()
	{
		return this.176B51CC.Pop();
	}

	// Token: 0x06000374 RID: 884 RVA: 0x00E6B4D0 File Offset: 0x00E678D0
	private 6B147225.68EF01A4 4206269E()
	{
		return this.176B51CC.Peek();
	}

	// Token: 0x06000375 RID: 885 RVA: 0x00E6B4F0 File Offset: 0x00E678F0
	private byte 399E5675()
	{
		uint num = 1321085391U;
		IntPtr ptr = new IntPtr(this.5E457DAB + (long)this.53F44057);
		num = 1956718112U - num;
		byte result = Marshal.ReadByte(ptr);
		num %= 330202031U;
		this.53F44057 += (int)(num - 305430689U);
		return result;
	}

	// Token: 0x06000376 RID: 886 RVA: 0x00E6B540 File Offset: 0x00E67940
	private short 75DA0F9B()
	{
		uint num = 1216772083U;
		long num2 = this.5E457DAB;
		num = (269491919U ^ num);
		num = 1990288746U % num;
		long num3 = (long)this.53F44057;
		num = 858460174U - num;
		long num4 = num3;
		num = (881286832U | num);
		long value = num2 + num4;
		num %= 425873865U;
		IntPtr ptr = new IntPtr(value);
		num -= 1220436181U;
		short result = Marshal.ReadInt16(ptr);
		num = (825366039U & num);
		num %= 1104609411U;
		int num5 = this.53F44057;
		num %= 489505056U;
		int num6 = (int)(num + 3977064225U);
		num = (1025865882U & num);
		this.53F44057 = num5 + num6;
		return result;
	}

	// Token: 0x06000377 RID: 887 RVA: 0x00E6B5D0 File Offset: 0x00E679D0
	private int 0D7859B3()
	{
		long num = this.5E457DAB;
		long num2 = (long)this.53F44057;
		uint num3 = 1488280712U;
		long num4 = num2;
		num3 <<= 9;
		IntPtr ptr = new IntPtr(num + num4);
		num3 /= 621574781U;
		int result = Marshal.ReadInt32(ptr);
		num3 |= 1625049563U;
		int num5 = this.53F44057;
		num3 = 880942502U << (int)num3;
		this.53F44057 = num5 + (int)(num3 + 3489660932U);
		return result;
	}

	// Token: 0x06000378 RID: 888 RVA: 0x00E6B638 File Offset: 0x00E67A38
	private long 6E0126C6()
	{
		uint num = 1823359757U;
		long num2 = this.5E457DAB;
		num &= 1616276460U;
		num = (907568098U | num);
		long num3 = (long)this.53F44057;
		num = (1072053957U ^ num);
		long num4 = num3;
		num ^= 75450588U;
		long result = Marshal.ReadInt64(new IntPtr(num2 + num4));
		num %= 586098148U;
		this.53F44057 += (int)(num + 4166464985U);
		return result;
	}

	// Token: 0x06000379 RID: 889 RVA: 0x00E6B6A0 File Offset: 0x00E67AA0
	private float 395A3124()
	{
		uint num = 437344791U;
		num ^= 150667484U;
		int value = this.0D7859B3();
		num = 1608453552U / num;
		byte[] bytes = BitConverter.GetBytes(value);
		int startIndex = (int)(num + 4294967291U);
		num &= 242693853U;
		return BitConverter.ToSingle(bytes, startIndex);
	}

	// Token: 0x0600037A RID: 890 RVA: 0x00E6B6E4 File Offset: 0x00E67AE4
	private double 48A81D26()
	{
		uint num = 1368941703U;
		long value = this.6E0126C6();
		num -= 982147274U;
		byte[] bytes = BitConverter.GetBytes(value);
		num = 1966737299U / num;
		return BitConverter.ToDouble(bytes, (int)(num - 5U));
	}

	// Token: 0x0600037B RID: 891 RVA: 0x00E6B720 File Offset: 0x00E67B20
	private void 477F2627()
	{
		uint num = 1694391046U;
		for (;;)
		{
			IL_07:
			byte b = this.399E5675();
			num %= 1486630244U;
			if (num != 861479285U)
			{
				int num4;
				int num5;
				6B147225.045263C1 045263C3;
				for (;;)
				{
					IL_25:
					num >>= 10;
					int num2 = this.0D7859B3();
					if (num + 1645355653U != 0U)
					{
						for (;;)
						{
							num >>= 10;
							int num3 = this.0D7859B3();
							num <<= 14;
							for (;;)
							{
								num ^= 607085918U;
								num4 = this.0D7859B3();
								if (num / 702483321U == 0U)
								{
									num5 = this.0D7859B3();
									num <<= 25;
									goto IL_91;
								}
								IL_FB:
								6B147225.045263C1 045263C;
								int num6 = 045263C.206548D1();
								num &= 1897150217U;
								if (num6 == num2)
								{
									num -= 682624497U;
									6B147225.045263C1 045263C2 = 045263C;
									num = (286207761U | num);
									int num7 = 045263C2.26F06F1B();
									int num8 = num3;
									num ^= 3632004895U;
									if (num7 == num8)
									{
										num = 1785726343U * num;
										if (num < 825585394U)
										{
											continue;
										}
										045263C3 = 045263C;
										if (342708338U / num == 0U)
										{
											goto IL_1E8;
										}
										goto IL_25;
									}
								}
								num %= 836401040U;
								if (num > 1455514675U)
								{
									goto IL_07;
								}
								int num10;
								int num9 = num10;
								num = 1016936763U - num;
								int num11 = (int)(num ^ 998848826U);
								num = 1023151466U << (int)num;
								num10 = num9 + num11;
								num += 1758081612U;
								IL_1AF:
								int num12 = num10;
								num <<= 9;
								num ^= 828789920U;
								List<6B147225.045263C1> list = this.1DD42960;
								num -= 1282227009U;
								if (num12 >= list.Count)
								{
									num ^= 2904133983U;
									goto IL_1E8;
								}
								num = 1658922516U;
								List<6B147225.045263C1> list2 = this.1DD42960;
								num = 259544699U * num;
								int index = num10;
								num %= 854730784U;
								6B147225.045263C1 045263C4 = list2[index];
								num += 1620270228U;
								045263C = 045263C4;
								num = 222626711U << (int)num;
								goto IL_FB;
								IL_91:
								045263C3 = null;
								num = 1959408204U - num;
								num10 = (int)(num + 1194708404U);
								if ((num & 942670596U) != 0U)
								{
									goto IL_1AF;
								}
								goto IL_07;
								IL_1E8:
								if (045263C3 == null)
								{
									bool flag = num + 175374336U != 0U;
									int 281B = num2;
									int 02404A = num3;
									num -= 744031556U;
									045263C3 = new 6B147225.045263C1(281B, 02404A);
									int num13 = (int)(num ^ 3375561404U);
									for (;;)
									{
										num = 1446606935U / num;
										if ((num & 1110195093U) != 0U)
										{
											goto IL_07;
										}
										int num14 = num13;
										num = 535255294U >> (int)num;
										List<6B147225.045263C1> list3 = this.1DD42960;
										num = 1131445238U * num;
										int count = list3.Count;
										num ^= 1657174385U;
										if (num14 >= count)
										{
											goto Block_14;
										}
										List<6B147225.045263C1> list4 = this.1DD42960;
										num = 1733382679U;
										int index2 = num13;
										num += 1645361124U;
										6B147225.045263C1 009C503D = list4[index2];
										num = 1851598259U >> (int)num;
										6B147225.045263C1 045263C5 = 045263C3;
										num = 261782628U / num;
										int num15 = 045263C5.74F076A1(009C503D);
										uint num16 = num + 4274830171U;
										num ^= 1403346865U;
										if (num15 < num16)
										{
											goto Block_10;
										}
										num ^= 421025171U;
										int num17 = num13;
										num = (1021586735U ^ num);
										int num18 = (int)(num ^ 2003461033U);
										num = (1933005093U ^ num);
										int num19 = num17 + num18;
										num = 941431259U - num;
										num13 = num19;
										num ^= 4203552242U;
									}
									IL_379:
									if (743600979U <= num)
									{
										goto IL_07;
									}
									bool flag2 = flag;
									num ^= 3726653255U;
									if (flag2)
									{
										goto IL_3D5;
									}
									num ^= 441416391U;
									if (469440432U <= num)
									{
										List<6B147225.045263C1> list5 = this.1DD42960;
										num <<= 19;
										6B147225.045263C1 item = 045263C3;
										num = 41751889U * num;
										list5.Add(item);
										num ^= 2855534592U;
										goto IL_3D5;
									}
									goto IL_25;
									Block_14:
									num += 3484696546U;
									goto IL_379;
									Block_10:
									num = (1973320612U & num);
									if (num % 735401647U == 0U)
									{
										goto IL_25;
									}
									num >>= 3;
									List<6B147225.045263C1> list6 = this.1DD42960;
									int index3 = num13;
									num %= 1854877000U;
									6B147225.045263C1 item2 = 045263C3;
									num >>= 28;
									list6.Insert(index3, item2);
									num = (430445360U | num);
									bool flag3 = (num ^ 430445361U) != 0U;
									num = (839132279U ^ num);
									flag = flag3;
									if (num << 31 != 0U)
									{
										goto IL_379;
									}
									break;
								}
								IL_3D5:
								if (num >= 2014646727U)
								{
									goto Block_18;
								}
								goto IL_91;
							}
						}
					}
				}
				Block_18:
				6B147225.045263C1 045263C6 = 045263C3;
				num ^= 865621579U;
				byte 6FE = b;
				num = 1330656527U % num;
				int 6E4D5A = num4;
				int 76DB08DF = num5;
				num >>= 26;
				045263C6.6D713505(6FE, 6E4D5A, 76DB08DF);
				if (num + 1123890207U != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600037C RID: 892 RVA: 0x00E6BB48 File Offset: 0x00E67F48
	private TypeCode 31801837(6B147225.68EF01A4 325E2D5D, 6B147225.68EF01A4 1C0C5130)
	{
		uint num;
		TypeCode typeCode;
		TypeCode typeCode3;
		for (;;)
		{
			IL_00:
			num = 2119064920U;
			typeCode = 325E2D5D.39440F35();
			num -= 1305837533U;
			if (num != 2122194498U)
			{
				for (;;)
				{
					IL_20:
					num <<= 15;
					TypeCode typeCode2 = 1C0C5130.39440F35();
					num = 974740564U + num;
					typeCode3 = typeCode2;
					if (num != 359944024U)
					{
						while (typeCode != TypeCode.Empty)
						{
							TypeCode typeCode4 = typeCode;
							uint num2 = num + 1462313901U;
							num = 1847332619U * num;
							num += 2676127928U;
							if (typeCode4 == num2)
							{
								break;
							}
							bool flag = typeCode3 != TypeCode.Empty;
							num = 332994795U + num;
							num ^= 343484779U;
							if (!flag)
							{
								break;
							}
							num <<= 18;
							if (num < 1023427655U)
							{
								goto IL_00;
							}
							TypeCode typeCode5 = typeCode3;
							num >>= 21;
							uint num3 = num ^ 907U;
							num /= 692091761U;
							if (typeCode5 == num3)
							{
								goto Block_4;
							}
							if (num != 828711510U)
							{
								uint num4 = (uint)typeCode;
								num = (1751385994U | num);
								if (num4 == num - 1751385984U)
								{
									goto Block_6;
								}
								num *= 858535208U;
								if (num >> 12 == 0U)
								{
									goto IL_00;
								}
								TypeCode typeCode6 = typeCode3;
								num = (1915297395U ^ num);
								uint num5 = num ^ 3166806505U;
								num = 1936482125U % num;
								if (typeCode6 == num5)
								{
									if (1449405561U <= num)
									{
										uint num6 = (uint)typeCode;
										num -= 5327491U;
										if (num6 != num + 2363812671U)
										{
											goto Block_11;
										}
										num >>= 5;
										if (num < 222691338U)
										{
											return typeCode3;
										}
										goto IL_20;
									}
								}
								else
								{
									num = 476069387U / num;
									TypeCode typeCode7 = typeCode;
									num *= 1775197556U;
									uint num7 = num + 12U;
									num += 103755498U;
									if (typeCode7 == num7)
									{
										num %= 115672261U;
										if (num < 1013804640U)
										{
											goto Block_14;
										}
									}
									else
									{
										TypeCode typeCode8 = typeCode3;
										num *= 2138400926U;
										uint num8 = num ^ 2199913568U;
										num ^= 153820161U;
										if (typeCode8 == num8)
										{
											num %= 669283456U;
											TypeCode typeCode9 = typeCode;
											num %= 84152429U;
											uint num9 = num ^ 55675311U;
											num = (1618238094U & num);
											if (typeCode9 != num9)
											{
												if (1468666693U == num)
												{
													continue;
												}
												TypeCode typeCode10 = typeCode;
												uint num10 = num + 4289722245U;
												num = (48456396U ^ num);
												num ^= 48456396U;
												if (typeCode10 != num10)
												{
													goto Block_21;
												}
											}
											if ((num ^ 138103311U) != 0U)
											{
												return typeCode;
											}
											goto IL_20;
										}
										else
										{
											if (num < 331054065U)
											{
												goto IL_20;
											}
											TypeCode typeCode11 = typeCode;
											uint num11 = num + 1978984353U;
											num |= 1288983842U;
											if (typeCode11 == num11)
											{
												goto IL_2DC;
											}
											num += 412248877U;
											if ((850417003U ^ num) == 0U)
											{
												goto IL_00;
											}
											if (typeCode3 == (TypeCode)(num - 3882993806U))
											{
												goto Block_26;
											}
											if (251228793U - num == 0U)
											{
												goto IL_00;
											}
											TypeCode typeCode12 = typeCode;
											num ^= 525681962U;
											uint num12 = num + 131822167U;
											num = 1932279395U % num;
											if (typeCode12 == num12)
											{
												goto IL_33E;
											}
											num /= 935266234U;
											if (num >> 18 == 0U)
											{
												goto Block_29;
											}
											goto IL_20;
										}
									}
								}
							}
						}
						goto IL_B3;
					}
				}
				Block_14:
				TypeCode typeCode13 = typeCode3;
				num += 1772960398U;
				uint num13 = num ^ 1876715889U;
				num = 1893343281U >> (int)num;
				if (typeCode13 != num13)
				{
					num = (864972448U ^ num);
					TypeCode typeCode14 = typeCode3;
					uint num14 = num ^ 864972507U;
					num = (226776807U | num);
					num += 3228664185U;
					if (typeCode14 != num14)
					{
						goto Block_16;
					}
				}
				num *= 39728178U;
				if (num <= 1227104011U)
				{
					return typeCode;
				}
				continue;
				Block_29:
				if (typeCode3 == (int)num + TypeCode.Int64)
				{
					goto Block_30;
				}
				if (typeCode == (TypeCode)(num - 4294967287U))
				{
					goto IL_383;
				}
				num = (2175226U | num);
				if (num != 1288329164U)
				{
					goto Block_32;
				}
			}
		}
		Block_4:
		num ^= 2832653396U;
		IL_B3:
		return (int)num + (TypeCode)1462313900;
		Block_6:
		TypeCode typeCode15 = typeCode3;
		uint num15 = num ^ 1751385987U;
		num = 396903020U >> (int)num;
		if (typeCode15 != num15)
		{
			return (TypeCode)(num ^ 387600U);
		}
		return typeCode;
		Block_11:
		num *= 1203663830U;
		return (TypeCode)(num ^ 3605405404U);
		Block_16:
		return (TypeCode)(num ^ 112U);
		Block_21:
		return (TypeCode)(num - 5245062U);
		Block_26:
		num += 3882718419U;
		IL_2DC:
		num /= 1495298975U;
		return (int)num + TypeCode.UInt64;
		Block_30:
		num += 1932279393U;
		IL_33E:
		return (int)num + (TypeCode)(-1932279382);
		Block_32:
		TypeCode typeCode16 = typeCode3;
		uint num16 = num ^ 2175217U;
		num = (345406683U & num);
		if (typeCode16 != num16)
		{
			return (TypeCode)(num - 12497U);
		}
		num ^= 12504U;
		IL_383:
		return (TypeCode)(num ^ 9U);
	}

	// Token: 0x0600037D RID: 893 RVA: 0x00E6BEE8 File Offset: 0x00E682E8
	private 6B147225.68EF01A4 0DC12445(6B147225.68EF01A4 0DA06669, 6B147225.68EF01A4 0CB13723, bool 125D19A8, bool 7ECE4C7A)
	{
		uint num = 1977442367U;
		if (num >= 1273499638U)
		{
			goto IL_13;
		}
		goto IL_68;
		TypeCode typeCode2;
		int value;
		long value2;
		float num30;
		float num32;
		for (;;)
		{
			IL_27:
			TypeCode typeCode = typeCode2;
			num &= 376921471U;
			uint num2 = num ^ 107151729U;
			num -= 1286231385U;
			switch (typeCode - num2)
			{
			case 0:
				goto IL_68;
			case 1:
				num = (342911785U | num);
				if (7ECE4C7A)
				{
					num = 360728525U >> (int)num;
					if (num > 2027755212U)
					{
						goto IL_13;
					}
					uint num3 = 0DA06669.786A7318();
					num |= 1051340611U;
					uint num4 = num3;
					num -= 1260076252U;
					uint num5 = 0CB13723.786A7318();
					num ^= 636834604U;
					int num7;
					if (!125D19A8)
					{
						num |= 891170545U;
						int num6 = (int)num4;
						num = 1907115241U % num;
						num7 = num6 + (int)num5;
					}
					else
					{
						num = (847281846U ^ num);
						if (num == 1261389950U)
						{
							goto IL_13;
						}
						int num8 = (int)num4;
						int num9 = (int)num5;
						num >>= 9;
						num7 = checked(num8 + num9);
						num += 1899611898U;
					}
					num = 355796911U + num;
					value = num7;
				}
				else
				{
					num = (2033871413U ^ num);
					int num10 = 0DA06669.EDAECC1C();
					num /= 83500990U;
					int num11 = 0CB13723.EDAECC1C();
					num = (898320171U | num);
					int num14;
					if (!125D19A8)
					{
						num = 623444801U >> (int)num;
						int num12 = num10;
						int num13 = num11;
						num &= 2117561103U;
						num14 = num12 + num13;
					}
					else
					{
						if (1634536347U < num)
						{
							goto IL_13;
						}
						int num15 = num10;
						num = 1814124471U + num;
						num14 = checked(num15 + num11);
						num ^= 2712458468U;
					}
					num |= 1177230783U;
					value = num14;
					num += 1085664473U;
				}
				if (128520938U <= num)
				{
					goto Block_38;
				}
				continue;
			case 2:
				num += 623995523U;
				num = 1170702185U >> (int)num;
				if (7ECE4C7A)
				{
					goto Block_10;
				}
				num = (1335973070U & num);
				if ((1087527481U ^ num) != 0U)
				{
					goto Block_14;
				}
				continue;
			case 3:
				if (1183991117U == num)
				{
					continue;
				}
				if (7ECE4C7A)
				{
					num *= 509037172U;
					ulong num16 = 0DA06669.5C835FEF();
					num = 482111715U >> (int)num;
					ulong num17 = 0CB13723.5C835FEF();
					num = (812087161U & num);
					ulong num18 = num17;
					if (1868905283U <= num)
					{
						goto IL_13;
					}
					long num19;
					if (!125D19A8)
					{
						num19 = (long)(num16 + num18);
					}
					else
					{
						num = 42301677U + num;
						long num20 = (long)num16;
						num |= 1046950468U;
						long num21 = (long)num18;
						num ^= 60629073U;
						num19 = checked(num20 + num21);
						num += 3263603970U;
					}
					num = 1754164506U % num;
					value2 = num19;
					if (1130589932U == num)
					{
						break;
					}
				}
				else
				{
					num = 1362505078U >> (int)num;
					num = 1162750507U - num;
					long num22 = 0DA06669.DA78F42D();
					num += 1962558549U;
					long num23 = 0CB13723.DA78F42D();
					num = 1780884447U - num;
					num *= 11999366U;
					long num26;
					if (!125D19A8)
					{
						num += 721955681U;
						if (740184034U == num)
						{
							goto IL_13;
						}
						long num24 = num22;
						num = 432489907U / num;
						long num25 = num23;
						num /= 111442493U;
						num26 = num24 + num25;
					}
					else
					{
						long num27 = num22;
						long num28 = num23;
						num &= 1330937196U;
						num26 = checked(num27 + num28);
						num += 2997594840U;
					}
					num |= 1975348672U;
					value2 = num26;
					num += 2319667789U;
				}
				num /= 1681882895U;
				if ((num ^ 1538670164U) != 0U)
				{
					goto Block_50;
				}
				continue;
			case 4:
			{
				num = 225593944U + num;
				6B147225.68EF01A4 68EF01A;
				if (!7ECE4C7A)
				{
					if (953104062U + num == 0U)
					{
						goto IL_13;
					}
					68EF01A = 0DA06669;
				}
				else
				{
					num %= 768814714U;
					68EF01A = 0DA06669.0C5BC4A1();
					num += 3075258856U;
				}
				float num29 = 68EF01A.B55103C5();
				num <<= 3;
				num30 = num29;
				num = 1148222776U - num;
				num <<= 7;
				6B147225.68EF01A4 68EF01A2;
				if (!7ECE4C7A)
				{
					num *= 129703446U;
					if (960438047U <= num)
					{
						goto IL_13;
					}
					68EF01A2 = 0CB13723;
				}
				else
				{
					num = 1201931754U - num;
					68EF01A2 = 0CB13723.0C5BC4A1();
					num ^= 2753021418U;
				}
				float num31 = 68EF01A2.B55103C5();
				num = 872228378U + num;
				num32 = num31;
				num = 808780430U << (int)num;
				if (1306751639U / num == 0U)
				{
					goto IL_13;
				}
				if (125D19A8)
				{
					goto IL_42D;
				}
				if ((num ^ 1624330235U) != 0U)
				{
					goto Block_23;
				}
				continue;
			}
			case 5:
			{
				if (1357534799U > num)
				{
					goto IL_95;
				}
				6B147225.68EF01A4 68EF01A3;
				if (!7ECE4C7A)
				{
					if (num == 473919280U)
					{
						goto IL_13;
					}
					68EF01A3 = 0DA06669;
				}
				else
				{
					num = 1079384382U * num;
					num = (132347249U ^ num);
					68EF01A3 = 0DA06669.0C5BC4A1();
					num += 665249836U;
				}
				num = 934641459U - num;
				double num33 = 68EF01A3.8CC4ACA1();
				num /= 1682646478U;
				double num34 = num33;
				num %= 944313896U;
				num = (1645678979U | num);
				6B147225.68EF01A4 68EF01A4;
				if (!7ECE4C7A)
				{
					num = (166935465U ^ num);
					if (711856487U == num)
					{
						goto IL_13;
					}
					68EF01A4 = 0CB13723;
				}
				else
				{
					num = (955084558U | num);
					68EF01A4 = 0CB13723.0C5BC4A1();
					num += 4041517723U;
				}
				num += 807619582U;
				double num35 = 68EF01A4.8CC4ACA1();
				if (1566315281U % num != 0U)
				{
					goto Block_29;
				}
				continue;
			}
			}
			goto IL_63;
		}
		Block_10:
		ulong num36 = 0DA06669.5C835FEF();
		num += 1193507188U;
		num = (1324563863U | num);
		ulong num37 = 0CB13723.5C835FEF();
		num |= 1123698434U;
		long 7B2365FA;
		if (num != 205871624U)
		{
			long num38;
			if (!125D19A8)
			{
				num += 1745577008U;
				if (num <= 507522495U)
				{
					goto IL_83;
				}
				num38 = (long)(num36 + num37);
			}
			else
			{
				num <<= 15;
				num38 = (long)(checked(num36 + num37));
				num ^= 2028299279U;
			}
			num = 1640056179U / num;
			7B2365FA = num38;
			goto IL_326;
		}
		goto IL_13;
		Block_14:
		num = 1178489292U % num;
		long num39 = 0DA06669.DA78F42D();
		num = (1188252965U | num);
		long num40 = 0CB13723.DA78F42D();
		if (70326907U >= num)
		{
			goto IL_13;
		}
		num = 1051794823U >> (int)num;
		long num41;
		if (!125D19A8)
		{
			num = 462976166U * num;
			num41 = num39 + num40;
		}
		else
		{
			long num42 = num39;
			num &= 1139812051U;
			long num43 = num40;
			num = 705386065U - num;
			num41 = checked(num42 + num43);
			num += 2403754871U;
		}
		num = 28259255U + num;
		7B2365FA = num41;
		num ^= 3104894143U;
		IL_326:
		return new 6B147225.58E136FA(7B2365FA);
		Block_23:
		float num44 = num30;
		num = 1053105401U - num;
		float num45 = num32;
		num = 1978536672U * num;
		float 2DBD116A = num44 + num45;
		goto IL_45A;
		IL_42D:
		num = 66981725U - num;
		float num46 = num30;
		num = 589829791U % num;
		float num47 = num32;
		num = (304292049U & num);
		2DBD116A = num46 + num47;
		num += 2195774287U;
		IL_45A:
		return new 6B147225.1F5C5947(2DBD116A);
		Block_29:
		num -= 638654408U;
		double 406C;
		if (!125D19A8)
		{
			double num34;
			double num35;
			406C = num34 + num35;
		}
		else
		{
			if (2075950237U == num)
			{
				goto IL_63;
			}
			double num34;
			double num35;
			406C = num34 + num35;
			num += 0U;
		}
		num = 653668446U * num;
		return new 6B147225.60416C9D(406C);
		Block_38:
		TypeCode typeCode3 = 0DA06669.39440F35();
		num = 1680367059U / num;
		6B147225.2EF54896 2EF;
		if (typeCode3 != typeCode2)
		{
			if (num >= 742143865U)
			{
				goto IL_13;
			}
			2EF = (6B147225.2EF54896)0CB13723;
		}
		else
		{
			num ^= 810902311U;
			2EF = (6B147225.2EF54896)0DA06669;
			num ^= 810902311U;
		}
		6B147225.2EF54896 2EF2 = 2EF;
		if ((num & 186329061U) != 0U)
		{
			goto IL_13;
		}
		IntPtr intPtr = new IntPtr(value);
		num >>= 19;
		if (575876687U != num)
		{
			object 286A427D = Pointer.Box(intPtr.ToPointer(), 2EF2.0B2A827C());
			6B147225.68EF01A4 68EF01A5 = 2EF2;
			num = 1183787791U << (int)num;
			Type 79C = 68EF01A5.0B2A827C();
			num %= 1882741719U;
			return new 6B147225.2EF54896(286A427D, 79C);
		}
		goto IL_83;
		Block_50:
		num %= 650714157U;
		TypeCode typeCode4 = 0DA06669.39440F35();
		num /= 976048185U;
		TypeCode typeCode5 = typeCode2;
		num %= 1997625034U;
		6B147225.2EF54896 2EF3;
		if (typeCode4 != typeCode5)
		{
			num = 1385502465U * num;
			if (1346067665U * num != 0U)
			{
				goto IL_13;
			}
			2EF3 = (6B147225.2EF54896)0CB13723;
		}
		else
		{
			2EF3 = (6B147225.2EF54896)0DA06669;
			num += 0U;
		}
		6B147225.2EF54896 2EF4 = 2EF3;
		IntPtr intPtr2 = new IntPtr(value2);
		num %= 581390921U;
		intPtr = intPtr2;
		if (num / 189294472U == 0U)
		{
			num -= 1338532869U;
			object 286A427D2 = Pointer.Box(intPtr.ToPointer(), 2EF4.0B2A827C());
			num <<= 14;
			Type 79C2 = 2EF4.0B2A827C();
			num = (1677263798U ^ num);
			return new 6B147225.2EF54896(286A427D2, 79C2);
		}
		goto IL_13;
		int num49;
		int num50;
		do
		{
			IL_68:
			num = 1842216977U / num;
			num += 125831532U;
			if (7ECE4C7A)
			{
				goto IL_83;
			}
			num = (1188380570U ^ num);
			int num48 = 0DA06669.EDAECC1C();
			num = (1899431577U | num);
			num49 = num48;
			num ^= 1294343655U;
			num50 = 0CB13723.EDAECC1C();
			num = 1758081053U * num;
			if (125D19A8)
			{
				goto IL_177;
			}
		}
		while (num < 1804548259U);
		int num51 = num49;
		int num52 = num50;
		num = (1652712740U | num);
		int num53 = num51 + num52;
		goto IL_1A7;
		IL_177:
		num += 633759456U;
		if (num >> 11 == 0U)
		{
			goto IL_63;
		}
		int num54 = num49;
		int num55 = num50;
		num = (2109500097U | num);
		num53 = checked(num54 + num55);
		num += 4005133027U;
		IL_1A7:
		int num56 = num53;
		num ^= 3558737798U;
		goto IL_1B3;
		IL_13:
		num <<= 3;
		typeCode2 = this.31801837(0DA06669, 0CB13723);
		goto IL_27;
		IL_63:
		num &= 5597819U;
		throw new InvalidOperationException();
		IL_83:
		num &= 1017389245U;
		uint num57 = 0DA06669.786A7318();
		IL_95:
		uint num58 = 0CB13723.786A7318();
		num = 954295582U >> (int)num;
		if (631077535U * num == 0U)
		{
			goto IL_63;
		}
		int num61;
		if (!125D19A8)
		{
			if (2140947012U / num == 0U)
			{
				goto IL_13;
			}
			int num59 = (int)num57;
			int num60 = (int)num58;
			num = 88545611U / num;
			num61 = num59 + num60;
		}
		else
		{
			if (2096196661U < num)
			{
				goto IL_13;
			}
			num61 = (int)(checked(num57 + num58));
			num += 4294734694U;
		}
		num = 984114102U - num;
		num56 = num61;
		if (num <= 949160803U)
		{
			goto IL_13;
		}
		IL_1B3:
		if (num <= 1548430175U)
		{
			int 5EEF = num56;
			num &= 534201946U;
			return new 6B147225.1F462BA1(5EEF);
		}
		goto IL_27;
	}

	// Token: 0x0600037E RID: 894 RVA: 0x00E6C8B0 File Offset: 0x00E68CB0
	private unsafe 6B147225.68EF01A4 5EC14AE2(6B147225.68EF01A4 618A07CF, 6B147225.68EF01A4 059517B2, bool 677C2C69, bool 2CB33AD1)
	{
		uint num;
		long 7B2365FA;
		double num35;
		double num36;
		int 5EEF;
		6B147225.2EF54896 2EF;
		IntPtr intPtr2;
		long value2;
		6B147225.2EF54896 2EF4;
		for (;;)
		{
			IL_00:
			num = 975259725U;
			num >>= 14;
			TypeCode typeCode = this.31801837(618A07CF, 059517B2);
			int num14;
			long num30;
			long num31;
			for (;;)
			{
				TypeCode typeCode2 = typeCode;
				num = 408558361U / num;
				uint num2 = num ^ 6854U;
				num = 539777961U / num;
				switch (typeCode2 - num2)
				{
				case 0:
				{
					num = (279981985U | num);
					num = 69993597U << (int)num;
					if (2CB33AD1)
					{
						goto Block_0;
					}
					num |= 1336623227U;
					num = 382498689U * num;
					int num3 = 618A07CF.EDAECC1C();
					num += 55146567U;
					int num4 = num3;
					if ((461190875U & num) == 0U)
					{
						goto IL_00;
					}
					num = 1579250393U % num;
					int num5 = 059517B2.EDAECC1C();
					if (521673238U != num)
					{
						goto Block_6;
					}
					continue;
				}
				case 1:
					num = (704209700U | num);
					num = 1486162823U - num;
					if (2CB33AD1)
					{
						num = (138023664U | num);
						uint num6 = 618A07CF.786A7318();
						num = 82800854U / num;
						uint num7 = num6;
						if (num == 784663488U)
						{
							goto IL_00;
						}
						uint num8 = 059517B2.786A7318();
						if (1623918190U == num)
						{
							goto IL_00;
						}
						num += 440271088U;
						int num11;
						if (!677C2C69)
						{
							num = 244986784U - num;
							if (798520863U >= num)
							{
								goto IL_00;
							}
							int num9 = (int)num7;
							int num10 = (int)num8;
							num = 1666135618U << (int)num;
							num11 = num9 - num10;
						}
						else
						{
							int num12 = (int)num7;
							num = 1682918102U + num;
							int num13 = (int)num8;
							num = 70197510U * num;
							num11 = checked(num12 - num13);
							num ^= 422333604U;
						}
						num14 = num11;
					}
					else
					{
						if (num / 1645765426U != 0U)
						{
							continue;
						}
						num = 1161064155U % num;
						int num15 = 618A07CF.EDAECC1C();
						num += 1286352787U;
						int num16 = num15;
						num = (1303147848U | num);
						if (num < 1832086442U)
						{
							break;
						}
						num = (717051447U ^ num);
						int num17 = 059517B2.EDAECC1C();
						num = (78596304U ^ num);
						int num18 = num17;
						if (num < 891963206U)
						{
							break;
						}
						int num21;
						if (!677C2C69)
						{
							num -= 2044529064U;
							int num19 = num16;
							int num20 = num18;
							num >>= 23;
							num21 = num19 - num20;
						}
						else
						{
							num %= 642349615U;
							if ((951196568U & num) == 0U)
							{
								break;
							}
							int num22 = num16;
							num = 1801676931U + num;
							int num23 = num18;
							num %= 2108751999U;
							num21 = checked(num22 - num23);
							num += 4137134641U;
						}
						num = (643250163U ^ num);
						num14 = num21;
						num += 267045277U;
					}
					num >>= 6;
					if (618A07CF.39440F35() == typeCode)
					{
						goto IL_7BC;
					}
					if (1029074341U % num != 0U)
					{
						goto Block_46;
					}
					continue;
				case 2:
				{
					if (num >= 675115191U)
					{
						goto IL_00;
					}
					num ^= 292975667U;
					if (!2CB33AD1)
					{
						goto IL_279;
					}
					ulong num24 = 618A07CF.5C835FEF();
					if (151086217U + num == 0U)
					{
						continue;
					}
					ulong num25 = 059517B2.5C835FEF();
					num = 668816990U - num;
					ulong num26 = num25;
					num = 978799848U % num;
					long num28;
					if (!677C2C69)
					{
						num >>= 10;
						long num27 = (long)num24;
						num *= 410723616U;
						num28 = num27 - (long)num26;
					}
					else
					{
						if (num >> 5 == 0U)
						{
							break;
						}
						num28 = (long)(checked(num24 - num26));
						num += 4021387810U;
					}
					7B2365FA = num28;
					if (843406317U != num)
					{
						goto Block_14;
					}
					continue;
				}
				case 3:
				{
					num = (1109852674U & num);
					if (2CB33AD1)
					{
						goto Block_48;
					}
					num = 913723924U * num;
					long num29 = 618A07CF.DA78F42D();
					num *= 735976999U;
					num30 = num29;
					num &= 1079194479U;
					num31 = 059517B2.DA78F42D();
					num = 779553569U * num;
					if (num == 1557405394U)
					{
						continue;
					}
					if (677C2C69)
					{
						goto IL_964;
					}
					num = (74933044U ^ num);
					if (num != 1818838460U)
					{
						goto Block_56;
					}
					continue;
				}
				case 4:
				{
					num *= 308617878U;
					if (num <= 280121682U)
					{
						goto IL_00;
					}
					num += 1942581537U;
					6B147225.68EF01A4 68EF01A;
					if (!2CB33AD1)
					{
						if (num * 222512476U == 0U)
						{
							continue;
						}
						68EF01A = 618A07CF;
					}
					else
					{
						num = (1770281992U | num);
						if (1569345252U / num != 0U)
						{
							continue;
						}
						68EF01A = 618A07CF.0C5BC4A1();
						num += 4152339456U;
					}
					num |= 214050005U;
					float num32 = 68EF01A.B55103C5();
					if (790380840U + num == 0U)
					{
						goto IL_00;
					}
					6B147225.68EF01A4 68EF01A2;
					if (!2CB33AD1)
					{
						if (801464156U * num == 0U)
						{
							break;
						}
						68EF01A2 = 059517B2;
					}
					else
					{
						num %= 1438533620U;
						if ((356589967U & num) == 0U)
						{
							goto IL_00;
						}
						num = 1394112771U >> (int)num;
						68EF01A2 = 059517B2.0C5BC4A1();
						num ^= 4025429829U;
					}
					num = 1369769200U / num;
					float num33 = 68EF01A2.B55103C5();
					num = (356192169U | num);
					float num34 = num33;
					if ((211572925U ^ num) != 0U)
					{
						goto Block_25;
					}
					continue;
				}
				case 5:
				{
					if (377311056U >> (int)num == 0U)
					{
						goto IL_00;
					}
					num = (22182419U ^ num);
					6B147225.68EF01A4 68EF01A3;
					if (!2CB33AD1)
					{
						num >>= 27;
						68EF01A3 = 618A07CF;
					}
					else
					{
						num = (1846036943U ^ num);
						num = 1084314774U >> (int)num;
						68EF01A3 = 618A07CF.0C5BC4A1();
						num += 4278024878U;
					}
					num35 = 68EF01A3.8CC4ACA1();
					num &= 341252797U;
					6B147225.68EF01A4 68EF01A4;
					if (!2CB33AD1)
					{
						68EF01A4 = 059517B2;
					}
					else
					{
						num &= 1354180174U;
						if (173611382U < num)
						{
							break;
						}
						68EF01A4 = 059517B2.0C5BC4A1();
						num += 0U;
					}
					num36 = 68EF01A4.8CC4ACA1();
					num = 769000754U << (int)num;
					if (472010618U < num)
					{
						num -= 852822841U;
						if (677C2C69)
						{
							goto IL_5A5;
						}
						num = 269947586U << (int)num;
						if ((num ^ 842103727U) != 0U)
						{
							goto Block_33;
						}
						continue;
					}
					break;
				}
				}
				goto IL_55;
			}
			Block_0:
			if (948573455U * num == 0U)
			{
				continue;
			}
			IL_88:
			num = (1592360300U & num);
			uint num37 = 618A07CF.786A7318();
			if (2103868970U % num == 0U)
			{
				break;
			}
			num = 113982332U - num;
			uint num38 = 059517B2.786A7318();
			num >>= 6;
			int num40;
			if (!677C2C69)
			{
				if (num << 8 == 0U)
				{
					continue;
				}
				int num39 = (int)num37;
				num = 1036336738U >> (int)num;
				num40 = num39 - (int)num38;
			}
			else
			{
				num40 = (int)(checked(num37 - num38));
				num += 4245078332U;
			}
			5EEF = num40;
			if (485576943U >> (int)num == 0U)
			{
				continue;
			}
			IL_1BD:
			num = 634807723U - num;
			if (1871928000U > num)
			{
				goto Block_8;
			}
			goto IL_88;
			Block_6:
			int num43;
			if (!677C2C69)
			{
				num <<= 10;
				int num4;
				int num41 = num4;
				num |= 41122895U;
				int num5;
				int num42 = num5;
				num = (2023115595U ^ num);
				num43 = num41 - num42;
			}
			else
			{
				int num4;
				int num5;
				num43 = checked(num4 - num5);
				num ^= 1097234579U;
			}
			num &= 46876481U;
			5EEF = num43;
			num += 4248364841U;
			goto IL_1BD;
			IL_5A5:
			num += 149374912U;
			if ((986131363U & num) != 0U)
			{
				goto Block_34;
			}
			continue;
			IL_7CC:
			6B147225.2EF54896 2EF2;
			2EF = 2EF2;
			int value = num14;
			num += 1570716422U;
			IntPtr intPtr = new IntPtr(value);
			num = 640838747U / num;
			intPtr2 = intPtr;
			if (1479047866U != num)
			{
				goto Block_47;
			}
			continue;
			IL_7BC:
			2EF2 = (6B147225.2EF54896)618A07CF;
			num += 4294965248U;
			goto IL_7CC;
			Block_46:
			num &= 1809671309U;
			2EF2 = (6B147225.2EF54896)059517B2;
			goto IL_7CC;
			Block_48:
			num >>= 26;
			num = 1396577846U * num;
			ulong num44 = 618A07CF.5C835FEF();
			num = 618414337U * num;
			ulong num45 = num44;
			num = 1483411769U - num;
			num = 400963443U << (int)num;
			ulong num46 = 059517B2.5C835FEF();
			if (num == 1407549250U)
			{
				continue;
			}
			long num48;
			if (!677C2C69)
			{
				if ((num & 50865935U) == 0U)
				{
					continue;
				}
				long num47 = (long)num45;
				num = (2003975968U & num);
				num48 = num47 - (long)num46;
			}
			else
			{
				if ((2037348333U ^ num) == 0U)
				{
					continue;
				}
				num48 = (long)(checked(num45 - num46));
				num ^= 2147483648U;
			}
			value2 = num48;
			if (num == 509430726U)
			{
				continue;
			}
			IL_999:
			num = 2137735893U % num;
			if (num >= 984961036U)
			{
				continue;
			}
			TypeCode typeCode3 = 618A07CF.39440F35();
			num ^= 247863427U;
			TypeCode typeCode4 = typeCode;
			num *= 1728000293U;
			6B147225.2EF54896 2EF3;
			if (typeCode3 != typeCode4)
			{
				2EF3 = (6B147225.2EF54896)059517B2;
			}
			else
			{
				2EF3 = (6B147225.2EF54896)618A07CF;
				num += 0U;
			}
			2EF4 = 2EF3;
			num >>= 30;
			if (num < 1923689399U)
			{
				goto Block_59;
			}
			continue;
			IL_98D:
			long num49;
			value2 = num49;
			num ^= 1536108231U;
			goto IL_999;
			IL_964:
			long num50 = num30;
			num = 1415721691U * num;
			long num51 = num31;
			num = 1837198670U >> (int)num;
			num49 = checked(num50 - num51);
			num ^= 1032791722U;
			goto IL_98D;
			Block_56:
			long num52 = num30;
			long num53 = num31;
			num = 207105675U + num;
			num49 = num52 - num53;
			goto IL_98D;
		}
		IL_55:
		num = 773071039U / num;
		throw new InvalidOperationException();
		Block_8:
		return new 6B147225.1F462BA1(5EEF);
		Block_14:
		goto IL_33B;
		IL_279:
		num = 2048347489U - num;
		num = 856387419U << (int)num;
		long num54 = 618A07CF.DA78F42D();
		num = (1816875876U ^ num);
		long num55 = num54;
		num = 838336922U % num;
		if (num % 1387275445U == 0U)
		{
			goto IL_55;
		}
		num = 1673820944U - num;
		long num56 = 059517B2.DA78F42D();
		num = 843581470U >> (int)num;
		long num57 = num56;
		num |= 398264060U;
		long num60;
		if (!677C2C69)
		{
			long num58 = num55;
			num = (1589461517U | num);
			long num59 = num57;
			num = 2067813859U + num;
			num60 = num58 - num59;
		}
		else
		{
			long num61 = num55;
			long num62 = num57;
			num = (1241193329U | num);
			num60 = checked(num61 - num62);
			num += 2063498467U;
		}
		num <<= 14;
		7B2365FA = num60;
		num ^= 2583998560U;
		IL_33B:
		return new 6B147225.58E136FA(7B2365FA);
		Block_25:
		float 2DBD116A;
		if (!677C2C69)
		{
			num <<= 5;
			float num32;
			float num63 = num32;
			num = 940055863U >> (int)num;
			float num34;
			float num64 = num34;
			num += 1710564753U;
			2DBD116A = num63 - num64;
		}
		else
		{
			num %= 601506930U;
			float num32;
			float num65 = num32;
			num = 1229459185U - num;
			float num34;
			2DBD116A = num65 - num34;
			num ^= 2851192192U;
		}
		return new 6B147225.1F5C5947(2DBD116A);
		Block_33:
		double num66 = num35;
		num <<= 21;
		double num67 = num36;
		num = (712247739U ^ num);
		double 406C = num66 - num67;
		goto IL_5DB;
		Block_34:
		double num68 = num35;
		num = 1871929610U << (int)num;
		406C = num68 - num36;
		num += 376703419U;
		IL_5DB:
		num = 1677334617U * num;
		return new 6B147225.60416C9D(406C);
		Block_47:
		num -= 514022409U;
		void* ptr = intPtr2.ToPointer();
		num = (1241538182U | num);
		object 286A427D = Pointer.Box(ptr, 2EF.0B2A827C());
		6B147225.68EF01A4 68EF01A5 = 2EF;
		num -= 53020308U;
		return new 6B147225.2EF54896(286A427D, 68EF01A5.0B2A827C());
		Block_59:
		IntPtr intPtr3 = new IntPtr(value2);
		num = (1703036890U & num);
		intPtr2 = intPtr3;
		void* ptr2 = intPtr2.ToPointer();
		num = (1185363414U ^ num);
		object 286A427D2 = Pointer.Box(ptr2, 2EF4.0B2A827C());
		num |= 757747111U;
		6B147225.68EF01A4 68EF01A6 = 2EF4;
		num = 1260223696U - num;
		return new 6B147225.2EF54896(286A427D2, 68EF01A6.0B2A827C());
	}

	// Token: 0x0600037F RID: 895 RVA: 0x00E6D320 File Offset: 0x00E69720
	private 6B147225.68EF01A4 32B739C2(6B147225.68EF01A4 2EF254CC, 6B147225.68EF01A4 037861FA, bool 6556234C, bool 6338003D)
	{
		uint num = 573711823U;
		if (1971654731U > num)
		{
			goto IL_13;
		}
		goto IL_70;
		TypeCode typeCode;
		for (;;)
		{
			IL_34:
			uint num2 = (uint)typeCode;
			num = 1441934743U * num;
			switch (num2 - (num ^ 3446396401U))
			{
			case 0U:
				goto IL_75;
			case 1U:
			case 3U:
				goto IL_5BF;
			case 2U:
				num = 1848803165U - num;
				if (6338003D)
				{
					goto Block_9;
				}
				if (629676593U < num)
				{
					goto Block_13;
				}
				continue;
			case 4U:
				if (1868768315U + num != 0U)
				{
					goto Block_16;
				}
				continue;
			case 5U:
				goto IL_494;
			}
			break;
		}
		num ^= 0U;
		goto IL_70;
		Block_9:
		num = (1364682269U | num);
		num = 2007241754U * num;
		ulong num3 = 2EF254CC.5C835FEF();
		num <<= 31;
		ulong num4 = num3;
		long num9;
		if (num <= 1576095824U)
		{
			ulong num5 = 037861FA.5C835FEF();
			num = (356730387U ^ num);
			long num6;
			if (!6556234C)
			{
				num = 325410107U % num;
				num6 = (long)(num4 * num5);
			}
			else
			{
				num = 1105148879U - num;
				if (1295647701U == num)
				{
					goto IL_13;
				}
				long num7 = (long)num4;
				long num8 = (long)num5;
				num = 104547562U % num;
				num6 = checked(num7 * num8);
				num += 220862545U;
			}
			num = (1892711074U | num);
			num9 = num6;
			goto IL_334;
		}
		goto IL_13;
		Block_13:
		long num10 = 2EF254CC.DA78F42D();
		num = (1276908483U & num);
		long num11 = num10;
		num = 905522478U * num;
		long num12 = 037861FA.DA78F42D();
		num = 48441951U >> (int)num;
		num *= 854665090U;
		long num14;
		if (!6556234C)
		{
			long num13 = num11;
			num /= 129329514U;
			num14 = num13 * num12;
		}
		else
		{
			num14 = checked(num11 * num12);
			num ^= 949235999U;
		}
		num9 = num14;
		num += 1945468852U;
		IL_334:
		num = 947415584U * num;
		if ((1509913544U & num) != 0U)
		{
			long 7B2365FA = num9;
			num = 1944399430U / num;
			return new 6B147225.58E136FA(7B2365FA);
		}
		goto IL_75;
		Block_16:
		6B147225.68EF01A4 68EF01A;
		if (!6338003D)
		{
			if (num + 2093438921U == 0U)
			{
				goto IL_70;
			}
			68EF01A = 2EF254CC;
		}
		else
		{
			num = (1318806386U | num);
			if (num * 1233134186U == 0U)
			{
				goto IL_13;
			}
			num /= 1433101469U;
			68EF01A = 2EF254CC.0C5BC4A1();
			num ^= 3446396410U;
		}
		num = (1141844243U | num);
		float num15 = 68EF01A.B55103C5();
		num /= 1650211908U;
		float num16 = num15;
		if (1442269343U >= num)
		{
			num %= 772690737U;
			6B147225.68EF01A4 68EF01A2;
			if (!6338003D)
			{
				68EF01A2 = 037861FA;
			}
			else
			{
				num = (1596924868U ^ num);
				num &= 516187691U;
				68EF01A2 = 037861FA.0C5BC4A1();
				num ^= 503587328U;
			}
			float num17 = 68EF01A2.B55103C5();
			num = 1894342536U % num;
			float num18 = num17;
			num %= 676026203U;
			num -= 333528258U;
			double num21;
			if (!6556234C)
			{
				num = (1872777318U & num);
				double num19 = (double)num16;
				num = 563029167U % num;
				double num20 = (double)num18;
				num = 2051497037U / num;
				num21 = num19 * num20;
			}
			else
			{
				num /= 443509166U;
				double num22 = (double)num16;
				double num23 = (double)num18;
				num >>= 30;
				num21 = num22 * num23;
				num += 3U;
			}
			return new 6B147225.60416C9D(num21);
		}
		goto IL_B2;
		IL_494:
		num = (1109417504U & num);
		if (num < 838552998U)
		{
			goto IL_70;
		}
		6B147225.68EF01A4 68EF01A3;
		if (!6338003D)
		{
			68EF01A3 = 2EF254CC;
		}
		else
		{
			if (num == 481254740U)
			{
				goto IL_70;
			}
			68EF01A3 = 2EF254CC.0C5BC4A1();
			num ^= 0U;
		}
		double num24 = 68EF01A3.8CC4ACA1();
		num = (1551201048U | num);
		if ((num ^ 789347869U) == 0U)
		{
			goto IL_70;
		}
		num &= 1685020239U;
		6B147225.68EF01A4 68EF01A4;
		if (!6338003D)
		{
			num += 575617479U;
			if (1539972466U == num)
			{
				goto IL_13;
			}
			68EF01A4 = 037861FA;
		}
		else
		{
			num |= 1507882194U;
			num ^= 1072966715U;
			68EF01A4 = 037861FA.0C5BC4A1();
			num ^= 77976878U;
		}
		double num25 = 68EF01A4.8CC4ACA1();
		num = 342701209U >> (int)num;
		if (num != 1603630181U)
		{
			double 406C;
			if (!6556234C)
			{
				num &= 1403419103U;
				if (1597209200 << (int)num == 0)
				{
					goto IL_13;
				}
				double num26 = num24;
				num <<= 1;
				406C = num26 * num25;
			}
			else
			{
				double num27 = num24;
				num = (837356330U ^ num);
				406C = num27 * num25;
				num += 3457625540U;
			}
			num = (1541701384U ^ num);
			return new 6B147225.60416C9D(406C);
		}
		IL_13:
		num >>= 14;
		typeCode = this.31801837(2EF254CC, 037861FA);
		if (1808996359U / num != 0U)
		{
			goto IL_34;
		}
		IL_70:
		goto IL_5BF;
		IL_75:
		num = (547572010U | num);
		if (num < 394203428U)
		{
			goto IL_70;
		}
		num -= 405765847U;
		int 5EEF;
		if (6338003D)
		{
			num = 1683111799U % num;
			if (1838096517U == num)
			{
				goto IL_34;
			}
		}
		else
		{
			num <<= 9;
			num -= 1167159313U;
			int num28 = 2EF254CC.EDAECC1C();
			num %= 1170493860U;
			int num29 = num28;
			if (num > 275005481U)
			{
				num = 1920691139U / num;
				int num30 = 037861FA.EDAECC1C();
				num = 635641872U / num;
				int num31 = num30;
				num = 1440434480U * num;
				int num33;
				if (!6556234C)
				{
					int num32 = num29;
					num <<= 27;
					num33 = num32 * num31;
				}
				else
				{
					if (33450026U > num)
					{
						goto IL_13;
					}
					int num34 = num29;
					int num35 = num31;
					num %= 303899380U;
					num33 = checked(num34 * num35);
					num += 4198449744U;
				}
				5EEF = num33;
				num += 3892314112U;
				goto IL_1F4;
			}
			goto IL_13;
		}
		IL_B2:
		uint num36 = 2EF254CC.786A7318();
		num >>= 20;
		uint num37 = num36;
		if (num % 1350123182U == 0U)
		{
			goto IL_13;
		}
		uint num38 = 037861FA.786A7318();
		num = 1098407714U + num;
		uint num39 = num38;
		num = (1101332519U ^ num);
		int num40;
		if (!6556234C)
		{
			num = 1075186843U << (int)num;
			num40 = (int)(num37 * num39);
		}
		else
		{
			num = 1180334377U << (int)num;
			int num41 = (int)num37;
			num = 776750567U + num;
			int num42 = (int)num39;
			num = 983135958U / num;
			num40 = checked(num41 * num42);
			num += 1075186843U;
		}
		num = 1043954333U << (int)num;
		5EEF = num40;
		IL_1F4:
		num >>= 3;
		return new 6B147225.1F462BA1(5EEF);
		IL_5BF:
		if (num / 1677199315U != 0U)
		{
			throw new InvalidOperationException();
		}
		goto IL_75;
	}

	// Token: 0x06000380 RID: 896 RVA: 0x00E6D900 File Offset: 0x00E69D00
	private 6B147225.68EF01A4 5F6F1AAB(6B147225.68EF01A4 744052AE, 6B147225.68EF01A4 74F14EB3, bool 543C4DE0)
	{
		uint num = 46946255U;
		int num6;
		for (;;)
		{
			IL_07:
			num = 436930495U - num;
			TypeCode typeCode = this.31801837(744052AE, 74F14EB3);
			num |= 827405718U;
			TypeCode typeCode2 = typeCode;
			num ^= 1161232781U;
			if (1350062806U >> (int)num != 0U)
			{
				do
				{
					object obj = typeCode2;
					object obj2 = num - 1917369970U;
					num = 508310189U * num;
					object obj3 = obj - obj2;
					num = 1971339159U + num;
					switch (obj3)
					{
					case 0:
						if (num % 400436794U == 0U)
						{
							goto IL_07;
						}
						if (!543C4DE0)
						{
							goto IL_11D;
						}
						num |= 1335175603U;
						if ((num & 277566203U) == 0U)
						{
							goto IL_07;
						}
						break;
					case 1:
					case 3:
						goto IL_3A5;
					case 2:
						num &= 1230059483U;
						if (num - 1784689642U == 0U)
						{
							goto IL_07;
						}
						if (!543C4DE0)
						{
							goto IL_1D6;
						}
						if (731980289U <= num)
						{
							goto Block_9;
						}
						continue;
					case 4:
						goto IL_235;
					case 5:
						goto IL_300;
					default:
						if (232210009U % num != 0U)
						{
							goto Block_2;
						}
						break;
					}
					num %= 1394295234U;
					int num2 = (int)744052AE.786A7318();
					num = 1595757810U >> (int)num;
					uint num3 = 74F14EB3.786A7318();
					num = (770929539U & num);
					uint num4 = num3;
					num = (340015525U & num);
					int num5 = num2 / (int)num4;
					num += 1126584707U;
					num6 = num5;
				}
				while (num >= 2004905061U);
				IL_164:
				if (2075617066 << (int)num != 0)
				{
					goto Block_6;
				}
				continue;
				IL_11D:
				num = 1572166832U % num;
				if (num / 1511467985U == 0U)
				{
					goto IL_93;
				}
				num |= 1087531596U;
				int num7 = 744052AE.EDAECC1C();
				int num8 = 74F14EB3.EDAECC1C();
				num %= 56977860U;
				int num9 = num8;
				num6 = num7 / num9;
				num ^= 1097008212U;
				IL_118:
				goto IL_164;
				IL_300:
				num -= 2068982446U;
				if (543C4DE0)
				{
					goto IL_322;
				}
				if (1862271148U >= num)
				{
					goto Block_15;
				}
				goto IL_118;
				IL_235:
				num = 1655911610U >> (int)num;
				if (506093757U != num)
				{
					num &= 1167926659U;
					if (543C4DE0)
					{
						goto IL_273;
					}
					if (332802412U > num)
					{
						goto Block_12;
					}
				}
			}
		}
		Block_2:
		num += 0U;
		IL_93:
		goto IL_3A5;
		Block_6:
		int 5EEF = num6;
		num = 732722926U >> (int)num;
		return new 6B147225.1F462BA1(5EEF);
		Block_9:
		long num10 = (long)744052AE.5C835FEF();
		ulong num11 = 74F14EB3.5C835FEF();
		long num12 = num10 / (long)num11;
		num ^= 579291426U;
		long 7B2365FA = num12;
		goto IL_22E;
		IL_1D6:
		num *= 798043703U;
		long num13 = 744052AE.DA78F42D();
		num -= 1829322016U;
		num = 566907555U - num;
		long num14 = 74F14EB3.DA78F42D();
		num %= 1902410813U;
		long num15 = num14;
		num >>= 25;
		long num16 = num13 / num15;
		num <<= 28;
		7B2365FA = num16;
		num ^= 3670507440U;
		IL_22E:
		return new 6B147225.58E136FA(7B2365FA);
		Block_12:
		6B147225.68EF01A4 68EF01A = 744052AE;
		goto IL_293;
		IL_273:
		num = 1457402897U >> (int)num;
		68EF01A = 744052AE.0C5BC4A1();
		num ^= 364350598U;
		IL_293:
		num *= 1256207299U;
		float num17 = 68EF01A.B55103C5();
		num -= 1394301471U;
		6B147225.68EF01A4 68EF01A2;
		if (!543C4DE0)
		{
			68EF01A2 = 74F14EB3;
		}
		else
		{
			68EF01A2 = 74F14EB3.0C5BC4A1();
			num += 0U;
		}
		float num18 = 68EF01A2.B55103C5();
		num /= 757218579U;
		float num19 = num18;
		num %= 73170751U;
		float num20 = num19;
		num = 1496526554U + num;
		float 2DBD116A = num17 / num20;
		num = (85478925U & num);
		return new 6B147225.1F5C5947(2DBD116A);
		Block_15:
		6B147225.68EF01A4 68EF01A3 = 744052AE;
		goto IL_33C;
		IL_322:
		num /= 1917592314U;
		68EF01A3 = 744052AE.0C5BC4A1();
		num ^= 1628361736U;
		IL_33C:
		double num21 = 68EF01A3.8CC4ACA1();
		num &= 303659196U;
		6B147225.68EF01A4 68EF01A4;
		if (!543C4DE0)
		{
			num = 2080314354U >> (int)num;
			68EF01A4 = 74F14EB3;
		}
		else
		{
			num = (137499166U ^ num);
			68EF01A4 = 74F14EB3.0C5BC4A1();
			num += 4165057789U;
		}
		double num22 = 68EF01A4.8CC4ACA1();
		num %= 40795512U;
		double num23 = num22;
		num <<= 28;
		return new 6B147225.60416C9D(num21 / num23);
		IL_3A5:
		num = 1875071700U * num;
		throw new InvalidOperationException();
	}

	// Token: 0x06000381 RID: 897 RVA: 0x00E6DCC4 File Offset: 0x00E6A0C4
	private 6B147225.68EF01A4 0E200672(6B147225.68EF01A4 3A2D41CB, 6B147225.68EF01A4 7CCD6FE7, bool 1D2A68DF)
	{
		uint num2;
		for (;;)
		{
			TypeCode typeCode = 3A2D41CB.39440F35();
			TypeCode typeCode2 = typeCode;
			int num = 9;
			num2 = 472148555U;
			if (typeCode2 != num)
			{
				num2 = (1467564070U | num2);
				if (1870344502U < num2)
				{
					continue;
				}
			}
			else
			{
				num2 = 481391241U >> (int)num2;
				if (1D2A68DF)
				{
					num2 *= 516316698U;
					if (1128611848 << (int)num2 != 0)
					{
						goto Block_4;
					}
				}
				else if (num2 != 2001555027U)
				{
					goto Block_5;
				}
			}
			TypeCode typeCode3 = typeCode;
			uint num3 = num2 + 2692912540U;
			num2 = (356995524U | num2);
			if (typeCode3 != num3)
			{
				if (num2 < 1821131822U)
				{
					break;
				}
			}
			else
			{
				num2 -= 1432507995U;
				num2 = 1881235848U - num2;
				if (!1D2A68DF)
				{
					goto IL_15C;
				}
				num2 = 2087322109U % num2;
				if (num2 < 513228075U)
				{
					goto Block_7;
				}
			}
		}
		throw new InvalidOperationException();
		Block_4:
		num2 = 907373545U << (int)num2;
		int num4 = (int)3A2D41CB.786A7318();
		num2 ^= 1904551456U;
		uint num5 = 7CCD6FE7.786A7318();
		int 5EEF = num4 % (int)num5;
		num2 <<= 1;
		return new 6B147225.1F462BA1(5EEF);
		Block_5:
		num2 = 1623790419U / num2;
		int num6 = 3A2D41CB.EDAECC1C();
		num2 |= 1373701279U;
		int num7 = 7CCD6FE7.EDAECC1C();
		num2 = 1160069860U - num2;
		int num8 = num7;
		int num9 = num8;
		num2 = (1754751797U | num2);
		int 5EEF2 = num6 % num9;
		num2 = 1228679671U % num2;
		return new 6B147225.1F462BA1(5EEF2);
		Block_7:
		num2 ^= 853153794U;
		long num10 = (long)3A2D41CB.5C835FEF();
		num2 = (1093097439U & num2);
		num2 ^= 925116020U;
		ulong num11 = 7CCD6FE7.5C835FEF();
		long 7B2365FA = num10 % (long)num11;
		num2 = 1517833418U >> (int)num2;
		return new 6B147225.58E136FA(7B2365FA);
		IL_15C:
		num2 <<= 3;
		num2 *= 1930509963U;
		long num12 = 3A2D41CB.DA78F42D();
		num2 ^= 153630282U;
		long num13 = 7CCD6FE7.DA78F42D();
		num2 = (2128354194U ^ num2);
		long num14 = num13;
		num2 &= 2076384606U;
		return new 6B147225.58E136FA(num12 % num14);
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00E6DE74 File Offset: 0x00E6A274
	private 6B147225.68EF01A4 1EDC252D(6B147225.68EF01A4 15B20018, 6B147225.68EF01A4 4C396C0B)
	{
		uint num = 236659064U;
		for (;;)
		{
			IL_06:
			num = 48839167U - num;
			num = 548351419U << (int)num;
			TypeCode typeCode = this.31801837(15B20018, 4C396C0B);
			num >>= 15;
			if (num != 180687146U)
			{
				for (;;)
				{
					TypeCode typeCode2 = typeCode;
					uint num2 = num ^ 44836U;
					num = 1382966625U >> (int)num;
					switch (typeCode2 - num2)
					{
					case 0:
						goto IL_79;
					case 1:
					case 3:
						goto IL_1D3;
					case 2:
						goto IL_C4;
					case 4:
						if (1833856034 << (int)num == 0)
						{
							goto IL_06;
						}
						if (IntPtr.Size == (int)(num - 168815U))
						{
							goto IL_144;
						}
						if (num < 1013857925U)
						{
							goto Block_5;
						}
						continue;
					case 5:
						goto IL_162;
					}
					goto Block_1;
				}
				IL_144:
				if (642721513U != num)
				{
					goto Block_6;
				}
				continue;
				IL_162:
				num /= 1887962637U;
				if (num <= 1781021959U)
				{
					if (IntPtr.Size != (int)(num ^ 4U))
					{
						num |= 553085846U;
						if (1204637037U / num != 0U)
						{
							goto Block_9;
						}
					}
					else
					{
						num |= 1412845987U;
						if (num * 1561203742U != 0U)
						{
							goto Block_10;
						}
					}
				}
			}
		}
		Block_1:
		num ^= 0U;
		IL_74:
		goto IL_1D3;
		IL_79:
		num = 2021287008U % num;
		num <<= 23;
		int num3 = 15B20018.EDAECC1C();
		num -= 2044610156U;
		num |= 1285253063U;
		int num4 = 4C396C0B.EDAECC1C();
		num = 1998207361U >> (int)num;
		int num5 = num4;
		int 5EEF = num3 ^ num5;
		num = 393367299U % num;
		return new 6B147225.1F462BA1(5EEF);
		IL_C4:
		num = 660153147U / num;
		if (1193019996U > num)
		{
			num -= 1723605697U;
			long num6 = 15B20018.DA78F42D();
			num += 1917787493U;
			long num7 = 4C396C0B.DA78F42D();
			num %= 1636511860U;
			long num8 = num7;
			long num9 = num8;
			num = 983792236U / num;
			return new 6B147225.58E136FA(num6 ^ num9);
		}
		goto IL_74;
		Block_5:
		float 2DBD116A = 0f;
		goto IL_15C;
		Block_6:
		2DBD116A = float.NaN;
		num ^= 0U;
		IL_15C:
		return new 6B147225.1F5C5947(2DBD116A);
		Block_9:
		double 406C = 0.0;
		goto IL_1CD;
		Block_10:
		406C = double.NaN;
		num += 3435207155U;
		IL_1CD:
		return new 6B147225.60416C9D(406C);
		IL_1D3:
		num = (1901876327U | num);
		throw new InvalidOperationException();
	}

	// Token: 0x06000383 RID: 899 RVA: 0x00E6E064 File Offset: 0x00E6A464
	private 6B147225.68EF01A4 68840CCE(6B147225.68EF01A4 4D673E8B, 6B147225.68EF01A4 64641C3E)
	{
		uint num = 254113351U;
		if (1776880387U <= num)
		{
			goto IL_BF;
		}
		for (;;)
		{
			IL_11:
			num += 1876124127U;
			num ^= 150631824U;
			TypeCode typeCode = this.31801837(4D673E8B, 64641C3E);
			num = (2060335410U | num);
			if (num <= 777865420U)
			{
				goto IL_73;
			}
			for (;;)
			{
				uint num2 = (uint)typeCode;
				num += 533872976U;
				switch (num2 - (num ^ 2661351183U))
				{
				case 0U:
					num = 1219635725U % num;
					if (1407610604U - num != 0U)
					{
						goto Block_2;
					}
					continue;
				case 1U:
				case 3U:
					goto IL_1A7;
				case 2U:
					goto IL_BF;
				case 4U:
					goto IL_105;
				case 5U:
					goto IL_15B;
				}
				goto Block_1;
			}
			IL_105:
			if (16922069U * num != 0U)
			{
				if (IntPtr.Size != (int)(num + 1633616126U))
				{
					goto Block_5;
				}
				num /= 698638839U;
				if ((num & 785204552U) == 0U)
				{
					goto Block_6;
				}
			}
		}
		Block_1:
		num ^= 0U;
		goto IL_73;
		Block_2:
		int num3 = 4D673E8B.EDAECC1C();
		num |= 89794909U;
		int num4 = 64641C3E.EDAECC1C();
		num = 1046886838U / num;
		int num5 = num4;
		num = 1478258944U >> (int)num;
		return new 6B147225.1F462BA1(num3 | num5);
		Block_5:
		float 2DBD116A = 0f;
		goto IL_14D;
		Block_6:
		2DBD116A = float.NaN;
		num += 2661351171U;
		IL_14D:
		num |= 271531615U;
		return new 6B147225.1F5C5947(2DBD116A);
		IL_15B:
		uint size = (uint)IntPtr.Size;
		num = (1722964003U & num);
		double 406C;
		if (size != num - 111171582U)
		{
			406C = 0.0;
		}
		else
		{
			num = 1429807846U >> (int)num;
			406C = double.NaN;
			num += 4048686921U;
		}
		return new 6B147225.60416C9D(406C);
		IL_73:
		goto IL_1A7;
		IL_BF:
		if (num != 288373316U)
		{
			num ^= 252931765U;
			long num6 = 4D673E8B.DA78F42D();
			num = 608206066U >> (int)num;
			long num7 = 64641C3E.DA78F42D();
			num = 2012028884U * num;
			long num8 = num7;
			num %= 653530140U;
			return new 6B147225.58E136FA(num6 | num8);
		}
		IL_1A7:
		if (num > 684474004U)
		{
			throw new InvalidOperationException();
		}
		goto IL_11;
	}

	// Token: 0x06000384 RID: 900 RVA: 0x00E6E228 File Offset: 0x00E6A628
	private 6B147225.68EF01A4 416E39C3(6B147225.68EF01A4 78EF14CD, 6B147225.68EF01A4 2F534991)
	{
		uint num = 1616861462U;
		if (340485934U < num)
		{
			goto IL_11;
		}
		goto IL_79;
		TypeCode typeCode;
		for (;;)
		{
			IL_3A:
			switch (typeCode - (TypeCode)(num ^ 9694063U))
			{
			case 0:
				goto IL_79;
			case 1:
			case 3:
				IL_1B4:
				if ((1258246080U ^ num) != 0U)
				{
					goto Block_9;
				}
				continue;
			case 2:
				goto IL_B9;
			case 4:
				if (num != 1887699424U)
				{
					goto Block_4;
				}
				continue;
			case 5:
				num = 466032014U * num;
				if (1218732887U >= num)
				{
					goto Block_7;
				}
				break;
			default:
				if (1116085892U * num == 0U)
				{
					continue;
				}
				num ^= 0U;
				break;
			}
			goto IL_1B4;
		}
		IL_B9:
		num -= 36728467U;
		long num2 = 78EF14CD.DA78F42D();
		num = (1759848942U | num);
		num |= 358815703U;
		long num3 = 2F534991.DA78F42D();
		num = 2106722572U % num;
		long num4 = num3;
		num <<= 3;
		long 7B2365FA = num2 & num4;
		num = (1731811946U ^ num);
		return new 6B147225.58E136FA(7B2365FA);
		Block_4:
		float 2DBD116A;
		if (IntPtr.Size != (int)(num - 9694050U))
		{
			num = 139935990U % num;
			if (num / 833056205U != 0U)
			{
				goto IL_11;
			}
			2DBD116A = 0f;
		}
		else
		{
			num &= 1764184744U;
			2DBD116A = float.NaN;
			num += 4005698U;
		}
		num |= 1321936835U;
		return new 6B147225.1F5C5947(2DBD116A);
		Block_7:
		double 406C;
		if (IntPtr.Size != (int)(num ^ 849735824U))
		{
			406C = 0.0;
		}
		else
		{
			num = (233640505U ^ num);
			406C = double.NaN;
			num += 4082961895U;
		}
		num >>= 5;
		return new 6B147225.60416C9D(406C);
		Block_9:
		throw new InvalidOperationException();
		IL_11:
		num *= 1554780614U;
		num = (613031627U | num);
		num = 77552434U % num;
		TypeCode typeCode2 = this.31801837(78EF14CD, 2F534991);
		num >>= 3;
		typeCode = typeCode2;
		goto IL_3A;
		IL_79:
		if (num <= 69609884U)
		{
			num = (982452623U | num);
			int num5 = 78EF14CD.EDAECC1C();
			num -= 215313792U;
			num = (1820202314U ^ num);
			int num6 = 2F534991.EDAECC1C();
			int 5EEF = num5 & num6;
			num = 459763704U + num;
			return new 6B147225.1F462BA1(5EEF);
		}
		goto IL_3A;
	}

	// Token: 0x06000385 RID: 901 RVA: 0x00E6E3FC File Offset: 0x00E6A7FC
	private int 5E181947(6B147225.68EF01A4 60D13ED5, 6B147225.68EF01A4 787153D8, bool 5F610039, int 3D4A2977)
	{
		uint num = 349452135U;
		int num2;
		object obj3;
		for (;;)
		{
			IL_07:
			num2 = 3D4A2977;
			TypeCode typeCode2;
			for (;;)
			{
				TypeCode typeCode = 60D13ED5.39440F35();
				num = 1799950270U * num;
				typeCode2 = typeCode;
				num = 1987068176U / num;
				if (num == 1586694849U)
				{
					goto IL_07;
				}
				double num10;
				do
				{
					num = 1374841087U << (int)num;
					TypeCode typeCode3 = 787153D8.39440F35();
					num = (2052412183U | num);
					TypeCode typeCode4 = typeCode3;
					num = 402537617U >> (int)num;
					TypeCode typeCode5 = typeCode2;
					num /= 149430267U;
					uint num3 = num + 1U;
					num = 1646404263U * num;
					if (typeCode5 == num3)
					{
						goto IL_D0;
					}
					num = (1347515180U | num);
					if (1210726373 << (int)num == 0)
					{
						goto IL_07;
					}
					TypeCode typeCode6 = typeCode4;
					num = 933961378U % num;
					uint num4 = num + 3361005919U;
					num = 1394544344U % num;
					if (typeCode6 == num4)
					{
						goto Block_3;
					}
					num *= 360535150U;
					TypeCode typeCode7 = typeCode2;
					uint num5 = num + 1895764186U;
					num %= 1632196808U;
					if (typeCode7 != num5)
					{
						if (typeCode4 == (TypeCode)(num ^ 767006306U))
						{
							num ^= 0U;
						}
						else
						{
							num ^= 801793691U;
							if (1769157827 << (int)num == 0)
							{
								goto IL_07;
							}
							TypeCode typeCode8 = typeCode2;
							uint num6 = num + 4253159190U;
							num = 2096177912U / num;
							if (typeCode8 == num6)
							{
								goto IL_224;
							}
							num -= 980761484U;
							TypeCode typeCode9 = typeCode4;
							num = 297753490U % num;
							uint num7 = num ^ 297753503U;
							num ^= 182782279U;
							if (typeCode9 == num7)
							{
								goto Block_13;
							}
							if (2054576682U == num)
							{
								goto IL_07;
							}
							uint num8 = (uint)typeCode2;
							num = (391600338U | num);
							if (num8 != num - 526342860U)
							{
								uint num9 = (uint)typeCode4;
								num = 1407741176U << (int)num;
								if (num9 != (num ^ 2080374795U))
								{
									goto IL_3CE;
								}
								num ^= 1667193559U;
							}
							num <<= 30;
							if (num << 7 == 0U)
							{
								goto Block_20;
							}
							continue;
						}
					}
					num = (602809600U & num);
					num10 = 60D13ED5.8CC4ACA1();
				}
				while (693920800U <= num);
				num = 1675822215U % num;
				num2 = num10.CompareTo(787153D8.8CC4ACA1());
				if ((546701981U ^ num) != 0U)
				{
					goto Block_10;
				}
			}
			IL_D0:
			object obj = 60D13ED5.5049A7CC();
			num >>= 19;
			object obj2 = 787153D8.5049A7CC();
			num *= 1508466567U;
			obj3 = obj2;
			if (obj == obj3)
			{
				break;
			}
			num = 2093037792U >> (int)num;
			if (num != 1307588035U)
			{
				goto Block_5;
			}
			continue;
			Block_3:
			num += 3834384330U;
			goto IL_D0;
			IL_224:
			if (num >= 197608848U)
			{
				continue;
			}
			num &= 1156194622U;
			float num11 = 60D13ED5.B55103C5();
			num = 368793748U - num;
			float num12 = num11;
			num = 1424121290U - num;
			if (1085756956U == num)
			{
				continue;
			}
			num = 528162764U << (int)num;
			float value = 787153D8.B55103C5();
			num = 1426808918U >> (int)num;
			int num13 = num12.CompareTo(value);
			num ^= 597909913U;
			num2 = num13;
			if (num != 713508242U)
			{
				num ^= 1446968648U;
				goto IL_4D9;
			}
			continue;
			Block_13:
			num ^= 458904295U;
			goto IL_224;
			Block_20:
			num /= 1269306387U;
			int num16;
			if (!5F610039)
			{
				num |= 902895091U;
				long num14 = 60D13ED5.DA78F42D();
				num <<= 5;
				long num15 = num14;
				num /= 1013327561U;
				long value2 = 787153D8.DA78F42D();
				num <<= 0;
				num16 = num15.CompareTo(value2);
			}
			else
			{
				if (195389464U < num)
				{
					continue;
				}
				num <<= 30;
				ulong num17 = 60D13ED5.5C835FEF();
				num = 1850494386U + num;
				ulong num18 = num17;
				num -= 770866741U;
				num += 1866692362U;
				num16 = num18.CompareTo(787153D8.5C835FEF());
				num ^= 798836356U;
			}
			num2 = num16;
			num ^= 546765956U;
			goto IL_4D9;
			IL_3CE:
			num ^= 659453206U;
			TypeCode typeCode10 = typeCode2;
			uint num19 = num + 2763098867U;
			num |= 1634235145U;
			if (typeCode10 != num19)
			{
				num >>= 27;
				if ((2134329289U ^ num) == 0U)
				{
					continue;
				}
				TypeCode typeCode4;
				TypeCode typeCode11 = typeCode4;
				uint num20 = num ^ 6U;
				num = 2106803265U / num;
				num += 406312408U;
				if (typeCode11 != num20)
				{
					goto IL_4D9;
				}
				num ^= 1543015320U;
			}
			num /= 1685667536U;
			int num22;
			if (!5F610039)
			{
				num /= 2132164965U;
				num = (813839972U & num);
				int num21 = 60D13ED5.EDAECC1C();
				num = (104615113U | num);
				num = 1743678810U * num;
				num22 = num21.CompareTo(787153D8.EDAECC1C());
			}
			else
			{
				num %= 134035864U;
				uint num23 = 60D13ED5.786A7318();
				num = (720123742U ^ num);
				num >>= 14;
				uint value3 = 787153D8.786A7318();
				num = (1965698956U & num);
				num22 = num23.CompareTo(value3);
				num += 532834346U;
			}
			num2 = num22;
			num ^= 1062498093U;
			IL_4D9:
			num = 677673597U % num;
			if (925509674U == num)
			{
				continue;
			}
			int num24 = num2;
			uint num25 = num + 4164059658U;
			num ^= 977365172U;
			if (num24 < num25)
			{
				goto Block_28;
			}
			num = 633895845U << (int)num;
			if ((117517255U ^ num) != 0U)
			{
				goto Block_29;
			}
			continue;
			Block_10:
			goto IL_4D9;
		}
		return (int)(num + 0U);
		Block_5:
		if (obj3 != null)
		{
			return (int)(num ^ 2201929503U);
		}
		return (int)(num ^ 2093037793U);
		Block_28:
		num *= 2010538653U;
		int num26 = (int)(num ^ 768062085U);
		num = 531791751U + num;
		num2 = num26;
		goto IL_593;
		Block_29:
		int num27 = num2;
		uint num28 = num - 2535583380U;
		num = 740187048U / num;
		num ^= 4058696961U;
		if (num27 > num28)
		{
			num ^= 260252592U;
			int num29 = (int)(num ^ 4268355248U);
			num = 664345830U * num;
			num2 = num29;
			num += 702152187U;
		}
		IL_593:
		num -= 400314734U;
		return num2;
	}

	// Token: 0x06000386 RID: 902 RVA: 0x00E6E9A8 File Offset: 0x00E6ADA8
	private 6B147225.68EF01A4 3EA21B89(6B147225.68EF01A4 344039A2)
	{
		uint num;
		TypeCode typeCode2;
		do
		{
			num = 944584558U;
			TypeCode typeCode = 344039A2.39440F35();
			num = 824927128U / num;
			typeCode2 = typeCode;
			num *= 638808325U;
		}
		while (num / 2142437884U != 0U);
		uint num2 = (uint)typeCode2;
		num -= 1829399451U;
		if (num2 != (num ^ 2465567852U))
		{
			num = 1490373697U % num;
			uint num3 = (uint)typeCode2;
			num = (277377996U & num);
			if (num3 == (num ^ 276840523U))
			{
				num = (1575364379U | num);
				long 7B2365FA = ~344039A2.DA78F42D();
				num <<= 0;
				return new 6B147225.58E136FA(7B2365FA);
			}
			if (1665473033U != num)
			{
				while (884605073U < num)
				{
				}
				throw new InvalidOperationException();
			}
		}
		num = 304510182U << (int)num;
		num = 1899955676U % num;
		int num4 = 344039A2.EDAECC1C();
		num %= 1805807028U;
		int 5EEF = ~num4;
		num &= 428278349U;
		return new 6B147225.1F462BA1(5EEF);
	}

	// Token: 0x06000387 RID: 903 RVA: 0x00E6EA80 File Offset: 0x00E6AE80
	private 6B147225.68EF01A4 68E333DB(6B147225.68EF01A4 3D372878)
	{
		uint num;
		TypeCode typeCode;
		do
		{
			num = 140322825U;
			typeCode = 3D372878.39440F35();
		}
		while (num > 2018605500U);
		for (;;)
		{
			switch (typeCode - (TypeCode)(num - 140322816U))
			{
			case 0:
				goto IL_4B;
			case 1:
			case 3:
				goto IL_CF;
			case 2:
				goto IL_68;
			case 4:
				goto IL_83;
			case 5:
				if (num - 1602842003U != 0U)
				{
					goto Block_1;
				}
				continue;
			}
			break;
		}
		num += 0U;
		goto IL_CF;
		IL_4B:
		num /= 768218958U;
		int 5EEF = -3D372878.EDAECC1C();
		num *= 1338714975U;
		return new 6B147225.1F462BA1(5EEF);
		IL_68:
		long num2 = 3D372878.DA78F42D();
		num = 397105280U << (int)num;
		return new 6B147225.58E136FA(-num2);
		IL_83:
		num = 1441733313U / num;
		num = 1644569142U + num;
		float num3 = 3D372878.B55103C5();
		num = 1858016170U << (int)num;
		float 2DBD116A = -num3;
		num <<= 29;
		return new 6B147225.1F5C5947(2DBD116A);
		Block_1:
		return new 6B147225.60416C9D(-3D372878.8CC4ACA1());
		IL_CF:
		throw new InvalidOperationException();
	}

	// Token: 0x06000388 RID: 904 RVA: 0x00E6EB64 File Offset: 0x00E6AF64
	private 6B147225.68EF01A4 5C511F83(6B147225.68EF01A4 3126727E, 6B147225.68EF01A4 2C3E15DA, bool 23DF2AF4)
	{
		uint num = 943797430U;
		for (;;)
		{
			IL_07:
			TypeCode typeCode = 3126727E.39440F35();
			if (num == 876686754U)
			{
				goto IL_67;
			}
			for (;;)
			{
				IL_1A:
				TypeCode typeCode2 = typeCode;
				num = 1150747724U >> (int)num;
				uint num2 = num + 4294967031U;
				num = (1475433724U & num);
				if (typeCode2 != num2)
				{
					if (270291546U * num == 0U)
					{
						goto IL_7C;
					}
					uint num3 = (uint)typeCode;
					num = (472802386U | num);
					if (num3 != num - 472802375U)
					{
						break;
					}
					if (num < 23750327U)
					{
						goto IL_07;
					}
					num /= 676412100U;
					if (23DF2AF4)
					{
						goto Block_5;
					}
					if (num <= 572614410U)
					{
						goto Block_6;
					}
				}
				else
				{
					num /= 1786972842U;
					if (23DF2AF4)
					{
						goto IL_7C;
					}
					num <<= 31;
					if (2098426766U >= num)
					{
						goto Block_3;
					}
				}
			}
			IL_67:
			num *= 1252752114U;
			if (1067277344U != num)
			{
				goto Block_7;
			}
			goto IL_1A;
		}
		IL_7C:
		uint num4 = 3126727E.786A7318();
		num *= 1379353053U;
		num = (644906494U ^ num);
		int num5 = 2C3E15DA.EDAECC1C();
		num = 739801242U - num;
		int num6 = num5;
		num /= 1064532832U;
		int num7 = num6;
		num = 954952594U * num;
		int 5EEF = num4 >> (num7 & (int)(num ^ 31U));
		num = 1055945509U * num;
		return new 6B147225.1F462BA1(5EEF);
		Block_3:
		int num8 = 3126727E.EDAECC1C();
		num *= 667815946U;
		num *= 861341621U;
		int num9 = 2C3E15DA.EDAECC1C();
		num = 498930222U + num;
		int num10 = num9;
		num = (534210417U | num);
		int num11 = num10;
		num |= 306081839U;
		int num12 = (int)(num + 3758131360U);
		num |= 1808943692U;
		return new 6B147225.1F462BA1(num8 >> (num11 & num12));
		Block_5:
		num = (498604560U & num);
		ulong num13 = 3126727E.5C835FEF();
		num = (724453399U ^ num);
		int num14 = 2C3E15DA.EDAECC1C();
		num = 778635147U << (int)num;
		int num15 = num14;
		num = 866456240U >> (int)num;
		int num16 = num15;
		num ^= 1797291337U;
		int num17 = (int)(num - 1485139898U);
		num = 1253005917U % num;
		int num18 = num16 & num17;
		num = 2117626551U << (int)num;
		long 7B2365FA = num13 >> num18;
		num *= 674650980U;
		return new 6B147225.58E136FA(7B2365FA);
		Block_6:
		num = (528495301U | num);
		long num19 = 3126727E.DA78F42D();
		num %= 1907766431U;
		int num20 = 2C3E15DA.EDAECC1C();
		num /= 939352092U;
		int num21 = num20 & (int)(num - 4294967233U);
		num -= 2144279779U;
		return new 6B147225.58E136FA(num19 >> num21);
		Block_7:
		throw new InvalidOperationException();
	}

	// Token: 0x06000389 RID: 905 RVA: 0x00E6EDC4 File Offset: 0x00E6B1C4
	private 6B147225.68EF01A4 561F4FE5(6B147225.68EF01A4 0D341F2B, 6B147225.68EF01A4 21940A1D)
	{
		uint num = 1903110581U;
		if ((1879723511U & num) != 0U)
		{
			goto IL_12;
		}
		TypeCode typeCode2;
		for (;;)
		{
			IL_21:
			TypeCode typeCode = typeCode2;
			num = 1535585142U * num;
			uint num2 = num + 4236648369U;
			num /= 1396524681U;
			if (typeCode != num2)
			{
				if (typeCode2 == (TypeCode)(num ^ 11U))
				{
					goto IL_B1;
				}
				if (1135360939 << (int)num != 0)
				{
					break;
				}
			}
			else
			{
				num = (849349562U & num);
				if (num >> 8 == 0U)
				{
					goto Block_4;
				}
			}
		}
		num = (2054781201U ^ num);
		if (num > 333934791U)
		{
			throw new InvalidOperationException();
		}
		goto IL_12;
		Block_4:
		num <<= 12;
		int num3 = 0D341F2B.EDAECC1C();
		num = 1828549080U << (int)num;
		int num4 = 21940A1D.EDAECC1C();
		num = (1373840067U & num);
		return new 6B147225.1F462BA1(num3 << (num4 & (int)(num ^ 1088495839U)));
		IL_B1:
		num += 1312651492U;
		if (875303208U - num != 0U)
		{
			num /= 1865756354U;
			long num5 = 0D341F2B.DA78F42D();
			num = 1120349503U << (int)num;
			num = 1917476975U % num;
			int num6 = 21940A1D.EDAECC1C();
			num = (779709600U | num);
			int num7 = num6;
			int num8 = num7;
			int num9 = (int)(num + 3489955983U);
			num = 404235840U >> (int)num;
			long 7B2365FA = num5 << (num8 & num9);
			num >>= 13;
			return new 6B147225.58E136FA(7B2365FA);
		}
		IL_12:
		num *= 1406010164U;
		typeCode2 = 0D341F2B.39440F35();
		goto IL_21;
	}

	// Token: 0x0600038A RID: 906 RVA: 0x00E6EF08 File Offset: 0x00E6B308
	private unsafe 6B147225.68EF01A4 6F327B1B(object 77241A59, Type 174C3C71)
	{
		uint num;
		6B147225.68EF01A4 68EF01A2;
		for (;;)
		{
			IL_00:
			object obj = 77241A59;
			num = 1994013073U;
			6B147225.68EF01A4 68EF01A = obj as 6B147225.68EF01A4;
			num = 1397313755U << (int)num;
			68EF01A2 = 68EF01A;
			num = 385097882U % num;
			if (num == 1710106485U)
			{
				goto IL_4D;
			}
			for (;;)
			{
				num >>= 27;
				if (174C3C71.IsEnum)
				{
					goto Block_0;
				}
				num %= 2084506910U;
				num = 1158098169U << (int)num;
				TypeCode typeCode = Type.GetTypeCode(174C3C71);
				num /= 1444023422U;
				TypeCode typeCode2 = typeCode;
				TypeCode typeCode3 = typeCode2;
				uint num2 = num - 4294967293U;
				num = (1218600879U ^ num);
				switch (typeCode3 - num2)
				{
				case 0:
					goto IL_1D7;
				case 1:
					goto IL_204;
				case 2:
					goto IL_261;
				case 3:
					if (num + 1073693193U == 0U)
					{
						goto IL_4D;
					}
					if (68EF01A2 != null)
					{
						goto IL_2CA;
					}
					if (num >= 884484471U)
					{
						goto Block_14;
					}
					continue;
				case 4:
				{
					num = 1341157754U - num;
					bool flag = 68EF01A2 != null;
					num = (251474220U | num);
					if (!flag)
					{
						num = (1812816762U & num);
						if ((num & 1360620613U) != 0U)
						{
							goto Block_16;
						}
						continue;
					}
					else
					{
						num &= 2020106568U;
						if ((1224634949U & num) != 0U)
						{
							goto Block_17;
						}
						continue;
					}
					break;
				}
				case 5:
					num /= 1460159576U;
					if (68EF01A2 == null)
					{
						goto Block_18;
					}
					if (num - 1637442728U != 0U)
					{
						goto Block_19;
					}
					continue;
				case 6:
					goto IL_3C0;
				case 7:
					goto IL_41B;
				case 8:
					num = 1477379710U % num;
					if (num <= 713313814U)
					{
						goto Block_25;
					}
					continue;
				case 9:
					goto IL_4F0;
				case 10:
				{
					num >>= 30;
					if (458584659U < num)
					{
						continue;
					}
					bool flag2 = 68EF01A2 != null;
					num = 1418477904U >> (int)num;
					if (flag2)
					{
						goto IL_587;
					}
					if (num >> 28 != 0U)
					{
						goto Block_33;
					}
					continue;
				}
				case 11:
					goto IL_5A9;
				case 12:
				case 13:
				case 14:
					break;
				case 15:
					goto IL_5F9;
				default:
					num += 0U;
					break;
				}
				num = 1541497669U + num;
				if ((num & 189276867U) == 0U)
				{
					goto IL_00;
				}
				Type typeFromHandle = typeof(IntPtr);
				num = 273315817U >> (int)num;
				if (174C3C71 == typeFromHandle)
				{
					goto Block_41;
				}
				num ^= 115696250U;
				Type typeFromHandle2 = typeof(UIntPtr);
				num += 960000279U;
				if (174C3C71 == typeFromHandle2)
				{
					if (num + 1590316234U != 0U)
					{
						goto Block_48;
					}
				}
				else
				{
					num |= 1999249431U;
					if (822941951U > num)
					{
						goto IL_C3;
					}
					num = (1827604715U & num);
					if (!174C3C71.IsValueType)
					{
						goto IL_85D;
					}
					num = 458645341U >> (int)num;
					if (num < 1042377330U)
					{
						bool flag3 = 68EF01A2 != null;
						num ^= 409932312U;
						if (flag3)
						{
							goto Block_56;
						}
						num /= 1146308674U;
						if (num != 426273468U)
						{
							goto Block_57;
						}
					}
				}
			}
			IL_261:
			bool flag4 = 68EF01A2 != null;
			num -= 1888236551U;
			if (flag4)
			{
				goto IL_28E;
			}
			if ((1776490525U & num) != 0U)
			{
				goto Block_11;
			}
			goto IL_9C;
			IL_204:
			if (1789609559U >> (int)num != 0U)
			{
				goto Block_8;
			}
			continue;
			IL_3C0:
			if (num >= 2107126980U)
			{
				continue;
			}
			if (68EF01A2 != null)
			{
				goto IL_3F7;
			}
			num &= 1682252049U;
			if (num != 2047218894U)
			{
				goto Block_22;
			}
			continue;
			Block_25:
			bool flag5 = 68EF01A2 != null;
			num *= 1275729376U;
			if (!flag5)
			{
				num = 1972644271U * num;
				if (num * 1520577350U != 0U)
				{
					goto Block_27;
				}
				continue;
			}
			else
			{
				num = 83781249U - num;
				if (1621693036U != num)
				{
					goto Block_28;
				}
				goto IL_9C;
			}
			IL_4F0:
			num = 1752920788U + num;
			bool flag6 = 68EF01A2 != null;
			num = 1524593920U + num;
			if (flag6)
			{
				goto IL_525;
			}
			num *= 184099089U;
			if (num - 1543902153U != 0U)
			{
				goto Block_30;
			}
			continue;
			IL_5F9:
			num = (497226397U & num);
			if (num / 1541700682U == 0U)
			{
				goto Block_38;
			}
			continue;
			Block_41:
			if (num > 1895266017U)
			{
				continue;
			}
			if (68EF01A2 != null)
			{
				if (153777902U != num)
				{
					goto Block_44;
				}
				continue;
			}
			else
			{
				num |= 1345525381U;
				if (77241A59 != null)
				{
					goto IL_6CF;
				}
				if (num != 1389036166U)
				{
					goto Block_46;
				}
				continue;
			}
			Block_48:
			if (68EF01A2 != null)
			{
				goto Block_49;
			}
			bool flag7 = 77241A59 != null;
			num += 606428284U;
			if (!flag7)
			{
				num = 359687772U * num;
				if (46751367U >> (int)num == 0U)
				{
					goto Block_51;
				}
				continue;
			}
			else
			{
				if (num > 479070895U)
				{
					goto Block_52;
				}
				goto IL_7B;
			}
			Block_57:
			if (77241A59 != null)
			{
				if (num < 57441505U)
				{
					goto Block_59;
				}
				goto IL_4D;
			}
			else
			{
				num = (278595364U ^ num);
				if (num * 439380934U != 0U)
				{
					goto Block_60;
				}
				continue;
			}
			IL_85D:
			num += 1054423572U;
			if (174C3C71.IsArray)
			{
				num = (1452833755U | num);
				bool flag8 = 68EF01A2 != null;
				num = 977474266U + num;
				if (flag8)
				{
					goto IL_89D;
				}
				if (num * 2109214961U != 0U)
				{
					goto Block_63;
				}
				continue;
			}
			else
			{
				if (189733283U * num == 0U)
				{
					continue;
				}
				num -= 2102426981U;
				bool isPointer = 174C3C71.IsPointer;
				num = (2079669015U & num);
				if (isPointer)
				{
					bool flag9 = 68EF01A2 != null;
					num = 1009979412U >> (int)num;
					if (flag9)
					{
						if (1350794655U % num != 0U)
						{
							goto Block_67;
						}
						continue;
					}
					else
					{
						if (1879724793U < num)
						{
							continue;
						}
						bool flag10 = 77241A59 != null;
						num |= 456464295U;
						if (!flag10)
						{
							goto Block_69;
						}
						num = (1346262537U ^ num);
						if (1780417778U / num != 0U)
						{
							goto Block_70;
						}
						goto IL_63;
					}
				}
				else
				{
					num -= 160711987U;
					bool flag11 = 68EF01A2 != null;
					num = (1240208316U | num);
					if (!flag11)
					{
						num = 798499727U / num;
						if (num != 1996631534U)
						{
							goto Block_72;
						}
						continue;
					}
					else
					{
						num = 1932867633U / num;
						if (num % 946213955U != 0U)
						{
							goto Block_73;
						}
						continue;
					}
				}
			}
			IL_41B:
			num *= 967522565U;
			if (1682209177U < num)
			{
				goto Block_23;
			}
			goto IL_63;
			Block_0:
			if (num * 1006522096U != 0U)
			{
				goto IL_4D;
			}
			goto IL_63;
			IL_5A9:
			if (num >= 1993500084U)
			{
				goto IL_4D;
			}
			if (68EF01A2 == null)
			{
				if ((num ^ 613030701U) != 0U)
				{
					goto Block_36;
				}
				goto IL_4D;
			}
			else
			{
				num -= 1764299172U;
				if (num * 769799295U != 0U)
				{
					goto Block_37;
				}
				continue;
			}
			IL_7B:
			num *= 1257715124U;
			if (77241A59 == null)
			{
				goto IL_F2;
			}
			num -= 1086328291U;
			if (748436730U <= num)
			{
				goto IL_9C;
			}
			continue;
			IL_4D:
			bool flag12 = 68EF01A2 != null;
			num = (91098209U & num);
			if (flag12)
			{
				num += 1830649771U;
				goto IL_63;
			}
			goto IL_7B;
			IL_F2:
			num &= 463933447U;
			bool flag13 = 77241A59 != null;
			num = (1821445510U & num);
			if (flag13)
			{
				break;
			}
			num /= 1418658976U;
			if (2003186675U != num)
			{
				goto Block_5;
			}
			continue;
			IL_9C:
			bool flag14 = 77241A59 is Enum;
			num += 1086328291U;
			if (flag14)
			{
				goto IL_F2;
			}
			num = 692216327U * num;
			if ((1476597792U & num) == 0U)
			{
				goto IL_C3;
			}
			IL_63:
			6B147225.68EF01A4 68EF01A3 = 68EF01A2;
			num = 960177536U - num;
			77241A59 = 68EF01A3.5049A7CC();
			num ^= 3424495061U;
			goto IL_7B;
			IL_C3:
			num = 1131422807U * num;
			object value = 77241A59;
			num = 864115184U << (int)num;
			object obj2 = Enum.ToObject(174C3C71, value);
			num >>= 1;
			77241A59 = obj2;
			num += 3862909704U;
			goto IL_F2;
		}
		Enum 6DB6533B = (Enum)77241A59;
		goto IL_141;
		Block_5:
		object obj3 = Activator.CreateInstance(174C3C71);
		num &= 1273171369U;
		6DB6533B = (Enum)obj3;
		num += 0U;
		IL_141:
		num *= 774976975U;
		return new 6B147225.58510C83(6DB6533B);
		IL_1D7:
		bool 0B;
		if (68EF01A2 == null)
		{
			0B = Convert.ToBoolean(77241A59);
		}
		else
		{
			0B = 68EF01A2.93CE0566();
			num ^= 0U;
		}
		num = 1584933225U * num;
		return new 6B147225.591C7B9A(0B);
		Block_8:
		bool flag15 = 68EF01A2 != null;
		num >>= 0;
		char 46AF6C;
		if (!flag15)
		{
			num -= 1304499948U;
			46AF6C = Convert.ToChar(77241A59);
		}
		else
		{
			num = (132596148U | num);
			6B147225.68EF01A4 68EF01A4 = 68EF01A2;
			num = 2075480457U >> (int)num;
			46AF6C = 68EF01A4.F3CAAB92();
			num += 4209068227U;
		}
		return new 6B147225.7E683F22(46AF6C);
		Block_11:
		object value2 = 77241A59;
		num = (2134772695U & num);
		sbyte 43EE79C = Convert.ToSByte(value2);
		goto IL_29C;
		IL_28E:
		43EE79C = 68EF01A2.060AA47D();
		num += 2147475416U;
		IL_29C:
		return new 6B147225.009559D5(43EE79C);
		Block_14:
		byte 2C6370E = Convert.ToByte(77241A59);
		goto IL_2E8;
		IL_2CA:
		num &= 1785997603U;
		6B147225.68EF01A4 68EF01A5 = 68EF01A2;
		num >>= 25;
		2C6370E = 68EF01A5.4D994718();
		num += 1218600843U;
		IL_2E8:
		return new 6B147225.62930004(2C6370E);
		Block_16:
		object value3 = 77241A59;
		num = (1673604508U | num);
		short 24507AC = Convert.ToInt16(value3);
		goto IL_35B;
		Block_17:
		6B147225.68EF01A4 68EF01A6 = 68EF01A2;
		num = 1316120796U >> (int)num;
		24507AC = 68EF01A6.E915D835();
		num ^= 1870880662U;
		IL_35B:
		return new 6B147225.6F5B5DDB(24507AC);
		Block_18:
		num = 1531598880U >> (int)num;
		object value4 = 77241A59;
		num = (544357346U & num);
		ushort 07BA1ABE = Convert.ToUInt16(value4);
		goto IL_3B2;
		Block_19:
		6B147225.68EF01A4 68EF01A7 = 68EF01A2;
		num = (1514027139U | num);
		07BA1ABE = 68EF01A7.D20A0A8F();
		num += 2785271709U;
		IL_3B2:
		num /= 99355646U;
		return new 6B147225.130817DC(07BA1ABE);
		Block_22:
		object value5 = 77241A59;
		num = 37191422U / num;
		int 5EEF = Convert.ToInt32(value5);
		goto IL_40D;
		IL_3F7:
		6B147225.68EF01A4 68EF01A8 = 68EF01A2;
		num = 78448718U / num;
		5EEF = 68EF01A8.EDAECC1C();
		num ^= 0U;
		IL_40D:
		num = 2081565124U - num;
		return new 6B147225.1F462BA1(5EEF);
		Block_23:
		bool flag16 = 68EF01A2 != null;
		num = 311579476U >> (int)num;
		uint <<EMPTY_NAME>>;
		if (!flag16)
		{
			object value6 = 77241A59;
			num %= 683242471U;
			<<EMPTY_NAME>> = Convert.ToUInt32(value6);
		}
		else
		{
			num <<= 30;
			<<EMPTY_NAME>> = 68EF01A2.786A7318();
			num ^= 2147635786U;
		}
		num = (1279740111U ^ num);
		return new 6B147225.373B0CAE(<<EMPTY_NAME>>);
		Block_27:
		long 7B2365FA = Convert.ToInt64(77241A59);
		goto IL_4E2;
		Block_28:
		6B147225.68EF01A4 68EF01A9 = 68EF01A2;
		num = 1372397083U / num;
		7B2365FA = 68EF01A9.DA78F42D();
		num ^= 300107232U;
		IL_4E2:
		num &= 1322269092U;
		return new 6B147225.58E136FA(7B2365FA);
		Block_30:
		ulong 305673D = Convert.ToUInt64(77241A59);
		goto IL_53B;
		IL_525:
		6B147225.68EF01A4 68EF01A10 = 68EF01A2;
		num = 64893925U * num;
		305673D = 68EF01A10.5C835FEF();
		num ^= 2770252700U;
		IL_53B:
		num = 780417091U / num;
		return new 6B147225.61A633AA(305673D);
		Block_33:
		float 2DBD116A = Convert.ToSingle(77241A59);
		goto IL_595;
		IL_587:
		2DBD116A = 68EF01A2.B55103C5();
		num += 0U;
		IL_595:
		num = 263737025U >> (int)num;
		return new 6B147225.1F5C5947(2DBD116A);
		Block_36:
		double 406C = Convert.ToDouble(77241A59);
		goto IL_5F3;
		Block_37:
		406C = 68EF01A2.8CC4ACA1();
		num += 1764299172U;
		IL_5F3:
		return new 6B147225.60416C9D(406C);
		Block_38:
		string 356D354A;
		if (68EF01A2 == null)
		{
			num ^= 411978354U;
			356D354A = (string)77241A59;
		}
		else
		{
			num ^= 1604272471U;
			object obj4 = 68EF01A2;
			num = 2030988306U / num;
			356D354A = obj4.ToString();
			num += 271341822U;
		}
		return new 6B147225.2B9A788E(356D354A);
		Block_44:
		IntPtr 20D63C = 68EF01A2.B74C1556();
		num = 510871223U % num;
		return new 6B147225.039A0C85(20D63C);
		Block_46:
		IntPtr 20D63C2 = IntPtr.Zero;
		goto IL_6DD;
		IL_6CF:
		20D63C2 = (IntPtr)77241A59;
		num ^= 0U;
		IL_6DD:
		return new 6B147225.039A0C85(20D63C2);
		Block_49:
		num = 624953535U * num;
		6B147225.68EF01A4 68EF01A11 = 68EF01A2;
		num = 1583239514U - num;
		UIntPtr 67895BD = 68EF01A11.2B2A13B3();
		num = (917467172U | num);
		return new 6B147225.15AB16A8(67895BD);
		Block_51:
		UIntPtr 67895BD2 = UIntPtr.Zero;
		goto IL_784;
		Block_52:
		67895BD2 = (UIntPtr)77241A59;
		num ^= 3462486285U;
		IL_784:
		num = 2114592210U + num;
		return new 6B147225.15AB16A8(67895BD2);
		Block_56:
		num += 1557018851U;
		6B147225.68EF01A4 68EF01A12 = 68EF01A2;
		num |= 1948724581U;
		object 21CD4FB = 68EF01A12.5049A7CC();
		num = (2074231462U ^ num);
		return new 6B147225.71755E30(21CD4FB);
		Block_59:
		object 21CD4FB2 = 77241A59;
		goto IL_857;
		Block_60:
		num = 402344019U % num;
		21CD4FB2 = Activator.CreateInstance(174C3C71);
		num ^= 123748655U;
		IL_857:
		return new 6B147225.71755E30(21CD4FB2);
		Block_63:
		Array 7DF064C = (Array)77241A59;
		goto IL_8B8;
		IL_89D:
		6B147225.68EF01A4 68EF01A13 = 68EF01A2;
		num = 1426028117U - num;
		7DF064C = (Array)68EF01A13.5049A7CC();
		num ^= 318269733U;
		IL_8B8:
		num <<= 1;
		return new 6B147225.69732A42(7DF064C);
		Block_67:
		void* ptr = 68EF01A2.477D7F8C();
		num = (1789688391U | num);
		object 286A427D = Pointer.Box(ptr, 174C3C71);
		num = 1935823082U / num;
		return new 6B147225.2EF54896(286A427D, 174C3C71);
		Block_69:
		num = 1838223622U << (int)num;
		void* ptr2 = num - 2290286592U;
		goto IL_986;
		Block_70:
		ptr2 = Pointer.Unbox(77241A59);
		num += 1031255642U;
		IL_986:
		num = (4063824U ^ num);
		object 286A427D2 = Pointer.Box(ptr2, 174C3C71);
		num = 1433478014U + num;
		num = 1265769495U % num;
		return new 6B147225.2EF54896(286A427D2, 174C3C71);
		Block_72:
		object 02FC5CA = 77241A59;
		goto IL_A04;
		Block_73:
		6B147225.68EF01A4 68EF01A14 = 68EF01A2;
		num = 266808568U * num;
		02FC5CA = 68EF01A14.5049A7CC();
		num ^= 266808568U;
		IL_A04:
		return new 6B147225.3FCC0B6B(02FC5CA);
	}

	// Token: 0x0600038B RID: 907 RVA: 0x00E6F920 File Offset: 0x00E6BD20
	private string 2AE22E39(int 49F577C5)
	{
		uint num;
		Dictionary<int, object> dictionary2;
		do
		{
			Dictionary<int, object> dictionary = 6B147225.13BF1BD3;
			num = 2012761227U;
			dictionary2 = dictionary;
			num /= 1917874032U;
		}
		while (num >= 1716469530U);
		Monitor.Enter(dictionary2);
		string result;
		try
		{
			num = 1909260946U + num;
			if (415771596U != num)
			{
				object obj;
				for (;;)
				{
					Dictionary<int, object> dictionary3 = 6B147225.13BF1BD3;
					num >>= 1;
					num |= 2004570500U;
					num %= 2038633783U;
					if (dictionary3.TryGetValue(49F577C5, out obj))
					{
						break;
					}
					num = 192042997U / num;
					if (num >> 4 == 0U)
					{
						goto Block_3;
					}
				}
				for (;;)
				{
					object obj2 = obj;
					num /= 1899836886U;
					result = (string)obj2;
					if (1929919411U >> (int)num != 0U)
					{
						goto IL_84;
					}
				}
				Block_3:
				num %= 746062731U;
				Module module = this.64D20DDA;
				num = (1735856898U | num);
				string text = module.ResolveString(49F577C5);
				if (1246255653U - num != 0U)
				{
					Dictionary<int, object> dictionary4 = 6B147225.13BF1BD3;
					num /= 1198467839U;
					object value = text;
					num = 1696608675U << (int)num;
					dictionary4.Add(49F577C5, value);
					num = 628578349U - num;
				}
				result = text;
			}
			IL_84:;
		}
		finally
		{
			do
			{
				object obj3 = dictionary2;
				num = 815483559U;
				Monitor.Exit(obj3);
			}
			while (1611888465U >> (int)num == 0U);
		}
		return result;
	}

	// Token: 0x0600038C RID: 908 RVA: 0x00E6FA64 File Offset: 0x00E6BE64
	private Type 04A156D1(int 43B2167F)
	{
		uint num = 605497372U;
		Dictionary<int, object> dictionary = 6B147225.13BF1BD3;
		num = 1566333239U >> (int)num;
		Dictionary<int, object> dictionary2 = dictionary;
		object obj = dictionary2;
		num = 1076580025U - num;
		Monitor.Enter(obj);
		Type result2;
		try
		{
			num = (1664769007U | num);
			Dictionary<int, object> dictionary3 = 6B147225.13BF1BD3;
			num *= 235626086U;
			object obj2;
			if (!dictionary3.TryGetValue(43B2167F, out obj2))
			{
				num *= 1090856186U;
				Module module = this.64D20DDA;
				num |= 1553810020U;
				num = 632884357U * num;
				Type type = module.ResolveType(43B2167F);
				num ^= 1617175999U;
				Type type2 = type;
				Dictionary<int, object> dictionary4 = 6B147225.13BF1BD3;
				num += 309220501U;
				dictionary4.Add(43B2167F, type2);
				if (622475679U < num)
				{
					Type result = type2;
					num = (1898984885U | num);
					return result;
				}
			}
			object obj3 = obj2;
			num ^= 578099809U;
			Type type3 = (Type)obj3;
			num *= 1879592275U;
			result2 = type3;
		}
		finally
		{
			num = 1475944906U;
			if (num != 687290016U)
			{
				Monitor.Exit(dictionary2);
			}
		}
		return result2;
	}

	// Token: 0x0600038D RID: 909 RVA: 0x00E6FB6C File Offset: 0x00E6BF6C
	private MethodBase 3BFD2570(int 16461A99)
	{
		Dictionary<int, object> obj = 6B147225.13BF1BD3;
		Monitor.Enter(obj);
		MethodBase result;
		try
		{
			uint num;
			do
			{
				Dictionary<int, object> dictionary = 6B147225.13BF1BD3;
				num = 1427526798U;
				num |= 437807266U;
				num /= 1389256442U;
				object obj2;
				if (dictionary.TryGetValue(16461A99, out obj2))
				{
					if (num * 1062685533U == 0U)
					{
						continue;
					}
				}
				else
				{
					num = (473830006U ^ num);
					Module module = this.64D20DDA;
					num = 695551569U % num;
					num /= 669263344U;
					MethodBase methodBase = module.ResolveMethod(16461A99);
					num = (297761266U | num);
					if (num % 1046035213U != 0U)
					{
						Dictionary<int, object> dictionary2 = 6B147225.13BF1BD3;
						object value = methodBase;
						num ^= 1138324869U;
						dictionary2.Add(16461A99, value);
						MethodBase methodBase2 = methodBase;
						num += 248848375U;
						result = methodBase2;
						if (num << 30 != 0U)
						{
							break;
						}
						continue;
					}
				}
				result = (MethodBase)obj2;
			}
			while (num >= 1631930480U);
		}
		finally
		{
			uint num;
			do
			{
				num = 1065365232U;
				Monitor.Exit(obj);
			}
			while (num >> 16 == 0U);
		}
		return result;
	}

	// Token: 0x0600038E RID: 910 RVA: 0x00E6FC78 File Offset: 0x00E6C078
	private FieldInfo 599E792E(int 7E194FE2)
	{
		Dictionary<int, object> obj;
		uint num;
		do
		{
			obj = 6B147225.13BF1BD3;
			num = 550245262U;
		}
		while (num > 1178741770U);
		Monitor.Enter(obj);
		FieldInfo result;
		try
		{
			num = 1294738321U * num;
			object obj2;
			for (;;)
			{
				Dictionary<int, object> dictionary = 6B147225.13BF1BD3;
				num = (2091319605U & num);
				if (dictionary.TryGetValue(7E194FE2, out obj2))
				{
					if (620187546U > num)
					{
						break;
					}
				}
				else
				{
					num &= 1901337484U;
					Module module = this.64D20DDA;
					num += 1693129104U;
					FieldInfo fieldInfo = module.ResolveField(7E194FE2);
					num = 232332177U % num;
					FieldInfo fieldInfo2 = fieldInfo;
					num = (1708161001U | num);
					if (1584204545U <= num)
					{
						Dictionary<int, object> dictionary2 = 6B147225.13BF1BD3;
						num = (228404286U | num);
						dictionary2.Add(7E194FE2, fieldInfo2);
						if (590503800U >> (int)num == 0U)
						{
							result = fieldInfo2;
							if (num - 1305625102U != 0U)
							{
								goto Block_7;
							}
						}
					}
				}
			}
			FieldInfo fieldInfo3 = (FieldInfo)obj2;
			num = 284102249U >> (int)num;
			result = fieldInfo3;
			Block_7:;
		}
		finally
		{
			num = 799541262U;
			if (num / 825630105U == 0U)
			{
				Monitor.Exit(obj);
			}
		}
		return result;
	}

	// Token: 0x0600038F RID: 911 RVA: 0x00E6FDA8 File Offset: 0x00E6C1A8
	private 6B147225.68EF01A4 7D244481(MethodBase 3C9D0B5C)
	{
		uint num = 1108896629U;
		Dictionary<int, 6B147225.68EF01A4> dictionary;
		object[] array2;
		for (;;)
		{
			ParameterInfo[] parameters = 3C9D0B5C.GetParameters();
			num = 1862346388U * num;
			ParameterInfo[] array = parameters;
			num = (1695776303U & num);
			dictionary = new Dictionary<int, 6B147225.68EF01A4>();
			if (1786970197U - num != 0U)
			{
				for (;;)
				{
					IL_30:
					int num2 = array.Length;
					num = 1725646587U * num;
					array2 = new object[num2];
					int num3 = array.Length;
					num <<= 18;
					int num4 = (int)(num + 3268411393U);
					num = 1984696002U % num;
					int num5 = num3 - num4;
					while (num != 707986440U)
					{
						int num6 = num5;
						num += 66809497U;
						uint num7 = num - 1024949595U;
						num |= 2107126349U;
						if (num6 < num7)
						{
							if ((num ^ 558987248U) != 0U)
							{
								goto Block_4;
							}
							goto IL_30;
						}
						else
						{
							6B147225.68EF01A4 68EF01A = this.114C39DF();
							num = 1925525785U;
							6B147225.68EF01A4 68EF01A2 = 68EF01A;
							if (68EF01A2.684ED4C6())
							{
								num += 297933947U;
								Dictionary<int, 6B147225.68EF01A4> dictionary2 = dictionary;
								num = 918497265U >> (int)num;
								dictionary2[num5] = 68EF01A2;
								num ^= 1925526130U;
							}
							num &= 892623157U;
							object[] array3 = array2;
							num -= 572067996U;
							int num8 = num5;
							num *= 1439594535U;
							object 77241A = 68EF01A2;
							ParameterInfo parameterInfo = array[num5];
							num = 1297839709U + num;
							Type parameterType = parameterInfo.ParameterType;
							num = 611208899U - num;
							object obj = this.6F327B1B(77241A, parameterType).5049A7CC();
							num |= 196157145U;
							array3[num8] = obj;
							int num9 = num5;
							num = 1442974231U % num;
							num5 = num9 - (int)(num - 1442974230U);
							num += 3810133163U;
						}
					}
					break;
				}
			}
		}
		Block_4:
		object obj2 = ((ConstructorInfo)3C9D0B5C).Invoke(array2);
		num += 82190513U;
		Dictionary<int, 6B147225.68EF01A4> dictionary3 = dictionary;
		num += 495735097U;
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator = dictionary3.GetEnumerator();
		num /= 1078988204U;
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator2 = enumerator;
		try
		{
			if (345846721U == num)
			{
				goto IL_182;
			}
			IL_17D:
			goto IL_1EB;
			IL_182:
			num = 1478252691U;
			if (492402077U >= num)
			{
				goto IL_20A;
			}
			num ^= 821104518U;
			KeyValuePair<int, 6B147225.68EF01A4> keyValuePair = enumerator2.Current;
			num = 1249577271U >> (int)num;
			KeyValuePair<int, 6B147225.68EF01A4> keyValuePair2 = keyValuePair;
			if (158141230U - num != 0U)
			{
				6B147225.68EF01A4 value = keyValuePair2.Value;
				num = (740130749U ^ num);
				object[] array4 = array2;
				num = 120744494U * num;
				value.62B618BD(array4[keyValuePair2.Key]);
				num += 3256013630U;
			}
			IL_1EB:
			if (1035352926U <= num)
			{
				goto IL_17D;
			}
			num *= 551760795U;
			if (enumerator2.MoveNext())
			{
				goto IL_182;
			}
			IL_20A:;
		}
		finally
		{
			num = 735674088U;
			if (num < 1604678694U)
			{
				((IDisposable)enumerator2).Dispose();
			}
		}
		num = 624107124U;
		num ^= 835394951U;
		object 77241A2 = obj2;
		num = 318849350U << (int)num;
		return this.6F327B1B(77241A2, 3C9D0B5C.DeclaringType);
	}

	// Token: 0x06000390 RID: 912 RVA: 0x00E7002C File Offset: 0x00E6C42C
	private bool 43191DF9(MethodBase 6EBD6A70, object 07C138C3, ref object 1C4C19B4, object[] 46643ACA)
	{
		uint num = 1756385954U;
		for (;;)
		{
			IL_06:
			Type declaringType = 6EBD6A70.DeclaringType;
			bool flag = declaringType != null;
			num <<= 31;
			if (!flag)
			{
				break;
			}
			do
			{
				num = 289365840U >> (int)num;
				if (!declaringType.IsGenericType)
				{
					goto IL_1E3;
				}
				if ((num ^ 1860202621U) == 0U)
				{
					goto IL_1B;
				}
				Type genericTypeDefinition = declaringType.GetGenericTypeDefinition();
				num ^= 946691745U;
				Type typeFromHandle = typeof(Nullable<>);
				num += 3891092831U;
				if (genericTypeDefinition != typeFromHandle)
				{
					goto IL_1E3;
				}
				if (2015372477U == num)
				{
					goto IL_06;
				}
				string name = 6EBD6A70.Name;
				string b = "get_HasValue";
				num /= 263743624U;
				StringComparison comparisonType = (int)num + StringComparison.InvariantCultureIgnoreCase;
				num /= 1149128197U;
				if (string.Equals(name, b, comparisonType))
				{
					goto Block_5;
				}
				string name2 = 6EBD6A70.Name;
				num = 1613520196U + num;
				if (!string.Equals(name2, "get_Value", (int)num + (StringComparison)(-1613520192)))
				{
					goto IL_13E;
				}
			}
			while (1908438261U < num);
			bool flag2 = 07C138C3 != null;
			num = 1607159030U / num;
			if (!flag2)
			{
				goto Block_8;
			}
			num -= 1647706714U;
			if (591792325U > num)
			{
				goto IL_BF;
			}
			num ^= 1878725273U;
			1C4C19B4 = 07C138C3;
			if (1831481184U - num != 0U)
			{
				goto Block_10;
			}
			continue;
			IL_13E:
			string name3 = 6EBD6A70.Name;
			num ^= 1136726219U;
			string value = "GetValueOrDefault";
			StringComparison comparisonType2 = (StringComparison)(num ^ 602754443U);
			num >>= 21;
			bool flag3 = name3.Equals(value, comparisonType2);
			num += 1275215873U;
			if (!flag3)
			{
				goto IL_1D3;
			}
			num = (2137992257U ^ num);
			if (num < 1520051858U)
			{
				goto Block_12;
			}
		}
		IL_1B:
		return num + 0U != 0U;
		Block_5:
		object obj = 07C138C3;
		num ^= 1275543968U;
		object obj2 = null;
		num = (2089436454U & num);
		1C4C19B4 = (obj > obj2);
		IL_BF:
		goto IL_1D3;
		Block_8:
		throw new InvalidOperationException();
		Block_10:
		num += 1506759137U;
		goto IL_1D3;
		Block_12:
		bool flag4 = 07C138C3 != null;
		num = 1012805187U * num;
		if (!flag4)
		{
			if (1546478827U <= num)
			{
				goto IL_1B;
			}
			Type underlyingType = Nullable.GetUnderlyingType(6EBD6A70.DeclaringType);
			num = 587006792U % num;
			07C138C3 = Activator.CreateInstance(underlyingType);
			num ^= 74748144U;
		}
		num %= 730006780U;
		1C4C19B4 = 07C138C3;
		num += 1192833725U;
		IL_1D3:
		num = 1966619655U - num;
		return (num ^ 691403494U) != 0U;
		IL_1E3:
		num = 1619086726U >> (int)num;
		return num + 4294942591U != 0U;
	}

	// Token: 0x06000391 RID: 913 RVA: 0x00E70234 File Offset: 0x00E6C634
	private 6B147225.68EF01A4 4B500392(MethodBase 72A53E9F, bool 28054C04)
	{
		uint num;
		MethodInfo methodInfo2;
		Dictionary<int, 6B147225.68EF01A4> dictionary2;
		object[] array2;
		6B147225.68EF01A4 68EF01A2;
		object obj3;
		object 77241A;
		object[] array8;
		for (;;)
		{
			IL_00:
			num = 2062947498U;
			MethodInfo methodInfo = 72A53E9F as MethodInfo;
			num <<= 24;
			methodInfo2 = methodInfo;
			num |= 1914008185U;
			if ((1808692928U & num) != 0U)
			{
				goto IL_30;
			}
			ParameterInfo[] parameters;
			for (;;)
			{
				IL_4D:
				Dictionary<int, 6B147225.68EF01A4> dictionary = new Dictionary<int, 6B147225.68EF01A4>();
				num = (1336086618U ^ num);
				dictionary2 = dictionary;
				for (;;)
				{
					IL_5E:
					ParameterInfo[] array = parameters;
					num -= 1907708951U;
					int num2 = array.Length;
					num = 256853039U - num;
					array2 = new object[num2];
					for (;;)
					{
						ParameterInfo[] array3 = parameters;
						num %= 94457447U;
						int num3 = array3.Length;
						num = (619802776U & num);
						int num4 = num3;
						int num5 = (int)(num ^ 10571913U);
						num += 1366432295U;
						int num6 = num4 - num5;
						num = 1672884042U * num;
						int num7 = num6;
						if (num % 352544651U == 0U)
						{
							goto IL_00;
						}
						for (;;)
						{
							while (1649750683U >> (int)num != 0U)
							{
								int num8 = num7;
								num = 1858800388U / num;
								uint num9 = num + 0U;
								num |= 1899062078U;
								if (num8 < num9)
								{
									num = 745414148U - num;
									if (num == 905124746U)
									{
										break;
									}
									num >>= 9;
									bool isStatic = 72A53E9F.IsStatic;
									num = 1501968859U / num;
									6B147225.68EF01A4 68EF01A;
									if (!isStatic)
									{
										68EF01A = this.114C39DF();
									}
									else
									{
										if ((num ^ 2026580354U) == 0U)
										{
											break;
										}
										68EF01A = null;
										num += 0U;
									}
									num /= 1047331239U;
									68EF01A2 = 68EF01A;
									num = 2013276922U + num;
									bool flag = 68EF01A2 != null;
									num %= 143401077U;
									object obj;
									if (!flag)
									{
										num &= 857684334U;
										if (1307783658U / num == 0U)
										{
											goto IL_4D;
										}
										obj = null;
									}
									else
									{
										num -= 1062234888U;
										obj = 68EF01A2.5049A7CC();
										num ^= 3239303560U;
									}
									num |= 2061763156U;
									object obj2;
									bool flag2 = (obj2 = obj) != null;
									num = 32258337U * num;
									if (!flag2)
									{
										if (2011447863U % num == 0U)
										{
											goto IL_30;
										}
										obj2 = null;
										num += 0U;
									}
									num = (1625111576U | num);
									obj3 = obj2;
									if (28054C04)
									{
										num >>= 15;
										if (num == 1093090744U)
										{
											goto IL_30;
										}
										bool flag3 = obj3 != null;
										num = (1678529715U ^ num);
										num ^= 2228398545U;
										if (!flag3)
										{
											goto Block_12;
										}
									}
									77241A = null;
									if (551119166U >> (int)num == 0U)
									{
										goto IL_5E;
									}
									if (!72A53E9F.IsConstructor)
									{
										goto IL_423;
									}
									num &= 2081913249U;
									if (num / 194787197U == 0U)
									{
										goto IL_30;
									}
									num %= 1033597627U;
									Type declaringType = 72A53E9F.DeclaringType;
									num ^= 1060770887U;
									bool isValueType = declaringType.IsValueType;
									num ^= 4255051102U;
									if (!isValueType)
									{
										goto IL_423;
									}
									num /= 2121420852U;
									if (1985232401U >> (int)num == 0U)
									{
										continue;
									}
									Type declaringType2 = 72A53E9F.DeclaringType;
									object[] args = array2;
									num = 789334032U + num;
									obj3 = Activator.CreateInstance(declaringType2, args);
									num = 858728132U + num;
									if (68EF01A2 == null)
									{
										goto IL_BE9;
									}
									num += 1866348925U;
									if (1547855871U >> (int)num != 0U)
									{
										goto Block_20;
									}
								}
								6B147225.68EF01A4 68EF01A3 = this.114C39DF();
								num = 1000692817U;
								68EF01A2 = 68EF01A3;
								num = 931990056U % num;
								bool flag4 = 68EF01A2.684ED4C6();
								num *= 1846817560U;
								if (flag4)
								{
									Dictionary<int, 6B147225.68EF01A4> dictionary3 = dictionary2;
									int key = num7;
									num = (619201530U & num);
									6B147225.68EF01A4 value = 68EF01A2;
									num /= 1778648006U;
									dictionary3[key] = value;
									num += 1230957504U;
								}
								num += 470507096U;
								object[] array4 = array2;
								int num10 = num7;
								num &= 990068048U;
								object 77241A2 = 68EF01A2;
								ParameterInfo[] array5 = parameters;
								num = (409821377U ^ num);
								int num11 = num7;
								num <<= 8;
								Type parameterType = array5[num11].ParameterType;
								num = 1783896868U - num;
								array4[num10] = this.6F327B1B(77241A2, parameterType).5049A7CC();
								int num12 = num7;
								int num13 = (int)(num - 4209723939U);
								num |= 2042258294U;
								num7 = num12 - num13;
								num += 3550579744U;
							}
							goto IL_00;
						}
						IL_423:
						num = 703154027U + num;
						if (290214591U <= num)
						{
							goto IL_00;
						}
						num *= 1982952319U;
						object 07C138C = obj3;
						num = 693902065U << (int)num;
						bool flag5 = this.43191DF9(72A53E9F, 07C138C, ref 77241A, array2);
						num += 2151378645U;
						if (flag5)
						{
							goto IL_BE9;
						}
						if (num >> 24 != 0U)
						{
							goto Block_24;
						}
					}
				}
			}
			Block_12:
			if ((num & 1532781063U) != 0U)
			{
				break;
			}
			continue;
			Block_24:
			num = 774662005U / num;
			if (28054C04)
			{
				goto IL_BBF;
			}
			num = 2021474561U << (int)num;
			bool isVirtual = 72A53E9F.IsVirtual;
			num ^= 2021474561U;
			if (!isVirtual)
			{
				goto IL_BBF;
			}
			bool isFinal = 72A53E9F.IsFinal;
			num ^= 0U;
			if (isFinal)
			{
				goto IL_BBF;
			}
			num *= 1277654742U;
			ParameterInfo[] array6 = parameters;
			num = (1546395517U & num);
			int num14 = array6.Length;
			int num15 = (int)(num ^ 1U);
			num /= 182265298U;
			object[] array7 = new object[num14 + num15];
			num |= 878057233U;
			array8 = array7;
			num = 735643067U % num;
			object[] array9 = array8;
			num = (353834920U & num);
			int num16 = (int)(num ^ 17892776U);
			object obj4 = obj3;
			num |= 482745518U;
			array9[num16] = obj4;
			int num17 = (int)(num ^ 500637102U);
			if (num != 1192319334U)
			{
				for (;;)
				{
					int num18 = num17;
					ParameterInfo[] array10 = parameters;
					num = (425159004U & num);
					int num19 = array10.Length;
					num = (1064790311U | num);
					int num20 = num19;
					num = 1223184592U << (int)num;
					if (num18 >= num20)
					{
						break;
					}
					num = 202775952U;
					object[] array11 = array8;
					num ^= 1128363443U;
					int num21 = num17;
					num &= 1581517705U;
					int num22 = num21 + (int)(num - 1313081344U);
					num = 1899331182U << (int)num;
					object[] array12 = array2;
					int num23 = num17;
					num /= 735004948U;
					array11[num22] = array12[num23];
					num <<= 17;
					int num24 = num17;
					int num25 = (int)(num ^ 655361U);
					num = 2086930976U - num;
					num17 = num24 + num25;
					num += 2709328782U;
				}
				num *= 606612832U;
				if ((num ^ 6756809U) != 0U)
				{
					goto Block_30;
				}
				continue;
			}
			IL_30:
			num -= 307577355U;
			parameters = 72A53E9F.GetParameters();
			if (num >= 113060179U)
			{
				goto IL_4D;
			}
		}
		throw new NullReferenceException();
		Block_20:
		bool flag6 = 68EF01A2.684ED4C6();
		num = 688677631U + num;
		num ^= 2562549124U;
		if (flag6)
		{
			6B147225.68EF01A4 68EF01A4 = 68EF01A2;
			object 77241A3 = obj3;
			Type declaringType3 = 72A53E9F.DeclaringType;
			num = 110394958U << (int)num;
			object 7FCE2AA = this.6F327B1B(77241A3, declaringType3).5049A7CC();
			num = 614035658U / num;
			68EF01A4.62B618BD(7FCE2AA);
			num += 1648062165U;
			goto IL_BE9;
		}
		goto IL_BE9;
		Block_30:
		Dictionary<MethodBase, DynamicMethod> dictionary4 = 6B147225.764039AB;
		num <<= 4;
		Dictionary<MethodBase, DynamicMethod> dictionary5 = dictionary4;
		num = 893279556U * num;
		Monitor.Enter(dictionary5);
		DynamicMethod dynamicMethod;
		try
		{
			num = 1884042992U % num;
			if ((918715313U & num) != 0U)
			{
				goto IL_636;
			}
			ILGenerator ilgenerator;
			for (;;)
			{
				IL_670:
				object[] array13 = array8;
				num %= 2115003272U;
				int num26 = array13.Length;
				num %= 379720221U;
				Type[] array14 = new Type[num26];
				num &= 217908410U;
				Type[] array15 = array14;
				if (num * 197069458U != 0U)
				{
					Type[] array16 = array15;
					int num27 = (int)(num ^ 5571728U);
					num = (1368667700U | num);
					Type declaringType4 = 72A53E9F.DeclaringType;
					num = (869292965U ^ num);
					array16[num27] = declaringType4;
					for (;;)
					{
						int num28 = (int)(num ^ 1644522769U);
						num = 386926201U + num;
						int num29 = num28;
						for (;;)
						{
							int num30 = num29;
							num += 68625172U;
							ParameterInfo[] parameters;
							ParameterInfo[] array17 = parameters;
							num = 1917062200U >> (int)num;
							int num31 = array17.Length;
							num = 1040860796U + num;
							if (num30 >= num31 && (num ^ 1462586831U) != 0U)
							{
								goto Block_46;
							}
							num = 84437752U;
							if (32603462U > num)
							{
								goto IL_636;
							}
							Type[] array18 = array15;
							int num32 = num29;
							num |= 1748119435U;
							array18[num32 + (int)(num ^ 1832546298U)] = parameters[num29].ParameterType;
							num -= 1123614781U;
							if ((832970833U & num) == 0U)
							{
								break;
							}
							int num33 = num29;
							num = 1151077348U - num;
							int num34 = num33 + (int)(num - 442145829U);
							num = (1617053843U & num);
							num29 = num34;
							num += 2027121544U;
						}
					}
					Block_46:
					string name = "";
					bool flag7 = methodInfo2 != null;
					num /= 452613048U;
					if (!flag7)
					{
						goto IL_7EF;
					}
					MethodInfo methodInfo3 = methodInfo2;
					num = 875986844U << (int)num;
					Type returnType = methodInfo3.ReturnType;
					num -= 1808945509U;
					Type typeFromHandle = typeof(void);
					num = 81689615U + num;
					if (returnType == typeFromHandle)
					{
						num += 2518275816U;
						goto IL_7EF;
					}
					Type returnType2 = methodInfo2.ReturnType;
					num ^= 1776691480U;
					IL_806:
					Type[] parameterTypes = array15;
					RuntimeTypeHandle handle = typeof(6B147225).TypeHandle;
					num = 2135503259U / num;
					Type typeFromHandle2 = Type.GetTypeFromHandle(handle);
					num <<= 4;
					Module module = typeFromHandle2.Module;
					num &= 309485389U;
					bool skipVisibility = num - 306187327U != 0U;
					num = 176231349U + num;
					dynamicMethod = new DynamicMethod(name, returnType2, parameterTypes, module, skipVisibility);
					ilgenerator = dynamicMethod.GetILGenerator();
					num = 928932315U >> (int)num;
					if (num * 2086034526U == 0U)
					{
						goto IL_636;
					}
					ILGenerator ilgenerator2 = ilgenerator;
					num <<= 20;
					bool flag8 = 68EF01A2.684ED4C6();
					num |= 1084953200U;
					OpCode opcode;
					if (!flag8)
					{
						opcode = OpCodes.Ldarg;
					}
					else
					{
						num = 567022363U / num;
						opcode = OpCodes.Ldarga;
						num += 1537938032U;
					}
					int arg = (int)(num + 2757029264U);
					num &= 287646704U;
					ilgenerator2.Emit(opcode, arg);
					int num35 = (int)(num ^ 287375985U);
					num <<= 30;
					int num36 = num35;
					if (109791737U >= num)
					{
						while (num << 0 == 0U)
						{
							int num37 = num36;
							num >>= 17;
							Type[] array19 = array15;
							num *= 1567040642U;
							int num38 = array19.Length;
							num = 538840513U - num;
							if (num37 >= num38)
							{
								goto Block_55;
							}
							ILGenerator ilgenerator3 = ilgenerator;
							num = 489697485U;
							Dictionary<int, 6B147225.68EF01A4> dictionary6 = dictionary2;
							num <<= 1;
							int key2 = num36 - (int)(num + 3315572327U);
							num = 1319836882U >> (int)num;
							bool flag9 = dictionary6.ContainsKey(key2);
							num %= 1844315709U;
							OpCode opcode2;
							if (!flag9)
							{
								num += 1300322926U;
								opcode2 = OpCodes.Ldarg;
							}
							else
							{
								num &= 1113333308U;
								opcode2 = OpCodes.Ldarga;
								num ^= 1300322961U;
							}
							num = (1851596299U | num);
							ilgenerator3.Emit(opcode2, num36);
							num /= 19797735U;
							if (1990478096 << (int)num != 0)
							{
								goto IL_670;
							}
							int num39 = num36;
							num = 360804450U % num;
							int num40 = (int)(num ^ 21U);
							num <<= 10;
							int num41 = num39 + num40;
							num *= 652887245U;
							num36 = num41;
							num ^= 897585152U;
						}
						goto IL_636;
					}
					goto IL_636;
					IL_7EF:
					returnType2 = null;
					goto IL_806;
				}
			}
			Block_55:
			ILGenerator ilgenerator4 = ilgenerator;
			OpCode call = OpCodes.Call;
			num = (89456759U ^ num);
			ilgenerator4.Emit(call, methodInfo2);
			ILGenerator ilgenerator5 = ilgenerator;
			num -= 1844137917U;
			OpCode ret = OpCodes.Ret;
			num /= 1584023940U;
			ilgenerator5.Emit(ret);
			num *= 1481978651U;
			Dictionary<MethodBase, DynamicMethod> dictionary7 = 6B147225.764039AB;
			num |= 322004592U;
			num *= 1736059540U;
			dictionary7[72A53E9F] = dynamicMethod;
			num ^= 582132635U;
			goto IL_A6B;
			IL_636:
			Dictionary<MethodBase, DynamicMethod> dictionary8 = 6B147225.764039AB;
			num = 1779202137U + num;
			num *= 681736162U;
			bool flag10 = dictionary8.TryGetValue(72A53E9F, out dynamicMethod);
			num = 1637627157U + num;
			if (!flag10)
			{
				num = 781810443U % num;
				goto IL_670;
			}
			IL_A6B:
			if (num == 1510766582U)
			{
				goto IL_636;
			}
		}
		finally
		{
			do
			{
				num = 1929587928U;
				object obj5 = dictionary5;
				num %= 1046677171U;
				Monitor.Exit(obj5);
			}
			while (786308611U == num);
		}
		num = 1714777855U;
		object obj6 = dynamicMethod.Invoke(null, array8);
		num = 714167055U * num;
		77241A = obj6;
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator = dictionary2.GetEnumerator();
		num = 1532578835U % num;
		using (Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator2 = enumerator)
		{
			if (71183163U < num)
			{
				goto IL_AE1;
			}
			do
			{
				IL_B59:
				num = 422600531U >> (int)num;
				if (enumerator2.MoveNext())
				{
					goto IL_AE1;
				}
			}
			while ((1021647100U & num) != 0U);
			goto IL_B95;
			IL_AE1:
			num = 411443343U;
			KeyValuePair<int, 6B147225.68EF01A4> keyValuePair = enumerator2.Current;
			num = 561674280U + num;
			if ((633414708U & num) != 0U)
			{
				num /= 383541683U;
				6B147225.68EF01A4 value2 = keyValuePair.Value;
				object[] array20 = array8;
				num /= 719464732U;
				int key3 = keyValuePair.Key;
				num ^= 1718762661U;
				int num42 = (int)(num + 2576204636U);
				num |= 535060269U;
				value2.62B618BD(array20[key3 + num42]);
				num ^= 2141702802U;
				goto IL_B59;
			}
			goto IL_B59;
		}
		IL_B95:
		num = 1092381048U;
		if ((num ^ 1777934532U) != 0U)
		{
			dictionary2.Clear();
			num += 555681117U;
			goto IL_BE9;
		}
		goto IL_BE9;
		IL_BBF:
		object obj7 = obj3;
		num &= 1151160674U;
		object obj8 = 72A53E9F.Invoke(obj7, array2);
		num &= 1140204609U;
		77241A = obj8;
		num += 1648062165U;
		IL_BE9:
		num %= 1131494740U;
		Dictionary<int, 6B147225.68EF01A4> dictionary9 = dictionary2;
		num = 422659487U >> (int)num;
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator3 = dictionary9.GetEnumerator();
		num = (1504468705U | num);
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator2 = enumerator3;
		try
		{
			for (;;)
			{
				num = 1300786398U << (int)num;
				bool flag11 = enumerator2.MoveNext();
				num = 818235976U - num;
				if (!flag11)
				{
					break;
				}
				KeyValuePair<int, 6B147225.68EF01A4> keyValuePair2 = enumerator2.Current;
				num = 1594190789U;
				num %= 798966478U;
				6B147225.68EF01A4 value3 = keyValuePair2.Value;
				object[] array21 = array2;
				num = 1306093200U / num;
				int key4 = keyValuePair2.Key;
				num -= 622945672U;
				object 7FCE2AA2 = array21[key4];
				num = 721946680U << (int)num;
				value3.62B618BD(7FCE2AA2);
				num += 3988586223U;
			}
		}
		finally
		{
			num = 1705860866U;
			if (num > 173089064U)
			{
				num = (213858590U | num);
				((IDisposable)enumerator2).Dispose();
			}
		}
		do
		{
			num = 2066359156U;
			if (19807604U < num)
			{
				bool flag12 = methodInfo2 != null;
				num -= 1234044407U;
				if (flag12)
				{
					if ((num ^ 128647274U) == 0U)
					{
						continue;
					}
					if (methodInfo2.ReturnType != typeof(void))
					{
						goto IL_D37;
					}
					num ^= 0U;
				}
			}
			num = 1349804052U - num;
		}
		while (num > 1747592269U);
		return null;
		IL_D37:
		return this.6F327B1B(77241A, methodInfo2.ReturnType);
	}

	// Token: 0x06000392 RID: 914 RVA: 0x00E70FD4 File Offset: 0x00E6D3D4
	private 6B147225.68EF01A4 6B6D4DAE(int 26DF4B7A, bool 61156D2F)
	{
		uint num = 1680294316U;
		Dictionary<int, 6B147225.68EF01A4> dictionary2;
		int num12;
		for (;;)
		{
			IL_07:
			num |= 440232905U;
			int num2 = this.53F44057;
			num = 1426265327U - num;
			int num3 = num2;
			num |= 581907162U;
			if (num - 480008825U != 0U)
			{
				goto IL_3A;
			}
			goto IL_58;
			ushort num5;
			for (;;)
			{
				IL_60:
				Dictionary<int, 6B147225.68EF01A4> dictionary = new Dictionary<int, 6B147225.68EF01A4>();
				num %= 1196298046U;
				dictionary2 = dictionary;
				num = (877817700U ^ num);
				object[] array;
				if (716983333U != num)
				{
					array = null;
					if ((1594295909U ^ num) != 0U)
					{
						goto IL_97;
					}
					goto IL_58;
				}
				IL_CB:
				int num4 = (int)num5;
				num = 1340163097U + num;
				int num6 = (int)(num ^ 1475626090U);
				num |= 1706130752U;
				int num7 = num4 - num6;
				num += 742928968U;
				int num8 = num7;
				if ((1488021617U ^ num) == 0U)
				{
					break;
				}
				for (;;)
				{
					num = 1815696530U * num;
					if (num == 1421569470U)
					{
						goto IL_60;
					}
					if (num8 < (int)(num ^ 2343563286U))
					{
						break;
					}
					num = 215891025U;
					6B147225.68EF01A4 68EF01A = this.114C39DF();
					num = (920985296U ^ num);
					6B147225.68EF01A4 68EF01A2 = 68EF01A;
					num %= 35655069U;
					bool flag = 68EF01A2.684ED4C6();
					num >>= 21;
					if (flag)
					{
						Dictionary<int, 6B147225.68EF01A4> dictionary3 = dictionary2;
						int key = num8;
						6B147225.68EF01A4 value = 68EF01A2;
						num = (290917036U ^ num);
						dictionary3[key] = value;
						num += 4004050268U;
					}
					object[] array2 = array;
					int num9 = num8;
					num ^= 1448370886U;
					object 77241A = 68EF01A2;
					num &= 215435706U;
					num -= 1142754577U;
					int 43B2167F = this.0D7859B3();
					num |= 557609951U;
					object obj = this.6F327B1B(77241A, this.04A156D1(43B2167F)).5049A7CC();
					num /= 260471924U;
					array2[num9] = obj;
					num >>= 5;
					if (num - 1481990818U == 0U)
					{
						goto IL_07;
					}
					int num10 = num8;
					num /= 1763248844U;
					int num11 = num10 - (int)(num ^ 1U);
					num = (1437956498U | num);
					num8 = num11;
					num ^= 4052276769U;
				}
				num += 3475130022U;
				IL_220:
				num = 1391941194U + num;
				num12 = this.0D7859B3();
				num = (1028747932U ^ num);
				int num13 = this.53F44057;
				num = 2138724864U / num;
				26DF4B7A = num13;
				num = 736506510U - num;
				if (num - 914255114U == 0U)
				{
					goto IL_07;
				}
				int num14 = num3;
				num |= 213723442U;
				this.53F44057 = num14;
				if (1014960380U - num != 0U)
				{
					if (61156D2F)
					{
						num -= 1830639450U;
						if (num == 2145325169U)
						{
							goto IL_07;
						}
						if (array == null)
						{
							goto IL_2DE;
						}
						object[] array3 = array;
						num &= 233462820U;
						int num15 = (int)(num - 14697508U);
						num /= 506740293U;
						bool flag2 = array3[num15];
						num ^= 805256126U;
						if (!flag2)
						{
							goto Block_13;
						}
					}
					num = 1241586539U - num;
					if (62940638 << (int)num == 0)
					{
						break;
					}
					6B147225 6B = new 6B147225();
					object[] 6F8F1E6E = array;
					num <<= 28;
					int 0B4E06E = 26DF4B7A;
					num = 2124680707U % num;
					object obj2 = 6B.654329F0(6F8F1E6E, 0B4E06E);
					num = 947655582U + num;
					object obj3 = obj2;
					if (num != 1287214596U)
					{
						goto Block_15;
					}
					continue;
				}
				IL_97:
				uint num16 = (uint)num5;
				num = 1148877208U + num;
				if (num16 > num - 1523726012U)
				{
					int num17 = (int)num5;
					num = 57233723U + num;
					array = new object[num17];
					num = (685189202U & num);
					goto IL_CB;
				}
				goto IL_220;
			}
			IL_3A:
			this.53F44057 = 26DF4B7A;
			num |= 1910990776U;
			if (num + 2073252384U == 0U)
			{
				goto IL_60;
			}
			IL_58:
			num5 = (ushort)this.75DA0F9B();
			goto IL_60;
		}
		Block_13:
		num ^= 3978223578U;
		IL_2DE:
		num *= 614342056U;
		throw new NullReferenceException();
		Block_15:
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator = dictionary2.GetEnumerator();
		num %= 1982146274U;
		Dictionary<int, 6B147225.68EF01A4>.Enumerator enumerator2 = enumerator;
		try
		{
			if (1506243965U >= num)
			{
				goto IL_3C8;
			}
			IL_366:
			num = 1046484533U;
			KeyValuePair<int, 6B147225.68EF01A4> keyValuePair = enumerator2.Current;
			num >>= 16;
			6B147225.68EF01A4 value2 = keyValuePair.Value;
			num ^= 1764295045U;
			object[] array;
			object[] array4 = array;
			num = 592264837U % num;
			num = (830105934U ^ num);
			int key2 = keyValuePair.Key;
			num = (1208637264U | num);
			value2.62B618BD(array4[key2]);
			num += 3871056612U;
			IL_3C8:
			if (enumerator2.MoveNext())
			{
				goto IL_366;
			}
		}
		finally
		{
			do
			{
				num = 34954905U;
				((IDisposable)enumerator2).Dispose();
			}
			while (num == 1382025977U);
		}
		while (num12 != 0)
		{
			num = 663237348U;
			num -= 199767584U;
			Type type = this.04A156D1(num12);
			num = 1837451907U * num;
			Type type2 = type;
			RuntimeTypeHandle handle = typeof(void).TypeHandle;
			num ^= 1797672488U;
			if (type2 == Type.GetTypeFromHandle(handle))
			{
				break;
			}
			num = (1630368292U | num);
			if (1960589306U != num)
			{
				object obj3;
				object 77241A2 = obj3;
				Type 174C3C = type;
				num /= 693981828U;
				return this.6F327B1B(77241A2, 174C3C);
			}
		}
		return null;
	}

	// Token: 0x06000393 RID: 915 RVA: 0x00E71468 File Offset: 0x00E6D868
	private bool 3662770D(object 1C8D241F, Type 5A59670C)
	{
		uint num;
		for (;;)
		{
			num = 2107274298U;
			if (1C8D241F == null)
			{
				break;
			}
			if (529076285U * num != 0U)
			{
				goto Block_1;
			}
		}
		return num - 2107274297U != 0U;
		Block_1:
		num = 591593687U - num;
		Type type = 1C8D241F.GetType();
		num -= 1555120330U;
		Type type2 = type;
		Type type3 = type2;
		num = 950411847U % num;
		if (type3 != 5A59670C)
		{
			num = (1440432761U ^ num);
			bool flag = 5A59670C.IsAssignableFrom(type2);
			num >>= 4;
			if (!flag)
			{
				num = 1951885050U >> (int)num;
				return num + 4050981665U != 0U;
			}
			num += 835603524U;
		}
		num = 1448245016U % num;
		return num - 497833168U != 0U;
	}

	// Token: 0x06000394 RID: 916 RVA: 0x00E71504 File Offset: 0x00E6D904
	private void 092A492C(Exception 30404E69)
	{
		uint num;
		6B147225.770962F3 770962F3;
		for (;;)
		{
			IL_00:
			Stack<6B147225.14B354D4> stack = this.176B51CC;
			num = 144246624U;
			stack.Clear();
			num = 1177711716U << (int)num;
			if ((1567169110U & num) != 0U)
			{
				for (;;)
				{
					IL_2F:
					num &= 1875118874U;
					this.21241E86.Clear();
					num /= 1829860528U;
					for (;;)
					{
						IL_4E:
						num >>= 4;
						bool flag = this.7D4C655B != null;
						num /= 678114497U;
						if (!flag)
						{
							num = (523773742U | num);
							if (141504226U < num)
							{
								goto IL_83;
							}
							goto IL_00;
						}
						IL_5F4:
						while (num != 1976446484U)
						{
							num = 538277759U + num;
							Stack<6B147225.045263C1> stack2 = this.31162A15;
							num ^= 1953330653U;
							if (stack2.Count == 0)
							{
								goto Block_30;
							}
							for (;;)
							{
								IL_99:
								num = 1351251819U;
								if (num == 933977472U)
								{
									goto IL_2F;
								}
								Stack<6B147225.045263C1> stack3 = this.31162A15;
								num = 2035768811U / num;
								6B147225.045263C1 045263C = stack3.Peek();
								num ^= 585842399U;
								List<6B147225.770962F3> list = 045263C.3B2F2F31();
								num <<= 30;
								List<6B147225.770962F3> list2 = list;
								num = 1858157499U - num;
								if (1077873391U < num)
								{
									num = 72826726U + num;
									int num4;
									if (this.7D4C655B != null)
									{
										num = 1774994076U >> (int)num;
										if (num >= 1016661052U)
										{
											goto IL_00;
										}
										List<6B147225.770962F3> list3 = list2;
										num <<= 24;
										num <<= 13;
										int num2 = list3.IndexOf(this.7D4C655B);
										num ^= 1093861533U;
										int num3 = (int)(num ^ 1093861532U);
										num = (1896303203U ^ num);
										num4 = num2 + num3;
									}
									else
									{
										num4 = (int)(num ^ 4078467873U);
										num += 1025232861U;
									}
									num <<= 3;
									this.7D4C655B = null;
									int num5 = num4;
									while (1628114710U <= num)
									{
										int num6 = num5;
										List<6B147225.770962F3> list4 = list2;
										num <<= 12;
										int count = list4.Count;
										num = 1850883585U + num;
										if (num6 >= count)
										{
											num += 774122106U;
											Stack<6B147225.045263C1> stack4 = this.31162A15;
											num &= 1561024859U;
											stack4.Pop();
											num = 296161322U + num;
											num = (1290486131U & num);
											if (853958029U == num)
											{
												break;
											}
											int num7 = list2.Count;
											if (num - 223817004U == 0U)
											{
												goto IL_4E;
											}
											for (;;)
											{
												int num8 = num7;
												uint num9 = num - 1084768257U;
												num *= 668106693U;
												if (num8 <= num9)
												{
													break;
												}
												List<6B147225.770962F3> list5 = list2;
												num = 982405515U;
												6B147225.770962F3 770962F = list5[num7 - (int)(num ^ 982405514U)];
												byte b = 770962F.77873502();
												num <<= 15;
												uint num10 = num ^ 684032002U;
												num %= 59312101U;
												if (b == num10)
												{
													goto IL_4DA;
												}
												num = 493966793U % num;
												if ((uint)770962F.77873502() == (num ^ 19983462U))
												{
													num ^= 13813067U;
													goto IL_4DA;
												}
												IL_515:
												int num11 = num7;
												num = 353779108U << (int)num;
												int num12 = (int)(num - 1415116431U);
												num ^= 1574976902U;
												int num13 = num11 - num12;
												num %= 1131110396U;
												num7 = num13;
												num ^= 1225820951U;
												continue;
												IL_4DA:
												num &= 1332159041U;
												if (num < 1802046077U)
												{
													Stack<int> stack5 = this.21241E86;
													num /= 484120031U;
													stack5.Push(770962F.3E5F028F());
													num ^= 19983458U;
													goto IL_515;
												}
												goto IL_4E;
											}
											num -= 977022937U;
											if ((num ^ 1211461690U) == 0U)
											{
												goto IL_2F;
											}
											num += 1672560584U;
											Stack<int> stack6 = this.21241E86;
											num = (1107890413U ^ num);
											bool count2 = stack6.Count != 0;
											num += 3077972135U;
											if (!count2)
											{
												goto IL_5F4;
											}
											num = 147478214U + num;
											if (num <= 1181700817U)
											{
												goto Block_28;
											}
											goto IL_99;
										}
										else
										{
											List<6B147225.770962F3> list6 = list2;
											int index = num5;
											num = 2046236240U;
											6B147225.770962F3 770962F2 = list6[index];
											num >>= 29;
											770962F3 = 770962F2;
											num = 453592945U >> (int)num;
											if (954821511U == num)
											{
												break;
											}
											byte b2 = 770962F3.77873502();
											num = 38760984U % num;
											byte b3 = b2;
											if (41373400U == num)
											{
												break;
											}
											bool flag2 = b3 != 0;
											num |= 1197024839U;
											if (flag2)
											{
												if ((num ^ 1279266735U) == 0U)
												{
													goto IL_2F;
												}
												uint num14 = (uint)b3;
												num = 877155069U + num;
												if (num14 == (num ^ 2074593629U))
												{
													goto IL_35C;
												}
												if (581988262U == num)
												{
													goto IL_2F;
												}
											}
											else
											{
												num = 1062025323U * num;
												Type type = 30404E69.GetType();
												num >>= 25;
												Type type2 = type;
												num = (540480187U & num);
												if (270229820 << (int)num == 0)
												{
													goto IL_2F;
												}
												num |= 1689479633U;
												6B147225.770962F3 770962F4 = 770962F3;
												num &= 345326593U;
												Type type3 = this.04A156D1(770962F4.641A0856());
												if (num >= 1123379692U)
												{
													break;
												}
												Type type4 = type2;
												num = 121251061U / num;
												if (type4 == type3)
												{
													goto IL_2DD;
												}
												num = 2099514348U << (int)num;
												Type type5 = type2;
												num >>= 3;
												bool flag3 = type5.IsSubclassOf(type3);
												num ^= 1693371303U;
												if (flag3)
												{
													goto Block_14;
												}
											}
											int num15 = num5;
											num = (1461863341U | num);
											num5 = num15 + (int)(num - 2141703164U);
											num ^= 4261780493U;
										}
									}
									goto IL_00;
								}
								goto IL_00;
							}
							IL_35C:
							if (num % 668168988U != 0U)
							{
								goto Block_15;
							}
							goto IL_83;
						}
						IL_94:
						goto IL_5F4;
						IL_83:
						this.249E65CD = 30404E69;
						num ^= 523773742U;
						goto IL_94;
					}
					Block_15:
					this.7D4C655B = 770962F3;
					num = 1982167006U + num;
					if (num / 378019999U == 0U)
					{
						goto IL_00;
					}
					Stack<6B147225.14B354D4> stack7 = this.176B51CC;
					num += 755117120U;
					stack7.Push(new 6B147225.3FCC0B6B(this.249E65CD));
					if ((540547140U ^ num) != 0U)
					{
						goto Block_17;
					}
				}
				Block_30:
				num /= 556955421U;
				if (num != 174746588U)
				{
					goto Block_31;
				}
			}
		}
		Block_14:
		num ^= 2074593629U;
		IL_2DD:
		num |= 867107998U;
		this.31162A15.Pop();
		num >>= 19;
		Stack<6B147225.14B354D4> stack8 = this.176B51CC;
		num = (1336043668U & num);
		num -= 760815785U;
		object 02FC5CA = this.249E65CD;
		num *= 1642675413U;
		stack8.Push(new 6B147225.3FCC0B6B(02FC5CA));
		num = 177209764U - num;
		num = (1765690789U | num);
		int num16 = 770962F3.3E5F028F();
		num = 1763316585U + num;
		this.53F44057 = num16;
		return;
		Block_17:
		6B147225.770962F3 770962F5 = 770962F3;
		num = 2053183325U * num;
		this.53F44057 = 770962F5.641A0856();
		return;
		Block_28:
		num = 1482102500U - num;
		num -= 1050300084U;
		int num17 = this.21241E86.Pop();
		num = (367412256U | num);
		this.53F44057 = num17;
		return;
		Block_31:
		throw 30404E69;
	}

	// Token: 0x06000395 RID: 917 RVA: 0x00E71B4C File Offset: 0x00E6DF4C
	private void 0E0938F5()
	{
		uint num = 1069025611U;
		6B147225.68EF01A4 68EF01A3;
		6B147225.68EF01A4 68EF01A4;
		for (;;)
		{
			num = 927494643U >> (int)num;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1970297674U / num;
			Type type = this.04A156D1(68EF01A.EDAECC1C());
			num ^= 440273104U;
			Type 174C3C = type;
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 135873070U >> (int)num;
			68EF01A3 = 68EF01A2;
			num >>= 25;
			num >>= 12;
			num ^= 1069811028U;
			68EF01A4 = this.6F327B1B(this.114C39DF().5049A7CC(), 174C3C);
			num = (1291135210U ^ num);
			if (71462852U != num)
			{
				6B147225.68EF01A4 68EF01A5 = 68EF01A3;
				num >>= 14;
				bool flag = 68EF01A5.684ED4C6();
				num = (1225850947U | num);
				if (!flag)
				{
					goto IL_E6;
				}
				num <<= 14;
				if (num - 1284074566U != 0U)
				{
					break;
				}
			}
		}
		6B147225.68EF01A4 10F = 68EF01A4;
		num += 707491141U;
		6B147225.68EF01A4 578F3F = 68EF01A3;
		num = 748825953U * num;
		6B147225.68EF01A4 68EF01A6 = new 6B147225.048D2534(10F, 578F3F);
		num = 60257685U >> (int)num;
		68EF01A4 = 68EF01A6;
		num ^= 1225619307U;
		IL_E6:
		List<6B147225.68EF01A4> list = this.374C66F2;
		num *= 1569996536U;
		6B147225.68EF01A4 item = 68EF01A4;
		num *= 1887897605U;
		list.Add(item);
	}

	// Token: 0x06000396 RID: 918 RVA: 0x00E71C5C File Offset: 0x00E6E05C
	private void 73175DAE()
	{
		uint num = 436470902U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num = (2106402367U ^ num);
		int num2 = 68EF01A.EDAECC1C();
		num += 1088431440U;
		int num3 = num2;
		num = (1129074932U | num);
		using (List<6B147225.045263C1>.Enumerator enumerator = this.1DD42960.GetEnumerator())
		{
			for (;;)
			{
				for (;;)
				{
					bool flag = enumerator.MoveNext();
					num |= 960365151U;
					if (!flag)
					{
						goto Block_5;
					}
					num = 1475159595U;
					6B147225.045263C1 045263C2;
					if ((2031628943U & num) != 0U)
					{
						num -= 2146700269U;
						6B147225.045263C1 045263C = enumerator.Current;
						num = 1968970542U % num;
						045263C2 = 045263C;
						if (num < 175076157U)
						{
							break;
						}
						int num4 = 045263C2.206548D1();
						num = 1299657237U / num;
						int num5 = num3;
						num ^= 3949811709U;
						if (num4 != num5)
						{
							break;
						}
						num %= 1478645598U;
					}
					Stack<6B147225.045263C1> stack = this.31162A15;
					num <<= 15;
					stack.Push(045263C2);
					num ^= 3217938429U;
				}
			}
			Block_5:;
		}
	}

	// Token: 0x06000397 RID: 919 RVA: 0x00E71D64 File Offset: 0x00E6E164
	private void 35E57C7B()
	{
		this.72160E89(new 6B147225.1F462BA1(this.0D7859B3()));
	}

	// Token: 0x06000398 RID: 920 RVA: 0x00E71D88 File Offset: 0x00E6E188
	private void 357734FC()
	{
		uint num = 1097095515U;
		num = 2102858339U << (int)num;
		num = (1313891611U ^ num);
		6B147225.68EF01A4 7E485B = new 6B147225.58E136FA(this.6E0126C6());
		num = (1581656295U & num);
		this.72160E89(7E485B);
	}

	// Token: 0x06000399 RID: 921 RVA: 0x00E71DCC File Offset: 0x00E6E1CC
	private void 04ED7FCC()
	{
		uint num = 1155360789U;
		do
		{
			num = 837177717U / num;
			num = (210115288U | num);
			float 2DBD116A = this.395A3124();
			num = (1743022006U | num);
			6B147225.68EF01A4 7E485B = new 6B147225.1F5C5947(2DBD116A);
			num = (1063217777U & num);
			this.72160E89(7E485B);
		}
		while (722293409U / num != 0U);
	}

	// Token: 0x0600039A RID: 922 RVA: 0x00E71E1C File Offset: 0x00E6E21C
	private void 0C8C75E3()
	{
		uint num;
		do
		{
			num = 1507622602U;
			num = (891106018U ^ num);
			6B147225.68EF01A4 7E485B = new 6B147225.60416C9D(this.48A81D26());
			num %= 1888828580U;
			this.72160E89(7E485B);
		}
		while ((num ^ 2045315999U) == 0U);
	}

	// Token: 0x0600039B RID: 923 RVA: 0x00E71E5C File Offset: 0x00E6E25C
	private void 340E502E()
	{
		uint num;
		do
		{
			object 02FC5CA = null;
			num = 1243107650U;
			this.72160E89(new 6B147225.3FCC0B6B(02FC5CA));
		}
		while (num + 404956075U == 0U);
	}

	// Token: 0x0600039C RID: 924 RVA: 0x00E71E88 File Offset: 0x00E6E288
	private void 685A48E2()
	{
		uint num = 1093478951U;
		num *= 881679876U;
		string 356D354A = this.2AE22E39(this.114C39DF().EDAECC1C());
		num = 791424753U >> (int)num;
		this.72160E89(new 6B147225.2B9A788E(356D354A));
	}

	// Token: 0x0600039D RID: 925 RVA: 0x00E71ED0 File Offset: 0x00E6E2D0
	private void 2014144B()
	{
		uint num = 885659362U;
		num = (977159494U | num);
		this.72160E89(this.4206269E().2EEBA499());
	}

	// Token: 0x0600039E RID: 926 RVA: 0x00E71EFC File Offset: 0x00E6E2FC
	private void 5DAD1526()
	{
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		uint num = 659768962U;
		6B147225.68EF01A4 68EF01A2 = 68EF01A;
		6B147225.68EF01A4 68EF01A4;
		do
		{
			6B147225.68EF01A4 68EF01A3 = this.114C39DF();
			num = (112549011U & num);
			68EF01A4 = 68EF01A3;
		}
		while (num >= 1701865102U);
		num %= 1157766044U;
		6B147225.68EF01A4 0DA = 68EF01A2;
		num = 772691060U << (int)num;
		6B147225.68EF01A4 0CB = 68EF01A4;
		num &= 746719877U;
		bool 125D19A = (num ^ 671088768U) != 0U;
		num += 772026721U;
		bool 7ECE4C7A = num + 2851851807U != 0U;
		num = (2072869531U ^ num);
		this.72160E89(this.0DC12445(0DA, 0CB, 125D19A, 7ECE4C7A));
	}

	// Token: 0x0600039F RID: 927 RVA: 0x00E71F7C File Offset: 0x00E6E37C
	private void 62CE50CC()
	{
		uint num = 116156193U;
		if (num - 2103998832U == 0U)
		{
			goto IL_37;
		}
		IL_12:
		num = 1326339333U << (int)num;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num -= 2103586966U;
		6B147225.68EF01A4 68EF01A2 = 68EF01A;
		num |= 1538813254U;
		IL_37:
		6B147225.68EF01A4 68EF01A3 = this.114C39DF();
		num >>= 3;
		6B147225.68EF01A4 68EF01A4 = 68EF01A3;
		if (225121252U == num)
		{
			goto IL_12;
		}
		6B147225.68EF01A4 0DA = 68EF01A2;
		6B147225.68EF01A4 0CB = 68EF01A4;
		bool 125D19A = num - 259477421U != 0U;
		num <<= 6;
		6B147225.68EF01A4 7E485B = this.0DC12445(0DA, 0CB, 125D19A, (num ^ 3721653120U) != 0U);
		num = 597691691U / num;
		this.72160E89(7E485B);
		if (num - 2022187615U != 0U)
		{
			return;
		}
		goto IL_12;
	}

	// Token: 0x060003A0 RID: 928 RVA: 0x00E72014 File Offset: 0x00E6E414
	private void 285D09B9()
	{
		uint num = 1048673821U;
		6B147225.68EF01A4 68EF01A;
		6B147225.68EF01A4 68EF01A2;
		if ((num & 518473228U) != 0U)
		{
			num = 1511416792U / num;
			68EF01A = this.114C39DF();
			num ^= 743656201U;
			num |= 88749402U;
			68EF01A2 = this.114C39DF();
			num <<= 29;
		}
		do
		{
			num = 320302399U * num;
			6B147225.68EF01A4 0DA = 68EF01A;
			6B147225.68EF01A4 0CB = 68EF01A2;
			num &= 1598436067U;
			bool 125D19A = num + 3221225473U != 0U;
			num |= 1476803322U;
			bool 7ECE4C7A = (num ^ 1476803323U) != 0U;
			num *= 1166159427U;
			6B147225.68EF01A4 7E485B = this.0DC12445(0DA, 0CB, 125D19A, 7ECE4C7A);
			num = (1444881419U | num);
			this.72160E89(7E485B);
		}
		while (715156763U > num);
	}

	// Token: 0x060003A1 RID: 929 RVA: 0x00E720B0 File Offset: 0x00E6E4B0
	private void 076D5B2A()
	{
		uint num = 724918803U;
		6B147225.68EF01A4 68EF01A;
		6B147225.68EF01A4 68EF01A3;
		if (14897936U >> (int)num != 0U)
		{
			for (;;)
			{
				num = 1088642613U >> (int)num;
				68EF01A = this.114C39DF();
				if (1842683755 << (int)num != 0)
				{
					6B147225.68EF01A4 68EF01A2 = this.114C39DF();
					num -= 1210259272U;
					68EF01A3 = 68EF01A2;
					if (num + 853619734U != 0U)
					{
						break;
					}
				}
			}
		}
		6B147225.68EF01A4 618A07CF = 68EF01A3;
		num = (1916098704U ^ num);
		6B147225.68EF01A4 059517B = 68EF01A;
		num >>= 16;
		bool 677C2C = num - 50665U != 0U;
		bool 2CB33AD = num - 50665U != 0U;
		num <<= 3;
		this.72160E89(this.5EC14AE2(618A07CF, 059517B, 677C2C, 2CB33AD));
	}

	// Token: 0x060003A2 RID: 930 RVA: 0x00E7214C File Offset: 0x00E6E54C
	private void 22D146F6()
	{
		uint num = 2118284269U;
		6B147225.68EF01A4 68EF01A;
		if (num >> 28 != 0U)
		{
			68EF01A = this.114C39DF();
			num = 293431937U % num;
		}
		num |= 1221733524U;
		6B147225.68EF01A4 68EF01A2 = this.114C39DF();
		if (num + 1243358331U != 0U)
		{
			do
			{
				num = (805582661U | num);
				6B147225.68EF01A4 618A07CF = 68EF01A2;
				6B147225.68EF01A4 059517B = 68EF01A;
				bool 677C2C = num - 2046787540U != 0U;
				bool 2CB33AD = num - 2046787541U != 0U;
				num |= 1278029365U;
				6B147225.68EF01A4 7E485B = this.5EC14AE2(618A07CF, 059517B, 677C2C, 2CB33AD);
				num = (530647301U ^ num);
				this.72160E89(7E485B);
			}
			while (2124441072U == num);
		}
	}

	// Token: 0x060003A3 RID: 931 RVA: 0x00E721D4 File Offset: 0x00E6E5D4
	private void 5E2E6EC1()
	{
		6B147225.68EF01A4 059517B = this.114C39DF();
		uint num = 1986353239U;
		for (;;)
		{
			num = 751445246U % num;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 408830864U + num;
			6B147225.68EF01A4 618A07CF = 68EF01A;
			if (num * 2045923221U != 0U)
			{
				num ^= 833825505U;
				num = 530712600U % num;
				this.72160E89(this.5EC14AE2(618A07CF, 059517B, (num ^ 530712601U) != 0U, num + 3764254697U != 0U));
				if (229903723U * num != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00E7224C File Offset: 0x00E6E64C
	private void 56C23C40()
	{
		uint num = 676598981U;
		if ((num ^ 815226977U) == 0U)
		{
			goto IL_29;
		}
		IL_12:
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num |= 913664975U;
		6B147225.68EF01A4 68EF01A2 = 68EF01A;
		num >>= 22;
		IL_29:
		6B147225.68EF01A4 68EF01A3 = this.114C39DF();
		num ^= 1199528655U;
		if (num != 1418401139U)
		{
			num |= 1632838706U;
			6B147225.68EF01A4 2EF254CC = 68EF01A3;
			6B147225.68EF01A4 037861FA = 68EF01A2;
			bool 6556234C = (num ^ 1736408630U) != 0U;
			bool 6338003D = (num ^ 1736408630U) != 0U;
			num &= 1723342277U;
			6B147225.68EF01A4 7E485B = this.32B739C2(2EF254CC, 037861FA, 6556234C, 6338003D);
			num = 1135690565U << (int)num;
			this.72160E89(7E485B);
			return;
		}
		goto IL_12;
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x00E722D8 File Offset: 0x00E6E6D8
	private void 33391827()
	{
		uint num = 165177512U;
		for (;;)
		{
			6B147225.68EF01A4 037861FA = this.114C39DF();
			num = 2066750142U + num;
			6B147225.68EF01A4 2EF254CC = this.114C39DF();
			if (num >= 425470295U)
			{
				num >>= 0;
				this.72160E89(this.32B739C2(2EF254CC, 037861FA, (num ^ 2231927655U) != 0U, (num ^ 2231927654U) != 0U));
				if (num > 1190997746U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003A6 RID: 934 RVA: 0x00E7233C File Offset: 0x00E6E73C
	private void 0B410DF3()
	{
		uint num = 191052504U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		if (num >> 7 != 0U)
		{
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 1955805282U >> (int)num;
			6B147225.68EF01A4 68EF01A3 = 68EF01A2;
			6B147225.68EF01A4 2EF254CC = 68EF01A3;
			6B147225.68EF01A4 037861FA = 68EF01A;
			num |= 319244710U;
			6B147225.68EF01A4 7E485B = this.32B739C2(2EF254CC, 037861FA, num - 319244789U != 0U, (num ^ 319244791U) != 0U);
			num <<= 5;
			this.72160E89(7E485B);
		}
	}

	// Token: 0x060003A7 RID: 935 RVA: 0x00E723A4 File Offset: 0x00E6E7A4
	private void 6CC86ABB()
	{
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		uint num = 1727426395U;
		6B147225.68EF01A4 74F14EB = 68EF01A;
		num /= 410745765U;
		if (num < 330772416U)
		{
			do
			{
				6B147225.68EF01A4 68EF01A2 = this.114C39DF();
				num = 2583697U >> (int)num;
				num += 1656297982U;
				6B147225.68EF01A4 744052AE = 68EF01A2;
				num = 1651519430U << (int)num;
				this.72160E89(this.5F6F1AAB(744052AE, 74F14EB, num - 941089536U != 0U));
			}
			while (num == 1453152855U);
		}
	}

	// Token: 0x060003A8 RID: 936 RVA: 0x00E7241C File Offset: 0x00E6E81C
	private void 73FC179B()
	{
		uint num;
		6B147225.68EF01A4 68EF01A2;
		6B147225.68EF01A4 68EF01A4;
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 617879847U;
			68EF01A2 = 68EF01A;
			if (num <= 1491094121U)
			{
				num *= 956332060U;
				6B147225.68EF01A4 68EF01A3 = this.114C39DF();
				num /= 960314592U;
				68EF01A4 = 68EF01A3;
				if (num + 635712133U != 0U)
				{
					break;
				}
			}
		}
		num /= 263919937U;
		6B147225.68EF01A4 744052AE = 68EF01A4;
		6B147225.68EF01A4 74F14EB = 68EF01A2;
		num = 1430389358U - num;
		this.72160E89(this.5F6F1AAB(744052AE, 74F14EB, num - 1430389357U != 0U));
	}

	// Token: 0x060003A9 RID: 937 RVA: 0x00E7248C File Offset: 0x00E6E88C
	private void 548B3481()
	{
		uint num = 134030791U;
		do
		{
			num = (2114088165U | num);
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (1893869066U & num);
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			if (72433971U - num == 0U)
			{
				break;
			}
			6B147225.68EF01A4 68EF01A3 = this.114C39DF();
			num <<= 0;
			6B147225.68EF01A4 68EF01A4 = 68EF01A3;
			num += 1546131769U;
			num /= 1009994648U;
			num /= 1178165468U;
			6B147225.68EF01A4 3A2D41CB = 68EF01A4;
			num = 1263345226U >> (int)num;
			6B147225.68EF01A4 7CCD6FE = 68EF01A2;
			bool 1D2A68DF = num + 3031622070U != 0U;
			num ^= 636961454U;
			6B147225.68EF01A4 7E485B = this.0E200672(3A2D41CB, 7CCD6FE, 1D2A68DF);
			num = 614279725U << (int)num;
			this.72160E89(7E485B);
		}
		while (num <= 617831081U);
	}

	// Token: 0x060003AA RID: 938 RVA: 0x00E72530 File Offset: 0x00E6E930
	private void 65BD5E64()
	{
		for (;;)
		{
			uint num = 1460561207U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1317094353U * num;
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			num <<= 29;
			if (360776856U != num)
			{
				num = (1348739100U & num);
				6B147225.68EF01A4 68EF01A3 = this.114C39DF();
				num = 1696740009U - num;
				if (num != 1889416902U)
				{
					6B147225.68EF01A4 3A2D41CB = 68EF01A3;
					6B147225.68EF01A4 7CCD6FE = 68EF01A2;
					num ^= 350776004U;
					this.72160E89(this.0E200672(3A2D41CB, 7CCD6FE, (num ^ 835344492U) != 0U));
					if ((num ^ 201080873U) != 0U)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003AB RID: 939 RVA: 0x00E725B0 File Offset: 0x00E6E9B0
	private void 104C242D()
	{
		uint num = 1395406838U;
		6B147225.68EF01A4 2F;
		if (num != 1637701688U)
		{
			do
			{
				num |= 806700317U;
				6B147225.68EF01A4 68EF01A = this.114C39DF();
				num = (237576120U | num);
				2F = 68EF01A;
			}
			while ((1816927815U & num) == 0U);
		}
		6B147225.68EF01A4 78EF14CD = this.114C39DF();
		if (num > 661597198U)
		{
			6B147225.68EF01A4 7E485B = this.416E39C3(78EF14CD, 2F);
			num <<= 30;
			this.72160E89(7E485B);
		}
	}

	// Token: 0x060003AC RID: 940 RVA: 0x00E7261C File Offset: 0x00E6EA1C
	private void 343307D2()
	{
		uint num = 976185785U;
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1601188159U - num;
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			if (num - 1239097725U != 0U)
			{
				for (;;)
				{
					num <<= 18;
					6B147225.68EF01A4 68EF01A3 = this.114C39DF();
					num = (956529164U ^ num);
					6B147225.68EF01A4 68EF01A4 = 68EF01A3;
					if (num == 445655193U)
					{
						break;
					}
					num *= 965673315U;
					num = 1077044546U + num;
					6B147225.68EF01A4 4D673E8B = 68EF01A4;
					6B147225.68EF01A4 64641C3E = 68EF01A2;
					num *= 1949594265U;
					6B147225.68EF01A4 7E485B = this.68840CCE(4D673E8B, 64641C3E);
					num -= 1893205896U;
					this.72160E89(7E485B);
					if (num != 778656378U)
					{
						return;
					}
				}
			}
		}
	}

	// Token: 0x060003AD RID: 941 RVA: 0x00E726A8 File Offset: 0x00E6EAA8
	private void 0DCF157D()
	{
		uint num;
		6B147225.68EF01A4 68EF01A2;
		6B147225.68EF01A4 68EF01A4;
		do
		{
			num = 1813262791U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num &= 1380073103U;
			68EF01A2 = 68EF01A;
			if (num + 1304984545U == 0U)
			{
				break;
			}
			num >>= 24;
			6B147225.68EF01A4 68EF01A3 = this.114C39DF();
			num %= 370830026U;
			68EF01A4 = 68EF01A3;
			num = (676012272U ^ num);
		}
		while (num * 539782806U == 0U);
		num <<= 13;
		6B147225.68EF01A4 15B = 68EF01A4;
		num = 332404881U * num;
		6B147225.68EF01A4 4C396C0B = 68EF01A2;
		num = (145909845U ^ num);
		this.72160E89(this.1EDC252D(15B, 4C396C0B));
	}

	// Token: 0x060003AE RID: 942 RVA: 0x00E72728 File Offset: 0x00E6EB28
	private void 1CF528B2()
	{
		uint num = 1940020771U;
		6B147225.68EF01A4 344039A = this.114C39DF();
		if (num >> 22 != 0U)
		{
			num = (244123045U & num);
			this.72160E89(this.3EA21B89(344039A));
		}
	}

	// Token: 0x060003AF RID: 943 RVA: 0x00E72764 File Offset: 0x00E6EB64
	private void 65FC77CC()
	{
		uint num;
		do
		{
			num = 949626003U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 807695537U - num;
			num >>= 21;
			6B147225.68EF01A4 3D = 68EF01A;
			num -= 185824937U;
			this.72160E89(this.68E333DB(3D));
		}
		while (num << 27 == 0U);
	}

	// Token: 0x060003B0 RID: 944 RVA: 0x00E727B0 File Offset: 0x00E6EBB0
	private void 63C40051()
	{
		6B147225.68EF01A4 2C3E15DA = this.114C39DF();
		uint num = 1205894241U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		6B147225.68EF01A4 3126727E = 68EF01A;
		num *= 1763723518U;
		this.72160E89(this.5C511F83(3126727E, 2C3E15DA, (num ^ 3369513022U) != 0U));
	}

	// Token: 0x060003B1 RID: 945 RVA: 0x00E727F0 File Offset: 0x00E6EBF0
	private void 7B3F02E5()
	{
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		uint num = 1395854396U;
		6B147225.68EF01A4 68EF01A3;
		do
		{
			num = 2025283334U << (int)num;
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 52433691U >> (int)num;
			68EF01A3 = 68EF01A2;
			num = (1624798820U | num);
		}
		while ((2090555395U ^ num) == 0U);
		num = 81489086U >> (int)num;
		6B147225.68EF01A4 3126727E = 68EF01A3;
		num <<= 22;
		6B147225.68EF01A4 2C3E15DA = 68EF01A;
		bool 23DF2AF = (num ^ 1U) != 0U;
		num &= 966619889U;
		6B147225.68EF01A4 7E485B = this.5C511F83(3126727E, 2C3E15DA, 23DF2AF);
		num = (430784779U ^ num);
		this.72160E89(7E485B);
	}

	// Token: 0x060003B2 RID: 946 RVA: 0x00E7287C File Offset: 0x00E6EC7C
	private void 041073EB()
	{
		for (;;)
		{
			uint num = 960325184U;
			6B147225.68EF01A4 21940A1D = this.114C39DF();
			num = 979774091U - num;
			if ((228338122U ^ num) != 0U)
			{
				num = 160637902U + num;
				6B147225.68EF01A4 68EF01A = this.114C39DF();
				num = (1249182879U & num);
				if (num < 1224292418U)
				{
					num = 662986096U * num;
					6B147225.68EF01A4 0D341F2B = 68EF01A;
					num <<= 25;
					6B147225.68EF01A4 7E485B = this.561F4FE5(0D341F2B, 21940A1D);
					num %= 1104432550U;
					this.72160E89(7E485B);
					if (num != 1763206706U)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003B3 RID: 947 RVA: 0x00E72900 File Offset: 0x00E6ED00
	private void 57302E15()
	{
		uint num;
		Type type;
		do
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 512491991U;
			type = this.04A156D1(68EF01A.EDAECC1C());
		}
		while (num > 1108632855U);
		do
		{
			object 77241A = this.114C39DF();
			num = 1649308814U % num;
			Type 174C3C = type;
			num /= 1759082034U;
			this.72160E89(this.6F327B1B(77241A, 174C3C));
		}
		while ((1818719648U & num) != 0U);
	}

	// Token: 0x060003B4 RID: 948 RVA: 0x00E72960 File Offset: 0x00E6ED60
	private void 1BBE5E66()
	{
		uint num = 271395786U;
		int 43B2167F = this.114C39DF().EDAECC1C();
		num = 649676448U / num;
		Type type = this.04A156D1(43B2167F);
		num = 1089298288U + num;
		Type type2 = type;
		if ((num ^ 1638031118U) != 0U)
		{
			do
			{
				num = 396635518U >> (int)num;
				num %= 1634546227U;
				6B147225.68EF01A4 68EF01A = this.114C39DF();
				Type 7FA16FE = type2;
				num <<= 26;
				object 77241A = 68EF01A.CA964614(7FA16FE, num + 1543503872U != 0U);
				num = 292363597U * num;
				Type 174C3C = type2;
				num = 285564198U - num;
				6B147225.68EF01A4 7E485B = this.6F327B1B(77241A, 174C3C);
				num = 11821454U - num;
				this.72160E89(7E485B);
			}
			while (635588952U > num);
		}
	}

	// Token: 0x060003B5 RID: 949 RVA: 0x00E72A04 File Offset: 0x00E6EE04
	private void 0B6F1D84()
	{
		uint num = 1685851104U;
		for (;;)
		{
			num -= 589304536U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1132863637U - num;
			Type type = this.04A156D1(68EF01A.EDAECC1C());
			num = 190064594U - num;
			if (num / 1001990629U == 0U)
			{
				num %= 1190820292U;
				num >>= 25;
				num = (29306872U | num);
				6B147225.68EF01A4 68EF01A2 = this.114C39DF();
				Type 7FA16FE = type;
				bool 422A4F = (num ^ 29306877U) != 0U;
				num = 138051295U * num;
				object 77241A = 68EF01A2.CA964614(7FA16FE, 422A4F);
				num |= 425593202U;
				Type 174C3C = type;
				num >>= 17;
				this.72160E89(this.6F327B1B(77241A, 174C3C));
				if (13135351U != num)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003B6 RID: 950 RVA: 0x00E72AA8 File Offset: 0x00E6EEA8
	private void 73290840()
	{
		uint num = 1839741606U;
		num *= 1682976804U;
		int 43B2167F = this.0D7859B3();
		num |= 2093906835U;
		Type t = this.04A156D1(43B2167F);
		num /= 1787524168U;
		int 5EEF = Marshal.SizeOf(t);
		num |= 1574440915U;
		6B147225.68EF01A4 7E485B = new 6B147225.1F462BA1(5EEF);
		num += 1130831515U;
		this.72160E89(7E485B);
	}

	// Token: 0x060003B7 RID: 951 RVA: 0x00E72B00 File Offset: 0x00E6EF00
	private void 19D279C4()
	{
		uint num = 1096559855U;
		if (1695498390U >= num)
		{
			goto IL_11;
		}
		6B147225.68EF01A4 68EF01A;
		do
		{
			IL_49:
			num &= 1262696872U;
			68EF01A = this.114C39DF();
			num -= 1603277258U;
			if (68EF01A.684ED4C6())
			{
				goto IL_E0;
			}
		}
		while (67970308U - num == 0U);
		Type type;
		do
		{
			object obj = 68EF01A.5049A7CC();
			num = 580132533U % num;
			if (!(obj is Pointer))
			{
				goto IL_DA;
			}
			if (1429353788U <= num)
			{
				goto IL_11;
			}
			object ptr = 68EF01A.5049A7CC();
			num &= 1359889667U;
			6B147225.68EF01A4 68EF01A2 = new 6B147225.77A20E0A(new IntPtr(Pointer.Unbox(ptr)), type);
			num = 684405149U - num;
			68EF01A = 68EF01A2;
		}
		while (num - 276184998U == 0U);
		num += 3131621562U;
		goto IL_E0;
		IL_DA:
		throw new ArgumentException();
		IL_E0:
		num >>= 21;
		object 77241A = 68EF01A;
		Type 174C3C = type;
		num += 633162625U;
		this.72160E89(this.6F327B1B(77241A, 174C3C));
		return;
		IL_11:
		num &= 1861239131U;
		num >>= 26;
		int 43B2167F = this.114C39DF().EDAECC1C();
		num = 198062040U >> (int)num;
		Type type2 = this.04A156D1(43B2167F);
		num = 1940403875U + num;
		type = type2;
		goto IL_49;
	}

	// Token: 0x060003B8 RID: 952 RVA: 0x00E72C0C File Offset: 0x00E6F00C
	private void 46675BC7()
	{
		uint num = 875239535U;
		FieldInfo fieldInfo2;
		object obj2;
		for (;;)
		{
			num = (128468722U & num);
			FieldInfo fieldInfo = this.599E792E(this.114C39DF().EDAECC1C());
			num >>= 9;
			fieldInfo2 = fieldInfo;
			if (num << 28 == 0U)
			{
				num = 151090625U - num;
				6B147225.68EF01A4 68EF01A = this.114C39DF();
				num = 402531334U + num;
				object obj = 68EF01A.5049A7CC();
				num = 2033541391U / num;
				obj2 = obj;
				for (;;)
				{
					FieldInfo fieldInfo3 = fieldInfo2;
					num = 1191905444U / num;
					bool isStatic = fieldInfo3.IsStatic;
					num = 1112504068U << (int)num;
					if (!isStatic)
					{
						if (282472568U > num)
						{
							break;
						}
						bool flag = obj2 != null;
						num += 0U;
						if (!flag)
						{
							goto Block_4;
						}
					}
					num *= 741680695U;
					if (num > 847925907U)
					{
						goto Block_5;
					}
				}
			}
		}
		Block_4:
		num = (1560944707U & num);
		throw new NullReferenceException();
		Block_5:
		num |= 1948071145U;
		object value = fieldInfo2.GetValue(obj2);
		num = 1579905109U * num;
		FieldInfo fieldInfo4 = fieldInfo2;
		num += 152650779U;
		6B147225.68EF01A4 7E485B = this.6F327B1B(value, fieldInfo4.FieldType);
		num += 2070900462U;
		this.72160E89(7E485B);
	}

	// Token: 0x060003B9 RID: 953 RVA: 0x00E72D08 File Offset: 0x00E6F108
	private void 27C365AB()
	{
		uint num;
		FieldInfo fieldInfo;
		object obj2;
		for (;;)
		{
			num = 1914266643U;
			fieldInfo = this.599E792E(this.114C39DF().EDAECC1C());
			num /= 1716801693U;
			do
			{
				6B147225.68EF01A4 68EF01A = this.114C39DF();
				num = (555437365U | num);
				object obj = 68EF01A.5049A7CC();
				num = (1731533863U | num);
				obj2 = obj;
				num ^= 1355096042U;
			}
			while (688731417U == num);
			bool isStatic = fieldInfo.IsStatic;
			num -= 184829575U;
			if (!isStatic)
			{
				if (num + 1450119876U == 0U)
				{
					break;
				}
				bool flag = obj2 != null;
				num ^= 0U;
				if (!flag)
				{
					num += 199964800U;
					if (num * 1139370260U != 0U)
					{
						break;
					}
					continue;
				}
			}
			num -= 1021782778U;
			if (606559984U / num == 0U)
			{
				goto Block_4;
			}
		}
		throw new NullReferenceException();
		Block_4:
		num %= 1648624166U;
		FieldInfo 2BB403FC = fieldInfo;
		num |= 1716217358U;
		this.72160E89(new 6B147225.0A3736B6(2BB403FC, obj2));
	}

	// Token: 0x060003BA RID: 954 RVA: 0x00E72DDC File Offset: 0x00E6F1DC
	private void 33CD2988()
	{
		uint num;
		FieldInfo fieldInfo;
		object obj2;
		6B147225.68EF01A4 68EF01A3;
		for (;;)
		{
			num = 486816592U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (305356610U ^ num);
			fieldInfo = this.599E792E(68EF01A.EDAECC1C());
			num = 379873661U * num;
			if (1824140645U < num)
			{
				goto IL_33;
			}
			IL_42:
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 2147308666U * num;
			object obj = 68EF01A2.5049A7CC();
			num = (154294879U | num);
			obj2 = obj;
			num *= 1759464079U;
			if (num > 1554979857U)
			{
				if (fieldInfo.IsStatic)
				{
					goto IL_A3;
				}
				num = (1240028207U | num);
				if (num > 647178199U)
				{
					break;
				}
				continue;
			}
			IL_33:
			num &= 272768865U;
			68EF01A3 = this.114C39DF();
			goto IL_42;
		}
		bool flag = obj2 != null;
		num ^= 163595310U;
		if (!flag)
		{
			throw new NullReferenceException();
		}
		IL_A3:
		FieldInfo fieldInfo2 = fieldInfo;
		num <<= 10;
		object obj3 = obj2;
		num /= 679300092U;
		object 77241A = 68EF01A3;
		num = (875449219U & num);
		6B147225.68EF01A4 68EF01A4 = this.6F327B1B(77241A, fieldInfo.FieldType);
		num = 391083805U * num;
		object value = 68EF01A4.5049A7CC();
		num %= 1809410163U;
		fieldInfo2.SetValue(obj3, value);
	}

	// Token: 0x060003BB RID: 955 RVA: 0x00E72ED0 File Offset: 0x00E6F2D0
	private void 00E3065E()
	{
		uint num = 800863876U;
		int 7E194FE = this.114C39DF().EDAECC1C();
		num = (968643579U & num);
		FieldInfo fieldInfo = this.599E792E(7E194FE);
		num /= 1042824059U;
		6B147225.68EF01A4 68EF01A;
		if (290093030U >= num)
		{
			do
			{
				num = 50033789U + num;
				68EF01A = this.114C39DF();
			}
			while (num > 486887483U);
		}
		FieldInfo fieldInfo2 = fieldInfo;
		object obj = null;
		num = 375289606U << (int)num;
		object 77241A = 68EF01A;
		Type fieldType = fieldInfo.FieldType;
		num = (1560625655U | num);
		object value = this.6F327B1B(77241A, fieldType).5049A7CC();
		num += 1207251112U;
		fieldInfo2.SetValue(obj, value);
	}

	// Token: 0x060003BC RID: 956 RVA: 0x00E72F64 File Offset: 0x00E6F364
	private void 73B51109()
	{
		uint num = 673522806U;
		Type type2;
		6B147225.68EF01A4 77241A;
		6B147225.68EF01A4 68EF01A3;
		do
		{
			num = 32930616U % num;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (654802348U | num);
			int 43B2167F = 68EF01A.EDAECC1C();
			num += 1848006267U;
			Type type = this.04A156D1(43B2167F);
			num &= 2130076678U;
			type2 = type;
			num = 603266906U % num;
			77241A = this.114C39DF();
			num = 2020177462U * num;
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 769148816U >> (int)num;
			68EF01A3 = 68EF01A2;
			num = 101863808U >> (int)num;
			6B147225.68EF01A4 68EF01A4 = 68EF01A3;
			num = 464155864U - num;
			if (68EF01A4.684ED4C6())
			{
				goto IL_108;
			}
			num |= 96808355U;
			bool flag = 68EF01A3.5049A7CC() is Pointer;
			num -= 1455960562U;
			if (!flag)
			{
				goto IL_102;
			}
			num = 1608277924U + num;
		}
		while (num == 415901628U);
		6B147225.68EF01A4 68EF01A5 = 68EF01A3;
		num |= 1181360673U;
		object ptr = 68EF01A5.5049A7CC();
		num = 1205435157U << (int)num;
		IntPtr 62D = new IntPtr(Pointer.Unbox(ptr));
		num *= 1380668384U;
		6B147225.68EF01A4 68EF01A6 = new 6B147225.77A20E0A(62D, type2);
		num <<= 30;
		68EF01A3 = 68EF01A6;
		num += 464143430U;
		goto IL_108;
		IL_102:
		throw new ArgumentException();
		IL_108:
		num = 782778787U - num;
		6B147225.68EF01A4 68EF01A7 = 68EF01A3;
		num = 264844687U >> (int)num;
		6B147225.68EF01A4 68EF01A8 = this.6F327B1B(77241A, type2);
		num >>= 9;
		object 7FCE2AA = 68EF01A8.5049A7CC();
		num /= 345849590U;
		68EF01A7.62B618BD(7FCE2AA);
	}

	// Token: 0x060003BD RID: 957 RVA: 0x00E730B4 File Offset: 0x00E6F4B4
	private void 2CF451AF()
	{
		uint num = 1492469126U;
		do
		{
			num %= 349906416U;
			num = 1857038305U / num;
			List<6B147225.68EF01A4> list = this.374C66F2;
			num = 129318052U * num;
			ushort num2 = (ushort)this.75DA0F9B();
			num = 328681238U << (int)num;
			int index = (int)num2;
			num = (1679952396U | num);
			6B147225.68EF01A4 68EF01A = list[index];
			num = (113193407U | num);
			this.72160E89(68EF01A.2EEBA499());
		}
		while ((num & 1929975591U) == 0U);
	}

	// Token: 0x060003BE RID: 958 RVA: 0x00E73128 File Offset: 0x00E6F528
	private void 3D7E61BB()
	{
		uint num = 1089214594U;
		num ^= 2012900419U;
		List<6B147225.68EF01A4> list = this.374C66F2;
		num -= 1356729058U;
		num |= 401031681U;
		int index = (int)((ushort)this.75DA0F9B());
		num += 23396414U;
		6B147225.68EF01A4 651A2A = list[index];
		num = (469175205U | num);
		6B147225.68EF01A4 7E485B = new 6B147225.0EEF2230(651A2A);
		num >>= 24;
		this.72160E89(7E485B);
	}

	// Token: 0x060003BF RID: 959 RVA: 0x00E73188 File Offset: 0x00E6F588
	private void 1CF516A9()
	{
		uint num = 725955186U;
		if (num < 395205965U)
		{
			goto IL_3A;
		}
		6B147225.68EF01A4 68EF01A;
		do
		{
			IL_11:
			num = 1819360952U - num;
			68EF01A = this.114C39DF();
			num = 1009997729U + num;
		}
		while (1819361354U >> (int)num == 0U);
		do
		{
			IL_3A:
			List<6B147225.68EF01A4> list = this.374C66F2;
			num ^= 778008693U;
			int index = (int)((ushort)this.75DA0F9B());
			num = (1402349821U ^ num);
			6B147225.68EF01A4 68EF01A2 = list[index];
			num <<= 22;
			6B147225.68EF01A4 68EF01A3 = 68EF01A2;
			num = (578702418U & num);
			if (1192122607U - num == 0U)
			{
				goto IL_11;
			}
			6B147225.68EF01A4 68EF01A4 = 68EF01A3;
			object 77241A = 68EF01A;
			6B147225.68EF01A4 68EF01A5 = 68EF01A3;
			num &= 940118356U;
			Type 174C3C = 68EF01A5.0B2A827C();
			num = 1763859989U - num;
			object 7FCE2AA = this.6F327B1B(77241A, 174C3C).5049A7CC();
			num = 769474678U << (int)num;
			68EF01A4.62B618BD(7FCE2AA);
		}
		while (num % 1412120894U == 0U);
	}

	// Token: 0x060003C0 RID: 960 RVA: 0x00E73250 File Offset: 0x00E6F650
	private void 7DD5082A()
	{
		uint num = 2069309239U;
		num = 2096974311U - num;
		Type type = this.04A156D1(this.114C39DF().EDAECC1C());
		num &= 599938422U;
		this.47653FC8 = type;
	}

	// Token: 0x060003C1 RID: 961 RVA: 0x00E7328C File Offset: 0x00E6F68C
	private void 338E7468()
	{
		uint num = 998512176U;
		do
		{
			num = 1406618866U / num;
			num |= 1800092830U;
			int 16461A = this.114C39DF().EDAECC1C();
			num ^= 1026971711U;
			MethodBase methodBase = this.3BFD2570(16461A);
			num -= 694905367U;
			MethodBase methodBase2 = methodBase;
			MethodBase 72A53E9F = methodBase2;
			bool 28054C = num - 756152969U != 0U;
			num = (1642222489U ^ num);
			6B147225.68EF01A4 68EF01A = this.4B500392(72A53E9F, 28054C);
			num *= 1465417199U;
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			num = 1683104752U / num;
			if (68EF01A2 != null)
			{
				num /= 886514179U;
				this.72160E89(68EF01A2);
				num ^= 1U;
			}
		}
		while ((num ^ 1075987179U) == 0U);
	}

	// Token: 0x060003C2 RID: 962 RVA: 0x00E73324 File Offset: 0x00E6F724
	private void 42335B77()
	{
		uint num = 61232503U;
		MethodBase methodBase2;
		Type[] array2;
		for (;;)
		{
			IL_06:
			num = (2140475727U & num);
			int 16461A = this.114C39DF().EDAECC1C();
			num = 1642160376U >> (int)num;
			MethodBase methodBase = this.3BFD2570(16461A);
			num <<= 9;
			methodBase2 = methodBase;
			if (1054304609U < num)
			{
				do
				{
					num = 1766806988U / num;
					bool flag = this.47653FC8 != null;
					num &= 1134782532U;
					if (!flag)
					{
						goto IL_1EC;
					}
				}
				while ((num & 1196959511U) != 0U);
				for (;;)
				{
					MethodBase methodBase3 = methodBase2;
					num = 1405380225U + num;
					ParameterInfo[] parameters = methodBase3.GetParameters();
					Type[] array = new Type[parameters.Length];
					num = (1208107036U ^ num);
					array2 = array;
					int num2 = (int)(num ^ 465970845U);
					num = 1526277437U - num;
					int num3 = num2;
					ParameterInfo[] array3 = parameters;
					int num4 = (int)(num ^ 1060306592U);
					if (1725904240U <= num)
					{
						break;
					}
					while ((num ^ 311185292U) != 0U)
					{
						int num5 = num4;
						ParameterInfo[] array4 = array3;
						num = 217451616U / num;
						if (num5 >= array4.Length)
						{
							goto Block_5;
						}
						num = 1983402306U;
						ParameterInfo[] array5 = array3;
						num *= 1120353132U;
						ParameterInfo parameterInfo = array5[num4];
						num = 709387577U + num;
						ParameterInfo parameterInfo2 = parameterInfo;
						if ((num & 1794908169U) == 0U)
						{
							goto IL_06;
						}
						Type[] array6 = array2;
						int num6 = num3;
						int num7 = (int)(num ^ 856875792U);
						num &= 286020577U;
						num3 = num6 + num7;
						num = 764416454U << (int)num;
						ParameterInfo parameterInfo3 = parameterInfo2;
						num -= 1584358944U;
						Type parameterType = parameterInfo3.ParameterType;
						num = 1371014911U - num;
						array6[num6] = parameterType;
						num = (1268328027U & num);
						int num8 = num4;
						num = 627328702U << (int)num;
						num4 = num8 + (int)(num - 904921087U);
						num ^= 180551328U;
					}
				}
			}
		}
		Block_5:
		num *= 1499675941U;
		Type type = this.47653FC8;
		num = 778070537U * num;
		string name = methodBase2.Name;
		num -= 1257660524U;
		BindingFlags bindingAttr = (BindingFlags)(num ^ 3037310624U);
		num &= 2113492591U;
		Binder binder = null;
		Type[] types = array2;
		num = 1203898719U << (int)num;
		MethodInfo method = type.GetMethod(name, bindingAttr, binder, types, null);
		num >>= 30;
		MethodInfo methodInfo = method;
		if (methodInfo != null)
		{
			num = 2022718892U << (int)num;
			MethodBase methodBase4 = methodInfo;
			num = 1627135233U / num;
			methodBase2 = methodBase4;
			num += 1U;
		}
		this.47653FC8 = null;
		num += uint.MaxValue;
		IL_1EC:
		num = 1784109118U + num;
		6B147225.68EF01A4 68EF01A = this.4B500392(methodBase2, num + 2510858179U != 0U);
		num = 373495608U + num;
		6B147225.68EF01A4 68EF01A2 = 68EF01A;
		bool flag2 = 68EF01A2 != null;
		num &= 1522171570U;
		if (flag2)
		{
			num /= 1101359707U;
			6B147225.68EF01A4 7E485B = 68EF01A2;
			num = 298212575U - num;
			this.72160E89(7E485B);
			num += 4006875475U;
		}
	}

	// Token: 0x060003C3 RID: 963 RVA: 0x00E7356C File Offset: 0x00E6F96C
	private void 2CAF332F()
	{
		uint num = 491263553U;
		MethodBase methodBase;
		if (752557487U > num)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 2131783821U / num;
			object obj = 68EF01A.5049A7CC();
			num %= 1403876074U;
			methodBase = (obj as MethodBase);
			num = 1066617819U % num;
			if (num % 1255151341U == 0U)
			{
				goto IL_5C;
			}
		}
		for (;;)
		{
			bool flag = methodBase != null;
			num += 2130119651U;
			if (!flag)
			{
				break;
			}
			if (num > 1068766032U)
			{
				num = 1235899861U / num;
				MethodBase 72A53E9F = methodBase;
				num >>= 15;
				bool 28054C = (num ^ 0U) != 0U;
				num -= 657281622U;
				6B147225.68EF01A4 68EF01A2 = this.4B500392(72A53E9F, 28054C);
				if (68EF01A2 != null)
				{
					6B147225.68EF01A4 7E485B = 68EF01A2;
					num /= 2001472440U;
					this.72160E89(7E485B);
					num ^= 3637685675U;
				}
				if ((1831627566U ^ num) != 0U)
				{
					return;
				}
			}
		}
		num = (1890614752U & num);
		IL_5C:
		throw new ArgumentException();
	}

	// Token: 0x060003C4 RID: 964 RVA: 0x00E73638 File Offset: 0x00E6FA38
	private void 7DA75F08()
	{
		uint num = 286817153U;
		for (;;)
		{
			num += 169699079U;
			int 26DF4B7A = this.114C39DF().EDAECC1C();
			num = 848573695U / num;
			bool 61156D2F = (num ^ 1U) != 0U;
			num |= 534971734U;
			6B147225.68EF01A4 68EF01A = this.6B6D4DAE(26DF4B7A, 61156D2F);
			num = 2052673725U - num;
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			if (606363711U >> (int)num != 0U)
			{
				bool flag = 68EF01A2 != null;
				num |= 1636001408U;
				if (flag)
				{
					if (638790485U >= num)
					{
						continue;
					}
					this.72160E89(68EF01A2);
					num ^= 0U;
				}
				if (num - 39080229U != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003C5 RID: 965 RVA: 0x00E736CC File Offset: 0x00E6FACC
	private void 287533B4()
	{
		uint num = 830014307U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num |= 309671667U;
		int 26DF4B7A = 68EF01A.EDAECC1C();
		num %= 1295786389U;
		6B147225.68EF01A4 68EF01A2 = this.6B6D4DAE(26DF4B7A, (num ^ 863844338U) != 0U);
		if ((1311971865U ^ num) != 0U)
		{
			while (68EF01A2 != null)
			{
				num = (757939681U | num);
				if (336331967U < num)
				{
					goto IL_54;
				}
			}
			return;
		}
		IL_54:
		6B147225.68EF01A4 7E485B = 68EF01A2;
		num <<= 7;
		this.72160E89(7E485B);
		num ^= 2380451443U;
	}

	// Token: 0x060003C6 RID: 966 RVA: 0x00E73744 File Offset: 0x00E6FB44
	private void 0AD64C7E()
	{
		uint num;
		6B147225.68EF01A4 68EF01A3;
		do
		{
			num = 1845697933U;
			num &= 2119985390U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (225391910U | num);
			MethodBase methodBase = this.3BFD2570(68EF01A.EDAECC1C());
			num = (1722833811U ^ num);
			num = (1832921597U ^ num);
			MethodBase 3C9D0B5C = methodBase;
			num *= 36857922U;
			6B147225.68EF01A4 68EF01A2 = this.7D244481(3C9D0B5C);
			num |= 864498404U;
			68EF01A3 = 68EF01A2;
			num += 161630007U;
			bool flag = 68EF01A3 != null;
			num ^= 1238055909U;
			if (!flag)
			{
				return;
			}
		}
		while (num < 2117761401U);
		num = (1654208640U ^ num);
		6B147225.68EF01A4 7E485B = 68EF01A3;
		num = 1561681006U / num;
		this.72160E89(7E485B);
		num ^= 2154380542U;
	}

	// Token: 0x060003C7 RID: 967 RVA: 0x00E737E4 File Offset: 0x00E6FBE4
	private void 5D4D68BE()
	{
		uint num = 1676900335U;
		6B147225.68EF01A4 68EF01A2;
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (1942374845U | num);
			Type type = this.04A156D1(68EF01A.EDAECC1C());
			num <<= 5;
			68EF01A2 = this.114C39DF();
			bool isGenericType = type.IsGenericType;
			num /= 835141038U;
			if (isGenericType)
			{
				num = 1295854790U / num;
				Type type2 = type;
				num /= 1770482182U;
				Type genericTypeDefinition = type2.GetGenericTypeDefinition();
				num >>= 6;
				Type typeFromHandle = typeof(Nullable<>);
				num %= 1644980395U;
				num ^= 2U;
				if (genericTypeDefinition == typeFromHandle)
				{
					if (902000540 << (int)num != 0)
					{
						break;
					}
					continue;
				}
			}
			num = 1315184706U << (int)num;
			bool isValueType = type.IsValueType;
			num *= 424312500U;
			if (isValueType)
			{
				num = 1922318148U / num;
				Type type3 = type;
				num = 45421076U + num;
				BindingFlags bindingAttr = (BindingFlags)(num ^ 45421152U);
				num /= 1754429682U;
				FieldInfo[] fields = type3.GetFields(bindingAttr);
				num *= 53888322U;
				FieldInfo[] array = fields;
				num &= 206391419U;
				int num2 = (int)(num + 0U);
				num <<= 7;
				int num3 = num2;
				if (num != 1832915529U)
				{
					for (;;)
					{
						num |= 1516195314U;
						int num4 = num3;
						num = (164834073U | num);
						int num5 = array.Length;
						num = (886066785U ^ num);
						if (num4 >= num5)
						{
							return;
						}
						FieldInfo[] array2 = array;
						int num6 = num3;
						num = 2144291388U;
						FieldInfo fieldInfo = array2[num6];
						FieldInfo fieldInfo2 = fieldInfo;
						num = 924006146U % num;
						object obj = 68EF01A2.5049A7CC();
						num -= 1456343877U;
						Type fieldType = fieldInfo.FieldType;
						num /= 474946651U;
						object value;
						if (!fieldType.IsValueType)
						{
							value = null;
						}
						else
						{
							num += 525275584U;
							value = Activator.CreateInstance(fieldInfo.FieldType);
							num += 3769691712U;
						}
						num = 1667332308U / num;
						fieldInfo2.SetValue(obj, value);
						num += 2070951356U;
						if ((num ^ 644033355U) == 0U)
						{
							break;
						}
						int num7 = num3;
						int num8 = (int)(num ^ 2309141684U);
						num = 610882868U * num;
						int num9 = num7 + num8;
						num = 526518551U % num;
						num3 = num9;
						num ^= 526518551U;
					}
				}
			}
			else
			{
				if (num < 1605520653U)
				{
					return;
				}
				6B147225.68EF01A4 68EF01A3 = 68EF01A2;
				num |= 550923243U;
				object 7FCE2AA = null;
				num = (611723321U ^ num);
				68EF01A3.62B618BD(7FCE2AA);
				if (877010176U <= num)
				{
					return;
				}
			}
		}
		6B147225.68EF01A4 68EF01A4 = 68EF01A2;
		num = (1296128630U & num);
		object 7FCE2AA2 = null;
		num ^= 836046911U;
		68EF01A4.62B618BD(7FCE2AA2);
	}

	// Token: 0x060003C8 RID: 968 RVA: 0x00E73A50 File Offset: 0x00E6FE50
	private void 0F4079E7()
	{
		uint num = 1027170639U;
		int num2;
		do
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 811749610U << (int)num;
			num2 = 68EF01A.EDAECC1C();
			num = (720251719U | num);
		}
		while (num == 782314270U);
		for (;;)
		{
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 1873166027U + num;
			6B147225.68EF01A4 68EF01A3 = 68EF01A2;
			if (1511352297U - num != 0U)
			{
				num = 600513863U % num;
				6B147225.68EF01A4 68EF01A4 = this.114C39DF();
				num = 733299810U * num;
				6B147225.68EF01A4 68EF01A5 = 68EF01A4;
				num >>= 13;
				6B147225.68EF01A4 60D13ED = 68EF01A5;
				6B147225.68EF01A4 787153D = 68EF01A3;
				bool 5F = num - 146904U != 0U;
				int 3D4A = num2;
				num = 391065928U << (int)num;
				int 5EEF = this.5E181947(60D13ED, 787153D, 5F, 3D4A);
				num |= 1036208423U;
				6B147225.68EF01A4 7E485B = new 6B147225.1F462BA1(5EEF);
				num *= 1932930238U;
				this.72160E89(7E485B);
				if ((num & 1486363652U) != 0U)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003C9 RID: 969 RVA: 0x00E73B10 File Offset: 0x00E6FF10
	private void 355B0EF2()
	{
		uint num = 205741444U;
		int 3D4A;
		6B147225.68EF01A4 68EF01A3;
		if (919764723U >= num)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (1474102611U | num);
			3D4A = 68EF01A.EDAECC1C();
			6B147225.68EF01A4 68EF01A2 = this.114C39DF();
			num = 229060581U - num;
			68EF01A3 = 68EF01A2;
			num = 433405464U * num;
			if (num == 594554438U)
			{
				return;
			}
		}
		num = 2144822876U >> (int)num;
		6B147225.68EF01A4 68EF01A4 = this.114C39DF();
		num = 2099712319U % num;
		6B147225.68EF01A4 68EF01A5 = 68EF01A4;
		num = 700521163U - num;
		num = 520121707U << (int)num;
		6B147225.68EF01A4 60D13ED = 68EF01A5;
		6B147225.68EF01A4 787153D = 68EF01A3;
		num |= 154744247U;
		int 5EEF = this.5E181947(60D13ED, 787153D, (num ^ 3375969718U) != 0U, 3D4A);
		num -= 1885878384U;
		6B147225.68EF01A4 7E485B = new 6B147225.1F462BA1(5EEF);
		num = (1734547165U | num);
		this.72160E89(7E485B);
	}

	// Token: 0x060003CA RID: 970 RVA: 0x00E73BCC File Offset: 0x00E6FFCC
	private void 23C57035()
	{
		uint num = 380915011U;
		num <<= 28;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num -= 1378378837U;
		int 43B2167F = 68EF01A.EDAECC1C();
		num = 816513790U % num;
		Type type = this.04A156D1(43B2167F);
		if (1396604696U != num)
		{
			num = (738137056U & num);
			Type elementType = type;
			num = (795764870U & num);
			this.72160E89(new 6B147225.69732A42(Array.CreateInstance(elementType, this.114C39DF().EDAECC1C())));
		}
	}

	// Token: 0x060003CB RID: 971 RVA: 0x00E73C40 File Offset: 0x00E70040
	private void 5B1D16EA()
	{
		for (;;)
		{
			uint num = 345392347U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num %= 1772169487U;
			Type 174C3C = this.04A156D1(68EF01A.EDAECC1C());
			num = 1717401848U * num;
			for (;;)
			{
				num >>= 4;
				6B147225.68EF01A4 77241A = this.114C39DF();
				if ((1216435103U & num) != 0U)
				{
					num = 724974514U - num;
					6B147225.68EF01A4 68EF01A2 = this.114C39DF();
					num &= 1266627729U;
					6B147225.68EF01A4 68EF01A3 = 68EF01A2;
					num /= 171200815U;
					if (2079595054U == num)
					{
						break;
					}
					object obj = this.114C39DF().5049A7CC();
					num = 414911018U >> (int)num;
					Array array = obj as Array;
					num = 220731539U >> (int)num;
					if (num > 1862604330U)
					{
						goto IL_BF;
					}
					if (array == null)
					{
						num = (858028147U | num);
						if (858720307U != num)
						{
							goto IL_BF;
						}
					}
					else
					{
						num &= 1221751902U;
						if ((num ^ 1962366134U) == 0U)
						{
							break;
						}
						Array array2 = array;
						num %= 522525569U;
						object 77241A2 = this.6F327B1B(77241A, 174C3C);
						object obj2 = array;
						num += 1433603906U;
						Type type = obj2.GetType();
						num %= 135080335U;
						Type elementType = type.GetElementType();
						num %= 1982555633U;
						object value = this.6F327B1B(77241A2, elementType).5049A7CC();
						6B147225.68EF01A4 68EF01A4 = 68EF01A3;
						num /= 1660759871U;
						int index = 68EF01A4.EDAECC1C();
						num = 1315724149U - num;
						array2.SetValue(value, index);
						if (718868439U <= num)
						{
							return;
						}
					}
				}
			}
		}
		IL_BF:
		throw new ArgumentException();
	}

	// Token: 0x060003CC RID: 972 RVA: 0x00E73D8C File Offset: 0x00E7018C
	private void 666745F0()
	{
		uint num = 1060262453U;
		Type 174C3C;
		if ((107310642U ^ num) != 0U)
		{
			do
			{
				int 43B2167F = this.114C39DF().EDAECC1C();
				num <<= 5;
				174C3C = this.04A156D1(43B2167F);
			}
			while (num - 1559630687U == 0U);
		}
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num = 466902082U + num;
		6B147225.68EF01A4 68EF01A2 = 68EF01A;
		num |= 1997239000U;
		object obj = this.114C39DF().5049A7CC();
		num = (814427413U & num);
		Array array = obj as Array;
		num = 1597664489U + num;
		Array array2 = array;
		num /= 838691346U;
		if (1802835699U > num)
		{
			bool flag = array2 != null;
			num *= 1776902793U;
			if (flag)
			{
				num = 1018973749U / num;
				num &= 101006591U;
				Array array3 = array2;
				6B147225.68EF01A4 68EF01A3 = 68EF01A2;
				num = 2113864879U - num;
				6B147225.68EF01A4 7E485B = this.6F327B1B(array3.GetValue(68EF01A3.EDAECC1C()), 174C3C);
				num += 848185690U;
				this.72160E89(7E485B);
				return;
			}
			num = 1131952849U + num;
		}
		throw new ArgumentException();
	}

	// Token: 0x060003CD RID: 973 RVA: 0x00E73E74 File Offset: 0x00E70274
	private void 794B7588()
	{
		for (;;)
		{
			uint num = 54854948U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num |= 844579011U;
			Array array = 68EF01A.5049A7CC() as Array;
			num = 1969055927U << (int)num;
			if (num == 1677216009U)
			{
				break;
			}
			bool flag = array != null;
			num += 1166484116U;
			if (!flag)
			{
				break;
			}
			num = 1238654247U / num;
			int length = array.Length;
			num = 283125422U - num;
			6B147225.68EF01A4 7E485B = new 6B147225.1F462BA1(length);
			num -= 1240808246U;
			this.72160E89(7E485B);
			if (897925255U % num != 0U)
			{
				return;
			}
		}
		throw new ArgumentException();
	}

	// Token: 0x060003CE RID: 974 RVA: 0x00E73F04 File Offset: 0x00E70304
	private void 59511227()
	{
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			uint num = 246052773U;
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			num = (1684406675U ^ num);
			Array array2;
			do
			{
				Array array = this.114C39DF().5049A7CC() as Array;
				num %= 778790604U;
				array2 = array;
				num = 182981367U << (int)num;
				bool flag = array2 != null;
				num >>= 8;
				if (!flag)
				{
					goto Block_0;
				}
			}
			while (1683105526U - num == 0U);
			num <<= 31;
			Array 304A372C = array2;
			num >>= 25;
			6B147225.68EF01A4 68EF01A3 = 68EF01A2;
			num = (815747087U | num);
			this.72160E89(new 6B147225.66154DF0(304A372C, 68EF01A3.EDAECC1C()));
			if (num <= 989275809U)
			{
				return;
			}
		}
		Block_0:
		throw new ArgumentException();
	}

	// Token: 0x060003CF RID: 975 RVA: 0x00E73FA4 File Offset: 0x00E703A4
	private void 32024E8A()
	{
		uint num = 1055597977U;
		num += 1123942552U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num += 1572499088U;
		int 16461A = 68EF01A.EDAECC1C();
		num += 47400466U;
		MethodBase 3F93496E = this.3BFD2570(16461A);
		num = 247924873U % num;
		6B147225.68EF01A4 7E485B = new 6B147225.1CB553EA(3F93496E);
		num = 1881604283U >> (int)num;
		this.72160E89(7E485B);
	}

	// Token: 0x060003D0 RID: 976 RVA: 0x00E74004 File Offset: 0x00E70404
	private void 33190BAC()
	{
		for (;;)
		{
			IL_00:
			uint num = 2137264784U;
			num <<= 7;
			MethodBase methodBase = this.3BFD2570(this.114C39DF().EDAECC1C());
			num /= 480715048U;
			MethodBase methodBase2 = methodBase;
			num = 296303872U / num;
			MethodInfo method;
			for (;;)
			{
				num = (1259676143U | num);
				object obj = this.114C39DF().5049A7CC();
				num >>= 0;
				Type type = obj.GetType();
				num = 293822862U - num;
				MemberInfo memberInfo = methodBase2;
				num += 1954305829U;
				Type declaringType = memberInfo.DeclaringType;
				num = (766275911U & num);
				Type type2 = declaringType;
				num |= 340803268U;
				MethodBase methodBase3 = methodBase2;
				num = (1052205356U ^ num);
				ParameterInfo[] parameters = methodBase3.GetParameters();
				num *= 1656974168U;
				num = 107761634U << (int)num;
				int num2 = parameters.Length;
				num ^= 1360547155U;
				Type[] array = new Type[num2];
				num %= 1171610705U;
				int num3 = (int)(num ^ 295609952U);
				num <<= 23;
				ParameterInfo[] array2 = parameters;
				int num4 = (int)(num - 805306368U);
				num ^= 1155480152U;
				int num5 = num4;
				for (;;)
				{
					num = 2140940617U % num;
					if (486489690 << (int)num == 0)
					{
						goto IL_00;
					}
					if (num5 >= array2.Length)
					{
						break;
					}
					ParameterInfo parameterInfo = array2[num5];
					Type[] array3 = array;
					num = 1517426454U;
					int num6 = num3;
					int num7 = (int)(num ^ 1517426455U);
					num = 1838884956U % num;
					num3 = num6 + num7;
					ParameterInfo parameterInfo2 = parameterInfo;
					num = (2093367556U ^ num);
					array3[num6] = parameterInfo2.ParameterType;
					if ((num ^ 2063996404U) == 0U)
					{
						goto IL_00;
					}
					int num8 = num5;
					num = 1316487804U / num;
					int num9 = (int)(num + 1U);
					num %= 1884248805U;
					int num10 = num8 + num9;
					num = 1265762634U * num;
					num5 = num10;
					num += 1960786520U;
				}
				while (num <= 2011566730U)
				{
					bool flag = type != null;
					num -= 1236283779U;
					num ^= 2194073793U;
					if (!flag)
					{
						goto IL_2EF;
					}
					num = 624784577U - num;
					if (1917868546U >= num)
					{
						break;
					}
					Type type3 = type;
					Type type4 = type2;
					num = (1277979249U & num);
					if (type3 == type4)
					{
						goto Block_11;
					}
					num = 1347777438U;
					if (2100697923U < num)
					{
						goto IL_00;
					}
					Type type5 = type;
					MemberInfo memberInfo2 = methodBase2;
					num = 997399595U << (int)num;
					string name = memberInfo2.Name;
					BindingFlags bindingAttr = (BindingFlags)(num ^ 3221303350U);
					num ^= 617485226U;
					Binder binder = null;
					CallingConventions callConvention = (CallingConventions)(num ^ 3838710697U);
					Type[] types = array;
					ParameterModifier[] modifiers = null;
					num = 398872679U % num;
					method = type5.GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
					num |= 194054633U;
					if (method != null)
					{
						MethodInfo methodInfo = method;
						num = 1992240437U * num;
						MethodInfo baseDefinition = methodInfo.GetBaseDefinition();
						MethodBase methodBase4 = methodBase2;
						num += 597779708U;
						num ^= 3330301848U;
						if (baseDefinition == methodBase4)
						{
							num = 1773889437U + num;
							if (2124507640U < num)
							{
								goto Block_6;
							}
							break;
						}
					}
					num = 390616436U - num;
					Type baseType = type.BaseType;
					num <<= 7;
					type = baseType;
					num ^= 2999004273U;
				}
			}
			Block_6:
			MethodBase methodBase5 = method;
			num %= 1170762717U;
			methodBase2 = methodBase5;
			if (num - 1041702751U == 0U)
			{
				continue;
			}
			IL_2EF:
			num = (64119645U ^ num);
			if ((528103444U ^ num) == 0U)
			{
				continue;
			}
			MethodBase 3F93496E = methodBase2;
			num ^= 355797629U;
			this.72160E89(new 6B147225.1CB553EA(3F93496E));
			if (num + 286994517U != 0U)
			{
				break;
			}
			continue;
			Block_11:
			num += 61492127U;
			goto IL_2EF;
		}
	}

	// Token: 0x060003D1 RID: 977 RVA: 0x00E7433C File Offset: 0x00E7073C
	private void 11222D5E()
	{
		uint num;
		do
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1963926174U;
			this.53F44057 = 68EF01A.EDAECC1C();
		}
		while (num + 850922488U == 0U);
	}

	// Token: 0x060003D2 RID: 978 RVA: 0x00E7436C File Offset: 0x00E7076C
	private void 04422881()
	{
		this.114C39DF();
	}

	// Token: 0x060003D3 RID: 979 RVA: 0x00E74380 File Offset: 0x00E70780
	private void 7DF54037()
	{
		uint num = 262346335U;
		if (2074572550U % num == 0U)
		{
			goto IL_62;
		}
		IL_12:
		Stack<int> stack = this.21241E86;
		num ^= 442659510U;
		num = 1361866850U >> (int)num;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num |= 109793314U;
		stack.Push(68EF01A.EDAECC1C());
		num = 632035441U % num;
		IL_4E:
		6B147225.68EF01A4 68EF01A2 = this.114C39DF();
		num = 1795765687U / num;
		int num2 = 68EF01A2.EDAECC1C();
		IL_62:
		for (;;)
		{
			num /= 739079805U;
			if (251290131U < num)
			{
				goto IL_4E;
			}
			if (this.31162A15.Count == 0)
			{
				goto IL_208;
			}
			num = 1335711908U - num;
			if (544304736U >> (int)num == 0U)
			{
				goto IL_4E;
			}
			int num3 = num2;
			num <<= 23;
			num = 260334200U % num;
			Stack<6B147225.045263C1> stack2 = this.31162A15;
			num *= 1727733583U;
			6B147225.045263C1 045263C = stack2.Peek();
			num = (116131882U | num);
			int num4 = 045263C.26F06F1B();
			num = 1245530329U + num;
			if (num3 <= num4)
			{
				break;
			}
			for (;;)
			{
				num = 1131550391U;
				6B147225.045263C1 045263C2 = this.31162A15.Pop();
				num <<= 27;
				List<6B147225.770962F3> list = 045263C2.3B2F2F31();
				num %= 2079064187U;
				List<6B147225.770962F3> list2 = list;
				List<6B147225.770962F3> list3 = list2;
				num = (1264406118U | num);
				int count = list3.Count;
				num *= 1351489955U;
				int num5 = count;
				while (237456312U < num)
				{
					int num6 = num5;
					num = 1744324508U / num;
					uint num7 = num ^ 0U;
					num <<= 13;
					if (num6 <= num7)
					{
						goto Block_5;
					}
					List<6B147225.770962F3> list4 = list2;
					int num8 = num5;
					num = 955475844U;
					6B147225.770962F3 770962F = list4[num8 - (int)(num - 955475843U)];
					num = 1280719286U << (int)num;
					6B147225.770962F3 770962F2 = 770962F;
					if (1830186241U - num == 0U)
					{
						goto IL_12;
					}
					6B147225.770962F3 770962F3 = 770962F2;
					num = (1260342972U ^ num);
					byte b = 770962F3.77873502();
					uint num9 = num + 1904421414U;
					num = 1562841296U * num;
					if (b == num9)
					{
						num = 1310411818U << (int)num;
						Stack<int> stack3 = this.21241E86;
						6B147225.770962F3 770962F4 = 770962F2;
						num <<= 29;
						stack3.Push(770962F4.3E5F028F());
						num += 3545203392U;
					}
					num *= 967922416U;
					if (num == 2026831957U)
					{
						goto IL_12;
					}
					num5 -= (int)(num ^ 3106673665U);
					num += 3809700629U;
				}
			}
			Block_5:
			num ^= 24U;
		}
		num ^= 2049717251U;
		IL_208:
		num ^= 858853541U;
		num = 1703575034U - num;
		Exception ex = null;
		num /= 21133529U;
		this.249E65CD = ex;
		num = 1899514656U + num;
		this.176B51CC.Clear();
		num <<= 24;
		if (num <= 1403603976U)
		{
			int num10 = this.21241E86.Pop();
			num |= 1271753271U;
			this.53F44057 = num10;
			return;
		}
		goto IL_12;
	}

	// Token: 0x060003D4 RID: 980 RVA: 0x00E745F4 File Offset: 0x00E709F4
	private void 5605518D()
	{
		uint num;
		while (this.249E65CD != null)
		{
			num = 1903127024U;
			if (num < 212928285U)
			{
				do
				{
					IL_11:
					num = (315366262U & num);
					num = 53413784U - num;
					Stack<int> stack = this.21241E86;
					num = 1449807317U + num;
					int num2 = stack.Pop();
					num = 1007028755U / num;
					this.53F44057 = num2;
				}
				while (1956409445U - num == 0U);
				return;
			}
			num = 1957888169U % num;
			num >>= 14;
			this.092A492C(this.249E65CD);
			if ((852977273U & num) != 0U)
			{
				return;
			}
		}
		num = 1044383205U;
		goto IL_11;
	}

	// Token: 0x060003D5 RID: 981 RVA: 0x00E7468C File Offset: 0x00E70A8C
	private void 70114960()
	{
		uint num;
		for (;;)
		{
			num = 679308759U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num >>= 18;
			bool flag = 68EF01A.EDAECC1C() != 0;
			num -= 257370513U;
			if (flag)
			{
				if (num != 1907832657U)
				{
					break;
				}
			}
			else
			{
				num = 642257391U - num;
				Exception 30404E = this.249E65CD;
				num = 366694288U % num;
				this.092A492C(30404E);
				if (num < 712729490U)
				{
					return;
				}
			}
		}
		num = 2133928889U + num;
		Stack<6B147225.045263C1> stack = this.31162A15;
		num = 1326076266U / num;
		stack.Pop();
		num %= 1078989288U;
		do
		{
			num = (1681138621U & num);
			this.176B51CC.Push(new 6B147225.3FCC0B6B(this.249E65CD));
			num = (1949124811U ^ num);
			6B147225.770962F3 770962F = this.7D4C655B;
			num = (1838175232U | num);
			this.53F44057 = 770962F.3E5F028F();
			num <<= 19;
		}
		while (num <= 611676005U);
		num &= 401631956U;
		this.7D4C655B = null;
	}

	// Token: 0x060003D6 RID: 982 RVA: 0x00E74778 File Offset: 0x00E70B78
	private void 26507E93()
	{
		uint num = 1214209028U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num /= 2101048398U;
		int 43B2167F = 68EF01A.EDAECC1C();
		num = 1351766450U - num;
		Type type = this.04A156D1(43B2167F);
		num = 1598685270U - num;
		Type type2 = type;
		num = 1381656533U / num;
		num >>= 15;
		object 77241A = this.114C39DF();
		num = 1500855877U << (int)num;
		Type 174C3C = type2;
		num = (1660975759U ^ num);
		object 02FC5CA = this.6F327B1B(77241A, 174C3C).5049A7CC();
		num /= 1371421142U;
		6B147225.68EF01A4 7E485B = new 6B147225.3FCC0B6B(02FC5CA);
		num = (1351711303U ^ num);
		this.72160E89(7E485B);
	}

	// Token: 0x060003D7 RID: 983 RVA: 0x00E74808 File Offset: 0x00E70C08
	private void 6B7F3AD1()
	{
		uint num;
		Type 174C3C;
		do
		{
			num = 1990791505U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num >>= 12;
			int 43B2167F = 68EF01A.EDAECC1C();
			num = 2072974214U >> (int)num;
			Type type = this.04A156D1(43B2167F);
			num = (602947687U & num);
			174C3C = type;
			num = 1847087716U * num;
		}
		while (1484139189U + num == 0U);
		num += 2105502987U;
		num <<= 24;
		6B147225.68EF01A4 68EF01A2 = this.114C39DF();
		num /= 504773821U;
		this.72160E89(this.6F327B1B(68EF01A2.5049A7CC(), 174C3C));
	}

	// Token: 0x060003D8 RID: 984 RVA: 0x00E74890 File Offset: 0x00E70C90
	private void 65104E65()
	{
		uint num = 722761829U;
		if (num == 1227769897U)
		{
			goto IL_50;
		}
		Type type2;
		do
		{
			IL_11:
			num &= 292251160U;
			int 43B2167F = this.114C39DF().EDAECC1C();
			num /= 869422477U;
			Type type = this.04A156D1(43B2167F);
			num = (1536832605U | num);
			type2 = type;
			num /= 290814762U;
		}
		while (125725440U * num == 0U);
		object obj;
		for (;;)
		{
			IL_50:
			num ^= 1521516008U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = (1789215682U ^ num);
			6B147225.68EF01A4 68EF01A2 = 68EF01A;
			for (;;)
			{
				obj = 68EF01A2.5049A7CC();
				num = 1445281090U >> (int)num;
				if (num > 1895202458U)
				{
					goto IL_50;
				}
				for (;;)
				{
					bool flag = obj != null;
					num = 422117917U * num;
					if (!flag)
					{
						goto Block_1;
					}
					num -= 1710059316U;
					if (num < 752558204U)
					{
						goto IL_11;
					}
					if (type2.IsValueType)
					{
						break;
					}
					num = 1862627779U + num;
					Type type3 = type2;
					num |= 1752048821U;
					TypeCode typeCode = Type.GetTypeCode(type3);
					if (num >= 1884425947U)
					{
						TypeCode typeCode2 = typeCode;
						uint num2 = num ^ 4236132086U;
						num = 1862606169U - num;
						switch (typeCode2 - num2)
						{
						case 0:
							goto IL_188;
						case 1:
							goto IL_1B5;
						case 2:
							goto IL_205;
						case 3:
							goto IL_249;
						case 4:
							goto IL_263;
						case 5:
							goto IL_298;
						case 6:
							goto IL_2CE;
						case 7:
							goto IL_303;
						case 8:
							goto IL_353;
						case 9:
							goto IL_375;
						case 10:
							goto IL_3A3;
						case 11:
							num = 834224086U << (int)num;
							if (1382448728U >> (int)num != 0U)
							{
								goto Block_22;
							}
							continue;
						}
						goto Block_9;
					}
					goto IL_11;
				}
				if ((1805346696U ^ num) == 0U)
				{
					goto IL_11;
				}
				Type type4 = type2;
				Type type5 = obj.GetType();
				num = (115152887U & num);
				if (type4 != type5)
				{
					goto Block_5;
				}
				if (17958901U == num)
				{
					goto IL_11;
				}
				num = (2018916889U | num);
				6B147225.68EF01A4 7E485B = 68EF01A2;
				num &= 1545106729U;
				this.72160E89(7E485B);
				if (281042770U <= num)
				{
					return;
				}
			}
			Block_9:
			if (num <= 969362364U)
			{
				goto IL_11;
			}
			num = 478630926U + num;
			if (2099712105U <= num)
			{
				goto Block_23;
			}
			continue;
			IL_188:
			if (num != 1805275573U)
			{
				goto Block_11;
			}
			continue;
			IL_2CE:
			if (num != 993277657U)
			{
				goto Block_17;
			}
			continue;
			IL_3A3:
			num /= 1680609800U;
			6B147225.68EF01A4 7E485B2 = new 6B147225.1F5C5947((float)obj);
			num = 748041150U - num;
			this.72160E89(7E485B2);
			if (656226443U != num)
			{
				return;
			}
		}
		Block_1:
		throw new NullReferenceException();
		Block_5:
		throw new InvalidCastException();
		Block_11:
		object obj2 = obj;
		num = (727210068U | num);
		6B147225.68EF01A4 7E485B3 = new 6B147225.591C7B9A((bool)obj2);
		num = 1792684675U - num;
		this.72160E89(7E485B3);
		return;
		IL_1B5:
		num >>= 15;
		if ((num ^ 305010350U) == 0U)
		{
			goto IL_11;
		}
		num += 1574658045U;
		object obj3 = obj;
		num = (975533471U ^ num);
		char 46AF6C = (char)obj3;
		num /= 27280381U;
		this.72160E89(new 6B147225.7E683F22(46AF6C));
		if (255134051U >> (int)num == 0U)
		{
			return;
		}
		goto IL_11;
		IL_205:
		num += 173160508U;
		if ((num ^ 1065837180U) != 0U)
		{
			num &= 241529242U;
			object obj4 = obj;
			num = (1229669768U ^ num);
			sbyte 43EE79C = (sbyte)obj4;
			num = 1231569366U << (int)num;
			this.72160E89(new 6B147225.009559D5(43EE79C));
			return;
		}
		goto IL_11;
		IL_249:
		num ^= 804672297U;
		this.72160E89(new 6B147225.62930004((byte)obj));
		return;
		IL_263:
		num = 118106123U * num;
		if (num != 707404339U)
		{
			num = 1554258578U + num;
			short 24507AC = (short)obj;
			num &= 1738875627U;
			this.72160E89(new 6B147225.6F5B5DDB(24507AC));
			return;
		}
		goto IL_11;
		IL_298:
		num = 604272125U + num;
		ushort 07BA1ABE = (ushort)obj;
		num = (1929579116U & num);
		6B147225.68EF01A4 7E485B4 = new 6B147225.130817DC(07BA1ABE);
		num = 2021987870U - num;
		this.72160E89(7E485B4);
		if (num / 1509194458U != 0U)
		{
			return;
		}
		goto IL_11;
		Block_17:
		num <<= 26;
		int 5EEF = (int)obj;
		num <<= 21;
		6B147225.68EF01A4 7E485B5 = new 6B147225.1F462BA1(5EEF);
		num = 1641291763U * num;
		this.72160E89(7E485B5);
		return;
		IL_303:
		num <<= 15;
		if (num < 831259212U)
		{
			goto IL_11;
		}
		num = (1698956172U ^ num);
		object obj5 = obj;
		num %= 362962076U;
		uint <<EMPTY_NAME>> = (uint)obj5;
		num = (2063941344U & num);
		6B147225.68EF01A4 7E485B6 = new 6B147225.373B0CAE(<<EMPTY_NAME>>);
		num = (347110163U ^ num);
		this.72160E89(7E485B6);
		if (num != 564031753U)
		{
			return;
		}
		goto IL_11;
		IL_353:
		long 7B2365FA = (long)obj;
		num = 1204051507U / num;
		6B147225.68EF01A4 7E485B7 = new 6B147225.58E136FA(7B2365FA);
		num = 1209356283U - num;
		this.72160E89(7E485B7);
		return;
		IL_375:
		num = 1202079763U - num;
		6B147225.68EF01A4 7E485B8 = new 6B147225.61A633AA((ulong)obj);
		num |= 549479292U;
		this.72160E89(7E485B8);
		if (num % 443559844U != 0U)
		{
			return;
		}
		goto IL_11;
		Block_22:
		double 406C = (double)obj;
		num -= 1248882465U;
		6B147225.68EF01A4 7E485B9 = new 6B147225.60416C9D(406C);
		num ^= 1661631098U;
		this.72160E89(7E485B9);
		return;
		Block_23:
		throw new InvalidCastException();
	}

	// Token: 0x060003D9 RID: 985 RVA: 0x00E74CC8 File Offset: 0x00E710C8
	private void 081C3000()
	{
		uint num = 1273393397U;
		num = 1340826686U << (int)num;
		long num2 = this.5E457DAB;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num = 957502515U / num;
		ulong num3 = (ulong)68EF01A.786A7318();
		num %= 1702112493U;
		long num4 = (long)num3;
		num = 1791249141U - num;
		int 5EEF = Marshal.ReadInt32(new IntPtr(num2 + num4));
		num >>= 4;
		6B147225.68EF01A4 7E485B = new 6B147225.1F462BA1(5EEF);
		num = 440283753U / num;
		this.72160E89(7E485B);
	}

	// Token: 0x060003DA RID: 986 RVA: 0x00E74D3C File Offset: 0x00E7113C
	private void 56AC6F55()
	{
		uint num;
		int num2;
		ModuleHandle moduleHandle2;
		for (;;)
		{
			IL_00:
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1061966037U;
			num2 = 68EF01A.EDAECC1C();
			num %= 395338482U;
			int num5;
			if (1098405066U > num)
			{
				for (;;)
				{
					int num3 = num2;
					num <<= 10;
					int num4 = (int)(num - 2922103784U);
					num = (869432701U ^ num);
					num5 = num3 >> num4;
					num = 1126512314U << (int)num;
					uint num6 = (uint)num5;
					num = 1903173855U % num;
					if (num6 > num - 829432021U)
					{
						goto IL_CE;
					}
					if (1709322580U + num == 0U)
					{
						goto IL_00;
					}
					int num7 = num5;
					num >>= 5;
					uint num8 = num ^ 25919751U;
					num = 118895219U * num;
					switch (num7 - num8)
					{
					case 0:
					case 1:
						goto IL_199;
					case 2:
					case 4:
						goto IL_343;
					case 3:
						goto IL_138;
					case 5:
						goto IL_1F1;
					default:
					{
						num <<= 7;
						int num9 = num5;
						uint num10 = num ^ 2970671370U;
						num = 1991734944U / num;
						if (num9 != num10)
						{
							goto Block_3;
						}
						num *= 1691029927U;
						if (2040351943 << (int)num != 0)
						{
							goto Block_12;
						}
						break;
					}
					}
				}
				IL_138:
				num = 2131307817U - num;
				if ((304624590U ^ num) != 0U)
				{
					goto Block_9;
				}
				continue;
			}
			IL_CE:
			if (num == 548539615U)
			{
				continue;
			}
			int num11 = num5;
			uint num12 = num ^ 829432004U;
			num = (427782621U | num);
			num ^= 136138861U;
			if (num11 != num12)
			{
				if ((num & 2055895014U) == 0U)
				{
					goto IL_C9;
				}
				int num13 = num5;
				uint num14 = num ^ 828514713U;
				num /= 12862459U;
				num ^= 828514802U;
				if (num13 == num14)
				{
					goto IL_1F1;
				}
				if (473590103U / num == 0U)
				{
					goto Block_8;
				}
				continue;
			}
			IL_199:
			num *= 1197899687U;
			ModuleHandle moduleHandle = this.64D20DDA.ModuleHandle;
			num ^= 451221273U;
			moduleHandle2 = moduleHandle;
			num = 224551455U % num;
			RuntimeTypeHandle runtimeTypeHandle = moduleHandle2.ResolveTypeHandle(num2);
			num &= 1225525140U;
			object 21CD4FB = runtimeTypeHandle;
			num *= 125855882U;
			this.72160E89(new 6B147225.71755E30(21CD4FB));
			if (num != 488858964U)
			{
				return;
			}
			continue;
			IL_1F1:
			num += 1213160122U;
			moduleHandle2 = this.64D20DDA.ModuleHandle;
			int methodToken = num2;
			num ^= 1784614994U;
			RuntimeMethodHandle runtimeMethodHandle = moduleHandle2.ResolveMethodHandle(methodToken);
			num /= 1742277500U;
			object 21CD4FB2 = runtimeMethodHandle;
			num = 1271819000U * num;
			6B147225.68EF01A4 7E485B = new 6B147225.71755E30(21CD4FB2);
			num = 772498910U + num;
			this.72160E89(7E485B);
			if (1816674586U > num)
			{
				return;
			}
		}
		Block_3:
		num ^= 828514738U;
		IL_C9:
		goto IL_343;
		Block_8:
		num += 0U;
		goto IL_343;
		Block_9:
		num |= 987789651U;
		Module module = this.64D20DDA;
		num = (93656435U ^ num);
		ModuleHandle moduleHandle3 = module.ModuleHandle;
		num *= 1177314708U;
		moduleHandle2 = moduleHandle3;
		num /= 1684356340U;
		6B147225.68EF01A4 7E485B2 = new 6B147225.71755E30(moduleHandle2.ResolveFieldHandle(num2));
		num >>= 27;
		this.72160E89(7E485B2);
		return;
		Block_12:
		try
		{
			num |= 78586277U;
			num = 1739458477U >> (int)num;
			Module module2 = this.64D20DDA;
			num ^= 1008271578U;
			moduleHandle2 = module2.ModuleHandle;
			num |= 1321105024U;
			int fieldToken = num2;
			num = 623055260U / num;
			RuntimeFieldHandle runtimeFieldHandle = moduleHandle2.ResolveFieldHandle(fieldToken);
			num <<= 12;
			object 21CD4FB3 = runtimeFieldHandle;
			num += 1743735435U;
			6B147225.68EF01A4 7E485B3 = new 6B147225.71755E30(21CD4FB3);
			num += 334315105U;
			this.72160E89(7E485B3);
			return;
		}
		catch
		{
			num = 576597995U;
			if ((1163150794U ^ num) != 0U)
			{
				do
				{
					num = (1565397016U & num);
					moduleHandle2 = this.64D20DDA.ModuleHandle;
					num |= 1564738783U;
					int methodToken2 = num2;
					num >>= 27;
					RuntimeMethodHandle runtimeMethodHandle2 = moduleHandle2.ResolveMethodHandle(methodToken2);
					num >>= 29;
					object 21CD4FB4 = runtimeMethodHandle2;
					num = (1315644725U & num);
					this.72160E89(new 6B147225.71755E30(21CD4FB4));
				}
				while (1960720955U + num == 0U);
			}
			return;
		}
		IL_343:
		throw new InvalidOperationException();
	}

	// Token: 0x060003DB RID: 987 RVA: 0x00E750B0 File Offset: 0x00E714B0
	private void 084039F9()
	{
		uint num = 468857494U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num = (1225874461U ^ num);
		object obj = 68EF01A.5049A7CC();
		num %= 307955156U;
		Exception ex = obj as Exception;
		if (ex == null)
		{
			throw new ArgumentException();
		}
		throw ex;
	}

	// Token: 0x060003DC RID: 988 RVA: 0x00E750F0 File Offset: 0x00E714F0
	private void 7FD16BED()
	{
		uint num = 833059824U;
		if (num > 202727682U)
		{
			num = 1541497979U / num;
			bool flag = this.249E65CD != null;
			num |= 1724397258U;
			if (flag)
			{
				num ^= 2024620585U;
				num |= 795618531U;
				throw this.249E65CD;
			}
		}
		throw new InvalidOperationException();
	}

	// Token: 0x060003DD RID: 989 RVA: 0x00E75148 File Offset: 0x00E71548
	private void 429E31B1()
	{
		uint num = 1757023268U;
		Type 5A59670C;
		do
		{
			num = 1624588612U - num;
			num -= 223357558U;
			int 43B2167F = this.114C39DF().EDAECC1C();
			num = 2037193399U << (int)num;
			Type type = this.04A156D1(43B2167F);
			num <<= 15;
			5A59670C = type;
		}
		while (num == 1362914020U);
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			do
			{
				6B147225.68EF01A4 68EF01A2 = 68EF01A;
				num &= 1818518338U;
				bool flag = this.3662770D(68EF01A2.5049A7CC(), 5A59670C);
				num = 167449162U << (int)num;
				if (!flag)
				{
					goto Block_1;
				}
			}
			while (num >= 1807679599U);
			this.72160E89(68EF01A);
			if ((num ^ 825710682U) != 0U)
			{
				return;
			}
		}
		Block_1:
		num = (1125405200U ^ num);
		throw new InvalidCastException();
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00E751FC File Offset: 0x00E715FC
	private void 7E752FE0()
	{
		uint num = 1434080021U;
		for (;;)
		{
			num |= 1316767465U;
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			num = 1659527187U * num;
			int 43B2167F = 68EF01A.EDAECC1C();
			num *= 1365124147U;
			Type 5A59670C = this.04A156D1(43B2167F);
			num *= 934165728U;
			6B147225.68EF01A4 68EF01A3;
			if (num != 126492398U)
			{
				6B147225.68EF01A4 68EF01A2 = this.114C39DF();
				num ^= 578453449U;
				68EF01A3 = 68EF01A2;
				if (num == 942822011U)
				{
					continue;
				}
			}
			object 1C8D241F = 68EF01A3.5049A7CC();
			num = 1746750847U - num;
			if (!this.3662770D(1C8D241F, 5A59670C))
			{
				goto IL_77;
			}
			IL_94:
			num = 1372920627U >> (int)num;
			if (num < 155985949U)
			{
				num = 1995712653U * num;
				6B147225.68EF01A4 7E485B = 68EF01A3;
				num &= 1335626889U;
				this.72160E89(7E485B);
				if ((1622507015U & num) != 0U)
				{
					break;
				}
				continue;
			}
			IL_77:
			object 02FC5CA = null;
			num = 1347684566U << (int)num;
			68EF01A3 = new 6B147225.3FCC0B6B(02FC5CA);
			num += 641927638U;
			goto IL_94;
		}
	}

	// Token: 0x060003DF RID: 991 RVA: 0x00E752DC File Offset: 0x00E716DC
	private void 636B0497()
	{
		uint num;
		for (;;)
		{
			6B147225.68EF01A4 68EF01A = this.114C39DF();
			for (;;)
			{
				6B147225.68EF01A4 68EF01A2 = 68EF01A;
				num = 2019245372U;
				if (!(68EF01A2.5049A7CC() is IConvertible))
				{
					68EF01A = new 6B147225.60416C9D(double.NaN);
					num += 2483882695U;
					goto IL_96;
				}
				num += 336474311U;
				if (1582115572U % num == 0U)
				{
					goto IL_5E;
				}
				IL_31:
				6B147225.68EF01A4 68EF01A3 = 68EF01A;
				num = (2113816755U & num);
				double num2 = 68EF01A3.8CC4ACA1();
				num %= 1831891616U;
				double d = num2;
				if (double.IsNaN(d))
				{
					goto IL_71;
				}
				if (num <= 1263079896U)
				{
					goto IL_5E;
				}
				continue;
				IL_96:
				num <<= 17;
				if (73097187U == num)
				{
					break;
				}
				this.72160E89(68EF01A);
				if (1720332333 << (int)num != 0)
				{
					return;
				}
				goto IL_31;
				IL_5E:
				if (double.IsInfinity(d))
				{
					goto Block_2;
				}
				goto IL_96;
			}
		}
		Block_2:
		num += 0U;
		IL_71:
		num = 374625907U + num;
		throw new OverflowException();
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00E753AC File Offset: 0x00E717AC
	private unsafe void 7416593F()
	{
		uint num = 1085935398U;
		6B147225.68EF01A4 68EF01A = this.114C39DF();
		num = 775189921U / num;
		IntPtr cb = 68EF01A.B74C1556();
		num &= 143072850U;
		IntPtr intPtr = Marshal.AllocHGlobal(cb);
		num = (111697260U ^ num);
		IntPtr item = intPtr;
		if (num <= 1832018416U)
		{
			List<IntPtr> list = this.227B4861;
			num = 1798639833U >> (int)num;
			list.Add(item);
			num ^= 175793202U;
		}
		void* ptr = item.ToPointer();
		RuntimeTypeHandle handle = typeof(void*).TypeHandle;
		num <<= 17;
		Type typeFromHandle = Type.GetTypeFromHandle(handle);
		num &= 161693214U;
		object 02FC5CA = Pointer.Box(ptr, typeFromHandle);
		num = 1500937421U / num;
		6B147225.68EF01A4 7E485B = new 6B147225.3FCC0B6B(02FC5CA);
		num >>= 27;
		this.72160E89(7E485B);
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x00E75458 File Offset: 0x00E71858
	private void 48C32F6D()
	{
		uint num = 1153570087U;
		num = 333135920U << (int)num;
		List<IntPtr>.Enumerator enumerator = this.227B4861.GetEnumerator();
		num = (1193244715U | num);
		List<IntPtr>.Enumerator enumerator2 = enumerator;
		try
		{
			for (;;)
			{
				for (;;)
				{
					num = 1547073108U + num;
					if (363340740U % num != 0U)
					{
						num += 2072995220U;
						if (!enumerator2.MoveNext())
						{
							if (1643478617U != num)
							{
								goto Block_4;
							}
						}
						else
						{
							Marshal.FreeHGlobal(enumerator2.Current);
							num = 4022302763U;
						}
					}
				}
			}
			Block_4:;
		}
		finally
		{
			do
			{
				num = 1829328188U;
				((IDisposable)enumerator2).Dispose();
			}
			while (784344983U - num == 0U);
		}
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00E75518 File Offset: 0x00E71918
	public object 654329F0(object[] 6F8F1E6E, int 0B4E06E9)
	{
		uint num = 667712887U;
		this.53F44057 = 0B4E06E9;
		num /= 688087669U;
		num %= 1805262143U;
		this.72160E89(new 6B147225.69732A42(6F8F1E6E));
		object result;
		try
		{
			for (;;)
			{
				num = 1416831729U;
				try
				{
					if (num >= 1025800725U)
					{
						Dictionary<uint, 6B147225.62147124> dictionary = this.01546E90;
						num = (1098349264U ^ num);
						uint key = (uint)this.399E5675();
						num = 2453577U * num;
						dictionary[key]();
						num <<= 30;
					}
					while (this.53F44057 == 0)
					{
						if (1674669662U > num)
						{
							goto IL_B0;
						}
					}
					if (num / 2015242011U == 0U)
					{
						continue;
					}
				}
				catch (Exception ex)
				{
					num = 397701759U;
					Exception 30404E = ex;
					num = 220215293U / num;
					this.092A492C(30404E);
					continue;
				}
				break;
			}
			IL_B0:
			num = 1949775120U;
			num = (143149997U | num);
			object obj = this.114C39DF().5049A7CC();
			num <<= 25;
			result = obj;
		}
		finally
		{
			this.48C32F6D();
		}
		return result;
	}

	// Token: 0x040002D8 RID: 728
	private readonly Dictionary<uint, 6B147225.62147124> 01546E90;

	// Token: 0x040002D9 RID: 729
	private readonly Module 64D20DDA;

	// Token: 0x040002DA RID: 730
	private readonly long 5E457DAB;

	// Token: 0x040002DB RID: 731
	private int 53F44057;

	// Token: 0x040002DC RID: 732
	private Type 47653FC8;

	// Token: 0x040002DD RID: 733
	private Stack<6B147225.14B354D4> 176B51CC;

	// Token: 0x040002DE RID: 734
	private static readonly Dictionary<int, object> 13BF1BD3 = new Dictionary<int, object>();

	// Token: 0x040002DF RID: 735
	private static readonly Dictionary<MethodBase, DynamicMethod> 764039AB = new Dictionary<MethodBase, DynamicMethod>();

	// Token: 0x040002E0 RID: 736
	private List<6B147225.68EF01A4> 374C66F2;

	// Token: 0x040002E1 RID: 737
	private List<6B147225.045263C1> 1DD42960;

	// Token: 0x040002E2 RID: 738
	private Stack<6B147225.045263C1> 31162A15;

	// Token: 0x040002E3 RID: 739
	private Stack<int> 21241E86;

	// Token: 0x040002E4 RID: 740
	private Exception 249E65CD;

	// Token: 0x040002E5 RID: 741
	private 6B147225.770962F3 7D4C655B;

	// Token: 0x040002E6 RID: 742
	private List<IntPtr> 227B4861;

	// Token: 0x02000050 RID: 80
	private abstract class 68EF01A4
	{
		// Token: 0x06000407 RID: 1031
		public abstract 6B147225.68EF01A4 2EEBA499();

		// Token: 0x06000408 RID: 1032
		public abstract object 5049A7CC();

		// Token: 0x06000409 RID: 1033
		public abstract void 62B618BD(object 7FCE2AA1);

		// Token: 0x0600040A RID: 1034 RVA: 0x00E75A28 File Offset: 0x00E71E28
		public virtual bool 684ED4C6()
		{
			uint num = 66208367U;
			return (num ^ 66208367U) != 0U;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00E75A44 File Offset: 0x00E71E44
		public virtual 6B147225.14B354D4 6991E7AF()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00E75A58 File Offset: 0x00E71E58
		public virtual 6B147225.68EF01A4 0C5BC4A1()
		{
			return this;
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00E75A6C File Offset: 0x00E71E6C
		public virtual Type 0B2A827C()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00E75A84 File Offset: 0x00E71E84
		public virtual TypeCode 39440F35()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00E75A98 File Offset: 0x00E71E98
		public virtual bool 93CE0566()
		{
			return Convert.ToBoolean(this.5049A7CC());
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00E75AB8 File Offset: 0x00E71EB8
		public virtual sbyte 060AA47D()
		{
			return Convert.ToSByte(this.5049A7CC());
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00E75AD0 File Offset: 0x00E71ED0
		public virtual short E915D835()
		{
			uint num = 17456137U;
			num >>= 25;
			return Convert.ToInt16(this.5049A7CC());
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00E75AF8 File Offset: 0x00E71EF8
		public virtual int EDAECC1C()
		{
			uint num = 1044404935U;
			object value = this.5049A7CC();
			num <<= 2;
			return Convert.ToInt32(value);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00E75B20 File Offset: 0x00E71F20
		public virtual long DA78F42D()
		{
			uint num = 831141243U;
			num = 1522090586U + num;
			object value = this.5049A7CC();
			num &= 1981428951U;
			return Convert.ToInt64(value);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00E75B50 File Offset: 0x00E71F50
		public virtual char F3CAAB92()
		{
			return Convert.ToChar(this.5049A7CC());
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x00E75B68 File Offset: 0x00E71F68
		public virtual byte 4D994718()
		{
			return Convert.ToByte(this.5049A7CC());
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x00E75B88 File Offset: 0x00E71F88
		public virtual ushort D20A0A8F()
		{
			uint num = 1603813842U;
			num = (856948979U & num);
			object value = this.5049A7CC();
			num <<= 30;
			return Convert.ToUInt16(value);
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00E75BB8 File Offset: 0x00E71FB8
		public virtual uint 786A7318()
		{
			uint num = 217012591U;
			object value = this.5049A7CC();
			num = 180582242U * num;
			return Convert.ToUInt32(value);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00E75BE0 File Offset: 0x00E71FE0
		public virtual ulong 5C835FEF()
		{
			uint num = 1091075339U;
			num = 418584350U / num;
			object value = this.5049A7CC();
			num ^= 1721138294U;
			return Convert.ToUInt64(value);
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00E75C10 File Offset: 0x00E72010
		public virtual float B55103C5()
		{
			uint num = 967858086U;
			object value = this.5049A7CC();
			num = (335177993U | num);
			return Convert.ToSingle(value);
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x00E75C38 File Offset: 0x00E72038
		public virtual double 8CC4ACA1()
		{
			return Convert.ToDouble(this.5049A7CC());
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00E75C50 File Offset: 0x00E72050
		public override string ToString()
		{
			uint num = 1057847783U;
			object obj = this.5049A7CC();
			num -= 434272305U;
			if (obj == null)
			{
				return null;
			}
			return Convert.ToString(obj);
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x00E75C80 File Offset: 0x00E72080
		public virtual IntPtr B74C1556()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00E75C94 File Offset: 0x00E72094
		public virtual UIntPtr 2B2A13B3()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00E75CA8 File Offset: 0x00E720A8
		public unsafe virtual void* 477D7F8C()
		{
			throw new InvalidOperationException();
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x00E75CC0 File Offset: 0x00E720C0
		public virtual object CA964614(Type 7FA16FE9, bool 422A4F49)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00E75CD4 File Offset: 0x00E720D4
		protected 68EF01A4()
		{
			uint num = 1997748653U;
			do
			{
				base..ctor();
			}
			while (num <= 1890193412U);
		}
	}

	// Token: 0x02000051 RID: 81
	private abstract class 14B354D4 : 6B147225.68EF01A4
	{
		// Token: 0x06000421 RID: 1057 RVA: 0x00E75CF8 File Offset: 0x00E720F8
		public override 6B147225.14B354D4 6991E7AF()
		{
			return this;
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00E75D08 File Offset: 0x00E72108
		public override TypeCode 39440F35()
		{
			return TypeCode.Empty;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00E75D18 File Offset: 0x00E72118
		protected 14B354D4()
		{
			uint num;
			do
			{
				num = 1031163669U;
				base..ctor();
			}
			while (1006722932U >= num);
		}
	}

	// Token: 0x02000052 RID: 82
	private sealed class 1F462BA1 : 6B147225.14B354D4
	{
		// Token: 0x06000424 RID: 1060 RVA: 0x00E75D3C File Offset: 0x00E7213C
		public 1F462BA1(int 5EEF2997)
		{
			uint num = 85096263U;
			if (538666807U >= num)
			{
				base..ctor();
				num ^= 188023687U;
				num = 496308770U / num;
				this.73A83794 = 5EEF2997;
			}
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00E75D78 File Offset: 0x00E72178
		public override Type 0B2A827C()
		{
			return typeof(int);
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00E75D98 File Offset: 0x00E72198
		public override TypeCode 39440F35()
		{
			uint num = 385707695U;
			return (TypeCode)(num ^ 385707686U);
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x00E75DB4 File Offset: 0x00E721B4
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.1F462BA1(this.73A83794);
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x00E75DCC File Offset: 0x00E721CC
		public override object 5049A7CC()
		{
			return this.73A83794;
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00E75DEC File Offset: 0x00E721EC
		public override void 62B618BD(object 12DB5687)
		{
			uint num = 1532968884U;
			if ((1496019628U & num) != 0U)
			{
				num |= 627272893U;
				num ^= 1289515969U;
				int num2 = Convert.ToInt32(12DB5687);
				num &= 2116617247U;
				this.73A83794 = num2;
			}
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x00E75E30 File Offset: 0x00E72230
		public override bool 93CE0566()
		{
			uint num = 1457410327U;
			uint num2 = (uint)this.73A83794;
			num <<= 22;
			return num2 > num - 1170210816U;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00E75E5C File Offset: 0x00E7225C
		public override sbyte 060AA47D()
		{
			uint num = 31683644U;
			num /= 1008209105U;
			return (sbyte)this.73A83794;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00E75E80 File Offset: 0x00E72280
		public override short E915D835()
		{
			uint num = 776227038U;
			num >>= 29;
			short num2 = (short)this.73A83794;
			num %= 1732264940U;
			return num2;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00E75EAC File Offset: 0x00E722AC
		public override int EDAECC1C()
		{
			return this.73A83794;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00E75EC8 File Offset: 0x00E722C8
		public override long DA78F42D()
		{
			uint num = 1702955089U;
			long num2 = (long)this.73A83794;
			num >>= 18;
			return num2;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00E75EEC File Offset: 0x00E722EC
		public override char F3CAAB92()
		{
			uint num = 1573878833U;
			num |= 1971543634U;
			char c = (char)this.73A83794;
			num = 27333030U << (int)num;
			return c;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00E75F1C File Offset: 0x00E7231C
		public override byte 4D994718()
		{
			return (byte)this.73A83794;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00E75F30 File Offset: 0x00E72330
		public override ushort D20A0A8F()
		{
			return (ushort)this.73A83794;
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x00E75F4C File Offset: 0x00E7234C
		public override uint 786A7318()
		{
			return (uint)this.73A83794;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00E75F68 File Offset: 0x00E72368
		public override ulong 5C835FEF()
		{
			return (ulong)this.73A83794;
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00E75F84 File Offset: 0x00E72384
		public override float B55103C5()
		{
			return (float)this.73A83794;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00E75FA0 File Offset: 0x00E723A0
		public override double 8CC4ACA1()
		{
			return (double)this.73A83794;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00E75FBC File Offset: 0x00E723BC
		public override IntPtr B74C1556()
		{
			return new IntPtr(this.73A83794);
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x00E75FD4 File Offset: 0x00E723D4
		public override UIntPtr 2B2A13B3()
		{
			return new UIntPtr((uint)this.73A83794);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00E75FF4 File Offset: 0x00E723F4
		public override 6B147225.68EF01A4 0C5BC4A1()
		{
			return new 6B147225.373B0CAE((uint)this.73A83794);
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x00E7600C File Offset: 0x00E7240C
		public override object CA964614(Type 3B8A3121, bool 046C4889)
		{
			uint num = 873333907U;
			do
			{
				if (3B8A3121 != typeof(IntPtr))
				{
					num <<= 20;
					if (3B8A3121 == typeof(UIntPtr))
					{
						goto Block_5;
					}
					TypeCode typeCode = Type.GetTypeCode(3B8A3121);
					if (74601915U > num)
					{
						goto IL_3B;
					}
					uint num2 = (uint)typeCode;
					num = 766849874U * num;
					uint num3 = num2 - (num - 23068667U);
					num <<= 29;
					switch (num3)
					{
					case 0:
						num = 399340549U + num;
						if (num >> 27 == 0U)
						{
							goto IL_DF;
						}
						if (!046C4889)
						{
							goto Block_10;
						}
						if (38026451U * num != 0U)
						{
							goto Block_11;
						}
						goto IL_16;
					case 1:
						goto IL_359;
					case 2:
						num = (228866137U & num);
						if (num < 152125292U)
						{
							goto Block_12;
						}
						continue;
					case 3:
						num = 1927905038U - num;
						if (!046C4889)
						{
							if ((num ^ 940127696U) != 0U)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							num |= 1021081493U;
							if ((num ^ 909531864U) != 0U)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					case 4:
						num /= 413026230U;
						num = (696005436U | num);
						if (!046C4889)
						{
							goto Block_14;
						}
						if (991720328U >= num)
						{
							goto Block_15;
						}
						goto IL_16;
					case 5:
						goto IL_421;
					case 6:
						num *= 1063270466U;
						num -= 102386509U;
						if (!046C4889)
						{
							goto Block_16;
						}
						num = 896663735U - num;
						if (1942566884U >> (int)num != 0U)
						{
							goto Block_18;
						}
						goto IL_16;
					case 7:
						goto IL_45D;
					case 8:
						break;
					case 9:
						num = (1461546904U ^ num);
						if (!046C4889)
						{
							goto Block_25;
						}
						num = 931732890U - num;
						if (419322409U <= num)
						{
							goto Block_26;
						}
						goto IL_16;
					default:
						num ^= 0U;
						break;
					}
					num = 12780691U << (int)num;
					if (444990204U >= num)
					{
						goto Block_27;
					}
					continue;
				}
				IL_16:
				int size = IntPtr.Size;
				uint num4 = num ^ 873333911U;
				num |= 812939075U;
				if (size == num4)
				{
					if (2065775643U * num == 0U)
					{
						continue;
					}
				}
				else
				{
					num ^= 724729053U;
					if (!046C4889)
					{
						if (162613109U <= num)
						{
							goto IL_DF;
						}
					}
					else
					{
						if (2090669203U / num != 0U)
						{
							goto Block_4;
						}
						continue;
					}
				}
				IL_3B:
				num = 1290471874U + num;
				if (046C4889)
				{
					goto IL_6F;
				}
				num = (1349780023U | num);
			}
			while (1557858232U == num);
			IL_5C:
			num += 170400198U;
			int value = this.73A83794;
			goto IL_A5;
			IL_6F:
			num = 1451761928U % num;
			num = 1350325199U << (int)num;
			uint num5 = (uint)this.73A83794;
			num *= 1235696274U;
			int num6 = (int)num5;
			num %= 1596721263U;
			value = num6;
			num += 2890637403U;
			IL_A5:
			num = 678889843U >> (int)num;
			IntPtr intPtr = new IntPtr(value);
			num = (171065390U ^ num);
			return intPtr;
			IL_DF:
			long num7 = (long)this.73A83794;
			num <<= 14;
			long value2 = num7;
			goto IL_10E;
			Block_4:
			value2 = (long)((ulong)this.73A83794);
			num += 3816256754U;
			IL_10E:
			num -= 860190962U;
			return new IntPtr(value2);
			Block_5:
			uint value3;
			if (!046C4889)
			{
				num = (328486886U ^ num);
				uint num8 = (uint)this.73A83794;
				num = 523518939U % num;
				value3 = num8;
			}
			else
			{
				num -= 98179629U;
				num += 291059977U;
				value3 = (uint)this.73A83794;
				num ^= 1268473095U;
			}
			return new UIntPtr(value3);
			Block_10:
			num *= 1977755628U;
			sbyte b = (sbyte)this.73A83794;
			num = (152907172U ^ num);
			sbyte b2 = b;
			goto IL_24B;
			Block_11:
			uint num9 = (uint)this.73A83794;
			num = (1329948964U & num);
			sbyte b3 = (sbyte)num9;
			num += 846089530U;
			b2 = b3;
			num ^= 3285399302U;
			IL_24B:
			num = 112672494U >> (int)num;
			return b2;
			Block_12:
			checked
			{
				short num10;
				if (!046C4889)
				{
					num10 = (short)this.73A83794;
				}
				else
				{
					short num11 = (short)((uint)this.73A83794);
					num = (43006325U ^ num);
					num10 = num11;
					num ^= 43006325U;
				}
				return num10;
				Block_14:
				int num12 = this.73A83794;
				goto IL_2DE;
				Block_15:
				num12 = (int)((uint)this.73A83794);
				num ^= 0U;
				IL_2DE:
				return num12;
				Block_16:;
			}
			num += 977303642U;
			long num14;
			if ((1076235095U ^ num) != 0U)
			{
				long num13 = (long)this.73A83794;
				num = 950363224U - num;
				num14 = num13;
				goto IL_353;
			}
			goto IL_5C;
			Block_18:
			num -= 340078059U;
			num14 = (long)((ulong)this.73A83794);
			num += 3711441202U;
			IL_353:
			return num14;
			IL_359:
			num = (984165504U & num);
			byte b5;
			if (!046C4889)
			{
				num = (1756318680U & num);
				byte b4 = (byte)this.73A83794;
				num &= 290067902U;
				b5 = b4;
			}
			else
			{
				num %= 1586116237U;
				num = 1901070721U + num;
				byte b6 = (byte)(checked((uint)this.73A83794));
				num = 1406931492U + num;
				b5 = b6;
				num += 986965083U;
			}
			return b5;
			Block_21:
			num |= 801711147U;
			ushort num15 = (ushort)this.73A83794;
			num >>= 5;
			ushort num16 = num15;
			goto IL_413;
			Block_22:
			num = (1490708343U & num);
			num16 = checked((ushort)((uint)this.73A83794));
			num += 2871452898U;
			IL_413:
			num = 1316437009U % num;
			return num16;
			IL_421:
			num = 1620779389U << (int)num;
			uint num17;
			if (!046C4889)
			{
				num17 = checked((uint)this.73A83794);
			}
			else
			{
				num = 318138504U % num;
				num17 = (uint)this.73A83794;
				num += 1302640885U;
			}
			return num17;
			IL_45D:
			num *= 1308366026U;
			num *= 207051913U;
			uint num19;
			if (!046C4889)
			{
				num = 1455776485U >> (int)num;
				num ^= 36250032U;
				uint num18 = (uint)this.73A83794;
				num -= 1293755810U;
				num19 = num18;
			}
			else
			{
				num19 = (uint)this.73A83794;
				num += 131014067U;
			}
			num = 223366507U / num;
			return num19;
			Block_25:
			num = (729288659U | num);
			double num20 = (double)this.73A83794;
			goto IL_514;
			Block_26:
			int num21 = this.73A83794;
			num = 1986292679U >> (int)num;
			double num22 = num21;
			num >>= 6;
			num20 = num22;
			num += 2131168112U;
			IL_514:
			num = 190404521U << (int)num;
			return num20;
			Block_27:
			throw new ArgumentException();
		}

		// Token: 0x040002FD RID: 765
		private int 73A83794;
	}

	// Token: 0x02000053 RID: 83
	private sealed class 58E136FA : 6B147225.14B354D4
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00E76560 File Offset: 0x00E72960
		public 58E136FA(long 7B2365FA)
		{
			uint num = 1729965528U;
			base..ctor();
			num = 913708810U / num;
			this.46631332 = 7B2365FA;
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00E76588 File Offset: 0x00E72988
		public override Type 0B2A827C()
		{
			return typeof(long);
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00E765A0 File Offset: 0x00E729A0
		public override TypeCode 39440F35()
		{
			return TypeCode.Int64;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00E765B0 File Offset: 0x00E729B0
		public override 6B147225.68EF01A4 0C5BC4A1()
		{
			return new 6B147225.61A633AA((ulong)this.46631332);
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00E765D0 File Offset: 0x00E729D0
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 2033733825U;
			num = 896154537U >> (int)num;
			long 7B2365FA = this.46631332;
			num /= 2035638742U;
			return new 6B147225.58E136FA(7B2365FA);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00E76604 File Offset: 0x00E72A04
		public override object 5049A7CC()
		{
			uint num = 1485064355U;
			long num2 = this.46631332;
			num *= 1760437510U;
			return num2;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00E7662C File Offset: 0x00E72A2C
		public override void 62B618BD(object 47722545)
		{
			this.46631332 = Convert.ToInt64(47722545);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00E76648 File Offset: 0x00E72A48
		public override bool 93CE0566()
		{
			uint num = 745548372U;
			num = (263920807U | num);
			long num2 = this.46631332;
			num = 1028798666U >> (int)num;
			long num3 = (long)(num - 122U);
			num <<= 22;
			return num2 > num3;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00E7668C File Offset: 0x00E72A8C
		public override char F3CAAB92()
		{
			return (char)this.46631332;
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00E766A8 File Offset: 0x00E72AA8
		public override byte 4D994718()
		{
			uint num = 155992690U;
			byte b = (byte)this.46631332;
			num <<= 17;
			return b;
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00E766CC File Offset: 0x00E72ACC
		public override sbyte 060AA47D()
		{
			return (sbyte)this.46631332;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00E766E8 File Offset: 0x00E72AE8
		public override short E915D835()
		{
			uint num = 49377406U;
			short num2 = (short)this.46631332;
			num &= 424482264U;
			return num2;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00E7670C File Offset: 0x00E72B0C
		public override int EDAECC1C()
		{
			return (int)this.46631332;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00E76720 File Offset: 0x00E72B20
		public override long DA78F42D()
		{
			uint num = 437870561U;
			num += 1157048010U;
			return this.46631332;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00E76744 File Offset: 0x00E72B44
		public override ushort D20A0A8F()
		{
			return (ushort)this.46631332;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00E76760 File Offset: 0x00E72B60
		public override uint 786A7318()
		{
			return (uint)this.46631332;
		}

		// Token: 0x0600044A RID: 1098 RVA: 0x00E7677C File Offset: 0x00E72B7C
		public override ulong 5C835FEF()
		{
			return (ulong)this.46631332;
		}

		// Token: 0x0600044B RID: 1099 RVA: 0x00E76798 File Offset: 0x00E72B98
		public override float B55103C5()
		{
			uint num = 2022783503U;
			num |= 1678784032U;
			return (float)this.46631332;
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00E767BC File Offset: 0x00E72BBC
		public override double 8CC4ACA1()
		{
			return (double)this.46631332;
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00E767D0 File Offset: 0x00E72BD0
		public override IntPtr B74C1556()
		{
			uint num;
			do
			{
				int size = IntPtr.Size;
				num = 672808226U;
				uint num2 = num ^ 672808230U;
				num <<= 20;
				if (size == num2)
				{
					goto IL_46;
				}
				num <<= 13;
			}
			while (2055806614U + num == 0U);
			IL_33:
			num = 316355865U * num;
			long value = this.46631332;
			goto IL_7F;
			IL_46:
			num *= 635766079U;
			if (2049521834U == num)
			{
				goto IL_33;
			}
			int num3 = (int)this.46631332;
			num = 1130496222U << (int)num;
			long num4 = (long)num3;
			num = (205016456U ^ num);
			value = num4;
			num += 2963649194U;
			IL_7F:
			num = 26948830U + num;
			return new IntPtr(value);
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00E7686C File Offset: 0x00E72C6C
		public override UIntPtr 2B2A13B3()
		{
			uint size = (uint)UIntPtr.Size;
			uint num = 1105481789U;
			ulong value;
			if (size != num + 3189485511U)
			{
				num ^= 98449530U;
				num = 141037345U * num;
				value = (ulong)this.46631332;
			}
			else
			{
				num = 1432235230U >> (int)num;
				value = (ulong)((uint)this.46631332);
				num ^= 3430652453U;
			}
			return new UIntPtr(value);
		}

		// Token: 0x0600044F RID: 1103 RVA: 0x00E768D0 File Offset: 0x00E72CD0
		public override object CA964614(Type 0C887E34, bool 75C62082)
		{
			uint num = 351081005U;
			do
			{
				num <<= 10;
				if (0C887E34 == typeof(IntPtr))
				{
					num = (996802780U & num);
					if (num >> 6 == 0U)
					{
						goto IL_65;
					}
				}
				else
				{
					num = 2024700440U * num;
					if (num < 84150358U)
					{
						continue;
					}
					if (0C887E34 == typeof(UIntPtr))
					{
						goto Block_4;
					}
					TypeCode typeCode = Type.GetTypeCode(0C887E34);
					uint num2 = (uint)typeCode;
					num = 1539579383U + num;
					uint num3 = num2 - (num - 1079836146U);
					num = 1972451170U + num;
					switch (num3)
					{
					case 0:
						goto IL_189;
					case 1:
						num = 948991520U + num;
						if (!75C62082)
						{
							num -= 2047370394U;
							if (869490804U <= num)
							{
								goto Block_16;
							}
						}
						else
						{
							if (num > 154420310U)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 2:
						num = 1061122828U >> (int)num;
						if (766399044U / num != 0U)
						{
							goto Block_9;
						}
						continue;
					case 3:
						if (582819438U / num != 0U)
						{
							continue;
						}
						num = (1849428459U & num);
						if (75C62082)
						{
							goto IL_396;
						}
						if (num != 1284706404U)
						{
							goto Block_20;
						}
						continue;
					case 4:
						num += 435181351U;
						num &= 968653200U;
						if (75C62082)
						{
							goto IL_277;
						}
						if (num / 404043356U == 0U)
						{
							goto Block_12;
						}
						continue;
					case 5:
						num = 854533214U % num;
						if (num + 248070385U != 0U)
						{
							goto Block_22;
						}
						continue;
					case 6:
						num /= 1570463271U;
						if (75C62082)
						{
							goto IL_2C1;
						}
						if (num != 1019218053U)
						{
							goto Block_14;
						}
						continue;
					case 7:
						num = 945232786U / num;
						if (num >= 1234655740U)
						{
							continue;
						}
						num %= 650074987U;
						if (!75C62082)
						{
							goto Block_25;
						}
						if (num != 157292699U)
						{
							goto Block_26;
						}
						continue;
					case 8:
						goto IL_51D;
					case 9:
						num = (1819496425U | num);
						if (num <= 1620537825U)
						{
							goto IL_65;
						}
						num = (1097280402U ^ num);
						if (!75C62082)
						{
							if (1736061939U != num)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							if (1060797197U < num)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					default:
						if (num != 1579900175U)
						{
							goto Block_7;
						}
						break;
					}
				}
				if (75C62082)
				{
					goto IL_65;
				}
				num *= 110101956U;
			}
			while (2022848622 << (int)num == 0);
			IL_52:
			num &= 1650878890U;
			long value = this.46631332;
			goto IL_9B;
			IL_65:
			num = (42809223U | num);
			num += 692546739U;
			ulong num4 = (ulong)this.46631332;
			num ^= 807145844U;
			long num5 = (long)num4;
			num = 2077698537U >> (int)num;
			value = num5;
			num ^= 1109520220U;
			IL_9B:
			num <<= 9;
			return new IntPtr(value);
			Block_4:
			num = (567245834U ^ num);
			ulong value2;
			if (!75C62082)
			{
				num += 361446326U;
				value2 = checked((ulong)this.46631332);
			}
			else
			{
				num -= 734468845U;
				num %= 602824578U;
				value2 = (ulong)this.46631332;
				num ^= 3543520469U;
			}
			UIntPtr uintPtr = new UIntPtr(value2);
			num ^= 898194808U;
			return uintPtr;
			Block_7:
			num ^= 0U;
			goto IL_51D;
			IL_189:
			num = 104669357U / num;
			num ^= 1491034007U;
			sbyte b;
			if (!75C62082)
			{
				b = checked((sbyte)this.46631332);
			}
			else
			{
				num = 206733066U << (int)num;
				ulong num6 = (ulong)this.46631332;
				num = 516694622U - num;
				sbyte b2 = (sbyte)num6;
				num = (927866324U | num);
				b = b2;
				num ^= 3876675657U;
			}
			return b;
			Block_9:
			num -= 1398890479U;
			int num9;
			checked
			{
				short num7;
				if (!75C62082)
				{
					num = 1974292178U / num;
					num = (2058101998U | num);
					num7 = (short)this.46631332;
				}
				else
				{
					num %= 363670877U;
					short num8 = (short)((ulong)this.46631332);
					num <<= 15;
					num7 = num8;
					num ^= 1274979566U;
				}
				return num7;
				Block_12:
				num9 = (int)this.46631332;
				goto IL_297;
				IL_277:;
			}
			num = 2114677543U * num;
			ulong num10 = (ulong)this.46631332;
			num -= 1956791601U;
			num9 = checked((int)num10);
			num ^= 2662108879U;
			IL_297:
			return num9;
			Block_14:
			long num11 = this.46631332;
			goto IL_2E1;
			IL_2C1:
			num = 1109550742U * num;
			long num12 = (long)(checked((ulong)this.46631332));
			num = 448404736U / num;
			num11 = num12;
			num ^= 1U;
			IL_2E1:
			num = 2091146040U + num;
			return num11;
			Block_16:
			num <<= 2;
			byte b3 = checked((byte)this.46631332);
			goto IL_34F;
			Block_17:
			ulong num13 = (ulong)this.46631332;
			num = (1986986502U & num);
			byte b4 = (byte)num13;
			num /= 1779915187U;
			b3 = b4;
			num += 3520666492U;
			IL_34F:
			num |= 1834316054U;
			return b3;
			Block_20:
			num %= 1334728215U;
			ushort num14 = checked((ushort)this.46631332);
			goto IL_3CA;
			IL_396:
			num ^= 1012686096U;
			if (num - 1230110824U == 0U)
			{
				goto IL_52;
			}
			num = (1620197274U & num);
			ushort num15 = (ushort)(checked((uint)this.46631332));
			num ^= 278015771U;
			num14 = num15;
			num += 329895494U;
			IL_3CA:
			num = (1949656523U & num);
			return num14;
			Block_22:
			uint num17;
			if (!75C62082)
			{
				num = 2002465777U - num;
				uint num16 = (uint)this.46631332;
				num = (1000698298U & num);
				num17 = num16;
			}
			else
			{
				ulong num18 = (ulong)this.46631332;
				num = 766211492U / num;
				uint num19 = (uint)num18;
				num = 1805148209U << (int)num;
				num17 = num19;
				num += 2492178785U;
			}
			return num17;
			Block_25:
			num = 326966582U << (int)num;
			ulong num20 = checked((ulong)this.46631332);
			goto IL_48E;
			Block_26:
			num20 = (ulong)this.46631332;
			num += 326966582U;
			IL_48E:
			num = 2034121963U + num;
			return num20;
			Block_29:
			num = 878064055U % num;
			double num21 = (double)this.46631332;
			goto IL_50F;
			Block_30:
			num %= 418201337U;
			long num22 = this.46631332;
			num -= 1726883031U;
			double num23 = num22;
			num = (780891224U & num);
			num21 = num23;
			num += 239910263U;
			IL_50F:
			num |= 1913922214U;
			return num21;
			IL_51D:
			throw new ArgumentException();
		}

		// Token: 0x040002FE RID: 766
		private long 46631332;
	}

	// Token: 0x02000054 RID: 84
	private sealed class 1F5C5947 : 6B147225.14B354D4
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00E76E00 File Offset: 0x00E73200
		public 1F5C5947(float 2DBD116A)
		{
			uint num = 707340342U;
			if (num != 1189171965U)
			{
				do
				{
					num -= 1926434770U;
					base..ctor();
				}
				while (num <= 969174069U);
				do
				{
					num = 1337677679U >> (int)num;
					this.4D687F50 = 2DBD116A;
				}
				while ((num & 1754883293U) == 0U);
			}
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x00E76E58 File Offset: 0x00E73258
		public override Type 0B2A827C()
		{
			return typeof(float);
		}

		// Token: 0x06000452 RID: 1106 RVA: 0x00E76E78 File Offset: 0x00E73278
		public override TypeCode 39440F35()
		{
			uint num = 534540606U;
			return (TypeCode)(num ^ 534540595U);
		}

		// Token: 0x06000453 RID: 1107 RVA: 0x00E76E94 File Offset: 0x00E73294
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.1F5C5947(this.4D687F50);
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x00E76EB4 File Offset: 0x00E732B4
		public override object 5049A7CC()
		{
			return this.4D687F50;
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x00E76ED4 File Offset: 0x00E732D4
		public override void 62B618BD(object 4C2B0FC1)
		{
			uint num = 1936277398U;
			if (num > 135405359U)
			{
				num = 1801938147U - num;
				float num2 = Convert.ToSingle(4C2B0FC1);
				num >>= 23;
				this.4D687F50 = num2;
			}
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x00E76F10 File Offset: 0x00E73310
		public override bool 93CE0566()
		{
			uint num = 122770829U;
			num = 1481534380U >> (int)num;
			float value = this.4D687F50;
			num = 270474168U >> (int)num;
			return Convert.ToBoolean(value);
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x00E76F4C File Offset: 0x00E7334C
		public override sbyte 060AA47D()
		{
			return (sbyte)this.4D687F50;
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00E76F68 File Offset: 0x00E73368
		public override short E915D835()
		{
			return (short)this.4D687F50;
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00E76F7C File Offset: 0x00E7337C
		public override int EDAECC1C()
		{
			return (int)this.4D687F50;
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00E76F98 File Offset: 0x00E73398
		public override long DA78F42D()
		{
			uint num = 257053497U;
			long num2 = (long)this.4D687F50;
			num >>= 3;
			return num2;
		}

		// Token: 0x0600045B RID: 1115 RVA: 0x00E76FBC File Offset: 0x00E733BC
		public override char F3CAAB92()
		{
			uint num = 1116744074U;
			num = (882642815U | num);
			char c = (char)this.4D687F50;
			num &= 1677143926U;
			return c;
		}

		// Token: 0x0600045C RID: 1116 RVA: 0x00E76FE8 File Offset: 0x00E733E8
		public override byte 4D994718()
		{
			uint num = 982782881U;
			num = 858529086U / num;
			return (byte)this.4D687F50;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x00E7700C File Offset: 0x00E7340C
		public override ushort D20A0A8F()
		{
			return (ushort)this.4D687F50;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x00E77028 File Offset: 0x00E73428
		public override uint 786A7318()
		{
			uint num = 1185108580U;
			num = 355142299U / num;
			uint num2 = (uint)this.4D687F50;
			num %= 1134173753U;
			return num2;
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x00E77054 File Offset: 0x00E73454
		public override ulong 5C835FEF()
		{
			uint num = 822229918U;
			ulong num2 = (ulong)this.4D687F50;
			num |= 1189895619U;
			return num2;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x00E77078 File Offset: 0x00E73478
		public override float B55103C5()
		{
			uint num = 1352996849U;
			num *= 5516831U;
			return this.4D687F50;
		}

		// Token: 0x06000461 RID: 1121 RVA: 0x00E7709C File Offset: 0x00E7349C
		public override double 8CC4ACA1()
		{
			return (double)this.4D687F50;
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x00E770B0 File Offset: 0x00E734B0
		public override IntPtr B74C1556()
		{
			int size = IntPtr.Size;
			uint num = 1425026966U;
			uint num2 = num ^ 1425026962U;
			num = (439968944U | num);
			long value;
			if (size != num2 && (num ^ 1569008799U) != 0U)
			{
				num = 845224507U * num;
				value = (long)this.4D687F50;
			}
			else
			{
				num = (421624062U & num);
				num <<= 26;
				int num3 = (int)this.4D687F50;
				num ^= 1493970704U;
				value = (long)num3;
				num += 2545880034U;
			}
			return new IntPtr(value);
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x00E7712C File Offset: 0x00E7352C
		public override UIntPtr 2B2A13B3()
		{
			uint num = 669996805U;
			if (849099916U > num)
			{
				while (IntPtr.Size != (int)(num - 669996801U))
				{
					if (num / 1437679152U == 0U)
					{
						goto IL_2E;
					}
				}
				goto IL_42;
			}
			goto IL_42;
			IL_2E:
			num -= 1019423120U;
			ulong value = (ulong)this.4D687F50;
			goto IL_7C;
			IL_42:
			if (1292659808U >> (int)num == 0U)
			{
				goto IL_2E;
			}
			num = (287209169U & num);
			uint num2 = (uint)this.4D687F50;
			num |= 1216568101U;
			ulong num3 = (ulong)num2;
			num >>= 28;
			value = num3;
			num += 3945540977U;
			IL_7C:
			return new UIntPtr(value);
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00E771BC File Offset: 0x00E735BC
		public override object CA964614(Type 39E22B82, bool 5A850603)
		{
			uint num = 1895791479U;
			if (num << 29 != 0U)
			{
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num |= 2081442080U;
				Type typeFromHandle = Type.GetTypeFromHandle(handle);
				num *= 896277568U;
				if (39E22B82 == typeFromHandle)
				{
					num += 103297476U;
					goto IL_3A;
				}
			}
			while (num << 12 != 0U)
			{
				num -= 634335165U;
				if (39E22B82 != typeof(UIntPtr))
				{
					for (;;)
					{
						TypeCode typeCode = Type.GetTypeCode(39E22B82);
						num <<= 16;
						TypeCode typeCode2 = typeCode;
						num /= 1528832186U;
						object obj = typeCode2;
						object obj2 = num ^ 4U;
						num = 661991308U * num;
						object obj3 = obj - obj2;
						num %= 1872515325U;
						switch (obj3)
						{
						case 0:
							goto IL_122;
						case 1:
							goto IL_20E;
						case 2:
							goto IL_18A;
						case 3:
							goto IL_237;
						case 4:
							goto IL_1F9;
						case 5:
							goto IL_25C;
						case 6:
							goto IL_2CA;
						case 7:
							num = (2133985993U & num);
							if (771901965U + num != 0U)
							{
								goto Block_15;
							}
							continue;
						}
						goto Block_5;
					}
					IL_18A:
					num = 503784586U - num;
					short num3;
					if (!5A850603)
					{
						num = 1893551430U - num;
						if (1029130573U > num)
						{
							goto IL_3A;
						}
						num = 1081487205U % num;
						short num2 = (short)this.4D687F50;
						num &= 1585912714U;
						num3 = num2;
					}
					else
					{
						if ((1899644703U & num) == 0U)
						{
							continue;
						}
						num = 1780559431U + num;
						num3 = checked((short)((uint)this.4D687F50));
						num += 3746752443U;
					}
					num = 1475503170U * num;
					return num3;
					Block_5:
					if (357379451 << (int)num != 0)
					{
						num += 0U;
						goto IL_2CA;
					}
					goto IL_3A;
					IL_122:
					num = 1369179510U + num;
					num = 1460825693U * num;
					sbyte b;
					if (!5A850603)
					{
						if ((num & 1919486789U) == 0U)
						{
							goto IL_3A;
						}
						num = 394020489U / num;
						b = checked((sbyte)this.4D687F50);
					}
					else
					{
						if ((1679103886U ^ num) == 0U)
						{
							goto IL_3A;
						}
						uint num4 = (uint)this.4D687F50;
						num += 824788132U;
						sbyte b2 = (sbyte)num4;
						num = 614924589U + num;
						b = b2;
						num ^= 503014283U;
					}
					return b;
					IL_1F9:
					int num5 = checked((int)this.4D687F50);
					num = 1407545565U * num;
					return num5;
					IL_20E:
					num <<= 24;
					if (1774281706U % num != 0U)
					{
						num %= 1004408513U;
						return checked((byte)this.4D687F50);
					}
					goto IL_3A;
					IL_237:
					num += 1039101567U;
					num = 285876955U % num;
					ushort num6 = checked((ushort)this.4D687F50);
					num *= 1974947130U;
					return num6;
					IL_25C:
					num &= 1793866836U;
					if ((num ^ 937891207U) != 0U)
					{
						uint num7 = (uint)this.4D687F50;
						num = 1347362851U * num;
						uint num8 = num7;
						num = 645731606U >> (int)num;
						return num8;
					}
					goto IL_3A;
					Block_15:
					ulong num9 = (ulong)this.4D687F50;
					num += 595940435U;
					ulong num10 = num9;
					num = 868374963U >> (int)num;
					return num10;
					IL_2CA:
					num = (790104268U & num);
					throw new ArgumentException();
				}
				if (1598173066U * num != 0U)
				{
					break;
				}
				goto IL_3A;
			}
			num = (1072713876U & num);
			ulong value = checked((ulong)this.4D687F50);
			num = 241246970U * num;
			return new UIntPtr(value);
			IL_3A:
			long value2 = checked((long)this.4D687F50);
			num = (1134563344U & num);
			IntPtr intPtr = new IntPtr(value2);
			num ^= 1024621250U;
			return intPtr;
		}

		// Token: 0x040002FF RID: 767
		private float 4D687F50;
	}

	// Token: 0x02000055 RID: 85
	private sealed class 60416C9D : 6B147225.14B354D4
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00E774A0 File Offset: 0x00E738A0
		public 60416C9D(double 406C0705)
		{
			uint num = 1702568468U;
			if (num <= 2079934161U)
			{
				num -= 9193934U;
				base..ctor();
				num -= 1378701972U;
			}
			num = (1906011768U | num);
			this.078205BB = 406C0705;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00E774E4 File Offset: 0x00E738E4
		public override Type 0B2A827C()
		{
			return typeof(double);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00E77504 File Offset: 0x00E73904
		public override TypeCode 39440F35()
		{
			uint num = 688408525U;
			return (TypeCode)(num - 688408511U);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00E77520 File Offset: 0x00E73920
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 800091201U;
			double 406C = this.078205BB;
			num |= 155519165U;
			return new 6B147225.60416C9D(406C);
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00E77548 File Offset: 0x00E73948
		public override object 5049A7CC()
		{
			return this.078205BB;
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00E77568 File Offset: 0x00E73968
		public override void 62B618BD(object 27197D71)
		{
			uint num = 657656021U;
			if (num <= 1913788477U)
			{
				num = 1185819015U >> (int)num;
				num >>= 18;
				double num2 = (double)27197D71;
				num = (205589061U & num);
				this.078205BB = num2;
			}
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00E775B0 File Offset: 0x00E739B0
		public override bool 93CE0566()
		{
			return Convert.ToBoolean(this.078205BB);
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x00E775D0 File Offset: 0x00E739D0
		public override sbyte 060AA47D()
		{
			return (sbyte)this.078205BB;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00E775EC File Offset: 0x00E739EC
		public override short E915D835()
		{
			return (short)this.078205BB;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00E77608 File Offset: 0x00E73A08
		public override int EDAECC1C()
		{
			return (int)this.078205BB;
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x00E77624 File Offset: 0x00E73A24
		public override long DA78F42D()
		{
			uint num = 786329326U;
			num = 254835494U - num;
			long num2 = (long)this.078205BB;
			num = 2139701750U << (int)num;
			return num2;
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x00E77654 File Offset: 0x00E73A54
		public override char F3CAAB92()
		{
			uint num = 1435705962U;
			num = 669131357U % num;
			return (char)this.078205BB;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00E77678 File Offset: 0x00E73A78
		public override byte 4D994718()
		{
			uint num = 1577275708U;
			byte b = (byte)this.078205BB;
			num >>= 22;
			return b;
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x00E7769C File Offset: 0x00E73A9C
		public override ushort D20A0A8F()
		{
			uint num = 4613721U;
			ushort num2 = (ushort)this.078205BB;
			num = 715027210U << (int)num;
			return num2;
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00E776C4 File Offset: 0x00E73AC4
		public override uint 786A7318()
		{
			return (uint)this.078205BB;
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x00E776E0 File Offset: 0x00E73AE0
		public override ulong 5C835FEF()
		{
			return (ulong)this.078205BB;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x00E776FC File Offset: 0x00E73AFC
		public override float B55103C5()
		{
			return (float)this.078205BB;
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00E77718 File Offset: 0x00E73B18
		public override double 8CC4ACA1()
		{
			uint num = 233469857U;
			num *= 1643211829U;
			return this.078205BB;
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00E7773C File Offset: 0x00E73B3C
		public override IntPtr B74C1556()
		{
			uint num = 1702910191U;
			int size = IntPtr.Size;
			num >>= 22;
			uint num2 = num ^ 402U;
			num %= 404491673U;
			long value;
			if (size != num2)
			{
				num = (1326397866U ^ num);
				num |= 1581466523U;
				value = (long)this.078205BB;
			}
			else
			{
				int num3 = (int)this.078205BB;
				num <<= 12;
				value = (long)num3;
				num ^= 1599478719U;
			}
			return new IntPtr(value);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x00E777AC File Offset: 0x00E73BAC
		public override UIntPtr 2B2A13B3()
		{
			uint num;
			for (;;)
			{
				if (IntPtr.Size != 4)
				{
					num = 1737828790U;
					if (1204033920U <= num)
					{
						break;
					}
				}
				num = 1067870018U;
				if (608071917U < num)
				{
					goto Block_2;
				}
			}
			num = (513891328U ^ num);
			ulong value = (ulong)this.078205BB;
			goto IL_61;
			Block_2:
			num = (797314931U | num);
			ulong num2 = (ulong)((uint)this.078205BB);
			num -= 1332376708U;
			value = num2;
			num += 2297985735U;
			IL_61:
			num = 1760170011U << (int)num;
			return new UIntPtr(value);
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00E77830 File Offset: 0x00E73C30
		public override object CA964614(Type 601F2AA5, bool 485138C2)
		{
			uint num = 1570714786U;
			if (num < 1065309023U)
			{
				goto IL_73;
			}
			for (;;)
			{
				IL_11:
				num *= 1544440934U;
				RuntimeTypeHandle handle = typeof(IntPtr).TypeHandle;
				num = (361584055U | num);
				if (601F2AA5 != Type.GetTypeFromHandle(handle))
				{
					break;
				}
				if (num - 661273932U != 0U)
				{
					goto IL_3D;
				}
			}
			for (;;)
			{
				IL_73:
				num = 1224105483U - num;
				if (num <= 2059497551U)
				{
					goto IL_11;
				}
				Type typeFromHandle = typeof(UIntPtr);
				num /= 1204624842U;
				if (601F2AA5 == typeFromHandle)
				{
					break;
				}
				num /= 380070856U;
				TypeCode typeCode = Type.GetTypeCode(601F2AA5);
				if (num != 639133358U)
				{
					TypeCode typeCode2 = typeCode;
					num += 296044237U;
					uint num2 = num ^ 296044232U;
					num |= 1338316909U;
					switch (typeCode2 - num2)
					{
					case 0:
						goto IL_143;
					case 1:
						goto IL_264;
					case 2:
						num ^= 1898397975U;
						if (485138C2)
						{
							goto IL_1F6;
						}
						num |= 1940007179U;
						if ((num ^ 562957412U) != 0U)
						{
							goto Block_9;
						}
						continue;
					case 3:
						goto IL_284;
					case 4:
						num = 696536806U / num;
						if (538325747U > num)
						{
							goto Block_11;
						}
						continue;
					case 5:
						goto IL_2AC;
					case 6:
						goto IL_24F;
					case 7:
						goto IL_2C9;
					case 8:
						goto IL_30C;
					case 9:
						goto IL_2DE;
					}
					goto Block_4;
				}
				goto IL_11;
			}
			IL_9E:
			num <<= 30;
			ulong num3 = (ulong)this.078205BB;
			num = (1656500041U & num);
			ulong value = num3;
			num = 437993895U >> (int)num;
			UIntPtr uintPtr = new UIntPtr(value);
			num %= 1672426639U;
			return uintPtr;
			Block_4:
			num ^= 0U;
			goto IL_30C;
			IL_143:
			num -= 410268083U;
			if (1027677497U * num != 0U)
			{
				sbyte b;
				if (!485138C2)
				{
					num = (184758548U | num);
					num |= 1699969709U;
					b = checked((sbyte)this.078205BB);
				}
				else
				{
					num ^= 2140084793U;
					if (1093233313U < num)
					{
						goto IL_9E;
					}
					uint num4 = (uint)this.078205BB;
					num ^= 1585588017U;
					sbyte b2 = (sbyte)num4;
					num = 1694043668U - num;
					b = b2;
					num += 1895203293U;
				}
				num ^= 1122590465U;
				return b;
			}
			goto IL_11;
			Block_9:
			num = 1163281944U << (int)num;
			short num5;
			checked
			{
				num5 = (short)this.078205BB;
				goto IL_221;
				IL_1F6:
				num &= 2096175826U;
				if (1639987594U < num)
				{
					goto IL_3D;
				}
				uint num6 = (uint)this.078205BB;
				num = (2140424846U ^ num);
				num5 = (short)num6;
			}
			num += 1823190948U;
			IL_221:
			return num5;
			Block_11:
			int num7 = (int)this.078205BB;
			num = (2139894754U | num);
			return num7;
			IL_24F:
			num = (1411455407U ^ num);
			checked
			{
				return (long)this.078205BB;
				IL_264:
				if (1267869546U < num)
				{
					num = 1589717351U % num;
					return (byte)this.078205BB;
				}
				goto IL_11;
				IL_284:
				num = 521624250U % num;
			}
			if (250026689U < num)
			{
				ushort num8 = checked((ushort)this.078205BB);
				num += 60558912U;
				return num8;
			}
			goto IL_11;
			IL_2AC:
			num *= 13661540U;
			uint num9 = (uint)this.078205BB;
			num |= 1354714124U;
			return num9;
			IL_2C9:
			num *= 1830230272U;
			checked
			{
				return (ulong)this.078205BB;
				IL_2DE:
				num = 726012415U % num;
				if (278201005 << (int)num != 0)
				{
					num = 1158837292U % num;
					return this.078205BB;
				}
				goto IL_11;
				IL_30C:
				num ^= 535102703U;
				if ((num ^ 1177450372U) != 0U)
				{
					throw new ArgumentException();
				}
				goto IL_11;
				IL_3D:
				num = 2073263227U >> (int)num;
				long value2 = (long)this.078205BB;
				num = 119800994U << (int)num;
				IntPtr intPtr = new IntPtr(value2);
				num <<= 11;
				return intPtr;
			}
		}

		// Token: 0x04000300 RID: 768
		private double 078205BB;
	}

	// Token: 0x02000056 RID: 86
	private sealed class 2B9A788E : 6B147225.14B354D4
	{
		// Token: 0x0600047A RID: 1146 RVA: 0x00E77B64 File Offset: 0x00E73F64
		public 2B9A788E(string 356D354A)
		{
			uint num = 1965895790U;
			do
			{
				num = 820264694U % num;
				base..ctor();
			}
			while (num == 803238444U);
			num = (1734085171U ^ num);
			this.43D64206 = 356D354A;
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x00E77BA0 File Offset: 0x00E73FA0
		public override Type 0B2A827C()
		{
			return typeof(string);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00E77BC0 File Offset: 0x00E73FC0
		public override TypeCode 39440F35()
		{
			return TypeCode.Object;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00E77BD0 File Offset: 0x00E73FD0
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.2B9A788E(this.43D64206);
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x00E77BF0 File Offset: 0x00E73FF0
		public override object 5049A7CC()
		{
			return this.43D64206;
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00E77C0C File Offset: 0x00E7400C
		public override void 62B618BD(object 6D354E1E)
		{
			uint num = 322584240U;
			if ((num & 975442763U) != 0U)
			{
				num <<= 22;
				string text;
				if (6D354E1E == null)
				{
					text = null;
				}
				else
				{
					text = Convert.ToString(6D354E1E);
					num ^= 0U;
				}
				this.43D64206 = text;
			}
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00E77C54 File Offset: 0x00E74054
		public override bool 93CE0566()
		{
			uint num = 193165472U;
			num *= 1847726054U;
			string text = this.43D64206;
			object obj = null;
			num &= 1954554179U;
			return text > obj;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00E77C80 File Offset: 0x00E74080
		public override string ToString()
		{
			return this.43D64206;
		}

		// Token: 0x04000301 RID: 769
		private string 43D64206;
	}

	// Token: 0x02000057 RID: 87
	private sealed class 6F5B5DDB : 6B147225.68EF01A4
	{
		// Token: 0x06000482 RID: 1154 RVA: 0x00E77C94 File Offset: 0x00E74094
		public 6F5B5DDB(short 24507AC4)
		{
			uint num = 32839139U;
			if (555307635U >> (int)num != 0U)
			{
				do
				{
					num *= 1151759349U;
					this.45D25330 = 24507AC4;
				}
				while (num % 1343316019U == 0U);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00E77CDC File Offset: 0x00E740DC
		public override Type 0B2A827C()
		{
			uint num = 2059040296U;
			RuntimeTypeHandle handle = typeof(short).TypeHandle;
			num = 120664032U % num;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00E77D04 File Offset: 0x00E74104
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.6F5B5DDB(this.45D25330);
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00E77D1C File Offset: 0x00E7411C
		public override object 5049A7CC()
		{
			return this.45D25330;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00E77D3C File Offset: 0x00E7413C
		public override void 62B618BD(object 1ADD2D63)
		{
			uint num = 455096270U;
			if (num / 1477576236U == 0U)
			{
				do
				{
					this.45D25330 = Convert.ToInt16(1ADD2D63);
				}
				while (num % 395904017U == 0U);
			}
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00E77D74 File Offset: 0x00E74174
		public override 6B147225.14B354D4 6991E7AF()
		{
			uint num = 1734824360U;
			int 5EEF = this.EDAECC1C();
			num = 209813023U + num;
			return new 6B147225.1F462BA1(5EEF);
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00E77D9C File Offset: 0x00E7419C
		public override sbyte 060AA47D()
		{
			uint num = 1037255443U;
			sbyte b = (sbyte)this.45D25330;
			num = 2075420446U + num;
			return b;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00E77DC0 File Offset: 0x00E741C0
		public override byte 4D994718()
		{
			uint num = 1451763888U;
			num |= 1385000730U;
			byte b = (byte)this.45D25330;
			num -= 442858956U;
			return b;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00E77DEC File Offset: 0x00E741EC
		public override short E915D835()
		{
			return this.45D25330;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00E77E00 File Offset: 0x00E74200
		public override ushort D20A0A8F()
		{
			uint num = 1499866464U;
			ushort num2 = (ushort)this.45D25330;
			num >>= 23;
			return num2;
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x00E77E24 File Offset: 0x00E74224
		public override int EDAECC1C()
		{
			return (int)this.45D25330;
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00E77E38 File Offset: 0x00E74238
		public override uint 786A7318()
		{
			return (uint)this.45D25330;
		}

		// Token: 0x04000302 RID: 770
		private short 45D25330;
	}

	// Token: 0x02000058 RID: 88
	private sealed class 130817DC : 6B147225.68EF01A4
	{
		// Token: 0x0600048E RID: 1166 RVA: 0x00E77E54 File Offset: 0x00E74254
		public 130817DC(ushort 07BA1ABE)
		{
			uint num = 411125299U;
			do
			{
				base..ctor();
				if ((765738935U & num) == 0U)
				{
					break;
				}
				this.5E111FE3 = 07BA1ABE;
			}
			while (2092439762U < num);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00E77E8C File Offset: 0x00E7428C
		public override Type 0B2A827C()
		{
			return typeof(ushort);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00E77EAC File Offset: 0x00E742AC
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 339501353U;
			num = (270417031U & num);
			return new 6B147225.130817DC(this.5E111FE3);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00E77ED4 File Offset: 0x00E742D4
		public override object 5049A7CC()
		{
			uint num = 1813005261U;
			ushort num2 = this.5E111FE3;
			num = 1452213559U << (int)num;
			return num2;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00E77F00 File Offset: 0x00E74300
		public override void 62B618BD(object 60CB5C89)
		{
			uint num;
			do
			{
				num = 234041894U;
				num = (1497890913U ^ num);
				this.5E111FE3 = Convert.ToUInt16(60CB5C89);
			}
			while (num % 1648381307U == 0U);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00E77F34 File Offset: 0x00E74334
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x00E77F4C File Offset: 0x00E7434C
		public override sbyte 060AA47D()
		{
			return (sbyte)this.5E111FE3;
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00E77F68 File Offset: 0x00E74368
		public override byte 4D994718()
		{
			return (byte)this.5E111FE3;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00E77F84 File Offset: 0x00E74384
		public override short E915D835()
		{
			return (short)this.5E111FE3;
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x00E77F98 File Offset: 0x00E74398
		public override ushort D20A0A8F()
		{
			return this.5E111FE3;
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x00E77FB4 File Offset: 0x00E743B4
		public override int EDAECC1C()
		{
			return (int)this.5E111FE3;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00E77FC8 File Offset: 0x00E743C8
		public override uint 786A7318()
		{
			uint num = 1685150653U;
			num = 2004038475U * num;
			return (uint)this.5E111FE3;
		}

		// Token: 0x04000303 RID: 771
		private ushort 5E111FE3;
	}

	// Token: 0x02000059 RID: 89
	private sealed class 591C7B9A : 6B147225.68EF01A4
	{
		// Token: 0x0600049A RID: 1178 RVA: 0x00E77FEC File Offset: 0x00E743EC
		public 591C7B9A(bool 0B111384)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1182607270U;
			}
			while (199119094U == num);
			num >>= 29;
			num = 1958691835U * num;
			this.11E440AF = 0B111384;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00E78028 File Offset: 0x00E74428
		public override Type 0B2A827C()
		{
			return typeof(bool);
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00E78048 File Offset: 0x00E74448
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.591C7B9A(this.11E440AF);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00E78068 File Offset: 0x00E74468
		public override object 5049A7CC()
		{
			return this.11E440AF;
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00E78088 File Offset: 0x00E74488
		public override void 62B618BD(object 42975549)
		{
			uint num = 548497938U;
			do
			{
				num = (1506494724U | num);
				num *= 577767677U;
				bool flag = Convert.ToBoolean(42975549);
				num = (1228554728U & num);
				this.11E440AF = flag;
			}
			while ((51922296U ^ num) == 0U);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00E780CC File Offset: 0x00E744CC
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x00E780EC File Offset: 0x00E744EC
		public override int EDAECC1C()
		{
			uint num = 433605728U;
			if (num > 63122560U)
			{
				bool flag = this.11E440AF;
				num = (1673142504U ^ num);
				if (flag)
				{
					return (int)(num ^ 2053270665U);
				}
			}
			num += 1614286877U;
			return (int)(num - 3667557541U);
		}

		// Token: 0x04000304 RID: 772
		private bool 11E440AF;
	}

	// Token: 0x0200005A RID: 90
	private sealed class 7E683F22 : 6B147225.68EF01A4
	{
		// Token: 0x060004A1 RID: 1185 RVA: 0x00E78134 File Offset: 0x00E74534
		public 7E683F22(char 46AF6C89)
		{
			uint num = 1793663340U;
			base..ctor();
			num >>= 29;
			num = 1803307477U * num;
			num = (1990294523U | num);
			this.1FCF7287 = 46AF6C89;
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x00E7816C File Offset: 0x00E7456C
		public override Type 0B2A827C()
		{
			uint num = 352528454U;
			RuntimeTypeHandle handle = typeof(char).TypeHandle;
			num ^= 906907543U;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00E78194 File Offset: 0x00E74594
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.7E683F22(this.1FCF7287);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x00E781B4 File Offset: 0x00E745B4
		public override object 5049A7CC()
		{
			uint num = 1059603147U;
			char c = this.1FCF7287;
			num |= 940450687U;
			return c;
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x00E781DC File Offset: 0x00E745DC
		public override void 62B618BD(object 386C03A2)
		{
			this.1FCF7287 = Convert.ToChar(386C03A2);
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00E781FC File Offset: 0x00E745FC
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00E7821C File Offset: 0x00E7461C
		public override sbyte 060AA47D()
		{
			uint num = 164511487U;
			num = 1725259051U << (int)num;
			sbyte b = (sbyte)this.1FCF7287;
			num = (1652368164U & num);
			return b;
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00E7824C File Offset: 0x00E7464C
		public override byte 4D994718()
		{
			uint num = 677063777U;
			byte b = (byte)this.1FCF7287;
			num = (112926780U ^ num);
			return b;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00E78270 File Offset: 0x00E74670
		public override short E915D835()
		{
			return (short)this.1FCF7287;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00E7828C File Offset: 0x00E7468C
		public override ushort D20A0A8F()
		{
			return (ushort)this.1FCF7287;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00E782A8 File Offset: 0x00E746A8
		public override int EDAECC1C()
		{
			return (int)this.1FCF7287;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00E782BC File Offset: 0x00E746BC
		public override uint 786A7318()
		{
			return (uint)this.1FCF7287;
		}

		// Token: 0x04000305 RID: 773
		private char 1FCF7287;
	}

	// Token: 0x0200005B RID: 91
	private sealed class 62930004 : 6B147225.68EF01A4
	{
		// Token: 0x060004AD RID: 1197 RVA: 0x00E782D8 File Offset: 0x00E746D8
		public 62930004(byte 2C6370E1)
		{
			this.540A1944 = 2C6370E1;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00E782F8 File Offset: 0x00E746F8
		public override Type 0B2A827C()
		{
			return typeof(byte);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00E78318 File Offset: 0x00E74718
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.62930004(this.540A1944);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00E78338 File Offset: 0x00E74738
		public override object 5049A7CC()
		{
			uint num = 1551696652U;
			num /= 151536008U;
			return this.540A1944;
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00E78360 File Offset: 0x00E74760
		public override void 62B618BD(object 7F895458)
		{
			this.540A1944 = Convert.ToByte(7F895458);
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00E78380 File Offset: 0x00E74780
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00E783A0 File Offset: 0x00E747A0
		public override sbyte 060AA47D()
		{
			return (sbyte)this.540A1944;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00E783BC File Offset: 0x00E747BC
		public override byte 4D994718()
		{
			return this.540A1944;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00E783D8 File Offset: 0x00E747D8
		public override short E915D835()
		{
			return (short)this.540A1944;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00E783F4 File Offset: 0x00E747F4
		public override ushort D20A0A8F()
		{
			return (ushort)this.540A1944;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00E78410 File Offset: 0x00E74810
		public override int EDAECC1C()
		{
			uint num = 1099580682U;
			num = (827278135U ^ num);
			return (int)this.540A1944;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00E78434 File Offset: 0x00E74834
		public override uint 786A7318()
		{
			return (uint)this.540A1944;
		}

		// Token: 0x04000306 RID: 774
		private byte 540A1944;
	}

	// Token: 0x0200005C RID: 92
	private sealed class 009559D5 : 6B147225.68EF01A4
	{
		// Token: 0x060004B9 RID: 1209 RVA: 0x00E78448 File Offset: 0x00E74848
		public 009559D5(sbyte 43EE79C8)
		{
			uint num = 1105274569U;
			if (num << 26 != 0U)
			{
				base..ctor();
				num = 1000301875U / num;
			}
			num = (654134318U | num);
			this.2D015221 = 43EE79C8;
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00E78484 File Offset: 0x00E74884
		public override Type 0B2A827C()
		{
			return typeof(sbyte);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00E784A4 File Offset: 0x00E748A4
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.009559D5(this.2D015221);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00E784C4 File Offset: 0x00E748C4
		public override object 5049A7CC()
		{
			uint num = 486963232U;
			num *= 691020640U;
			sbyte b = this.2D015221;
			num = 276706864U << (int)num;
			return b;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00E784F8 File Offset: 0x00E748F8
		public override void 62B618BD(object 3AC15370)
		{
			uint num;
			do
			{
				num = 1048728224U;
				this.2D015221 = Convert.ToSByte(3AC15370);
			}
			while (num == 881812857U);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00E78524 File Offset: 0x00E74924
		public override 6B147225.14B354D4 6991E7AF()
		{
			uint num = 1001553733U;
			num = 709194563U % num;
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00E7854C File Offset: 0x00E7494C
		public override sbyte 060AA47D()
		{
			uint num = 464999576U;
			num &= 2115919376U;
			return this.2D015221;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00E78570 File Offset: 0x00E74970
		public override byte 4D994718()
		{
			uint num = 1202995101U;
			byte b = (byte)this.2D015221;
			num = (1579040699U ^ num);
			return b;
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00E78594 File Offset: 0x00E74994
		public override short E915D835()
		{
			return (short)this.2D015221;
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00E785A8 File Offset: 0x00E749A8
		public override ushort D20A0A8F()
		{
			uint num = 861498440U;
			ushort num2 = (ushort)this.2D015221;
			num = 1190619688U - num;
			return num2;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00E785CC File Offset: 0x00E749CC
		public override int EDAECC1C()
		{
			return (int)this.2D015221;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00E785E8 File Offset: 0x00E749E8
		public override uint 786A7318()
		{
			uint num = 1268328433U;
			num &= 1994227702U;
			return (uint)this.2D015221;
		}

		// Token: 0x04000307 RID: 775
		private sbyte 2D015221;
	}

	// Token: 0x0200005D RID: 93
	private sealed class 373B0CAE : 6B147225.68EF01A4
	{
		// Token: 0x060004C5 RID: 1221 RVA: 0x00E7860C File Offset: 0x00E74A0C
		public 373B0CAE(uint 37864919)
		{
			uint num;
			do
			{
				num = 1176591519U;
				base..ctor();
				num = (916652301U ^ num);
				num = 2120565897U * num;
				this.4FD4163E = 37864919;
			}
			while (num < 1624398175U);
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x00E78648 File Offset: 0x00E74A48
		public override Type 0B2A827C()
		{
			return typeof(uint);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00E78668 File Offset: 0x00E74A68
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1382892099U;
			uint <<EMPTY_NAME>> = this.4FD4163E;
			num = (1785139625U | num);
			return new 6B147225.373B0CAE(<<EMPTY_NAME>>);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00E78690 File Offset: 0x00E74A90
		public override object 5049A7CC()
		{
			uint num = 266091551U;
			uint num2 = this.4FD4163E;
			num = 2021750821U + num;
			return num2;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00E786B8 File Offset: 0x00E74AB8
		public override void 62B618BD(object 62FB5AB6)
		{
			this.4FD4163E = Convert.ToUInt32(62FB5AB6);
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00E786D8 File Offset: 0x00E74AD8
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.1F462BA1(this.EDAECC1C());
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00E786F0 File Offset: 0x00E74AF0
		public override sbyte 060AA47D()
		{
			uint num = 389226890U;
			num = 2037452726U - num;
			return (sbyte)this.4FD4163E;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00E78714 File Offset: 0x00E74B14
		public override byte 4D994718()
		{
			return (byte)this.4FD4163E;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00E78728 File Offset: 0x00E74B28
		public override short E915D835()
		{
			uint num = 1445468186U;
			short num2 = (short)this.4FD4163E;
			num *= 1280786789U;
			return num2;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00E7874C File Offset: 0x00E74B4C
		public override ushort D20A0A8F()
		{
			return (ushort)this.4FD4163E;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00E78768 File Offset: 0x00E74B68
		public override int EDAECC1C()
		{
			return (int)this.4FD4163E;
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00E78784 File Offset: 0x00E74B84
		public override uint 786A7318()
		{
			return this.4FD4163E;
		}

		// Token: 0x04000308 RID: 776
		private uint 4FD4163E;
	}

	// Token: 0x0200005E RID: 94
	private sealed class 61A633AA : 6B147225.68EF01A4
	{
		// Token: 0x060004D1 RID: 1233 RVA: 0x00E787A0 File Offset: 0x00E74BA0
		public 61A633AA(ulong 305673D7)
		{
			uint num = 174526546U;
			base..ctor();
			if (2022012581 << (int)num != 0)
			{
				this.4CD76D1D = 305673D7;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00E787D4 File Offset: 0x00E74BD4
		public override Type 0B2A827C()
		{
			return typeof(ulong);
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00E787EC File Offset: 0x00E74BEC
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1279948892U;
			num -= 487522972U;
			ulong 305673D = this.4CD76D1D;
			num = 1818704777U * num;
			return new 6B147225.61A633AA(305673D);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00E7881C File Offset: 0x00E74C1C
		public override object 5049A7CC()
		{
			uint num = 1312443851U;
			ulong num2 = this.4CD76D1D;
			num -= 421676413U;
			return num2;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00E78844 File Offset: 0x00E74C44
		public override void 62B618BD(object 07B25037)
		{
			this.4CD76D1D = Convert.ToUInt64(07B25037);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00E78864 File Offset: 0x00E74C64
		public override 6B147225.14B354D4 6991E7AF()
		{
			return new 6B147225.58E136FA(this.DA78F42D());
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00E78884 File Offset: 0x00E74C84
		public override sbyte 060AA47D()
		{
			return (sbyte)this.4CD76D1D;
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00E788A0 File Offset: 0x00E74CA0
		public override byte 4D994718()
		{
			uint num = 1777752525U;
			num = 319902023U + num;
			return (byte)this.4CD76D1D;
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00E788C4 File Offset: 0x00E74CC4
		public override short E915D835()
		{
			return (short)this.4CD76D1D;
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00E788E0 File Offset: 0x00E74CE0
		public override ushort D20A0A8F()
		{
			return (ushort)this.4CD76D1D;
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00E788F4 File Offset: 0x00E74CF4
		public override int EDAECC1C()
		{
			uint num = 800655435U;
			int num2 = (int)this.4CD76D1D;
			num = 1379932065U * num;
			return num2;
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00E78918 File Offset: 0x00E74D18
		public override uint 786A7318()
		{
			return (uint)this.4CD76D1D;
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00E7892C File Offset: 0x00E74D2C
		public override long DA78F42D()
		{
			uint num = 1081413454U;
			num = 1364993931U << (int)num;
			return (long)this.4CD76D1D;
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00E78954 File Offset: 0x00E74D54
		public override ulong 5C835FEF()
		{
			return this.4CD76D1D;
		}

		// Token: 0x04000309 RID: 777
		private ulong 4CD76D1D;
	}

	// Token: 0x0200005F RID: 95
	private sealed class 3FCC0B6B : 6B147225.14B354D4
	{
		// Token: 0x060004DF RID: 1247 RVA: 0x00E78970 File Offset: 0x00E74D70
		public 3FCC0B6B(object 02FC5CA8)
		{
			uint num = 53829232U;
			base..ctor();
			if ((1124812391U & num) != 0U)
			{
				num = (357516616U ^ num);
				this.34122F28 = 02FC5CA8;
			}
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00E789A4 File Offset: 0x00E74DA4
		public override Type 0B2A827C()
		{
			return typeof(object);
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00E789C4 File Offset: 0x00E74DC4
		public override TypeCode 39440F35()
		{
			uint num = 631182331U;
			return (TypeCode)(num ^ 631182330U);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00E789E0 File Offset: 0x00E74DE0
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1713727624U;
			num = (63841627U & num);
			return new 6B147225.3FCC0B6B(this.34122F28);
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00E78A08 File Offset: 0x00E74E08
		public override object 5049A7CC()
		{
			return this.34122F28;
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00E78A24 File Offset: 0x00E74E24
		public override void 62B618BD(object 5F7674C7)
		{
			uint num;
			do
			{
				num = 1097411311U;
				num += 331443022U;
				this.34122F28 = 5F7674C7;
			}
			while ((1882221805U ^ num) == 0U);
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00E78A54 File Offset: 0x00E74E54
		public override bool 93CE0566()
		{
			return this.34122F28 != null;
		}

		// Token: 0x0400030A RID: 778
		private object 34122F28;
	}

	// Token: 0x02000060 RID: 96
	private sealed class 2EF54896 : 6B147225.14B354D4
	{
		// Token: 0x060004E6 RID: 1254 RVA: 0x00E78A70 File Offset: 0x00E74E70
		public 2EF54896(object 286A427D, Type 79C25829)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1513174089U;
			}
			while (num > 1926044831U);
			num >>= 3;
			num = 1360018861U % num;
			this.4B1A14CD = 286A427D;
			this.566B3F1E = 79C25829;
			num = 462178906U << (int)num;
			num = (699416951U & num);
			num ^= 1583966491U;
			this.1F510705 = 6B147225.2EF54896.2C0A3E55(286A427D);
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00E78ADC File Offset: 0x00E74EDC
		private unsafe static 6B147225.68EF01A4 2C0A3E55(object 323F7E52)
		{
			IntPtr intPtr;
			uint num;
			if (323F7E52 == null)
			{
				intPtr = IntPtr.Zero;
				num = 1298684417U;
				goto IL_2F;
			}
			IL_06:
			num = 197272441U;
			void* value = Pointer.Unbox(323F7E52);
			num = (1185577336U ^ num);
			intPtr = new IntPtr(value);
			IL_2F:
			IntPtr intPtr2 = intPtr;
			int size = IntPtr.Size;
			uint num2 = num ^ 1298684421U;
			num %= 1096694818U;
			if (size == num2)
			{
				if (num % 700979514U == 0U)
				{
					goto IL_06;
				}
			}
			else
			{
				num <<= 21;
				if (464277775U < num)
				{
					num = 1462841289U - num;
					long 7B2365FA = intPtr2.ToInt64();
					num = 912533975U + num;
					return new 6B147225.58E136FA(7B2365FA);
				}
			}
			num -= 316812846U;
			return new 6B147225.1F462BA1(intPtr2.ToInt32());
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00E78B84 File Offset: 0x00E74F84
		public override Type 0B2A827C()
		{
			return this.566B3F1E;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00E78BA0 File Offset: 0x00E74FA0
		public override TypeCode 39440F35()
		{
			uint num = 1589527320U;
			if (IntPtr.Size != (int)(num ^ 1589527324U))
			{
				return (TypeCode)(num ^ 1589527316U);
			}
			return (int)num + (TypeCode)(-1589527310);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00E78BD4 File Offset: 0x00E74FD4
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.2EF54896(this.4B1A14CD, this.566B3F1E);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00E78BF8 File Offset: 0x00E74FF8
		public override object 5049A7CC()
		{
			uint num = 867387595U;
			num += 623276141U;
			return this.4B1A14CD;
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00E78C1C File Offset: 0x00E7501C
		public override void 62B618BD(object 1C87464C)
		{
			uint num = 14813860U;
			num = 424106591U % num;
			this.4B1A14CD = 1C87464C;
			num /= 2116961908U;
			num = 947519950U << (int)num;
			num = 740384012U / num;
			6B147225.68EF01A4 68EF01A = 6B147225.2EF54896.2C0A3E55(1C87464C);
			num = (1516970195U & num);
			this.1F510705 = 68EF01A;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00E78C70 File Offset: 0x00E75070
		public override bool 93CE0566()
		{
			uint num = 1589056347U;
			num <<= 5;
			object obj = this.4B1A14CD;
			num += 1818629772U;
			return obj != null;
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00E78C9C File Offset: 0x00E7509C
		public override sbyte 060AA47D()
		{
			return this.1F510705.060AA47D();
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00E78CBC File Offset: 0x00E750BC
		public override short E915D835()
		{
			return this.1F510705.E915D835();
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00E78CD4 File Offset: 0x00E750D4
		public override int EDAECC1C()
		{
			uint num = 154627801U;
			6B147225.68EF01A4 68EF01A = this.1F510705;
			num = (703166523U & num);
			return 68EF01A.EDAECC1C();
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00E78CFC File Offset: 0x00E750FC
		public override long DA78F42D()
		{
			uint num = 324226772U;
			num *= 262307668U;
			6B147225.68EF01A4 68EF01A = this.1F510705;
			num = 277089253U + num;
			return 68EF01A.DA78F42D();
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00E78D2C File Offset: 0x00E7512C
		public override byte 4D994718()
		{
			return this.1F510705.4D994718();
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00E78D44 File Offset: 0x00E75144
		public override ushort D20A0A8F()
		{
			return this.1F510705.D20A0A8F();
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00E78D64 File Offset: 0x00E75164
		public override uint 786A7318()
		{
			return this.1F510705.786A7318();
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00E78D84 File Offset: 0x00E75184
		public override ulong 5C835FEF()
		{
			uint num = 987856010U;
			num = 1462975630U / num;
			6B147225.68EF01A4 68EF01A = this.1F510705;
			num = 1650091459U << (int)num;
			return 68EF01A.5C835FEF();
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00E78DB8 File Offset: 0x00E751B8
		public override float B55103C5()
		{
			return this.1F510705.B55103C5();
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00E78DD8 File Offset: 0x00E751D8
		public override double 8CC4ACA1()
		{
			uint num = 138028188U;
			6B147225.68EF01A4 68EF01A = this.1F510705;
			num &= 1886931467U;
			return 68EF01A.8CC4ACA1();
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00E78E00 File Offset: 0x00E75200
		public override IntPtr B74C1556()
		{
			return this.1F510705.B74C1556();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00E78E20 File Offset: 0x00E75220
		public override UIntPtr 2B2A13B3()
		{
			return this.1F510705.2B2A13B3();
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00E78E40 File Offset: 0x00E75240
		public unsafe override void* 477D7F8C()
		{
			return Pointer.Unbox(this.4B1A14CD);
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00E78E60 File Offset: 0x00E75260
		public override object CA964614(Type 58C45B31, bool 2AD769D0)
		{
			uint num = 675223844U;
			6B147225.68EF01A4 68EF01A = this.1F510705;
			num = 72707734U + num;
			return 68EF01A.CA964614(58C45B31, 2AD769D0);
		}

		// Token: 0x0400030B RID: 779
		private object 4B1A14CD;

		// Token: 0x0400030C RID: 780
		private Type 566B3F1E;

		// Token: 0x0400030D RID: 781
		private 6B147225.68EF01A4 1F510705;
	}

	// Token: 0x02000061 RID: 97
	private sealed class 71755E30 : 6B147225.14B354D4
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00E78E88 File Offset: 0x00E75288
		public 71755E30(object 21CD4FB8)
		{
			uint num = 1107105244U;
			base..ctor();
			for (;;)
			{
				if (21CD4FB8 != null)
				{
					num = 992631U << (int)num;
					goto IL_20;
				}
				IL_4F:
				if (946085030U >= num)
				{
					continue;
				}
				num = (695033193U | num);
				num = (720011200U & num);
				this.33EE42D9 = 21CD4FB8;
				if ((60180235U ^ num) != 0U)
				{
					return;
				}
				IL_20:
				num = 1646207425U << (int)num;
				bool flag = 21CD4FB8 is ValueType;
				num ^= 602027037U;
				if (!flag)
				{
					break;
				}
				goto IL_4F;
			}
			num += 1079726315U;
			throw new ArgumentException();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00E78F14 File Offset: 0x00E75314
		public override Type 0B2A827C()
		{
			uint num = 1470701230U;
			RuntimeTypeHandle handle = typeof(ValueType).TypeHandle;
			num &= 1733245332U;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00E78F3C File Offset: 0x00E7533C
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.71755E30(this.33EE42D9);
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00E78F54 File Offset: 0x00E75354
		public override object 5049A7CC()
		{
			return this.33EE42D9;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00E78F70 File Offset: 0x00E75370
		public override void 62B618BD(object 59264B01)
		{
			uint num;
			do
			{
				num = 519447101U;
				if (59264B01 == null)
				{
					goto IL_40;
				}
				num = 1236159628U * num;
				bool flag = 59264B01 is ValueType;
				num = (714554557U & num);
				num += 4108586529U;
				if (flag)
				{
					goto IL_40;
				}
			}
			while (776896151U == num);
			throw new ArgumentException();
			IL_40:
			num %= 1408442992U;
			num += 759200695U;
			this.33EE42D9 = 59264B01;
		}

		// Token: 0x0400030E RID: 782
		private object 33EE42D9;
	}

	// Token: 0x02000062 RID: 98
	private sealed class 69732A42 : 6B147225.14B354D4
	{
		// Token: 0x06000501 RID: 1281 RVA: 0x00E78FD4 File Offset: 0x00E753D4
		public 69732A42(Array 7DF064C6)
		{
			uint num = 1924293350U;
			num |= 1148211255U;
			base..ctor();
			if ((num & 1327370071U) != 0U)
			{
				num >>= 7;
				num = (1197620414U | num);
				this.780F5ED5 = 7DF064C6;
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00E79018 File Offset: 0x00E75418
		public override Type 0B2A827C()
		{
			uint num = 2024737282U;
			RuntimeTypeHandle handle = typeof(Array).TypeHandle;
			num >>= 24;
			return Type.GetTypeFromHandle(handle);
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00E79040 File Offset: 0x00E75440
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1957042643U;
			num = 1314521856U * num;
			return new 6B147225.69732A42(this.780F5ED5);
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00E79068 File Offset: 0x00E75468
		public override object 5049A7CC()
		{
			return this.780F5ED5;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00E79084 File Offset: 0x00E75484
		public override void 62B618BD(object 5E192E4F)
		{
			this.780F5ED5 = (Array)5E192E4F;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00E790A4 File Offset: 0x00E754A4
		public override bool 93CE0566()
		{
			uint num = 56381912U;
			Array array = this.780F5ED5;
			object obj = null;
			num = 2005099818U * num;
			return array > obj;
		}

		// Token: 0x0400030F RID: 783
		private Array 780F5ED5;
	}

	// Token: 0x02000063 RID: 99
	private abstract class 44DE5061 : 6B147225.14B354D4
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00E790C8 File Offset: 0x00E754C8
		public override bool 684ED4C6()
		{
			return true;
		}
	}

	// Token: 0x02000064 RID: 100
	private sealed class 0EEF2230 : 6B147225.44DE5061
	{
		// Token: 0x06000509 RID: 1289 RVA: 0x00E790EC File Offset: 0x00E754EC
		public 0EEF2230(6B147225.68EF01A4 651A2A05)
		{
			uint num;
			do
			{
				num = 2067678496U;
				base..ctor();
				this.407702CD = 651A2A05;
			}
			while (691755217U == num);
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00E79118 File Offset: 0x00E75518
		public override Type 0B2A827C()
		{
			uint num = 319110551U;
			num %= 1739799168U;
			6B147225.68EF01A4 68EF01A = this.407702CD;
			num = (989533233U & num);
			return 68EF01A.0B2A827C();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00E79148 File Offset: 0x00E75548
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.0EEF2230(this.407702CD);
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00E79160 File Offset: 0x00E75560
		public override object 5049A7CC()
		{
			uint num = 267650874U;
			6B147225.68EF01A4 68EF01A = this.407702CD;
			num = 2110747051U << (int)num;
			return 68EF01A.5049A7CC();
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00E7918C File Offset: 0x00E7558C
		public override void 62B618BD(object 673C2CE4)
		{
			uint num = 1579616283U;
			if (num > 289494458U)
			{
				do
				{
					this.407702CD.62B618BD(673C2CE4);
				}
				while (num / 945758650U == 0U);
			}
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00E791C4 File Offset: 0x00E755C4
		public override bool 93CE0566()
		{
			uint num = 1742371134U;
			object obj = this.407702CD;
			num -= 1491562496U;
			return obj != null;
		}

		// Token: 0x04000310 RID: 784
		private 6B147225.68EF01A4 407702CD;
	}

	// Token: 0x02000065 RID: 101
	private sealed class 048D2534 : 6B147225.44DE5061
	{
		// Token: 0x0600050F RID: 1295 RVA: 0x00E791E8 File Offset: 0x00E755E8
		public 048D2534(6B147225.68EF01A4 10F56645, 6B147225.68EF01A4 578F3F33)
		{
			uint num = 1195521273U;
			do
			{
				num |= 655964721U;
				base..ctor();
				num = 192882351U + num;
				num <<= 5;
				this.775F2092 = 10F56645;
			}
			while (num == 1820083857U);
			this.53E66CD4 = 578F3F33;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00E79234 File Offset: 0x00E75634
		public override Type 0B2A827C()
		{
			return this.775F2092.0B2A827C();
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00E79254 File Offset: 0x00E75654
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1845911303U;
			6B147225.68EF01A4 10F = this.775F2092;
			num = (1680026281U | num);
			6B147225.68EF01A4 578F3F = this.53E66CD4;
			num = 481632972U >> (int)num;
			return new 6B147225.048D2534(10F, 578F3F);
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00E79290 File Offset: 0x00E75690
		public override object 5049A7CC()
		{
			uint num = 882705478U;
			6B147225.68EF01A4 68EF01A = this.775F2092;
			num += 1238455236U;
			return 68EF01A.5049A7CC();
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00E792B8 File Offset: 0x00E756B8
		public override void 62B618BD(object 68315628)
		{
			uint num = 913703382U;
			6B147225.68EF01A4 68EF01A = this.775F2092;
			num = 1218322929U * num;
			68EF01A.62B618BD(68315628);
			6B147225.68EF01A4 68EF01A2 = this.53E66CD4;
			num += 881726399U;
			68EF01A2.62B618BD(this.775F2092.5049A7CC());
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00E79300 File Offset: 0x00E75700
		public override bool 93CE0566()
		{
			uint num = 1214135481U;
			num %= 703464527U;
			object obj = this.775F2092;
			num %= 1742930357U;
			return obj != null;
		}

		// Token: 0x04000311 RID: 785
		private 6B147225.68EF01A4 775F2092;

		// Token: 0x04000312 RID: 786
		private 6B147225.68EF01A4 53E66CD4;
	}

	// Token: 0x02000066 RID: 102
	private sealed class 0A3736B6 : 6B147225.44DE5061
	{
		// Token: 0x06000515 RID: 1301 RVA: 0x00E7932C File Offset: 0x00E7572C
		public 0A3736B6(FieldInfo 2BB403FC, object 214D330D)
		{
			uint num = 1810512213U;
			do
			{
				num = 1316900391U << (int)num;
				base..ctor();
				num += 954101698U;
				num = (1676952749U | num);
				num %= 740717624U;
				this.0BF821A3 = 2BB403FC;
				num |= 1093565368U;
			}
			while (num % 1855411461U == 0U);
			do
			{
				this.42DD3D33 = 214D330D;
			}
			while (787098111U * num == 0U);
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00E7939C File Offset: 0x00E7579C
		public override Type 0B2A827C()
		{
			return this.0BF821A3.FieldType;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00E793BC File Offset: 0x00E757BC
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.0A3736B6(this.0BF821A3, this.42DD3D33);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00E793E0 File Offset: 0x00E757E0
		public override object 5049A7CC()
		{
			uint num = 1617044395U;
			num = 208540408U / num;
			FieldInfo fieldInfo = this.0BF821A3;
			num <<= 8;
			return fieldInfo.GetValue(this.42DD3D33);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00E79414 File Offset: 0x00E75814
		public override void 62B618BD(object 6C20339D)
		{
			uint num = 557008133U;
			FieldInfo fieldInfo = this.0BF821A3;
			num /= 507254247U;
			object obj = this.42DD3D33;
			num >>= 0;
			num *= 1769676323U;
			fieldInfo.SetValue(obj, 6C20339D);
		}

		// Token: 0x04000313 RID: 787
		private FieldInfo 0BF821A3;

		// Token: 0x04000314 RID: 788
		private object 42DD3D33;
	}

	// Token: 0x02000067 RID: 103
	private sealed class 66154DF0 : 6B147225.44DE5061
	{
		// Token: 0x0600051A RID: 1306 RVA: 0x00E79454 File Offset: 0x00E75854
		public 66154DF0(Array 304A372C, int 65A969F5)
		{
			uint num;
			do
			{
				base..ctor();
				num = 1824139286U;
				if ((889530623U ^ num) == 0U)
				{
					break;
				}
				num |= 598949323U;
				this.2BC82B87 = 304A372C;
			}
			while (61617116U >= num);
			this.2BFC2534 = 65A969F5;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00E7949C File Offset: 0x00E7589C
		public override Type 0B2A827C()
		{
			uint num = 1385899420U;
			num |= 1544510668U;
			Type type = this.2BC82B87.GetType();
			num <<= 27;
			return type.GetElementType();
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00E794D0 File Offset: 0x00E758D0
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.66154DF0(this.2BC82B87, this.2BFC2534);
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00E794F4 File Offset: 0x00E758F4
		public override object 5049A7CC()
		{
			uint num = 236466502U;
			num |= 1569788420U;
			Array array = this.2BC82B87;
			num = 771178058U % num;
			num &= 888883015U;
			int index = this.2BFC2534;
			num = 1547255980U / num;
			return array.GetValue(index);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00E79538 File Offset: 0x00E75938
		public override void 62B618BD(object 623B0C9D)
		{
			uint num = 1555647703U;
			if (1435334698U < num)
			{
				num >>= 20;
				Array array = this.2BC82B87;
				num = 798779897U * num;
				num += 1583419676U;
				num += 579606659U;
				int index = this.2BFC2534;
				num = (242836885U ^ num);
				array.SetValue(623B0C9D, index);
			}
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00E79590 File Offset: 0x00E75990
		public override UIntPtr 2B2A13B3()
		{
			string name = "";
			Type typeFromHandle = typeof(UIntPtr);
			Type[] array = new Type[2];
			int num = 0;
			uint num2 = 1394087723U;
			object obj = this.2BC82B87;
			num2 <<= 7;
			array[num] = obj.GetType();
			num2 = 1688339934U << (int)num2;
			num2 = 515584743U + num2;
			int num3 = (int)(num2 ^ 2203924676U);
			Type typeFromHandle2 = typeof(int);
			num2 = 2038637226U * num2;
			array[num3] = typeFromHandle2;
			DynamicMethod dynamicMethod = new DynamicMethod(name, typeFromHandle, array, typeof(6B147225).Module, num2 + 952050479U != 0U);
			num2 >>= 0;
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			OpCode ldarg = OpCodes.Ldarg;
			num2 = 326205343U + num2;
			ilgenerator.Emit(ldarg, (int)(num2 - 3669122161U));
			num2 %= 1348281387U;
			OpCode ldarg2 = OpCodes.Ldarg;
			num2 = 481700877U >> (int)num2;
			int arg = (int)(num2 - 2U);
			num2 %= 1630870366U;
			ilgenerator.Emit(ldarg2, arg);
			OpCode ldelema = OpCodes.Ldelema;
			object obj2 = this.2BC82B87;
			num2 <<= 30;
			ilgenerator.Emit(ldelema, obj2.GetType().GetElementType());
			num2 = (1868115460U ^ num2);
			ilgenerator.Emit(OpCodes.Conv_U);
			ilgenerator.Emit(OpCodes.Ret);
			object obj3 = null;
			object[] array2 = new object[num2 ^ 2941857286U];
			num2 <<= 28;
			int num4 = (int)(num2 + 3221225472U);
			num2 = 2131824194U * num2;
			num2 |= 415134292U;
			object obj4 = this.2BC82B87;
			num2 %= 537412148U;
			array2[num4] = obj4;
			num2 = 1256982328U / num2;
			int num5 = (int)(num2 ^ 2U);
			int num6 = this.2BFC2534;
			num2 &= 2072265144U;
			object obj5 = num6;
			num2 -= 842930208U;
			array2[num5] = obj5;
			num2 = 1495102127U - num2;
			object obj6 = dynamicMethod.Invoke(obj3, array2);
			num2 |= 1775908024U;
			return (UIntPtr)obj6;
		}

		// Token: 0x04000315 RID: 789
		private Array 2BC82B87;

		// Token: 0x04000316 RID: 790
		private int 2BFC2534;
	}

	// Token: 0x02000068 RID: 104
	private sealed class 1CB553EA : 6B147225.14B354D4
	{
		// Token: 0x06000520 RID: 1312 RVA: 0x00E79734 File Offset: 0x00E75B34
		public 1CB553EA(MethodBase 3F93496E)
		{
			uint num;
			do
			{
				num = 673659144U;
				base..ctor();
				num *= 400169651U;
				this.0C461709 = 3F93496E;
			}
			while (num - 971337723U == 0U);
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00E79768 File Offset: 0x00E75B68
		public override Type 0B2A827C()
		{
			return typeof(MethodBase);
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00E79788 File Offset: 0x00E75B88
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.1CB553EA(this.0C461709);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00E797A8 File Offset: 0x00E75BA8
		public override object 5049A7CC()
		{
			return this.0C461709;
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00E797C4 File Offset: 0x00E75BC4
		public override void 62B618BD(object 034A55A1)
		{
			uint num = 793978238U;
			MethodBase methodBase = (MethodBase)034A55A1;
			num = 2051685990U >> (int)num;
			this.0C461709 = methodBase;
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00E797F4 File Offset: 0x00E75BF4
		public override bool 93CE0566()
		{
			uint num = 1196701922U;
			object obj = this.0C461709;
			num = 772877601U * num;
			return obj != null;
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00E79818 File Offset: 0x00E75C18
		public override IntPtr B74C1556()
		{
			uint num = 1260730902U;
			MethodBase methodBase = this.0C461709;
			num ^= 596580378U;
			RuntimeMethodHandle methodHandle = methodBase.MethodHandle;
			num = 1356153862U + num;
			return methodHandle.GetFunctionPointer();
		}

		// Token: 0x04000317 RID: 791
		private MethodBase 0C461709;
	}

	// Token: 0x02000069 RID: 105
	private sealed class 039A0C85 : 6B147225.14B354D4
	{
		// Token: 0x06000527 RID: 1319 RVA: 0x00E79850 File Offset: 0x00E75C50
		public 039A0C85(IntPtr 20D63C15)
		{
			uint num = 1993820299U;
			num = 1923764407U % num;
			this.111C54A9 = 20D63C15;
			num |= 1245457473U;
			num &= 1559064964U;
			6B147225.68EF01A4 68EF01A = 6B147225.039A0C85.665D19BD(this.111C54A9);
			num = (850792656U ^ num);
			this.3F54708C = 68EF01A;
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00E798A4 File Offset: 0x00E75CA4
		private static 6B147225.68EF01A4 665D19BD(IntPtr 5C295C27)
		{
			uint num = 1791125666U;
			do
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 1791125670U;
				num *= 167927429U;
				if (size != num2)
				{
					goto IL_3F;
				}
			}
			while (1264389000U >= num);
			int 5EEF = 5C295C27.ToInt32();
			num %= 929570973U;
			return new 6B147225.1F462BA1(5EEF);
			IL_3F:
			num %= 1565031952U;
			long 7B2365FA = 5C295C27.ToInt64();
			num = 150079443U / num;
			return new 6B147225.58E136FA(7B2365FA);
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00E7990C File Offset: 0x00E75D0C
		public override Type 0B2A827C()
		{
			return typeof(IntPtr);
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00E7992C File Offset: 0x00E75D2C
		public override TypeCode 39440F35()
		{
			uint num = 898374132U;
			num = (197528499U | num);
			return this.3F54708C.39440F35();
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00E79954 File Offset: 0x00E75D54
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.039A0C85(this.111C54A9);
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00E79974 File Offset: 0x00E75D74
		public override object 5049A7CC()
		{
			uint num = 1700537620U;
			IntPtr intPtr = this.111C54A9;
			num ^= 122362528U;
			return intPtr;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00E7999C File Offset: 0x00E75D9C
		public override void 62B618BD(object 5A6D480D)
		{
			uint num = 1865225633U;
			if (906377677U <= num)
			{
				num = 505814152U << (int)num;
				this.111C54A9 = (IntPtr)5A6D480D;
				if (num / 1240402366U == 0U)
				{
					do
					{
						num >>= 21;
						IntPtr 5C295C = this.111C54A9;
						num = (112208891U | num);
						6B147225.68EF01A4 68EF01A = 6B147225.039A0C85.665D19BD(5C295C);
						num |= 248725430U;
						this.3F54708C = 68EF01A;
					}
					while ((361528495U ^ num) == 0U);
				}
			}
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00E79A18 File Offset: 0x00E75E18
		public override bool 93CE0566()
		{
			return this.111C54A9 != IntPtr.Zero;
		}

		// Token: 0x0600052F RID: 1327 RVA: 0x00E79A38 File Offset: 0x00E75E38
		public override sbyte 060AA47D()
		{
			return this.3F54708C.060AA47D();
		}

		// Token: 0x06000530 RID: 1328 RVA: 0x00E79A58 File Offset: 0x00E75E58
		public override short E915D835()
		{
			uint num = 737238864U;
			num &= 639776899U;
			return this.3F54708C.E915D835();
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00E79A80 File Offset: 0x00E75E80
		public override int EDAECC1C()
		{
			return this.3F54708C.EDAECC1C();
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00E79AA0 File Offset: 0x00E75EA0
		public override long DA78F42D()
		{
			return this.3F54708C.DA78F42D();
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00E79AC0 File Offset: 0x00E75EC0
		public override byte 4D994718()
		{
			uint num = 201796367U;
			6B147225.68EF01A4 68EF01A = this.3F54708C;
			num -= 1475566898U;
			return 68EF01A.4D994718();
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x00E79AE8 File Offset: 0x00E75EE8
		public override ushort D20A0A8F()
		{
			return this.3F54708C.D20A0A8F();
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00E79B08 File Offset: 0x00E75F08
		public override uint 786A7318()
		{
			uint num = 1628521025U;
			num ^= 189992547U;
			return this.3F54708C.786A7318();
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00E79B30 File Offset: 0x00E75F30
		public override ulong 5C835FEF()
		{
			return this.3F54708C.5C835FEF();
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x00E79B50 File Offset: 0x00E75F50
		public override float B55103C5()
		{
			uint num = 238189379U;
			6B147225.68EF01A4 68EF01A = this.3F54708C;
			num = 563875581U / num;
			return 68EF01A.B55103C5();
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00E79B78 File Offset: 0x00E75F78
		public override double 8CC4ACA1()
		{
			uint num = 1429873414U;
			num = (258948760U | num);
			return this.3F54708C.8CC4ACA1();
		}

		// Token: 0x06000539 RID: 1337 RVA: 0x00E79BA0 File Offset: 0x00E75FA0
		public override IntPtr B74C1556()
		{
			return this.111C54A9;
		}

		// Token: 0x0600053A RID: 1338 RVA: 0x00E79BB4 File Offset: 0x00E75FB4
		public override UIntPtr 2B2A13B3()
		{
			return this.3F54708C.2B2A13B3();
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00E79BCC File Offset: 0x00E75FCC
		public unsafe override void* 477D7F8C()
		{
			return this.111C54A9.ToPointer();
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00E79BEC File Offset: 0x00E75FEC
		public override object CA964614(Type 5C450506, bool 24775B3A)
		{
			uint num = 87434751U;
			6B147225.68EF01A4 68EF01A = this.3F54708C;
			num /= 815231206U;
			num = (366771171U ^ num);
			num ^= 1713917661U;
			return 68EF01A.CA964614(5C450506, 24775B3A);
		}

		// Token: 0x04000318 RID: 792
		private IntPtr 111C54A9;

		// Token: 0x04000319 RID: 793
		private 6B147225.68EF01A4 3F54708C;
	}

	// Token: 0x0200006A RID: 106
	private sealed class 15AB16A8 : 6B147225.14B354D4
	{
		// Token: 0x0600053D RID: 1341 RVA: 0x00E79C24 File Offset: 0x00E76024
		public 15AB16A8(UIntPtr 67895BD3)
		{
			uint num;
			do
			{
				num = 238447152U;
				base..ctor();
				num = 1732796415U % num;
				num %= 2010061975U;
				this.555F446F = 67895BD3;
				num += 283606445U;
			}
			while (888160589U == num);
			num += 1336173964U;
			UIntPtr 6F0A = this.555F446F;
			num ^= 1113666342U;
			6B147225.68EF01A4 68EF01A = 6B147225.15AB16A8.3290726D(6F0A);
			num = 731382615U * num;
			this.38F72CEC = 68EF01A;
		}

		// Token: 0x0600053E RID: 1342 RVA: 0x00E79C90 File Offset: 0x00E76090
		private static 6B147225.68EF01A4 3290726D(UIntPtr 6F0A6451)
		{
			uint num = 2016367518U;
			if (297086111U >= num)
			{
				goto IL_5A;
			}
			do
			{
				int size = IntPtr.Size;
				uint num2 = num ^ 2016367514U;
				num = 1617510166U % num;
				if (size != num2)
				{
					goto IL_5A;
				}
				num *= 508383861U;
			}
			while (num >= 1561230813U);
			IL_3D:
			num = (643695699U ^ num);
			int 5EEF = (int)6F0A6451.ToUInt32();
			num = 350110915U + num;
			return new 6B147225.1F462BA1(5EEF);
			IL_5A:
			if (180563811U < num)
			{
				long 7B2365FA = (long)6F0A6451.ToUInt64();
				num = 1104757001U << (int)num;
				return new 6B147225.58E136FA(7B2365FA);
			}
			goto IL_3D;
		}

		// Token: 0x0600053F RID: 1343 RVA: 0x00E79D1C File Offset: 0x00E7611C
		public override Type 0B2A827C()
		{
			return typeof(UIntPtr);
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x00E79D34 File Offset: 0x00E76134
		public override TypeCode 39440F35()
		{
			return this.38F72CEC.39440F35();
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00E79D54 File Offset: 0x00E76154
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.15AB16A8(this.555F446F);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00E79D74 File Offset: 0x00E76174
		public override object 5049A7CC()
		{
			return this.555F446F;
		}

		// Token: 0x06000543 RID: 1347 RVA: 0x00E79D94 File Offset: 0x00E76194
		public override void 62B618BD(object 3A241068)
		{
			uint num = 1823736708U;
			if (num >= 1635719249U)
			{
				num *= 556353514U;
				UIntPtr uintPtr = (UIntPtr)3A241068;
				num = 785983058U - num;
				this.555F446F = uintPtr;
			}
			num = (112657737U & num);
			UIntPtr 6F0A = this.555F446F;
			num = 1177708809U * num;
			6B147225.68EF01A4 68EF01A = 6B147225.15AB16A8.3290726D(6F0A);
			num = (144378977U & num);
			this.38F72CEC = 68EF01A;
		}

		// Token: 0x06000544 RID: 1348 RVA: 0x00E79DF8 File Offset: 0x00E761F8
		public override bool 93CE0566()
		{
			return this.555F446F != UIntPtr.Zero;
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00E79E18 File Offset: 0x00E76218
		public override sbyte 060AA47D()
		{
			uint num = 815597354U;
			num = (600209359U | num);
			6B147225.68EF01A4 68EF01A = this.38F72CEC;
			num = (1826508074U & num);
			return 68EF01A.060AA47D();
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00E79E48 File Offset: 0x00E76248
		public override short E915D835()
		{
			uint num = 532358234U;
			num -= 425019506U;
			return this.38F72CEC.E915D835();
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00E79E70 File Offset: 0x00E76270
		public override int EDAECC1C()
		{
			return this.38F72CEC.EDAECC1C();
		}

		// Token: 0x06000548 RID: 1352 RVA: 0x00E79E90 File Offset: 0x00E76290
		public override long DA78F42D()
		{
			return this.38F72CEC.DA78F42D();
		}

		// Token: 0x06000549 RID: 1353 RVA: 0x00E79EB0 File Offset: 0x00E762B0
		public override byte 4D994718()
		{
			return this.38F72CEC.4D994718();
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00E79ED0 File Offset: 0x00E762D0
		public override ushort D20A0A8F()
		{
			return this.38F72CEC.D20A0A8F();
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00E79EF0 File Offset: 0x00E762F0
		public override uint 786A7318()
		{
			uint num = 1799388457U;
			num /= 199185948U;
			return this.38F72CEC.786A7318();
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00E79F18 File Offset: 0x00E76318
		public override ulong 5C835FEF()
		{
			uint num = 75067169U;
			6B147225.68EF01A4 68EF01A = this.38F72CEC;
			num = 1656898821U - num;
			return 68EF01A.5C835FEF();
		}

		// Token: 0x0600054D RID: 1357 RVA: 0x00E79F40 File Offset: 0x00E76340
		public override float B55103C5()
		{
			return this.38F72CEC.B55103C5();
		}

		// Token: 0x0600054E RID: 1358 RVA: 0x00E79F58 File Offset: 0x00E76358
		public override double 8CC4ACA1()
		{
			uint num = 1330137180U;
			num <<= 10;
			return this.38F72CEC.8CC4ACA1();
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00E79F80 File Offset: 0x00E76380
		public override IntPtr B74C1556()
		{
			uint num = 1637697823U;
			num *= 859916366U;
			6B147225.68EF01A4 68EF01A = this.38F72CEC;
			num = 173764944U % num;
			return 68EF01A.B74C1556();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00E79FB0 File Offset: 0x00E763B0
		public override UIntPtr 2B2A13B3()
		{
			return this.555F446F;
		}

		// Token: 0x06000551 RID: 1361 RVA: 0x00E79FCC File Offset: 0x00E763CC
		public unsafe override void* 477D7F8C()
		{
			return this.555F446F.ToPointer();
		}

		// Token: 0x06000552 RID: 1362 RVA: 0x00E79FEC File Offset: 0x00E763EC
		public override object CA964614(Type 5C564A8E, bool 0F4D4289)
		{
			uint num = 320961974U;
			6B147225.68EF01A4 68EF01A = this.38F72CEC;
			num %= 1129787896U;
			num = 1339300186U * num;
			return 68EF01A.CA964614(5C564A8E, 0F4D4289);
		}

		// Token: 0x0400031A RID: 794
		private UIntPtr 555F446F;

		// Token: 0x0400031B RID: 795
		private 6B147225.68EF01A4 38F72CEC;
	}

	// Token: 0x0200006B RID: 107
	private sealed class 58510C83 : 6B147225.14B354D4
	{
		// Token: 0x06000553 RID: 1363 RVA: 0x00E7A01C File Offset: 0x00E7641C
		public 58510C83(Enum 6DB6533B)
		{
			uint num;
			for (;;)
			{
				base..ctor();
				num = 1751676085U;
				if (598606717U >> (int)num != 0U)
				{
					num -= 619667471U;
					if (6DB6533B == null)
					{
						break;
					}
					if ((num & 1436499996U) != 0U)
					{
						num -= 396323542U;
						num %= 994976247U;
						this.14501456 = 6DB6533B;
						num *= 1503417554U;
						if (1947807537U != num)
						{
							goto Block_3;
						}
					}
				}
			}
			num = (926829527U | num);
			throw new ArgumentException();
			Block_3:
			num &= 1415204808U;
			this.5EB0488E = 6B147225.58510C83.283B59D5(this.14501456);
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00E7A0B4 File Offset: 0x00E764B4
		private static 6B147225.68EF01A4 283B59D5(Enum 2DA07241)
		{
			uint num;
			for (;;)
			{
				TypeCode typeCode = 2DA07241.GetTypeCode();
				num = 660818686U;
				TypeCode typeCode2 = typeCode;
				for (;;)
				{
					uint num2 = (uint)typeCode2;
					num = 834492750U << (int)num;
					uint num3 = num2 - (num ^ 2147483653U);
					num %= 1941664519U;
					switch (num3)
					{
					case 0:
					case 2:
					case 4:
						goto IL_81;
					case 1:
					case 3:
					case 5:
						goto IL_62;
					case 6:
						if ((1761639072U & num) != 0U)
						{
							goto Block_3;
						}
						continue;
					case 7:
						goto IL_8D;
					}
					break;
				}
				if (418413004U / num != 0U)
				{
					break;
				}
				continue;
				IL_8D:
				if (num != 533024162U)
				{
					goto Block_2;
				}
			}
			IL_5D:
			num |= 1883789852U;
			throw new InvalidOperationException();
			IL_62:
			num *= 252520393U;
			if (1322542232U <= num)
			{
				return new 6B147225.1F462BA1((int)Convert.ToUInt32(2DA07241));
			}
			goto IL_5D;
			IL_81:
			return new 6B147225.1F462BA1(Convert.ToInt32(2DA07241));
			Block_2:
			return new 6B147225.58E136FA((long)Convert.ToUInt64(2DA07241));
			Block_3:
			num &= 1433293619U;
			long 7B2365FA = Convert.ToInt64(2DA07241);
			num <<= 14;
			return new 6B147225.58E136FA(7B2365FA);
		}

		// Token: 0x06000555 RID: 1365 RVA: 0x00E7A19C File Offset: 0x00E7659C
		public override 6B147225.68EF01A4 0C5BC4A1()
		{
			uint num = 1046561320U;
			6B147225.68EF01A4 68EF01A = this.5EB0488E;
			num >>= 8;
			return 68EF01A.0C5BC4A1();
		}

		// Token: 0x06000556 RID: 1366 RVA: 0x00E7A1C4 File Offset: 0x00E765C4
		public override Type 0B2A827C()
		{
			uint num = 53635116U;
			num %= 714635254U;
			object obj = this.14501456;
			num ^= 1310607109U;
			return obj.GetType();
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x00E7A1F4 File Offset: 0x00E765F4
		public override TypeCode 39440F35()
		{
			uint num = 158625049U;
			num ^= 327885505U;
			return this.5EB0488E.39440F35();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00E7A21C File Offset: 0x00E7661C
		public override 6B147225.68EF01A4 2EEBA499()
		{
			return new 6B147225.58510C83(this.14501456);
		}

		// Token: 0x06000559 RID: 1369 RVA: 0x00E7A234 File Offset: 0x00E76634
		public override object 5049A7CC()
		{
			return this.14501456;
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00E7A250 File Offset: 0x00E76650
		public override void 62B618BD(object 0ADF27B4)
		{
			uint num = 1066564573U;
			num -= 334259432U;
			if (0ADF27B4 == null)
			{
				num = 274008816U >> (int)num;
				if (1979188303U / num != 0U)
				{
					throw new ArgumentException();
				}
			}
			else
			{
				num = (1958364184U & num);
				num %= 1881757899U;
				this.14501456 = (Enum)0ADF27B4;
				num |= 2073504790U;
				num = 1956017656U >> (int)num;
				6B147225.68EF01A4 68EF01A = 6B147225.58510C83.283B59D5(this.14501456);
				num = 2063211963U + num;
				this.5EB0488E = 68EF01A;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00E7A2DC File Offset: 0x00E766DC
		public override byte 4D994718()
		{
			uint num = 1414737211U;
			num %= 547313635U;
			return this.5EB0488E.4D994718();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00E7A304 File Offset: 0x00E76704
		public override sbyte 060AA47D()
		{
			uint num = 873079254U;
			6B147225.68EF01A4 68EF01A = this.5EB0488E;
			num = 896273872U * num;
			return 68EF01A.060AA47D();
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00E7A32C File Offset: 0x00E7672C
		public override short E915D835()
		{
			uint num = 117668439U;
			num *= 985480841U;
			6B147225.68EF01A4 68EF01A = this.5EB0488E;
			num >>= 6;
			return 68EF01A.E915D835();
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00E7A35C File Offset: 0x00E7675C
		public override ushort D20A0A8F()
		{
			return this.5EB0488E.D20A0A8F();
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00E7A37C File Offset: 0x00E7677C
		public override int EDAECC1C()
		{
			uint num = 52388436U;
			6B147225.68EF01A4 68EF01A = this.5EB0488E;
			num %= 688290753U;
			return 68EF01A.EDAECC1C();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00E7A3A4 File Offset: 0x00E767A4
		public override uint 786A7318()
		{
			return this.5EB0488E.786A7318();
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00E7A3BC File Offset: 0x00E767BC
		public override long DA78F42D()
		{
			uint num = 1675757828U;
			num = 136404398U >> (int)num;
			return this.5EB0488E.DA78F42D();
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00E7A3E8 File Offset: 0x00E767E8
		public override ulong 5C835FEF()
		{
			return this.5EB0488E.5C835FEF();
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00E7A400 File Offset: 0x00E76800
		public override float B55103C5()
		{
			return this.5EB0488E.B55103C5();
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00E7A420 File Offset: 0x00E76820
		public override double 8CC4ACA1()
		{
			return this.5EB0488E.8CC4ACA1();
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00E7A440 File Offset: 0x00E76840
		public override IntPtr B74C1556()
		{
			return new IntPtr((IntPtr.Size == 4) ? ((long)this.EDAECC1C()) : this.DA78F42D());
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00E7A478 File Offset: 0x00E76878
		public override UIntPtr 2B2A13B3()
		{
			uint num2;
			for (;;)
			{
				int size = IntPtr.Size;
				int num = 4;
				num2 = 1948397649U;
				if (size != num)
				{
					if (num2 > 286861398U)
					{
						break;
					}
				}
				else if ((2079160462U ^ num2) != 0U)
				{
					goto Block_2;
				}
			}
			ulong value = this.5C835FEF();
			goto IL_52;
			Block_2:
			num2 *= 1526752741U;
			ulong num3 = (ulong)this.786A7318();
			num2 = (1808488300U & num2);
			value = num3;
			num2 += 1235299053U;
			IL_52:
			return new UIntPtr(value);
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00E7A4DC File Offset: 0x00E768DC
		public override object CA964614(Type 0E9A0D64, bool 738562D2)
		{
			uint num = 1497788408U;
			6B147225.68EF01A4 68EF01A = this.5EB0488E;
			num = 79705773U >> (int)num;
			num = 1578894508U % num;
			return 68EF01A.CA964614(0E9A0D64, 738562D2);
		}

		// Token: 0x0400031C RID: 796
		private Enum 14501456;

		// Token: 0x0400031D RID: 797
		private 6B147225.68EF01A4 5EB0488E;
	}

	// Token: 0x0200006C RID: 108
	private sealed class 77A20E0A : 6B147225.44DE5061
	{
		// Token: 0x06000568 RID: 1384 RVA: 0x00E7A514 File Offset: 0x00E76914
		public 77A20E0A(IntPtr 62D85391, Type 4E6B677F)
		{
			uint num = 1657219320U;
			base..ctor();
			num %= 1177769422U;
			this.5E030C3A = 62D85391;
			do
			{
				num *= 1362452166U;
				num -= 453313351U;
				this.48CE229B = 4E6B677F;
			}
			while ((1434079665U & num) == 0U);
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00E7A560 File Offset: 0x00E76960
		public override Type 0B2A827C()
		{
			return typeof(Pointer);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00E7A578 File Offset: 0x00E76978
		public override TypeCode 39440F35()
		{
			return TypeCode.Empty;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00E7A588 File Offset: 0x00E76988
		public override 6B147225.68EF01A4 2EEBA499()
		{
			uint num = 1587222361U;
			num /= 1357409965U;
			IntPtr 62D = this.5E030C3A;
			num = 1978022845U % num;
			return new 6B147225.77A20E0A(62D, this.48CE229B);
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00E7A5BC File Offset: 0x00E769BC
		public override object 5049A7CC()
		{
			uint num;
			for (;;)
			{
				bool isValueType = this.48CE229B.IsValueType;
				num = 2129814067U;
				if (isValueType)
				{
					break;
				}
				if (857758485U <= num)
				{
					goto Block_1;
				}
			}
			num ^= 354823651U;
			num /= 1585599426U;
			IntPtr ptr = this.5E030C3A;
			num >>= 27;
			Type structureType = this.48CE229B;
			num -= 2119451608U;
			return Marshal.PtrToStructure(ptr, structureType);
			Block_1:
			throw new InvalidOperationException();
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x00E7A624 File Offset: 0x00E76A24
		public override void 62B618BD(object 6D4A5F01)
		{
			uint num;
			for (;;)
			{
				num = 1865224319U;
				TypeCode typeCode;
				if (6D4A5F01 == null)
				{
					num ^= 1831622333U;
					if (num + 1351621311U != 0U)
					{
						break;
					}
				}
				else
				{
					num = 856043505U / num;
					if (953091643U == num)
					{
						break;
					}
					Type type = this.48CE229B;
					num %= 1650592670U;
					bool isValueType = type.IsValueType;
					num = (1089344440U ^ num);
					if (isValueType)
					{
						goto Block_2;
					}
					num = (528881784U & num);
					num /= 1192844267U;
					Type type2 = 6D4A5F01.GetType();
					num = 1428499112U * num;
					typeCode = Type.GetTypeCode(type2);
					num /= 959525060U;
					if (2136759235U == num)
					{
						return;
					}
				}
				for (;;)
				{
					object obj = typeCode;
					object obj2 = num + 4U;
					num = (1614703076U | num);
					object obj3 = obj - obj2;
					num >>= 12;
					switch (obj3)
					{
					case 0:
						goto IL_18D;
					case 1:
						goto IL_124;
					case 2:
						num -= 1662661321U;
						if ((160984271U ^ num) != 0U)
						{
							goto Block_5;
						}
						continue;
					case 3:
						goto IL_1CD;
					case 4:
						goto IL_1F9;
					case 5:
						goto IL_224;
					case 6:
						goto IL_24E;
					case 7:
						goto IL_294;
					case 8:
						goto IL_2C5;
					case 9:
						goto IL_309;
					case 10:
						goto IL_33C;
					}
					goto Block_3;
				}
				IL_1CD:
				num = (247091384U | num);
				Marshal.WriteInt16(this.5E030C3A, Convert.ToInt16(6D4A5F01));
				if (1569598771 << (int)num != 0)
				{
					return;
				}
				continue;
				IL_24E:
				num >>= 27;
				num |= 1794783514U;
				IntPtr ptr = this.5E030C3A;
				num = 1341159398U + num;
				num = 1187930861U - num;
				int val = (int)Convert.ToUInt32(6D4A5F01);
				num = 1791833349U / num;
				Marshal.WriteInt32(ptr, val);
				if (num >> 16 == 0U)
				{
					return;
				}
				continue;
				IL_294:
				if (1920301149U * num == 0U)
				{
					continue;
				}
				num = 347952441U % num;
				Marshal.WriteInt64(this.5E030C3A, Convert.ToInt64(6D4A5F01));
				if (num != 2027313205U)
				{
					return;
				}
				continue;
				IL_2C5:
				num = 1298859079U >> (int)num;
				if ((num ^ 1992708233U) != 0U)
				{
					goto Block_12;
				}
				continue;
				IL_33C:
				num = (1506439548U | num);
				num = 1454929491U * num;
				IntPtr ptr2 = this.5E030C3A;
				num ^= 1683380926U;
				double value = Convert.ToDouble(6D4A5F01);
				num = 450564277U - num;
				Marshal.WriteInt64(ptr2, BitConverter.ToInt64(BitConverter.GetBytes(value), (int)(num ^ 2100959953U)));
				if ((num ^ 1676363477U) != 0U)
				{
					return;
				}
			}
			IL_20:
			throw new ArgumentException();
			Block_2:
			num = 1769825099U >> (int)num;
			IL_67:
			num <<= 13;
			IntPtr ptr3 = this.5E030C3A;
			num = (884038101U ^ num);
			bool fDeleteOld = num + 3410200107U != 0U;
			num = (1737709340U ^ num);
			Marshal.StructureToPtr(6D4A5F01, ptr3, fDeleteOld);
			return;
			Block_3:
			if (1269520501U > num && num * 943802741U != 0U)
			{
				throw new ArgumentException();
			}
			goto IL_20;
			IL_124:
			num = 93521782U - num;
			IntPtr ptr4 = this.5E030C3A;
			num = 1299787017U * num;
			byte b = (byte)Convert.ToSByte(6D4A5F01);
			num *= 52915121U;
			byte val2 = b;
			num &= 48640364U;
			Marshal.WriteByte(ptr4, val2);
			return;
			Block_5:
			IntPtr ptr5 = this.5E030C3A;
			num %= 821839014U;
			num -= 695346019U;
			Marshal.WriteByte(ptr5, Convert.ToByte(6D4A5F01));
			return;
			IL_18D:
			num = (828261493U & num);
			if (1589461275U == num)
			{
				goto IL_67;
			}
			IntPtr ptr6 = this.5E030C3A;
			num -= 822154655U;
			char val3 = Convert.ToChar(6D4A5F01);
			num ^= 563420789U;
			Marshal.WriteInt16(ptr6, val3);
			if (num >= 282020856U)
			{
				return;
			}
			goto IL_20;
			IL_1F9:
			num = 1538286909U * num;
			IntPtr ptr7 = this.5E030C3A;
			short num2 = (short)Convert.ToUInt16(6D4A5F01);
			num += 1317568212U;
			short val4 = num2;
			num = 1213415596U / num;
			Marshal.WriteInt16(ptr7, val4);
			return;
			IL_224:
			num = 415062012U + num;
			IntPtr ptr8 = this.5E030C3A;
			num = 1190537888U + num;
			num = (1144075011U ^ num);
			Marshal.WriteInt32(ptr8, Convert.ToInt32(6D4A5F01));
			return;
			Block_12:
			num = 2088596728U % num;
			IntPtr ptr9 = this.5E030C3A;
			num = 1414811676U * num;
			num = 513044347U * num;
			Marshal.WriteInt64(ptr9, (long)Convert.ToUInt64(6D4A5F01));
			return;
			IL_309:
			num = (931279138U ^ num);
			IntPtr ptr10 = this.5E030C3A;
			float value2 = Convert.ToSingle(6D4A5F01);
			num = 1949437891U - num;
			Marshal.WriteInt32(ptr10, BitConverter.ToInt32(BitConverter.GetBytes(value2), (int)(num ^ 1018027263U)));
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x00E7A9D0 File Offset: 0x00E76DD0
		public override sbyte 060AA47D()
		{
			uint num = 951667626U;
			sbyte b = (sbyte)Marshal.ReadByte(this.5E030C3A);
			num ^= 245661153U;
			return b;
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00E7A9F8 File Offset: 0x00E76DF8
		public override short E915D835()
		{
			uint num = 1698583979U;
			num >>= 10;
			IntPtr ptr = this.5E030C3A;
			num = 2098137540U % num;
			return Marshal.ReadInt16(ptr);
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00E7AA28 File Offset: 0x00E76E28
		public override int EDAECC1C()
		{
			return Marshal.ReadInt32(this.5E030C3A);
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00E7AA48 File Offset: 0x00E76E48
		public override long DA78F42D()
		{
			return Marshal.ReadInt64(this.5E030C3A);
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00E7AA60 File Offset: 0x00E76E60
		public override char F3CAAB92()
		{
			return (char)Marshal.ReadInt16(this.5E030C3A);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00E7AA80 File Offset: 0x00E76E80
		public override byte 4D994718()
		{
			return Marshal.ReadByte(this.5E030C3A);
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00E7AA98 File Offset: 0x00E76E98
		public override ushort D20A0A8F()
		{
			uint num = 343304134U;
			IntPtr ptr = this.5E030C3A;
			num >>= 26;
			return (ushort)Marshal.ReadInt16(ptr);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00E7AAC0 File Offset: 0x00E76EC0
		public override uint 786A7318()
		{
			return (uint)Marshal.ReadInt32(this.5E030C3A);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00E7AAD8 File Offset: 0x00E76ED8
		public override ulong 5C835FEF()
		{
			return (ulong)Marshal.ReadInt64(this.5E030C3A);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00E7AAF8 File Offset: 0x00E76EF8
		public override float B55103C5()
		{
			uint num = 1176978377U;
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt32(this.5E030C3A));
			num ^= 889741097U;
			int startIndex = (int)(num - 1932467424U);
			num &= 876827085U;
			return BitConverter.ToSingle(bytes, startIndex);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00E7AB38 File Offset: 0x00E76F38
		public override double 8CC4ACA1()
		{
			IntPtr ptr = this.5E030C3A;
			uint num = 282134616U;
			byte[] bytes = BitConverter.GetBytes(Marshal.ReadInt64(ptr));
			num += 1699311317U;
			return BitConverter.ToDouble(bytes, (int)(num - 1981445933U));
		}

		// Token: 0x06000579 RID: 1401 RVA: 0x00E7AB70 File Offset: 0x00E76F70
		public override IntPtr B74C1556()
		{
			uint num;
			long value;
			if (IntPtr.Size != 4)
			{
				num = 282081286U;
				value = Marshal.ReadInt64(this.5E030C3A);
			}
			else
			{
				num = 666577424U;
				IntPtr ptr = this.5E030C3A;
				num -= 1834945652U;
				long num2 = (long)Marshal.ReadInt32(ptr);
				num = 1808039225U - num;
				value = num2;
				num ^= 2713216923U;
			}
			num -= 312019729U;
			return new IntPtr(value);
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00E7ABD8 File Offset: 0x00E76FD8
		public override UIntPtr 2B2A13B3()
		{
			uint size = (uint)IntPtr.Size;
			uint num = 1193155322U;
			if (size == num - 1193155318U)
			{
				goto IL_48;
			}
			num /= 1392921037U;
			if (num >= 1604595027U)
			{
				goto IL_48;
			}
			IL_2A:
			num = 658988585U >> (int)num;
			ulong value = (ulong)Marshal.ReadInt64(this.5E030C3A);
			goto IL_78;
			IL_48:
			if ((num & 1809851244U) == 0U)
			{
				goto IL_2A;
			}
			IntPtr ptr = this.5E030C3A;
			num = (2126141142U & num);
			ulong num2 = (ulong)Marshal.ReadInt32(ptr);
			num = (872288876U & num);
			value = num2;
			num ^= 626871401U;
			IL_78:
			num = 1100770395U % num;
			return new UIntPtr(value);
		}

		// Token: 0x0400031E RID: 798
		private IntPtr 5E030C3A;

		// Token: 0x0400031F RID: 799
		private Type 48CE229B;
	}

	// Token: 0x0200006D RID: 109
	private sealed class 770962F3
	{
		// Token: 0x0600057B RID: 1403 RVA: 0x00E7AC6C File Offset: 0x00E7706C
		public 770962F3(byte 0775334E, int 2E131509, int 23CB1046)
		{
			uint num = 1470837366U;
			if (237053005U + num == 0U)
			{
				goto IL_20;
			}
			IL_12:
			base..ctor();
			num &= 664683866U;
			IL_20:
			this.158426EE = 0775334E;
			num = (998662987U ^ num);
			num = 677786396U >> (int)num;
			this.4BB15D10 = 2E131509;
			num |= 1610573732U;
			this.49EE0093 = 23CB1046;
			if (1442919460U <= num)
			{
				return;
			}
			goto IL_12;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00E7ACD8 File Offset: 0x00E770D8
		public byte 77873502()
		{
			uint num = 1236226633U;
			num /= 1902250559U;
			return this.158426EE;
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00E7ACFC File Offset: 0x00E770FC
		public int 3E5F028F()
		{
			return this.4BB15D10;
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00E7AD10 File Offset: 0x00E77110
		public int 641A0856()
		{
			uint num = 616718226U;
			num = (312493269U & num);
			return this.49EE0093;
		}

		// Token: 0x04000320 RID: 800
		private byte 158426EE;

		// Token: 0x04000321 RID: 801
		private int 4BB15D10;

		// Token: 0x04000322 RID: 802
		private int 49EE0093;
	}

	// Token: 0x0200006E RID: 110
	private sealed class 045263C1
	{
		// Token: 0x0600057F RID: 1407 RVA: 0x00E7AD34 File Offset: 0x00E77134
		public 045263C1(int 281B4539, int 02404A38)
		{
			uint num = 1156785396U;
			List<6B147225.770962F3> list = new List<6B147225.770962F3>();
			num = (1182155322U ^ num);
			this.5D572C3C = list;
			do
			{
				num = 1815824968U << (int)num;
				base..ctor();
			}
			while ((255669059U ^ num) == 0U);
			do
			{
				num ^= 125656608U;
				this.3FB73035 = 281B4539;
				num = (1748925721U & num);
				this.4C986709 = 02404A38;
			}
			while (num >> 20 == 0U);
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00E7ADA4 File Offset: 0x00E771A4
		public int 206548D1()
		{
			return this.3FB73035;
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00E7ADC0 File Offset: 0x00E771C0
		public int 26F06F1B()
		{
			return this.4C986709;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00E7ADDC File Offset: 0x00E771DC
		public int 74F076A1(6B147225.045263C1 009C503D)
		{
			if (009C503D == null)
			{
				return 1;
			}
			uint num;
			int num2;
			for (;;)
			{
				num = 2038248355U;
				num &= 1052926896U;
				num += 2052684178U;
				num2 = this.3FB73035.CompareTo(009C503D.206548D1());
				num = 818417258U >> (int)num;
				if (num <= 1265174991U)
				{
					bool flag = num2 != 0;
					num = (1606507159U | num);
					if (flag)
					{
						return num2;
					}
					num = (596314866U | num);
					if (1313224026U <= num)
					{
						break;
					}
				}
			}
			int num3 = 009C503D.26F06F1B();
			num *= 630271864U;
			int num4 = num3;
			num ^= 1344421556U;
			int num5 = num4.CompareTo(this.4C986709);
			num = (1377195089U | num);
			num2 = num5;
			num ^= 2774509770U;
			return num2;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00E7AE8C File Offset: 0x00E7728C
		public void 6D713505(byte 6FE27086, int 6E4D5A94, int 76DB08DF)
		{
			uint num;
			do
			{
				num = 447615263U;
				List<6B147225.770962F3> list = this.5D572C3C;
				num = (784074290U ^ num);
				num /= 481036535U;
				list.Add(new 6B147225.770962F3(6FE27086, 6E4D5A94, 76DB08DF));
			}
			while (num / 1684959103U != 0U);
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x00E7AED0 File Offset: 0x00E772D0
		public List<6B147225.770962F3> 3B2F2F31()
		{
			return this.5D572C3C;
		}

		// Token: 0x04000323 RID: 803
		private int 3FB73035;

		// Token: 0x04000324 RID: 804
		private int 4C986709;

		// Token: 0x04000325 RID: 805
		private List<6B147225.770962F3> 5D572C3C;
	}

	// Token: 0x0200006F RID: 111
	// (Invoke) Token: 0x06000586 RID: 1414
	internal delegate void 62147124();
}
