using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000106 RID: 262
	public class DrawableModel : ResourceSystemBlock
	{
		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0001C745 File Offset: 0x0001A945
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x0001C74D File Offset: 0x0001A94D
		public uint VFT { get; set; }

		// Token: 0x06000445 RID: 1093 RVA: 0x0001C758 File Offset: 0x0001A958
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.GeometriesPointer = reader.ReadUInt64();
			this.GeometriesCount1 = reader.ReadUInt16();
			this.GeometriesCount2 = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt32();
			this.BoundsPointer = reader.ReadUInt64();
			this.ShaderMappingPointer = reader.ReadUInt64();
			this.SkeletonBinding = reader.ReadUInt32();
			this.RenderMaskFlags = reader.ReadUInt16();
			this.GeometriesCount3 = reader.ReadUInt16();
			this.Geometries = reader.ReadBlockAt<ResourcePointerArray64<DrawableGeometry>>(this.GeometriesPointer, new object[]
			{
				this.GeometriesCount1
			});
			this.BoundsData = reader.ReadBlockAt<ResourceSimpleArray<RAGE_AABB>>(this.BoundsPointer, new object[]
			{
				(int)((this.GeometriesCount1 > 1) ? (this.GeometriesCount1 + 1) : this.GeometriesCount1)
			});
			this.ShaderMapping = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.ShaderMappingPointer, new object[]
			{
				this.GeometriesCount1
			});
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x0001C870 File Offset: 0x0001AA70
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.GeometriesPointer = (ulong)((this.Geometries != null) ? this.Geometries.Position : 0L);
			this.GeometriesCount1 = (ushort)((this.Geometries != null) ? this.Geometries.Count : 0);
			this.GeometriesCount2 = this.GeometriesCount1;
			this.GeometriesCount3 = this.GeometriesCount1;
			this.BoundsPointer = (ulong)((this.BoundsData != null) ? this.BoundsData.Position : 0L);
			this.ShaderMappingPointer = (ulong)((this.ShaderMapping != null) ? this.ShaderMapping.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.GeometriesPointer);
			writer.Write(this.GeometriesCount1);
			writer.Write(this.GeometriesCount2);
			writer.Write(this.Unknown_14h);
			writer.Write(this.BoundsPointer);
			writer.Write(this.ShaderMappingPointer);
			writer.Write(this.SkeletonBinding);
			writer.Write(this.RenderMaskFlags);
			writer.Write(this.GeometriesCount3);
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001C990 File Offset: 0x0001AB90
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Geometries != null)
			{
				list.Add(this.Geometries);
			}
			if (this.BoundsData != null)
			{
				list.Add(this.BoundsData);
			}
			if (this.ShaderMapping != null)
			{
				list.Add(this.ShaderMapping);
			}
			return list.ToArray();
		}

		// Token: 0x04003174 RID: 12660
		public uint Unknown_4h;

		// Token: 0x04003175 RID: 12661
		public ulong GeometriesPointer;

		// Token: 0x04003176 RID: 12662
		public ushort GeometriesCount1;

		// Token: 0x04003177 RID: 12663
		public ushort GeometriesCount2;

		// Token: 0x04003178 RID: 12664
		public uint Unknown_14h;

		// Token: 0x04003179 RID: 12665
		public ulong BoundsPointer;

		// Token: 0x0400317A RID: 12666
		public ulong ShaderMappingPointer;

		// Token: 0x0400317B RID: 12667
		public uint SkeletonBinding;

		// Token: 0x0400317C RID: 12668
		public ushort RenderMaskFlags;

		// Token: 0x0400317D RID: 12669
		public ushort GeometriesCount3;

		// Token: 0x0400317E RID: 12670
		public ResourcePointerArray64<DrawableGeometry> Geometries;

		// Token: 0x0400317F RID: 12671
		public ResourceSimpleArray<RAGE_AABB> BoundsData;

		// Token: 0x04003180 RID: 12672
		public ResourceSimpleArray<ushort_r> ShaderMapping;
	}
}
