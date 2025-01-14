using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015D RID: 349
	public class PropertyAttributeQuaternion : PropertyAttribute
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600055E RID: 1374 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00025125 File Offset: 0x00023325
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.X = reader.ReadSingle();
			this.Y = reader.ReadSingle();
			this.Z = reader.ReadSingle();
			this.W = reader.ReadSingle();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0002515F File Offset: 0x0002335F
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.X);
			writer.Write(this.Y);
			writer.Write(this.Z);
			writer.Write(this.W);
		}

		// Token: 0x040035D9 RID: 13785
		public float X;

		// Token: 0x040035DA RID: 13786
		public float Y;

		// Token: 0x040035DB RID: 13787
		public float Z;

		// Token: 0x040035DC RID: 13788
		public float W;
	}
}
