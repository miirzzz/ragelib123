using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000020 RID: 32
	public class BehaviourColour : Behaviour
	{
		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x00004F4B File Offset: 0x0000314B
		public override long Length
		{
			get
			{
				return 496L;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00004F54 File Offset: 0x00003154
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
			this.KeyframeProp2 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_1E0h = reader.ReadUInt32();
			this.Unknown_1E4h = reader.ReadUInt32();
			this.Unknown_1E8h = reader.ReadUInt32();
			this.Unknown_1ECh = reader.ReadUInt32();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00005010 File Offset: 0x00003210
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
			writer.WriteBlock(this.KeyframeProp2);
			writer.Write(this.Unknown_1E0h);
			writer.Write(this.Unknown_1E4h);
			writer.Write(this.Unknown_1E8h);
			writer.Write(this.Unknown_1ECh);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x000050B8 File Offset: 0x000032B8
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(336L, this.KeyframeProp2)
			};
		}

		// Token: 0x04000101 RID: 257
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x04000102 RID: 258
		public uint Unknown_20h;

		// Token: 0x04000103 RID: 259
		public uint Unknown_24h;

		// Token: 0x04000104 RID: 260
		public uint Unknown_28h;

		// Token: 0x04000105 RID: 261
		public uint Unknown_2Ch;

		// Token: 0x04000106 RID: 262
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000107 RID: 263
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000108 RID: 264
		public KeyframeProp KeyframeProp2;

		// Token: 0x04000109 RID: 265
		public uint Unknown_1E0h;

		// Token: 0x0400010A RID: 266
		public uint Unknown_1E4h;

		// Token: 0x0400010B RID: 267
		public uint Unknown_1E8h;

		// Token: 0x0400010C RID: 268
		public uint Unknown_1ECh;
	}
}
