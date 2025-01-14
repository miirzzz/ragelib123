using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005E RID: 94
	public class PolysList : ResourceSystemBlock
	{
		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000C820 File Offset: 0x0000AA20
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
			this.ListParts = reader.ReadBlockAt<ResourceSimpleArray<PolysListPart>>(this.ListPartsPointer, new object[]
			{
				this.ListPartsCount
			});
			this.ListOffsets = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.ListOffsetsPointer, new object[]
			{
				this.ListPartsCount
			});
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000C8F4 File Offset: 0x0000AAF4
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

		// Token: 0x060001F6 RID: 502 RVA: 0x0000C9D0 File Offset: 0x0000ABD0
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

		// Token: 0x040004A5 RID: 1189
		public uint VFT;

		// Token: 0x040004A6 RID: 1190
		public uint Unknown_4h;

		// Token: 0x040004A7 RID: 1191
		public uint Unknown_8h;

		// Token: 0x040004A8 RID: 1192
		public uint Unknown_Ch;

		// Token: 0x040004A9 RID: 1193
		public ulong ListPartsPointer;

		// Token: 0x040004AA RID: 1194
		public ulong ListOffsetsPointer;

		// Token: 0x040004AB RID: 1195
		public uint ListPartsCount;

		// Token: 0x040004AC RID: 1196
		public uint Unknown_24h;

		// Token: 0x040004AD RID: 1197
		public uint Unknown_28h;

		// Token: 0x040004AE RID: 1198
		public uint Unknown_2Ch;

		// Token: 0x040004AF RID: 1199
		public ResourceSimpleArray<PolysListPart> ListParts;

		// Token: 0x040004B0 RID: 1200
		public ResourceSimpleArray<uint_r> ListOffsets;
	}
}
