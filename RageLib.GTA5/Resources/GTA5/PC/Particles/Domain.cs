using System;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Particles
{
	// Token: 0x02000032 RID: 50
	public class Domain : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600012D RID: 301 RVA: 0x000060C1 File Offset: 0x000042C1
		public override long Length
		{
			get
			{
				return 640L;
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00007164 File Offset: 0x00005364
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadByte();
			this.Unknown_Dh = reader.ReadByte();
			this.Unknown_Eh = reader.ReadUInt16();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.KeyframeProp0 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp1 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp2 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.KeyframeProp3 = reader.ReadBlock<KeyframeProp>(Array.Empty<object>());
			this.Unknown_258h = reader.ReadUInt32();
			this.Unknown_25Ch = reader.ReadUInt32();
			this.KeyframeProps = reader.ReadBlock<ResourcePointerList64<KeyframeProp>>(Array.Empty<object>());
			this.Unknown_270h = reader.ReadUInt32();
			this.Unknown_274h = reader.ReadUInt32();
			this.Unknown_278h = reader.ReadUInt32();
			this.Unknown_27Ch = reader.ReadUInt32();
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00007270 File Offset: 0x00005470
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_Dh);
			writer.Write(this.Unknown_Eh);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.WriteBlock(this.KeyframeProp0);
			writer.WriteBlock(this.KeyframeProp1);
			writer.WriteBlock(this.KeyframeProp2);
			writer.WriteBlock(this.KeyframeProp3);
			writer.Write(this.Unknown_258h);
			writer.Write(this.Unknown_25Ch);
			writer.WriteBlock(this.KeyframeProps);
			writer.Write(this.Unknown_270h);
			writer.Write(this.Unknown_274h);
			writer.Write(this.Unknown_278h);
			writer.Write(this.Unknown_27Ch);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00007364 File Offset: 0x00005564
		public override Tuple<long, IResourceBlock>[] GetParts()
		{
			return new Tuple<long, IResourceBlock>[]
			{
				new Tuple<long, IResourceBlock>(24L, this.KeyframeProp0),
				new Tuple<long, IResourceBlock>(168L, this.KeyframeProp1),
				new Tuple<long, IResourceBlock>(312L, this.KeyframeProp2),
				new Tuple<long, IResourceBlock>(456L, this.KeyframeProp3),
				new Tuple<long, IResourceBlock>(608L, this.KeyframeProps)
			};
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000073D8 File Offset: 0x000055D8
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 12L;
			byte b = reader.ReadByte();
			reader.Position -= 13L;
			switch (b)
			{
			case 0:
				return new DomainBox();
			case 1:
				return new DomainSphere();
			case 2:
				return new DomainCylinder();
			case 3:
				return new DomainAttractor();
			default:
				throw new Exception("Unknown domain type");
			}
		}

		// Token: 0x0400020D RID: 525
		public uint VFT;

		// Token: 0x0400020E RID: 526
		public uint Unknown_4h;

		// Token: 0x0400020F RID: 527
		public uint Unknown_8h;

		// Token: 0x04000210 RID: 528
		public byte Unknown_Ch;

		// Token: 0x04000211 RID: 529
		public byte Unknown_Dh;

		// Token: 0x04000212 RID: 530
		public ushort Unknown_Eh;

		// Token: 0x04000213 RID: 531
		public uint Unknown_10h;

		// Token: 0x04000214 RID: 532
		public uint Unknown_14h;

		// Token: 0x04000215 RID: 533
		public KeyframeProp KeyframeProp0;

		// Token: 0x04000216 RID: 534
		public KeyframeProp KeyframeProp1;

		// Token: 0x04000217 RID: 535
		public KeyframeProp KeyframeProp2;

		// Token: 0x04000218 RID: 536
		public KeyframeProp KeyframeProp3;

		// Token: 0x04000219 RID: 537
		public uint Unknown_258h;

		// Token: 0x0400021A RID: 538
		public uint Unknown_25Ch;

		// Token: 0x0400021B RID: 539
		public ResourcePointerList64<KeyframeProp> KeyframeProps;

		// Token: 0x0400021C RID: 540
		public uint Unknown_270h;

		// Token: 0x0400021D RID: 541
		public uint Unknown_274h;

		// Token: 0x0400021E RID: 542
		public uint Unknown_278h;

		// Token: 0x0400021F RID: 543
		public uint Unknown_27Ch;
	}
}
