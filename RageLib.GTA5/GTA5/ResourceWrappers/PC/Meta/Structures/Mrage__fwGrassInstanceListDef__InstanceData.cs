using System;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001D0 RID: 464
	public class Mrage__fwGrassInstanceListDef__InstanceData : MetaStructureWrapper<rage__fwGrassInstanceListDef__InstanceData>
	{
		// Token: 0x060007C3 RID: 1987 RVA: 0x00035619 File Offset: 0x00033819
		public Mrage__fwGrassInstanceListDef__InstanceData()
		{
			this.MetaName = MetaName.rage__fwGrassInstanceListDef__InstanceData;
			this.MetaStructure = default(rage__fwGrassInstanceListDef__InstanceData);
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x00035638 File Offset: 0x00033838
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(Mrage__fwGrassInstanceListDef__InstanceData._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(Mrage__fwGrassInstanceListDef__InstanceData._MetaName);
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x00035678 File Offset: 0x00033878
		public override void Parse(MetaFile meta, rage__fwGrassInstanceListDef__InstanceData rage__fwGrassInstanceListDef__InstanceData)
		{
			this.Meta = meta;
			this.MetaStructure = rage__fwGrassInstanceListDef__InstanceData;
			this.Position = rage__fwGrassInstanceListDef__InstanceData.Position;
			this.NormalX = rage__fwGrassInstanceListDef__InstanceData.NormalX;
			this.NormalY = rage__fwGrassInstanceListDef__InstanceData.NormalY;
			this.Color = rage__fwGrassInstanceListDef__InstanceData.Color;
			this.Scale = rage__fwGrassInstanceListDef__InstanceData.Scale;
			this.Ao = rage__fwGrassInstanceListDef__InstanceData.Ao;
			this.Pad = rage__fwGrassInstanceListDef__InstanceData.Pad;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x000356E8 File Offset: 0x000338E8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.Position = this.Position;
			this.MetaStructure.NormalX = this.NormalX;
			this.MetaStructure.NormalY = this.NormalY;
			this.MetaStructure.Color = this.Color;
			this.MetaStructure.Scale = this.Scale;
			this.MetaStructure.Ao = this.Ao;
			this.MetaStructure.Pad = this.Pad;
			Mrage__fwGrassInstanceListDef__InstanceData.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<rage__fwGrassInstanceListDef__InstanceData>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003941 RID: 14657
		public static MetaName _MetaName = MetaName.rage__fwGrassInstanceListDef__InstanceData;

		// Token: 0x04003942 RID: 14658
		public MetaFile Meta;

		// Token: 0x04003943 RID: 14659
		public ArrayOfBytes3 Position;

		// Token: 0x04003944 RID: 14660
		public byte NormalX;

		// Token: 0x04003945 RID: 14661
		public byte NormalY;

		// Token: 0x04003946 RID: 14662
		public ArrayOfBytes3 Color;

		// Token: 0x04003947 RID: 14663
		public byte Scale;

		// Token: 0x04003948 RID: 14664
		public byte Ao;

		// Token: 0x04003949 RID: 14665
		public ArrayOfBytes3 Pad;
	}
}
