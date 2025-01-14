using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000147 RID: 327
	public class Unknown_C_001 : ResourceSystemBlock
	{
		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00022745 File Offset: 0x00020945
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00022777 File Offset: 0x00020977
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x04003497 RID: 13463
		public uint Unknown_0h;

		// Token: 0x04003498 RID: 13464
		public uint Unknown_4h;

		// Token: 0x04003499 RID: 13465
		public uint Unknown_8h;

		// Token: 0x0400349A RID: 13466
		public uint Unknown_Ch;
	}
}
