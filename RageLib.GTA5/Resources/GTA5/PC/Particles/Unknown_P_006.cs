using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004A RID: 74
	public class Unknown_P_006 : ResourceSystemBlock
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000A75C File Offset: 0x0000895C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_009>>(Array.Empty<object>());
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000A7DC File Offset: 0x000089DC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.WriteBlock(this.Unknown_0h);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000A855 File Offset: 0x00008A55
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(0L, this.Unknown_0h)
			};
		}

		// Token: 0x040003AD RID: 941
		public ResourceSimpleList64<Unknown_P_009> Unknown_0h;

		// Token: 0x040003AE RID: 942
		public uint Unknown_10h;

		// Token: 0x040003AF RID: 943
		public uint Unknown_14h;

		// Token: 0x040003B0 RID: 944
		public uint Unknown_18h;

		// Token: 0x040003B1 RID: 945
		public uint Unknown_1Ch;

		// Token: 0x040003B2 RID: 946
		public uint Unknown_20h;

		// Token: 0x040003B3 RID: 947
		public uint Unknown_24h;

		// Token: 0x040003B4 RID: 948
		public uint Unknown_28h;

		// Token: 0x040003B5 RID: 949
		public uint Unknown_2Ch;
	}
}
