using System;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta.Structures
{
	// Token: 0x020001A8 RID: 424
	public class MCExtensionDefDoor : MetaStructureWrapper<CExtensionDefDoor>
	{
		// Token: 0x060006E8 RID: 1768 RVA: 0x0002F08C File Offset: 0x0002D28C
		public MCExtensionDefDoor()
		{
			this.MetaName = MetaName.CExtensionDefDoor;
			this.MetaStructure = default(CExtensionDefDoor);
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0002F0AC File Offset: 0x0002D2AC
		public static void AddEnumAndStructureInfo(MetaBuilder mb)
		{
			EnumInfo[] structureEnumInfo = MetaInfo.GetStructureEnumInfo(MCExtensionDefDoor._MetaName);
			for (int i = 0; i < structureEnumInfo.Length; i++)
			{
				mb.AddEnumInfo((MetaName)structureEnumInfo[i].EnumNameHash);
			}
			mb.AddStructureInfo(MCExtensionDefDoor._MetaName);
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0002F0EC File Offset: 0x0002D2EC
		public override void Parse(MetaFile meta, CExtensionDefDoor CExtensionDefDoor)
		{
			this.Meta = meta;
			this.MetaStructure = CExtensionDefDoor;
			this.Name = CExtensionDefDoor.name;
			this.OffsetPosition = CExtensionDefDoor.offsetPosition;
			this.EnableLimitAngle = CExtensionDefDoor.enableLimitAngle;
			this.StartsLocked = CExtensionDefDoor.startsLocked;
			this.CanBreak = CExtensionDefDoor.canBreak;
			this.LimitAngle = CExtensionDefDoor.limitAngle;
			this.DoorTargetRatio = CExtensionDefDoor.doorTargetRatio;
			this.AudioHash = CExtensionDefDoor.audioHash;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0002F168 File Offset: 0x0002D368
		public override void Build(MetaBuilder mb, bool isRoot = false)
		{
			this.MetaStructure.name = this.Name;
			this.MetaStructure.offsetPosition = this.OffsetPosition;
			this.MetaStructure.enableLimitAngle = this.EnableLimitAngle;
			this.MetaStructure.startsLocked = this.StartsLocked;
			this.MetaStructure.canBreak = this.CanBreak;
			this.MetaStructure.limitAngle = this.LimitAngle;
			this.MetaStructure.doorTargetRatio = this.DoorTargetRatio;
			this.MetaStructure.audioHash = this.AudioHash;
			MCExtensionDefDoor.AddEnumAndStructureInfo(mb);
			if (isRoot)
			{
				mb.AddItem<CExtensionDefDoor>(this.MetaName, this.MetaStructure);
				this.Meta = mb.GetMeta("");
			}
		}

		// Token: 0x04003772 RID: 14194
		public static MetaName _MetaName = MetaName.CExtensionDefDoor;

		// Token: 0x04003773 RID: 14195
		public MetaFile Meta;

		// Token: 0x04003774 RID: 14196
		public uint Name;

		// Token: 0x04003775 RID: 14197
		public Vector3 OffsetPosition;

		// Token: 0x04003776 RID: 14198
		public byte EnableLimitAngle;

		// Token: 0x04003777 RID: 14199
		public byte StartsLocked;

		// Token: 0x04003778 RID: 14200
		public byte CanBreak;

		// Token: 0x04003779 RID: 14201
		public float LimitAngle;

		// Token: 0x0400377A RID: 14202
		public float DoorTargetRatio;

		// Token: 0x0400377B RID: 14203
		public uint AudioHash;
	}
}
