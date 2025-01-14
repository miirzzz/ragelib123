using System;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001EB RID: 491
	public class FxcHeaderExt
	{
		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x000394D1 File Offset: 0x000376D1
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x000394D9 File Offset: 0x000376D9
		public string Name { get; set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x000394E2 File Offset: 0x000376E2
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x000394EA File Offset: 0x000376EA
		public byte Unk0Byte { get; set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x000394F3 File Offset: 0x000376F3
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x000394FB File Offset: 0x000376FB
		public uint Unk1Uint { get; set; }

		// Token: 0x0600087D RID: 2173 RVA: 0x00039504 File Offset: 0x00037704
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.Name,
				": ",
				this.Unk0Byte.ToString(),
				": ",
				this.Unk1Uint.ToString()
			});
		}
	}
}
