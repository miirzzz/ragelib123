using System;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010C RID: 268
	public class JointTranslationLimit : ResourceSystemBlock
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000462 RID: 1122 RVA: 0x0001D828 File Offset: 0x0001BA28
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.BoneId = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Min = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Max = reader.ReadBlock<RAGE_Vector3>(Array.Empty<object>());
			this.Unknown_3Ch = reader.ReadUInt32();
		}

		// Token: 0x06000463 RID: 1123 RVA: 0x0001D8D0 File Offset: 0x0001BAD0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.BoneId);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Min);
			writer.Write(this.Unknown_2Ch);
			writer.WriteBlock(this.Max);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x040031F5 RID: 12789
		public uint Unknown_0h;

		// Token: 0x040031F6 RID: 12790
		public uint Unknown_4h;

		// Token: 0x040031F7 RID: 12791
		public uint BoneId;

		// Token: 0x040031F8 RID: 12792
		public uint Unknown_Ch;

		// Token: 0x040031F9 RID: 12793
		public uint Unknown_10h;

		// Token: 0x040031FA RID: 12794
		public uint Unknown_14h;

		// Token: 0x040031FB RID: 12795
		public uint Unknown_18h;

		// Token: 0x040031FC RID: 12796
		public uint Unknown_1Ch;

		// Token: 0x040031FD RID: 12797
		public RAGE_Vector3 Min;

		// Token: 0x040031FE RID: 12798
		public uint Unknown_2Ch;

		// Token: 0x040031FF RID: 12799
		public RAGE_Vector3 Max;

		// Token: 0x04003200 RID: 12800
		public uint Unknown_3Ch;
	}
}
