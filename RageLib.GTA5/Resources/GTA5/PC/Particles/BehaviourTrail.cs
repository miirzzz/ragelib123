using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002E RID: 46
	public class BehaviourTrail : Behaviour
	{
		// Token: 0x1700004A RID: 74
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00006A69 File Offset: 0x00004C69
		public override long Length
		{
			get
			{
				return 240L;
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00006A74 File Offset: 0x00004C74
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

		// Token: 0x0600011C RID: 284 RVA: 0x00006B6C File Offset: 0x00004D6C
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

		// Token: 0x0600011D RID: 285 RVA: 0x00006C59 File Offset: 0x00004E59
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0)
			};
		}

		// Token: 0x040001D2 RID: 466
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040001D3 RID: 467
		public uint Unknown_20h;

		// Token: 0x040001D4 RID: 468
		public uint Unknown_24h;

		// Token: 0x040001D5 RID: 469
		public uint Unknown_28h;

		// Token: 0x040001D6 RID: 470
		public uint Unknown_2Ch;

		// Token: 0x040001D7 RID: 471
		public KeyframeProp KeyframeProp0;

		// Token: 0x040001D8 RID: 472
		public uint Unknown_C0h;

		// Token: 0x040001D9 RID: 473
		public uint Unknown_C4h;

		// Token: 0x040001DA RID: 474
		public uint Unknown_C8h;

		// Token: 0x040001DB RID: 475
		public uint Unknown_CCh;

		// Token: 0x040001DC RID: 476
		public uint Unknown_D0h;

		// Token: 0x040001DD RID: 477
		public uint Unknown_D4h;

		// Token: 0x040001DE RID: 478
		public uint Unknown_D8h;

		// Token: 0x040001DF RID: 479
		public uint Unknown_DCh;

		// Token: 0x040001E0 RID: 480
		public uint Unknown_E0h;

		// Token: 0x040001E1 RID: 481
		public uint Unknown_E4h;

		// Token: 0x040001E2 RID: 482
		public uint Unknown_E8h;

		// Token: 0x040001E3 RID: 483
		public uint Unknown_ECh;
	}
}
