using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000039 RID: 57
	public class EffectSpawner : ResourceSystemBlock
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000142 RID: 322 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00007D88 File Offset: 0x00005F88
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
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.EmitterRulePointer = reader.ReadUInt64();
			this.p1 = reader.ReadUInt64();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.EmitterRule = reader.ReadBlockAt<EffectRule>(this.EmitterRulePointer, Array.Empty<object>());
			this.p1data = reader.ReadBlockAt<string_r>(this.p1, Array.Empty<object>());
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00007EFC File Offset: 0x000060FC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.EmitterRulePointer = (ulong)((this.EmitterRule != null) ? this.EmitterRule.Position : 0L);
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.EmitterRulePointer);
			writer.Write(this.p1);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000807C File Offset: 0x0000627C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.EmitterRule != null)
			{
				list.Add(this.EmitterRule);
			}
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			return list.ToArray();
		}

		// Token: 0x0400026D RID: 621
		public uint VFT;

		// Token: 0x0400026E RID: 622
		public uint Unknown_4h;

		// Token: 0x0400026F RID: 623
		public uint Unknown_8h;

		// Token: 0x04000270 RID: 624
		public uint Unknown_Ch;

		// Token: 0x04000271 RID: 625
		public uint Unknown_10h;

		// Token: 0x04000272 RID: 626
		public uint Unknown_14h;

		// Token: 0x04000273 RID: 627
		public uint Unknown_18h;

		// Token: 0x04000274 RID: 628
		public uint Unknown_1Ch;

		// Token: 0x04000275 RID: 629
		public uint Unknown_20h;

		// Token: 0x04000276 RID: 630
		public uint Unknown_24h;

		// Token: 0x04000277 RID: 631
		public uint Unknown_28h;

		// Token: 0x04000278 RID: 632
		public uint Unknown_2Ch;

		// Token: 0x04000279 RID: 633
		public uint Unknown_30h;

		// Token: 0x0400027A RID: 634
		public uint Unknown_34h;

		// Token: 0x0400027B RID: 635
		public uint Unknown_38h;

		// Token: 0x0400027C RID: 636
		public uint Unknown_3Ch;

		// Token: 0x0400027D RID: 637
		public uint Unknown_40h;

		// Token: 0x0400027E RID: 638
		public uint Unknown_44h;

		// Token: 0x0400027F RID: 639
		public uint Unknown_48h;

		// Token: 0x04000280 RID: 640
		public uint Unknown_4Ch;

		// Token: 0x04000281 RID: 641
		public uint Unknown_50h;

		// Token: 0x04000282 RID: 642
		public uint Unknown_54h;

		// Token: 0x04000283 RID: 643
		public ulong EmitterRulePointer;

		// Token: 0x04000284 RID: 644
		public ulong p1;

		// Token: 0x04000285 RID: 645
		public uint Unknown_68h;

		// Token: 0x04000286 RID: 646
		public uint Unknown_6Ch;

		// Token: 0x04000287 RID: 647
		public EffectRule EmitterRule;

		// Token: 0x04000288 RID: 648
		public string_r p1data;
	}
}
