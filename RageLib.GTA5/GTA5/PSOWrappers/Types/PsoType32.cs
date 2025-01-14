using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000297 RID: 663
	public class PsoType32 : IPsoValue
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000B95 RID: 2965 RVA: 0x00084358 File Offset: 0x00082558
		// (set) Token: 0x06000B96 RID: 2966 RVA: 0x00084360 File Offset: 0x00082560
		public int Value { get; set; }

		// Token: 0x06000B98 RID: 2968 RVA: 0x00084369 File Offset: 0x00082569
		public void Read(PsoDataReader reader)
		{
			reader.ReadInt32();
			reader.ReadInt32();
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
