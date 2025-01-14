using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x0200029C RID: 668
	public class PsoXXHalf : IPsoValue
	{
		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x00084405 File Offset: 0x00082605
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0008440D File Offset: 0x0008260D
		public short Value { get; set; }

		// Token: 0x06000BB1 RID: 2993 RVA: 0x00084416 File Offset: 0x00082616
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt16();
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x00084424 File Offset: 0x00082624
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}
	}
}
