using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005A RID: 90
	public class IndicesList : ResourceSystemBlock
	{
		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001E0 RID: 480 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000BA00 File Offset: 0x00009C00
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
			this.ListParts = reader.ReadBlockAt<ResourceSimpleArray<IndicesListPart>>(this.ListPartsPointer, new object[]
			{
				this.ListPartsCount
			});
			this.ListOffsets = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.ListOffsetsPointer, new object[]
			{
				this.ListPartsCount
			});
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000BAD4 File Offset: 0x00009CD4
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

		// Token: 0x060001E3 RID: 483 RVA: 0x0000BBB0 File Offset: 0x00009DB0
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

		// Token: 0x04000431 RID: 1073
		public uint VFT;

		// Token: 0x04000432 RID: 1074
		public uint Unknown_4h;

		// Token: 0x04000433 RID: 1075
		public uint Unknown_8h;

		// Token: 0x04000434 RID: 1076
		public uint Unknown_Ch;

		// Token: 0x04000435 RID: 1077
		public ulong ListPartsPointer;

		// Token: 0x04000436 RID: 1078
		public ulong ListOffsetsPointer;

		// Token: 0x04000437 RID: 1079
		public uint ListPartsCount;

		// Token: 0x04000438 RID: 1080
		public uint Unknown_24h;

		// Token: 0x04000439 RID: 1081
		public uint Unknown_28h;

		// Token: 0x0400043A RID: 1082
		public uint Unknown_2Ch;

		// Token: 0x0400043B RID: 1083
		public ResourceSimpleArray<IndicesListPart> ListParts;

		// Token: 0x0400043C RID: 1084
		public ResourceSimpleArray<uint_r> ListOffsets;
	}
}
