using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000045 RID: 69
	public class Unknown_P_001 : ResourceSystemBlock
	{
		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600017F RID: 383 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000A304 File Offset: 0x00008504
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

		// Token: 0x06000181 RID: 385 RVA: 0x0000A374 File Offset: 0x00008574
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

		// Token: 0x0400038E RID: 910
		public uint Unknown_0h;

		// Token: 0x0400038F RID: 911
		public uint Unknown_4h;

		// Token: 0x04000390 RID: 912
		public uint Unknown_8h;

		// Token: 0x04000391 RID: 913
		public uint Unknown_Ch;

		// Token: 0x04000392 RID: 914
		public uint Unknown_10h;

		// Token: 0x04000393 RID: 915
		public uint Unknown_14h;

		// Token: 0x04000394 RID: 916
		public uint Unknown_18h;

		// Token: 0x04000395 RID: 917
		public uint Unknown_1Ch;
	}
}
