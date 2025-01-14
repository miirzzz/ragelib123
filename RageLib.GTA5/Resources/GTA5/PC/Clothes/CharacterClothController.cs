using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200013F RID: 319
	public class CharacterClothController : ClothController
	{
		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00006A69 File Offset: 0x00004C69
		public override long Length
		{
			get
			{
				return 240L;
			}
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00021100 File Offset: 0x0001F300
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_80h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_90h = reader.ReadBlock<ResourceSimpleList64<Unknown_C_002>>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_C0h = reader.ReadBlock<ResourceSimpleList64<Unknown_C_003>>(Array.Empty<object>());
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x000211CC File Offset: 0x0001F3CC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.WriteBlock(this.Unknown_80h);
			writer.WriteBlock(this.Unknown_90h);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.WriteBlock(this.Unknown_B0h);
			writer.WriteBlock(this.Unknown_C0h);
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.WriteBlock(this.Unknown_E0h);
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00021280 File Offset: 0x0001F480
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(128L, this.Unknown_80h),
				new Tuple<long, IResourceBlock>(144L, this.Unknown_90h),
				new Tuple<long, IResourceBlock>(176L, this.Unknown_B0h),
				new Tuple<long, IResourceBlock>(192L, this.Unknown_C0h),
				new Tuple<long, IResourceBlock>(224L, this.Unknown_E0h)
			};
		}

		// Token: 0x040033EA RID: 13290
		public ResourceSimpleList64<ushort_r> Unknown_80h;

		// Token: 0x040033EB RID: 13291
		public ResourceSimpleList64<Unknown_C_002> Unknown_90h;

		// Token: 0x040033EC RID: 13292
		public uint Unknown_A0h;

		// Token: 0x040033ED RID: 13293
		public uint Unknown_A4h;

		// Token: 0x040033EE RID: 13294
		public uint Unknown_A8h;

		// Token: 0x040033EF RID: 13295
		public uint Unknown_ACh;

		// Token: 0x040033F0 RID: 13296
		public ResourceSimpleList64<uint_r> Unknown_B0h;

		// Token: 0x040033F1 RID: 13297
		public ResourceSimpleList64<Unknown_C_003> Unknown_C0h;

		// Token: 0x040033F2 RID: 13298
		public uint Unknown_D0h;

		// Token: 0x040033F3 RID: 13299
		public uint Unknown_D4h;

		// Token: 0x040033F4 RID: 13300
		public uint Unknown_D8h;

		// Token: 0x040033F5 RID: 13301
		public uint Unknown_DCh;

		// Token: 0x040033F6 RID: 13302
		public ResourceSimpleList64<uint_r> Unknown_E0h;
	}
}
