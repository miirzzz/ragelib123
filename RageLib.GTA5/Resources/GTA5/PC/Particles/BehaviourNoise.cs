using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000029 RID: 41
	public class BehaviourNoise : Behaviour
	{
		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000103 RID: 259 RVA: 0x000060C1 File Offset: 0x000042C1
		public override long Length
		{
			get
			{
				return 640L;
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000060CC File Offset: 0x000042CC
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

		// Token: 0x06000105 RID: 261 RVA: 0x00006198 File Offset: 0x00004398
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

		// Token: 0x06000106 RID: 262 RVA: 0x0000624C File Offset: 0x0000444C
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

		// Token: 0x04000187 RID: 391
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x04000188 RID: 392
		public uint Unknown_20h;

		// Token: 0x04000189 RID: 393
		public uint Unknown_24h;

		// Token: 0x0400018A RID: 394
		public uint Unknown_28h;

		// Token: 0x0400018B RID: 395
		public uint Unknown_2Ch;

		// Token: 0x0400018C RID: 396
		public KeyframeProp KeyframeProp0;

		// Token: 0x0400018D RID: 397
		public KeyframeProp KeyframeProp1;

		// Token: 0x0400018E RID: 398
		public KeyframeProp KeyframeProp2;

		// Token: 0x0400018F RID: 399
		public KeyframeProp KeyframeProp3;

		// Token: 0x04000190 RID: 400
		public uint Unknown_270h;

		// Token: 0x04000191 RID: 401
		public uint Unknown_274h;

		// Token: 0x04000192 RID: 402
		public uint Unknown_278h;

		// Token: 0x04000193 RID: 403
		public uint Unknown_27Ch;
	}
}
