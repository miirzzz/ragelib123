using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.VehicleRecords
{
	// Token: 0x02000013 RID: 19
	public class VehicleRecords : FileBase64_GTA5_pc
	{
		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00003D3D File Offset: 0x00001F3D
		public VehicleRecords()
		{
			this.Entries = new ResourceSimpleList64<VehicleRecordsEntry>();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00003D50 File Offset: 0x00001F50
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Entries = reader.ReadBlock<ResourceSimpleList64<VehicleRecordsEntry>>(Array.Empty<object>());
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00003D6B File Offset: 0x00001F6B
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.WriteBlock(this.Entries);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00003D81 File Offset: 0x00001F81
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.Entries)
			};
		}

		// Token: 0x0400006E RID: 110
		public ResourceSimpleList64<VehicleRecordsEntry> Entries;
	}
}
