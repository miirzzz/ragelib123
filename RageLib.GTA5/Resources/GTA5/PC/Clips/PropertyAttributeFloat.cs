using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015A RID: 346
	public class PropertyAttributeFloat : PropertyAttribute
	{
		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000552 RID: 1362 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000553 RID: 1363 RVA: 0x00024FC9 File Offset: 0x000231C9
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Value = reader.ReadSingle();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000554 RID: 1364 RVA: 0x00025003 File Offset: 0x00023203
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Value);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040035CD RID: 13773
		public float Value;

		// Token: 0x040035CE RID: 13774
		public uint Unknown_24h;

		// Token: 0x040035CF RID: 13775
		public uint Unknown_28h;

		// Token: 0x040035D0 RID: 13776
		public uint Unknown_2Ch;
	}
}
