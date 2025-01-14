using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000025 RID: 37
	public class BehaviourLight : Behaviour
	{
		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x00005981 File Offset: 0x00003B81
		public override long Length
		{
			get
			{
				return 1360L;
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000598C File Offset: 0x00003B8C
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
			this.KeyframeProp7 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp8 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_540h = reader.ReadUInt32();
			this.Unknown_544h = reader.ReadUInt32();
			this.Unknown_548h = reader.ReadUInt32();
			this.Unknown_54Ch = reader.ReadUInt32();
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00005AAC File Offset: 0x00003CAC
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
			writer.WriteBlock(this.KeyframeProp7);
			writer.WriteBlock(this.KeyframeProp8);
			writer.Write(this.Unknown_540h);
			writer.Write(this.Unknown_544h);
			writer.Write(this.Unknown_548h);
			writer.Write(this.Unknown_54Ch);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00005B9C File Offset: 0x00003D9C
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
				new Tuple<long, IResourceBlock>(912L, this.KeyframeProp6),
				new Tuple<long, IResourceBlock>(1056L, this.KeyframeProp7),
				new Tuple<long, IResourceBlock>(1200L, this.KeyframeProp8)
			};
		}

		// Token: 0x0400014F RID: 335
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x04000150 RID: 336
		public uint Unknown_20h;

		// Token: 0x04000151 RID: 337
		public uint Unknown_24h;

		// Token: 0x04000152 RID: 338
		public uint Unknown_28h;

		// Token: 0x04000153 RID: 339
		public uint Unknown_2Ch;

		// Token: 0x04000154 RID: 340
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000155 RID: 341
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000156 RID: 342
		public KeyframeProp KeyframeProp2;

		// Token: 0x04000157 RID: 343
		public KeyframeProp KeyframeProp3;

		// Token: 0x04000158 RID: 344
		public KeyframeProp KeyframeProp4;

		// Token: 0x04000159 RID: 345
		public KeyframeProp KeyframeProp5;

		// Token: 0x0400015A RID: 346
		public KeyframeProp KeyframeProp6;

		// Token: 0x0400015B RID: 347
		public KeyframeProp KeyframeProp7;

		// Token: 0x0400015C RID: 348
		public KeyframeProp KeyframeProp8;

		// Token: 0x0400015D RID: 349
		public uint Unknown_540h;

		// Token: 0x0400015E RID: 350
		public uint Unknown_544h;

		// Token: 0x0400015F RID: 351
		public uint Unknown_548h;

		// Token: 0x04000160 RID: 352
		public uint Unknown_54Ch;
	}
}
