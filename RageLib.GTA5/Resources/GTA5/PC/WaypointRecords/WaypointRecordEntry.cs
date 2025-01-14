using System;

namespace RageLib.Resources.GTA5.PC.WaypointRecords
{
	// Token: 0x02000012 RID: 18
	public class WaypointRecordEntry : ResourceSystemBlock
	{
		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00002875 File Offset: 0x00000A75
		public override long Length
		{
			get
			{
				return 20L;
			}
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00003C78 File Offset: 0x00001E78
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.PositionX = reader.ReadSingle();
			this.PositionY = reader.ReadSingle();
			this.PositionZ = reader.ReadSingle();
			this.Unknown_Ch = reader.ReadUInt16();
			this.Unknown_Eh = reader.ReadUInt16();
			this.Unknown_10h = reader.ReadUInt16();
			this.Unknown_12h = reader.ReadUInt16();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003CDC File Offset: 0x00001EDC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.PositionX);
			writer.Write(this.PositionY);
			writer.Write(this.PositionZ);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_Eh);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_12h);
		}

		// Token: 0x04000067 RID: 103
		public float PositionX;

		// Token: 0x04000068 RID: 104
		public float PositionY;

		// Token: 0x04000069 RID: 105
		public float PositionZ;

		// Token: 0x0400006A RID: 106
		public ushort Unknown_Ch;

		// Token: 0x0400006B RID: 107
		public ushort Unknown_Eh;

		// Token: 0x0400006C RID: 108
		public ushort Unknown_10h;

		// Token: 0x0400006D RID: 109
		public ushort Unknown_12h;
	}
}
