using System;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F9 RID: 249
	public class JointType : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x0001A91C File Offset: 0x00018B1C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadByte();
			this.Type = reader.ReadByte();
			this.Unknown_16h = reader.ReadUInt16();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x0001A9A4 File Offset: 0x00018BA4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Type);
			writer.Write(this.Unknown_16h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x0001AA2C File Offset: 0x00018C2C
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 21L;
			byte b = reader.ReadByte();
			reader.Position -= 22L;
			if (b == 0)
			{
				return new Joint1DofType();
			}
			if (b != 1)
			{
				throw new Exception("Unknown type");
			}
			return new Joint3DofType();
		}

		// Token: 0x04003081 RID: 12417
		public uint VFT;

		// Token: 0x04003082 RID: 12418
		public uint Unknown_4h;

		// Token: 0x04003083 RID: 12419
		public uint Unknown_8h;

		// Token: 0x04003084 RID: 12420
		public uint Unknown_Ch;

		// Token: 0x04003085 RID: 12421
		public uint Unknown_10h;

		// Token: 0x04003086 RID: 12422
		public byte Unknown_14h;

		// Token: 0x04003087 RID: 12423
		public byte Type;

		// Token: 0x04003088 RID: 12424
		public ushort Unknown_16h;

		// Token: 0x04003089 RID: 12425
		public uint Unknown_18h;

		// Token: 0x0400308A RID: 12426
		public uint Unknown_1Ch;
	}
}
