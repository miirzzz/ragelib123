using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000051 RID: 81
	public class Unknown_P_013 : ResourceSystemBlock
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000AE55 File Offset: 0x00009055
		public override long Length
		{
			get
			{
				return 88L;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000AE5C File Offset: 0x0000905C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000AF54 File Offset: 0x00009154
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
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
			writer.WriteBlock(this.Unknown_40h);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000B045 File Offset: 0x00009245
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(64L, this.Unknown_40h)
			};
		}

		// Token: 0x040003E0 RID: 992
		public uint Unknown_0h;

		// Token: 0x040003E1 RID: 993
		public uint Unknown_4h;

		// Token: 0x040003E2 RID: 994
		public uint Unknown_8h;

		// Token: 0x040003E3 RID: 995
		public uint Unknown_Ch;

		// Token: 0x040003E4 RID: 996
		public uint Unknown_10h;

		// Token: 0x040003E5 RID: 997
		public uint Unknown_14h;

		// Token: 0x040003E6 RID: 998
		public uint Unknown_18h;

		// Token: 0x040003E7 RID: 999
		public uint Unknown_1Ch;

		// Token: 0x040003E8 RID: 1000
		public uint Unknown_20h;

		// Token: 0x040003E9 RID: 1001
		public uint Unknown_24h;

		// Token: 0x040003EA RID: 1002
		public uint Unknown_28h;

		// Token: 0x040003EB RID: 1003
		public uint Unknown_2Ch;

		// Token: 0x040003EC RID: 1004
		public uint Unknown_30h;

		// Token: 0x040003ED RID: 1005
		public uint Unknown_34h;

		// Token: 0x040003EE RID: 1006
		public uint Unknown_38h;

		// Token: 0x040003EF RID: 1007
		public uint Unknown_3Ch;

		// Token: 0x040003F0 RID: 1008
		public ResourceSimpleList64<uint_r> Unknown_40h;

		// Token: 0x040003F1 RID: 1009
		public uint Unknown_50h;

		// Token: 0x040003F2 RID: 1010
		public uint Unknown_54h;
	}
}
