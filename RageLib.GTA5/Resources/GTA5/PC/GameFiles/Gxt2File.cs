using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace RageLib.Resources.GTA5.PC.GameFiles
{
	// Token: 0x020000E4 RID: 228
	public class Gxt2File : GameFileBase
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00016E0C File Offset: 0x0001500C
		public override void Parse(object[] parameters = null)
		{
			using (BinaryReader binaryReader = new BinaryReader(this.Stream))
			{
				if (binaryReader.ReadUInt32() == 1196971058U)
				{
					this.EntryCount = binaryReader.ReadUInt32();
					this.TextEntries = new List<Gxt2Entry>();
					for (uint num = 0U; num < this.EntryCount; num += 1U)
					{
						Gxt2Entry gxt2Entry = new Gxt2Entry();
						gxt2Entry.Hash = binaryReader.ReadUInt32();
						gxt2Entry.Offset = binaryReader.ReadUInt32();
						this.TextEntries.Add(gxt2Entry);
					}
					if (binaryReader.ReadUInt32() == 1196971058U)
					{
						uint num2 = binaryReader.ReadUInt32();
						List<byte> list = new List<byte>();
						for (uint num3 = 0U; num3 < this.EntryCount; num3 += 1U)
						{
							Gxt2Entry gxt2Entry2 = this.TextEntries[(int)num3];
							binaryReader.BaseStream.Position = (long)((ulong)gxt2Entry2.Offset);
							list.Clear();
							byte b = binaryReader.ReadByte();
							while (b != 0 && binaryReader.BaseStream.Position < (long)((ulong)num2))
							{
								list.Add(b);
								b = binaryReader.ReadByte();
							}
							gxt2Entry2.Text = Encoding.UTF8.GetString(list.ToArray());
						}
					}
				}
			}
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00016F58 File Offset: 0x00015158
		public override void Build(object[] parameters = null)
		{
		}

		// Token: 0x04002EB1 RID: 11953
		public uint EntryCount;

		// Token: 0x04002EB2 RID: 11954
		public List<Gxt2Entry> TextEntries = new List<Gxt2Entry>();
	}
}
