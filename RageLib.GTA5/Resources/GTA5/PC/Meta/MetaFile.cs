using System;
using System.Collections.Generic;
using System.Xml;
using RageLib.GTA5.ResourceWrappers.PC.Meta;
using RageLib.Resources.Common;

namespace RageLib.Resources.GTA5.PC.Meta
{
	// Token: 0x0200007F RID: 127
	public class MetaFile : FileBase64_GTA5_pc
	{
		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600030D RID: 781 RVA: 0x000067F5 File Offset: 0x000049F5
		public override long Length
		{
			get
			{
				return 112L;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0000F797 File Offset: 0x0000D997
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0000F79F File Offset: 0x0000D99F
		public int Unknown_10h { get; set; } = 1347568688;

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		public short Unknown_14h { get; set; } = 121;

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0000F7B9 File Offset: 0x0000D9B9
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0000F7C1 File Offset: 0x0000D9C1
		public byte HasUselessData { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0000F7CA File Offset: 0x0000D9CA
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0000F7D2 File Offset: 0x0000D9D2
		public byte Unknown_17h { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0000F7DB File Offset: 0x0000D9DB
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0000F7E3 File Offset: 0x0000D9E3
		public int Unknown_18h { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		public int RootBlockIndex { get; set; }

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F7FD File Offset: 0x0000D9FD
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0000F805 File Offset: 0x0000DA05
		public long StructureInfosPointer { get; private set; }

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0000F80E File Offset: 0x0000DA0E
		// (set) Token: 0x0600031D RID: 797 RVA: 0x0000F816 File Offset: 0x0000DA16
		public long EnumInfosPointer { get; private set; }

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F81F File Offset: 0x0000DA1F
		// (set) Token: 0x0600031F RID: 799 RVA: 0x0000F827 File Offset: 0x0000DA27
		public long DataBlocksPointer { get; private set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0000F830 File Offset: 0x0000DA30
		// (set) Token: 0x06000321 RID: 801 RVA: 0x0000F838 File Offset: 0x0000DA38
		public long NamePointer { get; private set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0000F841 File Offset: 0x0000DA41
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0000F849 File Offset: 0x0000DA49
		public long UselessPointer { get; private set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000F852 File Offset: 0x0000DA52
		// (set) Token: 0x06000325 RID: 805 RVA: 0x0000F85A File Offset: 0x0000DA5A
		public short StructureInfosCount { get; set; }

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000F863 File Offset: 0x0000DA63
		// (set) Token: 0x06000327 RID: 807 RVA: 0x0000F86B File Offset: 0x0000DA6B
		public short EnumInfosCount { get; set; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000F874 File Offset: 0x0000DA74
		// (set) Token: 0x06000329 RID: 809 RVA: 0x0000F87C File Offset: 0x0000DA7C
		public short DataBlocksCount { get; set; }

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0000F885 File Offset: 0x0000DA85
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0000F88D File Offset: 0x0000DA8D
		public short Unknown_4Eh { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0000F896 File Offset: 0x0000DA96
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0000F89E File Offset: 0x0000DA9E
		public int Unknown_50h { get; set; }

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000F8A7 File Offset: 0x0000DAA7
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0000F8AF File Offset: 0x0000DAAF
		public int Unknown_54h { get; set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0000F8C0 File Offset: 0x0000DAC0
		public int Unknown_58h { get; set; }

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0000F8C9 File Offset: 0x0000DAC9
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0000F8D1 File Offset: 0x0000DAD1
		public int Unknown_5Ch { get; set; }

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000334 RID: 820 RVA: 0x0000F8DA File Offset: 0x0000DADA
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0000F8E2 File Offset: 0x0000DAE2
		public int Unknown_60h { get; set; }

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0000F8EB File Offset: 0x0000DAEB
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0000F8F3 File Offset: 0x0000DAF3
		public int Unknown_64h { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0000F904 File Offset: 0x0000DB04
		public int Unknown_68h { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0000F90D File Offset: 0x0000DB0D
		// (set) Token: 0x0600033B RID: 827 RVA: 0x0000F915 File Offset: 0x0000DB15
		public int Unknown_6Ch { get; set; }

		// Token: 0x0600033C RID: 828 RVA: 0x0000F920 File Offset: 0x0000DB20
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			base.Read(reader, parameters);
			this.Unknown_10h = reader.ReadInt32();
			this.Unknown_14h = reader.ReadInt16();
			this.HasUselessData = reader.ReadByte();
			this.Unknown_17h = reader.ReadByte();
			this.Unknown_18h = reader.ReadInt32();
			this.RootBlockIndex = reader.ReadInt32();
			this.StructureInfosPointer = reader.ReadInt64();
			this.EnumInfosPointer = reader.ReadInt64();
			this.DataBlocksPointer = reader.ReadInt64();
			this.NamePointer = reader.ReadInt64();
			this.UselessPointer = reader.ReadInt64();
			this.StructureInfosCount = reader.ReadInt16();
			this.EnumInfosCount = reader.ReadInt16();
			this.DataBlocksCount = reader.ReadInt16();
			this.Unknown_4Eh = reader.ReadInt16();
			this.Unknown_50h = reader.ReadInt32();
			this.Unknown_54h = reader.ReadInt32();
			this.Unknown_58h = reader.ReadInt32();
			this.Unknown_5Ch = reader.ReadInt32();
			this.Unknown_60h = reader.ReadInt32();
			this.Unknown_64h = reader.ReadInt32();
			this.Unknown_68h = reader.ReadInt32();
			this.Unknown_6Ch = reader.ReadInt32();
			this.StructureInfos = reader.ReadBlockAt<ResourceSimpleArray<StructureInfo>>((ulong)this.StructureInfosPointer, new object[]
			{
				this.StructureInfosCount
			});
			this.EnumInfos = reader.ReadBlockAt<ResourceSimpleArray<EnumInfo>>((ulong)this.EnumInfosPointer, new object[]
			{
				this.EnumInfosCount
			});
			this.DataBlocks = reader.ReadBlockAt<ResourceSimpleArray<DataBlock>>((ulong)this.DataBlocksPointer, new object[]
			{
				this.DataBlocksCount
			});
			this.Name = reader.ReadBlockAt<string_r>((ulong)this.NamePointer, Array.Empty<object>());
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000FAD4 File Offset: 0x0000DCD4
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			base.Write(writer, parameters);
			ResourceSimpleArray<StructureInfo> structureInfos = this.StructureInfos;
			this.StructureInfosPointer = ((structureInfos != null) ? structureInfos.Position : 0L);
			ResourceSimpleArray<EnumInfo> enumInfos = this.EnumInfos;
			this.EnumInfosPointer = ((enumInfos != null) ? enumInfos.Position : 0L);
			ResourceSimpleArray<DataBlock> dataBlocks = this.DataBlocks;
			this.DataBlocksPointer = ((dataBlocks != null) ? dataBlocks.Position : 0L);
			string_r name = this.Name;
			this.NamePointer = ((name != null) ? name.Position : 0L);
			this.UselessPointer = 0L;
			ResourceSimpleArray<StructureInfo> structureInfos2 = this.StructureInfos;
			this.StructureInfosCount = (short)((structureInfos2 != null) ? structureInfos2.Count : 0);
			ResourceSimpleArray<EnumInfo> enumInfos2 = this.EnumInfos;
			this.EnumInfosCount = (short)((enumInfos2 != null) ? enumInfos2.Count : 0);
			ResourceSimpleArray<DataBlock> dataBlocks2 = this.DataBlocks;
			this.DataBlocksCount = (short)((dataBlocks2 != null) ? dataBlocks2.Count : 0);
			writer.Write(this.Unknown_10h);
			writer.Write(this.Unknown_14h);
			writer.Write(this.HasUselessData);
			writer.Write(this.Unknown_17h);
			writer.Write(this.Unknown_18h);
			writer.Write(this.RootBlockIndex);
			writer.Write(this.StructureInfosPointer);
			writer.Write(this.EnumInfosPointer);
			writer.Write(this.DataBlocksPointer);
			writer.Write(this.NamePointer);
			writer.Write(this.UselessPointer);
			writer.Write(this.StructureInfosCount);
			writer.Write(this.EnumInfosCount);
			writer.Write(this.DataBlocksCount);
			writer.Write(this.Unknown_4Eh);
			writer.Write(this.Unknown_50h);
			writer.Write(this.Unknown_54h);
			writer.Write(this.Unknown_58h);
			writer.Write(this.Unknown_5Ch);
			writer.Write(this.Unknown_60h);
			writer.Write(this.Unknown_64h);
			writer.Write(this.Unknown_68h);
			writer.Write(this.Unknown_6Ch);
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000FCB4 File Offset: 0x0000DEB4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>(base.GetReferences());
			if (this.StructureInfos != null)
			{
				list.Add(this.StructureInfos);
			}
			if (this.EnumInfos != null)
			{
				list.Add(this.EnumInfos);
			}
			if (this.DataBlocks != null)
			{
				list.Add(this.DataBlocks);
			}
			if (this.Name != null)
			{
				list.Add(this.Name);
			}
			return list.ToArray();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000FD24 File Offset: 0x0000DF24
		public DataBlock[] FindBlocks(MetaName name)
		{
			List<DataBlock> list = new List<DataBlock>();
			for (int i = 0; i < this.DataBlocks.Count; i++)
			{
				if (this.DataBlocks[i].StructureNameHash == name)
				{
					list.Add(this.DataBlocks[i]);
				}
			}
			return list.ToArray();
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000FD7C File Offset: 0x0000DF7C
		public DataBlock GetRootBlock()
		{
			DataBlock result = null;
			int num = this.RootBlockIndex - 1;
			if (num >= 0 && num < this.DataBlocks.Count && this.DataBlocks.Data != null)
			{
				result = this.DataBlocks[num];
			}
			return result;
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		public DataBlock GetRootBlock(MetaName name)
		{
			DataBlock result = null;
			int num = this.RootBlockIndex - 1;
			if (num >= 0 && num < this.DataBlocks.Count && this.DataBlocks.Data != null)
			{
				result = this.DataBlocks[num];
			}
			return result;
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000FE0C File Offset: 0x0000E00C
		public DataBlock GetBlock(int id)
		{
			DataBlock result = null;
			int num = id - 1;
			if (num >= 0 && num < this.DataBlocks.Count && this.DataBlocks.Data != null)
			{
				result = this.DataBlocks[num];
			}
			return result;
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public static explicit operator XmlDocument(MetaFile meta)
		{
			XmlDocument xmlDocument = new XmlDocument();
			string xml = MetaXml.GetXml(meta);
			xmlDocument.LoadXml(xml);
			return xmlDocument;
		}

		// Token: 0x040005B1 RID: 1457
		public ResourceSimpleArray<StructureInfo> StructureInfos;

		// Token: 0x040005B2 RID: 1458
		public ResourceSimpleArray<EnumInfo> EnumInfos;

		// Token: 0x040005B3 RID: 1459
		public ResourceSimpleArray<DataBlock> DataBlocks;

		// Token: 0x040005B4 RID: 1460
		public string_r Name;
	}
}
