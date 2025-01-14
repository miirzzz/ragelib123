using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001D RID: 29
	public class BehaviourAnimateTexture : Behaviour
	{
		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000CA RID: 202 RVA: 0x00004B19 File Offset: 0x00002D19
		public override long Length
		{
			get
			{
				return 208L;
			}
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00004B24 File Offset: 0x00002D24
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.KeyframeProps = reader.ReadBlock<ResourcePointerList64<KeyframeProp>>(Array.Empty<object>());
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.Unknown_C8h = reader.ReadUInt32();
			this.Unknown_CCh = reader.ReadUInt32();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00004BBC File Offset: 0x00002DBC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.WriteBlock(this.KeyframeProps);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.WriteBlock(this.KeyframeProp0);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.Unknown_C8h);
			writer.Write(this.Unknown_CCh);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00004C49 File Offset: 0x00002E49
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0)
			};
		}

		// Token: 0x040000E2 RID: 226
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040000E3 RID: 227
		public uint Unknown_20h;

		// Token: 0x040000E4 RID: 228
		public uint Unknown_24h;

		// Token: 0x040000E5 RID: 229
		public uint Unknown_28h;

		// Token: 0x040000E6 RID: 230
		public uint Unknown_2Ch;

		// Token: 0x040000E7 RID: 231
		public KeyframeProp KeyframeProp0;

		// Token: 0x040000E8 RID: 232
		public uint Unknown_C0h;

		// Token: 0x040000E9 RID: 233
		public uint Unknown_C4h;

		// Token: 0x040000EA RID: 234
		public uint Unknown_C8h;

		// Token: 0x040000EB RID: 235
		public uint Unknown_CCh;
	}
}
