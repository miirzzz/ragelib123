using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200001E RID: 30
	public class BehaviourAttractor : Behaviour
	{
		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000CF RID: 207 RVA: 0x00004C73 File Offset: 0x00002E73
		public override long Length
		{
			get
			{
				return 192L;
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00004C7C File Offset: 0x00002E7C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.KeyframeProps = reader.ReadBlock<ResourcePointerList64<KeyframeProp>>(Array.Empty<object>());
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00004CE4 File Offset: 0x00002EE4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.WriteBlock(this.KeyframeProps);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.WriteBlock(this.KeyframeProp0);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00004D41 File Offset: 0x00002F41
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.KeyframeProps),
				new Tuple<long, IResourceBlock>(48L, this.KeyframeProp0)
			};
		}

		// Token: 0x040000EC RID: 236
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x040000ED RID: 237
		public uint Unknown_20h;

		// Token: 0x040000EE RID: 238
		public uint Unknown_24h;

		// Token: 0x040000EF RID: 239
		public uint Unknown_28h;

		// Token: 0x040000F0 RID: 240
		public uint Unknown_2Ch;

		// Token: 0x040000F1 RID: 241
		public KeyframeProp KeyframeProp0;
	}
}
