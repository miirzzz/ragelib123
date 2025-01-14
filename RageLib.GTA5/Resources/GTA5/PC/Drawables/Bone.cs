using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000102 RID: 258
	public class Bone : ResourceSystemBlock
	{
		// Token: 0x1700011E RID: 286
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0000553F File Offset: 0x0000373F
		public override long Length
		{
			get
			{
				return 80L;
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0001B9C8 File Offset: 0x00019BC8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.RotationX = reader.ReadSingle();
			this.RotationY = reader.ReadSingle();
			this.RotationZ = reader.ReadSingle();
			this.RotationW = reader.ReadSingle();
			this.TranslationX = reader.ReadSingle();
			this.TranslationY = reader.ReadSingle();
			this.TranslationZ = reader.ReadSingle();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.ScaleX = reader.ReadSingle();
			this.ScaleY = reader.ReadSingle();
			this.ScaleZ = reader.ReadSingle();
			this.Unknown_2Ch = reader.ReadSingle();
			this.NextSiblingIndex = reader.ReadInt16();
			this.ParentIndex = reader.ReadInt16();
			this.Unknown_34h = reader.ReadUInt32();
			this.NamePointer = reader.ReadUInt64();
			this.Flags = reader.ReadUInt16();
			this.Unknown_42h = reader.ReadUInt16();
			this.Id = reader.ReadUInt16();
			this.Unknown_46h = reader.ReadUInt16();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0001BAF4 File Offset: 0x00019CF4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			writer.Write(this.RotationX);
			writer.Write(this.RotationY);
			writer.Write(this.RotationZ);
			writer.Write(this.RotationW);
			writer.Write(this.TranslationX);
			writer.Write(this.TranslationY);
			writer.Write(this.TranslationZ);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.ScaleX);
			writer.Write(this.ScaleY);
			writer.Write(this.ScaleZ);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.NextSiblingIndex);
			writer.Write(this.ParentIndex);
			writer.Write(this.Unknown_34h);
			writer.Write(this.NamePointer);
			writer.Write(this.Flags);
			writer.Write(this.Unknown_42h);
			writer.Write(this.Id);
			writer.Write(this.Unknown_46h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x0001BC28 File Offset: 0x00019E28
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x0400310F RID: 12559
		public float RotationX;

		// Token: 0x04003110 RID: 12560
		public float RotationY;

		// Token: 0x04003111 RID: 12561
		public float RotationZ;

		// Token: 0x04003112 RID: 12562
		public float RotationW;

		// Token: 0x04003113 RID: 12563
		public float TranslationX;

		// Token: 0x04003114 RID: 12564
		public float TranslationY;

		// Token: 0x04003115 RID: 12565
		public float TranslationZ;

		// Token: 0x04003116 RID: 12566
		public uint Unknown_1Ch;

		// Token: 0x04003117 RID: 12567
		public float ScaleX;

		// Token: 0x04003118 RID: 12568
		public float ScaleY;

		// Token: 0x04003119 RID: 12569
		public float ScaleZ;

		// Token: 0x0400311A RID: 12570
		public float Unknown_2Ch;

		// Token: 0x0400311B RID: 12571
		public short NextSiblingIndex;

		// Token: 0x0400311C RID: 12572
		public short ParentIndex;

		// Token: 0x0400311D RID: 12573
		public uint Unknown_34h;

		// Token: 0x0400311E RID: 12574
		public ulong NamePointer;

		// Token: 0x0400311F RID: 12575
		public ushort Flags;

		// Token: 0x04003120 RID: 12576
		public ushort Unknown_42h;

		// Token: 0x04003121 RID: 12577
		public ushort Id;

		// Token: 0x04003122 RID: 12578
		public ushort Unknown_46h;

		// Token: 0x04003123 RID: 12579
		public uint Unknown_48h;

		// Token: 0x04003124 RID: 12580
		public uint Unknown_4Ch;

		// Token: 0x04003125 RID: 12581
		public string_r Name;
	}
}
