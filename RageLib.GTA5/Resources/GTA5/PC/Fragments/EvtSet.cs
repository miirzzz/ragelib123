using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000EF RID: 239
	public class EvtSet : ResourceSystemBlock
	{
		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003D3 RID: 979 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00017CAC File Offset: 0x00015EAC
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

		// Token: 0x060003D5 RID: 981 RVA: 0x00017D4C File Offset: 0x00015F4C
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

		// Token: 0x04002F0C RID: 12044
		public uint VFT;

		// Token: 0x04002F0D RID: 12045
		public uint Unknown_4h;

		// Token: 0x04002F0E RID: 12046
		public uint Unknown_8h;

		// Token: 0x04002F0F RID: 12047
		public uint Unknown_Ch;

		// Token: 0x04002F10 RID: 12048
		public uint Unknown_10h;

		// Token: 0x04002F11 RID: 12049
		public uint Unknown_14h;

		// Token: 0x04002F12 RID: 12050
		public uint Unknown_18h;

		// Token: 0x04002F13 RID: 12051
		public uint Unknown_1Ch;

		// Token: 0x04002F14 RID: 12052
		public uint Unknown_20h;

		// Token: 0x04002F15 RID: 12053
		public uint Unknown_24h;

		// Token: 0x04002F16 RID: 12054
		public uint Unknown_28h;

		// Token: 0x04002F17 RID: 12055
		public uint Unknown_2Ch;
	}
}
