using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200014F RID: 335
	public class AnimationMap : ResourceSystemBlock
	{
		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00023C80 File Offset: 0x00021E80
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.AnimationsPointer = reader.ReadUInt64();
			this.AnimationEntriesCount = reader.ReadUInt16();
			this.AnimationEntriesTotalCount = reader.ReadUInt16();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Animations = reader.ReadBlockAt<ResourcePointerArray64<AnimationMapEntry>>(this.AnimationsPointer, new object[]
			{
				this.AnimationEntriesCount
			});
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00023D44 File Offset: 0x00021F44
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.AnimationsPointer = (ulong)((this.Animations != null) ? this.Animations.Position : 0L);
			this.AnimationEntriesCount = (ushort)((this.Animations != null) ? this.Animations.Count : 0);
			if (this.Animations != null)
			{
				int num = 0;
				foreach (AnimationMapEntry animationMapEntry in this.Animations.data_items)
				{
					if (animationMapEntry != null)
					{
						AnimationMapEntry animationMapEntry2 = animationMapEntry;
						for (;;)
						{
							if (animationMapEntry2.Animation != null)
							{
								num++;
							}
							if (animationMapEntry2.NextEntry == null)
							{
								break;
							}
							animationMapEntry2 = animationMapEntry2.NextEntry;
						}
					}
				}
				this.AnimationEntriesTotalCount = (ushort)num;
			}
			else
			{
				this.AnimationEntriesTotalCount = 0;
			}
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.AnimationsPointer);
			writer.Write(this.AnimationEntriesCount);
			writer.Write(this.AnimationEntriesTotalCount);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00023E9C File Offset: 0x0002209C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Animations != null)
			{
				list.Add(this.Animations);
			}
			return list.ToArray();
		}

		// Token: 0x04003558 RID: 13656
		public uint VFT;

		// Token: 0x04003559 RID: 13657
		public uint Unknown_4h;

		// Token: 0x0400355A RID: 13658
		public uint Unknown_8h;

		// Token: 0x0400355B RID: 13659
		public uint Unknown_Ch;

		// Token: 0x0400355C RID: 13660
		public uint Unknown_10h;

		// Token: 0x0400355D RID: 13661
		public uint Unknown_14h;

		// Token: 0x0400355E RID: 13662
		public ulong AnimationsPointer;

		// Token: 0x0400355F RID: 13663
		public ushort AnimationEntriesCount;

		// Token: 0x04003560 RID: 13664
		public ushort AnimationEntriesTotalCount;

		// Token: 0x04003561 RID: 13665
		public uint Unknown_24h;

		// Token: 0x04003562 RID: 13666
		public uint Unknown_28h;

		// Token: 0x04003563 RID: 13667
		public uint Unknown_2Ch;

		// Token: 0x04003564 RID: 13668
		public ResourcePointerArray64<AnimationMapEntry> Animations;
	}
}
