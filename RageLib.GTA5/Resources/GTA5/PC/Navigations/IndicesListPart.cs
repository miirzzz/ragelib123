using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005B RID: 91
	public class IndicesListPart : ResourceSystemBlock
	{
		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000BBF4 File Offset: 0x00009DF4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.IndicesPointer = reader.ReadUInt64();
			this.IndicesCount = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Indices = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.IndicesPointer, new object[]
			{
				this.IndicesCount
			});
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000BC4C File Offset: 0x00009E4C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.IndicesPointer = (ulong)((this.Indices != null) ? this.Indices.Position : 0L);
			this.IndicesCount = (uint)((this.Indices != null) ? this.Indices.Count : 0);
			writer.Write(this.IndicesPointer);
			writer.Write(this.IndicesCount);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000BCB8 File Offset: 0x00009EB8
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Indices != null)
			{
				list.Add(this.Indices);
			}
			return list.ToArray();
		}

		// Token: 0x0400043D RID: 1085
		public ulong IndicesPointer;

		// Token: 0x0400043E RID: 1086
		public uint IndicesCount;

		// Token: 0x0400043F RID: 1087
		public uint Unknown_Ch;

		// Token: 0x04000440 RID: 1088
		public ResourceSimpleArray<ushort_r> Indices;
	}
}
