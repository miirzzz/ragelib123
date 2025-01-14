using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000207 RID: 519
	public class PsoDataMappingEntry
	{
		// Token: 0x17000213 RID: 531
		// (get) Token: 0x06000981 RID: 2433 RVA: 0x0003C8EA File Offset: 0x0003AAEA
		// (set) Token: 0x06000982 RID: 2434 RVA: 0x0003C8F2 File Offset: 0x0003AAF2
		public int NameHash { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0003C8FB File Offset: 0x0003AAFB
		// (set) Token: 0x06000984 RID: 2436 RVA: 0x0003C903 File Offset: 0x0003AB03
		public int Offset { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06000985 RID: 2437 RVA: 0x0003C90C File Offset: 0x0003AB0C
		// (set) Token: 0x06000986 RID: 2438 RVA: 0x0003C914 File Offset: 0x0003AB14
		public int Unknown_8h { get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x0003C91D File Offset: 0x0003AB1D
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0003C925 File Offset: 0x0003AB25
		public int Length { get; set; }

		// Token: 0x06000989 RID: 2441 RVA: 0x0003C92E File Offset: 0x0003AB2E
		public void Read(DataReader reader)
		{
			this.NameHash = reader.ReadInt32();
			this.Offset = reader.ReadInt32();
			this.Unknown_8h = reader.ReadInt32();
			this.Length = reader.ReadInt32();
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0003C960 File Offset: 0x0003AB60
		public void Write(DataWriter writer)
		{
			writer.Write(this.NameHash);
			writer.Write(this.Offset);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Length);
		}
	}
}
