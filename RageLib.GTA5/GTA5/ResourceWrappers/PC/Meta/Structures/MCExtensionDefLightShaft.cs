using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AD RID: 429
	public class MCExtensionDefLightShaft : MetaStructureWrapper<CExtensionDefLightShaft>
	{
		// Token: 0x06000701 RID: 1793 RVA: 0x0002F8F6 File Offset: 0x0002DAF6
		public MCExtensionDefLightShaft()
		{
			this.MetaName = MetaName.CExtensionDefLightShaft;
			this.MetaStructure = default(CExtensionDefLightShaft);
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x0002F918 File Offset: 0x0002DB18
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefLightShaft._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefLightShaft._MetaName);
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x0002F958 File Offset: 0x0002DB58
		public override void Parse(MetaFile meta, CExtensionDefLightShaft CExtensionDefLightShaft)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefLightShaft;
			this.Name = CExtensionDefLightShaft.name;
			this.OffsetPosition = CExtensionDefLightShaft.offsetPosition;
			this.CornerA = CExtensionDefLightShaft.cornerA;
			this.CornerB = CExtensionDefLightShaft.cornerB;
			this.CornerC = CExtensionDefLightShaft.cornerC;
			this.CornerD = CExtensionDefLightShaft.cornerD;
			this.Direction = CExtensionDefLightShaft.direction;
			this.DirectionAmount = CExtensionDefLightShaft.directionAmount;
			this.Length = CExtensionDefLightShaft.length;
			this.Unk_1616789093 = CExtensionDefLightShaft.Unk_1616789093;
			this.Unk_120454521 = CExtensionDefLightShaft.Unk_120454521;
			this.Unk_1297365553 = CExtensionDefLightShaft.Unk_1297365553;
			this.Unk_75548206 = CExtensionDefLightShaft.Unk_75548206;
			this.Unk_40301253 = CExtensionDefLightShaft.Unk_40301253;
			this.Unk_475013030 = CExtensionDefLightShaft.Unk_475013030;
			this.Color = CExtensionDefLightShaft.color;
			this.Intensity = CExtensionDefLightShaft.intensity;
			this.Flashiness = CExtensionDefLightShaft.flashiness;
			this.Flags = CExtensionDefLightShaft.flags;
			this.DensityType = CExtensionDefLightShaft.densityType;
			this.VolumeType = CExtensionDefLightShaft.volumeType;
			this.Softness = CExtensionDefLightShaft.softness;
			this.Unk_59101696 = CExtensionDefLightShaft.Unk_59101696;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x0002FA88 File Offset: 0x0002DC88
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.cornerA = this.CornerA;
			this.MetaStructure.cornerB = this.CornerB;
			this.MetaStructure.cornerC = this.CornerC;
			this.MetaStructure.cornerD = this.CornerD;
			this.MetaStructure.direction = this.Direction;
			this.MetaStructure.directionAmount = this.DirectionAmount;
			this.MetaStructure.length = this.Length;
			this.MetaStructure.Unk_1616789093 = this.Unk_1616789093;
			this.MetaStructure.Unk_120454521 = this.Unk_120454521;
			this.MetaStructure.Unk_1297365553 = this.Unk_1297365553;
			this.MetaStructure.Unk_75548206 = this.Unk_75548206;
			this.MetaStructure.Unk_40301253 = this.Unk_40301253;
			this.MetaStructure.Unk_475013030 = this.Unk_475013030;
			this.MetaStructure.color = this.Color;
			this.MetaStructure.intensity = this.Intensity;
			this.MetaStructure.flashiness = this.Flashiness;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.densityType = this.DensityType;
			this.MetaStructure.volumeType = this.VolumeType;
			this.MetaStructure.softness = this.Softness;
			this.MetaStructure.Unk_59101696 = this.Unk_59101696;
			MCExtensionDefLightShaft.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefLightShaft>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400379E RID: 14238
		public static MetaName _MetaName = MetaName.CExtensionDefLightShaft;

		// Token: 0x0400379F RID: 14239
		public MetaFile Meta;

		// Token: 0x040037A0 RID: 14240
		public uint Name;

		// Token: 0x040037A1 RID: 14241
		public Vector3 OffsetPosition;

		// Token: 0x040037A2 RID: 14242
		public Vector3 CornerA;

		// Token: 0x040037A3 RID: 14243
		public Vector3 CornerB;

		// Token: 0x040037A4 RID: 14244
		public Vector3 CornerC;

		// Token: 0x040037A5 RID: 14245
		public Vector3 CornerD;

		// Token: 0x040037A6 RID: 14246
		public Vector3 Direction;

		// Token: 0x040037A7 RID: 14247
		public float DirectionAmount;

		// Token: 0x040037A8 RID: 14248
		public float Length;

		// Token: 0x040037A9 RID: 14249
		public float Unk_1616789093;

		// Token: 0x040037AA RID: 14250
		public float Unk_120454521;

		// Token: 0x040037AB RID: 14251
		public float Unk_1297365553;

		// Token: 0x040037AC RID: 14252
		public float Unk_75548206;

		// Token: 0x040037AD RID: 14253
		public float Unk_40301253;

		// Token: 0x040037AE RID: 14254
		public float Unk_475013030;

		// Token: 0x040037AF RID: 14255
		public uint Color;

		// Token: 0x040037B0 RID: 14256
		public float Intensity;

		// Token: 0x040037B1 RID: 14257
		public byte Flashiness;

		// Token: 0x040037B2 RID: 14258
		public uint Flags;

		// Token: 0x040037B3 RID: 14259
		public Unk_1931949281 DensityType;

		// Token: 0x040037B4 RID: 14260
		public Unk_2266515059 VolumeType;

		// Token: 0x040037B5 RID: 14261
		public float Softness;

		// Token: 0x040037B6 RID: 14262
		public byte Unk_59101696;
	}
}
