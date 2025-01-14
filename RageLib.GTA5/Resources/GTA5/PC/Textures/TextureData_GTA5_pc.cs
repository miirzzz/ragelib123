using System;

namespace RageLib.Resources.GTA5.PC.Textures
{
	// Token: 0x02000018 RID: 24
	public class TextureData_GTA5_pc : ResourceGraphicsBlock
	{
		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00004534 File Offset: 0x00002734
		public override long Length
		{
			get
			{
				return (long)this.FullData.Length;
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00004540 File Offset: 0x00002740
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			Convert.ToUInt32(parameters[0]);
			Convert.ToInt32(parameters[1]);
			int num = Convert.ToInt32(parameters[2]);
			int num2 = Convert.ToInt32(parameters[3]);
			int num3 = Convert.ToInt32(parameters[4]);
			int num4 = 0;
			int num5 = num3 * num;
			for (int i = 0; i < num2; i++)
			{
				num4 += num5;
				num5 /= 4;
			}
			this.FullData = reader.ReadBytes(num4);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x000045A3 File Offset: 0x000027A3
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.FullData);
		}

		// Token: 0x040000AE RID: 174
		public byte[] FullData;
	}
}
