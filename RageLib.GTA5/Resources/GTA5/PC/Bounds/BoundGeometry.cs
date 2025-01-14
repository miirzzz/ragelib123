using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016E RID: 366
	public class BoundGeometry : Bound
	{
		// Token: 0x1700016C RID: 364
		// (get) Token: 0x060005AC RID: 1452 RVA: 0x000182C1 File Offset: 0x000164C1
		public override long Length
		{
			get
			{
				return 304L;
			}
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x000265DF File Offset: 0x000247DF
		public bool HasVertex(int idx)
		{
			return this.Vertices.Count > idx;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x000265F0 File Offset: 0x000247F0
		public Vector3 GetVector3Vertex(int idx)
		{
			return new Vector3((float)this.Vertices[idx].X, (float)this.Vertices[idx].Y, (float)this.Vertices[idx].Z) * (Vector3)this.Quantum;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x00026648 File Offset: 0x00024848
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h_Pointer = reader.ReadUInt64();
			this.Unknown_80h = reader.ReadUInt32();
			this.VerticesCount1 = reader.ReadUInt32();
			this.PolygonsPointer = reader.ReadUInt64();
			this.Quantum = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Unknown_9Ch = reader.ReadUInt32();
			this.CenterGeometry = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Unknown_ACh = reader.ReadSingle();
			this.VerticesPointer = reader.ReadUInt64();
			this.Unknown_B8h_Pointer = reader.ReadUInt64();
			this.Unknown_C0h_Pointer = reader.ReadUInt64();
			this.Unknown_C8h_Pointer = reader.ReadUInt64();
			this.VerticesCount2 = reader.ReadUInt32();
			this.PolygonsCount = reader.ReadUInt32();
			this.Unknown_D8h = reader.ReadUInt32();
			this.Unknown_DCh = reader.ReadUInt32();
			this.Unknown_E0h = reader.ReadUInt32();
			this.Unknown_E4h = reader.ReadUInt32();
			this.Unknown_E8h = reader.ReadUInt32();
			this.Unknown_ECh = reader.ReadUInt32();
			this.MaterialsPointer = reader.ReadUInt64();
			this.MaterialColoursPointer = reader.ReadUInt64();
			this.Unknown_100h = reader.ReadUInt32();
			this.Unknown_104h = reader.ReadUInt32();
			this.Unknown_108h = reader.ReadUInt32();
			this.Unknown_10Ch = reader.ReadUInt32();
			this.Unknown_110h = reader.ReadUInt32();
			this.Unknown_114h = reader.ReadUInt32();
			this.PolygonMaterialIndicesPointer = reader.ReadUInt64();
			this.MaterialsCount = reader.ReadByte();
			this.MaterialColoursCount = reader.ReadByte();
			this.Unknown_122h = reader.ReadUInt16();
			this.Unknown_124h = reader.ReadUInt32();
			this.Unknown_128h = reader.ReadUInt32();
			this.Unknown_12Ch = reader.ReadUInt32();
			this.Unknown_78h_Data = reader.ReadBlockAt<ResourceSimpleArray<BoundVertex>>(this.Unknown_78h_Pointer, new object[]
			{
				this.VerticesCount2
			});
			this.Polygons = reader.ReadBlockAt<ResourceSimpleArray<BoundPolygon>>(this.PolygonsPointer, new object[]
			{
				this.PolygonsCount
			});
			this.Vertices = reader.ReadBlockAt<ResourceSimpleArray<BoundVertex>>(this.VerticesPointer, new object[]
			{
				this.VerticesCount2
			});
			this.Unknown_B8h_Data = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.Unknown_B8h_Pointer, new object[]
			{
				this.VerticesCount2
			});
			this.Unknown_C0h_Data = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.Unknown_C0h_Pointer, new object[]
			{
				8
			});
			this.Unknown_C8h_Data = reader.ReadBlockAt<ResourceSimpleArrayArray64<uint_r>>(this.Unknown_C8h_Pointer, new object[]
			{
				8,
				this.Unknown_C0h_Data
			});
			this.Materials = reader.ReadBlockAt<ResourceSimpleArray<BoundMaterial>>(this.MaterialsPointer, new object[]
			{
				this.MaterialsCount
			});
			this.MaterialColours = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.MaterialColoursPointer, new object[]
			{
				this.MaterialColoursCount
			});
			this.PolygonMaterialIndices = reader.ReadBlockAt<ResourceSimpleArray<byte_r>>(this.PolygonMaterialIndicesPointer, new object[]
			{
				this.PolygonsCount
			});
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x00026978 File Offset: 0x00024B78
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.Unknown_78h_Pointer = (ulong)((this.Unknown_78h_Data != null) ? this.Unknown_78h_Data.Position : 0L);
			this.VerticesCount1 = (uint)((this.Vertices != null) ? this.Vertices.Count : 0);
			this.PolygonsPointer = (ulong)((this.Polygons != null) ? this.Polygons.Position : 0L);
			this.VerticesPointer = (ulong)((this.Vertices != null) ? this.Vertices.Position : 0L);
			this.Unknown_B8h_Pointer = (ulong)((this.Unknown_B8h_Data != null) ? this.Unknown_B8h_Data.Position : 0L);
			this.Unknown_C0h_Pointer = (ulong)((this.Unknown_C0h_Data != null) ? this.Unknown_C0h_Data.Position : 0L);
			this.Unknown_C8h_Pointer = (ulong)((this.Unknown_C8h_Data != null) ? this.Unknown_C8h_Data.Position : 0L);
			this.VerticesCount2 = (uint)((this.Vertices != null) ? this.Vertices.Count : 0);
			this.PolygonsCount = (uint)((this.Polygons != null) ? this.Polygons.Count : 0);
			this.MaterialsPointer = (ulong)((this.Materials != null) ? this.Materials.Position : 0L);
			this.MaterialColoursPointer = (ulong)((this.MaterialColours != null) ? this.MaterialColours.Position : 0L);
			this.PolygonMaterialIndicesPointer = (ulong)((this.PolygonMaterialIndices != null) ? this.PolygonMaterialIndices.Position : 0L);
			this.MaterialsCount = (byte)((this.Materials != null) ? this.Materials.Count : 0);
			this.MaterialColoursCount = (byte)((this.MaterialColours != null) ? this.MaterialColours.Count : 0);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h_Pointer);
			writer.Write(this.Unknown_80h);
			writer.Write(this.VerticesCount1);
			writer.Write(this.PolygonsPointer);
			writer.WriteBlock(this.Quantum);
			writer.Write(this.Unknown_9Ch);
			writer.WriteBlock(this.CenterGeometry);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.VerticesPointer);
			writer.Write(this.Unknown_B8h_Pointer);
			writer.Write(this.Unknown_C0h_Pointer);
			writer.Write(this.Unknown_C8h_Pointer);
			writer.Write(this.VerticesCount2);
			writer.Write(this.PolygonsCount);
			writer.Write(this.Unknown_D8h);
			writer.Write(this.Unknown_DCh);
			writer.Write(this.Unknown_E0h);
			writer.Write(this.Unknown_E4h);
			writer.Write(this.Unknown_E8h);
			writer.Write(this.Unknown_ECh);
			writer.Write(this.MaterialsPointer);
			writer.Write(this.MaterialColoursPointer);
			writer.Write(this.Unknown_100h);
			writer.Write(this.Unknown_104h);
			writer.Write(this.Unknown_108h);
			writer.Write(this.Unknown_10Ch);
			writer.Write(this.Unknown_110h);
			writer.Write(this.Unknown_114h);
			writer.Write(this.PolygonMaterialIndicesPointer);
			writer.Write(this.MaterialsCount);
			writer.Write(this.MaterialColoursCount);
			writer.Write(this.Unknown_122h);
			writer.Write(this.Unknown_124h);
			writer.Write(this.Unknown_128h);
			writer.Write(this.Unknown_12Ch);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00026CDC File Offset: 0x00024EDC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Unknown_78h_Data != null)
			{
				list.Add(this.Unknown_78h_Data);
			}
			if (this.Polygons != null)
			{
				list.Add(this.Polygons);
			}
			if (this.Vertices != null)
			{
				list.Add(this.Vertices);
			}
			if (this.Unknown_B8h_Data != null)
			{
				list.Add(this.Unknown_B8h_Data);
			}
			if (this.Unknown_C0h_Data != null)
			{
				list.Add(this.Unknown_C0h_Data);
			}
			if (this.Unknown_C8h_Data != null)
			{
				list.Add(this.Unknown_C8h_Data);
			}
			if (this.Materials != null)
			{
				list.Add(this.Materials);
			}
			if (this.MaterialColours != null)
			{
				list.Add(this.MaterialColours);
			}
			if (this.PolygonMaterialIndices != null)
			{
				list.Add(this.PolygonMaterialIndices);
			}
			return list.ToArray();
		}

		// Token: 0x04003659 RID: 13913
		public uint Unknown_70h;

		// Token: 0x0400365A RID: 13914
		public uint Unknown_74h;

		// Token: 0x0400365B RID: 13915
		public ulong Unknown_78h_Pointer;

		// Token: 0x0400365C RID: 13916
		public uint Unknown_80h;

		// Token: 0x0400365D RID: 13917
		public uint VerticesCount1;

		// Token: 0x0400365E RID: 13918
		public ulong PolygonsPointer;

		// Token: 0x0400365F RID: 13919
		public RAGE_Vector3 Quantum;

		// Token: 0x04003660 RID: 13920
		public uint Unknown_9Ch;

		// Token: 0x04003661 RID: 13921
		public RAGE_Vector3 CenterGeometry;

		// Token: 0x04003662 RID: 13922
		public float Unknown_ACh;

		// Token: 0x04003663 RID: 13923
		public ulong VerticesPointer;

		// Token: 0x04003664 RID: 13924
		public ulong Unknown_B8h_Pointer;

		// Token: 0x04003665 RID: 13925
		public ulong Unknown_C0h_Pointer;

		// Token: 0x04003666 RID: 13926
		public ulong Unknown_C8h_Pointer;

		// Token: 0x04003667 RID: 13927
		public uint VerticesCount2;

		// Token: 0x04003668 RID: 13928
		public uint PolygonsCount;

		// Token: 0x04003669 RID: 13929
		public uint Unknown_D8h;

		// Token: 0x0400366A RID: 13930
		public uint Unknown_DCh;

		// Token: 0x0400366B RID: 13931
		public uint Unknown_E0h;

		// Token: 0x0400366C RID: 13932
		public uint Unknown_E4h;

		// Token: 0x0400366D RID: 13933
		public uint Unknown_E8h;

		// Token: 0x0400366E RID: 13934
		public uint Unknown_ECh;

		// Token: 0x0400366F RID: 13935
		public ulong MaterialsPointer;

		// Token: 0x04003670 RID: 13936
		public ulong MaterialColoursPointer;

		// Token: 0x04003671 RID: 13937
		public uint Unknown_100h;

		// Token: 0x04003672 RID: 13938
		public uint Unknown_104h;

		// Token: 0x04003673 RID: 13939
		public uint Unknown_108h;

		// Token: 0x04003674 RID: 13940
		public uint Unknown_10Ch;

		// Token: 0x04003675 RID: 13941
		public uint Unknown_110h;

		// Token: 0x04003676 RID: 13942
		public uint Unknown_114h;

		// Token: 0x04003677 RID: 13943
		public ulong PolygonMaterialIndicesPointer;

		// Token: 0x04003678 RID: 13944
		public byte MaterialsCount;

		// Token: 0x04003679 RID: 13945
		public byte MaterialColoursCount;

		// Token: 0x0400367A RID: 13946
		public ushort Unknown_122h;

		// Token: 0x0400367B RID: 13947
		public uint Unknown_124h;

		// Token: 0x0400367C RID: 13948
		public uint Unknown_128h;

		// Token: 0x0400367D RID: 13949
		public uint Unknown_12Ch;

		// Token: 0x0400367E RID: 13950
		public ResourceSimpleArray<BoundVertex> Unknown_78h_Data;

		// Token: 0x0400367F RID: 13951
		public ResourceSimpleArray<BoundPolygon> Polygons;

		// Token: 0x04003680 RID: 13952
		public ResourceSimpleArray<BoundVertex> Vertices;

		// Token: 0x04003681 RID: 13953
		public ResourceSimpleArray<uint_r> Unknown_B8h_Data;

		// Token: 0x04003682 RID: 13954
		public ResourceSimpleArray<uint_r> Unknown_C0h_Data;

		// Token: 0x04003683 RID: 13955
		public ResourceSimpleArrayArray64<uint_r> Unknown_C8h_Data;

		// Token: 0x04003684 RID: 13956
		public ResourceSimpleArray<BoundMaterial> Materials;

		// Token: 0x04003685 RID: 13957
		public ResourceSimpleArray<uint_r> MaterialColours;

		// Token: 0x04003686 RID: 13958
		public ResourceSimpleArray<byte_r> PolygonMaterialIndices;
	}
}
