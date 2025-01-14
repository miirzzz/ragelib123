using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000159 RID: 345
	public class PropertyAttributeBool : PropertyAttribute
	{
		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600054F RID: 1359 RVA: 0x00024F4D File Offset: 0x0002314D
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Value = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000550 RID: 1360 RVA: 0x00024F87 File Offset: 0x00023187
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Value);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x040035C9 RID: 13769
		public uint Value;

		// Token: 0x040035CA RID: 13770
		public uint Unknown_24h;

		// Token: 0x040035CB RID: 13771
		public uint Unknown_28h;

		// Token: 0x040035CC RID: 13772
		public uint Unknown_2Ch;
	}
}
