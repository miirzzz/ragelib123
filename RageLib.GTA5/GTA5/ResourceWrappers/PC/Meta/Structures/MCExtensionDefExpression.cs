using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AA RID: 426
	public class MCExtensionDefExpression : MetaStructureWrapper<CExtensionDefExpression>
	{
		// Token: 0x060006F2 RID: 1778 RVA: 0x0002F3FC File Offset: 0x0002D5FC
		public MCExtensionDefExpression()
		{
			this.MetaName = MetaName.CExtensionDefExpression;
			this.MetaStructure = default(CExtensionDefExpression);
		}

		// Token: 0x060006F3 RID: 1779 RVA: 0x0002F41C File Offset: 0x0002D61C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefExpression._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefExpression._MetaName);
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x0002F45C File Offset: 0x0002D65C
		public override void Parse(MetaFile meta, CExtensionDefExpression CExtensionDefExpression)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefExpression;
			this.Name = CExtensionDefExpression.name;
			this.OffsetPosition = CExtensionDefExpression.offsetPosition;
			this.Unk_1095612811 = CExtensionDefExpression.Unk_1095612811;
			this.ExpressionName = CExtensionDefExpression.expressionName;
			this.Unk_2766477159 = CExtensionDefExpression.Unk_2766477159;
			this.Unk_1562817888 = CExtensionDefExpression.Unk_1562817888;
		}

		// Token: 0x060006F5 RID: 1781 RVA: 0x0002F4C0 File Offset: 0x0002D6C0
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.Unk_1095612811 = this.Unk_1095612811;
			this.MetaStructure.expressionName = this.ExpressionName;
			this.MetaStructure.Unk_2766477159 = this.Unk_2766477159;
			this.MetaStructure.Unk_1562817888 = this.Unk_1562817888;
			MCExtensionDefExpression.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefExpression>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003786 RID: 14214
		public static MetaName _MetaName = MetaName.CExtensionDefExpression;

		// Token: 0x04003787 RID: 14215
		public MetaFile Meta;

		// Token: 0x04003788 RID: 14216
		public uint Name;

		// Token: 0x04003789 RID: 14217
		public Vector3 OffsetPosition;

		// Token: 0x0400378A RID: 14218
		public uint Unk_1095612811;

		// Token: 0x0400378B RID: 14219
		public uint ExpressionName;

		// Token: 0x0400378C RID: 14220
		public uint Unk_2766477159;

		// Token: 0x0400378D RID: 14221
		public byte Unk_1562817888;
	}
}
