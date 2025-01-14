using System;
using System.Collections.Generic;

namespace RageLib.Resources.GTA5.PC.Fragments
{
	// Token: 0x020000F3 RID: 243
	public class FragPhysicsLODGroup : ResourceSystemBlock
	{
		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00002984 File Offset: 0x00000B84
		public override long Length
		{
			get
			{
				return 48L;
			}
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00018B44 File Offset: 0x00016D44
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.VFT = reader.ReadUInt32();
			this.Unknown_4h = reader.ReadUInt32();
			this.Unknown_8h = reader.ReadUInt32();
			this.Unknown_Ch = reader.ReadUInt32();
			this.PhysicsLOD1Pointer = reader.ReadUInt64();
			this.PhysicsLOD2Pointer = reader.ReadUInt64();
			this.PhysicsLOD3Pointer = reader.ReadUInt64();
			this.Unknown_28h = reader.ReadUInt32();
			this.Unknown_2Ch = reader.ReadUInt32();
			this.PhysicsLOD1 = reader.ReadBlockAt<FragPhysicsLOD>(this.PhysicsLOD1Pointer, Array.Empty<object>());
			this.PhysicsLOD2 = reader.ReadBlockAt<FragPhysicsLOD>(this.PhysicsLOD2Pointer, Array.Empty<object>());
			this.PhysicsLOD3 = reader.ReadBlockAt<FragPhysicsLOD>(this.PhysicsLOD3Pointer, Array.Empty<object>());
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x00018C04 File Offset: 0x00016E04
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			this.PhysicsLOD1Pointer = (ulong)((this.PhysicsLOD1 != null) ? this.PhysicsLOD1.Position : 0L);
			this.PhysicsLOD2Pointer = (ulong)((this.PhysicsLOD2 != null) ? this.PhysicsLOD2.Position : 0L);
			this.PhysicsLOD3Pointer = (ulong)((this.PhysicsLOD3 != null) ? this.PhysicsLOD3.Position : 0L);
			writer.Write(this.VFT);
			writer.Write(this.Unknown_4h);
			writer.Write(this.Unknown_8h);
			writer.Write(this.Unknown_Ch);
			writer.Write(this.PhysicsLOD1Pointer);
			writer.Write(this.PhysicsLOD2Pointer);
			writer.Write(this.PhysicsLOD3Pointer);
			writer.Write(this.Unknown_28h);
			writer.Write(this.Unknown_2Ch);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00018CD4 File Offset: 0x00016ED4
		public override IResourceBlock[] GetReferences()
		{
			List<IResourceBlock> list = new List<IResourceBlock>();
			if (this.PhysicsLOD1 != null)
			{
				list.Add(this.PhysicsLOD1);
			}
			if (this.PhysicsLOD2 != null)
			{
				list.Add(this.PhysicsLOD2);
			}
			if (this.PhysicsLOD3 != null)
			{
				list.Add(this.PhysicsLOD3);
			}
			return list.ToArray();
		}

		// Token: 0x04002F74 RID: 12148
		public uint VFT;

		// Token: 0x04002F75 RID: 12149
		public uint Unknown_4h;

		// Token: 0x04002F76 RID: 12150
		public uint Unknown_8h;

		// Token: 0x04002F77 RID: 12151
		public uint Unknown_Ch;

		// Token: 0x04002F78 RID: 12152
		public ulong PhysicsLOD1Pointer;

		// Token: 0x04002F79 RID: 12153
		public ulong PhysicsLOD2Pointer;

		// Token: 0x04002F7A RID: 12154
		public ulong PhysicsLOD3Pointer;

		// Token: 0x04002F7B RID: 12155
		public uint Unknown_28h;

		// Token: 0x04002F7C RID: 12156
		public uint Unknown_2Ch;

		// Token: 0x04002F7D RID: 12157
		public FragPhysicsLOD PhysicsLOD1;

		// Token: 0x04002F7E RID: 12158
		public FragPhysicsLOD PhysicsLOD2;

		// Token: 0x04002F7F RID: 12159
		public FragPhysicsLOD PhysicsLOD3;
	}
}
