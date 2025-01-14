using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000040 RID: 64
	public class ParticleRuleDictionary : ResourceSystemBlock
	{
		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00009C54 File Offset: 0x00007E54
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.ParticleRuleNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.ParticleRules = reader.ReadBlock<ResourcePointerList64<ParticleRule>>(Array.Empty<object>());
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00009CE4 File Offset: 0x00007EE4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.ParticleRuleNameHashes);
			writer.WriteBlock(this.ParticleRules);
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00009D69 File Offset: 0x00007F69
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.ParticleRuleNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.ParticleRules)
			};
		}

		// Token: 0x0400035D RID: 861
		public uint VFT;

		// Token: 0x0400035E RID: 862
		public uint Unknown_4h;

		// Token: 0x0400035F RID: 863
		public uint Unknown_8h;

		// Token: 0x04000360 RID: 864
		public uint Unknown_Ch;

		// Token: 0x04000361 RID: 865
		public uint Unknown_10h;

		// Token: 0x04000362 RID: 866
		public uint Unknown_14h;

		// Token: 0x04000363 RID: 867
		public uint Unknown_18h;

		// Token: 0x04000364 RID: 868
		public uint Unknown_1Ch;

		// Token: 0x04000365 RID: 869
		public ResourceSimpleList64<uint_r> ParticleRuleNameHashes;

		// Token: 0x04000366 RID: 870
		public ResourcePointerList64<ParticleRule> ParticleRules;
	}
}
