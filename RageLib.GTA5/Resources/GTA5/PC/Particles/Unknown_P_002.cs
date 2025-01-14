using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000046 RID: 70
	public class Unknown_P_002 : ResourceSystemBlock
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000A3E4 File Offset: 0x000085E4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.p1 = reader.ReadUInt64();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.p1data = reader.ReadBlockAt<string_r>(this.p1, Array.Empty<object>());
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000A444 File Offset: 0x00008644
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			writer.Write(this.p1);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000A4AC File Offset: 0x000086AC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			return list.ToArray();
		}

		// Token: 0x04000396 RID: 918
		public ulong p1;

		// Token: 0x04000397 RID: 919
		public uint Unknown_8h;

		// Token: 0x04000398 RID: 920
		public uint Unknown_Ch;

		// Token: 0x04000399 RID: 921
		public uint Unknown_10h;

		// Token: 0x0400039A RID: 922
		public uint Unknown_14h;

		// Token: 0x0400039B RID: 923
		public string_r p1data;
	}
}
