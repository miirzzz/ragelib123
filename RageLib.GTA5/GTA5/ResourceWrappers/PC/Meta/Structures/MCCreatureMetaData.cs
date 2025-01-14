using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A1 RID: 417
	public class MCCreatureMetaData : MetaStructureWrapper<CCreatureMetaData>
	{
		// Token: 0x060006C3 RID: 1731 RVA: 0x0002DFCD File Offset: 0x0002C1CD
		public MCCreatureMetaData()
		{
			this.MetaName = MetaName.CCreatureMetaData;
			this.MetaStructure = default(CCreatureMetaData);
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x0002DFEC File Offset: 0x0002C1EC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCCreatureMetaData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCCreatureMetaData._MetaName);
			mb.AddStructureInfo(MetaName.CShaderVariableComponent);
			mb.AddStructureInfo(MetaName.CPedPropExpressionData);
			mb.AddStructureInfo(MetaName.CPedCompExpressionData);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x0002E04C File Offset: 0x0002C24C
		public override void Parse(MetaFile meta, CCreatureMetaData CCreatureMetaData)
		{
			this.Meta = meta;
			this.MetaStructure = CCreatureMetaData;
			CShaderVariableComponent[] array = MetaUtils.ConvertDataArray<CShaderVariableComponent>(meta, CCreatureMetaData.shaderVariableComponents);
			this.ShaderVariableComponents = ((array != null) ? array.Select(delegate(CShaderVariableComponent e)
			{
				MCShaderVariableComponent mcshaderVariableComponent = new MCShaderVariableComponent();
				mcshaderVariableComponent.Parse(meta, e);
				return mcshaderVariableComponent;
			}).ToList<MCShaderVariableComponent>() : null);
			CPedPropExpressionData[] array2 = MetaUtils.ConvertDataArray<CPedPropExpressionData>(meta, CCreatureMetaData.pedPropExpressions);
			this.PedPropExpressions = ((array2 != null) ? array2.Select(delegate(CPedPropExpressionData e)
			{
				MCPedPropExpressionData mcpedPropExpressionData = new MCPedPropExpressionData();
				mcpedPropExpressionData.Parse(meta, e);
				return mcpedPropExpressionData;
			}).ToList<MCPedPropExpressionData>() : null);
			CPedCompExpressionData[] array3 = MetaUtils.ConvertDataArray<CPedCompExpressionData>(meta, CCreatureMetaData.pedCompExpressions);
			this.PedCompExpressions = ((array3 != null) ? array3.Select(delegate(CPedCompExpressionData e)
			{
				MCPedCompExpressionData mcpedCompExpressionData = new MCPedCompExpressionData();
				mcpedCompExpressionData.Parse(meta, e);
				return mcpedCompExpressionData;
			}).ToList<MCPedCompExpressionData>() : null);
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x0002E118 File Offset: 0x0002C318
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.ShaderVariableComponents != null)
			{
				this.MetaStructure.shaderVariableComponents = mb.AddItemArrayPtr<CShaderVariableComponent>(MetaName.CShaderVariableComponent, this.ShaderVariableComponents.Select(delegate(MCShaderVariableComponent e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CShaderVariableComponent>());
			}
			MCShaderVariableComponent.AddEnumAndStructureInfo(mb);
			if (this.PedPropExpressions != null)
			{
				this.MetaStructure.pedPropExpressions = mb.AddItemArrayPtr<CPedPropExpressionData>(MetaName.CPedPropExpressionData, this.PedPropExpressions.Select(delegate(MCPedPropExpressionData e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CPedPropExpressionData>());
			}
			MCPedPropExpressionData.AddEnumAndStructureInfo(mb);
			if (this.PedCompExpressions != null)
			{
				this.MetaStructure.pedCompExpressions = mb.AddItemArrayPtr<CPedCompExpressionData>(MetaName.CPedCompExpressionData, this.PedCompExpressions.Select(delegate(MCPedCompExpressionData e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CPedCompExpressionData>());
			}
			MCPedCompExpressionData.AddEnumAndStructureInfo(mb);
			MCCreatureMetaData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CCreatureMetaData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400373D RID: 14141
		public static MetaName _MetaName = MetaName.CCreatureMetaData;

		// Token: 0x0400373E RID: 14142
		public MetaFile Meta;

		// Token: 0x0400373F RID: 14143
		public List<MCShaderVariableComponent> ShaderVariableComponents;

		// Token: 0x04003740 RID: 14144
		public List<MCPedPropExpressionData> PedPropExpressions;

		// Token: 0x04003741 RID: 14145
		public List<MCPedCompExpressionData> PedCompExpressions;
	}
}
