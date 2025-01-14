using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001B RID: 27
	public class BehaviourAcceleration : Behaviour
	{
		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000483C File Offset: 0x00002A3C
		public override long Length
		{
			get
			{
				return 368L;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00004844 File Offset: 0x00002A44
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

		// Token: 0x060000C3 RID: 195 RVA: 0x0000491C File Offset: 0x00002B1C
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

		// Token: 0x060000C4 RID: 196 RVA: 0x000049E5 File Offset: 0x00002BE5
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1)
			};
		}

		// Token: 0x040000CB RID: 203
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040000CC RID: 204
		public uint Unknown_20h;

		// Token: 0x040000CD RID: 205
		public uint Unknown_24h;

		// Token: 0x040000CE RID: 206
		public uint Unknown_28h;

		// Token: 0x040000CF RID: 207
		public uint Unknown_2Ch;

		// Token: 0x040000D0 RID: 208
		public KeyframeProp KeyframeProp0;

		// Token: 0x040000D1 RID: 209
		public KeyframeProp KeyframeProp1;

		// Token: 0x040000D2 RID: 210
		public uint Unknown_150h;

		// Token: 0x040000D3 RID: 211
		public uint Unknown_154h;

		// Token: 0x040000D4 RID: 212
		public uint Unknown_158h;

		// Token: 0x040000D5 RID: 213
		public uint Unknown_15Ch;

		// Token: 0x040000D6 RID: 214
		public uint Unknown_160h;

		// Token: 0x040000D7 RID: 215
		public uint Unknown_164h;

		// Token: 0x040000D8 RID: 216
		public uint Unknown_168h;

		// Token: 0x040000D9 RID: 217
		public uint Unknown_16Ch;
	}
}
