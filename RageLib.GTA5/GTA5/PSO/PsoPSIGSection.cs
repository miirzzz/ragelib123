using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000214 RID: 532
	public class PsoPSIGSection
	{
		// Token: 0x17000234 RID: 564
		// (get) Token: 0x060009F0 RID: 2544 RVA: 0x0003D78B File Offset: 0x0003B98B
		// (set) Token: 0x060009F1 RID: 2545 RVA: 0x0003D793 File Offset: 0x0003B993
		public int Ident { get; private set; } = 1347635527;

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0003D79C File Offset: 0x0003B99C
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0003D7A4 File Offset: 0x0003B9A4
		public int Length { get; set; }

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x060009F4 RID: 2548 RVA: 0x0003D7AD File Offset: 0x0003B9AD
		// (set) Token: 0x060009F5 RID: 2549 RVA: 0x0003D7B5 File Offset: 0x0003B9B5
		public byte[] Data { get; set; }

		// Token: 0x060009F6 RID: 2550 RVA: 0x0003D7BE File Offset: 0x0003B9BE
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			if (this.Length > 8)
			{
				this.Data = reader.ReadBytes(this.Length - 8);
			}
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0003D7F5 File Offset: 0x0003B9F5
		public void Write(DataWriter writer)
		{
			writer.Write(this.Ident);
			writer.Write(this.Length);
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0003D810 File Offset: 0x0003BA10
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
