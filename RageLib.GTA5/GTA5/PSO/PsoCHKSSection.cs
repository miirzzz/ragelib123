using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000205 RID: 517
	public class PsoCHKSSection
	{
		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x0003C61A File Offset: 0x0003A81A
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x0003C622 File Offset: 0x0003A822
		public int Ident { get; private set; } = 1128811347;

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x0003C62B File Offset: 0x0003A82B
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x0003C633 File Offset: 0x0003A833
		public int Length { get; set; }

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x0003C63C File Offset: 0x0003A83C
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x0003C644 File Offset: 0x0003A844
		public uint FileSize { get; set; }

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x0003C64D File Offset: 0x0003A84D
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x0003C655 File Offset: 0x0003A855
		public uint Checksum { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x0003C65E File Offset: 0x0003A85E
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x0003C666 File Offset: 0x0003A866
		public uint Unk0 { get; set; } = 2037411952U;

		// Token: 0x0600096E RID: 2414 RVA: 0x0003C670 File Offset: 0x0003A870
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			if (this.Length != 20)
			{
				return;
			}
			this.FileSize = reader.ReadUInt32();
			this.Checksum = reader.ReadUInt32();
			this.Unk0 = reader.ReadUInt32();
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x0003C6C4 File Offset: 0x0003A8C4
		public void Write(DataWriter writer)
		{
			writer.Write(this.Ident);
			writer.Write(this.Length);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x0003C6E0 File Offset: 0x0003A8E0
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
