using System;
using SharpDX;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000D7 RID: 215
	public struct rage__spdAABB
	{
		// Token: 0x06000354 RID: 852 RVA: 0x00015E80 File Offset: 0x00014080
		public void SwapEnd()
		{
			this.min = MetaUtils.SwapBytes(this.min);
			this.max = MetaUtils.SwapBytes(this.max);
		}

		// Token: 0x04002E52 RID: 11858
		public Vector4 min;

		// Token: 0x04002E53 RID: 11859
		public Vector4 max;
	}
}
