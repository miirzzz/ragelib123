using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200017D RID: 381
	public class BVHTreeInfo : ResourceSystemBlock
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060005EB RID: 1515 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x000278DC File Offset: 0x00025ADC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.MinX = reader.ReadUInt16();
			this.MinY = reader.ReadUInt16();
			this.MinZ = reader.ReadUInt16();
			this.MaxX = reader.ReadUInt16();
			this.MaxY = reader.ReadUInt16();
			this.MaxZ = reader.ReadUInt16();
			this.NodeIndex1 = reader.ReadUInt16();
			this.NodeIndex2 = reader.ReadUInt16();
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0002794C File Offset: 0x00025B4C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.MinX);
			writer.Write(this.MinY);
			writer.Write(this.MinZ);
			writer.Write(this.MaxX);
			writer.Write(this.MaxY);
			writer.Write(this.MaxZ);
			writer.Write(this.NodeIndex1);
			writer.Write(this.NodeIndex2);
		}

		// Token: 0x040036D2 RID: 14034
		public ushort MinX;

		// Token: 0x040036D3 RID: 14035
		public ushort MinY;

		// Token: 0x040036D4 RID: 14036
		public ushort MinZ;

		// Token: 0x040036D5 RID: 14037
		public ushort MaxX;

		// Token: 0x040036D6 RID: 14038
		public ushort MaxY;

		// Token: 0x040036D7 RID: 14039
		public ushort MaxZ;

		// Token: 0x040036D8 RID: 14040
		public ushort NodeIndex1;

		// Token: 0x040036D9 RID: 14041
		public ushort NodeIndex2;
	}
}
