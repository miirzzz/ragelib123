using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AB RID: 427
	public class MCExtensionDefLadder : MetaStructureWrapper<CExtensionDefLadder>
	{
		// Token: 0x060006F7 RID: 1783 RVA: 0x0002F56C File Offset: 0x0002D76C
		public MCExtensionDefLadder()
		{
			this.MetaName = MetaName.CExtensionDefLadder;
			this.MetaStructure = default(CExtensionDefLadder);
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x0002F58C File Offset: 0x0002D78C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefLadder._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefLadder._MetaName);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x0002F5CC File Offset: 0x0002D7CC
		public override void Parse(MetaFile meta, CExtensionDefLadder CExtensionDefLadder)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefLadder;
			this.Name = CExtensionDefLadder.name;
			this.OffsetPosition = CExtensionDefLadder.offsetPosition;
			this.Bottom = CExtensionDefLadder.bottom;
			this.Top = CExtensionDefLadder.top;
			this.Normal = CExtensionDefLadder.normal;
			this.MaterialType = CExtensionDefLadder.materialType;
			this.Template = CExtensionDefLadder.template;
			this.CanGetOffAtTop = CExtensionDefLadder.canGetOffAtTop;
			this.CanGetOffAtBottom = CExtensionDefLadder.canGetOffAtBottom;
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x0002F654 File Offset: 0x0002D854
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.bottom = this.Bottom;
			this.MetaStructure.top = this.Top;
			this.MetaStructure.normal = this.Normal;
			this.MetaStructure.materialType = this.MaterialType;
			this.MetaStructure.template = this.Template;
			this.MetaStructure.canGetOffAtTop = this.CanGetOffAtTop;
			this.MetaStructure.canGetOffAtBottom = this.CanGetOffAtBottom;
			MCExtensionDefLadder.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefLadder>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400378E RID: 14222
		public static MetaName _MetaName = MetaName.CExtensionDefLadder;

		// Token: 0x0400378F RID: 14223
		public MetaFile Meta;

		// Token: 0x04003790 RID: 14224
		public uint Name;

		// Token: 0x04003791 RID: 14225
		public Vector3 OffsetPosition;

		// Token: 0x04003792 RID: 14226
		public Vector3 Bottom;

		// Token: 0x04003793 RID: 14227
		public Vector3 Top;

		// Token: 0x04003794 RID: 14228
		public Vector3 Normal;

		// Token: 0x04003795 RID: 14229
		public Unk_1294270217 MaterialType;

		// Token: 0x04003796 RID: 14230
		public uint Template;

		// Token: 0x04003797 RID: 14231
		public byte CanGetOffAtTop;

		// Token: 0x04003798 RID: 14232
		public byte CanGetOffAtBottom;
	}
}
