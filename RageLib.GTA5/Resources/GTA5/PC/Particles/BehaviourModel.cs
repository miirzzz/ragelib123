using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000028 RID: 40
	public class BehaviourModel : Behaviour
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00005F74 File Offset: 0x00004174
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

		// Token: 0x06000101 RID: 257 RVA: 0x0000601C File Offset: 0x0000421C
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

		// Token: 0x0400017B RID: 379
		public uint Unknown_10h;

		// Token: 0x0400017C RID: 380
		public uint Unknown_14h;

		// Token: 0x0400017D RID: 381
		public uint Unknown_18h;

		// Token: 0x0400017E RID: 382
		public uint Unknown_1Ch;

		// Token: 0x0400017F RID: 383
		public uint Unknown_20h;

		// Token: 0x04000180 RID: 384
		public uint Unknown_24h;

		// Token: 0x04000181 RID: 385
		public uint Unknown_28h;

		// Token: 0x04000182 RID: 386
		public uint Unknown_2Ch;

		// Token: 0x04000183 RID: 387
		public uint Unknown_30h;

		// Token: 0x04000184 RID: 388
		public uint Unknown_34h;

		// Token: 0x04000185 RID: 389
		public uint Unknown_38h;

		// Token: 0x04000186 RID: 390
		public uint Unknown_3Ch;
	}
}
