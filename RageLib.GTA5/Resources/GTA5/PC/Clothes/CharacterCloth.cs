using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Bounds;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x0200013E RID: 318
	public class CharacterCloth : ResourceSystemBlock
	{
		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00004B19 File Offset: 0x00002D19
		public override long Length
		{
			get
			{
				return 208L;
			}
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00020C14 File Offset: 0x0001EE14
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadBlock<ResourceSimpleList64<Unknown_C_001>>(Array.Empty<object>());
			this.ControllerPointer = reader.ReadUInt64();
			this.BoundPointer = reader.ReadUInt64();
			this.Unknown_30h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.Unknown_80h = reader.ReadUInt32();
			this.Unknown_84h = reader.ReadUInt32();
			this.Unknown_88h = reader.ReadUInt32();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadBlock<ResourceSimpleList64<uint_r>>(Array.Empty<object>());
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.Unknown_B0h = reader.ReadUInt32();
			this.Unknown_B4h = reader.ReadUInt32();
			this.Unknown_B8h = reader.ReadUInt32();
			this.Unknown_BCh = reader.ReadUInt32();
			this.Unknown_C0h = reader.ReadUInt32();
			this.Unknown_C4h = reader.ReadUInt32();
			this.Unknown_C8h = reader.ReadUInt32();
			this.Unknown_CCh = reader.ReadUInt32();
			this.Controller = reader.ReadBlockAt<CharacterClothController>(this.ControllerPointer, Array.Empty<object>());
			this.Bound = reader.ReadBlockAt<Bound>(this.BoundPointer, Array.Empty<object>());
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00020E4C File Offset: 0x0001F04C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.ControllerPointer = (ulong)((this.Controller != null) ? this.Controller.Position : 0L);
			this.BoundPointer = (ulong)((this.Bound != null) ? this.Bound.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.WriteBlock(this.Unknown_10h);
			writer.Write(this.ControllerPointer);
			writer.Write(this.BoundPointer);
			writer.WriteBlock(this.Unknown_30h);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.WriteBlock(this.Unknown_90h);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.Unknown_B0h);
			writer.Write(this.Unknown_B4h);
			writer.Write(this.Unknown_B8h);
			writer.Write(this.Unknown_BCh);
			writer.Write(this.Unknown_C0h);
			writer.Write(this.Unknown_C4h);
			writer.Write(this.Unknown_C8h);
			writer.Write(this.Unknown_CCh);
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00021080 File Offset: 0x0001F280
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.Controller != null)
			{
				list.Add(this.Controller);
			}
			if (this.Bound != null)
			{
				list.Add(this.Bound);
			}
			return list.ToArray();
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x000210C1 File Offset: 0x0001F2C1
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(16L, this.Unknown_10h),
				new Tuple<long, IResourceBlock>(48L, this.Unknown_30h),
				new Tuple<long, IResourceBlock>(144L, this.Unknown_90h)
			};
		}

		// Token: 0x040033BF RID: 13247
		public uint VFT;

		// Token: 0x040033C0 RID: 13248
		public uint Unknown_4h;

		// Token: 0x040033C1 RID: 13249
		public uint Unknown_8h;

		// Token: 0x040033C2 RID: 13250
		public uint Unknown_Ch;

		// Token: 0x040033C3 RID: 13251
		public ResourceSimpleList64<Unknown_C_001> Unknown_10h;

		// Token: 0x040033C4 RID: 13252
		public ulong ControllerPointer;

		// Token: 0x040033C5 RID: 13253
		public ulong BoundPointer;

		// Token: 0x040033C6 RID: 13254
		public ResourceSimpleList64<uint_r> Unknown_30h;

		// Token: 0x040033C7 RID: 13255
		public uint Unknown_40h;

		// Token: 0x040033C8 RID: 13256
		public uint Unknown_44h;

		// Token: 0x040033C9 RID: 13257
		public uint Unknown_48h;

		// Token: 0x040033CA RID: 13258
		public uint Unknown_4Ch;

		// Token: 0x040033CB RID: 13259
		public uint Unknown_50h;

		// Token: 0x040033CC RID: 13260
		public uint Unknown_54h;

		// Token: 0x040033CD RID: 13261
		public uint Unknown_58h;

		// Token: 0x040033CE RID: 13262
		public uint Unknown_5Ch;

		// Token: 0x040033CF RID: 13263
		public uint Unknown_60h;

		// Token: 0x040033D0 RID: 13264
		public uint Unknown_64h;

		// Token: 0x040033D1 RID: 13265
		public uint Unknown_68h;

		// Token: 0x040033D2 RID: 13266
		public uint Unknown_6Ch;

		// Token: 0x040033D3 RID: 13267
		public uint Unknown_70h;

		// Token: 0x040033D4 RID: 13268
		public uint Unknown_74h;

		// Token: 0x040033D5 RID: 13269
		public uint Unknown_78h;

		// Token: 0x040033D6 RID: 13270
		public uint Unknown_7Ch;

		// Token: 0x040033D7 RID: 13271
		public uint Unknown_80h;

		// Token: 0x040033D8 RID: 13272
		public uint Unknown_84h;

		// Token: 0x040033D9 RID: 13273
		public uint Unknown_88h;

		// Token: 0x040033DA RID: 13274
		public uint Unknown_8Ch;

		// Token: 0x040033DB RID: 13275
		public ResourceSimpleList64<uint_r> Unknown_90h;

		// Token: 0x040033DC RID: 13276
		public uint Unknown_A0h;

		// Token: 0x040033DD RID: 13277
		public uint Unknown_A4h;

		// Token: 0x040033DE RID: 13278
		public uint Unknown_A8h;

		// Token: 0x040033DF RID: 13279
		public uint Unknown_ACh;

		// Token: 0x040033E0 RID: 13280
		public uint Unknown_B0h;

		// Token: 0x040033E1 RID: 13281
		public uint Unknown_B4h;

		// Token: 0x040033E2 RID: 13282
		public uint Unknown_B8h;

		// Token: 0x040033E3 RID: 13283
		public uint Unknown_BCh;

		// Token: 0x040033E4 RID: 13284
		public uint Unknown_C0h;

		// Token: 0x040033E5 RID: 13285
		public uint Unknown_C4h;

		// Token: 0x040033E6 RID: 13286
		public uint Unknown_C8h;

		// Token: 0x040033E7 RID: 13287
		public uint Unknown_CCh;

		// Token: 0x040033E8 RID: 13288
		public CharacterClothController Controller;

		// Token: 0x040033E9 RID: 13289
		public Bound Bound;
	}
}
