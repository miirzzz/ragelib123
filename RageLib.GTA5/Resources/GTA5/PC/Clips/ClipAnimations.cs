using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000153 RID: 339
	public class ClipAnimations : Clip
	{
		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000530 RID: 1328 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x000244CC File Offset: 0x000226CC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.AnimationsPointer = reader.ReadUInt64();
			this.AnimationsCount1 = reader.ReadUInt16();
			this.AnimationsCount2 = reader.ReadUInt16();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Animations = reader.ReadBlockAt<ResourceSimpleArray<ClipAnimationsEntry>>(this.AnimationsPointer, new object[]
			{
				this.AnimationsCount1
			});
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x00024568 File Offset: 0x00022768
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.AnimationsPointer = (ulong)((this.Animations != null) ? this.Animations.Position : 0L);
			this.AnimationsCount1 = (ushort)((this.Animations != null) ? this.Animations.Count : 0);
			this.AnimationsCount2 = (ushort)((this.Animations != null) ? this.Animations.Count : 0);
			writer.Write(this.AnimationsPointer);
			writer.Write(this.AnimationsCount1);
			writer.Write(this.AnimationsCount2);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x00024634 File Offset: 0x00022834
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			list.AddRange(base.GetReferences());
			if (this.Animations != null)
			{
				list.Add(this.Animations);
			}
			return list.ToArray();
		}

		// Token: 0x0400358A RID: 13706
		public ulong AnimationsPointer;

		// Token: 0x0400358B RID: 13707
		public ushort AnimationsCount1;

		// Token: 0x0400358C RID: 13708
		public ushort AnimationsCount2;

		// Token: 0x0400358D RID: 13709
		public uint Unknown_5Ch;

		// Token: 0x0400358E RID: 13710
		public uint Unknown_60h;

		// Token: 0x0400358F RID: 13711
		public uint Unknown_64h;

		// Token: 0x04003590 RID: 13712
		public uint Unknown_68h;

		// Token: 0x04003591 RID: 13713
		public uint Unknown_6Ch;

		// Token: 0x04003592 RID: 13714
		public ResourceSimpleArray<ClipAnimationsEntry> Animations;
	}
}
