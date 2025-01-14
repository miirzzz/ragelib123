using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000163 RID: 355
	public class Tag : Property
	{
		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x0000553F File Offset: 0x0000373F
		public override long Length
		{
			get
			{
				return 80L;
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x0002574C File Offset: 0x0002394C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.TagsPointer = reader.ReadUInt64();
			this.Tags = reader.ReadBlockAt<Tags>(this.TagsPointer, Array.Empty<object>());
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x0002579C File Offset: 0x0002399C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.TagsPointer = (ulong)((this.Tags != null) ? this.Tags.Position : 0L);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.TagsPointer);
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x000257F4 File Offset: 0x000239F4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Tags != null)
			{
				list.Add(this.Tags);
			}
			return list.ToArray();
		}

		// Token: 0x040035FD RID: 13821
		public uint Unknown_40h;

		// Token: 0x040035FE RID: 13822
		public uint Unknown_44h;

		// Token: 0x040035FF RID: 13823
		public ulong TagsPointer;

		// Token: 0x04003600 RID: 13824
		public Tags Tags;
	}
}
