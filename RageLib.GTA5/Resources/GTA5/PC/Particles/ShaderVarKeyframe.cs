using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000042 RID: 66
	public class ShaderVarKeyframe : ShaderVar
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000171 RID: 369 RVA: 0x0000553F File Offset: 0x0000373F
		public override long Length
		{
			get
			{
				return 80L;
			}
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00009EEC File Offset: 0x000080EC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_001>>(Array.Empty<object>());
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x00009F8C File Offset: 0x0000818C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.WriteBlock(this.Unknown_28h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000A025 File Offset: 0x00008225
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(40L, this.Unknown_28h)
			};
		}

		// Token: 0x0400036F RID: 879
		public uint Unknown_18h;

		// Token: 0x04000370 RID: 880
		public uint Unknown_1Ch;

		// Token: 0x04000371 RID: 881
		public uint Unknown_20h;

		// Token: 0x04000372 RID: 882
		public uint Unknown_24h;

		// Token: 0x04000373 RID: 883
		public ResourceSimpleList64<Unknown_P_001> Unknown_28h;

		// Token: 0x04000374 RID: 884
		public uint Unknown_38h;

		// Token: 0x04000375 RID: 885
		public uint Unknown_3Ch;

		// Token: 0x04000376 RID: 886
		public uint Unknown_40h;

		// Token: 0x04000377 RID: 887
		public uint Unknown_44h;

		// Token: 0x04000378 RID: 888
		public uint Unknown_48h;

		// Token: 0x04000379 RID: 889
		public uint Unknown_4Ch;
	}
}
