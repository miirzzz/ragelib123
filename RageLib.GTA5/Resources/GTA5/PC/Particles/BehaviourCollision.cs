using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001F RID: 31
	public class BehaviourCollision : Behaviour
	{
		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000483C File Offset: 0x00002A3C
		public override long Length
		{
			get
			{
				return 368L;
			}
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00004D6C File Offset: 0x00002F6C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.KeyframeProps = reader.ReadBlock<ResourcePointerList64<KeyframeProp>>(Array.Empty<object>());
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp1 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_150h = reader.ReadUInt32();
			this.Unknown_154h = reader.ReadUInt32();
			this.Unknown_158h = reader.ReadUInt32();
			this.Unknown_15Ch = reader.ReadUInt32();
			this.Unknown_160h = reader.ReadUInt32();
			this.Unknown_164h = reader.ReadUInt32();
			this.Unknown_168h = reader.ReadUInt32();
			this.Unknown_16Ch = reader.ReadUInt32();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00004E44 File Offset: 0x00003044
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.WriteBlock(this.KeyframeProps);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.WriteBlock(this.KeyframeProp0);
			writer.WriteBlock(this.KeyframeProp1);
			writer.Write(this.Unknown_150h);
			writer.Write(this.Unknown_154h);
			writer.Write(this.Unknown_158h);
			writer.Write(this.Unknown_15Ch);
			writer.Write(this.Unknown_160h);
			writer.Write(this.Unknown_164h);
			writer.Write(this.Unknown_168h);
			writer.Write(this.Unknown_16Ch);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00004F0D File Offset: 0x0000310D
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1)
			};
		}

		// Token: 0x040000F2 RID: 242
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040000F3 RID: 243
		public uint Unknown_20h;

		// Token: 0x040000F4 RID: 244
		public uint Unknown_24h;

		// Token: 0x040000F5 RID: 245
		public uint Unknown_28h;

		// Token: 0x040000F6 RID: 246
		public uint Unknown_2Ch;

		// Token: 0x040000F7 RID: 247
		public KeyframeProp KeyframeProp0;

		// Token: 0x040000F8 RID: 248
		public KeyframeProp KeyframeProp1;

		// Token: 0x040000F9 RID: 249
		public uint Unknown_150h;

		// Token: 0x040000FA RID: 250
		public uint Unknown_154h;

		// Token: 0x040000FB RID: 251
		public uint Unknown_158h;

		// Token: 0x040000FC RID: 252
		public uint Unknown_15Ch;

		// Token: 0x040000FD RID: 253
		public uint Unknown_160h;

		// Token: 0x040000FE RID: 254
		public uint Unknown_164h;

		// Token: 0x040000FF RID: 255
		public uint Unknown_168h;

		// Token: 0x04000100 RID: 256
		public uint Unknown_16Ch;
	}
}
