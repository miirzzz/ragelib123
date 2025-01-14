using System;
using System.Collections.Generic;
using RageLib.Resources.Common;
using RageLib.Resources.GTA5.PC.Fragments;

namespace RageLib.Resources.GTA5.PC.Clothes
{
	// Token: 0x02000145 RID: 325
	public class EnvironmentCloth : ResourceSystemBlock
	{
		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x0001EE55 File Offset: 0x0001D055
		public override long Length
		{
			get
			{
				return 128L;
			}
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x000220A8 File Offset: 0x000202A8
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.InstanceTuningPointer = reader.ReadUInt64();
			this.DrawablePointer = reader.ReadUInt64();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.ControllerPointer = reader.ReadUInt64();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadUInt32();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadUInt32();
			this.Unknown_54h = reader.ReadUInt32();
			this.Unknown_58h = reader.ReadUInt32();
			this.Unknown_5Ch = reader.ReadUInt32();
			this.pxxxxx_2 = reader.ReadUInt64();
			this.cntxx51a = reader.ReadUInt16();
			this.cntxx51b = reader.ReadUInt16();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.Unknown_78h = reader.ReadUInt32();
			this.Unknown_7Ch = reader.ReadUInt32();
			this.InstanceTuning = reader.ReadBlockAt<ClothInstanceTuning>(this.InstanceTuningPointer, Array.Empty<object>());
			this.Drawable = reader.ReadBlockAt<FragDrawable>(this.DrawablePointer, Array.Empty<object>());
			this.Controller = reader.ReadBlockAt<ClothController>(this.ControllerPointer, Array.Empty<object>());
			this.pxxxxx_2data = reader.ReadBlockAt<ResourceSimpleArray<uint_r>>(this.pxxxxx_2, new object[]
			{
				this.cntxx51a
			});
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0002227C File Offset: 0x0002047C
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.InstanceTuningPointer = (ulong)((this.InstanceTuning != null) ? this.InstanceTuning.Position : 0L);
			this.DrawablePointer = (ulong)((this.Drawable != null) ? this.Drawable.Position : 0L);
			this.ControllerPointer = (ulong)((this.Controller != null) ? this.Controller.Position : 0L);
			this.pxxxxx_2 = (ulong)((this.pxxxxx_2data != null) ? this.pxxxxx_2data.Position : 0L);
			this.cntxx51a = (ushort)((this.pxxxxx_2data != null) ? this.pxxxxx_2data.Count : 0);
			this.cntxx51b = (ushort)((this.pxxxxx_2data != null) ? this.pxxxxx_2data.Count : 0);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.InstanceTuningPointer);
			writer.Write(this.DrawablePointer);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.ControllerPointer);
			writer.Write(this.Unknown_30h);
			writer.Write(this.Unknown_34h);
			writer.Write(this.Unknown_38h);
			writer.Write(this.Unknown_3Ch);
			writer.Write(this.Unknown_40h);
			writer.Write(this.Unknown_44h);
			writer.Write(this.Unknown_48h);
			writer.Write(this.Unknown_4Ch);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.pxxxxx_2);
			writer.Write(this.cntxx51a);
			writer.Write(this.cntxx51b);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00022494 File Offset: 0x00020694
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.InstanceTuning != null)
			{
				list.Add(this.InstanceTuning);
			}
			if (this.Drawable != null)
			{
				list.Add(this.Drawable);
			}
			if (this.Controller != null)
			{
				list.Add(this.Controller);
			}
			if (this.pxxxxx_2data != null)
			{
				list.Add(this.pxxxxx_2data);
			}
			return list.ToArray();
		}

		// Token: 0x04003466 RID: 13414
		public uint VFT;

		// Token: 0x04003467 RID: 13415
		public uint Unknown_4h;

		// Token: 0x04003468 RID: 13416
		public uint Unknown_8h;

		// Token: 0x04003469 RID: 13417
		public uint Unknown_Ch;

		// Token: 0x0400346A RID: 13418
		public ulong InstanceTuningPointer;

		// Token: 0x0400346B RID: 13419
		public ulong DrawablePointer;

		// Token: 0x0400346C RID: 13420
		public uint Unknown_20h;

		// Token: 0x0400346D RID: 13421
		public uint Unknown_24h;

		// Token: 0x0400346E RID: 13422
		public ulong ControllerPointer;

		// Token: 0x0400346F RID: 13423
		public uint Unknown_30h;

		// Token: 0x04003470 RID: 13424
		public uint Unknown_34h;

		// Token: 0x04003471 RID: 13425
		public uint Unknown_38h;

		// Token: 0x04003472 RID: 13426
		public uint Unknown_3Ch;

		// Token: 0x04003473 RID: 13427
		public uint Unknown_40h;

		// Token: 0x04003474 RID: 13428
		public uint Unknown_44h;

		// Token: 0x04003475 RID: 13429
		public uint Unknown_48h;

		// Token: 0x04003476 RID: 13430
		public uint Unknown_4Ch;

		// Token: 0x04003477 RID: 13431
		public uint Unknown_50h;

		// Token: 0x04003478 RID: 13432
		public uint Unknown_54h;

		// Token: 0x04003479 RID: 13433
		public uint Unknown_58h;

		// Token: 0x0400347A RID: 13434
		public uint Unknown_5Ch;

		// Token: 0x0400347B RID: 13435
		public ulong pxxxxx_2;

		// Token: 0x0400347C RID: 13436
		public ushort cntxx51a;

		// Token: 0x0400347D RID: 13437
		public ushort cntxx51b;

		// Token: 0x0400347E RID: 13438
		public uint Unknown_6Ch;

		// Token: 0x0400347F RID: 13439
		public uint Unknown_70h;

		// Token: 0x04003480 RID: 13440
		public uint Unknown_74h;

		// Token: 0x04003481 RID: 13441
		public uint Unknown_78h;

		// Token: 0x04003482 RID: 13442
		public uint Unknown_7Ch;

		// Token: 0x04003483 RID: 13443
		public ClothInstanceTuning InstanceTuning;

		// Token: 0x04003484 RID: 13444
		public FragDrawable Drawable;

		// Token: 0x04003485 RID: 13445
		public ClothController Controller;

		// Token: 0x04003486 RID: 13446
		public ResourceSimpleArray<uint_r> pxxxxx_2data;
	}
}
