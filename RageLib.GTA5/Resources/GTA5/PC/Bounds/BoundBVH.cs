using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000168 RID: 360
	public class BoundBVH : BoundGeometry
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x00017DE9 File Offset: 0x00015FE9
		public override long Length
		{
			get
			{
				return 336L;
			}
		}

		// Token: 0x06000592 RID: 1426 RVA: 0x00025E70 File Offset: 0x00024070
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.BvhPointer = reader.ReadUInt64();
			this.Unknown_138h = reader.ReadUInt32();
			this.Unknown_13Ch = reader.ReadUInt32();
			this.Unknown_140h = reader.ReadUInt16();
			this.Unknown_142h = reader.ReadUInt16();
			this.Unknown_144h = reader.ReadUInt32();
			this.Unknown_148h = reader.ReadUInt32();
			this.Unknown_14Ch = reader.ReadUInt32();
			this.BVH = reader.ReadBlockAt<BVH>(this.BvhPointer, Array.Empty<object>());
		}

		// Token: 0x06000593 RID: 1427 RVA: 0x00025EFC File Offset: 0x000240FC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.BvhPointer = (ulong)((this.BVH != null) ? this.BVH.Position : 0L);
			writer.Write(this.BvhPointer);
			writer.Write(this.Unknown_138h);
			writer.Write(this.Unknown_13Ch);
			writer.Write(this.Unknown_140h);
			writer.Write(this.Unknown_142h);
			writer.Write(this.Unknown_144h);
			writer.Write(this.Unknown_148h);
			writer.Write(this.Unknown_14Ch);
		}

		// Token: 0x06000594 RID: 1428 RVA: 0x00025F90 File Offset: 0x00024190
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.BVH != null)
			{
				list.Add(this.BVH);
			}
			return list.ToArray();
		}

		// Token: 0x0400362D RID: 13869
		public ulong BvhPointer;

		// Token: 0x0400362E RID: 13870
		public uint Unknown_138h;

		// Token: 0x0400362F RID: 13871
		public uint Unknown_13Ch;

		// Token: 0x04003630 RID: 13872
		public ushort Unknown_140h;

		// Token: 0x04003631 RID: 13873
		public ushort Unknown_142h;

		// Token: 0x04003632 RID: 13874
		public uint Unknown_144h;

		// Token: 0x04003633 RID: 13875
		public uint Unknown_148h;

		// Token: 0x04003634 RID: 13876
		public uint Unknown_14Ch;

		// Token: 0x04003635 RID: 13877
		public BVH BVH;
	}
}
