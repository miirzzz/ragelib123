using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007A RID: 122
	public class EnumInfo : ResourceSystemBlock
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060002CD RID: 717 RVA: 0x0000EB44 File Offset: 0x0000CD44
		// (set) Token: 0x060002CE RID: 718 RVA: 0x0000EB4C File Offset: 0x0000CD4C
		public int EnumNameHash { get; set; }

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000EB55 File Offset: 0x0000CD55
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0000EB5D File Offset: 0x0000CD5D
		public int EnumKey { get; set; }

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000EB66 File Offset: 0x0000CD66
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x0000EB6E File Offset: 0x0000CD6E
		public long EntriesPointer { get; private set; }

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x0000EB77 File Offset: 0x0000CD77
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x0000EB7F File Offset: 0x0000CD7F
		public int EntriesCount { get; private set; }

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x0000EB88 File Offset: 0x0000CD88
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x0000EB90 File Offset: 0x0000CD90
		public int Unknown_14h { get; set; }

		// Token: 0x060002D7 RID: 727 RVA: 0x0000286D File Offset: 0x00000A6D
		public EnumInfo()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0000EB99 File Offset: 0x0000CD99
		public EnumInfo(int enumNameHash, int enumKey, long entriesPointer, int Unkown_14h, ResourceSimpleArray<EnumEntryInfo> entries)
		{
			this.EnumNameHash = enumNameHash;
			this.EnumKey = enumKey;
			this.EntriesPointer = this.EntriesPointer;
			this.EntriesCount = entries.Count;
			this.Unknown_14h = Unkown_14h;
			this.Entries = entries;
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x0000EBD8 File Offset: 0x0000CDD8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.EnumNameHash = reader.ReadInt32();
			this.EnumKey = reader.ReadInt32();
			this.EntriesPointer = reader.ReadInt64();
			this.EntriesCount = reader.ReadInt32();
			this.Unknown_14h = reader.ReadInt32();
			this.Entries = reader.ReadBlockAt<ResourceSimpleArray<EnumEntryInfo>>((ulong)this.EntriesPointer, new object[]
			{
				this.EntriesCount
			});
		}

		// Token: 0x060002DA RID: 730 RVA: 0x0000EC48 File Offset: 0x0000CE48
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			ResourceSimpleArray<EnumEntryInfo> entries = this.Entries;
			this.EntriesPointer = ((entries != null) ? entries.Position : 0L);
			ResourceSimpleArray<EnumEntryInfo> entries2 = this.Entries;
			this.EntriesCount = ((entries2 != null) ? entries2.Count : 0);
			writer.Write(this.EnumNameHash);
			writer.Write(this.EnumKey);
			writer.Write(this.EntriesPointer);
			writer.Write(this.EntriesCount);
			writer.Write(this.Unknown_14h);
		}

		// Token: 0x060002DB RID: 731 RVA: 0x0000ECC4 File Offset: 0x0000CEC4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Entries != null)
			{
				list.Add(this.Entries);
			}
			return list.ToArray();
		}

		// Token: 0x0400058E RID: 1422
		public ResourceSimpleArray<EnumEntryInfo> Entries;
	}
}
