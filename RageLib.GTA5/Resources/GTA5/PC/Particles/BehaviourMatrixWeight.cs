using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000027 RID: 39
	public class BehaviourMatrixWeight : Behaviour
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000FA RID: 250 RVA: 0x00004B19 File Offset: 0x00002D19
		public override long Length
		{
			get
			{
				return 208L;
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00005E24 File Offset: 0x00004024
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

		// Token: 0x060000FC RID: 252 RVA: 0x00005EBC File Offset: 0x000040BC
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

		// Token: 0x060000FD RID: 253 RVA: 0x00005F49 File Offset: 0x00004149
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0)
			};
		}

		// Token: 0x04000171 RID: 369
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x04000172 RID: 370
		public uint Unknown_20h;

		// Token: 0x04000173 RID: 371
		public uint Unknown_24h;

		// Token: 0x04000174 RID: 372
		public uint Unknown_28h;

		// Token: 0x04000175 RID: 373
		public uint Unknown_2Ch;

		// Token: 0x04000176 RID: 374
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000177 RID: 375
		public uint Unknown_C0h;

		// Token: 0x04000178 RID: 376
		public uint Unknown_C4h;

		// Token: 0x04000179 RID: 377
		public uint Unknown_C8h;

		// Token: 0x0400017A RID: 378
		public uint Unknown_CCh;
	}
}
