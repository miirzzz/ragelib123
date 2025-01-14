using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000162 RID: 354
	public class Sequence : ResourceSystemBlock
	{
		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000575 RID: 1397 RVA: 0x00025629 File Offset: 0x00023829
		public override long Length
		{
			get
			{
				return (long)(32 + this.Data.Length);
			}
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00025638 File Offset: 0x00023838
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.DataLength = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt16();
			this.Unknown_1Eh = reader.ReadUInt16();
			this.Data = reader.ReadBytes((int)this.DataLength);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x000256C4 File Offset: 0x000238C4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.DataLength);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_1Eh);
			writer.Write(this.Data);
		}

		// Token: 0x040035F3 RID: 13811
		public uint Unknown_0h;

		// Token: 0x040035F4 RID: 13812
		public uint DataLength;

		// Token: 0x040035F5 RID: 13813
		public uint Unknown_8h;

		// Token: 0x040035F6 RID: 13814
		public uint Unknown_Ch;

		// Token: 0x040035F7 RID: 13815
		public uint Unknown_10h;

		// Token: 0x040035F8 RID: 13816
		public uint Unknown_14h;

		// Token: 0x040035F9 RID: 13817
		public uint Unknown_18h;

		// Token: 0x040035FA RID: 13818
		public ushort Unknown_1Ch;

		// Token: 0x040035FB RID: 13819
		public ushort Unknown_1Eh;

		// Token: 0x040035FC RID: 13820
		public byte[] Data;
	}
}
