using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200017B RID: 379
	public class BVH : ResourceSystemBlock
	{
		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060005E1 RID: 1505 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000274A0 File Offset: 0x000256A0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.NodesPointer = reader.ReadUInt64();
			this.NodesCount = reader.ReadUInt32();
			this.NodesCapacity = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.BoundingBoxMin = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.BoundingBoxMax = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.BoundingBoxCenter = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.QuantumInverse = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.Quantum = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.TreesPointer = reader.ReadUInt64();
			this.TreesCount1 = reader.ReadUInt16();
			this.TreesCount2 = reader.ReadUInt16();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Nodes = reader.ReadBlockAt<ResourceSimpleArray<BVHNode>>(this.NodesPointer, new object[]
			{
				this.NodesCount
			});
			this.Trees = reader.ReadBlockAt<ResourceSimpleArray<BVHTreeInfo>>(this.TreesPointer, new object[]
			{
				this.TreesCount1
			});
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000275D4 File Offset: 0x000257D4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NodesPointer = (ulong)((this.Nodes != null) ? this.Nodes.Position : 0L);
			this.NodesCount = (uint)((this.Nodes != null) ? this.Nodes.Count : 0);
			this.NodesCapacity = (uint)((this.Nodes != null) ? this.Nodes.Count : 0);
			this.TreesPointer = (ulong)((this.Trees != null) ? this.Trees.Position : 0L);
			this.TreesCount1 = (ushort)((this.Trees != null) ? this.Trees.Count : 0);
			this.TreesCount2 = (ushort)((this.Trees != null) ? this.Trees.Count : 0);
			writer.Write(this.NodesPointer);
			writer.Write(this.NodesCount);
			writer.Write(this.NodesCapacity);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.BoundingBoxMin);
			writer.WriteBlock(this.BoundingBoxMax);
			writer.WriteBlock(this.BoundingBoxCenter);
			writer.WriteBlock(this.QuantumInverse);
			writer.WriteBlock(this.Quantum);
			writer.Write(this.TreesPointer);
			writer.Write(this.TreesCount1);
			writer.Write(this.TreesCount2);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x00027750 File Offset: 0x00025950
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Nodes != null)
			{
				list.Add(this.Nodes);
			}
			if (this.Trees != null)
			{
				list.Add(this.Trees);
			}
			return list.ToArray();
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x00027794 File Offset: 0x00025994
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.BoundingBoxMin),
				new Tuple<long, IResourceBlock>(48L, this.BoundingBoxMax),
				new Tuple<long, IResourceBlock>(64L, this.BoundingBoxCenter),
				new Tuple<long, IResourceBlock>(80L, this.QuantumInverse),
				new Tuple<long, IResourceBlock>(96L, this.Quantum)
			};
		}

		// Token: 0x040036B8 RID: 14008
		public ulong NodesPointer;

		// Token: 0x040036B9 RID: 14009
		public uint NodesCount;

		// Token: 0x040036BA RID: 14010
		public uint NodesCapacity;

		// Token: 0x040036BB RID: 14011
		public uint Unknown_10h;

		// Token: 0x040036BC RID: 14012
		public uint Unknown_14h;

		// Token: 0x040036BD RID: 14013
		public uint Unknown_18h;

		// Token: 0x040036BE RID: 14014
		public uint Unknown_1Ch;

		// Token: 0x040036BF RID: 14015
		public RAGE_Vector4 BoundingBoxMin;

		// Token: 0x040036C0 RID: 14016
		public RAGE_Vector4 BoundingBoxMax;

		// Token: 0x040036C1 RID: 14017
		public RAGE_Vector4 BoundingBoxCenter;

		// Token: 0x040036C2 RID: 14018
		public RAGE_Vector4 QuantumInverse;

		// Token: 0x040036C3 RID: 14019
		public RAGE_Vector4 Quantum;

		// Token: 0x040036C4 RID: 14020
		public ulong TreesPointer;

		// Token: 0x040036C5 RID: 14021
		public ushort TreesCount1;

		// Token: 0x040036C6 RID: 14022
		public ushort TreesCount2;

		// Token: 0x040036C7 RID: 14023
		public uint Unknown_7Ch;

		// Token: 0x040036C8 RID: 14024
		public ResourceSimpleArray<BVHNode> Nodes;

		// Token: 0x040036C9 RID: 14025
		public ResourceSimpleArray<BVHTreeInfo> Trees;
	}
}
