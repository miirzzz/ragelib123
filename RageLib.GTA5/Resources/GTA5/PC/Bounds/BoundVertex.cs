using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200017A RID: 378
	public class BoundVertex : ResourceSystemBlock
	{
		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060005DD RID: 1501 RVA: 0x0000D199 File Offset: 0x0000B399
		public override long Length
		{
			get
			{
				return 6L;
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x00027453 File Offset: 0x00025653
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.X = reader.ReadInt16();
			this.Y = reader.ReadInt16();
			this.Z = reader.ReadInt16();
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x00027479 File Offset: 0x00025679
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.X);
			writer.Write(this.Y);
			writer.Write(this.Z);
		}

		// Token: 0x040036B5 RID: 14005
		public short X;

		// Token: 0x040036B6 RID: 14006
		public short Y;

		// Token: 0x040036B7 RID: 14007
		public short Z;
	}
}
