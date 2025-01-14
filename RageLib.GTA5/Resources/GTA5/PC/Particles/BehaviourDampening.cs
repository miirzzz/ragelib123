using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000021 RID: 33
	public class BehaviourDampening : Behaviour
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000483C File Offset: 0x00002A3C
		public override long Length
		{
			get
			{
				return 368L;
			}
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00005118 File Offset: 0x00003318
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

		// Token: 0x060000E0 RID: 224 RVA: 0x000051F0 File Offset: 0x000033F0
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

		// Token: 0x060000E1 RID: 225 RVA: 0x000052B9 File Offset: 0x000034B9
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1)
			};
		}

		// Token: 0x0400010D RID: 269
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x0400010E RID: 270
		public uint Unknown_20h;

		// Token: 0x0400010F RID: 271
		public uint Unknown_24h;

		// Token: 0x04000110 RID: 272
		public uint Unknown_28h;

		// Token: 0x04000111 RID: 273
		public uint Unknown_2Ch;

		// Token: 0x04000112 RID: 274
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000113 RID: 275
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000114 RID: 276
		public uint Unknown_150h;

		// Token: 0x04000115 RID: 277
		public uint Unknown_154h;

		// Token: 0x04000116 RID: 278
		public uint Unknown_158h;

		// Token: 0x04000117 RID: 279
		public uint Unknown_15Ch;

		// Token: 0x04000118 RID: 280
		public uint Unknown_160h;

		// Token: 0x04000119 RID: 281
		public uint Unknown_164h;

		// Token: 0x0400011A RID: 282
		public uint Unknown_168h;

		// Token: 0x0400011B RID: 283
		public uint Unknown_16Ch;
	}
}
