using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000140 RID: 320
	public class ClothBridgeSimGfx : ResourceSystemBlock
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000212FF File Offset: 0x0001F4FF
		public override long Length
		{
			get
			{
				return 320L;
			}
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00021308 File Offset: 0x0001F508
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadBlock<ResourceSimpleList64<float_r>>(Array.Empty<object>());
			this.Unknown_30h = reader.ReadBlock<ResourceSimpleList64<float_r>>(Array.Empty<object>());
			this.Unknown_40h = reader.ReadBlock<ResourceSimpleList64<float_r>>(Array.Empty<object>());
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadBlock<ResourceSimpleList64<float_r>>(Array.Empty<object>());
			this.Unknown_70h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_80h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadBlock<ResourceSimpleList64<float_r>>(Array.Empty<object>());
			this.Unknown_B0h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_C0h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_F0h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_100h = reader.ReadBlock<ResourceSimpleList64<ushort_r>>(Array.Empty<object>());
			this.Unknown_110h = reader.ReadUInt32();
			this.Unknown_114h = reader.ReadUInt32();
			this.Unknown_118h = reader.ReadUInt32();
			this.Unknown_11Ch = reader.ReadUInt32();
			this.Unknown_120h = reader.ReadUInt32();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00021544 File Offset: 0x0001F744
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Unknown_20h);
			writer.WriteBlock(this.Unknown_30h);
			writer.WriteBlock(this.Unknown_40h);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.WriteBlock(this.Unknown_60h);
			writer.WriteBlock(this.Unknown_70h);
			writer.WriteBlock(this.Unknown_80h);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.WriteBlock(this.Unknown_A0h);
			writer.WriteBlock(this.Unknown_B0h);
			writer.WriteBlock(this.Unknown_C0h);
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.WriteBlock(this.Unknown_E0h);
			writer.WriteBlock(this.Unknown_F0h);
			writer.WriteBlock(this.Unknown_100h);
			writer.Write(this.Unknown_110h);
			writer.Write(this.Unknown_114h);
			writer.Write(this.Unknown_118h);
			writer.Write(this.Unknown_11Ch);
			writer.Write(this.Unknown_120h);
			writer.Write(this.Unknown_124h);
			writer.WriteBlock(this.Unknown_128h);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00021740 File Offset: 0x0001F940
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.Unknown_20h),
				new Tuple<long, IResourceBlock>(48L, this.Unknown_30h),
				new Tuple<long, IResourceBlock>(64L, this.Unknown_40h),
				new Tuple<long, IResourceBlock>(96L, this.Unknown_60h),
				new Tuple<long, IResourceBlock>(112L, this.Unknown_70h),
				new Tuple<long, IResourceBlock>(128L, this.Unknown_80h),
				new Tuple<long, IResourceBlock>(160L, this.Unknown_A0h),
				new Tuple<long, IResourceBlock>(176L, this.Unknown_B0h),
				new Tuple<long, IResourceBlock>(192L, this.Unknown_C0h),
				new Tuple<long, IResourceBlock>(224L, this.Unknown_E0h),
				new Tuple<long, IResourceBlock>(240L, this.Unknown_F0h),
				new Tuple<long, IResourceBlock>(256L, this.Unknown_100h),
				new Tuple<long, IResourceBlock>(296L, this.Unknown_128h)
			};
		}

		// Token: 0x040033F7 RID: 13303
		public uint VFT;

		// Token: 0x040033F8 RID: 13304
		public uint Unknown_4h;

		// Token: 0x040033F9 RID: 13305
		public uint Unknown_8h;

		// Token: 0x040033FA RID: 13306
		public uint Unknown_Ch;

		// Token: 0x040033FB RID: 13307
		public uint Unknown_10h;

		// Token: 0x040033FC RID: 13308
		public uint Unknown_14h;

		// Token: 0x040033FD RID: 13309
		public uint Unknown_18h;

		// Token: 0x040033FE RID: 13310
		public uint Unknown_1Ch;

		// Token: 0x040033FF RID: 13311
		public ResourceSimpleList64<float_r> Unknown_20h;

		// Token: 0x04003400 RID: 13312
		public ResourceSimpleList64<float_r> Unknown_30h;

		// Token: 0x04003401 RID: 13313
		public ResourceSimpleList64<float_r> Unknown_40h;

		// Token: 0x04003402 RID: 13314
		public uint Unknown_50h;

		// Token: 0x04003403 RID: 13315
		public uint Unknown_54h;

		// Token: 0x04003404 RID: 13316
		public uint Unknown_58h;

		// Token: 0x04003405 RID: 13317
		public uint Unknown_5Ch;

		// Token: 0x04003406 RID: 13318
		public ResourceSimpleList64<float_r> Unknown_60h;

		// Token: 0x04003407 RID: 13319
		public ResourceSimpleList64<uint_r> Unknown_70h;

		// Token: 0x04003408 RID: 13320
		public ResourceSimpleList64<uint_r> Unknown_80h;

		// Token: 0x04003409 RID: 13321
		public uint Unknown_90h;

		// Token: 0x0400340A RID: 13322
		public uint Unknown_94h;

		// Token: 0x0400340B RID: 13323
		public uint Unknown_98h;

		// Token: 0x0400340C RID: 13324
		public uint Unknown_9Ch;

		// Token: 0x0400340D RID: 13325
		public ResourceSimpleList64<float_r> Unknown_A0h;

		// Token: 0x0400340E RID: 13326
		public ResourceSimpleList64<uint_r> Unknown_B0h;

		// Token: 0x0400340F RID: 13327
		public ResourceSimpleList64<uint_r> Unknown_C0h;

		// Token: 0x04003410 RID: 13328
		public uint Unknown_D0h;

		// Token: 0x04003411 RID: 13329
		public uint Unknown_D4h;

		// Token: 0x04003412 RID: 13330
		public uint Unknown_D8h;

		// Token: 0x04003413 RID: 13331
		public uint Unknown_DCh;

		// Token: 0x04003414 RID: 13332
		public ResourceSimpleList64<ushort_r> Unknown_E0h;

		// Token: 0x04003415 RID: 13333
		public ResourceSimpleList64<ushort_r> Unknown_F0h;

		// Token: 0x04003416 RID: 13334
		public ResourceSimpleList64<ushort_r> Unknown_100h;

		// Token: 0x04003417 RID: 13335
		public uint Unknown_110h;

		// Token: 0x04003418 RID: 13336
		public uint Unknown_114h;

		// Token: 0x04003419 RID: 13337
		public uint Unknown_118h;

		// Token: 0x0400341A RID: 13338
		public uint Unknown_11Ch;

		// Token: 0x0400341B RID: 13339
		public uint Unknown_120h;

		// Token: 0x0400341C RID: 13340
		public uint Unknown_124h;

		// Token: 0x0400341D RID: 13341
		public ResourceSimpleList64<uint_r> Unknown_128h;

		// Token: 0x0400341E RID: 13342
		public uint Unknown_138h;

		// Token: 0x0400341F RID: 13343
		public uint Unknown_13Ch;
	}
}
