using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004F RID: 79
	public class Unknown_P_011 : ResourceSystemBlock
	{
		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0000ABC0 File Offset: 0x00008DC0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadSingle();
			this.Unknown_4h = reader.ReadSingle();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadSingle();
			this.Unknown_14h = reader.ReadSingle();
			this.Unknown_18h = reader.ReadSingle();
			this.Unknown_1Ch = reader.ReadSingle();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000AC30 File Offset: 0x00008E30
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

		// Token: 0x040003CC RID: 972
		public float Unknown_0h;

		// Token: 0x040003CD RID: 973
		public float Unknown_4h;

		// Token: 0x040003CE RID: 974
		public uint Unknown_8h;

		// Token: 0x040003CF RID: 975
		public uint Unknown_Ch;

		// Token: 0x040003D0 RID: 976
		public float Unknown_10h;

		// Token: 0x040003D1 RID: 977
		public float Unknown_14h;

		// Token: 0x040003D2 RID: 978
		public float Unknown_18h;

		// Token: 0x040003D3 RID: 979
		public float Unknown_1Ch;
	}
}
