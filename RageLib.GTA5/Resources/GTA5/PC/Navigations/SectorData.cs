using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Navigations
{
	// Token: 0x02000062 RID: 98
	public class SectorData : ResourceSystemBlock
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000206 RID: 518 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000CF6C File Offset: 0x0000B16C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.c1 = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.p1 = reader.ReadUInt64();
			this.p2 = reader.ReadUInt64();
			this.c2 = reader.ReadUInt16();
			this.c3 = reader.ReadUInt16();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.p1data = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.p1, new object[]
			{
				this.c2
			});
			this.p2data = reader.ReadBlockAt<ResourceSimpleArray<SectorDataUnk>>(this.p2, new object[]
			{
				this.c3
			});
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000D01C File Offset: 0x0000B21C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			this.p2 = (ulong)((this.p2data != null) ? this.p2data.Position : 0L);
			this.c2 = (ushort)((this.p1data != null) ? this.p1data.Count : 0);
			this.c3 = (ushort)((this.p2data != null) ? this.p2data.Count : 0);
			writer.Write(this.c1);
			writer.Write(this.Unknown_4h);
			writer.Write(this.p1);
			writer.Write(this.p2);
			writer.Write(this.c2);
			writer.Write(this.c3);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000D0F4 File Offset: 0x0000B2F4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			if (this.p2data != null)
			{
				list.Add(this.p2data);
			}
			return list.ToArray();
		}

		// Token: 0x040004D6 RID: 1238
		public uint c1;

		// Token: 0x040004D7 RID: 1239
		public uint Unknown_4h;

		// Token: 0x040004D8 RID: 1240
		public ulong p1;

		// Token: 0x040004D9 RID: 1241
		public ulong p2;

		// Token: 0x040004DA RID: 1242
		public ushort c2;

		// Token: 0x040004DB RID: 1243
		public ushort c3;

		// Token: 0x040004DC RID: 1244
		public uint Unknown_1Ch;

		// Token: 0x040004DD RID: 1245
		public ResourceSimpleArray<ushort_r> p1data;

		// Token: 0x040004DE RID: 1246
		public ResourceSimpleArray<SectorDataUnk> p2data;
	}
}
