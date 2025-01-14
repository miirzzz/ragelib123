using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000022 RID: 34
	public class BehaviourDecal : Behaviour
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x000052F7 File Offset: 0x000034F7
		public override long Length
		{
			get
			{
				return 384L;
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00005300 File Offset: 0x00003500
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
			this.Unknown_170h = reader.ReadUInt32();
			this.Unknown_174h = reader.ReadUInt32();
			this.Unknown_178h = reader.ReadUInt32();
			this.Unknown_17Ch = reader.ReadUInt32();
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00005408 File Offset: 0x00003608
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
			writer.Write(this.Unknown_170h);
			writer.Write(this.Unknown_174h);
			writer.Write(this.Unknown_178h);
			writer.Write(this.Unknown_17Ch);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00005501 File Offset: 0x00003701
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1)
			};
		}

		// Token: 0x0400011C RID: 284
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x0400011D RID: 285
		public uint Unknown_20h;

		// Token: 0x0400011E RID: 286
		public uint Unknown_24h;

		// Token: 0x0400011F RID: 287
		public uint Unknown_28h;

		// Token: 0x04000120 RID: 288
		public uint Unknown_2Ch;

		// Token: 0x04000121 RID: 289
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000122 RID: 290
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000123 RID: 291
		public uint Unknown_150h;

		// Token: 0x04000124 RID: 292
		public uint Unknown_154h;

		// Token: 0x04000125 RID: 293
		public uint Unknown_158h;

		// Token: 0x04000126 RID: 294
		public uint Unknown_15Ch;

		// Token: 0x04000127 RID: 295
		public uint Unknown_160h;

		// Token: 0x04000128 RID: 296
		public uint Unknown_164h;

		// Token: 0x04000129 RID: 297
		public uint Unknown_168h;

		// Token: 0x0400012A RID: 298
		public uint Unknown_16Ch;

		// Token: 0x0400012B RID: 299
		public uint Unknown_170h;

		// Token: 0x0400012C RID: 300
		public uint Unknown_174h;

		// Token: 0x0400012D RID: 301
		public uint Unknown_178h;

		// Token: 0x0400012E RID: 302
		public uint Unknown_17Ch;
	}
}
