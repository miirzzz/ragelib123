using System;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000148 RID: 328
	public class Unknown_C_002 : ResourceSystemBlock
	{
		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004FB RID: 1275 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000227A9 File Offset: 0x000209A9
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x000227DB File Offset: 0x000209DB
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x0400349B RID: 13467
		public uint Unknown_0h;

		// Token: 0x0400349C RID: 13468
		public uint Unknown_4h;

		// Token: 0x0400349D RID: 13469
		public uint Unknown_8h;

		// Token: 0x0400349E RID: 13470
		public uint Unknown_Ch;
	}
}
