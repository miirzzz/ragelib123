using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004E RID: 78
	public class Unknown_P_010 : ResourceSystemBlock
	{
		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000AB01 File Offset: 0x00008D01
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h_Pointer = reader.ReadUInt64();
			this.Unknown_8h_Data = reader.ReadBlockAt<Unknown_P_003>(this.Unknown_8h_Pointer, Array.Empty<object>());
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000AB40 File Offset: 0x00008D40
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.Unknown_8h_Pointer = (ulong)((this.Unknown_8h_Data != null) ? this.Unknown_8h_Data.Position : 0L);
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h_Pointer);
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000AB90 File Offset: 0x00008D90
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Unknown_8h_Data != null)
			{
				list.Add(this.Unknown_8h_Data);
			}
			return list.ToArray();
		}

		// Token: 0x040003C8 RID: 968
		public uint Unknown_0h;

		// Token: 0x040003C9 RID: 969
		public uint Unknown_4h;

		// Token: 0x040003CA RID: 970
		public ulong Unknown_8h_Pointer;

		// Token: 0x040003CB RID: 971
		public Unknown_P_003 Unknown_8h_Data;
	}
}
