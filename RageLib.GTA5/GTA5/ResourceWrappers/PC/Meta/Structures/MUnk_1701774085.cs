using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D9 RID: 473
	public class MUnk_1701774085 : MetaStructureWrapper<Unk_1701774085>
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x000361F5 File Offset: 0x000343F5
		public MUnk_1701774085()
		{
			this.MetaName = (MetaName)1701774085;
			this.MetaStructure = default(Unk_1701774085);
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00036220 File Offset: 0x00034420
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_1701774085._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_1701774085._MetaName);
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x00036260 File Offset: 0x00034460
		public override void Parse(MetaFile meta, Unk_1701774085 Unk_1701774085)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_1701774085;
			this.OwnerName = MetaUtils.GetString(this.Meta, Unk_1701774085.OwnerName);
			this.Rotation = Unk_1701774085.Rotation;
			this.Position = Unk_1701774085.Position;
			this.Normal = Unk_1701774085.Normal;
			this.CapsuleRadius = Unk_1701774085.CapsuleRadius;
			this.CapsuleLen = Unk_1701774085.CapsuleLen;
			this.CapsuleHalfHeight = Unk_1701774085.CapsuleHalfHeight;
			this.CapsuleHalfWidth = Unk_1701774085.CapsuleHalfWidth;
			this.Flags = Unk_1701774085.Flags;
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x000362F4 File Offset: 0x000344F4
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.OwnerName = mb.AddStringPtr(this.OwnerName);
			this.MetaStructure.Rotation = this.Rotation;
			this.MetaStructure.Position = this.Position;
			this.MetaStructure.Normal = this.Normal;
			this.MetaStructure.CapsuleRadius = this.CapsuleRadius;
			this.MetaStructure.CapsuleLen = this.CapsuleLen;
			this.MetaStructure.CapsuleHalfHeight = this.CapsuleHalfHeight;
			this.MetaStructure.CapsuleHalfWidth = this.CapsuleHalfWidth;
			this.MetaStructure.Flags = this.Flags;
			MUnk_1701774085.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_1701774085>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400396F RID: 14703
		public static MetaName _MetaName = (MetaName)1701774085;

		// Token: 0x04003970 RID: 14704
		public MetaFile Meta;

		// Token: 0x04003971 RID: 14705
		public string OwnerName = "";

		// Token: 0x04003972 RID: 14706
		public Vector4 Rotation;

		// Token: 0x04003973 RID: 14707
		public Vector3 Position;

		// Token: 0x04003974 RID: 14708
		public Vector3 Normal;

		// Token: 0x04003975 RID: 14709
		public float CapsuleRadius;

		// Token: 0x04003976 RID: 14710
		public float CapsuleLen;

		// Token: 0x04003977 RID: 14711
		public float CapsuleHalfHeight;

		// Token: 0x04003978 RID: 14712
		public float CapsuleHalfWidth;

		// Token: 0x04003979 RID: 14713
		public Unk_3044470860 Flags;
	}
}
