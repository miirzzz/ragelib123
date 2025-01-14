using System;

namespace RageLib.Resources.GTA5.PC.Drawables
{
	// Token: 0x0200010A RID: 266
	public class JointRotationLimit : ResourceSystemBlock
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000458 RID: 1112 RVA: 0x00004C73 File Offset: 0x00002E73
		public override long Length
		{
			get
			{
				return 192L;
			}
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0001D0CC File Offset: 0x0001B2CC
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Unknown_0h = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.BoneId = reader.ReadUInt16();
			this.Unknown_Ah = reader.ReadUInt16();
			this.Unknown_Ch = reader.ReadUInt32();
			this.Unknown_10h = reader.ReadUInt32();
			this.Unknown_14h = reader.ReadUInt32();
			this.Unknown_18h = reader.ReadUInt32();
			this.Unknown_1Ch = reader.ReadUInt32();
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadSingle();
			this.Unknown_30h = reader.ReadUInt32();
			this.Unknown_34h = reader.ReadUInt32();
			this.Unknown_38h = reader.ReadUInt32();
			this.Unknown_3Ch = reader.ReadUInt32();
			this.Unknown_40h = reader.ReadSingle();
			this.Unknown_44h = reader.ReadUInt32();
			this.Unknown_48h = reader.ReadUInt32();
			this.Unknown_4Ch = reader.ReadUInt32();
			this.Unknown_50h = reader.ReadSingle();
			this.Unknown_54h = reader.ReadSingle();
			this.Unknown_58h = reader.ReadSingle();
			this.MinX = reader.ReadSingle();
			this.MinY = reader.ReadSingle();
			this.MinZ = reader.ReadSingle();
			this.MaxX = reader.ReadSingle();
			this.MaxY = reader.ReadSingle();
			this.MaxZ = reader.ReadSingle();
			this.Unknown_74h = reader.ReadSingle();
			this.Unknown_78h = reader.ReadSingle();
			this.Unknown_7Ch = reader.ReadSingle();
			this.Unknown_80h = reader.ReadSingle();
			this.Unknown_84h = reader.ReadSingle();
			this.Unknown_88h = reader.ReadSingle();
			this.Unknown_8Ch = reader.ReadSingle();
			this.Unknown_90h = reader.ReadSingle();
			this.Unknown_94h = reader.ReadSingle();
			this.Unknown_98h = reader.ReadSingle();
			this.Unknown_9Ch = reader.ReadSingle();
			this.Unknown_A0h = reader.ReadSingle();
			this.Unknown_A4h = reader.ReadSingle();
			this.Unknown_A8h = reader.ReadSingle();
			this.Unknown_ACh = reader.ReadSingle();
			this.Unknown_B0h = reader.ReadSingle();
			this.Unknown_B4h = reader.ReadSingle();
			this.Unknown_B8h = reader.ReadSingle();
			this.Unknown_BCh = reader.ReadUInt32();
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x0001D328 File Offset: 0x0001B528
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Unknown_0h);
			writer.Write(this.Unknown_4h);
			writer.Write(this.BoneId);
			writer.Write(this.Unknown_Ah);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.Unknown_1Ch);
			writer.Write(this.Unknown_20h);
			writer.Write(this.Unknown_24h);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
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
			writer.Write(this.MinX);
			writer.Write(this.MinY);
			writer.Write(this.MinZ);
			writer.Write(this.MaxX);
			writer.Write(this.MaxY);
			writer.Write(this.MaxZ);
			writer.Write(this.Unknown_74h);
			writer.Write(this.Unknown_78h);
			writer.Write(this.Unknown_7Ch);
			writer.Write(this.Unknown_80h);
			writer.Write(this.Unknown_84h);
			writer.Write(this.Unknown_88h);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
			writer.Write(this.Unknown_B0h);
			writer.Write(this.Unknown_B4h);
			writer.Write(this.Unknown_B8h);
			writer.Write(this.Unknown_BCh);
		}

		// Token: 0x040031B2 RID: 12722
		public uint Unknown_0h;

		// Token: 0x040031B3 RID: 12723
		public uint Unknown_4h;

		// Token: 0x040031B4 RID: 12724
		public ushort BoneId;

		// Token: 0x040031B5 RID: 12725
		public ushort Unknown_Ah;

		// Token: 0x040031B6 RID: 12726
		public uint Unknown_Ch;

		// Token: 0x040031B7 RID: 12727
		public uint Unknown_10h;

		// Token: 0x040031B8 RID: 12728
		public uint Unknown_14h;

		// Token: 0x040031B9 RID: 12729
		public uint Unknown_18h;

		// Token: 0x040031BA RID: 12730
		public uint Unknown_1Ch;

		// Token: 0x040031BB RID: 12731
		public uint Unknown_20h;

		// Token: 0x040031BC RID: 12732
		public uint Unknown_24h;

		// Token: 0x040031BD RID: 12733
		public uint Unknown_28h;

		// Token: 0x040031BE RID: 12734
		public float Unknown_2Ch;

		// Token: 0x040031BF RID: 12735
		public uint Unknown_30h;

		// Token: 0x040031C0 RID: 12736
		public uint Unknown_34h;

		// Token: 0x040031C1 RID: 12737
		public uint Unknown_38h;

		// Token: 0x040031C2 RID: 12738
		public uint Unknown_3Ch;

		// Token: 0x040031C3 RID: 12739
		public float Unknown_40h;

		// Token: 0x040031C4 RID: 12740
		public uint Unknown_44h;

		// Token: 0x040031C5 RID: 12741
		public uint Unknown_48h;

		// Token: 0x040031C6 RID: 12742
		public uint Unknown_4Ch;

		// Token: 0x040031C7 RID: 12743
		public float Unknown_50h;

		// Token: 0x040031C8 RID: 12744
		public float Unknown_54h;

		// Token: 0x040031C9 RID: 12745
		public float Unknown_58h;

		// Token: 0x040031CA RID: 12746
		public float MinX;

		// Token: 0x040031CB RID: 12747
		public float MinY;

		// Token: 0x040031CC RID: 12748
		public float MinZ;

		// Token: 0x040031CD RID: 12749
		public float MaxX;

		// Token: 0x040031CE RID: 12750
		public float MaxY;

		// Token: 0x040031CF RID: 12751
		public float MaxZ;

		// Token: 0x040031D0 RID: 12752
		public float Unknown_74h;

		// Token: 0x040031D1 RID: 12753
		public float Unknown_78h;

		// Token: 0x040031D2 RID: 12754
		public float Unknown_7Ch;

		// Token: 0x040031D3 RID: 12755
		public float Unknown_80h;

		// Token: 0x040031D4 RID: 12756
		public float Unknown_84h;

		// Token: 0x040031D5 RID: 12757
		public float Unknown_88h;

		// Token: 0x040031D6 RID: 12758
		public float Unknown_8Ch;

		// Token: 0x040031D7 RID: 12759
		public float Unknown_90h;

		// Token: 0x040031D8 RID: 12760
		public float Unknown_94h;

		// Token: 0x040031D9 RID: 12761
		public float Unknown_98h;

		// Token: 0x040031DA RID: 12762
		public float Unknown_9Ch;

		// Token: 0x040031DB RID: 12763
		public float Unknown_A0h;

		// Token: 0x040031DC RID: 12764
		public float Unknown_A4h;

		// Token: 0x040031DD RID: 12765
		public float Unknown_A8h;

		// Token: 0x040031DE RID: 12766
		public float Unknown_ACh;

		// Token: 0x040031DF RID: 12767
		public float Unknown_B0h;

		// Token: 0x040031E0 RID: 12768
		public float Unknown_B4h;

		// Token: 0x040031E1 RID: 12769
		public float Unknown_B8h;

		// Token: 0x040031E2 RID: 12770
		public uint Unknown_BCh;
	}
}
