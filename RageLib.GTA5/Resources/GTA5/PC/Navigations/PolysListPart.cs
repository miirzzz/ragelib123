using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x0200005F RID: 95
	public class PolysListPart : ResourceSystemBlock
	{
		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000CA14 File Offset: 0x0000AC14
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.PolysPointer = reader.ReadUInt64();
			this.PolysCount = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Polys = reader.ReadBlockAt<ResourceSimpleArray<Poly>>(this.PolysPointer, new object[]
			{
				this.PolysCount
			});
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.PolysPointer = (ulong)((this.Polys != null) ? this.Polys.Position : 0L);
			this.PolysCount = (uint)((this.Polys != null) ? this.Polys.Count : 0);
			writer.Write(this.PolysPointer);
			writer.Write(this.PolysCount);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Polys != null)
			{
				list.Add(this.Polys);
			}
			return list.ToArray();
		}

		// Token: 0x040004B1 RID: 1201
		public ulong PolysPointer;

		// Token: 0x040004B2 RID: 1202
		public uint PolysCount;

		// Token: 0x040004B3 RID: 1203
		public uint Unknown_Ch;

		// Token: 0x040004B4 RID: 1204
		public ResourceSimpleArray<Poly> Polys;
	}
}
