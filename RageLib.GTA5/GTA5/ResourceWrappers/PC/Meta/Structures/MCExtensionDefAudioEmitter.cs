using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A6 RID: 422
	public class MCExtensionDefAudioEmitter : MetaStructureWrapper<CExtensionDefAudioEmitter>
	{
		// Token: 0x060006DE RID: 1758 RVA: 0x0002EE71 File Offset: 0x0002D071
		public MCExtensionDefAudioEmitter()
		{
			this.MetaName = MetaName.CExtensionDefAudioEmitter;
			this.MetaStructure = default(CExtensionDefAudioEmitter);
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0002EE90 File Offset: 0x0002D090
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefAudioEmitter._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefAudioEmitter._MetaName);
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0002EECF File Offset: 0x0002D0CF
		public override void Parse(MetaFile meta, CExtensionDefAudioEmitter CExtensionDefAudioEmitter)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefAudioEmitter;
			this.Name = CExtensionDefAudioEmitter.name;
			this.OffsetPosition = CExtensionDefAudioEmitter.offsetPosition;
			this.OffsetRotation = CExtensionDefAudioEmitter.offsetRotation;
			this.EffectHash = CExtensionDefAudioEmitter.effectHash;
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0002EF10 File Offset: 0x0002D110
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.effectHash = this.EffectHash;
			MCExtensionDefAudioEmitter.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefAudioEmitter>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003768 RID: 14184
		public static MetaName _MetaName = MetaName.CExtensionDefAudioEmitter;

		// Token: 0x04003769 RID: 14185
		public MetaFile Meta;

		// Token: 0x0400376A RID: 14186
		public uint Name;

		// Token: 0x0400376B RID: 14187
		public Vector3 OffsetPosition;

		// Token: 0x0400376C RID: 14188
		public Vector4 OffsetRotation;

		// Token: 0x0400376D RID: 14189
		public uint EffectHash;
	}
}
