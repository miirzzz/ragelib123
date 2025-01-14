using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200003B RID: 59
	public class EmitterRuleDictionary : ResourceSystemBlock
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600014D RID: 333 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00008778 File Offset: 0x00006978
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
			this.HashesPointer = reader.ReadUInt64();
			this.HashesCount1 = reader.ReadUInt16();
			this.HashesCount2 = reader.ReadUInt16();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.EffectRulesPointer = reader.ReadUInt64();
			this.EffectRulesCount1 = reader.ReadUInt16();
			this.EffectRulesCount2 = reader.ReadUInt16();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Hashes = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.HashesPointer, new object[]
			{
				this.HashesCount1
			});
			this.EmitterRules = reader.ReadBlockAt<ResourcePointerArray64<EmitterRule>>(this.EffectRulesPointer, new object[]
			{
				this.EffectRulesCount1
			});
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00008894 File Offset: 0x00006A94
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.HashesPointer = (ulong)((this.Hashes != null) ? this.Hashes.Position : 0L);
			this.EffectRulesPointer = (ulong)((this.EmitterRules != null) ? this.EmitterRules.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.HashesPointer);
			writer.Write(this.HashesCount1);
			writer.Write(this.HashesCount2);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.EffectRulesPointer);
			writer.Write(this.EffectRulesCount1);
			writer.Write(this.EffectRulesCount2);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000899C File Offset: 0x00006B9C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Hashes != null)
			{
				list.Add(this.Hashes);
			}
			if (this.EmitterRules != null)
			{
				list.Add(this.EmitterRules);
			}
			return list.ToArray();
		}

		// Token: 0x040002B8 RID: 696
		public uint VFT;

		// Token: 0x040002B9 RID: 697
		public uint Unknown_4h;

		// Token: 0x040002BA RID: 698
		public uint Unknown_8h;

		// Token: 0x040002BB RID: 699
		public uint Unknown_Ch;

		// Token: 0x040002BC RID: 700
		public uint Unknown_10h;

		// Token: 0x040002BD RID: 701
		public uint Unknown_14h;

		// Token: 0x040002BE RID: 702
		public uint Unknown_18h;

		// Token: 0x040002BF RID: 703
		public uint Unknown_1Ch;

		// Token: 0x040002C0 RID: 704
		public ulong HashesPointer;

		// Token: 0x040002C1 RID: 705
		public ushort HashesCount1;

		// Token: 0x040002C2 RID: 706
		public ushort HashesCount2;

		// Token: 0x040002C3 RID: 707
		public uint Unknown_2Ch;

		// Token: 0x040002C4 RID: 708
		public ulong EffectRulesPointer;

		// Token: 0x040002C5 RID: 709
		public ushort EffectRulesCount1;

		// Token: 0x040002C6 RID: 710
		public ushort EffectRulesCount2;

		// Token: 0x040002C7 RID: 711
		public uint Unknown_3Ch;

		// Token: 0x040002C8 RID: 712
		public ResourceSimpleArray<uint_r> Hashes;

		// Token: 0x040002C9 RID: 713
		public ResourcePointerArray64<EmitterRule> EmitterRules;
	}
}
