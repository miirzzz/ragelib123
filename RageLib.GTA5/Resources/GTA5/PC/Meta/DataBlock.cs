using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x02000077 RID: 119
	public class DataBlock : ResourceSystemBlock
	{
		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060002AE RID: 686 RVA: 0x0000E8FB File Offset: 0x0000CAFB
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0000E903 File Offset: 0x0000CB03
		public MetaName StructureNameHash { get; set; }

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000E90C File Offset: 0x0000CB0C
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0000E914 File Offset: 0x0000CB14
		public int DataLength { get; set; }

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000E91D File Offset: 0x0000CB1D
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x0000E925 File Offset: 0x0000CB25
		public long DataPointer { get; private set; }

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000E92E File Offset: 0x0000CB2E
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x0000E936 File Offset: 0x0000CB36
		public ResourceSimpleArray<byte_r> Data { get; set; }

		// Token: 0x060002B6 RID: 694 RVA: 0x0000E940 File Offset: 0x0000CB40
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.StructureNameHash = (MetaName)reader.ReadInt32();
			this.DataLength = reader.ReadInt32();
			this.DataPointer = reader.ReadInt64();
			this.Data = reader.ReadBlockAt<ResourceSimpleArray<byte_r>>((ulong)this.DataPointer, new object[]
			{
				this.DataLength
			});
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x0000E998 File Offset: 0x0000CB98
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			ResourceSimpleArray<byte_r> data = this.Data;
			this.DataLength = ((data != null) ? data.Count : 0);
			ResourceSimpleArray<byte_r> data2 = this.Data;
			this.DataPointer = ((data2 != null) ? data2.Position : 0L);
			writer.Write((int)this.StructureNameHash);
			writer.Write(this.DataLength);
			writer.Write(this.DataPointer);
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Data != null)
			{
				list.Add(this.Data);
			}
			return list.ToArray();
		}
	}
}
