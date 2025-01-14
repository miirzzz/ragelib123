using System;
using System.Collections.Generic;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000EE RID: 238
	public class ArticulatedBodyType : ResourceSystemBlock
	{
		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00017799 File Offset: 0x00015999
		public override long Length
		{
			get
			{
				return 176L;
			}
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000177A4 File Offset: 0x000159A4
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
			this.Unknown_20h = reader.ReadUInt32();
			this.Unknown_24h = reader.ReadUInt32();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
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
			this.Unknown_60h = reader.ReadUInt32();
			this.Unknown_64h = reader.ReadUInt32();
			this.Unknown_68h = reader.ReadUInt32();
			this.Unknown_6Ch = reader.ReadUInt32();
			this.Unknown_70h = reader.ReadUInt32();
			this.Unknown_74h = reader.ReadUInt32();
			this.JointTypesPointer = reader.ReadUInt64();
			this.p2 = reader.ReadUInt64();
			this.c1 = reader.ReadByte();
			this.JointTypesCount = reader.ReadByte();
			this.Unknown_8Ah = reader.ReadUInt16();
			this.Unknown_8Ch = reader.ReadUInt32();
			this.Unknown_90h = reader.ReadUInt32();
			this.Unknown_94h = reader.ReadUInt32();
			this.Unknown_98h = reader.ReadUInt32();
			this.Unknown_9Ch = reader.ReadUInt32();
			this.Unknown_A0h = reader.ReadUInt32();
			this.Unknown_A4h = reader.ReadUInt32();
			this.Unknown_A8h = reader.ReadUInt32();
			this.Unknown_ACh = reader.ReadUInt32();
			this.JointTypes = reader.ReadBlockAt<ResourcePointerArray64<JointType>>(this.JointTypesPointer, new object[]
			{
				this.JointTypesCount
			});
			this.p2data = reader.ReadBlockAt<ResourceSimpleArray<RAGE_Vector4>>(this.p2, new object[]
			{
				this.c1
			});
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00017A10 File Offset: 0x00015C10
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.JointTypesPointer = (ulong)((this.JointTypes != null) ? this.JointTypes.Position : 0L);
			this.p2 = (ulong)((this.p2data != null) ? this.p2data.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
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
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
			writer.Write(this.Unknown_70h);
			writer.Write(this.Unknown_74h);
			writer.Write(this.JointTypesPointer);
			writer.Write(this.p2);
			writer.Write(this.c1);
			writer.Write(this.JointTypesCount);
			writer.Write(this.Unknown_8Ah);
			writer.Write(this.Unknown_8Ch);
			writer.Write(this.Unknown_90h);
			writer.Write(this.Unknown_94h);
			writer.Write(this.Unknown_98h);
			writer.Write(this.Unknown_9Ch);
			writer.Write(this.Unknown_A0h);
			writer.Write(this.Unknown_A4h);
			writer.Write(this.Unknown_A8h);
			writer.Write(this.Unknown_ACh);
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00017C68 File Offset: 0x00015E68
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.JointTypes != null)
			{
				list.Add(this.JointTypes);
			}
			if (this.p2data != null)
			{
				list.Add(this.p2data);
			}
			return list.ToArray();
		}

		// Token: 0x04002EDE RID: 11998
		public uint VFT;

		// Token: 0x04002EDF RID: 11999
		public uint Unknown_4h;

		// Token: 0x04002EE0 RID: 12000
		public uint Unknown_8h;

		// Token: 0x04002EE1 RID: 12001
		public uint Unknown_Ch;

		// Token: 0x04002EE2 RID: 12002
		public uint Unknown_10h;

		// Token: 0x04002EE3 RID: 12003
		public uint Unknown_14h;

		// Token: 0x04002EE4 RID: 12004
		public uint Unknown_18h;

		// Token: 0x04002EE5 RID: 12005
		public uint Unknown_1Ch;

		// Token: 0x04002EE6 RID: 12006
		public uint Unknown_20h;

		// Token: 0x04002EE7 RID: 12007
		public uint Unknown_24h;

		// Token: 0x04002EE8 RID: 12008
		public uint Unknown_28h;

		// Token: 0x04002EE9 RID: 12009
		public uint Unknown_2Ch;

		// Token: 0x04002EEA RID: 12010
		public uint Unknown_30h;

		// Token: 0x04002EEB RID: 12011
		public uint Unknown_34h;

		// Token: 0x04002EEC RID: 12012
		public uint Unknown_38h;

		// Token: 0x04002EED RID: 12013
		public uint Unknown_3Ch;

		// Token: 0x04002EEE RID: 12014
		public uint Unknown_40h;

		// Token: 0x04002EEF RID: 12015
		public uint Unknown_44h;

		// Token: 0x04002EF0 RID: 12016
		public uint Unknown_48h;

		// Token: 0x04002EF1 RID: 12017
		public uint Unknown_4Ch;

		// Token: 0x04002EF2 RID: 12018
		public uint Unknown_50h;

		// Token: 0x04002EF3 RID: 12019
		public uint Unknown_54h;

		// Token: 0x04002EF4 RID: 12020
		public uint Unknown_58h;

		// Token: 0x04002EF5 RID: 12021
		public uint Unknown_5Ch;

		// Token: 0x04002EF6 RID: 12022
		public uint Unknown_60h;

		// Token: 0x04002EF7 RID: 12023
		public uint Unknown_64h;

		// Token: 0x04002EF8 RID: 12024
		public uint Unknown_68h;

		// Token: 0x04002EF9 RID: 12025
		public uint Unknown_6Ch;

		// Token: 0x04002EFA RID: 12026
		public uint Unknown_70h;

		// Token: 0x04002EFB RID: 12027
		public uint Unknown_74h;

		// Token: 0x04002EFC RID: 12028
		public ulong JointTypesPointer;

		// Token: 0x04002EFD RID: 12029
		public ulong p2;

		// Token: 0x04002EFE RID: 12030
		public byte c1;

		// Token: 0x04002EFF RID: 12031
		public byte JointTypesCount;

		// Token: 0x04002F00 RID: 12032
		public ushort Unknown_8Ah;

		// Token: 0x04002F01 RID: 12033
		public uint Unknown_8Ch;

		// Token: 0x04002F02 RID: 12034
		public uint Unknown_90h;

		// Token: 0x04002F03 RID: 12035
		public uint Unknown_94h;

		// Token: 0x04002F04 RID: 12036
		public uint Unknown_98h;

		// Token: 0x04002F05 RID: 12037
		public uint Unknown_9Ch;

		// Token: 0x04002F06 RID: 12038
		public uint Unknown_A0h;

		// Token: 0x04002F07 RID: 12039
		public uint Unknown_A4h;

		// Token: 0x04002F08 RID: 12040
		public uint Unknown_A8h;

		// Token: 0x04002F09 RID: 12041
		public uint Unknown_ACh;

		// Token: 0x04002F0A RID: 12042
		public ResourcePointerArray64<JointType> JointTypes;

		// Token: 0x04002F0B RID: 12043
		public ResourceSimpleArray<RAGE_Vector4> p2data;
	}
}
