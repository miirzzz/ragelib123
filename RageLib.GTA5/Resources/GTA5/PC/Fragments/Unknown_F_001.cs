using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000FA RID: 250
	public class Unknown_F_001 : ResourceSystemBlock
	{
		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x0001AA7F File Offset: 0x00018C7F
		public override long Length
		{
			get
			{
				return 32L + this.Data.Length;
			}
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0001AA90 File Offset: 0x00018C90
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.cnt = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlock<ResourceSimpleArray<RAGE_Matrix4>>(new object[]
			{
				this.cnt
			});
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0001AB20 File Offset: 0x00018D20
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.cnt);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Data);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0001AB99 File Offset: 0x00018D99
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.Data)
			};
		}

		// Token: 0x0400308B RID: 12427
		public uint VFT;

		// Token: 0x0400308C RID: 12428
		public uint Unknown_4h;

		// Token: 0x0400308D RID: 12429
		public uint Unknown_8h;

		// Token: 0x0400308E RID: 12430
		public uint Unknown_Ch;

		// Token: 0x0400308F RID: 12431
		public uint cnt;

		// Token: 0x04003090 RID: 12432
		public uint Unknown_14h;

		// Token: 0x04003091 RID: 12433
		public uint Unknown_18h;

		// Token: 0x04003092 RID: 12434
		public uint Unknown_1Ch;

		// Token: 0x04003093 RID: 12435
		public ResourceSimpleArray<RAGE_Matrix4> Data;
	}
}
