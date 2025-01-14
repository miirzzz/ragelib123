using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x02000173 RID: 371
	public abstract class BoundPolygonBase
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060005C2 RID: 1474 RVA: 0x00026F6E File Offset: 0x0002516E
		// (set) Token: 0x060005C3 RID: 1475 RVA: 0x00026F76 File Offset: 0x00025176
		public BoundPolygonType Type { get; set; }

		// Token: 0x060005C4 RID: 1476
		public abstract void Read(byte[] bytes, int offset);

		// Token: 0x060005C5 RID: 1477 RVA: 0x00026F80 File Offset: 0x00025180
		public override string ToString()
		{
			return this.Type.ToString();
		}
	}
}
