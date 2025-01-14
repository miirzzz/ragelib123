using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000038 RID: 56
	public class EffectRuleDictionary : ResourceSystemBlock
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00007C48 File Offset: 0x00005E48
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
			this.EffectRuleNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.EffectRules = reader.ReadBlock<ResourcePointerList64<EffectRule>>(Array.Empty<object>());
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00007CD8 File Offset: 0x00005ED8
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
			writer.WriteBlock(this.EffectRuleNameHashes);
			writer.WriteBlock(this.EffectRules);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00007D5D File Offset: 0x00005F5D
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.EffectRuleNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.EffectRules)
			};
		}

		// Token: 0x04000263 RID: 611
		public uint VFT;

		// Token: 0x04000264 RID: 612
		public uint Unknown_4h;

		// Token: 0x04000265 RID: 613
		public uint Unknown_8h;

		// Token: 0x04000266 RID: 614
		public uint Unknown_Ch;

		// Token: 0x04000267 RID: 615
		public uint Unknown_10h;

		// Token: 0x04000268 RID: 616
		public uint Unknown_14h;

		// Token: 0x04000269 RID: 617
		public uint Unknown_18h;

		// Token: 0x0400026A RID: 618
		public uint Unknown_1Ch;

		// Token: 0x0400026B RID: 619
		public ResourceSimpleList64<uint_r> EffectRuleNameHashes;

		// Token: 0x0400026C RID: 620
		public ResourcePointerList64<EffectRule> EffectRules;
	}
}
