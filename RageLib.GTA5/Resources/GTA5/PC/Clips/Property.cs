using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000157 RID: 343
	public class Property : ResourceSystemBlock
	{
		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000544 RID: 1348 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000545 RID: 1349 RVA: 0x00024B54 File Offset: 0x00022D54
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.NameHash = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.AttributesPointer = reader.ReadUInt64();
			this.AttributesCount1 = reader.ReadUInt16();
			this.AttributesCount2 = reader.ReadUInt16();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Attributes = reader.ReadBlockAt<ResourcePointerArray64<PropertyAttribute>>(this.AttributesPointer, new object[]
			{
				this.AttributesCount1
			});
		}

		// Token: 0x06000546 RID: 1350 RVA: 0x00024C48 File Offset: 0x00022E48
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.AttributesPointer = (ulong)((this.Attributes != null) ? this.Attributes.Position : 0L);
			this.AttributesCount1 = (ushort)((this.Attributes != null) ? this.Attributes.Count : 0);
			this.AttributesCount2 = (ushort)((this.Attributes != null) ? this.Attributes.Count : 0);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.NameHash);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.AttributesPointer);
			writer.Write(this.AttributesCount1);
			writer.Write(this.AttributesCount2);
			writer.Write(this.Unknown_2Ch);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
		}

		// Token: 0x06000547 RID: 1351 RVA: 0x00024D6C File Offset: 0x00022F6C
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Attributes != null)
			{
				list.Add(this.Attributes);
			}
			return list.ToArray();
		}

		// Token: 0x040035AE RID: 13742
		public uint VFT;

		// Token: 0x040035AF RID: 13743
		public uint Unknown_4h;

		// Token: 0x040035B0 RID: 13744
		public uint Unknown_8h;

		// Token: 0x040035B1 RID: 13745
		public uint Unknown_Ch;

		// Token: 0x040035B2 RID: 13746
		public uint Unknown_10h;

		// Token: 0x040035B3 RID: 13747
		public uint Unknown_14h;

		// Token: 0x040035B4 RID: 13748
		public uint NameHash;

		// Token: 0x040035B5 RID: 13749
		public uint Unknown_1Ch;

		// Token: 0x040035B6 RID: 13750
		public ulong AttributesPointer;

		// Token: 0x040035B7 RID: 13751
		public ushort AttributesCount1;

		// Token: 0x040035B8 RID: 13752
		public ushort AttributesCount2;

		// Token: 0x040035B9 RID: 13753
		public uint Unknown_2Ch;

		// Token: 0x040035BA RID: 13754
		public uint Unknown_30h;

		// Token: 0x040035BB RID: 13755
		public uint Unknown_34h;

		// Token: 0x040035BC RID: 13756
		public uint Unknown_38h;

		// Token: 0x040035BD RID: 13757
		public uint Unknown_3Ch;

		// Token: 0x040035BE RID: 13758
		public ResourcePointerArray64<PropertyAttribute> Attributes;
	}
}
