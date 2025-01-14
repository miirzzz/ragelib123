using System;
using System.Collections.Generic;

namespace RageLib.Resources
{
	// Token: 0x02000006 RID: 6
	public class FileBase64_GTA5_pc : ResourceSystemBlock
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x0600002D RID: 45 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000027B2 File Offset: 0x000009B2
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.PagesInfoPointer = reader.ReadUInt64();
			this.PagesInfo = reader.ReadBlockAt<PagesInfo_GTA5_pc>(this.PagesInfoPointer, Array.Empty<object>());
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000027F0 File Offset: 0x000009F0
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.PagesInfoPointer = (ulong)((this.PagesInfo != null) ? this.PagesInfo.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.PagesInfoPointer);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002840 File Offset: 0x00000A40
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.PagesInfo != null)
			{
				list.Add(this.PagesInfo);
			}
			return list.ToArray();
		}

		// Token: 0x04000005 RID: 5
		public uint VFT;

		// Token: 0x04000006 RID: 6
		public uint Unknown_4h;

		// Token: 0x04000007 RID: 7
		public ulong PagesInfoPointer;

		// Token: 0x04000008 RID: 8
		public PagesInfo_GTA5_pc PagesInfo;
	}
}
