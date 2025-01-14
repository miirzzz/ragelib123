using System;
using System.IO;
using RageLib.Data;
using RageLib.GTA5.PSO;

namespace RageLib.GTA5.PSOWrappers.Data
{
	// Token: 0x0200029D RID: 669
	public class PsoDataReader : DataReader
	{
		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000BB3 RID: 2995 RVA: 0x00084432 File Offset: 0x00082632
		public override long Length
		{
			get
			{
				return (long)this.psoFile.DataMappingSection.Entries[this.CurrentSectionIndex].Length;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x00084455 File Offset: 0x00082655
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0008445D File Offset: 0x0008265D
		public int CurrentSectionIndex { get; private set; }

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000BB6 RID: 2998 RVA: 0x00084466 File Offset: 0x00082666
		// (set) Token: 0x06000BB7 RID: 2999 RVA: 0x0008446E File Offset: 0x0008266E
		public int CurrentSectionHash { get; private set; }

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000BB8 RID: 3000 RVA: 0x00084477 File Offset: 0x00082677
		// (set) Token: 0x06000BB9 RID: 3001 RVA: 0x0008447F File Offset: 0x0008267F
		public override long Position { get; set; }

		// Token: 0x06000BBA RID: 3002 RVA: 0x00084488 File Offset: 0x00082688
		public PsoDataReader(PsoFile psoFile) : base(null, Endianess.BigEndian)
		{
			this.psoFile = psoFile;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0008449C File Offset: 0x0008269C
		protected override byte[] ReadFromStream(int count, bool ignoreEndianess = false)
		{
			MemoryStream memoryStream = new MemoryStream(this.psoFile.DataSection.Data);
			memoryStream.Position = (long)this.psoFile.DataMappingSection.Entries[this.CurrentSectionIndex].Offset;
			memoryStream.Position += this.Position;
			byte[] array = new byte[count];
			memoryStream.Read(array, 0, count);
			this.Position += (long)count;
			if (!ignoreEndianess && base.Endianess == Endianess.BigEndian)
			{
				Array.Reverse(array);
			}
			return array;
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0008452A File Offset: 0x0008272A
		public void SetSectionIndex(int index)
		{
			this.CurrentSectionIndex = index;
			this.CurrentSectionHash = this.psoFile.DataMappingSection.Entries[index].NameHash;
		}

		// Token: 0x04003FF0 RID: 16368
		private readonly PsoFile psoFile;
	}
}
