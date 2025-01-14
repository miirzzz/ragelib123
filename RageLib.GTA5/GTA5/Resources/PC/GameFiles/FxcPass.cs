using System;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F3 RID: 499
	public class FxcPass
	{
		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0003A8B6 File Offset: 0x00038AB6
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x0003A8BE File Offset: 0x00038ABE
		public byte VS { get; set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0003A8C7 File Offset: 0x00038AC7
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x0003A8CF File Offset: 0x00038ACF
		public byte PS { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0003A8D8 File Offset: 0x00038AD8
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0003A8E0 File Offset: 0x00038AE0
		public byte CS { get; set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0003A8E9 File Offset: 0x00038AE9
		// (set) Token: 0x060008FD RID: 2301 RVA: 0x0003A8F1 File Offset: 0x00038AF1
		public byte DS { get; set; }

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0003A8FA File Offset: 0x00038AFA
		// (set) Token: 0x060008FF RID: 2303 RVA: 0x0003A902 File Offset: 0x00038B02
		public byte GS { get; set; }

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0003A90B File Offset: 0x00038B0B
		// (set) Token: 0x06000901 RID: 2305 RVA: 0x0003A913 File Offset: 0x00038B13
		public byte HS { get; set; }

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0003A91C File Offset: 0x00038B1C
		// (set) Token: 0x06000903 RID: 2307 RVA: 0x0003A924 File Offset: 0x00038B24
		public byte ParamCount { get; set; }

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0003A92D File Offset: 0x00038B2D
		// (set) Token: 0x06000905 RID: 2309 RVA: 0x0003A935 File Offset: 0x00038B35
		public FxcPassParam[] Params { get; set; }

		// Token: 0x06000906 RID: 2310 RVA: 0x0003A940 File Offset: 0x00038B40
		public void Read(BinaryReader br)
		{
			this.VS = br.ReadByte();
			this.PS = br.ReadByte();
			this.CS = br.ReadByte();
			this.DS = br.ReadByte();
			this.GS = br.ReadByte();
			this.HS = br.ReadByte();
			this.ParamCount = br.ReadByte();
			if (this.ParamCount > 0)
			{
				this.Params = new FxcPassParam[(int)this.ParamCount];
				for (int i = 0; i < (int)this.ParamCount; i++)
				{
					FxcPassParam fxcPassParam = new FxcPassParam();
					fxcPassParam.u0 = br.ReadUInt32();
					fxcPassParam.u1 = br.ReadUInt32();
					this.Params[i] = fxcPassParam;
				}
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x0003A9F4 File Offset: 0x00038BF4
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.VS.ToString(),
				", ",
				this.PS.ToString(),
				", ",
				this.CS.ToString(),
				", ",
				this.DS.ToString(),
				", ",
				this.GS.ToString(),
				", ",
				this.HS.ToString()
			});
		}
	}
}
