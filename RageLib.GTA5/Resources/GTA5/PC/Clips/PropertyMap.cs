using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000160 RID: 352
	public class PropertyMap : ResourceSystemBlock
	{
		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600056B RID: 1387 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00025348 File Offset: 0x00023548
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.PropertyEntriesPointer = reader.ReadUInt64();
			this.PropertyEntriesCount = reader.ReadUInt16();
			this.PropertyEntriesTotalCount = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Properties = reader.ReadBlockAt<ResourcePointerArray64<PropertyMapEntry>>(this.PropertyEntriesPointer, new object[]
			{
				this.PropertyEntriesCount
			});
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000253AC File Offset: 0x000235AC
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.PropertyEntriesPointer = (ulong)((this.Properties != null) ? this.Properties.Position : 0L);
			this.PropertyEntriesCount = (ushort)((this.Properties != null) ? this.Properties.Count : 0);
			if (this.Properties != null)
			{
				int num = 0;
				foreach (PropertyMapEntry propertyMapEntry in this.Properties.data_items)
				{
					if (propertyMapEntry != null)
					{
						PropertyMapEntry propertyMapEntry2 = propertyMapEntry;
						for (;;)
						{
							if (propertyMapEntry2.Data != null)
							{
								num++;
							}
							if (propertyMapEntry2.Next == null)
							{
								break;
							}
							propertyMapEntry2 = propertyMapEntry2.Next;
						}
					}
				}
				this.PropertyEntriesTotalCount = (ushort)num;
			}
			else
			{
				this.PropertyEntriesTotalCount = 0;
			}
			writer.Write(this.PropertyEntriesPointer);
			writer.Write(this.PropertyEntriesCount);
			writer.Write(this.PropertyEntriesTotalCount);
			writer.Write(this.Unknown_Ch);
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000254A4 File Offset: 0x000236A4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Properties != null)
			{
				list.Add(this.Properties);
			}
			return list.ToArray();
		}

		// Token: 0x040035E6 RID: 13798
		public ulong PropertyEntriesPointer;

		// Token: 0x040035E7 RID: 13799
		public ushort PropertyEntriesCount;

		// Token: 0x040035E8 RID: 13800
		public ushort PropertyEntriesTotalCount;

		// Token: 0x040035E9 RID: 13801
		public uint Unknown_Ch;

		// Token: 0x040035EA RID: 13802
		public ResourcePointerArray64<PropertyMapEntry> Properties;
	}
}
