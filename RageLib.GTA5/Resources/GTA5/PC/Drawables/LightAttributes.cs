using System;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010D RID: 269
	public class LightAttributes : ResourceSystemBlock
	{
		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0001BC55 File Offset: 0x00019E55
		public override long Length
		{
			get
			{
				return 168L;
			}
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x0001D970 File Offset: 0x0001BB70
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.PositionX = reader.ReadSingle();
			this.PositionY = reader.ReadSingle();
			this.PositionZ = reader.ReadSingle();
			this.Unknown_14h = reader.ReadUInt32();
			this.ColorR = reader.ReadByte();
			this.ColorG = reader.ReadByte();
			this.ColorB = reader.ReadByte();
			this.Flashiness = reader.ReadByte();
			this.Intensity = reader.ReadSingle();
			this.Flags = reader.ReadUInt32();
			this.BoneId = reader.ReadUInt16();
			this.Type = reader.ReadByte();
			this.GroupId = reader.ReadByte();
			this.TimeFlags = reader.ReadUInt32();
			this.Falloff = reader.ReadSingle();
			this.FalloffExponent = reader.ReadSingle();
			this.CullingPlaneNormalX = reader.ReadSingle();
			this.CullingPlaneNormalY = reader.ReadSingle();
			this.CullingPlaneNormalZ = reader.ReadSingle();
			this.CullingPlaneOffset = reader.ReadSingle();
			this.ShadowBlur = reader.ReadByte();
			this.Unknown_45h = reader.ReadByte();
			this.Unknown_46h = reader.ReadUInt16();
			this.Unknown_48h = reader.ReadUInt32();
			this.VolumeIntensity = reader.ReadSingle();
			this.VolumeSizeScale = reader.ReadSingle();
			this.VolumeOuterColorR = reader.ReadByte();
			this.VolumeOuterColorG = reader.ReadByte();
			this.VolumeOuterColorB = reader.ReadByte();
			this.LightHash = reader.ReadByte();
			this.VolumeOuterIntensity = reader.ReadSingle();
			this.CoronaSize = reader.ReadSingle();
			this.VolumeOuterExponent = reader.ReadSingle();
			this.LightFadeDistance = reader.ReadByte();
			this.ShadowFadeDistance = reader.ReadByte();
			this.SpecularFadeDistance = reader.ReadByte();
			this.VolumetricFadeDistance = reader.ReadByte();
			this.ShadowNearClip = reader.ReadSingle();
			this.CoronaIntensity = reader.ReadSingle();
			this.CoronaZBias = reader.ReadSingle();
			this.DirectionX = reader.ReadSingle();
			this.DirectionY = reader.ReadSingle();
			this.DirectionZ = reader.ReadSingle();
			this.TangentX = reader.ReadSingle();
			this.TangentY = reader.ReadSingle();
			this.TangentZ = reader.ReadSingle();
			this.ConeInnerAngle = reader.ReadSingle();
			this.ConeOuterAngle = reader.ReadSingle();
			this.ExtentX = reader.ReadSingle();
			this.ExtentY = reader.ReadSingle();
			this.ExtentZ = reader.ReadSingle();
			this.ProjectedTextureHash = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001DC14 File Offset: 0x0001BE14
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.PositionX);
			writer.Write(this.PositionY);
			writer.Write(this.PositionZ);
			writer.Write(this.Unknown_14h);
			writer.Write(this.ColorR);
			writer.Write(this.ColorG);
			writer.Write(this.ColorB);
			writer.Write(this.Flashiness);
			writer.Write(this.Intensity);
			writer.Write(this.Flags);
			writer.Write(this.BoneId);
			writer.Write(this.Type);
			writer.Write(this.GroupId);
			writer.Write(this.TimeFlags);
			writer.Write(this.Falloff);
			writer.Write(this.FalloffExponent);
			writer.Write(this.CullingPlaneNormalX);
			writer.Write(this.CullingPlaneNormalY);
			writer.Write(this.CullingPlaneNormalZ);
			writer.Write(this.CullingPlaneOffset);
			writer.Write(this.ShadowBlur);
			writer.Write(this.Unknown_45h);
			writer.Write(this.Unknown_46h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.VolumeIntensity);
			writer.Write(this.VolumeSizeScale);
			writer.Write(this.VolumeOuterColorR);
			writer.Write(this.VolumeOuterColorG);
			writer.Write(this.VolumeOuterColorB);
			writer.Write(this.LightHash);
			writer.Write(this.VolumeOuterIntensity);
			writer.Write(this.CoronaSize);
			writer.Write(this.VolumeOuterExponent);
			writer.Write(this.LightFadeDistance);
			writer.Write(this.ShadowFadeDistance);
			writer.Write(this.SpecularFadeDistance);
			writer.Write(this.VolumetricFadeDistance);
			writer.Write(this.ShadowNearClip);
			writer.Write(this.CoronaIntensity);
			writer.Write(this.CoronaZBias);
			writer.Write(this.DirectionX);
			writer.Write(this.DirectionY);
			writer.Write(this.DirectionZ);
			writer.Write(this.TangentX);
			writer.Write(this.TangentY);
			writer.Write(this.TangentZ);
			writer.Write(this.ConeInnerAngle);
			writer.Write(this.ConeOuterAngle);
			writer.Write(this.ExtentX);
			writer.Write(this.ExtentY);
			writer.Write(this.ExtentZ);
			writer.Write(this.ProjectedTextureHash);
			writer.Write(this.Unknown_A4h);
		}

		// Token: 0x04003201 RID: 12801
		public uint Unknown_0h;

		// Token: 0x04003202 RID: 12802
		public uint Unknown_4h;

		// Token: 0x04003203 RID: 12803
		public float PositionX;

		// Token: 0x04003204 RID: 12804
		public float PositionY;

		// Token: 0x04003205 RID: 12805
		public float PositionZ;

		// Token: 0x04003206 RID: 12806
		public uint Unknown_14h;

		// Token: 0x04003207 RID: 12807
		public byte ColorR;

		// Token: 0x04003208 RID: 12808
		public byte ColorG;

		// Token: 0x04003209 RID: 12809
		public byte ColorB;

		// Token: 0x0400320A RID: 12810
		public byte Flashiness;

		// Token: 0x0400320B RID: 12811
		public float Intensity;

		// Token: 0x0400320C RID: 12812
		public uint Flags;

		// Token: 0x0400320D RID: 12813
		public ushort BoneId;

		// Token: 0x0400320E RID: 12814
		public byte Type;

		// Token: 0x0400320F RID: 12815
		public byte GroupId;

		// Token: 0x04003210 RID: 12816
		public uint TimeFlags;

		// Token: 0x04003211 RID: 12817
		public float Falloff;

		// Token: 0x04003212 RID: 12818
		public float FalloffExponent;

		// Token: 0x04003213 RID: 12819
		public float CullingPlaneNormalX;

		// Token: 0x04003214 RID: 12820
		public float CullingPlaneNormalY;

		// Token: 0x04003215 RID: 12821
		public float CullingPlaneNormalZ;

		// Token: 0x04003216 RID: 12822
		public float CullingPlaneOffset;

		// Token: 0x04003217 RID: 12823
		public byte ShadowBlur;

		// Token: 0x04003218 RID: 12824
		public byte Unknown_45h;

		// Token: 0x04003219 RID: 12825
		public ushort Unknown_46h;

		// Token: 0x0400321A RID: 12826
		public uint Unknown_48h;

		// Token: 0x0400321B RID: 12827
		public float VolumeIntensity;

		// Token: 0x0400321C RID: 12828
		public float VolumeSizeScale;

		// Token: 0x0400321D RID: 12829
		public byte VolumeOuterColorR;

		// Token: 0x0400321E RID: 12830
		public byte VolumeOuterColorG;

		// Token: 0x0400321F RID: 12831
		public byte VolumeOuterColorB;

		// Token: 0x04003220 RID: 12832
		public byte LightHash;

		// Token: 0x04003221 RID: 12833
		public float VolumeOuterIntensity;

		// Token: 0x04003222 RID: 12834
		public float CoronaSize;

		// Token: 0x04003223 RID: 12835
		public float VolumeOuterExponent;

		// Token: 0x04003224 RID: 12836
		public byte LightFadeDistance;

		// Token: 0x04003225 RID: 12837
		public byte ShadowFadeDistance;

		// Token: 0x04003226 RID: 12838
		public byte SpecularFadeDistance;

		// Token: 0x04003227 RID: 12839
		public byte VolumetricFadeDistance;

		// Token: 0x04003228 RID: 12840
		public float ShadowNearClip;

		// Token: 0x04003229 RID: 12841
		public float CoronaIntensity;

		// Token: 0x0400322A RID: 12842
		public float CoronaZBias;

		// Token: 0x0400322B RID: 12843
		public float DirectionX;

		// Token: 0x0400322C RID: 12844
		public float DirectionY;

		// Token: 0x0400322D RID: 12845
		public float DirectionZ;

		// Token: 0x0400322E RID: 12846
		public float TangentX;

		// Token: 0x0400322F RID: 12847
		public float TangentY;

		// Token: 0x04003230 RID: 12848
		public float TangentZ;

		// Token: 0x04003231 RID: 12849
		public float ConeInnerAngle;

		// Token: 0x04003232 RID: 12850
		public float ConeOuterAngle;

		// Token: 0x04003233 RID: 12851
		public float ExtentX;

		// Token: 0x04003234 RID: 12852
		public float ExtentY;

		// Token: 0x04003235 RID: 12853
		public float ExtentZ;

		// Token: 0x04003236 RID: 12854
		public uint ProjectedTextureHash;

		// Token: 0x04003237 RID: 12855
		public uint Unknown_A4h;
	}
}
