using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200017C RID: 380
	public class BVHNode : ResourceSystemBlock
	{
		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060005E7 RID: 1511 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x000277FC File Offset: 0x000259FC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.MinX = reader.ReadUInt16();
			this.MinY = reader.ReadUInt16();
			this.MinZ = reader.ReadUInt16();
			this.MaxX = reader.ReadUInt16();
			this.MaxY = reader.ReadUInt16();
			this.MaxZ = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt16();
			this.Unknown_Eh = reader.ReadUInt16();
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0002786C File Offset: 0x00025A6C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.MinX);
			writer.Write(this.MinY);
			writer.Write(this.MinZ);
			writer.Write(this.MaxX);
			writer.Write(this.MaxY);
			writer.Write(this.MaxZ);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_Eh);
		}

		// Token: 0x040036CA RID: 14026
		public ushort MinX;

		// Token: 0x040036CB RID: 14027
		public ushort MinY;

		// Token: 0x040036CC RID: 14028
		public ushort MinZ;

		// Token: 0x040036CD RID: 14029
		public ushort MaxX;

		// Token: 0x040036CE RID: 14030
		public ushort MaxY;

		// Token: 0x040036CF RID: 14031
		public ushort MaxZ;

		// Token: 0x040036D0 RID: 14032
		public ushort Unknown_Ch;

		// Token: 0x040036D1 RID: 14033
		public ushort Unknown_Eh;
	}
}
