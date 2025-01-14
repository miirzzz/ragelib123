using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F1 RID: 241
	public class fragNameStruct : ResourceSystemBlock
	{
		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000181E4 File Offset: 0x000163E4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00018254 File Offset: 0x00016454
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x04002F35 RID: 12085
		public uint Unknown_0h;

		// Token: 0x04002F36 RID: 12086
		public uint Unknown_4h;

		// Token: 0x04002F37 RID: 12087
		public uint Unknown_8h;

		// Token: 0x04002F38 RID: 12088
		public uint Unknown_Ch;

		// Token: 0x04002F39 RID: 12089
		public uint Unknown_10h;

		// Token: 0x04002F3A RID: 12090
		public uint Unknown_14h;

		// Token: 0x04002F3B RID: 12091
		public uint Unknown_18h;

		// Token: 0x04002F3C RID: 12092
		public uint Unknown_1Ch;
	}
}
