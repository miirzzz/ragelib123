using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000FB RID: 251
	public class Unknown_F_002 : ResourceSystemBlock
	{
		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x0001ABB2 File Offset: 0x00018DB2
		public override long Length
		{
			get
			{
				return 16L + this.Data.Length;
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0001ABC4 File Offset: 0x00018DC4
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.cnt1 = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Data = reader.ReadBlock<ResourceSimpleArray<byte_r>>(new object[]
			{
				this.cnt1 - 16U
			});
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0001AC24 File Offset: 0x00018E24
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.cnt1);
			writer.Write(this.Unknown_Ch);
			writer.WriteBlock(this.Data);
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x0001AC62 File Offset: 0x00018E62
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.Data)
			};
		}

		// Token: 0x04003094 RID: 12436
		public uint Unknown_0h;

		// Token: 0x04003095 RID: 12437
		public uint Unknown_4h;

		// Token: 0x04003096 RID: 12438
		public uint cnt1;

		// Token: 0x04003097 RID: 12439
		public uint Unknown_Ch;

		// Token: 0x04003098 RID: 12440
		public ResourceSimpleArray<byte_r> Data;
	}
}
