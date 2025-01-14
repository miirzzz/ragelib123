using System;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001C RID: 28
	public class BehaviourAge : Behaviour
	{
		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00004A2C File Offset: 0x00002C2C
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
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00004AA4 File Offset: 0x00002CA4
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
		}

		// Token: 0x040000DA RID: 218
		public uint Unknown_10h;

		// Token: 0x040000DB RID: 219
		public uint Unknown_14h;

		// Token: 0x040000DC RID: 220
		public uint Unknown_18h;

		// Token: 0x040000DD RID: 221
		public uint Unknown_1Ch;

		// Token: 0x040000DE RID: 222
		public uint Unknown_20h;

		// Token: 0x040000DF RID: 223
		public uint Unknown_24h;

		// Token: 0x040000E0 RID: 224
		public uint Unknown_28h;

		// Token: 0x040000E1 RID: 225
		public uint Unknown_2Ch;
	}
}
