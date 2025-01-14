using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200002C RID: 44
	public class BehaviourSize : Behaviour
	{
		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000111 RID: 273 RVA: 0x000060C1 File Offset: 0x000042C1
		public override long Length
		{
			get
			{
				return 640L;
			}
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00006604 File Offset: 0x00004804
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

		// Token: 0x06000113 RID: 275 RVA: 0x000066D0 File Offset: 0x000048D0
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

		// Token: 0x06000114 RID: 276 RVA: 0x00006784 File Offset: 0x00004984
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

		// Token: 0x040001AD RID: 429
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040001AE RID: 430
		public uint Unknown_20h;

		// Token: 0x040001AF RID: 431
		public uint Unknown_24h;

		// Token: 0x040001B0 RID: 432
		public uint Unknown_28h;

		// Token: 0x040001B1 RID: 433
		public uint Unknown_2Ch;

		// Token: 0x040001B2 RID: 434
		public KeyframeProp KeyframeProp0;

		// Token: 0x040001B3 RID: 435
		public KeyframeProp KeyframeProp1;

		// Token: 0x040001B4 RID: 436
		public KeyframeProp KeyframeProp2;

		// Token: 0x040001B5 RID: 437
		public KeyframeProp KeyframeProp3;

		// Token: 0x040001B6 RID: 438
		public uint Unknown_270h;

		// Token: 0x040001B7 RID: 439
		public uint Unknown_274h;

		// Token: 0x040001B8 RID: 440
		public uint Unknown_278h;

		// Token: 0x040001B9 RID: 441
		public uint Unknown_27Ch;
	}
}
