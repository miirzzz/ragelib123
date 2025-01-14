using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000149 RID: 329
	public class Unknown_C_003 : ResourceSystemBlock
	{
		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004FF RID: 1279 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00022810 File Offset: 0x00020A10
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
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00022880 File Offset: 0x00020A80
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
		}

		// Token: 0x0400349F RID: 13471
		public uint Unknown_0h;

		// Token: 0x040034A0 RID: 13472
		public uint Unknown_4h;

		// Token: 0x040034A1 RID: 13473
		public uint Unknown_8h;

		// Token: 0x040034A2 RID: 13474
		public uint Unknown_Ch;

		// Token: 0x040034A3 RID: 13475
		public uint Unknown_10h;

		// Token: 0x040034A4 RID: 13476
		public uint Unknown_14h;

		// Token: 0x040034A5 RID: 13477
		public uint Unknown_18h;

		// Token: 0x040034A6 RID: 13478
		public uint Unknown_1Ch;
	}
}
