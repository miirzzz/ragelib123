using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000066 RID: 102
	public class VerticesListPart : ResourceSystemBlock
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000218 RID: 536 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000D3E0 File Offset: 0x0000B5E0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VerticesPointer = reader.ReadUInt64();
			this.VerticesCount = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Vertices = reader.ReadBlockAt<ResourceSimpleArray<Vertex>>(this.VerticesPointer, new object[]
			{
				this.VerticesCount
			});
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000D438 File Offset: 0x0000B638
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.VerticesPointer = (ulong)((this.Vertices != null) ? this.Vertices.Position : 0L);
			this.VerticesCount = (uint)((this.Vertices != null) ? this.Vertices.Count : 0);
			writer.Write(this.VerticesPointer);
			writer.Write(this.VerticesCount);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000D4A4 File Offset: 0x0000B6A4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Vertices != null)
			{
				list.Add(this.Vertices);
			}
			return list.ToArray();
		}

		// Token: 0x040004F2 RID: 1266
		public ulong VerticesPointer;

		// Token: 0x040004F3 RID: 1267
		public uint VerticesCount;

		// Token: 0x040004F4 RID: 1268
		public uint Unknown_Ch;

		// Token: 0x040004F5 RID: 1269
		public ResourceSimpleArray<Vertex> Vertices;
	}
}
