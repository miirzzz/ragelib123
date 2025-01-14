using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007E RID: 126
	public struct MetaBuilderPointer
	{
		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000306 RID: 774 RVA: 0x0000F737 File Offset: 0x0000D937
		// (set) Token: 0x06000307 RID: 775 RVA: 0x0000F73F File Offset: 0x0000D93F
		public int BlockID { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0000F748 File Offset: 0x0000D948
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000F750 File Offset: 0x0000D950
		public int Offset { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0000F759 File Offset: 0x0000D959
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000F761 File Offset: 0x0000D961
		public int Length { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0000F76C File Offset: 0x0000D96C
		public uint Pointer
		{
			get
			{
				uint num = (uint)(this.BlockID & 4095);
				uint num2 = (uint)((uint)(this.Offset & 1048575) << 12);
				return num + num2;
			}
		}
	}
}
