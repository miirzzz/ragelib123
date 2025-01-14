using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000144 RID: 324
	public class EnvClothVerletBehavior : ResourceSystemBlock
	{
		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00021F08 File Offset: 0x00020108
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
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00021FD8 File Offset: 0x000201D8
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
		}

		// Token: 0x04003456 RID: 13398
		public uint Unknown_0h;

		// Token: 0x04003457 RID: 13399
		public uint Unknown_4h;

		// Token: 0x04003458 RID: 13400
		public uint Unknown_8h;

		// Token: 0x04003459 RID: 13401
		public uint Unknown_Ch;

		// Token: 0x0400345A RID: 13402
		public uint Unknown_10h;

		// Token: 0x0400345B RID: 13403
		public uint Unknown_14h;

		// Token: 0x0400345C RID: 13404
		public uint Unknown_18h;

		// Token: 0x0400345D RID: 13405
		public uint Unknown_1Ch;

		// Token: 0x0400345E RID: 13406
		public uint Unknown_20h;

		// Token: 0x0400345F RID: 13407
		public uint Unknown_24h;

		// Token: 0x04003460 RID: 13408
		public uint Unknown_28h;

		// Token: 0x04003461 RID: 13409
		public uint Unknown_2Ch;

		// Token: 0x04003462 RID: 13410
		public uint Unknown_30h;

		// Token: 0x04003463 RID: 13411
		public uint Unknown_34h;

		// Token: 0x04003464 RID: 13412
		public uint Unknown_38h;

		// Token: 0x04003465 RID: 13413
		public uint Unknown_3Ch;
	}
}
