using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000299 RID: 665
	public class PsoType5 : IPsoValue
	{
		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000B9F RID: 2975 RVA: 0x00084398 File Offset: 0x00082598
		// (set) Token: 0x06000BA0 RID: 2976 RVA: 0x000843A0 File Offset: 0x000825A0
		public int Value { get; set; }

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000843A9 File Offset: 0x000825A9
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadInt32();
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
