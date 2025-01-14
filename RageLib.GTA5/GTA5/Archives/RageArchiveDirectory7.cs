using System;
using System.Collections.Generic;
using RageLib.Data;

namespace RageLib.GTA5.Archives
{
	// Token: 0x020002B0 RID: 688
	public class RageArchiveDirectory7 : IRageArchiveEntry7
	{
		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000C40 RID: 3136 RVA: 0x00089D3F File Offset: 0x00087F3F
		// (set) Token: 0x06000C41 RID: 3137 RVA: 0x00089D47 File Offset: 0x00087F47
		public uint NameOffset { get; set; }

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000C42 RID: 3138 RVA: 0x00089D50 File Offset: 0x00087F50
		// (set) Token: 0x06000C43 RID: 3139 RVA: 0x00089D58 File Offset: 0x00087F58
		public uint EntriesIndex { get; set; }

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000C44 RID: 3140 RVA: 0x00089D61 File Offset: 0x00087F61
		// (set) Token: 0x06000C45 RID: 3141 RVA: 0x00089D69 File Offset: 0x00087F69
		public uint EntriesCount { get; set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000C46 RID: 3142 RVA: 0x00089D72 File Offset: 0x00087F72
		// (set) Token: 0x06000C47 RID: 3143 RVA: 0x00089D7A File Offset: 0x00087F7A
		public string Name { get; set; }

		// Token: 0x06000C48 RID: 3144 RVA: 0x00089D83 File Offset: 0x00087F83
		public void Read(DataReader reader)
		{
			this.NameOffset = reader.ReadUInt32();
			if (reader.ReadUInt32() != 2147483392U)
			{
				throw new Exception("Error in RPF7 directory entry.");
			}
			this.EntriesIndex = reader.ReadUInt32();
			this.EntriesCount = reader.ReadUInt32();
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x00089DC1 File Offset: 0x00087FC1
		public void Write(DataWriter writer)
		{
			writer.Write(this.NameOffset);
			writer.Write(2147483392U);
			writer.Write(this.EntriesIndex);
			writer.Write(this.EntriesCount);
		}

		// Token: 0x0400401C RID: 16412
		public List<RageArchiveDirectory7> Directories = new List<RageArchiveDirectory7>();

		// Token: 0x0400401D RID: 16413
		public List<IRageArchiveEntry7> Files = new List<IRageArchiveEntry7>();
	}
}
