using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000150 RID: 336
	public class AnimationMapEntry : ResourceSystemBlock
	{
		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000520 RID: 1312 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00023ECC File Offset: 0x000220CC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Hash = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.AnimationPointer = reader.ReadUInt64();
			this.NextEntryPointer = reader.ReadUInt64();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Animation = reader.ReadBlockAt<Animation>(this.AnimationPointer, Array.Empty<object>());
			this.NextEntry = reader.ReadBlockAt<AnimationMapEntry>(this.NextEntryPointer, Array.Empty<object>());
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x00023F50 File Offset: 0x00022150
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.AnimationPointer = (ulong)((this.Animation != null) ? this.Animation.Position : 0L);
			this.NextEntryPointer = (ulong)((this.NextEntry != null) ? this.NextEntry.Position : 0L);
			writer.Write(this.Hash);
			writer.Write(this.Unknown_4h);
			writer.Write(this.AnimationPointer);
			writer.Write(this.NextEntryPointer);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000523 RID: 1315 RVA: 0x00023FE0 File Offset: 0x000221E0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Animation != null)
			{
				list.Add(this.Animation);
			}
			if (this.NextEntry != null)
			{
				list.Add(this.NextEntry);
			}
			return list.ToArray();
		}

		// Token: 0x04003565 RID: 13669
		public uint Hash;

		// Token: 0x04003566 RID: 13670
		public uint Unknown_4h;

		// Token: 0x04003567 RID: 13671
		public ulong AnimationPointer;

		// Token: 0x04003568 RID: 13672
		public ulong NextEntryPointer;

		// Token: 0x04003569 RID: 13673
		public uint Unknown_18h;

		// Token: 0x0400356A RID: 13674
		public uint Unknown_1Ch;

		// Token: 0x0400356B RID: 13675
		public Animation Animation;

		// Token: 0x0400356C RID: 13676
		public AnimationMapEntry NextEntry;
	}
}
