using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001B0 RID: 432
	public class MCExtensionDefSpawnPoint : MetaStructureWrapper<CExtensionDefSpawnPoint>
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x00030093 File Offset: 0x0002E293
		public MCExtensionDefSpawnPoint()
		{
			this.MetaName = MetaName.CExtensionDefSpawnPoint;
			this.MetaStructure = default(CExtensionDefSpawnPoint);
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x000300B4 File Offset: 0x0002E2B4
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefSpawnPoint._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefSpawnPoint._MetaName);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000300F4 File Offset: 0x0002E2F4
		public override void Parse(MetaFile meta, CExtensionDefSpawnPoint CExtensionDefSpawnPoint)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefSpawnPoint;
			this.Name = CExtensionDefSpawnPoint.name;
			this.OffsetPosition = CExtensionDefSpawnPoint.offsetPosition;
			this.OffsetRotation = CExtensionDefSpawnPoint.offsetRotation;
			this.SpawnType = CExtensionDefSpawnPoint.spawnType;
			this.PedType = CExtensionDefSpawnPoint.pedType;
			this.Group = CExtensionDefSpawnPoint.group;
			this.Interior = CExtensionDefSpawnPoint.interior;
			this.RequiredImap = CExtensionDefSpawnPoint.requiredImap;
			this.AvailableInMpSp = CExtensionDefSpawnPoint.availableInMpSp;
			this.Probability = CExtensionDefSpawnPoint.probability;
			this.TimeTillPedLeaves = CExtensionDefSpawnPoint.timeTillPedLeaves;
			this.Radius = CExtensionDefSpawnPoint.radius;
			this.Start = CExtensionDefSpawnPoint.start;
			this.End = CExtensionDefSpawnPoint.end;
			this.Flags = CExtensionDefSpawnPoint.flags;
			this.HighPri = CExtensionDefSpawnPoint.highPri;
			this.ExtendedRange = CExtensionDefSpawnPoint.extendedRange;
			this.ShortRange = CExtensionDefSpawnPoint.shortRange;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x000301E8 File Offset: 0x0002E3E8
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.offsetRotation = this.OffsetRotation;
			this.MetaStructure.spawnType = this.SpawnType;
			this.MetaStructure.pedType = this.PedType;
			this.MetaStructure.group = this.Group;
			this.MetaStructure.interior = this.Interior;
			this.MetaStructure.requiredImap = this.RequiredImap;
			this.MetaStructure.availableInMpSp = this.AvailableInMpSp;
			this.MetaStructure.probability = this.Probability;
			this.MetaStructure.timeTillPedLeaves = this.TimeTillPedLeaves;
			this.MetaStructure.radius = this.Radius;
			this.MetaStructure.start = this.Start;
			this.MetaStructure.end = this.End;
			this.MetaStructure.flags = this.Flags;
			this.MetaStructure.highPri = this.HighPri;
			this.MetaStructure.extendedRange = this.ExtendedRange;
			this.MetaStructure.shortRange = this.ShortRange;
			MCExtensionDefSpawnPoint.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefSpawnPoint>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x040037D2 RID: 14290
		public static MetaName _MetaName = MetaName.CExtensionDefSpawnPoint;

		// Token: 0x040037D3 RID: 14291
		public MetaFile Meta;

		// Token: 0x040037D4 RID: 14292
		public uint Name;

		// Token: 0x040037D5 RID: 14293
		public Vector3 OffsetPosition;

		// Token: 0x040037D6 RID: 14294
		public Vector4 OffsetRotation;

		// Token: 0x040037D7 RID: 14295
		public uint SpawnType;

		// Token: 0x040037D8 RID: 14296
		public uint PedType;

		// Token: 0x040037D9 RID: 14297
		public uint Group;

		// Token: 0x040037DA RID: 14298
		public uint Interior;

		// Token: 0x040037DB RID: 14299
		public uint RequiredImap;

		// Token: 0x040037DC RID: 14300
		public Unk_3573596290 AvailableInMpSp;

		// Token: 0x040037DD RID: 14301
		public float Probability;

		// Token: 0x040037DE RID: 14302
		public float TimeTillPedLeaves;

		// Token: 0x040037DF RID: 14303
		public float Radius;

		// Token: 0x040037E0 RID: 14304
		public byte Start;

		// Token: 0x040037E1 RID: 14305
		public byte End;

		// Token: 0x040037E2 RID: 14306
		public Unk_700327466 Flags;

		// Token: 0x040037E3 RID: 14307
		public byte HighPri;

		// Token: 0x040037E4 RID: 14308
		public byte ExtendedRange;

		// Token: 0x040037E5 RID: 14309
		public byte ShortRange;
	}
}
