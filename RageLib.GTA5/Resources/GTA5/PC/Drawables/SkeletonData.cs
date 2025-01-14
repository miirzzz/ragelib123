using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000112 RID: 274
	public class SkeletonData : ResourceSystemBlock
	{
		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x0001E838 File Offset: 0x0001CA38
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h_Pointer = reader.ReadUInt64();
			this.Count1 = reader.ReadUInt16();
			this.Count2 = reader.ReadUInt16();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.BonesPointer = reader.ReadUInt64();
			this.TransformationsInvertedPointer = reader.ReadUInt64();
			this.TransformationsPointer = reader.ReadUInt64();
			this.ParentIndicesPointer = reader.ReadUInt64();
			this.Unknown_40h_Pointer = reader.ReadUInt64();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.DataCRC = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt16();
			this.BonesCount = reader.ReadUInt16();
			this.Count4 = reader.ReadUInt16();
			this.Unknown_62h = reader.ReadUInt16();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_10h_Data = reader.ReadBlockAt<ResourcePointerArray64<Unknown_D_001>>(this.Unknown_10h_Pointer, new object[]
			{
				this.Count1
			});
			this.Bones = reader.ReadBlockAt<ResourceSimpleArray<Bone>>(this.BonesPointer, new object[]
			{
				this.BonesCount
			});
			this.TransformationsInverted = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Matrix4>>(this.TransformationsInvertedPointer, new object[]
			{
				this.BonesCount
			});
			this.Transformations = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Matrix4>>(this.TransformationsPointer, new object[]
			{
				this.BonesCount
			});
			this.ParentIndices = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.ParentIndicesPointer, new object[]
			{
				this.BonesCount
			});
			this.Unknown_40h_Data = reader.ReadBlockAt<ResourceSimpleArray<ushort_r>>(this.Unknown_40h_Pointer, new object[]
			{
				this.Count4
			});
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x0001EA58 File Offset: 0x0001CC58
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.Unknown_10h_Pointer = (ulong)((this.Unknown_10h_Data != null) ? this.Unknown_10h_Data.Position : 0L);
			ResourcePointerArray64<Unknown_D_001> unknown_10h_Data = this.Unknown_10h_Data;
			this.Count1 = (ushort)((unknown_10h_Data != null) ? unknown_10h_Data.Count : 0);
			if (this.Unknown_10h_Data != null)
			{
				int num = 0;
				foreach (Unknown_D_001 unknown_D_ in this.Unknown_10h_Data.data_items)
				{
					if (unknown_D_ != null)
					{
						Unknown_D_001 unknown_D_2 = unknown_D_;
						for (;;)
						{
							num++;
							if (unknown_D_2.Next == null)
							{
								break;
							}
							unknown_D_2 = unknown_D_2.Next;
						}
					}
				}
				this.Count2 = (ushort)num;
			}
			else
			{
				this.Count2 = 0;
			}
			this.BonesPointer = (ulong)((this.Bones != null) ? this.Bones.Position : 0L);
			this.TransformationsInvertedPointer = (ulong)((this.TransformationsInverted != null) ? this.TransformationsInverted.Position : 0L);
			this.TransformationsPointer = (ulong)((this.Transformations != null) ? this.Transformations.Position : 0L);
			this.ParentIndicesPointer = (ulong)((this.ParentIndices != null) ? this.ParentIndices.Position : 0L);
			this.Unknown_40h_Pointer = (ulong)((this.Unknown_40h_Data != null) ? this.Unknown_40h_Data.Position : 0L);
			ResourceSimpleArray<Bone> bones = this.Bones;
			this.BonesCount = (ushort)((bones != null) ? bones.Count : 0);
			this.Count4 = (ushort)((this.Unknown_40h_Data != null) ? this.Unknown_40h_Data.Count : 0);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h_Pointer);
			writer.Write(this.Count1);
			writer.Write(this.Count2);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.BonesPointer);
			writer.Write(this.TransformationsInvertedPointer);
			writer.Write(this.TransformationsPointer);
			writer.Write(this.ParentIndicesPointer);
			writer.Write(this.Unknown_40h_Pointer);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.DataCRC);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.BonesCount);
			writer.Write(this.Count4);
			writer.Write(this.Unknown_62h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0001ED08 File Offset: 0x0001CF08
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Unknown_10h_Data != null)
			{
				list.Add(this.Unknown_10h_Data);
			}
			if (this.Bones != null)
			{
				list.Add(this.Bones);
			}
			if (this.TransformationsInverted != null)
			{
				list.Add(this.TransformationsInverted);
			}
			if (this.Transformations != null)
			{
				list.Add(this.Transformations);
			}
			if (this.ParentIndices != null)
			{
				list.Add(this.ParentIndices);
			}
			if (this.Unknown_40h_Data != null)
			{
				list.Add(this.Unknown_40h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x04003261 RID: 12897
		public uint VFT;

		// Token: 0x04003262 RID: 12898
		public uint Unknown_4h;

		// Token: 0x04003263 RID: 12899
		public uint Unknown_8h;

		// Token: 0x04003264 RID: 12900
		public uint Unknown_Ch;

		// Token: 0x04003265 RID: 12901
		public ulong Unknown_10h_Pointer;

		// Token: 0x04003266 RID: 12902
		public ushort Count1;

		// Token: 0x04003267 RID: 12903
		public ushort Count2;

		// Token: 0x04003268 RID: 12904
		public uint Unknown_1Ch;

		// Token: 0x04003269 RID: 12905
		public ulong BonesPointer;

		// Token: 0x0400326A RID: 12906
		public ulong TransformationsInvertedPointer;

		// Token: 0x0400326B RID: 12907
		public ulong TransformationsPointer;

		// Token: 0x0400326C RID: 12908
		public ulong ParentIndicesPointer;

		// Token: 0x0400326D RID: 12909
		public ulong Unknown_40h_Pointer;

		// Token: 0x0400326E RID: 12910
		public uint Unknown_48h;

		// Token: 0x0400326F RID: 12911
		public uint Unknown_4Ch;

		// Token: 0x04003270 RID: 12912
		public uint Unknown_50h;

		// Token: 0x04003271 RID: 12913
		public uint Unknown_54h;

		// Token: 0x04003272 RID: 12914
		public uint DataCRC;

		// Token: 0x04003273 RID: 12915
		public ushort Unknown_5Ch;

		// Token: 0x04003274 RID: 12916
		public ushort BonesCount;

		// Token: 0x04003275 RID: 12917
		public ushort Count4;

		// Token: 0x04003276 RID: 12918
		public ushort Unknown_62h;

		// Token: 0x04003277 RID: 12919
		public uint Unknown_64h;

		// Token: 0x04003278 RID: 12920
		public uint Unknown_68h;

		// Token: 0x04003279 RID: 12921
		public uint Unknown_6Ch;

		// Token: 0x0400327A RID: 12922
		public ResourcePointerArray64<Unknown_D_001> Unknown_10h_Data;

		// Token: 0x0400327B RID: 12923
		public ResourceSimpleArray<Bone> Bones;

		// Token: 0x0400327C RID: 12924
		public ResourceSimpleArray<RAGE_Matrix4> TransformationsInverted;

		// Token: 0x0400327D RID: 12925
		public ResourceSimpleArray<RAGE_Matrix4> Transformations;

		// Token: 0x0400327E RID: 12926
		public ResourceSimpleArray<ushort_r> ParentIndices;

		// Token: 0x0400327F RID: 12927
		public ResourceSimpleArray<ushort_r> Unknown_40h_Data;
	}
}
