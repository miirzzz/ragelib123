using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000030 RID: 48
	public class BehaviourWind : Behaviour
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x06000123 RID: 291 RVA: 0x00006A69 File Offset: 0x00004C69
		public override long Length
		{
			get
			{
				return 240L;
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00006D74 File Offset: 0x00004F74
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
			this.Unknown_D0h = reader.ReadUInt32();
			this.Unknown_D4h = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadUInt32();
			this.Unknown_E4h = reader.ReadUInt32();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00006E6C File Offset: 0x0000506C
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
			writer.Write(this.Unknown_D0h);
			writer.Write(this.Unknown_D4h);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h);
			writer.Write(this.Unknown_E4h);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00006F59 File Offset: 0x00005159
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0)
			};
		}

		// Token: 0x040001EC RID: 492
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040001ED RID: 493
		public uint Unknown_20h;

		// Token: 0x040001EE RID: 494
		public uint Unknown_24h;

		// Token: 0x040001EF RID: 495
		public uint Unknown_28h;

		// Token: 0x040001F0 RID: 496
		public uint Unknown_2Ch;

		// Token: 0x040001F1 RID: 497
		public KeyframeProp KeyframeProp0;

		// Token: 0x040001F2 RID: 498
		public uint Unknown_C0h;

		// Token: 0x040001F3 RID: 499
		public uint Unknown_C4h;

		// Token: 0x040001F4 RID: 500
		public uint Unknown_C8h;

		// Token: 0x040001F5 RID: 501
		public uint Unknown_CCh;

		// Token: 0x040001F6 RID: 502
		public uint Unknown_D0h;

		// Token: 0x040001F7 RID: 503
		public uint Unknown_D4h;

		// Token: 0x040001F8 RID: 504
		public uint Unknown_D8h;

		// Token: 0x040001F9 RID: 505
		public uint Unknown_DCh;

		// Token: 0x040001FA RID: 506
		public uint Unknown_E0h;

		// Token: 0x040001FB RID: 507
		public uint Unknown_E4h;

		// Token: 0x040001FC RID: 508
		public uint Unknown_E8h;

		// Token: 0x040001FD RID: 509
		public uint Unknown_ECh;
	}
}
