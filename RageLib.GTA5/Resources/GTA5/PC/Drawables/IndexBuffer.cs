using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000109 RID: 265
	public class IndexBuffer : ResourceSystemBlock
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000453 RID: 1107 RVA: 0x000090FA File Offset: 0x000072FA
		public override long Length
		{
			get
			{
				return 96L;
			}
		}

		// Token: 0x06000454 RID: 1108 RVA: 0x0001CDF8 File Offset: 0x0001AFF8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.IndicesCount = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.IndicesPointer = reader.ReadUInt64();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Indices = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.IndicesPointer, new object[]
			{
				this.IndicesCount
			});
		}

		// Token: 0x06000455 RID: 1109 RVA: 0x0001CF40 File Offset: 0x0001B140
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.IndicesCount = (uint)((this.Indices != null) ? this.Indices.Count : 0);
			this.IndicesPointer = (ulong)((this.Indices != null) ? this.Indices.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.IndicesCount);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.IndicesPointer);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
		}

		// Token: 0x06000456 RID: 1110 RVA: 0x0001D09C File Offset: 0x0001B29C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Indices != null)
			{
				list.Add(this.Indices);
			}
			return list.ToArray();
		}

		// Token: 0x0400319A RID: 12698
		public uint VFT;

		// Token: 0x0400319B RID: 12699
		public uint Unknown_4h;

		// Token: 0x0400319C RID: 12700
		public uint IndicesCount;

		// Token: 0x0400319D RID: 12701
		public uint Unknown_Ch;

		// Token: 0x0400319E RID: 12702
		public ulong IndicesPointer;

		// Token: 0x0400319F RID: 12703
		public uint Unknown_18h;

		// Token: 0x040031A0 RID: 12704
		public uint Unknown_1Ch;

		// Token: 0x040031A1 RID: 12705
		public uint Unknown_20h;

		// Token: 0x040031A2 RID: 12706
		public uint Unknown_24h;

		// Token: 0x040031A3 RID: 12707
		public uint Unknown_28h;

		// Token: 0x040031A4 RID: 12708
		public uint Unknown_2Ch;

		// Token: 0x040031A5 RID: 12709
		public uint Unknown_30h;

		// Token: 0x040031A6 RID: 12710
		public uint Unknown_34h;

		// Token: 0x040031A7 RID: 12711
		public uint Unknown_38h;

		// Token: 0x040031A8 RID: 12712
		public uint Unknown_3Ch;

		// Token: 0x040031A9 RID: 12713
		public uint Unknown_40h;

		// Token: 0x040031AA RID: 12714
		public uint Unknown_44h;

		// Token: 0x040031AB RID: 12715
		public uint Unknown_48h;

		// Token: 0x040031AC RID: 12716
		public uint Unknown_4Ch;

		// Token: 0x040031AD RID: 12717
		public uint Unknown_50h;

		// Token: 0x040031AE RID: 12718
		public uint Unknown_54h;

		// Token: 0x040031AF RID: 12719
		public uint Unknown_58h;

		// Token: 0x040031B0 RID: 12720
		public uint Unknown_5Ch;

		// Token: 0x040031B1 RID: 12721
		public ResourceSimpleArray<ushort_r> Indices;
	}
}
