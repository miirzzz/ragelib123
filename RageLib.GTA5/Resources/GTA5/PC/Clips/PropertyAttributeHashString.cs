using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015B RID: 347
	public class PropertyAttributeHashString : PropertyAttribute
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000556 RID: 1366 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000557 RID: 1367 RVA: 0x0002503D File Offset: 0x0002323D
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Value = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000558 RID: 1368 RVA: 0x00025077 File Offset: 0x00023277
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Value);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040035D1 RID: 13777
		public uint Value;

		// Token: 0x040035D2 RID: 13778
		public uint Unknown_24h;

		// Token: 0x040035D3 RID: 13779
		public uint Unknown_28h;

		// Token: 0x040035D4 RID: 13780
		public uint Unknown_2Ch;
	}
}
