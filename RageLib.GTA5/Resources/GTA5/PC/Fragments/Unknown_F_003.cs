using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000FC RID: 252
	public class Unknown_F_003 : ResourceSystemBlock
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x0001AC7B File Offset: 0x00018E7B
		public override long Length
		{
			get
			{
				return 32L + this.Data.Length;
			}
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001AC8C File Offset: 0x00018E8C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.cnt1 = reader.ReadByte();
			this.cnt2 = reader.ReadByte();
			this.Unknown_12h = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlock<ResourceSimpleArray<RAGE_Matrix3>>(new object[]
			{
				this.cnt1
			});
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x0001AD34 File Offset: 0x00018F34
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.cnt1);
			writer.Write(this.cnt2);
			writer.Write(this.Unknown_12h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Data);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001ADC5 File Offset: 0x00018FC5
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.Data)
			};
		}

		// Token: 0x04003099 RID: 12441
		public uint Unknown_0h;

		// Token: 0x0400309A RID: 12442
		public uint Unknown_4h;

		// Token: 0x0400309B RID: 12443
		public uint Unknown_8h;

		// Token: 0x0400309C RID: 12444
		public uint Unknown_Ch;

		// Token: 0x0400309D RID: 12445
		public byte cnt1;

		// Token: 0x0400309E RID: 12446
		public byte cnt2;

		// Token: 0x0400309F RID: 12447
		public ushort Unknown_12h;

		// Token: 0x040030A0 RID: 12448
		public uint Unknown_14h;

		// Token: 0x040030A1 RID: 12449
		public uint Unknown_18h;

		// Token: 0x040030A2 RID: 12450
		public uint Unknown_1Ch;

		// Token: 0x040030A3 RID: 12451
		public ResourceSimpleArray<RAGE_Matrix3> Data;
	}
}
