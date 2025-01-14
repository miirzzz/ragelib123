using System;
using RageLib.Data;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Data;

namespace RageLib.GTA5.PSOWrappers.Types
{
	// Token: 0x02000281 RID: 641
	public class PsoEnumByte : IPsoValue
	{
		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x000838B9 File Offset: 0x00081AB9
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x000838C1 File Offset: 0x00081AC1
		public PsoEnumInfo TypeInfo { get; set; }

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x000838CA File Offset: 0x00081ACA
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x000838D2 File Offset: 0x00081AD2
		public byte Value { get; set; }

		// Token: 0x06000B09 RID: 2825 RVA: 0x00002192 File Offset: 0x00000392
		public PsoEnumByte()
		{
		}

		// Token: 0x06000B0A RID: 2826 RVA: 0x000838DB File Offset: 0x00081ADB
		public PsoEnumByte(byte value)
		{
			this.Value = value;
		}

		// Token: 0x06000B0B RID: 2827 RVA: 0x000838EA File Offset: 0x00081AEA
		public PsoEnumByte(PsoEnumInfo typeInfo, byte value)
		{
			this.TypeInfo = typeInfo;
			this.Value = value;
		}

		// Token: 0x06000B0C RID: 2828 RVA: 0x00083900 File Offset: 0x00081B00
		public void Read(PsoDataReader reader)
		{
			this.Value = reader.ReadByte();
		}

		// Token: 0x06000B0D RID: 2829 RVA: 0x0008390E File Offset: 0x00081B0E
		public void Write(DataWriter writer)
		{
			writer.Write(this.Value);
		}
	}
}
