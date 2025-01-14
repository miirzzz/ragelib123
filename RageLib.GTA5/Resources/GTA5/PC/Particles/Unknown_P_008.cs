using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x0200004C RID: 76
	public class Unknown_P_008 : ResourceSystemBlock
	{
		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000A92C File Offset: 0x00008B2C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.p1 = reader.ReadUInt64();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.p1data = reader.ReadBlockAt<string_r>(this.p1, Array.Empty<object>());
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000A98C File Offset: 0x00008B8C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.p1 = (ulong)((this.p1data != null) ? this.p1data.Position : 0L);
			writer.Write(this.p1);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000A9F4 File Offset: 0x00008BF4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.p1data != null)
			{
				list.Add(this.p1data);
			}
			return list.ToArray();
		}

		// Token: 0x040003BA RID: 954
		public ulong p1;

		// Token: 0x040003BB RID: 955
		public uint Unknown_8h;

		// Token: 0x040003BC RID: 956
		public uint Unknown_Ch;

		// Token: 0x040003BD RID: 957
		public uint Unknown_10h;

		// Token: 0x040003BE RID: 958
		public uint Unknown_14h;

		// Token: 0x040003BF RID: 959
		public string_r p1data;
	}
}
