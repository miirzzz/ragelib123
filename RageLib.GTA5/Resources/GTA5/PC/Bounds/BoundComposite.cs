using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016A RID: 362
	public class BoundComposite : Bound
	{
		// Token: 0x17000168 RID: 360
		// (get) Token: 0x0600059A RID: 1434 RVA: 0x00017799 File Offset: 0x00015999
		public override long Length
		{
			get
			{
				return 176L;
			}
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x00026040 File Offset: 0x00024240
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.ChildrenPointer = reader.ReadUInt64();
			this.ChildTransformations1Pointer = reader.ReadUInt64();
			this.ChildTransformations2Pointer = reader.ReadUInt64();
			this.ChildBoundingBoxesPointer = reader.ReadUInt64();
			this.ChildFlags1Pointer = reader.ReadUInt64();
			this.ChildFlags2Pointer = reader.ReadUInt64();
			this.ChildrenCount1 = reader.ReadUInt16();
			this.ChildrenCount2 = reader.ReadUInt16();
			this.Unknown_A4h = reader.ReadUInt32();
			this.BVHPointer = reader.ReadUInt64();
			this.Children = reader.ReadBlockAt<ResourcePointerArray64<Bound>>(this.ChildrenPointer, new object[]
			{
				this.ChildrenCount1
			});
			this.ChildTransformations1 = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Matrix4>>(this.ChildTransformations1Pointer, new object[]
			{
				this.ChildrenCount1
			});
			this.ChildTransformations2 = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Matrix4>>(this.ChildTransformations2Pointer, new object[]
			{
				this.ChildrenCount1
			});
			this.ChildBoundingBoxes = reader.ReadBlockAt<ResourceSimpleArray<RAGE_AABB>>(this.ChildBoundingBoxesPointer, new object[]
			{
				this.ChildrenCount1
			});
			this.ChildFlags1 = reader.ReadBlockAt<ResourceSimpleArray<ulong_r>>(this.ChildFlags1Pointer, new object[]
			{
				this.ChildrenCount1
			});
			this.ChildFlags2 = reader.ReadBlockAt<ResourceSimpleArray<ulong_r>>(this.ChildFlags2Pointer, new object[]
			{
				this.ChildrenCount1
			});
			this.BVH = reader.ReadBlockAt<BVH>(this.BVHPointer, Array.Empty<object>());
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x000261C8 File Offset: 0x000243C8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.ChildrenPointer = (ulong)((this.Children != null) ? this.Children.Position : 0L);
			this.ChildTransformations1Pointer = (ulong)((this.ChildTransformations1 != null) ? this.ChildTransformations1.Position : 0L);
			this.ChildTransformations2Pointer = (ulong)((this.ChildTransformations2 != null) ? this.ChildTransformations2.Position : 0L);
			this.ChildBoundingBoxesPointer = (ulong)((this.ChildBoundingBoxes != null) ? this.ChildBoundingBoxes.Position : 0L);
			this.ChildFlags1Pointer = (ulong)((this.ChildFlags1 != null) ? this.ChildFlags1.Position : 0L);
			this.ChildFlags2Pointer = (ulong)((this.ChildFlags2 != null) ? this.ChildFlags2.Position : 0L);
			this.ChildrenCount1 = (ushort)((this.Children != null) ? this.Children.Count : 0);
			this.ChildrenCount2 = (ushort)((this.Children != null) ? this.Children.Count : 0);
			this.BVHPointer = (ulong)((this.BVH != null) ? this.BVH.Position : 0L);
			writer.Write(this.ChildrenPointer);
			writer.Write(this.ChildTransformations1Pointer);
			writer.Write(this.ChildTransformations2Pointer);
			writer.Write(this.ChildBoundingBoxesPointer);
			writer.Write(this.ChildFlags1Pointer);
			writer.Write(this.ChildFlags2Pointer);
			writer.Write(this.ChildrenCount1);
			writer.Write(this.ChildrenCount2);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.BVHPointer);
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0002635C File Offset: 0x0002455C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Children != null)
			{
				list.Add(this.Children);
			}
			if (this.ChildTransformations1 != null)
			{
				list.Add(this.ChildTransformations1);
			}
			if (this.ChildTransformations2 != null)
			{
				list.Add(this.ChildTransformations2);
			}
			if (this.ChildBoundingBoxes != null)
			{
				list.Add(this.ChildBoundingBoxes);
			}
			if (this.ChildFlags1 != null)
			{
				list.Add(this.ChildFlags1);
			}
			if (this.ChildFlags2 != null)
			{
				list.Add(this.ChildFlags2);
			}
			if (this.BVH != null)
			{
				list.Add(this.BVH);
			}
			return list.ToArray();
		}

		// Token: 0x0400363A RID: 13882
		public ulong ChildrenPointer;

		// Token: 0x0400363B RID: 13883
		public ulong ChildTransformations1Pointer;

		// Token: 0x0400363C RID: 13884
		public ulong ChildTransformations2Pointer;

		// Token: 0x0400363D RID: 13885
		public ulong ChildBoundingBoxesPointer;

		// Token: 0x0400363E RID: 13886
		public ulong ChildFlags1Pointer;

		// Token: 0x0400363F RID: 13887
		public ulong ChildFlags2Pointer;

		// Token: 0x04003640 RID: 13888
		public ushort ChildrenCount1;

		// Token: 0x04003641 RID: 13889
		public ushort ChildrenCount2;

		// Token: 0x04003642 RID: 13890
		public uint Unknown_A4h;

		// Token: 0x04003643 RID: 13891
		public ulong BVHPointer;

		// Token: 0x04003644 RID: 13892
		public ResourcePointerArray64<Bound> Children;

		// Token: 0x04003645 RID: 13893
		public ResourceSimpleArray<RAGE_Matrix4> ChildTransformations1;

		// Token: 0x04003646 RID: 13894
		public ResourceSimpleArray<RAGE_Matrix4> ChildTransformations2;

		// Token: 0x04003647 RID: 13895
		public ResourceSimpleArray<RAGE_AABB> ChildBoundingBoxes;

		// Token: 0x04003648 RID: 13896
		public ResourceSimpleArray<ulong_r> ChildFlags1;

		// Token: 0x04003649 RID: 13897
		public ResourceSimpleArray<ulong_r> ChildFlags2;

		// Token: 0x0400364A RID: 13898
		public BVH BVH;
	}
}
