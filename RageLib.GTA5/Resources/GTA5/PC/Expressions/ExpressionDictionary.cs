using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Expressions
{
	// Token: 0x020000FF RID: 255
	public class ExpressionDictionary : FileBase64_GTA5_pc
	{
		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00002B39 File Offset: 0x00000D39
		public override long Length
		{
			get
			{
				return 64L;
			}
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001B3CC File Offset: 0x000195CC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.ExpressionNameHashes = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Expressions = reader.ReadBlock<ResourcePointerList64<Expression>>(Array.Empty<object>());
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001B434 File Offset: 0x00019634
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.ExpressionNameHashes);
			writer.WriteBlock(this.Expressions);
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x0001B491 File Offset: 0x00019691
		public override IResourceBlock[] GetReferences()
		{
			return new List<IResourceBlock>(base.GetReferences()).ToArray();
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x0001B4A3 File Offset: 0x000196A3
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.ExpressionNameHashes),
				new Tuple<long, IResourceBlock>(48L, this.Expressions)
			};
		}

		// Token: 0x040030D9 RID: 12505
		public uint Unknown_10h;

		// Token: 0x040030DA RID: 12506
		public uint Unknown_14h;

		// Token: 0x040030DB RID: 12507
		public uint Unknown_18h;

		// Token: 0x040030DC RID: 12508
		public uint Unknown_1Ch;

		// Token: 0x040030DD RID: 12509
		public ResourceSimpleList64<uint_r> ExpressionNameHashes;

		// Token: 0x040030DE RID: 12510
		public ResourcePointerList64<Expression> Expressions;
	}
}
