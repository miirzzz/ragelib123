using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000031 RID: 49
	public class BehaviourZCull : Behaviour
	{
		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000483C File Offset: 0x00002A3C
		public override long Length
		{
			get
			{
				return 368L;
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00006F84 File Offset: 0x00005184
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

		// Token: 0x0600012A RID: 298 RVA: 0x0000705C File Offset: 0x0000525C
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

		// Token: 0x0600012B RID: 299 RVA: 0x00007125 File Offset: 0x00005325
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1)
			};
		}

		// Token: 0x040001FE RID: 510
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040001FF RID: 511
		public uint Unknown_20h;

		// Token: 0x04000200 RID: 512
		public uint Unknown_24h;

		// Token: 0x04000201 RID: 513
		public uint Unknown_28h;

		// Token: 0x04000202 RID: 514
		public uint Unknown_2Ch;

		// Token: 0x04000203 RID: 515
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000204 RID: 516
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000205 RID: 517
		public uint Unknown_150h;

		// Token: 0x04000206 RID: 518
		public uint Unknown_154h;

		// Token: 0x04000207 RID: 519
		public uint Unknown_158h;

		// Token: 0x04000208 RID: 520
		public uint Unknown_15Ch;

		// Token: 0x04000209 RID: 521
		public uint Unknown_160h;

		// Token: 0x0400020A RID: 522
		public uint Unknown_164h;

		// Token: 0x0400020B RID: 523
		public uint Unknown_168h;

		// Token: 0x0400020C RID: 524
		public uint Unknown_16Ch;
	}
}
