using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000164 RID: 356
	public class Tags : ResourceSystemBlock
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00025830 File Offset: 0x00023A30
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.TagListPointer = reader.ReadUInt64();
			this.TagsCount1 = reader.ReadUInt16();
			this.TagsCount2 = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.TagList = reader.ReadBlockAt<ResourcePointerArray64<Tag>>(this.TagListPointer, new object[]
			{
				this.TagsCount1
			});
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x000258C4 File Offset: 0x00023AC4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.TagListPointer = (ulong)((this.TagList != null) ? this.TagList.Position : 0L);
			this.TagsCount1 = (ushort)((this.TagList != null) ? this.TagList.Count : 0);
			this.TagsCount2 = (ushort)((this.TagList != null) ? this.TagList.Count : 0);
			writer.Write(this.TagListPointer);
			writer.Write(this.TagsCount1);
			writer.Write(this.TagsCount2);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00025988 File Offset: 0x00023B88
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.TagList != null)
			{
				list.Add(this.TagList);
			}
			return list.ToArray();
		}

		// Token: 0x04003601 RID: 13825
		public ulong TagListPointer;

		// Token: 0x04003602 RID: 13826
		public ushort TagsCount1;

		// Token: 0x04003603 RID: 13827
		public ushort TagsCount2;

		// Token: 0x04003604 RID: 13828
		public uint Unknown_Ch;

		// Token: 0x04003605 RID: 13829
		public uint Unknown_10h;

		// Token: 0x04003606 RID: 13830
		public uint Unknown_14h;

		// Token: 0x04003607 RID: 13831
		public uint Unknown_18h;

		// Token: 0x04003608 RID: 13832
		public uint Unknown_1Ch;

		// Token: 0x04003609 RID: 13833
		public ResourcePointerArray64<Tag> TagList;
	}
}
