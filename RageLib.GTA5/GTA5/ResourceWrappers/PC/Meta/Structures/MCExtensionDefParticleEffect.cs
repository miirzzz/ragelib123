using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AE RID: 430
	public class MCExtensionDefParticleEffect : MetaStructureWrapper<CExtensionDefParticleEffect>
	{
		// Token: 0x06000706 RID: 1798 RVA: 0x0002FC55 File Offset: 0x0002DE55
		public MCExtensionDefParticleEffect()
		{
			this.MetaName = MetaName.CExtensionDefParticleEffect;
			this.MetaStructure = default(CExtensionDefParticleEffect);
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0002FC80 File Offset: 0x0002DE80
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefParticleEffect._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefParticleEffect._MetaName);
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0002FCC0 File Offset: 0x0002DEC0
		public override void Parse(MetaFile meta, CExtensionDefParticleEffect CExtensionDefParticleEffect)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefParticleEffect;
			this.Name = CExtensionDefParticleEffect.name;
			this.OffsetPosition = CExtensionDefParticleEffect.offsetPosition;
			this.OffsetRotation = CExtensionDefParticleEffect.offsetRotation;
			this.FxName = MetaUtils.GetString(this.Meta, CExtensionDefParticleEffect.fxName);
			this.FxType = CExtensionDefParticleEffect.fxType;
			this.BoneTag = CExtensionDefParticleEffect.boneTag;
			this.Scale = CExtensionDefParticleEffect.scale;
			this.Probability = CExtensionDefParticleEffect.probability;
			this.Flags = CExtensionDefParticleEffect.flags;
			this.Color = CExtensionDefParticleEffect.color;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x0002FD60 File Offset: 0x0002DF60
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.fxName = mb.AddStringPtr(this.FxName);
			this.MetaStructure.fxType = this.FxType;
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.scale = this.Scale;
			this.MetaStructure.probability = this.Probability;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.color = this.Color;
			MCExtensionDefParticleEffect.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefParticleEffect>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037B7 RID: 14263
		public static MetaName _MetaName = MetaName.CExtensionDefParticleEffect;

		// Token: 0x040037B8 RID: 14264
		public MetaFile Meta;

		// Token: 0x040037B9 RID: 14265
		public uint Name;

		// Token: 0x040037BA RID: 14266
		public Vector3 OffsetPosition;

		// Token: 0x040037BB RID: 14267
		public Vector4 OffsetRotation;

		// Token: 0x040037BC RID: 14268
		public string FxName = "";

		// Token: 0x040037BD RID: 14269
		public int FxType;

		// Token: 0x040037BE RID: 14270
		public int BoneTag;

		// Token: 0x040037BF RID: 14271
		public float Scale;

		// Token: 0x040037C0 RID: 14272
		public int Probability;

		// Token: 0x040037C1 RID: 14273
		public int Flags;

		// Token: 0x040037C2 RID: 14274
		public uint Color;
	}
}
