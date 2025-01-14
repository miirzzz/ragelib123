using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010B RID: 267
	public class Joints : ResourceSystemBlock
	{
		// Token: 0x17000128 RID: 296
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001D584 File Offset: 0x0001B784
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.RotationLimitsPointer = reader.ReadUInt64();
			this.TranslationLimitsPointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.RotationLimitsCount = reader.ReadUInt16();
			this.TranslationLimitsCount = reader.ReadUInt16();
			this.Unknown_34h = reader.ReadUInt16();
			this.Unknown_36h = reader.ReadUInt16();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.RotationLimits = reader.ReadBlockAt<ResourceSimpleArray<JointRotationLimit>>(this.RotationLimitsPointer, new object[]
			{
				this.RotationLimitsCount
			});
			this.TranslationLimits = reader.ReadBlockAt<ResourceSimpleArray<JointTranslationLimit>>(this.TranslationLimitsPointer, new object[]
			{
				this.TranslationLimitsCount
			});
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001D6A0 File Offset: 0x0001B8A0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.RotationLimitsPointer = (ulong)((this.RotationLimits != null) ? this.RotationLimits.Position : 0L);
			this.TranslationLimitsPointer = (ulong)((this.TranslationLimits != null) ? this.TranslationLimits.Position : 0L);
			this.RotationLimitsCount = (ushort)((this.RotationLimits != null) ? this.RotationLimits.Count : 0);
			this.TranslationLimitsCount = (ushort)((this.TranslationLimits != null) ? this.TranslationLimits.Count : 0);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.RotationLimitsPointer);
			writer.Write(this.TranslationLimitsPointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.RotationLimitsCount);
			writer.Write(this.TranslationLimitsCount);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_36h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001D7E4 File Offset: 0x0001B9E4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.RotationLimits != null)
			{
				list.Add(this.RotationLimits);
			}
			if (this.TranslationLimits != null)
			{
				list.Add(this.TranslationLimits);
			}
			return list.ToArray();
		}

		// Token: 0x040031E3 RID: 12771
		public uint VFT;

		// Token: 0x040031E4 RID: 12772
		public uint Unknown_4h;

		// Token: 0x040031E5 RID: 12773
		public uint Unknown_8h;

		// Token: 0x040031E6 RID: 12774
		public uint Unknown_Ch;

		// Token: 0x040031E7 RID: 12775
		public ulong RotationLimitsPointer;

		// Token: 0x040031E8 RID: 12776
		public ulong TranslationLimitsPointer;

		// Token: 0x040031E9 RID: 12777
		public uint Unknown_20h;

		// Token: 0x040031EA RID: 12778
		public uint Unknown_24h;

		// Token: 0x040031EB RID: 12779
		public uint Unknown_28h;

		// Token: 0x040031EC RID: 12780
		public uint Unknown_2Ch;

		// Token: 0x040031ED RID: 12781
		public ushort RotationLimitsCount;

		// Token: 0x040031EE RID: 12782
		public ushort TranslationLimitsCount;

		// Token: 0x040031EF RID: 12783
		public ushort Unknown_34h;

		// Token: 0x040031F0 RID: 12784
		public ushort Unknown_36h;

		// Token: 0x040031F1 RID: 12785
		public uint Unknown_38h;

		// Token: 0x040031F2 RID: 12786
		public uint Unknown_3Ch;

		// Token: 0x040031F3 RID: 12787
		public ResourceSimpleArray<JointRotationLimit> RotationLimits;

		// Token: 0x040031F4 RID: 12788
		public ResourceSimpleArray<JointTranslationLimit> TranslationLimits;
	}
}
