using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000215 RID: 533
	public class PsoSTRESection
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0003D856 File Offset: 0x0003BA56
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0003D85E File Offset: 0x0003BA5E
		public int Ident { get; private set; } = 1398035013;

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0003D867 File Offset: 0x0003BA67
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0003D86F File Offset: 0x0003BA6F
		public int Length { get; set; }

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0003D878 File Offset: 0x0003BA78
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0003D880 File Offset: 0x0003BA80
		public byte[] Data { get; set; }

		// Token: 0x06000A00 RID: 2560 RVA: 0x0003D889 File Offset: 0x0003BA89
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadInt32();
			this.Length = reader.ReadInt32();
			if (this.Length > 8)
			{
				this.Data = reader.ReadBytes(this.Length - 8);
			}
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0003D8C0 File Offset: 0x0003BAC0
		public void Write(DataWriter writer)
		{
			writer.Write(this.Ident);
			writer.Write(this.Length);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0003D8DC File Offset: 0x0003BADC
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
