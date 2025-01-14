using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x0200015E RID: 350
	public class PropertyAttributeString : PropertyAttribute
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000562 RID: 1378 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0002519C File Offset: 0x0002339C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.ValuePointer = reader.ReadUInt64();
			this.ValueLength1 = reader.ReadUInt16();
			this.ValueLength2 = reader.ReadUInt16();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.Value = reader.ReadBlockAt<string_r>(this.ValuePointer, Array.Empty<object>());
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000251F8 File Offset: 0x000233F8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			this.ValuePointer = (ulong)((this.Value != null) ? this.Value.Position : 0L);
			this.ValueLength1 = (ushort)((this.Value != null) ? this.Value.Value.Length : 0);
			this.ValueLength2 = (ushort)((this.Value != null) ? (this.Value.Value.Length + 1) : 0);
			writer.Write(this.ValuePointer);
			writer.Write(this.ValueLength1);
			writer.Write(this.ValueLength2);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000252A0 File Offset: 0x000234A0
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.Value != null)
			{
				list.Add(this.Value);
			}
			return list.ToArray();
		}

		// Token: 0x040035DD RID: 13789
		public ulong ValuePointer;

		// Token: 0x040035DE RID: 13790
		public ushort ValueLength1;

		// Token: 0x040035DF RID: 13791
		public ushort ValueLength2;

		// Token: 0x040035E0 RID: 13792
		public uint Unknown_2Ch;

		// Token: 0x040035E1 RID: 13793
		public string_r Value;
	}
}
