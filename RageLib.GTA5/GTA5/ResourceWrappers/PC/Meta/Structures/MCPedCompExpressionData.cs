using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001BE RID: 446
	public class MCPedCompExpressionData : MetaStructureWrapper<CPedCompExpressionData>
	{
		// Token: 0x0600076A RID: 1898 RVA: 0x0003392C File Offset: 0x00031B2C
		public MCPedCompExpressionData()
		{
			this.MetaName = MetaName.CPedCompExpressionData;
			this.MetaStructure = default(CPedCompExpressionData);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0003394C File Offset: 0x00031B4C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCPedCompExpressionData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCPedCompExpressionData._MetaName);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0003398B File Offset: 0x00031B8B
		public override void Parse(MetaFile meta, CPedCompExpressionData CPedCompExpressionData)
		{
			this.Meta = meta;
			this.MetaStructure = CPedCompExpressionData;
			this.PedCompID = CPedCompExpressionData.pedCompID;
			this.PedCompVarIndex = CPedCompExpressionData.pedCompVarIndex;
			this.PedCompExpressionIndex = CPedCompExpressionData.pedCompExpressionIndex;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x000339C0 File Offset: 0x00031BC0
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.pedCompID = this.PedCompID;
			this.MetaStructure.pedCompVarIndex = this.PedCompVarIndex;
			this.MetaStructure.pedCompExpressionIndex = this.PedCompExpressionIndex;
			MCPedCompExpressionData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CPedCompExpressionData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040038AE RID: 14510
		public static MetaName _MetaName = MetaName.CPedCompExpressionData;

		// Token: 0x040038AF RID: 14511
		public MetaFile Meta;

		// Token: 0x040038B0 RID: 14512
		public uint PedCompID;

		// Token: 0x040038B1 RID: 14513
		public int PedCompVarIndex;

		// Token: 0x040038B2 RID: 14514
		public uint PedCompExpressionIndex;

		// Token: 0x040038B3 RID: 14515
		public Array_byte Tracks;

		// Token: 0x040038B4 RID: 14516
		public Array_ushort Ids;

		// Token: 0x040038B5 RID: 14517
		public Array_byte Types;

		// Token: 0x040038B6 RID: 14518
		public Array_byte Components;
	}
}
