using System;
using RageLib.Data;

namespace RageLib.GTA5.PSO
{
	// Token: 0x0200020E RID: 526
	public class PsoStructureEntryInfo
	{
		// Token: 0x060009B7 RID: 2487 RVA: 0x00002192 File Offset: 0x00000392
		public PsoStructureEntryInfo()
		{
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0003D046 File Offset: 0x0003B246
		public PsoStructureEntryInfo(int nameHash, DataType type, byte unk5, short dataOffset, int referenceKey)
		{
			this.EntryNameHash = nameHash;
			this.Type = type;
			this.Unk_5h = unk5;
			this.DataOffset = dataOffset;
			this.ReferenceKey = referenceKey;
		}

		// Token: 0x060009B9 RID: 2489 RVA: 0x0003D073 File Offset: 0x0003B273
		public void Read(DataReader reader)
		{
			this.EntryNameHash = reader.ReadInt32();
			this.Type = (DataType)reader.ReadByte();
			this.Unk_5h = reader.ReadByte();
			this.DataOffset = reader.ReadInt16();
			this.ReferenceKey = reader.ReadInt32();
		}

		// Token: 0x060009BA RID: 2490 RVA: 0x0003D0B1 File Offset: 0x0003B2B1
		public void Write(DataWriter writer)
		{
			writer.Write(this.EntryNameHash);
			writer.Write((byte)this.Type);
			writer.Write(this.Unk_5h);
			writer.Write(this.DataOffset);
			writer.Write(this.ReferenceKey);
		}

		// Token: 0x04003AD6 RID: 15062
		public int EntryNameHash;

		// Token: 0x04003AD7 RID: 15063
		public DataType Type;

		// Token: 0x04003AD8 RID: 15064
		public byte Unk_5h;

		// Token: 0x04003AD9 RID: 15065
		public short DataOffset;

		// Token: 0x04003ADA RID: 15066
		public int ReferenceKey;
	}
}
