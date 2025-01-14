using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000165 RID: 357
	public class Unknown_CL_004 : ResourceSystemBlock
	{
		// Token: 0x17000162 RID: 354
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x000259B8 File Offset: 0x00023BB8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x00025A58 File Offset: 0x00023C58
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x0400360A RID: 13834
		public uint VFT;

		// Token: 0x0400360B RID: 13835
		public uint Unknown_4h;

		// Token: 0x0400360C RID: 13836
		public uint Unknown_8h;

		// Token: 0x0400360D RID: 13837
		public uint Unknown_Ch;

		// Token: 0x0400360E RID: 13838
		public uint Unknown_10h;

		// Token: 0x0400360F RID: 13839
		public uint Unknown_14h;

		// Token: 0x04003610 RID: 13840
		public uint Unknown_18h;

		// Token: 0x04003611 RID: 13841
		public uint Unknown_1Ch;

		// Token: 0x04003612 RID: 13842
		public uint Unknown_20h;

		// Token: 0x04003613 RID: 13843
		public uint Unknown_24h;

		// Token: 0x04003614 RID: 13844
		public uint Unknown_28h;

		// Token: 0x04003615 RID: 13845
		public uint Unknown_2Ch;
	}
}
