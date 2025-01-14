using System;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000079 RID: 121
	public class EnumEntryInfo : ResourceSystemBlock
	{
		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x0000B613 File Offset: 0x00009813
		public override long Length
		{
			get
			{
				return 8L;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x0000EAD8 File Offset: 0x0000CCD8
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x0000EAE0 File Offset: 0x0000CCE0
		public int EntryNameHash { get; set; }

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x0000EAE9 File Offset: 0x0000CCE9
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x0000EAF1 File Offset: 0x0000CCF1
		public int EntryValue { get; set; }

		// Token: 0x060002C8 RID: 712 RVA: 0x0000286D File Offset: 0x00000A6D
		public EnumEntryInfo()
		{
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x0000EAFA File Offset: 0x0000CCFA
		public EnumEntryInfo(int entryNameHash, int entryValue)
		{
			this.EntryNameHash = entryNameHash;
			this.EntryValue = entryValue;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000EB10 File Offset: 0x0000CD10
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.EntryNameHash = reader.ReadInt32();
			this.EntryValue = reader.ReadInt32();
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.EntryNameHash);
			writer.Write(this.EntryValue);
		}
	}
}
