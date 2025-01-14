using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.WaypointRecords
{
	// Token: 0x02000011 RID: 17
	public class WaypointRecord : FileBase64_GTA5_pc
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00003B18 File Offset: 0x00001D18
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.EntriesPointer = reader.ReadUInt64();
			this.EntriesCount = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Entries = reader.ReadBlockAt<ResourceSimpleArray<WaypointRecordEntry>>(this.EntriesPointer, new object[]
			{
				this.EntriesCount
			});
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00003BA8 File Offset: 0x00001DA8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			ResourceSimpleArray<WaypointRecordEntry> entries = this.Entries;
			this.EntriesPointer = (ulong)((entries != null) ? entries.Position : 0L);
			ResourceSimpleArray<WaypointRecordEntry> entries2 = this.Entries;
			this.EntriesCount = (uint)((entries2 != null) ? entries2.Count : 0);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.EntriesPointer);
			writer.Write(this.EntriesCount);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00003C44 File Offset: 0x00001E44
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Entries != null)
			{
				list.Add(this.Entries);
			}
			return list.ToArray();
		}

		// Token: 0x0400005F RID: 95
		public uint Unknown_10h;

		// Token: 0x04000060 RID: 96
		public uint Unknown_14h;

		// Token: 0x04000061 RID: 97
		public ulong EntriesPointer;

		// Token: 0x04000062 RID: 98
		public uint EntriesCount;

		// Token: 0x04000063 RID: 99
		public uint Unknown_24h;

		// Token: 0x04000064 RID: 100
		public uint Unknown_28h;

		// Token: 0x04000065 RID: 101
		public uint Unknown_2Ch;

		// Token: 0x04000066 RID: 102
		public ResourceSimpleArray<WaypointRecordEntry> Entries;
	}
}
