using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001C9 RID: 457
	public class MCShaderVariableComponent : MetaStructureWrapper<CShaderVariableComponent>
	{
		// Token: 0x060007A1 RID: 1953 RVA: 0x00034ADB File Offset: 0x00032CDB
		public MCShaderVariableComponent()
		{
			this.MetaName = MetaName.CShaderVariableComponent;
			this.MetaStructure = default(CShaderVariableComponent);
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x00034AFC File Offset: 0x00032CFC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCShaderVariableComponent._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCShaderVariableComponent._MetaName);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00034B3B File Offset: 0x00032D3B
		public override void Parse(MetaFile meta, CShaderVariableComponent CShaderVariableComponent)
		{
			this.Meta = meta;
			this.MetaStructure = CShaderVariableComponent;
			this.PedcompID = CShaderVariableComponent.pedcompID;
			this.MaskID = CShaderVariableComponent.maskID;
			this.ShaderVariableHashString = CShaderVariableComponent.shaderVariableHashString;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00034B70 File Offset: 0x00032D70
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.pedcompID = this.PedcompID;
			this.MetaStructure.maskID = this.MaskID;
			this.MetaStructure.shaderVariableHashString = this.ShaderVariableHashString;
			MCShaderVariableComponent.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CShaderVariableComponent>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003904 RID: 14596
		public static MetaName _MetaName = MetaName.CShaderVariableComponent;

		// Token: 0x04003905 RID: 14597
		public MetaFile Meta;

		// Token: 0x04003906 RID: 14598
		public uint PedcompID;

		// Token: 0x04003907 RID: 14599
		public uint MaskID;

		// Token: 0x04003908 RID: 14600
		public uint ShaderVariableHashString;

		// Token: 0x04003909 RID: 14601
		public Array_byte Tracks;

		// Token: 0x0400390A RID: 14602
		public Array_ushort Ids;

		// Token: 0x0400390B RID: 14603
		public Array_byte Components;
	}
}
