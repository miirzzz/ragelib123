using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000048 RID: 72
	public class Unknown_P_004 : ResourceSystemBlock
	{
		// Token: 0x17000060 RID: 96
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000A544 File Offset: 0x00008744
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_002>>(Array.Empty<object>());
			this.Unknown_10h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_003>>(Array.Empty<object>());
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_007>>(Array.Empty<object>());
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000A5B4 File Offset: 0x000087B4
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

		// Token: 0x06000190 RID: 400 RVA: 0x0000A615 File Offset: 0x00008815
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(0L, this.Unknown_0h),
				new Tuple<long, IResourceBlock>(16L, this.Unknown_10h),
				new Tuple<long, IResourceBlock>(40L, this.Unknown_28h)
			};
		}

		// Token: 0x0400039F RID: 927
		public ResourceSimpleList64<Unknown_P_002> Unknown_0h;

		// Token: 0x040003A0 RID: 928
		public ResourceSimpleList64<Unknown_P_003> Unknown_10h;

		// Token: 0x040003A1 RID: 929
		public uint Unknown_20h;

		// Token: 0x040003A2 RID: 930
		public uint Unknown_24h;

		// Token: 0x040003A3 RID: 931
		public ResourceSimpleList64<Unknown_P_007> Unknown_28h;

		// Token: 0x040003A4 RID: 932
		public uint Unknown_38h;

		// Token: 0x040003A5 RID: 933
		public uint Unknown_3Ch;
	}
}
