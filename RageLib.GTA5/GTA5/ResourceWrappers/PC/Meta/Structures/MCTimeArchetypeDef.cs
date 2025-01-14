using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CC RID: 460
	public class MCTimeArchetypeDef : MetaStructureWrapper<CTimeArchetypeDef>
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x00034F17 File Offset: 0x00033117
		public MCTimeArchetypeDef()
		{
			this.MetaName = MetaName.CTimeArchetypeDef;
			this.MetaStructure = default(CTimeArchetypeDef);
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x00034F38 File Offset: 0x00033138
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCTimeArchetypeDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCTimeArchetypeDef._MetaName);
		}

		// Token: 0x060007B2 RID: 1970 RVA: 0x00034F78 File Offset: 0x00033178
		public override void Parse(MetaFile meta, CTimeArchetypeDef CTimeArchetypeDef)
		{
			this.Meta = meta;
			this.MetaStructure = CTimeArchetypeDef;
			this.LodDist = CTimeArchetypeDef.lodDist;
			this.Flags = CTimeArchetypeDef.flags;
			this.SpecialAttribute = CTimeArchetypeDef.specialAttribute;
			this.BbMin = CTimeArchetypeDef.bbMin;
			this.BbMax = CTimeArchetypeDef.bbMax;
			this.BsCentre = CTimeArchetypeDef.bsCentre;
			this.BsRadius = CTimeArchetypeDef.bsRadius;
			this.HdTextureDist = CTimeArchetypeDef.hdTextureDist;
			this.Name = CTimeArchetypeDef.name;
			this.TextureDictionary = CTimeArchetypeDef.textureDictionary;
			this.ClipDictionary = CTimeArchetypeDef.clipDictionary;
			this.DrawableDictionary = CTimeArchetypeDef.drawableDictionary;
			this.PhysicsDictionary = CTimeArchetypeDef.physicsDictionary;
			this.AssetType = CTimeArchetypeDef.assetType;
			this.AssetName = CTimeArchetypeDef.assetName;
			this.TimeFlags = CTimeArchetypeDef.timeFlags;
		}

		// Token: 0x060007B3 RID: 1971 RVA: 0x00035054 File Offset: 0x00033254
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.lodDist = this.LodDist;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.specialAttribute = this.SpecialAttribute;
			this.MetaStructure.bbMin = this.BbMin;
			this.MetaStructure.bbMax = this.BbMax;
			this.MetaStructure.bsCentre = this.BsCentre;
			this.MetaStructure.bsRadius = this.BsRadius;
			this.MetaStructure.hdTextureDist = this.HdTextureDist;
			this.MetaStructure.name = this.Name;
			this.MetaStructure.textureDictionary = this.TextureDictionary;
			this.MetaStructure.clipDictionary = this.ClipDictionary;
			this.MetaStructure.drawableDictionary = this.DrawableDictionary;
			this.MetaStructure.physicsDictionary = this.PhysicsDictionary;
			this.MetaStructure.assetType = this.AssetType;
			this.MetaStructure.assetName = this.AssetName;
			this.MetaStructure.extensions = default(Array_StructurePointer);
			this.MetaStructure.timeFlags = this.TimeFlags;
			MCTimeArchetypeDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CTimeArchetypeDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003919 RID: 14617
		public static MetaName _MetaName = MetaName.CTimeArchetypeDef;

		// Token: 0x0400391A RID: 14618
		public MetaFile Meta;

		// Token: 0x0400391B RID: 14619
		public float LodDist;

		// Token: 0x0400391C RID: 14620
		public uint Flags;

		// Token: 0x0400391D RID: 14621
		public uint SpecialAttribute;

		// Token: 0x0400391E RID: 14622
		public Vector3 BbMin;

		// Token: 0x0400391F RID: 14623
		public Vector3 BbMax;

		// Token: 0x04003920 RID: 14624
		public Vector3 BsCentre;

		// Token: 0x04003921 RID: 14625
		public float BsRadius;

		// Token: 0x04003922 RID: 14626
		public float HdTextureDist;

		// Token: 0x04003923 RID: 14627
		public uint Name;

		// Token: 0x04003924 RID: 14628
		public uint TextureDictionary;

		// Token: 0x04003925 RID: 14629
		public uint ClipDictionary;

		// Token: 0x04003926 RID: 14630
		public uint DrawableDictionary;

		// Token: 0x04003927 RID: 14631
		public uint PhysicsDictionary;

		// Token: 0x04003928 RID: 14632
		public Unk_1991964615 AssetType;

		// Token: 0x04003929 RID: 14633
		public uint AssetName;

		// Token: 0x0400392A RID: 14634
		public Array_StructurePointer Extensions;

		// Token: 0x0400392B RID: 14635
		public uint TimeFlags;
	}
}
