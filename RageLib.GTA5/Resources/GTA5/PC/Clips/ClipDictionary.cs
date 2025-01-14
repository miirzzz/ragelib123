using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000155 RID: 341
	public class ClipDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600053A RID: 1338 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x0600053B RID: 1339 RVA: 0x00024768 File Offset: 0x00022968
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.AnimationsPointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.ClipsPointer = reader.ReadUInt64();
			this.ClipEntriesCount = reader.ReadUInt16();
			this.ClipEntriesTotalCount = reader.ReadUInt16();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Animations = reader.ReadBlockAt<AnimationMap>(this.AnimationsPointer, Array.Empty<object>());
			this.Clips = reader.ReadBlockAt<ResourcePointerArray64<ClipMapEntry>>(this.ClipsPointer, new object[]
			{
				this.ClipEntriesCount
			});
		}

		// Token: 0x0600053C RID: 1340 RVA: 0x00024840 File Offset: 0x00022A40
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.AnimationsPointer = (ulong)((this.Animations != null) ? this.Animations.Position : 0L);
			this.ClipsPointer = (ulong)((this.Clips != null) ? this.Clips.Position : 0L);
			this.ClipEntriesCount = (ushort)((this.Clips != null) ? this.Clips.Count : 0);
			if (this.Clips != null)
			{
				int num = 0;
				foreach (ClipMapEntry clipMapEntry in this.Clips.data_items)
				{
					if (clipMapEntry != null)
					{
						ClipMapEntry clipMapEntry2 = clipMapEntry;
						for (;;)
						{
							if (clipMapEntry2.Clip != null)
							{
								num++;
							}
							if (clipMapEntry2.Next == null)
							{
								break;
							}
							clipMapEntry2 = clipMapEntry2.Next;
						}
					}
				}
				this.ClipEntriesTotalCount = (ushort)num;
			}
			else
			{
				this.ClipEntriesTotalCount = 0;
			}
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.AnimationsPointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.ClipsPointer);
			writer.Write(this.ClipEntriesCount);
			writer.Write(this.ClipEntriesTotalCount);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x0600053D RID: 1341 RVA: 0x000249B4 File Offset: 0x00022BB4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Animations != null)
			{
				list.Add(this.Animations);
			}
			if (this.Clips != null)
			{
				list.Add(this.Clips);
			}
			return list.ToArray();
		}

		// Token: 0x04003599 RID: 13721
		public uint Unknown_10h;

		// Token: 0x0400359A RID: 13722
		public uint Unknown_14h;

		// Token: 0x0400359B RID: 13723
		public ulong AnimationsPointer;

		// Token: 0x0400359C RID: 13724
		public uint Unknown_20h;

		// Token: 0x0400359D RID: 13725
		public uint Unknown_24h;

		// Token: 0x0400359E RID: 13726
		public ulong ClipsPointer;

		// Token: 0x0400359F RID: 13727
		public ushort ClipEntriesCount;

		// Token: 0x040035A0 RID: 13728
		public ushort ClipEntriesTotalCount;

		// Token: 0x040035A1 RID: 13729
		public uint Unknown_34h;

		// Token: 0x040035A2 RID: 13730
		public uint Unknown_38h;

		// Token: 0x040035A3 RID: 13731
		public uint Unknown_3Ch;

		// Token: 0x040035A4 RID: 13732
		public AnimationMap Animations;

		// Token: 0x040035A5 RID: 13733
		public ResourcePointerArray64<ClipMapEntry> Clips;
	}
}
