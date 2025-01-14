using System;

namespace RageLib.Resources.GTA5.PC.Clips
{
	// Token: 0x02000158 RID: 344
	public class PropertyAttribute : ResourceSystemBlock, IResourceXXSystemBlock, IResourceSystemBlock, IResourceBlock
	{
		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000549 RID: 1353 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x0600054A RID: 1354 RVA: 0x00024D9C File Offset: 0x00022F9C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Type = reader.ReadByte();
			this.Unknown_9h = reader.ReadByte();
			this.Unknown_Ah = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.NameHash = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
		}

		// Token: 0x0600054B RID: 1355 RVA: 0x00024E24 File Offset: 0x00023024
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Type);
			writer.Write(this.Unknown_9h);
			writer.Write(this.Unknown_Ah);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.NameHash);
			writer.Write(this.Unknown_1Ch);
		}

		// Token: 0x0600054C RID: 1356 RVA: 0x00024EAC File Offset: 0x000230AC
		public IResourceSystemBlock GetType(ResourceDataReader reader, params object[] parameters)
		{
			reader.Position += 8L;
			byte b = reader.ReadByte();
			reader.Position -= 9L;
			switch (b)
			{
			case 1:
				return new PropertyAttributeFloat();
			case 2:
				return new PropertyAttributeInt();
			case 3:
				return new PropertyAttributeBool();
			case 4:
				return new PropertyAttributeString();
			case 6:
				return new PropertyAttributeVector3();
			case 8:
				return new PropertyAttributeQuaternion();
			case 12:
				return new PropertyAttributeHashString();
			}
			throw new Exception("Unknown attribute type");
		}

		// Token: 0x040035BF RID: 13759
		public uint VFT;

		// Token: 0x040035C0 RID: 13760
		public uint Unknown_4h;

		// Token: 0x040035C1 RID: 13761
		public byte Type;

		// Token: 0x040035C2 RID: 13762
		public byte Unknown_9h;

		// Token: 0x040035C3 RID: 13763
		public ushort Unknown_Ah;

		// Token: 0x040035C4 RID: 13764
		public uint Unknown_Ch;

		// Token: 0x040035C5 RID: 13765
		public uint Unknown_10h;

		// Token: 0x040035C6 RID: 13766
		public uint Unknown_14h;

		// Token: 0x040035C7 RID: 13767
		public uint NameHash;

		// Token: 0x040035C8 RID: 13768
		public uint Unknown_1Ch;
	}
}
