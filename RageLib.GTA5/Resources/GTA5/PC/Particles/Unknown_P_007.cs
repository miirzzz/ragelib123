using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004B RID: 75
	public class Unknown_P_007 : ResourceSystemBlock
	{
		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600019C RID: 412 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000A86D File Offset: 0x00008A6D
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.p1 = reader.ReadUInt64();
			this.p1data = reader.ReadBlockAt<Unknown_P_003>(this.p1, Array.Empty<object>());
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000A8AC File Offset: 0x00008AAC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.p1);
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			return list.ToArray();
		}

		// Token: 0x040003B6 RID: 950
		public uint Unknown_0h;

		// Token: 0x040003B7 RID: 951
		public uint Unknown_4h;

		// Token: 0x040003B8 RID: 952
		public ulong p1;

		// Token: 0x040003B9 RID: 953
		public Unknown_P_003 p1data;
	}
}
