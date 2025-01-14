using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000103 RID: 259
	public class Drawable : FileBase64_GTA5_pc
	{
		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0001BC55 File Offset: 0x00019E55
		public override long Length
		{
			get
			{
				return 168L;
			}
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x0001BC60 File Offset: 0x00019E60
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.ShaderGroupPointer = reader.ReadUInt64();
			this.SkeletonPointer = reader.ReadUInt64();
			this.BoundingCenter = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.BoundingSphereRadius = reader.ReadSingle();
			this.BoundingBoxMin = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.BoundingBoxMax = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.DrawableModelsHighPointer = reader.ReadUInt64();
			this.DrawableModelsMediumPointer = reader.ReadUInt64();
			this.DrawableModelsLowPointer = reader.ReadUInt64();
			this.DrawableModelsVeryLowPointer = reader.ReadUInt64();
			this.LodGroupHigh = reader.ReadSingle();
			this.LodGroupMed = reader.ReadSingle();
			this.LodGroupLow = reader.ReadSingle();
			this.LodGroupVlow = reader.ReadSingle();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.JointsPointer = reader.ReadUInt64();
			this.Unknown_98h = reader.ReadUInt16();
			this.Unknown_9Ah = reader.ReadUInt16();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.DrawableModelsXPointer = reader.ReadUInt64();
			this.ShaderGroup = reader.ReadBlockAt<ShaderGroup>(this.ShaderGroupPointer, Array.Empty<object>());
			this.Skeleton = reader.ReadBlockAt<SkeletonData>(this.SkeletonPointer, Array.Empty<object>());
			this.DrawableModelsHigh = reader.ReadBlockAt<ResourcePointerList64<DrawableModel>>(this.DrawableModelsHighPointer, Array.Empty<object>());
			this.DrawableModelsMedium = reader.ReadBlockAt<ResourcePointerList64<DrawableModel>>(this.DrawableModelsMediumPointer, Array.Empty<object>());
			this.DrawableModelsLow = reader.ReadBlockAt<ResourcePointerList64<DrawableModel>>(this.DrawableModelsLowPointer, Array.Empty<object>());
			this.DrawableModelsVeryLow = reader.ReadBlockAt<ResourcePointerList64<DrawableModel>>(this.DrawableModelsVeryLowPointer, Array.Empty<object>());
			this.Joints = reader.ReadBlockAt<Joints>(this.JointsPointer, Array.Empty<object>());
			this.DrawableModelsX = reader.ReadBlockAt<ResourcePointerList64<DrawableModel>>(this.DrawableModelsXPointer, Array.Empty<object>());
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x0001BE50 File Offset: 0x0001A050
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.ShaderGroupPointer = (ulong)((this.ShaderGroup != null) ? this.ShaderGroup.Position : 0L);
			this.SkeletonPointer = (ulong)((this.Skeleton != null) ? this.Skeleton.Position : 0L);
			this.DrawableModelsHighPointer = (ulong)((this.DrawableModelsHigh != null) ? this.DrawableModelsHigh.Position : 0L);
			this.DrawableModelsMediumPointer = (ulong)((this.DrawableModelsMedium != null) ? this.DrawableModelsMedium.Position : 0L);
			this.DrawableModelsLowPointer = (ulong)((this.DrawableModelsLow != null) ? this.DrawableModelsLow.Position : 0L);
			this.DrawableModelsVeryLowPointer = (ulong)((this.DrawableModelsVeryLow != null) ? this.DrawableModelsVeryLow.Position : 0L);
			this.JointsPointer = (ulong)((this.Joints != null) ? this.Joints.Position : 0L);
			this.DrawableModelsXPointer = (ulong)((this.DrawableModelsX != null) ? this.DrawableModelsX.Position : 0L);
			writer.Write(this.ShaderGroupPointer);
			writer.Write(this.SkeletonPointer);
			writer.WriteBlock(this.BoundingCenter);
			writer.Write(this.BoundingSphereRadius);
			writer.WriteBlock(this.BoundingBoxMin);
			writer.WriteBlock(this.BoundingBoxMax);
			writer.Write(this.DrawableModelsHighPointer);
			writer.Write(this.DrawableModelsMediumPointer);
			writer.Write(this.DrawableModelsLowPointer);
			writer.Write(this.DrawableModelsVeryLowPointer);
			writer.Write(this.LodGroupHigh);
			writer.Write(this.LodGroupMed);
			writer.Write(this.LodGroupLow);
			writer.Write(this.LodGroupVlow);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.JointsPointer);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ah);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.DrawableModelsXPointer);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001C064 File Offset: 0x0001A264
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.ShaderGroup != null)
			{
				list.Add(this.ShaderGroup);
			}
			if (this.Skeleton != null)
			{
				list.Add(this.Skeleton);
			}
			if (this.DrawableModelsHigh != null)
			{
				list.Add(this.DrawableModelsHigh);
			}
			if (this.DrawableModelsMedium != null)
			{
				list.Add(this.DrawableModelsMedium);
			}
			if (this.DrawableModelsLow != null)
			{
				list.Add(this.DrawableModelsLow);
			}
			if (this.DrawableModelsVeryLow != null)
			{
				list.Add(this.DrawableModelsVeryLow);
			}
			if (this.Joints != null)
			{
				list.Add(this.Joints);
			}
			if (this.DrawableModelsX != null)
			{
				list.Add(this.DrawableModelsX);
			}
			return list.ToArray();
		}

		// Token: 0x04003126 RID: 12582
		public ulong ShaderGroupPointer;

		// Token: 0x04003127 RID: 12583
		public ulong SkeletonPointer;

		// Token: 0x04003128 RID: 12584
		public RAGE_Vector3 BoundingCenter;

		// Token: 0x04003129 RID: 12585
		public float BoundingSphereRadius;

		// Token: 0x0400312A RID: 12586
		public RAGE_Vector4 BoundingBoxMin;

		// Token: 0x0400312B RID: 12587
		public RAGE_Vector4 BoundingBoxMax;

		// Token: 0x0400312C RID: 12588
		public ulong DrawableModelsHighPointer;

		// Token: 0x0400312D RID: 12589
		public ulong DrawableModelsMediumPointer;

		// Token: 0x0400312E RID: 12590
		public ulong DrawableModelsLowPointer;

		// Token: 0x0400312F RID: 12591
		public ulong DrawableModelsVeryLowPointer;

		// Token: 0x04003130 RID: 12592
		public float LodGroupHigh;

		// Token: 0x04003131 RID: 12593
		public float LodGroupMed;

		// Token: 0x04003132 RID: 12594
		public float LodGroupLow;

		// Token: 0x04003133 RID: 12595
		public float LodGroupVlow;

		// Token: 0x04003134 RID: 12596
		public uint Unknown_80h;

		// Token: 0x04003135 RID: 12597
		public uint Unknown_84h;

		// Token: 0x04003136 RID: 12598
		public uint Unknown_88h;

		// Token: 0x04003137 RID: 12599
		public uint Unknown_8Ch;

		// Token: 0x04003138 RID: 12600
		public ulong JointsPointer;

		// Token: 0x04003139 RID: 12601
		public ushort Unknown_98h;

		// Token: 0x0400313A RID: 12602
		public ushort Unknown_9Ah;

		// Token: 0x0400313B RID: 12603
		public uint Unknown_9Ch;

		// Token: 0x0400313C RID: 12604
		public ulong DrawableModelsXPointer;

		// Token: 0x0400313D RID: 12605
		public ShaderGroup ShaderGroup;

		// Token: 0x0400313E RID: 12606
		public SkeletonData Skeleton;

		// Token: 0x0400313F RID: 12607
		public ResourcePointerList64<DrawableModel> DrawableModelsHigh;

		// Token: 0x04003140 RID: 12608
		public ResourcePointerList64<DrawableModel> DrawableModelsMedium;

		// Token: 0x04003141 RID: 12609
		public ResourcePointerList64<DrawableModel> DrawableModelsLow;

		// Token: 0x04003142 RID: 12610
		public ResourcePointerList64<DrawableModel> DrawableModelsVeryLow;

		// Token: 0x04003143 RID: 12611
		public Joints Joints;

		// Token: 0x04003144 RID: 12612
		public ResourcePointerList64<DrawableModel> DrawableModelsX;
	}
}
