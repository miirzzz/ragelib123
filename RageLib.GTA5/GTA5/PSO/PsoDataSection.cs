using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000208 RID: 520
	public class PsoDataSection
	{
		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600098C RID: 2444 RVA: 0x0003C992 File Offset: 0x0003AB92
		// (set) Token: 0x0600098D RID: 2445 RVA: 0x0003C99A File Offset: 0x0003AB9A
		public uint Ident { get; set; } = 1347635534U;

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x0600098E RID: 2446 RVA: 0x0003C9A3 File Offset: 0x0003ABA3
		// (set) Token: 0x0600098F RID: 2447 RVA: 0x0003C9AB File Offset: 0x0003ABAB
		public int Length { get; private set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000990 RID: 2448 RVA: 0x0003C9B4 File Offset: 0x0003ABB4
		// (set) Token: 0x06000991 RID: 2449 RVA: 0x0003C9BC File Offset: 0x0003ABBC
		public byte[] Data { get; set; }

		// Token: 0x06000992 RID: 2450 RVA: 0x0003C9C5 File Offset: 0x0003ABC5
		public void Read(DataReader reader)
		{
			this.Ident = reader.ReadUInt32();
			this.Length = reader.ReadInt32();
			reader.Position -= 8L;
			this.Data = reader.ReadBytes(this.Length);
		}

		// Token: 0x06000993 RID: 2451 RVA: 0x0003CA00 File Offset: 0x0003AC00
		public void Write(DataWriter writer)
		{
			writer.Write(this.Data);
			writer.Position -= (long)this.Data.Length;
			writer.Write(1347635534U);
			writer.Write((uint)this.Data.Length);
			writer.Position += (long)(this.Data.Length - 8);
		}

		// Token: 0x06000994 RID: 2452 RVA: 0x0003CA60 File Offset: 0x0003AC60
		public override string ToString()
		{
			return this.Ident.ToString() + ": " + this.Length.ToString();
		}
	}
}
