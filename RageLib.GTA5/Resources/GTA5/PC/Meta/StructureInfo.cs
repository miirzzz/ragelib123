using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000E0 RID: 224
	public class StructureInfo : ResourceSystemBlock
	{
		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000381 RID: 897 RVA: 0x000169E1 File Offset: 0x00014BE1
		// (set) Token: 0x06000382 RID: 898 RVA: 0x000169E9 File Offset: 0x00014BE9
		public int StructureNameHash { get; set; }

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000383 RID: 899 RVA: 0x000169F2 File Offset: 0x00014BF2
		// (set) Token: 0x06000384 RID: 900 RVA: 0x000169FA File Offset: 0x00014BFA
		public int StructureKey { get; set; }

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00016A03 File Offset: 0x00014C03
		// (set) Token: 0x06000386 RID: 902 RVA: 0x00016A0B File Offset: 0x00014C0B
		public int Unknown_8h { get; set; }

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000387 RID: 903 RVA: 0x00016A14 File Offset: 0x00014C14
		// (set) Token: 0x06000388 RID: 904 RVA: 0x00016A1C File Offset: 0x00014C1C
		public int Unknown_Ch { get; set; }

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00016A25 File Offset: 0x00014C25
		// (set) Token: 0x0600038A RID: 906 RVA: 0x00016A2D File Offset: 0x00014C2D
		public long EntriesPointer { get; private set; }

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600038B RID: 907 RVA: 0x00016A36 File Offset: 0x00014C36
		// (set) Token: 0x0600038C RID: 908 RVA: 0x00016A3E File Offset: 0x00014C3E
		public int StructureLength { get; set; }

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600038D RID: 909 RVA: 0x00016A47 File Offset: 0x00014C47
		// (set) Token: 0x0600038E RID: 910 RVA: 0x00016A4F File Offset: 0x00014C4F
		public short Unknown_1Ch { get; set; }

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600038F RID: 911 RVA: 0x00016A58 File Offset: 0x00014C58
		// (set) Token: 0x06000390 RID: 912 RVA: 0x00016A60 File Offset: 0x00014C60
		public short EntriesCount { get; private set; }

		// Token: 0x06000391 RID: 913 RVA: 0x0000286D File Offset: 0x00000A6D
		public StructureInfo()
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00016A6C File Offset: 0x00014C6C
		public StructureInfo(int structureNameHash, int structureKey, int unknown_8h, int unknown_Ch, long entriesPointer, int structureLength, short unknown_1Ch, ResourceSimpleArray<StructureEntryInfo> entries)
		{
			this.StructureNameHash = structureNameHash;
			this.StructureKey = structureKey;
			this.Unknown_8h = unknown_8h;
			this.Unknown_Ch = unknown_Ch;
			this.EntriesPointer = entriesPointer;
			this.StructureLength = structureLength;
			this.Unknown_1Ch = unknown_1Ch;
			this.EntriesCount = (short)entries.Count;
			this.Entries = entries;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00016ACC File Offset: 0x00014CCC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.StructureNameHash = reader.ReadInt32();
			this.StructureKey = reader.ReadInt32();
			this.Unknown_8h = reader.ReadInt32();
			this.Unknown_Ch = reader.ReadInt32();
			this.EntriesPointer = reader.ReadInt64();
			this.StructureLength = reader.ReadInt32();
			this.Unknown_1Ch = reader.ReadInt16();
			this.EntriesCount = reader.ReadInt16();
			this.Entries = reader.ReadBlockAt<ResourceSimpleArray<StructureEntryInfo>>((ulong)((uint)this.EntriesPointer), new object[]
			{
				this.EntriesCount
			});
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00016B64 File Offset: 0x00014D64
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			ResourceSimpleArray<StructureEntryInfo> entries = this.Entries;
			this.EntriesPointer = ((entries != null) ? entries.Position : 0L);
			ResourceSimpleArray<StructureEntryInfo> entries2 = this.Entries;
			this.EntriesCount = (short)((entries2 != null) ? entries2.Count : 0);
			writer.Write(this.StructureNameHash);
			writer.Write(this.StructureKey);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.EntriesPointer);
			writer.Write(this.StructureLength);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.EntriesCount);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00016C04 File Offset: 0x00014E04
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Entries != null)
			{
				list.Add(this.Entries);
			}
			return list.ToArray();
		}

		// Token: 0x04002EAE RID: 11950
		public ResourceSimpleArray<StructureEntryInfo> Entries;
	}
}
