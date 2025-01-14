using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A5 RID: 421
	public class MCExtensionDefAudioCollisionSettings : MetaStructureWrapper<CExtensionDefAudioCollisionSettings>
	{
		// Token: 0x060006D9 RID: 1753 RVA: 0x0002ED64 File Offset: 0x0002CF64
		public MCExtensionDefAudioCollisionSettings()
		{
			this.MetaName = MetaName.CExtensionDefAudioCollisionSettings;
			this.MetaStructure = default(CExtensionDefAudioCollisionSettings);
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0002ED84 File Offset: 0x0002CF84
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefAudioCollisionSettings._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefAudioCollisionSettings._MetaName);
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0002EDC3 File Offset: 0x0002CFC3
		public override void Parse(MetaFile meta, CExtensionDefAudioCollisionSettings CExtensionDefAudioCollisionSettings)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefAudioCollisionSettings;
			this.Name = CExtensionDefAudioCollisionSettings.name;
			this.OffsetPosition = CExtensionDefAudioCollisionSettings.offsetPosition;
			this.Settings = CExtensionDefAudioCollisionSettings.settings;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0002EDF8 File Offset: 0x0002CFF8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.settings = this.Settings;
			MCExtensionDefAudioCollisionSettings.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefAudioCollisionSettings>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003763 RID: 14179
		public static MetaName _MetaName = MetaName.CExtensionDefAudioCollisionSettings;

		// Token: 0x04003764 RID: 14180
		public MetaFile Meta;

		// Token: 0x04003765 RID: 14181
		public uint Name;

		// Token: 0x04003766 RID: 14182
		public Vector3 OffsetPosition;

		// Token: 0x04003767 RID: 14183
		public uint Settings;
	}
}
