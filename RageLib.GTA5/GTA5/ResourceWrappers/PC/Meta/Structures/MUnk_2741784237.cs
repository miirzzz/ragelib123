using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001DE RID: 478
	public class MUnk_2741784237 : MetaStructureWrapper<Unk_2741784237>
	{
		// Token: 0x06000809 RID: 2057 RVA: 0x00036998 File Offset: 0x00034B98
		public MUnk_2741784237()
		{
			this.MetaName = MetaName.OccludeModel;
			this.MetaStructure = default(Unk_2741784237);
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000369B8 File Offset: 0x00034BB8
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MUnk_2741784237._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MUnk_2741784237._MetaName);
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000369F8 File Offset: 0x00034BF8
		public override void Parse(MetaFile meta, Unk_2741784237 Unk_2741784237)
		{
			this.Meta = meta;
			this.MetaStructure = Unk_2741784237;
			this.Bmin = Unk_2741784237.bmin;
			this.Bmax = Unk_2741784237.bmax;
			this.DataSize = Unk_2741784237.dataSize;
			this.Verts = Unk_2741784237.verts;
			this.Unk_853977995 = Unk_2741784237.Unk_853977995;
			this.Unk_2337695078 = Unk_2741784237.Unk_2337695078;
			this.Flags = Unk_2741784237.flags;
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00036A68 File Offset: 0x00034C68
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.bmin = this.Bmin;
			this.MetaStructure.bmax = this.Bmax;
			this.MetaStructure.dataSize = this.DataSize;
			this.MetaStructure.verts = this.Verts;
			this.MetaStructure.Unk_853977995 = this.Unk_853977995;
			this.MetaStructure.Unk_2337695078 = this.Unk_2337695078;
			this.MetaStructure.flags = this.Flags;
			MUnk_2741784237.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<Unk_2741784237>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003995 RID: 14741
		public static MetaName _MetaName = MetaName.OccludeModel;

		// Token: 0x04003996 RID: 14742
		public MetaFile Meta;

		// Token: 0x04003997 RID: 14743
		public Vector3 Bmin;

		// Token: 0x04003998 RID: 14744
		public Vector3 Bmax;

		// Token: 0x04003999 RID: 14745
		public uint DataSize;

		// Token: 0x0400399A RID: 14746
		public DataBlockPointer Verts;

		// Token: 0x0400399B RID: 14747
		public ushort Unk_853977995;

		// Token: 0x0400399C RID: 14748
		public ushort Unk_2337695078;

		// Token: 0x0400399D RID: 14749
		public uint Flags;
	}
}
