using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002B RID: 43
	public class BehaviourRotation : Behaviour
	{
		// Token: 0x17000047 RID: 71
		// (get) Token: 0x0600010C RID: 268 RVA: 0x000060C1 File Offset: 0x000042C1
		public override long Length
		{
			get
			{
				return 640L;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00006410 File Offset: 0x00004610
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
			this.KeyframeProp3 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_270h = reader.ReadUInt32();
			this.Unknown_274h = reader.ReadUInt32();
			this.Unknown_278h = reader.ReadUInt32();
			this.Unknown_27Ch = reader.ReadUInt32();
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000064DC File Offset: 0x000046DC
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
			writer.WriteBlock(this.KeyframeProp3);
			writer.Write(this.Unknown_270h);
			writer.Write(this.Unknown_274h);
			writer.Write(this.Unknown_278h);
			writer.Write(this.Unknown_27Ch);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00006590 File Offset: 0x00004790
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(336L, this.KeyframeProp2),
				new Tuple<long, IResourceBlock>(480L, this.KeyframeProp3)
			};
		}

		// Token: 0x040001A0 RID: 416
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040001A1 RID: 417
		public uint Unknown_20h;

		// Token: 0x040001A2 RID: 418
		public uint Unknown_24h;

		// Token: 0x040001A3 RID: 419
		public uint Unknown_28h;

		// Token: 0x040001A4 RID: 420
		public uint Unknown_2Ch;

		// Token: 0x040001A5 RID: 421
		public KeyframeProp KeyframeProp0;

		// Token: 0x040001A6 RID: 422
		public KeyframeProp KeyframeProp1;

		// Token: 0x040001A7 RID: 423
		public KeyframeProp KeyframeProp2;

		// Token: 0x040001A8 RID: 424
		public KeyframeProp KeyframeProp3;

		// Token: 0x040001A9 RID: 425
		public uint Unknown_270h;

		// Token: 0x040001AA RID: 426
		public uint Unknown_274h;

		// Token: 0x040001AB RID: 427
		public uint Unknown_278h;

		// Token: 0x040001AC RID: 428
		public uint Unknown_27Ch;
	}
}
