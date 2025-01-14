using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Expressions
{
	// Token: 0x020000FE RID: 254
	public class Expression : ResourceSystemBlock
	{
		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600041A RID: 1050 RVA: 0x00004243 File Offset: 0x00002443
		public override long Length
		{
			get
			{
				return 144L;
			}
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x0001B0A0 File Offset: 0x000192A0
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadBlock<ResourcePointerList64<Unknown_E_001>>(Array.Empty<object>());
			this.Unknown_30h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_40h = reader.ReadBlock<ResourceSimpleList64<Unknown_E_002>>(Array.Empty<object>());
			this.Unknown_50h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.NamePointer = reader.ReadUInt64();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.len = reader.ReadUInt16();
			this.Unknown_7Ah = reader.ReadUInt16();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Name = reader.ReadBlockAt<string_r>(this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001B1F8 File Offset: 0x000193F8
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.NamePointer = (ulong)((this.Name != null) ? this.Name.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.WriteBlock(this.Unknown_20h);
			writer.WriteBlock(this.Unknown_30h);
			writer.WriteBlock(this.Unknown_40h);
			writer.WriteBlock(this.Unknown_50h);
			writer.Write(this.NamePointer);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.len);
			writer.Write(this.Unknown_7Ah);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x0001B344 File Offset: 0x00019544
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x0001B374 File Offset: 0x00019574
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(32L, this.Unknown_20h),
				new Tuple<long, IResourceBlock>(48L, this.Unknown_30h),
				new Tuple<long, IResourceBlock>(64L, this.Unknown_40h),
				new Tuple<long, IResourceBlock>(80L, this.Unknown_50h)
			};
		}

		// Token: 0x040030C0 RID: 12480
		public uint VFT;

		// Token: 0x040030C1 RID: 12481
		public uint Unknown_4h;

		// Token: 0x040030C2 RID: 12482
		public uint Unknown_8h;

		// Token: 0x040030C3 RID: 12483
		public uint Unknown_Ch;

		// Token: 0x040030C4 RID: 12484
		public uint Unknown_10h;

		// Token: 0x040030C5 RID: 12485
		public uint Unknown_14h;

		// Token: 0x040030C6 RID: 12486
		public uint Unknown_18h;

		// Token: 0x040030C7 RID: 12487
		public uint Unknown_1Ch;

		// Token: 0x040030C8 RID: 12488
		public ResourcePointerList64<Unknown_E_001> Unknown_20h;

		// Token: 0x040030C9 RID: 12489
		public ResourceSimpleList64<uint_r> Unknown_30h;

		// Token: 0x040030CA RID: 12490
		public ResourceSimpleList64<Unknown_E_002> Unknown_40h;

		// Token: 0x040030CB RID: 12491
		public ResourceSimpleList64<uint_r> Unknown_50h;

		// Token: 0x040030CC RID: 12492
		public ulong NamePointer;

		// Token: 0x040030CD RID: 12493
		public uint Unknown_68h;

		// Token: 0x040030CE RID: 12494
		public uint Unknown_6Ch;

		// Token: 0x040030CF RID: 12495
		public uint Unknown_70h;

		// Token: 0x040030D0 RID: 12496
		public uint Unknown_74h;

		// Token: 0x040030D1 RID: 12497
		public ushort len;

		// Token: 0x040030D2 RID: 12498
		public ushort Unknown_7Ah;

		// Token: 0x040030D3 RID: 12499
		public uint Unknown_7Ch;

		// Token: 0x040030D4 RID: 12500
		public uint Unknown_80h;

		// Token: 0x040030D5 RID: 12501
		public uint Unknown_84h;

		// Token: 0x040030D6 RID: 12502
		public uint Unknown_88h;

		// Token: 0x040030D7 RID: 12503
		public uint Unknown_8Ch;

		// Token: 0x040030D8 RID: 12504
		public string_r Name;
	}
}
