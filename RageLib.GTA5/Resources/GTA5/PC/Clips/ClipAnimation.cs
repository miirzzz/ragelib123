using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000152 RID: 338
	public class ClipAnimation : Clip
	{
		// Token: 0x1700014F RID: 335
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x00024380 File Offset: 0x00022580
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.AnimationPointer = reader.ReadUInt64();
			this.Unknown_58h = reader.ReadSingle();
			this.Unknown_5Ch = reader.ReadSingle();
			this.Unknown_60h = reader.ReadSingle();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Animation = reader.ReadBlockAt<Animation>(this.AnimationPointer, Array.Empty<object>());
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x00024400 File Offset: 0x00022600
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.AnimationPointer = (ulong)((this.Animation != null) ? this.Animation.Position : 0L);
			writer.Write(this.AnimationPointer);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00024488 File Offset: 0x00022688
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			list.AddRange(base.GetReferences());
			if (this.Animation != null)
			{
				list.Add(this.Animation);
			}
			return list.ToArray();
		}

		// Token: 0x04003582 RID: 13698
		public ulong AnimationPointer;

		// Token: 0x04003583 RID: 13699
		public float Unknown_58h;

		// Token: 0x04003584 RID: 13700
		public float Unknown_5Ch;

		// Token: 0x04003585 RID: 13701
		public float Unknown_60h;

		// Token: 0x04003586 RID: 13702
		public uint Unknown_64h;

		// Token: 0x04003587 RID: 13703
		public uint Unknown_68h;

		// Token: 0x04003588 RID: 13704
		public uint Unknown_6Ch;

		// Token: 0x04003589 RID: 13705
		public Animation Animation;
	}
}
