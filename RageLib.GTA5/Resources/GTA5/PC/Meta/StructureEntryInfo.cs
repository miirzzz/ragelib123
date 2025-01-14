using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x020000DF RID: 223
	public class StructureEntryInfo : ResourceSystemBlock
	{
		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00016899 File Offset: 0x00014A99
		// (set) Token: 0x06000371 RID: 881 RVA: 0x000168A1 File Offset: 0x00014AA1
		public int EntryNameHash { get; set; }

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000168AA File Offset: 0x00014AAA
		// (set) Token: 0x06000373 RID: 883 RVA: 0x000168B2 File Offset: 0x00014AB2
		public int DataOffset { get; set; }

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000374 RID: 884 RVA: 0x000168BB File Offset: 0x00014ABB
		// (set) Token: 0x06000375 RID: 885 RVA: 0x000168C3 File Offset: 0x00014AC3
		public StructureEntryDataType DataType { get; set; }

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000376 RID: 886 RVA: 0x000168CC File Offset: 0x00014ACC
		// (set) Token: 0x06000377 RID: 887 RVA: 0x000168D4 File Offset: 0x00014AD4
		public byte Unknown_9h { get; set; }

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000378 RID: 888 RVA: 0x000168DD File Offset: 0x00014ADD
		// (set) Token: 0x06000379 RID: 889 RVA: 0x000168E5 File Offset: 0x00014AE5
		public short ReferenceTypeIndex { get; set; }

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600037A RID: 890 RVA: 0x000168EE File Offset: 0x00014AEE
		// (set) Token: 0x0600037B RID: 891 RVA: 0x000168F6 File Offset: 0x00014AF6
		public int ReferenceKey { get; set; }

		// Token: 0x0600037C RID: 892 RVA: 0x0000286D File Offset: 0x00000A6D
		public StructureEntryInfo()
		{
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000168FF File Offset: 0x00014AFF
		public StructureEntryInfo(int entryNameHash, int dataOffset, StructureEntryDataType structureEntryDataType, byte unknown_9h, short referenceTypeIndex, int referenceKey)
		{
			this.EntryNameHash = entryNameHash;
			this.DataOffset = dataOffset;
			this.DataType = structureEntryDataType;
			this.Unknown_9h = unknown_9h;
			this.ReferenceTypeIndex = referenceTypeIndex;
			this.ReferenceKey = referenceKey;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00016934 File Offset: 0x00014B34
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.EntryNameHash = reader.ReadInt32();
			this.DataOffset = reader.ReadInt32();
			this.DataType = (StructureEntryDataType)reader.ReadByte();
			this.Unknown_9h = reader.ReadByte();
			this.ReferenceTypeIndex = reader.ReadInt16();
			this.ReferenceKey = reader.ReadInt32();
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001698C File Offset: 0x00014B8C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.EntryNameHash);
			writer.Write(this.DataOffset);
			writer.Write((byte)this.DataType);
			writer.Write(this.Unknown_9h);
			writer.Write(this.ReferenceTypeIndex);
			writer.Write(this.ReferenceKey);
		}
	}
}
