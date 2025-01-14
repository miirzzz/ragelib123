using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200014A RID: 330
	public class Unknown_C_004 : ResourceSystemBlock
	{
		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x000228ED File Offset: 0x00020AED
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt16();
			this.Unknown_2h = reader.ReadUInt16();
			this.Unknown_4h = reader.ReadSingle();
			this.Unknown_8h = reader.ReadSingle();
			this.Unknown_Ch = reader.ReadSingle();
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x0002292B File Offset: 0x00020B2B
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_2h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x040034A7 RID: 13479
		public ushort Unknown_0h;

		// Token: 0x040034A8 RID: 13480
		public ushort Unknown_2h;

		// Token: 0x040034A9 RID: 13481
		public float Unknown_4h;

		// Token: 0x040034AA RID: 13482
		public float Unknown_8h;

		// Token: 0x040034AB RID: 13483
		public float Unknown_Ch;
	}
}
