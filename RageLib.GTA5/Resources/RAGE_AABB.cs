using System;

namespace RageLib.Resources
{
	// Token: 0x02000008 RID: 8
	public class RAGE_AABB : ResourceSystemBlock
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002946 File Offset: 0x00000B46
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.AABB_Max = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
			this.AABB_Min = reader.ReadBlock<RAGE_Vector4>(Array.Empty<object>());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000296A File Offset: 0x00000B6A
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.WriteBlock(this.AABB_Max);
			writer.WriteBlock(this.AABB_Min);
		}

		// Token: 0x04000010 RID: 16
		public RAGE_Vector4 AABB_Max;

		// Token: 0x04000011 RID: 17
		public RAGE_Vector4 AABB_Min;
	}
}
