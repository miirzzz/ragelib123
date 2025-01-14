using System;
using System.Collections.Generic;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000206 RID: 518
	public class PsoDataMappingSection
	{
		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0003C731 File Offset: 0x0003A931
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x0003C739 File Offset: 0x0003A939
		public int Ident { get; set; } = 1347240272;

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x0003C742 File Offset: 0x0003A942
		// (set) Token: 0x06000975 RID: 2421 RVA: 0x0003C74A File Offset: 0x0003A94A
		public int Length { get; private set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x0003C753 File Offset: 0x0003A953
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x0003C75B File Offset: 0x0003A95B
		public int RootIndex { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000978 RID: 2424 RVA: 0x0003C764 File Offset: 0x0003A964
		// (set) Token: 0x06000979 RID: 2425 RVA: 0x0003C76C File Offset: 0x0003A96C
		public short EntriesCount { get; private set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600097A RID: 2426 RVA: 0x0003C775 File Offset: 0x0003A975
		// (set) Token: 0x0600097B RID: 2427 RVA: 0x0003C77D File Offset: 0x0003A97D
		public short Unknown_Eh { get; set; } = 28784;

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600097C RID: 2428 RVA: 0x0003C786 File Offset: 0x0003A986
		// (set) Token: 0x0600097D RID: 2429 RVA: 0x0003C78E File Offset: 0x0003A98E
		public List<PsoDataMappingEntry> Entries { get; set; }

		// Token: 0x0600097E RID: 2430 RVA: 0x0003C798 File Offset: 0x0003A998
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			this.RootIndex = reader.ReadInt32();
			this.EntriesCount = reader.ReadInt16();
			this.Unknown_Eh = reader.ReadInt16();
			this.Entries = new List<PsoDataMappingEntry>();
			for (int i = 0; i < (int)this.EntriesCount; i++)
			{
				PsoDataMappingEntry psoDataMappingEntry = new PsoDataMappingEntry();
				psoDataMappingEntry.Read(reader);
				this.Entries.Add(psoDataMappingEntry);
			}
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x0003C818 File Offset: 0x0003AA18
		public void Write(DataWriter writer)
		{
			this.EntriesCount = (short)this.Entries.Count;
			this.Length = (int)(16 + this.EntriesCount * 16);
			writer.Write(this.Ident);
			writer.Write(this.Length);
			writer.Write(this.RootIndex);
			writer.Write(this.EntriesCount);
			writer.Write(this.Unknown_Eh);
			foreach (PsoDataMappingEntry psoDataMappingEntry in this.Entries)
			{
				psoDataMappingEntry.Write(writer);
			}
		}
	}
}
