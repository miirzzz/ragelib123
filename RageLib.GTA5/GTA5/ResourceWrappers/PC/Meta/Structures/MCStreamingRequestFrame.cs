using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001CA RID: 458
	public class MCStreamingRequestFrame : MetaStructureWrapper<CStreamingRequestFrame>
	{
		// Token: 0x060007A6 RID: 1958 RVA: 0x00034BE9 File Offset: 0x00032DE9
		public MCStreamingRequestFrame()
		{
			this.MetaName = MetaName.CStreamingRequestFrame;
			this.MetaStructure = default(CStreamingRequestFrame);
		}

		// Token: 0x060007A7 RID: 1959 RVA: 0x00034C08 File Offset: 0x00032E08
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCStreamingRequestFrame._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCStreamingRequestFrame._MetaName);
		}

		// Token: 0x060007A8 RID: 1960 RVA: 0x00034C47 File Offset: 0x00032E47
		public override void Parse(MetaFile meta, CStreamingRequestFrame CStreamingRequestFrame)
		{
			this.Meta = meta;
			this.MetaStructure = CStreamingRequestFrame;
			this.CamPos = CStreamingRequestFrame.CamPos;
			this.CamDir = CStreamingRequestFrame.CamDir;
			this.Flags = CStreamingRequestFrame.Flags;
		}

		// Token: 0x060007A9 RID: 1961 RVA: 0x00034C7C File Offset: 0x00032E7C
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.CamPos = this.CamPos;
			this.MetaStructure.CamDir = this.CamDir;
			this.MetaStructure.Flags = this.Flags;
			MCStreamingRequestFrame.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CStreamingRequestFrame>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x0400390C RID: 14604
		public static MetaName _MetaName = MetaName.CStreamingRequestFrame;

		// Token: 0x0400390D RID: 14605
		public MetaFile Meta;

		// Token: 0x0400390E RID: 14606
		public Array_uint AddList;

		// Token: 0x0400390F RID: 14607
		public Array_uint RemoveList;

		// Token: 0x04003910 RID: 14608
		public Vector3 CamPos;

		// Token: 0x04003911 RID: 14609
		public Vector3 CamDir;

		// Token: 0x04003912 RID: 14610
		public Array_byte Unk_1762439591;

		// Token: 0x04003913 RID: 14611
		public uint Flags;
	}
}
