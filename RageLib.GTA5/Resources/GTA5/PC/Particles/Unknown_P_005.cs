using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000049 RID: 73
	public class Unknown_P_005 : ResourceSystemBlock
	{
		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000A650 File Offset: 0x00008850
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_008>>(Array.Empty<object>());
			this.Unknown_10h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_003>>(Array.Empty<object>());
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_010>>(Array.Empty<object>());
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000A6C0 File Offset: 0x000088C0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.WriteBlock(this.Unknown_0h);
			writer.WriteBlock(this.Unknown_10h);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.WriteBlock(this.Unknown_28h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000A721 File Offset: 0x00008921
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(0L, this.Unknown_0h),
				new Tuple<long, IResourceBlock>(16L, this.Unknown_10h),
				new Tuple<long, IResourceBlock>(40L, this.Unknown_28h)
			};
		}

		// Token: 0x040003A6 RID: 934
		public ResourceSimpleList64<Unknown_P_008> Unknown_0h;

		// Token: 0x040003A7 RID: 935
		public ResourceSimpleList64<Unknown_P_003> Unknown_10h;

		// Token: 0x040003A8 RID: 936
		public uint Unknown_20h;

		// Token: 0x040003A9 RID: 937
		public uint Unknown_24h;

		// Token: 0x040003AA RID: 938
		public ResourceSimpleList64<Unknown_P_010> Unknown_28h;

		// Token: 0x040003AB RID: 939
		public uint Unknown_38h;

		// Token: 0x040003AC RID: 940
		public uint Unknown_3Ch;
	}
}
