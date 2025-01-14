using System;

namespace RageLib.Resources.GTA5.PC.Nodes
{
	// Token: 0x02000052 RID: 82
	public class Node : ResourceSystemBlock
	{
		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001BD RID: 445 RVA: 0x0000B05E File Offset: 0x0000925E
		public override long Length
		{
			get
			{
				return 40L;
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000B064 File Offset: 0x00009264
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt16();
			this.Unknown_12h = reader.ReadUInt16();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000B0F8 File Offset: 0x000092F8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_12h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
		}

		// Token: 0x040003F3 RID: 1011
		public uint Unknown_0h;

		// Token: 0x040003F4 RID: 1012
		public uint Unknown_4h;

		// Token: 0x040003F5 RID: 1013
		public uint Unknown_8h;

		// Token: 0x040003F6 RID: 1014
		public uint Unknown_Ch;

		// Token: 0x040003F7 RID: 1015
		public ushort Unknown_10h;

		// Token: 0x040003F8 RID: 1016
		public ushort Unknown_12h;

		// Token: 0x040003F9 RID: 1017
		public uint Unknown_14h;

		// Token: 0x040003FA RID: 1018
		public uint Unknown_18h;

		// Token: 0x040003FB RID: 1019
		public uint Unknown_1Ch;

		// Token: 0x040003FC RID: 1020
		public uint Unknown_20h;

		// Token: 0x040003FD RID: 1021
		public uint Unknown_24h;
	}
}
