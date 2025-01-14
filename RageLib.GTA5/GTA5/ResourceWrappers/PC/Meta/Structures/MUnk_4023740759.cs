using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001E3 RID: 483
	public class MUnk_4023740759 : MetaStructureWrapper<Unk_4023740759>
	{
		// Token: 0x06000827 RID: 2087 RVA: 0x00037BD9 File Offset: 0x00035DD9
		public MUnk_4023740759()
		{
			this.MetaName = (MetaName)(-271226537);
			this.MetaStructure = default(Unk_4023740759);
		}

		// Token: 0x06000828 RID: 2088 RVA: 0x00037BF8 File Offset: 0x00035DF8
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_4023740759._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_4023740759._MetaName);
			mb.AddStructureInfo(MetaName.CScenarioChainingNode);
			mb.AddStructureInfo(MetaName.CScenarioChainingEdge);
			mb.AddStructureInfo(MetaName.CScenarioChain);
		}

		// Token: 0x06000829 RID: 2089 RVA: 0x00037C58 File Offset: 0x00035E58
		public override void Parse(MetaFile meta, Unk_4023740759 Unk_4023740759)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_4023740759;
			CScenarioChainingNode[] array = MetaUtils.ConvertDataArray<CScenarioChainingNode>(meta, Unk_4023740759.Nodes);
			this.Nodes = ((array != null) ? array.Select(delegate(CScenarioChainingNode e)
			{
				MCScenarioChainingNode mcscenarioChainingNode = new MCScenarioChainingNode();
				mcscenarioChainingNode.Parse(meta, e);
				return mcscenarioChainingNode;
			}).ToList<MCScenarioChainingNode>() : null);
			CScenarioChainingEdge[] array2 = MetaUtils.ConvertDataArray<CScenarioChainingEdge>(meta, Unk_4023740759.Edges);
			this.Edges = ((array2 != null) ? array2.Select(delegate(CScenarioChainingEdge e)
			{
				MCScenarioChainingEdge mcscenarioChainingEdge = new MCScenarioChainingEdge();
				mcscenarioChainingEdge.Parse(meta, e);
				return mcscenarioChainingEdge;
			}).ToList<MCScenarioChainingEdge>() : null);
			CScenarioChain[] array3 = MetaUtils.ConvertDataArray<CScenarioChain>(meta, Unk_4023740759.Chains);
			this.Chains = ((array3 != null) ? array3.Select(delegate(CScenarioChain e)
			{
				MCScenarioChain mcscenarioChain = new MCScenarioChain();
				mcscenarioChain.Parse(meta, e);
				return mcscenarioChain;
			}).ToList<MCScenarioChain>() : null);
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x00037D24 File Offset: 0x00035F24
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.Nodes != null)
			{
				this.MetaStructure.Nodes = mb.AddItemArrayPtr<CScenarioChainingNode>(MetaName.CScenarioChainingNode, this.Nodes.Select(delegate(MCScenarioChainingNode e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioChainingNode>());
			}
			MCScenarioChainingNode.AddEnumAndStructureInfo(mb);
			if (this.Edges != null)
			{
				this.MetaStructure.Edges = mb.AddItemArrayPtr<CScenarioChainingEdge>(MetaName.CScenarioChainingEdge, this.Edges.Select(delegate(MCScenarioChainingEdge e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioChainingEdge>());
			}
			MCScenarioChainingEdge.AddEnumAndStructureInfo(mb);
			if (this.Chains != null)
			{
				this.MetaStructure.Chains = mb.AddItemArrayPtr<CScenarioChain>(MetaName.CScenarioChain, this.Chains.Select(delegate(MCScenarioChain e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CScenarioChain>());
			}
			MCScenarioChain.AddEnumAndStructureInfo(mb);
			MUnk_4023740759.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_4023740759>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040039C1 RID: 14785
		public static MetaName _MetaName = (MetaName)(-271226537);

		// Token: 0x040039C2 RID: 14786
		public MetaFile Meta;

		// Token: 0x040039C3 RID: 14787
		public List<MCScenarioChainingNode> Nodes;

		// Token: 0x040039C4 RID: 14788
		public List<MCScenarioChainingEdge> Edges;

		// Token: 0x040039C5 RID: 14789
		public List<MCScenarioChain> Chains;
	}
}
