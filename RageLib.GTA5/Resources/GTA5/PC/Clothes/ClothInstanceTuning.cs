using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000143 RID: 323
	public class ClothInstanceTuning : ResourceSystemBlock
	{
		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00021D68 File Offset: 0x0001FF68
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
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00021E38 File Offset: 0x00020038
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
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x04003446 RID: 13382
		public uint VFT;

		// Token: 0x04003447 RID: 13383
		public uint Unknown_4h;

		// Token: 0x04003448 RID: 13384
		public uint Unknown_8h;

		// Token: 0x04003449 RID: 13385
		public uint Unknown_Ch;

		// Token: 0x0400344A RID: 13386
		public uint Unknown_10h;

		// Token: 0x0400344B RID: 13387
		public uint Unknown_14h;

		// Token: 0x0400344C RID: 13388
		public uint Unknown_18h;

		// Token: 0x0400344D RID: 13389
		public uint Unknown_1Ch;

		// Token: 0x0400344E RID: 13390
		public uint Unknown_20h;

		// Token: 0x0400344F RID: 13391
		public uint Unknown_24h;

		// Token: 0x04003450 RID: 13392
		public uint Unknown_28h;

		// Token: 0x04003451 RID: 13393
		public uint Unknown_2Ch;

		// Token: 0x04003452 RID: 13394
		public uint Unknown_30h;

		// Token: 0x04003453 RID: 13395
		public uint Unknown_34h;

		// Token: 0x04003454 RID: 13396
		public uint Unknown_38h;

		// Token: 0x04003455 RID: 13397
		public uint Unknown_3Ch;
	}
}
