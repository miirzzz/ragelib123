using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000156 RID: 342
	public class ClipMapEntry : ResourceSystemBlock
	{
		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600053F RID: 1343 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000540 RID: 1344 RVA: 0x000249FC File Offset: 0x00022BFC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Hash = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.ClipPointer = reader.ReadUInt64();
			this.NextPointer = reader.ReadUInt64();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Clip = reader.ReadBlockAt<Clip>(this.ClipPointer, Array.Empty<object>());
			this.Next = reader.ReadBlockAt<ClipMapEntry>(this.NextPointer, Array.Empty<object>());
		}

		// Token: 0x06000541 RID: 1345 RVA: 0x00024A80 File Offset: 0x00022C80
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.ClipPointer = (ulong)((this.Clip != null) ? this.Clip.Position : 0L);
			this.NextPointer = (ulong)((this.Next != null) ? this.Next.Position : 0L);
			writer.Write(this.Hash);
			writer.Write(this.Unknown_4h);
			writer.Write(this.ClipPointer);
			writer.Write(this.NextPointer);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000542 RID: 1346 RVA: 0x00024B10 File Offset: 0x00022D10
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Clip != null)
			{
				list.Add(this.Clip);
			}
			if (this.Next != null)
			{
				list.Add(this.Next);
			}
			return list.ToArray();
		}

		// Token: 0x040035A6 RID: 13734
		public uint Hash;

		// Token: 0x040035A7 RID: 13735
		public uint Unknown_4h;

		// Token: 0x040035A8 RID: 13736
		public ulong ClipPointer;

		// Token: 0x040035A9 RID: 13737
		public ulong NextPointer;

		// Token: 0x040035AA RID: 13738
		public uint Unknown_18h;

		// Token: 0x040035AB RID: 13739
		public uint Unknown_1Ch;

		// Token: 0x040035AC RID: 13740
		public Clip Clip;

		// Token: 0x040035AD RID: 13741
		public ClipMapEntry Next;
	}
}
