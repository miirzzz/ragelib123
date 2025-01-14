using System;

namespace RageLib.Resources
{
	// Token: 0x02000009 RID: 9
	public class RAGE_Matrix3 : ResourceSystemBlock
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003A RID: 58 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000286D File Offset: 0x00000A6D
		public RAGE_Matrix3()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x0000298C File Offset: 0x00000B8C
		public RAGE_Matrix3(uint Unknown_0h, uint Unknown_4h, uint Unknown_8h, uint Unknown_Ch, uint Unknown_10h, uint Unknown_14h, uint Unknown_18h, uint Unknown_1Ch, uint Unknown_20h, uint Unknown_24h, uint Unknown_28h, uint Unknown_2Ch)
		{
			this.Unknown_0h = Unknown_0h;
			this.Unknown_4h = Unknown_4h;
			this.Unknown_8h = Unknown_8h;
			this.Unknown_Ch = Unknown_Ch;
			this.Unknown_10h = Unknown_10h;
			this.Unknown_14h = Unknown_14h;
			this.Unknown_18h = Unknown_18h;
			this.Unknown_1Ch = Unknown_1Ch;
			this.Unknown_20h = Unknown_20h;
			this.Unknown_24h = Unknown_24h;
			this.Unknown_28h = Unknown_28h;
			this.Unknown_2Ch = Unknown_2Ch;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000029FC File Offset: 0x00000BFC
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
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002A9C File Offset: 0x00000C9C
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
		}

		// Token: 0x04000012 RID: 18
		public uint Unknown_0h;

		// Token: 0x04000013 RID: 19
		public uint Unknown_4h;

		// Token: 0x04000014 RID: 20
		public uint Unknown_8h;

		// Token: 0x04000015 RID: 21
		public uint Unknown_Ch;

		// Token: 0x04000016 RID: 22
		public uint Unknown_10h;

		// Token: 0x04000017 RID: 23
		public uint Unknown_14h;

		// Token: 0x04000018 RID: 24
		public uint Unknown_18h;

		// Token: 0x04000019 RID: 25
		public uint Unknown_1Ch;

		// Token: 0x0400001A RID: 26
		public uint Unknown_20h;

		// Token: 0x0400001B RID: 27
		public uint Unknown_24h;

		// Token: 0x0400001C RID: 28
		public uint Unknown_28h;

		// Token: 0x0400001D RID: 29
		public uint Unknown_2Ch;
	}
}
