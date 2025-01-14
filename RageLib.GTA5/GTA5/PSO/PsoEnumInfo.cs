using System;
using System.Collections.Generic;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020F RID: 527
	public class PsoEnumInfo : PsoElementInfo
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060009BB RID: 2491 RVA: 0x0003D0EF File Offset: 0x0003B2EF
		// (set) Token: 0x060009BC RID: 2492 RVA: 0x0003D0F7 File Offset: 0x0003B2F7
		public byte Type { get; private set; } = 1;

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x060009BD RID: 2493 RVA: 0x0003D100 File Offset: 0x0003B300
		// (set) Token: 0x060009BE RID: 2494 RVA: 0x0003D108 File Offset: 0x0003B308
		public int EntriesCount { get; private set; }

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0003D111 File Offset: 0x0003B311
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0003D119 File Offset: 0x0003B319
		public List<PsoEnumEntryInfo> Entries { get; set; }

		// Token: 0x060009C1 RID: 2497 RVA: 0x0003D122 File Offset: 0x0003B322
		public PsoEnumInfo()
		{
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0003D131 File Offset: 0x0003B331
		public PsoEnumInfo(byte type, List<PsoEnumEntryInfo> entries)
		{
			this.Type = type;
			this.Entries = entries;
			this.EntriesCount = entries.Count;
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x0003D15C File Offset: 0x0003B35C
		public override void Read(DataReader reader)
		{
			uint num = reader.ReadUInt32();
			this.Type = (byte)((num & 4278190080U) >> 24);
			this.EntriesCount = (int)(num & 16777215U);
			this.Entries = new List<PsoEnumEntryInfo>();
			for (int i = 0; i < this.EntriesCount; i++)
			{
				PsoEnumEntryInfo psoEnumEntryInfo = new PsoEnumEntryInfo();
				psoEnumEntryInfo.Read(reader);
				this.Entries.Add(psoEnumEntryInfo);
			}
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x0003D1C4 File Offset: 0x0003B3C4
		public override void Write(DataWriter writer)
		{
			this.Type = 1;
			this.EntriesCount = this.Entries.Count;
			uint value = (uint)((int)this.Type << 24 | this.EntriesCount);
			writer.Write(value);
			foreach (PsoEnumEntryInfo psoEnumEntryInfo in this.Entries)
			{
				psoEnumEntryInfo.Write(writer);
			}
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x0003D248 File Offset: 0x0003B448
		public PsoEnumEntryInfo FindEntry(int val)
		{
			if (this.Entries == null)
			{
				return null;
			}
			for (int i = 0; i < this.Entries.Count; i++)
			{
				PsoEnumEntryInfo psoEnumEntryInfo = this.Entries[i];
				if (psoEnumEntryInfo.EntryKey == val)
				{
					return psoEnumEntryInfo;
				}
			}
			return null;
		}
	}
}
