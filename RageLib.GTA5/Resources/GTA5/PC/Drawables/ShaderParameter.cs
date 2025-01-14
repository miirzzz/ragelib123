using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x02000111 RID: 273
	public class ShaderParameter : ResourceSystemBlock
	{
		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x000027AD File Offset: 0x000009AD
		public override long Length
		{
			get
			{
				return 16L;
			}
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x0001E785 File Offset: 0x0001C985
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.DataType = reader.ReadByte();
			this.Unknown_1h = reader.ReadByte();
			this.Unknown_2h = reader.ReadUInt16();
			this.Unknown_4h = reader.ReadUInt32();
			this.DataPointer = reader.ReadUInt64();
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001E7C3 File Offset: 0x0001C9C3
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.DataType);
			writer.Write(this.Unknown_1h);
			writer.Write(this.Unknown_2h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.DataPointer);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001E804 File Offset: 0x0001CA04
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Data != null)
			{
				list.Add(this.Data);
			}
			return list.ToArray();
		}

		// Token: 0x0400325B RID: 12891
		public byte DataType;

		// Token: 0x0400325C RID: 12892
		public byte Unknown_1h;

		// Token: 0x0400325D RID: 12893
		public ushort Unknown_2h;

		// Token: 0x0400325E RID: 12894
		public uint Unknown_4h;

		// Token: 0x0400325F RID: 12895
		public ulong DataPointer;

		// Token: 0x04003260 RID: 12896
		public IResourceBlock Data;
	}
}
