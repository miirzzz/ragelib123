using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000044 RID: 68
	public class ShaderVarVector : ShaderVar
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600017B RID: 379 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
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

		// Token: 0x0600017D RID: 381 RVA: 0x0000A274 File Offset: 0x00008474
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
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

		// Token: 0x04000384 RID: 900
		public uint Unknown_18h;

		// Token: 0x04000385 RID: 901
		public uint Unknown_1Ch;

		// Token: 0x04000386 RID: 902
		public uint Unknown_20h;

		// Token: 0x04000387 RID: 903
		public uint Unknown_24h;

		// Token: 0x04000388 RID: 904
		public uint Unknown_28h;

		// Token: 0x04000389 RID: 905
		public uint Unknown_2Ch;

		// Token: 0x0400038A RID: 906
		public uint Unknown_30h;

		// Token: 0x0400038B RID: 907
		public uint Unknown_34h;

		// Token: 0x0400038C RID: 908
		public uint Unknown_38h;

		// Token: 0x0400038D RID: 909
		public uint Unknown_3Ch;
	}
}
