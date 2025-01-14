using System;
using System.Collections.Generic;
using System.Linq;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B4 RID: 436
	public class MCLODLight : MetaStructureWrapper<CLODLight>
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000724 RID: 1828 RVA: 0x00030BE2 File Offset: 0x0002EDE2
		public List<MVECTOR3> Direction
		{
			get
			{
				return (from e in this.Entries
				select e.Direction).ToList<MVECTOR3>();
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000725 RID: 1829 RVA: 0x00030C13 File Offset: 0x0002EE13
		public List<float> Falloff
		{
			get
			{
				return (from e in this.Entries
				select e.FallOff).ToList<float>();
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00030C44 File Offset: 0x0002EE44
		public List<float> FalloffExponent
		{
			get
			{
				return (from e in this.Entries
				select e.FalloffExponent).ToList<float>();
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000727 RID: 1831 RVA: 0x00030C75 File Offset: 0x0002EE75
		public List<uint> TimeAndStateFlags
		{
			get
			{
				return (from e in this.Entries
				select e.TimeAndStateFlags).ToList<uint>();
			}
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x06000728 RID: 1832 RVA: 0x00030CA6 File Offset: 0x0002EEA6
		public List<uint> Hash
		{
			get
			{
				return (from e in this.Entries
				select e.Hash).ToList<uint>();
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000729 RID: 1833 RVA: 0x00030CD7 File Offset: 0x0002EED7
		public List<byte> ConeInnerAngle
		{
			get
			{
				return (from e in this.Entries
				select e.ConeInnerAngle).ToList<byte>();
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00030D08 File Offset: 0x0002EF08
		public List<byte> ConeOuterAngleOrCapExt
		{
			get
			{
				return (from e in this.Entries
				select e.ConeOuterAngleOrCapExt).ToList<byte>();
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x0600072B RID: 1835 RVA: 0x00030D39 File Offset: 0x0002EF39
		public List<byte> CoronaIntensity
		{
			get
			{
				return (from e in this.Entries
				select e.CoronaIntensity).ToList<byte>();
			}
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00030D6A File Offset: 0x0002EF6A
		public MCLODLight()
		{
			this.MetaName = MetaName.CLODLight;
			this.MetaStructure = default(CLODLight);
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00030D94 File Offset: 0x0002EF94
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCLODLight._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCLODLight._MetaName);
			mb.AddStructureInfo(MetaName.VECTOR3);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00030DE0 File Offset: 0x0002EFE0
		public override void Parse(MetaFile meta, CLODLight CLODLight)
		{
			this.Meta = meta;
			this.MetaStructure = CLODLight;
			VECTOR3[] array = MetaUtils.ConvertDataArray<VECTOR3>(meta, CLODLight.direction);
			List<MVECTOR3> list = (array != null) ? array.Select(delegate(VECTOR3 e)
			{
				MVECTOR3 mvector = new MVECTOR3();
				mvector.Parse(meta, e);
				return mvector;
			}).ToList<MVECTOR3>() : null;
			float[] array2 = MetaUtils.ConvertDataArray<float>(meta, CLODLight.falloff.Pointer, (uint)CLODLight.falloff.Count1).ToArray<float>();
			float[] array3 = MetaUtils.ConvertDataArray<float>(meta, CLODLight.falloffExponent.Pointer, (uint)CLODLight.falloffExponent.Count1).ToArray<float>();
			uint[] array4 = MetaUtils.ConvertDataArray<uint>(meta, CLODLight.timeAndStateFlags.Pointer, (uint)CLODLight.timeAndStateFlags.Count1).ToArray<uint>();
			uint[] array5 = MetaUtils.ConvertDataArray<uint>(meta, CLODLight.hash.Pointer, (uint)CLODLight.hash.Count1).ToArray<uint>();
			byte[] array6 = MetaUtils.ConvertDataArray<byte>(meta, CLODLight.coneInnerAngle.Pointer, (uint)CLODLight.coneInnerAngle.Count1).ToArray<byte>();
			byte[] array7 = MetaUtils.ConvertDataArray<byte>(meta, CLODLight.coneOuterAngleOrCapExt.Pointer, (uint)CLODLight.coneOuterAngleOrCapExt.Count1).ToArray<byte>();
			byte[] array8 = MetaUtils.ConvertDataArray<byte>(meta, CLODLight.coronaIntensity.Pointer, (uint)CLODLight.coronaIntensity.Count1).ToArray<byte>();
			this.Entries.Clear();
			for (int i = 0; i < array5.Length; i++)
			{
				this.Entries.Add(new LODLightEntry
				{
					Direction = list[i],
					FallOff = array2[i],
					FalloffExponent = array3[i],
					TimeAndStateFlags = array4[i],
					Hash = array5[i],
					ConeInnerAngle = array6[i],
					ConeOuterAngleOrCapExt = array7[i],
					CoronaIntensity = array8[i]
				});
			}
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x00030FF8 File Offset: 0x0002F1F8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			if (this.Direction != null)
			{
				this.MetaStructure.direction = mb.AddItemArrayPtr<VECTOR3>(MetaName.VECTOR3, this.Direction.Select(delegate(MVECTOR3 e)
				{
					e.Build(mb, false);
					return e.MetaStructure;
				}).ToArray<VECTOR3>());
			}
			MVECTOR3.AddEnumAndStructureInfo(mb);
			this.MetaStructure.falloff = mb.AddFloatArrayPtr(this.Falloff.ToArray());
			this.MetaStructure.falloffExponent = mb.AddFloatArrayPtr(this.FalloffExponent.ToArray());
			this.MetaStructure.timeAndStateFlags = mb.AddUintArrayPtr(this.TimeAndStateFlags.ToArray());
			this.MetaStructure.hash = mb.AddUintArrayPtr(this.Hash.ToArray());
			this.MetaStructure.coneInnerAngle = mb.AddByteArrayPtr(this.ConeInnerAngle.ToArray());
			this.MetaStructure.coneOuterAngleOrCapExt = mb.AddByteArrayPtr(this.ConeOuterAngleOrCapExt.ToArray());
			this.MetaStructure.coronaIntensity = mb.AddByteArrayPtr(this.CoronaIntensity.ToArray());
			MCLODLight.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CLODLight>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003823 RID: 14371
		public static MetaName _MetaName = MetaName.CLODLight;

		// Token: 0x04003824 RID: 14372
		public MetaFile Meta;

		// Token: 0x04003825 RID: 14373
		public List<LODLightEntry> Entries = new List<LODLightEntry>();
	}
}
