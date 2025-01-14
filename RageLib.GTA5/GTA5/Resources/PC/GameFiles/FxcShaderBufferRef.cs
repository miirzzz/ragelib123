using System;

namespace RageLib.GTA5.Resources.PC.GameFiles
{
	// Token: 0x020001EE RID: 494
	public class FxcShaderBufferRef
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x0003985B File Offset: 0x00037A5B
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x00039863 File Offset: 0x00037A63
		public string Name { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x0003986C File Offset: 0x00037A6C
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00039874 File Offset: 0x00037A74
		public ushort Unk0Ushort { get; set; }

		// Token: 0x060008A9 RID: 2217 RVA: 0x00039880 File Offset: 0x00037A80
		public override string ToString()
		{
			return this.Name + ": " + this.Unk0Ushort.ToString();
		}
	}
}
