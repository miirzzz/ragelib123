using System;

namespace RageLib.Resources.GTA5.PC.Bounds
{
	// Token: 0x0200016F RID: 367
	public class BoundMaterial : ResourceSystemBlock
	{
		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060005B4 RID: 1460 RVA: 0x00026DAF File Offset: 0x00024FAF
		// (set) Token: 0x060005B5 RID: 1461 RVA: 0x00026DBA File Offset: 0x00024FBA
		public int RoomId
		{
			get
			{
				return (int)(31 & this.RoomId_And_PedDensity);
			}
			set
			{
				this.RoomId_And_PedDensity = (byte)(((int)this.RoomId_And_PedDensity & -32) | value);
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060005B6 RID: 1462 RVA: 0x00026DCE File Offset: 0x00024FCE
		// (set) Token: 0x060005B7 RID: 1463 RVA: 0x00026DDE File Offset: 0x00024FDE
		public int PedDensity
		{
			get
			{
				return (224 & this.RoomId_And_PedDensity) >> 5;
			}
			set
			{
				this.RoomId_And_PedDensity = (byte)(((int)this.RoomId_And_PedDensity & -225) | value << 5);
			}
		}

		// Token: 0x060005B8 RID: 1464 RVA: 0x00026DF8 File Offset: 0x00024FF8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.MaterialIndex = reader.ReadByte();
			this.ProcId = reader.ReadByte();
			this.RoomId_And_PedDensity = reader.ReadByte();
			this.Unknown_3h = reader.ReadByte();
			this.Unknown_4h = reader.ReadByte();
			this.MaterialColorIndex = reader.ReadByte();
			this.Unknown_6h = reader.ReadInt16();
		}

		// Token: 0x060005B9 RID: 1465 RVA: 0x00026E5C File Offset: 0x0002505C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.MaterialIndex);
			writer.Write(this.ProcId);
			writer.Write(this.RoomId_And_PedDensity);
			writer.Write(this.Unknown_3h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.MaterialColorIndex);
			writer.Write(this.Unknown_6h);
		}

		// Token: 0x04003687 RID: 13959
		public byte MaterialIndex;

		// Token: 0x04003688 RID: 13960
		public byte ProcId;

		// Token: 0x04003689 RID: 13961
		public byte RoomId_And_PedDensity;

		// Token: 0x0400368A RID: 13962
		public byte Unknown_3h;

		// Token: 0x0400368B RID: 13963
		public byte Unknown_4h;

		// Token: 0x0400368C RID: 13964
		public byte MaterialColorIndex;

		// Token: 0x0400368D RID: 13965
		public short Unknown_6h;
	}
}
