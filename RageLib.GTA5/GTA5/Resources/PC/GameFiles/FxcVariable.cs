using System;
using System.Collections.Generic;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F0 RID: 496
	public class FxcVariable
	{
		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x00039AEA File Offset: 0x00037CEA
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x00039AF2 File Offset: 0x00037CF2
		public byte b0 { get; set; }

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00039AFB File Offset: 0x00037CFB
		// (set) Token: 0x060008C6 RID: 2246 RVA: 0x00039B03 File Offset: 0x00037D03
		public byte b1 { get; set; }

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x00039B0C File Offset: 0x00037D0C
		// (set) Token: 0x060008C8 RID: 2248 RVA: 0x00039B14 File Offset: 0x00037D14
		public byte b2 { get; set; }

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x00039B1D File Offset: 0x00037D1D
		// (set) Token: 0x060008CA RID: 2250 RVA: 0x00039B25 File Offset: 0x00037D25
		public byte b3 { get; set; }

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00039B2E File Offset: 0x00037D2E
		// (set) Token: 0x060008CC RID: 2252 RVA: 0x00039B36 File Offset: 0x00037D36
		public string Name1 { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x00039B3F File Offset: 0x00037D3F
		// (set) Token: 0x060008CE RID: 2254 RVA: 0x00039B47 File Offset: 0x00037D47
		public string Name2 { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x00039B50 File Offset: 0x00037D50
		// (set) Token: 0x060008D0 RID: 2256 RVA: 0x00039B58 File Offset: 0x00037D58
		public byte b4 { get; set; }

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x00039B61 File Offset: 0x00037D61
		// (set) Token: 0x060008D2 RID: 2258 RVA: 0x00039B69 File Offset: 0x00037D69
		public byte b5 { get; set; }

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00039B72 File Offset: 0x00037D72
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x00039B7A File Offset: 0x00037D7A
		public byte b6 { get; set; }

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00039B83 File Offset: 0x00037D83
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x00039B8B File Offset: 0x00037D8B
		public byte b7 { get; set; }

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00039B94 File Offset: 0x00037D94
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00039B9C File Offset: 0x00037D9C
		public uint CBufferName { get; set; }

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x00039BA5 File Offset: 0x00037DA5
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00039BAD File Offset: 0x00037DAD
		public byte ParamCount { get; set; }

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00039BB6 File Offset: 0x00037DB6
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00039BBE File Offset: 0x00037DBE
		public FxcVariableParam[] Params { get; set; }

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x00039BC7 File Offset: 0x00037DC7
		// (set) Token: 0x060008DE RID: 2270 RVA: 0x00039BCF File Offset: 0x00037DCF
		public byte ValueCount { get; set; }

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x00039BD8 File Offset: 0x00037DD8
		// (set) Token: 0x060008E0 RID: 2272 RVA: 0x00039BE0 File Offset: 0x00037DE0
		public float[] Values { get; set; }

		// Token: 0x060008E1 RID: 2273 RVA: 0x00039BEC File Offset: 0x00037DEC
		public void Read(BinaryReader br)
		{
			this.b0 = br.ReadByte();
			this.b1 = br.ReadByte();
			this.b2 = br.ReadByte();
			this.b3 = br.ReadByte();
			this.Name1 = FxcFile.ReadString(br);
			this.Name2 = FxcFile.ReadString(br);
			this.b4 = br.ReadByte();
			this.b5 = br.ReadByte();
			this.b6 = br.ReadByte();
			this.b7 = br.ReadByte();
			this.CBufferName = br.ReadUInt32();
			this.ParamCount = br.ReadByte();
			if (this.ParamCount > 0)
			{
				List<FxcVariableParam> list = new List<FxcVariableParam>();
				for (int i = 0; i < (int)this.ParamCount; i++)
				{
					FxcVariableParam fxcVariableParam = new FxcVariableParam();
					fxcVariableParam.Read(br);
					list.Add(fxcVariableParam);
				}
				this.Params = list.ToArray();
			}
			this.ValueCount = br.ReadByte();
			if (this.ValueCount > 0)
			{
				this.Values = new float[(int)this.ValueCount];
				for (int j = 0; j < (int)this.ValueCount; j++)
				{
					this.Values[j] = br.ReadSingle();
				}
			}
			switch (this.b0)
			{
			default:
			{
				byte b = this.b1;
				if (b <= 24)
				{
					switch (b)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
					case 12:
					case 13:
					case 14:
					case 15:
					case 16:
						break;
					default:
						if (b != 24)
						{
						}
						break;
					}
				}
				else if (b != 40 && b != 117)
				{
					byte b2 = b - 254;
				}
				uint cbufferName = this.CBufferName;
				if (cbufferName <= 2172777116U)
				{
					if (cbufferName <= 1059338858U)
					{
						if (cbufferName <= 673228990U)
						{
							if (cbufferName <= 482774302U)
							{
								if (cbufferName <= 118958736U)
								{
									if (cbufferName != 0U && cbufferName != 115655537U && cbufferName != 118958736U)
									{
									}
								}
								else if (cbufferName != 201854132U && cbufferName != 278397346U && cbufferName != 482774302U)
								{
								}
							}
							else if (cbufferName <= 519785780U)
							{
								if (cbufferName != 486482914U && cbufferName != 488789527U && cbufferName != 519785780U)
								{
								}
							}
							else if (cbufferName <= 579364910U)
							{
								if (cbufferName != 556501613U && cbufferName != 579364910U)
								{
								}
							}
							else if (cbufferName != 586499600U && cbufferName != 673228990U)
							{
							}
						}
						else if (cbufferName <= 938670440U)
						{
							if (cbufferName <= 764124013U)
							{
								if (cbufferName != 713939274U && cbufferName != 729415208U && cbufferName != 764124013U)
								{
								}
							}
							else if (cbufferName != 832855465U && cbufferName != 871214106U && cbufferName != 938670440U)
							{
							}
						}
						else if (cbufferName <= 962813362U)
						{
							if (cbufferName != 950211059U && cbufferName != 957783816U && cbufferName != 962813362U)
							{
							}
						}
						else if (cbufferName <= 1004646027U)
						{
							if (cbufferName != 970248680U && cbufferName != 1004646027U)
							{
							}
						}
						else if (cbufferName != 1032736383U && cbufferName != 1059338858U)
						{
						}
					}
					else if (cbufferName <= 1641847936U)
					{
						if (cbufferName <= 1286180849U)
						{
							if (cbufferName <= 1237102223U)
							{
								if (cbufferName != 1100625170U && cbufferName != 1142002603U && cbufferName != 1237102223U)
								{
								}
							}
							else if (cbufferName != 1275817784U && cbufferName != 1279142172U && cbufferName != 1286180849U)
							{
							}
						}
						else if (cbufferName <= 1438660507U)
						{
							if (cbufferName != 1316881611U && cbufferName != 1340365912U && cbufferName != 1438660507U)
							{
							}
						}
						else if (cbufferName <= 1554708878U)
						{
							if (cbufferName != 1519748817U && cbufferName != 1554708878U)
							{
							}
						}
						else if (cbufferName != 1561144077U && cbufferName != 1641847936U)
						{
						}
					}
					else if (cbufferName <= 2017746823U)
					{
						if (cbufferName <= 1853474951U)
						{
							if (cbufferName != 1778702372U && cbufferName != 1834530379U && cbufferName != 1853474951U)
							{
							}
						}
						else if (cbufferName <= 1910375705U)
						{
							if (cbufferName != 1866965008U && cbufferName != 1910375705U)
							{
							}
						}
						else if (cbufferName != 1927486087U && cbufferName != 2017746823U)
						{
						}
					}
					else if (cbufferName <= 2062541604U)
					{
						if (cbufferName != 2020034807U && cbufferName != 2049538169U && cbufferName != 2062541604U)
						{
						}
					}
					else if (cbufferName <= 2121263542U)
					{
						if (cbufferName != 2092585241U && cbufferName != 2121263542U)
						{
						}
					}
					else if (cbufferName != 2165770756U && cbufferName != 2172777116U)
					{
					}
				}
				else if (cbufferName <= 3291504934U)
				{
					if (cbufferName <= 2656344872U)
					{
						if (cbufferName <= 2384984532U)
						{
							if (cbufferName <= 2300268537U)
							{
								if (cbufferName != 2193272593U && cbufferName != 2224880237U && cbufferName != 2300268537U)
								{
								}
							}
							else if (cbufferName != 2355014976U && cbufferName != 2380663322U && cbufferName != 2384984532U)
							{
							}
						}
						else if (cbufferName <= 2526104914U)
						{
							if (cbufferName != 2397841684U && cbufferName != 2522030664U && cbufferName != 2526104914U)
							{
							}
						}
						else if (cbufferName <= 2564407213U)
						{
							if (cbufferName != 2531859994U && cbufferName != 2564407213U)
							{
							}
						}
						else if (cbufferName != 2651790209U && cbufferName != 2656344872U)
						{
						}
					}
					else if (cbufferName <= 2865440919U)
					{
						if (cbufferName <= 2725372071U)
						{
							if (cbufferName != 2714887816U && cbufferName != 2718810031U && cbufferName != 2725372071U)
							{
							}
						}
						else if (cbufferName <= 2783177544U)
						{
							if (cbufferName != 2782027784U && cbufferName != 2783177544U)
							{
							}
						}
						else if (cbufferName != 2829744882U && cbufferName != 2865440919U)
						{
						}
					}
					else if (cbufferName <= 3049310097U)
					{
						if (cbufferName != 2988188919U && cbufferName != 2999112456U && cbufferName != 3049310097U)
						{
						}
					}
					else if (cbufferName <= 3162602184U)
					{
						if (cbufferName != 3084860475U && cbufferName != 3162602184U)
						{
						}
					}
					else if (cbufferName != 3291498326U && cbufferName != 3291504934U)
					{
					}
				}
				else if (cbufferName <= 3766848419U)
				{
					if (cbufferName <= 3458315595U)
					{
						if (cbufferName <= 3369176576U)
						{
							if (cbufferName != 3346871633U && cbufferName != 3367312321U && cbufferName != 3369176576U)
							{
							}
						}
						else if (cbufferName != 3375019131U && cbufferName != 3453406875U && cbufferName != 3458315595U)
						{
						}
					}
					else if (cbufferName <= 3616072140U)
					{
						if (cbufferName != 3502503908U && cbufferName != 3572088685U && cbufferName != 3616072140U)
						{
						}
					}
					else if (cbufferName <= 3661207622U)
					{
						if (cbufferName != 3635751376U && cbufferName != 3661207622U)
						{
						}
					}
					else if (cbufferName != 3743503190U && cbufferName != 3766848419U)
					{
					}
				}
				else if (cbufferName <= 4046148196U)
				{
					if (cbufferName <= 3899781660U)
					{
						if (cbufferName != 3779850771U && cbufferName != 3844532749U && cbufferName != 3899781660U)
						{
						}
					}
					else if (cbufferName <= 4017086211U)
					{
						if (cbufferName != 3977262900U && cbufferName != 4017086211U)
						{
						}
					}
					else if (cbufferName != 4029270406U && cbufferName != 4046148196U)
					{
					}
				}
				else if (cbufferName <= 4135739982U)
				{
					if (cbufferName != 4091106477U && cbufferName != 4092686193U && cbufferName != 4135739982U)
					{
					}
				}
				else if (cbufferName <= 4213364555U)
				{
					if (cbufferName != 4165560568U && cbufferName != 4213364555U)
					{
					}
				}
				else if (cbufferName != 4224116138U)
				{
				}
				b = this.b3;
				if (b <= 35)
				{
					switch (b)
					{
					case 0:
					case 1:
					case 2:
					case 3:
					case 4:
					case 5:
					case 6:
					case 7:
					case 8:
					case 9:
					case 10:
					case 11:
						break;
					default:
						switch (b)
						{
						case 16:
						case 17:
						case 18:
						case 19:
							break;
						default:
							switch (b)
							{
							case 26:
							case 27:
							case 28:
							case 29:
							case 30:
							case 31:
							case 32:
							case 33:
							case 34:
							case 35:
								break;
							default:
								return;
							}
							break;
						}
						break;
					}
				}
				else if (b == 39 || b != 49)
				{
				}
				return;
			}
			}
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x0003A5D0 File Offset: 0x000387D0
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.b0.ToString(),
				", ",
				this.b1.ToString(),
				", ",
				this.b2.ToString(),
				", ",
				this.b3.ToString(),
				", ",
				this.b4.ToString(),
				", ",
				this.b5.ToString(),
				", ",
				this.b6.ToString(),
				", ",
				this.b7.ToString(),
				", ",
				this.CBufferName.ToString(),
				", ",
				this.Name1,
				", ",
				this.Name2
			});
		}
	}
}
