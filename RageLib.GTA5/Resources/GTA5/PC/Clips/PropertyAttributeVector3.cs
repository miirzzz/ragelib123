using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015F RID: 351
	public class PropertyAttributeVector3 : PropertyAttribute
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000567 RID: 1383 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x000252D3 File Offset: 0x000234D3
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
			this.Z = reader.ReadSingle();
			this.Unknown_2Ch = reader.ReadSingle();
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x0002530D File Offset: 0x0002350D
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.X);
			writer.Write(this.Y);
			writer.Write(this.Z);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040035E2 RID: 13794
		public float X;

		// Token: 0x040035E3 RID: 13795
		public float Y;

		// Token: 0x040035E4 RID: 13796
		public float Z;

		// Token: 0x040035E5 RID: 13797
		public float Unknown_2Ch;
	}
}
