using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200014C RID: 332
	public class Unknown_C_007 : ResourceSystemBlock
	{
		// Token: 0x17000149 RID: 329
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x000230CE File Offset: 0x000212CE
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00023100 File Offset: 0x00021300
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x040034EC RID: 13548
		public uint Unknown_0h;

		// Token: 0x040034ED RID: 13549
		public uint Unknown_4h;

		// Token: 0x040034EE RID: 13550
		public uint Unknown_8h;

		// Token: 0x040034EF RID: 13551
		public uint Unknown_Ch;
	}
}
