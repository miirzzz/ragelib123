using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000161 RID: 353
	public class PropertyMapEntry : ResourceSystemBlock
	{
		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x000254D4 File Offset: 0x000236D4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.DataNameHash = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.DataPointer = reader.ReadUInt64();
			this.NextPointer = reader.ReadUInt64();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlockAt<Property>(this.DataPointer, Array.Empty<object>());
			this.Next = reader.ReadBlockAt<PropertyMapEntry>(this.NextPointer, Array.Empty<object>());
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00025558 File Offset: 0x00023758
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.DataPointer = (ulong)((this.Data != null) ? this.Data.Position : 0L);
			this.NextPointer = (ulong)((this.Next != null) ? this.Next.Position : 0L);
			writer.Write(this.DataNameHash);
			writer.Write(this.Unknown_4h);
			writer.Write(this.DataPointer);
			writer.Write(this.NextPointer);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x000255E8 File Offset: 0x000237E8
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Data != null)
			{
				list.Add(this.Data);
			}
			if (this.Next != null)
			{
				list.Add(this.Next);
			}
			return list.ToArray();
		}

		// Token: 0x040035EB RID: 13803
		public uint DataNameHash;

		// Token: 0x040035EC RID: 13804
		public uint Unknown_4h;

		// Token: 0x040035ED RID: 13805
		public ulong DataPointer;

		// Token: 0x040035EE RID: 13806
		public ulong NextPointer;

		// Token: 0x040035EF RID: 13807
		public uint Unknown_18h;

		// Token: 0x040035F0 RID: 13808
		public uint Unknown_1Ch;

		// Token: 0x040035F1 RID: 13809
		public Property Data;

		// Token: 0x040035F2 RID: 13810
		public PropertyMapEntry Next;
	}
}
