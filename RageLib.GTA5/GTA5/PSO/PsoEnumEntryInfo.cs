using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000210 RID: 528
	public class PsoEnumEntryInfo
	{
		// Token: 0x17000226 RID: 550
		// (get) Token: 0x060009C6 RID: 2502 RVA: 0x0003D28E File Offset: 0x0003B48E
		// (set) Token: 0x060009C7 RID: 2503 RVA: 0x0003D296 File Offset: 0x0003B496
		public int EntryNameHash { get; set; }

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x060009C8 RID: 2504 RVA: 0x0003D29F File Offset: 0x0003B49F
		// (set) Token: 0x060009C9 RID: 2505 RVA: 0x0003D2A7 File Offset: 0x0003B4A7
		public int EntryKey { get; set; }

		// Token: 0x060009CA RID: 2506 RVA: 0x00002192 File Offset: 0x00000392
		public PsoEnumEntryInfo()
		{
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x0003D2B0 File Offset: 0x0003B4B0
		public PsoEnumEntryInfo(int nameHash, int key)
		{
			this.EntryNameHash = nameHash;
			this.EntryKey = key;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x0003D2C6 File Offset: 0x0003B4C6
		public void Read(DataReader reader)
		{
			this.EntryNameHash = reader.ReadInt32();
			this.EntryKey = reader.ReadInt32();
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0003D2E0 File Offset: 0x0003B4E0
		public void Write(DataWriter writer)
		{
			writer.Write(this.EntryNameHash);
			writer.Write(this.EntryKey);
		}
	}
}
