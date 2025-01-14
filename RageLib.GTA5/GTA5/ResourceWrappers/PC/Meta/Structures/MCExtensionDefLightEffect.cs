using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001AC RID: 428
	public class MCExtensionDefLightEffect : MetaStructureWrapper<CExtensionDefLightEffect>
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x0002F733 File Offset: 0x0002D933
		public MCExtensionDefLightEffect()
		{
			this.MetaName = MetaName.CExtensionDefLightEffect;
			this.MetaStructure = default(CExtensionDefLightEffect);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002F760 File Offset: 0x0002D960
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefLightEffect._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefLightEffect._MetaName);
			mb.AddStructureInfo(MetaName.CLightAttrDef);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x0002F7AC File Offset: 0x0002D9AC
		public override void Parse(MetaFile meta, CExtensionDefLightEffect CExtensionDefLightEffect)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefLightEffect;
			this.Name = CExtensionDefLightEffect.name;
			this.OffsetPosition = CExtensionDefLightEffect.offsetPosition;
			CLightAttrDef[] array = MetaUtils.ConvertDataArray<CLightAttrDef>(meta, CExtensionDefLightEffect.instances);
			this.Instances = ((array != null) ? array.Select(delegate(CLightAttrDef e)
			{
				MCLightAttrDef mclightAttrDef = new MCLightAttrDef();
				mclightAttrDef.Parse(meta, e);
				return mclightAttrDef;
			}).ToList<MCLightAttrDef>() : null);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x0002F828 File Offset: 0x0002DA28
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			if (this.Instances != null)
			{
				this.MetaStructure.instances = mb.AddItemArrayPtr<CLightAttrDef>(MetaName.CLightAttrDef, this.Instances.Select(delegate(MCLightAttrDef e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<CLightAttrDef>());
			}
			MCLightAttrDef.AddEnumAndStructureInfo(mb);
			MCExtensionDefLightEffect.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefLightEffect>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003799 RID: 14233
		public static MetaName _MetaName = MetaName.CExtensionDefLightEffect;

		// Token: 0x0400379A RID: 14234
		public MetaFile Meta;

		// Token: 0x0400379B RID: 14235
		public uint Name;

		// Token: 0x0400379C RID: 14236
		public Vector3 OffsetPosition;

		// Token: 0x0400379D RID: 14237
		public List<MCLightAttrDef> Instances = new List<MCLightAttrDef>();
	}
}
