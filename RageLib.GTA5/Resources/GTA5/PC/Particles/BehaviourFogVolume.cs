using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000024 RID: 36
	public class BehaviourFogVolume : Behaviour
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EC RID: 236 RVA: 0x000056F1 File Offset: 0x000038F1
		public override long Length
		{
			get
			{
				return 1072L;
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000056FC File Offset: 0x000038FC
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
			this.KeyframeProp4 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp5 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp6 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_420h = reader.ReadUInt32();
			this.Unknown_424h = reader.ReadUInt32();
			this.Unknown_428h = reader.ReadUInt32();
			this.Unknown_42Ch = reader.ReadUInt32();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000057FC File Offset: 0x000039FC
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
			writer.WriteBlock(this.KeyframeProp4);
			writer.WriteBlock(this.KeyframeProp5);
			writer.WriteBlock(this.KeyframeProp6);
			writer.Write(this.Unknown_420h);
			writer.Write(this.Unknown_424h);
			writer.Write(this.Unknown_428h);
			writer.Write(this.Unknown_42Ch);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000058D4 File Offset: 0x00003AD4
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(192L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(336L, this.KeyframeProp2),
				new Tuple<long, IResourceBlock>(480L, this.KeyframeProp3),
				new Tuple<long, IResourceBlock>(624L, this.KeyframeProp4),
				new Tuple<long, IResourceBlock>(768L, this.KeyframeProp5),
				new Tuple<long, IResourceBlock>(912L, this.KeyframeProp6)
			};
		}

		// Token: 0x0400013F RID: 319
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x04000140 RID: 320
		public uint Unknown_20h;

		// Token: 0x04000141 RID: 321
		public uint Unknown_24h;

		// Token: 0x04000142 RID: 322
		public uint Unknown_28h;

		// Token: 0x04000143 RID: 323
		public uint Unknown_2Ch;

		// Token: 0x04000144 RID: 324
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000145 RID: 325
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000146 RID: 326
		public KeyframeProp KeyframeProp2;

		// Token: 0x04000147 RID: 327
		public KeyframeProp KeyframeProp3;

		// Token: 0x04000148 RID: 328
		public KeyframeProp KeyframeProp4;

		// Token: 0x04000149 RID: 329
		public KeyframeProp KeyframeProp5;

		// Token: 0x0400014A RID: 330
		public KeyframeProp KeyframeProp6;

		// Token: 0x0400014B RID: 331
		public uint Unknown_420h;

		// Token: 0x0400014C RID: 332
		public uint Unknown_424h;

		// Token: 0x0400014D RID: 333
		public uint Unknown_428h;

		// Token: 0x0400014E RID: 334
		public uint Unknown_42Ch;
	}
}
