using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BF RID: 447
	public class MCPedPropExpressionData : MetaStructureWrapper<CPedPropExpressionData>
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x00033A39 File Offset: 0x00031C39
		public MCPedPropExpressionData()
		{
			this.MetaName = MetaName.CPedPropExpressionData;
			this.MetaStructure = default(CPedPropExpressionData);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x00033A58 File Offset: 0x00031C58
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCPedPropExpressionData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCPedPropExpressionData._MetaName);
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x00033A97 File Offset: 0x00031C97
		public override void Parse(MetaFile meta, CPedPropExpressionData CPedPropExpressionData)
		{
			this.Meta = meta;
			this.MetaStructure = CPedPropExpressionData;
			this.PedPropID = CPedPropExpressionData.pedPropID;
			this.PedPropVarIndex = CPedPropExpressionData.pedPropVarIndex;
			this.PedPropExpressionIndex = CPedPropExpressionData.pedPropExpressionIndex;
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x00033ACC File Offset: 0x00031CCC
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.pedPropID = this.PedPropID;
			this.MetaStructure.pedPropVarIndex = this.PedPropVarIndex;
			this.MetaStructure.pedPropExpressionIndex = this.PedPropExpressionIndex;
			MCPedPropExpressionData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CPedPropExpressionData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038B7 RID: 14519
		public static MetaName _MetaName = MetaName.CPedPropExpressionData;

		// Token: 0x040038B8 RID: 14520
		public MetaFile Meta;

		// Token: 0x040038B9 RID: 14521
		public uint PedPropID;

		// Token: 0x040038BA RID: 14522
		public int PedPropVarIndex;

		// Token: 0x040038BB RID: 14523
		public uint PedPropExpressionIndex;

		// Token: 0x040038BC RID: 14524
		public Array_byte Tracks;

		// Token: 0x040038BD RID: 14525
		public Array_ushort Ids;

		// Token: 0x040038BE RID: 14526
		public Array_byte Types;

		// Token: 0x040038BF RID: 14527
		public Array_byte Components;
	}
}
