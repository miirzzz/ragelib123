using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000105 RID: 261
	public class DrawableGeometry : ResourceSystemBlock
	{
		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x0001C213 File Offset: 0x0001A413
		public override long Length
		{
			get
			{
				return 152L;
			}
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x0001C21C File Offset: 0x0001A41C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.VertexBufferPointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.IndexBufferPointer = reader.ReadUInt64();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.IndicesCount = reader.ReadUInt32();
			this.TrianglesCount = reader.ReadUInt32();
			this.VerticesCount = reader.ReadUInt16();
			this.Unknown_62h = reader.ReadUInt16();
			this.Unknown_64h = reader.ReadUInt32();
			this.BoneIdsPointer = reader.ReadUInt64();
			this.VertexStride = reader.ReadUInt16();
			this.BoneIdsCount = reader.ReadUInt16();
			this.Unknown_74h = reader.ReadUInt32();
			this.VertexDataPointer = reader.ReadUInt64();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.VertexBuffer = reader.ReadBlockAt<VertexBuffer>(this.VertexBufferPointer, Array.Empty<object>());
			this.IndexBuffer = reader.ReadBlockAt<IndexBuffer>(this.IndexBufferPointer, Array.Empty<object>());
			this.BoneIds = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.BoneIdsPointer, new object[]
			{
				this.BoneIdsCount
			});
			this.VertexData = reader.ReadBlockAt<VertexData_GTA5_pc>(this.VertexDataPointer, new object[]
			{
				this.VertexStride,
				this.VerticesCount,
				this.VertexBuffer.Info
			});
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x0001C470 File Offset: 0x0001A670
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.VertexBufferPointer = (ulong)((this.VertexBuffer != null) ? this.VertexBuffer.Position : 0L);
			this.IndexBufferPointer = (ulong)((this.IndexBuffer != null) ? this.IndexBuffer.Position : 0L);
			this.BoneIdsPointer = (ulong)((this.BoneIds != null) ? this.BoneIds.Position : 0L);
			this.VerticesCount = (ushort)((this.VertexData != null) ? this.VertexData.VertexCount : 0);
			this.BoneIdsCount = (ushort)((this.BoneIds != null) ? this.BoneIds.Count : 0);
			this.VertexDataPointer = (ulong)((this.VertexData != null) ? this.VertexData.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.VertexBufferPointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.IndexBufferPointer);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.IndicesCount);
			writer.Write(this.TrianglesCount);
			writer.Write(this.VerticesCount);
			writer.Write(this.Unknown_62h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.BoneIdsPointer);
			writer.Write(this.VertexStride);
			writer.Write(this.BoneIdsCount);
			writer.Write(this.Unknown_74h);
			writer.Write(this.VertexDataPointer);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x0001C6DC File Offset: 0x0001A8DC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.VertexBuffer != null)
			{
				list.Add(this.VertexBuffer);
			}
			if (this.IndexBuffer != null)
			{
				list.Add(this.IndexBuffer);
			}
			if (this.BoneIds != null)
			{
				list.Add(this.BoneIds);
			}
			if (this.VertexData != null)
			{
				list.Add(this.VertexData);
			}
			return list.ToArray();
		}

		// Token: 0x0400314B RID: 12619
		public uint VFT;

		// Token: 0x0400314C RID: 12620
		public uint Unknown_4h;

		// Token: 0x0400314D RID: 12621
		public uint Unknown_8h;

		// Token: 0x0400314E RID: 12622
		public uint Unknown_Ch;

		// Token: 0x0400314F RID: 12623
		public uint Unknown_10h;

		// Token: 0x04003150 RID: 12624
		public uint Unknown_14h;

		// Token: 0x04003151 RID: 12625
		public ulong VertexBufferPointer;

		// Token: 0x04003152 RID: 12626
		public uint Unknown_20h;

		// Token: 0x04003153 RID: 12627
		public uint Unknown_24h;

		// Token: 0x04003154 RID: 12628
		public uint Unknown_28h;

		// Token: 0x04003155 RID: 12629
		public uint Unknown_2Ch;

		// Token: 0x04003156 RID: 12630
		public uint Unknown_30h;

		// Token: 0x04003157 RID: 12631
		public uint Unknown_34h;

		// Token: 0x04003158 RID: 12632
		public ulong IndexBufferPointer;

		// Token: 0x04003159 RID: 12633
		public uint Unknown_40h;

		// Token: 0x0400315A RID: 12634
		public uint Unknown_44h;

		// Token: 0x0400315B RID: 12635
		public uint Unknown_48h;

		// Token: 0x0400315C RID: 12636
		public uint Unknown_4Ch;

		// Token: 0x0400315D RID: 12637
		public uint Unknown_50h;

		// Token: 0x0400315E RID: 12638
		public uint Unknown_54h;

		// Token: 0x0400315F RID: 12639
		public uint IndicesCount;

		// Token: 0x04003160 RID: 12640
		public uint TrianglesCount;

		// Token: 0x04003161 RID: 12641
		public ushort VerticesCount;

		// Token: 0x04003162 RID: 12642
		public ushort Unknown_62h;

		// Token: 0x04003163 RID: 12643
		public uint Unknown_64h;

		// Token: 0x04003164 RID: 12644
		public ulong BoneIdsPointer;

		// Token: 0x04003165 RID: 12645
		public ushort VertexStride;

		// Token: 0x04003166 RID: 12646
		public ushort BoneIdsCount;

		// Token: 0x04003167 RID: 12647
		public uint Unknown_74h;

		// Token: 0x04003168 RID: 12648
		public ulong VertexDataPointer;

		// Token: 0x04003169 RID: 12649
		public uint Unknown_80h;

		// Token: 0x0400316A RID: 12650
		public uint Unknown_84h;

		// Token: 0x0400316B RID: 12651
		public uint Unknown_88h;

		// Token: 0x0400316C RID: 12652
		public uint Unknown_8Ch;

		// Token: 0x0400316D RID: 12653
		public uint Unknown_90h;

		// Token: 0x0400316E RID: 12654
		public uint Unknown_94h;

		// Token: 0x0400316F RID: 12655
		public VertexBuffer VertexBuffer;

		// Token: 0x04003170 RID: 12656
		public IndexBuffer IndexBuffer;

		// Token: 0x04003171 RID: 12657
		public ResourceSimpleArray<ushort_r> BoneIds;

		// Token: 0x04003172 RID: 12658
		public VertexData_GTA5_pc VertexData;
	}
}
