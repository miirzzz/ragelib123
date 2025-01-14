using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A9 RID: 425
	public class MCExtensionDefExplosionEffect : MetaStructureWrapper<CExtensionDefExplosionEffect>
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x0002F236 File Offset: 0x0002D436
		public MCExtensionDefExplosionEffect()
		{
			this.MetaName = MetaName.CExtensionDefExplosionEffect;
			this.MetaStructure = default(CExtensionDefExplosionEffect);
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0002F260 File Offset: 0x0002D460
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefExplosionEffect._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefExplosionEffect._MetaName);
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0002F2A0 File Offset: 0x0002D4A0
		public override void Parse(MetaFile meta, CExtensionDefExplosionEffect CExtensionDefExplosionEffect)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefExplosionEffect;
			this.Name = CExtensionDefExplosionEffect.name;
			this.OffsetPosition = CExtensionDefExplosionEffect.offsetPosition;
			this.OffsetRotation = CExtensionDefExplosionEffect.offsetRotation;
			this.ExplosionName = MetaUtils.GetString(this.Meta, CExtensionDefExplosionEffect.explosionName);
			this.BoneTag = CExtensionDefExplosionEffect.boneTag;
			this.ExplosionTag = CExtensionDefExplosionEffect.explosionTag;
			this.ExplosionType = CExtensionDefExplosionEffect.explosionType;
			this.Flags = CExtensionDefExplosionEffect.flags;
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0002F328 File Offset: 0x0002D528
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.explosionName = mb.AddStringPtr(this.ExplosionName);
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.explosionTag = this.ExplosionTag;
			this.MetaStructure.explosionType = this.ExplosionType;
			this.MetaStructure.flags = this.Flags;
			MCExtensionDefExplosionEffect.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefExplosionEffect>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400377C RID: 14204
		public static MetaName _MetaName = MetaName.CExtensionDefExplosionEffect;

		// Token: 0x0400377D RID: 14205
		public MetaFile Meta;

		// Token: 0x0400377E RID: 14206
		public uint Name;

		// Token: 0x0400377F RID: 14207
		public Vector3 OffsetPosition;

		// Token: 0x04003780 RID: 14208
		public Vector4 OffsetRotation;

		// Token: 0x04003781 RID: 14209
		public string ExplosionName = "";

		// Token: 0x04003782 RID: 14210
		public int BoneTag;

		// Token: 0x04003783 RID: 14211
		public int ExplosionTag;

		// Token: 0x04003784 RID: 14212
		public int ExplosionType;

		// Token: 0x04003785 RID: 14213
		public uint Flags;
	}
}
