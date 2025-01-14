using System;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000116 RID: 278
	public class VertexData_GTA5_pc : ResourceSystemBlock
	{
		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x0001F2C1 File Offset: 0x0001D4C1
		public override long Length
		{
			get
			{
				byte[] vertexBytes = this.VertexBytes;
				return (long)((vertexBytes != null) ? vertexBytes.Length : 0);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x0001F2D3 File Offset: 0x0001D4D3
		// (set) Token: 0x0600048F RID: 1167 RVA: 0x0001F2DB File Offset: 0x0001D4DB
		public VertexDeclaration info { get; set; }

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x0001F2E4 File Offset: 0x0001D4E4
		// (set) Token: 0x06000491 RID: 1169 RVA: 0x0001F2EC File Offset: 0x0001D4EC
		public object[] Data { get; set; }

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x0001F2F5 File Offset: 0x0001D4F5
		// (set) Token: 0x06000493 RID: 1171 RVA: 0x0001F2FD File Offset: 0x0001D4FD
		public uint[] Types { get; set; }

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x0001F306 File Offset: 0x0001D506
		// (set) Token: 0x06000495 RID: 1173 RVA: 0x0001F30E File Offset: 0x0001D50E
		public VertexType VertexType { get; set; }

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x0001F317 File Offset: 0x0001D517
		// (set) Token: 0x06000497 RID: 1175 RVA: 0x0001F31F File Offset: 0x0001D51F
		public byte[] VertexBytes { get; set; }

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x0001F328 File Offset: 0x0001D528
		// (set) Token: 0x06000499 RID: 1177 RVA: 0x0001F330 File Offset: 0x0001D530
		public int VertexCount { get; set; }

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x0001F339 File Offset: 0x0001D539
		// (set) Token: 0x0600049B RID: 1179 RVA: 0x0001F341 File Offset: 0x0001D541
		public int VertexStride { get; set; }

		// Token: 0x0600049C RID: 1180 RVA: 0x0001F34C File Offset: 0x0001D54C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VertexStride = Convert.ToInt32(parameters[0]);
			this.VertexCount = Convert.ToInt32(parameters[1]);
			this.info = (VertexDeclaration)parameters[2];
			this.VertexType = (VertexType)this.info.Flags;
			this.VertexBytes = reader.ReadBytes(this.VertexCount * this.VertexStride);
			ulong types = this.info.Types;
			if (types != 216172782140612614UL)
			{
				if (types != 216172782140628998UL)
				{
					return;
				}
				if (this.info.Flags == 16473U)
				{
					this.VertexType = (VertexType)2147500121U;
					return;
				}
			}
			else if (this.info.Flags == 89U)
			{
				this.VertexType = (VertexType)2147483737U;
			}
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x0001F416 File Offset: 0x0001D616
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			if (this.VertexBytes != null)
			{
				writer.Write(this.VertexBytes);
			}
		}
	}
}
