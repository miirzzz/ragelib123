using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000113 RID: 275
	public class Unknown_D_001 : ResourceSystemBlock
	{
		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001ED99 File Offset: 0x0001CF99
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Key = reader.ReadUInt32();
			this.Value = reader.ReadUInt32();
			this.NextPointer = reader.ReadUInt64();
			this.Next = reader.ReadBlockAt<Unknown_D_001>(this.NextPointer, Array.Empty<object>());
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001EDD8 File Offset: 0x0001CFD8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NextPointer = (ulong)((this.Next != null) ? this.Next.Position : 0L);
			writer.Write(this.Key);
			writer.Write(this.Value);
			writer.Write(this.NextPointer);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001EE28 File Offset: 0x0001D028
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Next != null)
			{
				list.Add(this.Next);
			}
			return list.ToArray();
		}

		// Token: 0x04003280 RID: 12928
		public uint Key;

		// Token: 0x04003281 RID: 12929
		public uint Value;

		// Token: 0x04003282 RID: 12930
		public ulong NextPointer;

		// Token: 0x04003283 RID: 12931
		public Unknown_D_001 Next;
	}
}
