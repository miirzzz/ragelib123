using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004D RID: 77
	public class Unknown_P_009 : ResourceSystemBlock
	{
		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001A6 RID: 422 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000AA24 File Offset: 0x00008C24
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

		// Token: 0x060001A8 RID: 424 RVA: 0x0000AA94 File Offset: 0x00008C94
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

		// Token: 0x040003C0 RID: 960
		public uint Unknown_0h;

		// Token: 0x040003C1 RID: 961
		public uint Unknown_4h;

		// Token: 0x040003C2 RID: 962
		public uint Unknown_8h;

		// Token: 0x040003C3 RID: 963
		public uint Unknown_Ch;

		// Token: 0x040003C4 RID: 964
		public uint Unknown_10h;

		// Token: 0x040003C5 RID: 965
		public uint Unknown_14h;

		// Token: 0x040003C6 RID: 966
		public uint Unknown_18h;

		// Token: 0x040003C7 RID: 967
		public uint Unknown_1Ch;
	}
}
