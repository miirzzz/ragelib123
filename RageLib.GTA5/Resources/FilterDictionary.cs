using System;
using RageLib.Resources.Common;

namespace RageLib.Resources
{
	// Token: 0x0200000E RID: 14
	public class FilterDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000057 RID: 87 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00003040 File Offset: 0x00001240
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.FilterNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Filters = reader.ReadBlock<ResourcePointerList64<Filter>>(Array.Empty<object>());
		}

		// Token: 0x06000059 RID: 89 RVA: 0x000030A8 File Offset: 0x000012A8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.FilterNameHashes);
			writer.WriteBlock(this.Filters);
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00003105 File Offset: 0x00001305
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.FilterNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.Filters)
			};
		}

		// Token: 0x0400003F RID: 63
		public uint Unknown_10h;

		// Token: 0x04000040 RID: 64
		public uint Unknown_14h;

		// Token: 0x04000041 RID: 65
		public uint Unknown_18h;

		// Token: 0x04000042 RID: 66
		public uint Unknown_1Ch;

		// Token: 0x04000043 RID: 67
		public ResourceSimpleList64<uint_r> FilterNameHashes;

		// Token: 0x04000044 RID: 68
		public ResourcePointerList64<Filter> Filters;
	}
}
