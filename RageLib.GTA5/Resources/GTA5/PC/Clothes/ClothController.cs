using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000141 RID: 321
	public class ClothController : ResourceSystemBlock
	{
		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00021850 File Offset: 0x0001FA50
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.BridgeSimGfxPointer = reader.ReadUInt64();
			this.MorphControllerPointer = reader.ReadUInt64();
			this.VerletCloth1Pointer = reader.ReadUInt64();
			this.VerletCloth2Pointer = reader.ReadUInt64();
			this.VerletCloth3Pointer = reader.ReadUInt64();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Type = reader.ReadUInt32();
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
			this.BridgeSimGfx = reader.ReadBlockAt<ClothBridgeSimGfx>(this.BridgeSimGfxPointer, Array.Empty<object>());
			this.MorphController = reader.ReadBlockAt<MorphController>(this.MorphControllerPointer, Array.Empty<object>());
			this.VerletCloth1 = reader.ReadBlockAt<VerletCloth>(this.VerletCloth1Pointer, Array.Empty<object>());
			this.VerletCloth2 = reader.ReadBlockAt<VerletCloth>(this.VerletCloth2Pointer, Array.Empty<object>());
			this.VerletCloth3 = reader.ReadBlockAt<VerletCloth>(this.VerletCloth3Pointer, Array.Empty<object>());
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00021A14 File Offset: 0x0001FC14
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.BridgeSimGfxPointer = (ulong)((this.BridgeSimGfx != null) ? this.BridgeSimGfx.Position : 0L);
			this.MorphControllerPointer = (ulong)((this.MorphController != null) ? this.MorphController.Position : 0L);
			this.VerletCloth1Pointer = (ulong)((this.VerletCloth1 != null) ? this.VerletCloth1.Position : 0L);
			this.VerletCloth2Pointer = (ulong)((this.VerletCloth2 != null) ? this.VerletCloth2.Position : 0L);
			this.VerletCloth3Pointer = (ulong)((this.VerletCloth3 != null) ? this.VerletCloth3.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.BridgeSimGfxPointer);
			writer.Write(this.MorphControllerPointer);
			writer.Write(this.VerletCloth1Pointer);
			writer.Write(this.VerletCloth2Pointer);
			writer.Write(this.VerletCloth3Pointer);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Type);
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
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00021BF8 File Offset: 0x0001FDF8
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.BridgeSimGfx != null)
			{
				list.Add(this.BridgeSimGfx);
			}
			if (this.MorphController != null)
			{
				list.Add(this.MorphController);
			}
			if (this.VerletCloth1 != null)
			{
				list.Add(this.VerletCloth1);
			}
			if (this.VerletCloth2 != null)
			{
				list.Add(this.VerletCloth2);
			}
			if (this.VerletCloth3 != null)
			{
				list.Add(this.VerletCloth3);
			}
			return list.ToArray();
		}

		// Token: 0x04003420 RID: 13344
		public uint VFT;

		// Token: 0x04003421 RID: 13345
		public uint Unknown_4h;

		// Token: 0x04003422 RID: 13346
		public uint Unknown_8h;

		// Token: 0x04003423 RID: 13347
		public uint Unknown_Ch;

		// Token: 0x04003424 RID: 13348
		public ulong BridgeSimGfxPointer;

		// Token: 0x04003425 RID: 13349
		public ulong MorphControllerPointer;

		// Token: 0x04003426 RID: 13350
		public ulong VerletCloth1Pointer;

		// Token: 0x04003427 RID: 13351
		public ulong VerletCloth2Pointer;

		// Token: 0x04003428 RID: 13352
		public ulong VerletCloth3Pointer;

		// Token: 0x04003429 RID: 13353
		public uint Unknown_38h;

		// Token: 0x0400342A RID: 13354
		public uint Unknown_3Ch;

		// Token: 0x0400342B RID: 13355
		public uint Unknown_40h;

		// Token: 0x0400342C RID: 13356
		public uint Unknown_44h;

		// Token: 0x0400342D RID: 13357
		public uint Unknown_48h;

		// Token: 0x0400342E RID: 13358
		public uint Unknown_4Ch;

		// Token: 0x0400342F RID: 13359
		public uint Type;

		// Token: 0x04003430 RID: 13360
		public uint Unknown_54h;

		// Token: 0x04003431 RID: 13361
		public uint Unknown_58h;

		// Token: 0x04003432 RID: 13362
		public uint Unknown_5Ch;

		// Token: 0x04003433 RID: 13363
		public uint Unknown_60h;

		// Token: 0x04003434 RID: 13364
		public uint Unknown_64h;

		// Token: 0x04003435 RID: 13365
		public uint Unknown_68h;

		// Token: 0x04003436 RID: 13366
		public uint Unknown_6Ch;

		// Token: 0x04003437 RID: 13367
		public uint Unknown_70h;

		// Token: 0x04003438 RID: 13368
		public uint Unknown_74h;

		// Token: 0x04003439 RID: 13369
		public uint Unknown_78h;

		// Token: 0x0400343A RID: 13370
		public uint Unknown_7Ch;

		// Token: 0x0400343B RID: 13371
		public ClothBridgeSimGfx BridgeSimGfx;

		// Token: 0x0400343C RID: 13372
		public MorphController MorphController;

		// Token: 0x0400343D RID: 13373
		public VerletCloth VerletCloth1;

		// Token: 0x0400343E RID: 13374
		public VerletCloth VerletCloth2;

		// Token: 0x0400343F RID: 13375
		public VerletCloth VerletCloth3;
	}
}
