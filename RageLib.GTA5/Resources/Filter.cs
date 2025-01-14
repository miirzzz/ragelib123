using System;
using RageLib.Resources.Common;

namespace RageLib.Resources
{
	// Token: 0x0200000D RID: 13
	public class Filter : ResourceSystemBlock
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002F00 File Offset: 0x00001100
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadBlock<ResourceSimpleList64<ulong_r>>(Array.Empty<object>());
			this.Unknown_28h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002F90 File Offset: 0x00001190
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.WriteBlock(this.Unknown_18h);
			writer.WriteBlock(this.Unknown_28h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00003015 File Offset: 0x00001215
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(24L, this.Unknown_18h),
				new Tuple<long, IResourceBlock>(40L, this.Unknown_28h)
			};
		}

		// Token: 0x04000035 RID: 53
		public uint VFT;

		// Token: 0x04000036 RID: 54
		public uint Unknown_4h;

		// Token: 0x04000037 RID: 55
		public uint Unknown_8h;

		// Token: 0x04000038 RID: 56
		public uint Unknown_Ch;

		// Token: 0x04000039 RID: 57
		public uint Unknown_10h;

		// Token: 0x0400003A RID: 58
		public uint Unknown_14h;

		// Token: 0x0400003B RID: 59
		public ResourceSimpleList64<ulong_r> Unknown_18h;

		// Token: 0x0400003C RID: 60
		public ResourceSimpleList64<uint_r> Unknown_28h;

		// Token: 0x0400003D RID: 61
		public uint Unknown_38h;

		// Token: 0x0400003E RID: 62
		public uint Unknown_3Ch;
	}
}
