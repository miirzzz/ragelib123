using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000154 RID: 340
	public class ClipAnimationsEntry : ResourceSystemBlock
	{
		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000535 RID: 1333 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00024670 File Offset: 0x00022870
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadSingle();
			this.Unknown_4h = reader.ReadSingle();
			this.Unknown_8h = reader.ReadSingle();
			this.Unknown_Ch = reader.ReadUInt32();
			this.AnimationPointer = reader.ReadUInt64();
			this.Animation = reader.ReadBlockAt<Animation>(this.AnimationPointer, Array.Empty<object>());
		}

		// Token: 0x06000537 RID: 1335 RVA: 0x000246D0 File Offset: 0x000228D0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.AnimationPointer = (ulong)((this.Animation != null) ? this.Animation.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.AnimationPointer);
		}

		// Token: 0x06000538 RID: 1336 RVA: 0x00024738 File Offset: 0x00022938
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Animation != null)
			{
				list.Add(this.Animation);
			}
			return list.ToArray();
		}

		// Token: 0x04003593 RID: 13715
		public float Unknown_0h;

		// Token: 0x04003594 RID: 13716
		public float Unknown_4h;

		// Token: 0x04003595 RID: 13717
		public float Unknown_8h;

		// Token: 0x04003596 RID: 13718
		public uint Unknown_Ch;

		// Token: 0x04003597 RID: 13719
		public ulong AnimationPointer;

		// Token: 0x04003598 RID: 13720
		public Animation Animation;
	}
}
