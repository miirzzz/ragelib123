using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Nodes
{
	// Token: 0x02000053 RID: 83
	public class NodesFile : FileBase64_GTA5_pc
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000B18C File Offset: 0x0000938C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.NodesPointer = reader.ReadUInt64();
			this.NodesCount = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h_Pointer = reader.ReadUInt64();
			this.DataPointer1Length = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h_Pointer = reader.ReadUInt64();
			this.Unknown_40h_Pointer = reader.ReadUInt64();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h_Pointer = reader.ReadUInt64();
			this.cnt5a = reader.ReadUInt16();
			this.cnt5b = reader.ReadUInt16();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.len4 = reader.ReadUInt32();
			this.len5 = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Nodes = reader.ReadBlockAt<ResourceSimpleArray<Node>>(this.NodesPointer, new object[]
			{
				this.NodesCount
			});
			this.Unknown_28h_Data = reader.ReadBlockAt<ResourceSimpleArray<Unknown_ND_002>>(this.Unknown_28h_Pointer, new object[]
			{
				this.DataPointer1Length
			});
			this.Unknown_38h_Data = reader.ReadBlockAt<ResourceSimpleArray<Unknown_ND_003>>(this.Unknown_38h_Pointer, new object[]
			{
				this.len4
			});
			this.Unknown_40h_Data = reader.ReadBlockAt<ResourceSimpleArray<byte_r>>(this.Unknown_40h_Pointer, new object[]
			{
				this.len5
			});
			this.Unknown_50h_Data = reader.ReadBlockAt<ResourceSimpleArray<Unknown_ND_004>>(this.Unknown_50h_Pointer, new object[]
			{
				this.cnt5b
			});
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000B350 File Offset: 0x00009550
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.NodesPointer = (ulong)((this.Nodes != null) ? this.Nodes.Position : 0L);
			this.NodesCount = (uint)((this.Nodes != null) ? this.Nodes.Count : 0);
			this.Unknown_28h_Pointer = (ulong)((this.Unknown_28h_Data != null) ? this.Unknown_28h_Data.Position : 0L);
			this.DataPointer1Length = (uint)((this.Unknown_28h_Data != null) ? this.Unknown_28h_Data.Count : 0);
			this.Unknown_38h_Pointer = (ulong)((this.Unknown_38h_Data != null) ? this.Unknown_38h_Data.Position : 0L);
			this.Unknown_40h_Pointer = (ulong)((this.Unknown_40h_Data != null) ? this.Unknown_40h_Data.Position : 0L);
			this.Unknown_50h_Pointer = (ulong)((this.Unknown_50h_Data != null) ? this.Unknown_50h_Data.Position : 0L);
			this.cnt5a = (ushort)((this.Unknown_50h_Data != null) ? this.Unknown_50h_Data.Count : 0);
			this.cnt5b = (ushort)((this.Unknown_50h_Data != null) ? this.Unknown_50h_Data.Count : 0);
			this.len4 = (uint)((this.Unknown_38h_Data != null) ? this.Unknown_38h_Data.Count : 0);
			this.len5 = (uint)((this.Unknown_40h_Data != null) ? this.Unknown_40h_Data.Count : 0);
			writer.Write(this.NodesPointer);
			writer.Write(this.NodesCount);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h_Pointer);
			writer.Write(this.DataPointer1Length);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h_Pointer);
			writer.Write(this.Unknown_40h_Pointer);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h_Pointer);
			writer.Write(this.cnt5a);
			writer.Write(this.cnt5b);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.len4);
			writer.Write(this.len5);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000B590 File Offset: 0x00009790
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Nodes != null)
			{
				list.Add(this.Nodes);
			}
			if (this.Unknown_28h_Data != null)
			{
				list.Add(this.Unknown_28h_Data);
			}
			if (this.Unknown_38h_Data != null)
			{
				list.Add(this.Unknown_38h_Data);
			}
			if (this.Unknown_40h_Data != null)
			{
				list.Add(this.Unknown_40h_Data);
			}
			if (this.Unknown_50h_Data != null)
			{
				list.Add(this.Unknown_50h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x040003FE RID: 1022
		public ulong NodesPointer;

		// Token: 0x040003FF RID: 1023
		public uint NodesCount;

		// Token: 0x04000400 RID: 1024
		public uint Unknown_1Ch;

		// Token: 0x04000401 RID: 1025
		public uint Unknown_20h;

		// Token: 0x04000402 RID: 1026
		public uint Unknown_24h;

		// Token: 0x04000403 RID: 1027
		public ulong Unknown_28h_Pointer;

		// Token: 0x04000404 RID: 1028
		public uint DataPointer1Length;

		// Token: 0x04000405 RID: 1029
		public uint Unknown_34h;

		// Token: 0x04000406 RID: 1030
		public ulong Unknown_38h_Pointer;

		// Token: 0x04000407 RID: 1031
		public ulong Unknown_40h_Pointer;

		// Token: 0x04000408 RID: 1032
		public uint Unknown_48h;

		// Token: 0x04000409 RID: 1033
		public uint Unknown_4Ch;

		// Token: 0x0400040A RID: 1034
		public ulong Unknown_50h_Pointer;

		// Token: 0x0400040B RID: 1035
		public ushort cnt5a;

		// Token: 0x0400040C RID: 1036
		public ushort cnt5b;

		// Token: 0x0400040D RID: 1037
		public uint Unknown_5Ch;

		// Token: 0x0400040E RID: 1038
		public uint len4;

		// Token: 0x0400040F RID: 1039
		public uint len5;

		// Token: 0x04000410 RID: 1040
		public uint Unknown_68h;

		// Token: 0x04000411 RID: 1041
		public uint Unknown_6Ch;

		// Token: 0x04000412 RID: 1042
		public ResourceSimpleArray<Node> Nodes;

		// Token: 0x04000413 RID: 1043
		public ResourceSimpleArray<Unknown_ND_002> Unknown_28h_Data;

		// Token: 0x04000414 RID: 1044
		public ResourceSimpleArray<Unknown_ND_003> Unknown_38h_Data;

		// Token: 0x04000415 RID: 1045
		public ResourceSimpleArray<byte_r> Unknown_40h_Data;

		// Token: 0x04000416 RID: 1046
		public ResourceSimpleArray<Unknown_ND_004> Unknown_50h_Data;
	}
}
