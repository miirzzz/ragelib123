using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200014E RID: 334
	public class Animation : ResourceSystemBlock
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x06000516 RID: 1302 RVA: 0x000090FA File Offset: 0x000072FA
		public override long Length
		{
			get
			{
				return 96L;
			}
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00023A50 File Offset: 0x00021C50
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt16();
			this.Unknown_12h = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt16();
			this.Unknown_16h = reader.ReadUInt16();
			this.Unknown_18h = reader.ReadSingle();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Sequences = reader.ReadBlock<ResourcePointerList64<Sequence>>(Array.Empty<object>());
			this.Unknown_50h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00023B58 File Offset: 0x00021D58
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_12h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_16h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.WriteBlock(this.Sequences);
			writer.WriteBlock(this.Unknown_50h);
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00023C55 File Offset: 0x00021E55
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(64L, this.Sequences),
				new Tuple<long, IResourceBlock>(80L, this.Unknown_50h)
			};
		}

		// Token: 0x04003544 RID: 13636
		public uint VFT;

		// Token: 0x04003545 RID: 13637
		public uint Unknown_4h;

		// Token: 0x04003546 RID: 13638
		public uint Unknown_8h;

		// Token: 0x04003547 RID: 13639
		public uint Unknown_Ch;

		// Token: 0x04003548 RID: 13640
		public ushort Unknown_10h;

		// Token: 0x04003549 RID: 13641
		public ushort Unknown_12h;

		// Token: 0x0400354A RID: 13642
		public ushort Unknown_14h;

		// Token: 0x0400354B RID: 13643
		public ushort Unknown_16h;

		// Token: 0x0400354C RID: 13644
		public float Unknown_18h;

		// Token: 0x0400354D RID: 13645
		public uint Unknown_1Ch;

		// Token: 0x0400354E RID: 13646
		public uint Unknown_20h;

		// Token: 0x0400354F RID: 13647
		public uint Unknown_24h;

		// Token: 0x04003550 RID: 13648
		public uint Unknown_28h;

		// Token: 0x04003551 RID: 13649
		public uint Unknown_2Ch;

		// Token: 0x04003552 RID: 13650
		public uint Unknown_30h;

		// Token: 0x04003553 RID: 13651
		public uint Unknown_34h;

		// Token: 0x04003554 RID: 13652
		public uint Unknown_38h;

		// Token: 0x04003555 RID: 13653
		public uint Unknown_3Ch;

		// Token: 0x04003556 RID: 13654
		public ResourcePointerList64<Sequence> Sequences;

		// Token: 0x04003557 RID: 13655
		public ResourceSimpleList64<uint_r> Unknown_50h;
	}
}
