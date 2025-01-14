using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000065 RID: 101
	public class VerticesList : ResourceSystemBlock
	{
		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000213 RID: 531 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x0000D1EC File Offset: 0x0000B3EC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.ListPartsPointer = reader.ReadUInt64();
			this.ListOffsetsPointer = reader.ReadUInt64();
			this.ListPartsCount = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.ListParts = reader.ReadBlockAt<ResourceSimpleArray<VerticesListPart>>(this.ListPartsPointer, new object[]
			{
				this.ListPartsCount
			});
			this.ListOffsets = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.ListOffsetsPointer, new object[]
			{
				this.ListPartsCount
			});
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0000D2C0 File Offset: 0x0000B4C0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.ListPartsPointer = (ulong)((this.ListParts != null) ? this.ListParts.Position : 0L);
			this.ListOffsetsPointer = (ulong)((this.ListOffsets != null) ? this.ListOffsets.Position : 0L);
			this.ListPartsCount = (uint)((this.ListParts != null) ? this.ListParts.Count : 0);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.ListPartsPointer);
			writer.Write(this.ListOffsetsPointer);
			writer.Write(this.ListPartsCount);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x0000D39C File Offset: 0x0000B59C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.ListParts != null)
			{
				list.Add(this.ListParts);
			}
			if (this.ListOffsets != null)
			{
				list.Add(this.ListOffsets);
			}
			return list.ToArray();
		}

		// Token: 0x040004E6 RID: 1254
		public uint VFT;

		// Token: 0x040004E7 RID: 1255
		public uint Unknown_4h;

		// Token: 0x040004E8 RID: 1256
		public uint Unknown_8h;

		// Token: 0x040004E9 RID: 1257
		public uint Unknown_Ch;

		// Token: 0x040004EA RID: 1258
		public ulong ListPartsPointer;

		// Token: 0x040004EB RID: 1259
		public ulong ListOffsetsPointer;

		// Token: 0x040004EC RID: 1260
		public uint ListPartsCount;

		// Token: 0x040004ED RID: 1261
		public uint Unknown_24h;

		// Token: 0x040004EE RID: 1262
		public uint Unknown_28h;

		// Token: 0x040004EF RID: 1263
		public uint Unknown_2Ch;

		// Token: 0x040004F0 RID: 1264
		public ResourceSimpleArray<VerticesListPart> ListParts;

		// Token: 0x040004F1 RID: 1265
		public ResourceSimpleArray<uint_r> ListOffsets;
	}
}
