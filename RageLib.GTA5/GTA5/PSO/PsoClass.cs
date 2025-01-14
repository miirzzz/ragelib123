using System;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000203 RID: 515
	public abstract class PsoClass<T> where T : struct, IPsoSwapEnd
	{
		// Token: 0x06000961 RID: 2401
		public abstract void Init(PsoFile pso, ref T v);
	}
}
