using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002A RID: 42
	public class BehaviourRiver : Behaviour
	{
		// Token: 0x17000046 RID: 70
		// (get) Token: 0x06000108 RID: 264 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000062C0 File Offset: 0x000044C0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
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

		// Token: 0x0600010A RID: 266 RVA: 0x00006368 File Offset: 0x00004568
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
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

		// Token: 0x04000194 RID: 404
		public uint Unknown_10h;

		// Token: 0x04000195 RID: 405
		public uint Unknown_14h;

		// Token: 0x04000196 RID: 406
		public uint Unknown_18h;

		// Token: 0x04000197 RID: 407
		public uint Unknown_1Ch;

		// Token: 0x04000198 RID: 408
		public uint Unknown_20h;

		// Token: 0x04000199 RID: 409
		public uint Unknown_24h;

		// Token: 0x0400019A RID: 410
		public uint Unknown_28h;

		// Token: 0x0400019B RID: 411
		public uint Unknown_2Ch;

		// Token: 0x0400019C RID: 412
		public uint Unknown_30h;

		// Token: 0x0400019D RID: 413
		public uint Unknown_34h;

		// Token: 0x0400019E RID: 414
		public uint Unknown_38h;

		// Token: 0x0400019F RID: 415
		public uint Unknown_3Ch;
	}
}
