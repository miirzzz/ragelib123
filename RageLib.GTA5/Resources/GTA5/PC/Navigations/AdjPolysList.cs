using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000058 RID: 88
	public class AdjPolysList : ResourceSystemBlock
	{
		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x0000B718 File Offset: 0x00009918
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
			this.ListParts = reader.ReadBlockAt<ResourceSimpleArray<AdjPolysListPart>>(this.ListPartsPointer, new object[]
			{
				this.ListPartsCount
			});
			this.ListOffsets = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.ListOffsetsPointer, new object[]
			{
				this.ListPartsCount
			});
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000B7EC File Offset: 0x000099EC
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

		// Token: 0x060001D9 RID: 473 RVA: 0x0000B8C8 File Offset: 0x00009AC8
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

		// Token: 0x04000421 RID: 1057
		public uint VFT;

		// Token: 0x04000422 RID: 1058
		public uint Unknown_4h;

		// Token: 0x04000423 RID: 1059
		public uint Unknown_8h;

		// Token: 0x04000424 RID: 1060
		public uint Unknown_Ch;

		// Token: 0x04000425 RID: 1061
		public ulong ListPartsPointer;

		// Token: 0x04000426 RID: 1062
		public ulong ListOffsetsPointer;

		// Token: 0x04000427 RID: 1063
		public uint ListPartsCount;

		// Token: 0x04000428 RID: 1064
		public uint Unknown_24h;

		// Token: 0x04000429 RID: 1065
		public uint Unknown_28h;

		// Token: 0x0400042A RID: 1066
		public uint Unknown_2Ch;

		// Token: 0x0400042B RID: 1067
		public ResourceSimpleArray<AdjPolysListPart> ListParts;

		// Token: 0x0400042C RID: 1068
		public ResourceSimpleArray<uint_r> ListOffsets;
	}
}
