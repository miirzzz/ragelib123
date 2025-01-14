using System;
using RageLib.Data;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000280 RID: 640
	public class PsoByte : IPsoValue
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x0008389A File Offset: 0x00081A9A
		// (set) Token: 0x06000B01 RID: 2817 RVA: 0x000838A2 File Offset: 0x00081AA2
		public byte Value { get; set; }

		// Token: 0x06000B02 RID: 2818 RVA: 0x000838AB File Offset: 0x00081AAB
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadByte();
		}

		// Token: 0x06000B03 RID: 2819 RVA: 0x00016F58 File Offset: 0x00015158
		public void Write(DataWriter writer)
		{
		}
	}
}
