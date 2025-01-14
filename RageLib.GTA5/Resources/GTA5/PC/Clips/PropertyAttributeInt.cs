using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015C RID: 348
	public class PropertyAttributeInt : PropertyAttribute
	{
		// Token: 0x17000159 RID: 345
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x000250B1 File Offset: 0x000232B1
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Value = reader.ReadInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x000250EB File Offset: 0x000232EB
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Value);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040035D5 RID: 13781
		public int Value;

		// Token: 0x040035D6 RID: 13782
		public uint Unknown_24h;

		// Token: 0x040035D7 RID: 13783
		public uint Unknown_28h;

		// Token: 0x040035D8 RID: 13784
		public uint Unknown_2Ch;
	}
}
