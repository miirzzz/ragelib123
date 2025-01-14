using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000047 RID: 71
	public class Unknown_P_003 : ResourceSystemBlock
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00009D93 File Offset: 0x00007F93
		public override long Length
		{
			get
			{
				return 24L;
			}
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000A4D9 File Offset: 0x000086D9
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadBlock<ResourceSimpleList64<Unknown_P_006>>(Array.Empty<object>());
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000A504 File Offset: 0x00008704
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.WriteBlock(this.Unknown_0h);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000A52A File Offset: 0x0000872A
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(0L, this.Unknown_0h)
			};
		}

		// Token: 0x0400039C RID: 924
		public ResourceSimpleList64<Unknown_P_006> Unknown_0h;

		// Token: 0x0400039D RID: 925
		public uint Unknown_10h;

		// Token: 0x0400039E RID: 926
		public uint Unknown_14h;
	}
}
