using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000059 RID: 89
	public class AdjPolysListPart : ResourceSystemBlock
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001DB RID: 475 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000B90C File Offset: 0x00009B0C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.AdjPolysPointer = reader.ReadUInt64();
			this.AdjPolysCount = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.AdjPolys = reader.ReadBlockAt<ResourceSimpleArray<AdjPoly>>(this.AdjPolysPointer, new object[]
			{
				this.AdjPolysCount
			});
		}

		// Token: 0x060001DD RID: 477 RVA: 0x0000B964 File Offset: 0x00009B64
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.AdjPolysPointer = (ulong)((this.AdjPolys != null) ? this.AdjPolys.Position : 0L);
			this.AdjPolysCount = (uint)((this.AdjPolys != null) ? this.AdjPolys.Count : 0);
			writer.Write(this.AdjPolysPointer);
			writer.Write(this.AdjPolysCount);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000B9D0 File Offset: 0x00009BD0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.AdjPolys != null)
			{
				list.Add(this.AdjPolys);
			}
			return list.ToArray();
		}

		// Token: 0x0400042D RID: 1069
		public ulong AdjPolysPointer;

		// Token: 0x0400042E RID: 1070
		public uint AdjPolysCount;

		// Token: 0x0400042F RID: 1071
		public uint Unknown_Ch;

		// Token: 0x04000430 RID: 1072
		public ResourceSimpleArray<AdjPoly> AdjPolys;
	}
}
