using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B3 RID: 435
	public class MCLightAttrDef : MetaStructureWrapper<CLightAttrDef>
	{
		// Token: 0x0600071F RID: 1823 RVA: 0x0003070A File Offset: 0x0002E90A
		public MCLightAttrDef()
		{
			this.MetaName = MetaName.CLightAttrDef;
			this.MetaStructure = default(CLightAttrDef);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0003072C File Offset: 0x0002E92C
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCLightAttrDef._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCLightAttrDef._MetaName);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x0003076C File Offset: 0x0002E96C
		public override void Parse(MetaFile meta, CLightAttrDef CLightAttrDef)
		{
			this.Meta = meta;
			this.MetaStructure = CLightAttrDef;
			this.Posn = CLightAttrDef.posn;
			this.Colour = CLightAttrDef.colour;
			this.Flashiness = CLightAttrDef.flashiness;
			this.Intensity = CLightAttrDef.intensity;
			this.Flags = CLightAttrDef.flags;
			this.BoneTag = CLightAttrDef.boneTag;
			this.LightType = CLightAttrDef.lightType;
			this.GroupId = CLightAttrDef.groupId;
			this.TimeFlags = CLightAttrDef.timeFlags;
			this.Falloff = CLightAttrDef.falloff;
			this.FalloffExponent = CLightAttrDef.falloffExponent;
			this.CullingPlane = CLightAttrDef.cullingPlane;
			this.ShadowBlur = CLightAttrDef.shadowBlur;
			this.Padding1 = CLightAttrDef.padding1;
			this.Padding2 = CLightAttrDef.padding2;
			this.Padding3 = CLightAttrDef.padding3;
			this.VolIntensity = CLightAttrDef.volIntensity;
			this.VolSizeScale = CLightAttrDef.volSizeScale;
			this.VolOuterColour = CLightAttrDef.volOuterColour;
			this.LightHash = CLightAttrDef.lightHash;
			this.VolOuterIntensity = CLightAttrDef.volOuterIntensity;
			this.CoronaSize = CLightAttrDef.coronaSize;
			this.VolOuterExponent = CLightAttrDef.volOuterExponent;
			this.LightFadeDistance = CLightAttrDef.lightFadeDistance;
			this.ShadowFadeDistance = CLightAttrDef.shadowFadeDistance;
			this.SpecularFadeDistance = CLightAttrDef.specularFadeDistance;
			this.VolumetricFadeDistance = CLightAttrDef.volumetricFadeDistance;
			this.ShadowNearClip = CLightAttrDef.shadowNearClip;
			this.CoronaIntensity = CLightAttrDef.coronaIntensity;
			this.CoronaZBias = CLightAttrDef.coronaZBias;
			this.Direction = CLightAttrDef.direction;
			this.Tangent = CLightAttrDef.tangent;
			this.ConeInnerAngle = CLightAttrDef.coneInnerAngle;
			this.ConeOuterAngle = CLightAttrDef.coneOuterAngle;
			this.Extents = CLightAttrDef.extents;
			this.ProjectedTextureKey = CLightAttrDef.projectedTextureKey;
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00030938 File Offset: 0x0002EB38
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.posn = this.Posn;
			this.MetaStructure.colour = this.Colour;
			this.MetaStructure.flashiness = this.Flashiness;
			this.MetaStructure.intensity = this.Intensity;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.boneTag = this.BoneTag;
			this.MetaStructure.lightType = this.LightType;
			this.MetaStructure.groupId = this.GroupId;
			this.MetaStructure.timeFlags = this.TimeFlags;
			this.MetaStructure.falloff = this.Falloff;
			this.MetaStructure.falloffExponent = this.FalloffExponent;
			this.MetaStructure.cullingPlane = this.CullingPlane;
			this.MetaStructure.shadowBlur = this.ShadowBlur;
			this.MetaStructure.padding1 = this.Padding1;
			this.MetaStructure.padding2 = this.Padding2;
			this.MetaStructure.padding3 = this.Padding3;
			this.MetaStructure.volIntensity = this.VolIntensity;
			this.MetaStructure.volSizeScale = this.VolSizeScale;
			this.MetaStructure.volOuterColour = this.VolOuterColour;
			this.MetaStructure.lightHash = this.LightHash;
			this.MetaStructure.volOuterIntensity = this.VolOuterIntensity;
			this.MetaStructure.coronaSize = this.CoronaSize;
			this.MetaStructure.volOuterExponent = this.VolOuterExponent;
			this.MetaStructure.lightFadeDistance = this.LightFadeDistance;
			this.MetaStructure.shadowFadeDistance = this.ShadowFadeDistance;
			this.MetaStructure.specularFadeDistance = this.SpecularFadeDistance;
			this.MetaStructure.volumetricFadeDistance = this.VolumetricFadeDistance;
			this.MetaStructure.shadowNearClip = this.ShadowNearClip;
			this.MetaStructure.coronaIntensity = this.CoronaIntensity;
			this.MetaStructure.coronaZBias = this.CoronaZBias;
			this.MetaStructure.direction = this.Direction;
			this.MetaStructure.tangent = this.Tangent;
			this.MetaStructure.coneInnerAngle = this.ConeInnerAngle;
			this.MetaStructure.coneOuterAngle = this.ConeOuterAngle;
			this.MetaStructure.extents = this.Extents;
			this.MetaStructure.projectedTextureKey = this.ProjectedTextureKey;
			MCLightAttrDef.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CLightAttrDef>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037FD RID: 14333
		public static MetaName _MetaName = MetaName.CLightAttrDef;

		// Token: 0x040037FE RID: 14334
		public MetaFile Meta;

		// Token: 0x040037FF RID: 14335
		public Vector3 Posn;

		// Token: 0x04003800 RID: 14336
		public ArrayOfBytes3 Colour;

		// Token: 0x04003801 RID: 14337
		public byte Flashiness;

		// Token: 0x04003802 RID: 14338
		public float Intensity;

		// Token: 0x04003803 RID: 14339
		public uint Flags;

		// Token: 0x04003804 RID: 14340
		public short BoneTag;

		// Token: 0x04003805 RID: 14341
		public byte LightType;

		// Token: 0x04003806 RID: 14342
		public byte GroupId;

		// Token: 0x04003807 RID: 14343
		public uint TimeFlags;

		// Token: 0x04003808 RID: 14344
		public float Falloff;

		// Token: 0x04003809 RID: 14345
		public float FalloffExponent;

		// Token: 0x0400380A RID: 14346
		public Vector4 CullingPlane;

		// Token: 0x0400380B RID: 14347
		public byte ShadowBlur;

		// Token: 0x0400380C RID: 14348
		public byte Padding1;

		// Token: 0x0400380D RID: 14349
		public short Padding2;

		// Token: 0x0400380E RID: 14350
		public uint Padding3;

		// Token: 0x0400380F RID: 14351
		public float VolIntensity;

		// Token: 0x04003810 RID: 14352
		public float VolSizeScale;

		// Token: 0x04003811 RID: 14353
		public ArrayOfBytes3 VolOuterColour;

		// Token: 0x04003812 RID: 14354
		public byte LightHash;

		// Token: 0x04003813 RID: 14355
		public float VolOuterIntensity;

		// Token: 0x04003814 RID: 14356
		public float CoronaSize;

		// Token: 0x04003815 RID: 14357
		public float VolOuterExponent;

		// Token: 0x04003816 RID: 14358
		public byte LightFadeDistance;

		// Token: 0x04003817 RID: 14359
		public byte ShadowFadeDistance;

		// Token: 0x04003818 RID: 14360
		public byte SpecularFadeDistance;

		// Token: 0x04003819 RID: 14361
		public byte VolumetricFadeDistance;

		// Token: 0x0400381A RID: 14362
		public float ShadowNearClip;

		// Token: 0x0400381B RID: 14363
		public float CoronaIntensity;

		// Token: 0x0400381C RID: 14364
		public float CoronaZBias;

		// Token: 0x0400381D RID: 14365
		public Vector3 Direction;

		// Token: 0x0400381E RID: 14366
		public Vector3 Tangent;

		// Token: 0x0400381F RID: 14367
		public float ConeInnerAngle;

		// Token: 0x04003820 RID: 14368
		public float ConeOuterAngle;

		// Token: 0x04003821 RID: 14369
		public Vector3 Extents;

		// Token: 0x04003822 RID: 14370
		public uint ProjectedTextureKey;
	}
}
