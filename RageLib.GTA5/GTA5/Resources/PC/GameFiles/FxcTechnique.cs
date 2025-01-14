using System;
using System.IO;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001F2 RID: 498
	public class FxcTechnique
	{
		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0003A7B7 File Offset: 0x000389B7
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x0003A7BF File Offset: 0x000389BF
		public string Name { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0003A7C8 File Offset: 0x000389C8
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x0003A7D0 File Offset: 0x000389D0
		public byte PassCount { get; set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0003A7D9 File Offset: 0x000389D9
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x0003A7E1 File Offset: 0x000389E1
		public FxcPass[] Passes { get; set; }

		// Token: 0x060008F3 RID: 2291 RVA: 0x0003A7EC File Offset: 0x000389EC
		public void Read(BinaryReader br)
		{
			this.Name = FxcFile.ReadString(br);
			this.PassCount = br.ReadByte();
			if (this.PassCount > 0)
			{
				this.Passes = new FxcPass[(int)this.PassCount];
				for (int i = 0; i < (int)this.PassCount; i++)
				{
					FxcPass fxcPass = new FxcPass();
					fxcPass.Read(br);
					this.Passes[i] = fxcPass;
				}
			}
		}

		// Token: 0x060008F4 RID: 2292 RVA: 0x0003A854 File Offset: 0x00038A54
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Name,
				" (",
				this.PassCount.ToString(),
				" pass",
				(this.PassCount != 1) ? "es" : "",
				")"
			});
		}
	}
}
