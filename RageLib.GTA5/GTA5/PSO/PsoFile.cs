using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using RageLib.Data;
using RageLib.GTA5.ResourceWrappers.PC.PSO;

namespace RageLib.GTA5.PSO
{
	// Token: 0x02000212 RID: 530
	public class PsoFile
	{
		// Token: 0x17000228 RID: 552
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x0003D2FA File Offset: 0x0003B4FA
		// (set) Token: 0x060009CF RID: 2511 RVA: 0x0003D302 File Offset: 0x0003B502
		public PsoDataSection DataSection { get; set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x060009D0 RID: 2512 RVA: 0x0003D30B File Offset: 0x0003B50B
		// (set) Token: 0x060009D1 RID: 2513 RVA: 0x0003D313 File Offset: 0x0003B513
		public PsoDataMappingSection DataMappingSection { get; set; }

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x0003D31C File Offset: 0x0003B51C
		// (set) Token: 0x060009D3 RID: 2515 RVA: 0x0003D324 File Offset: 0x0003B524
		public PsoDefinitionSection DefinitionSection { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060009D4 RID: 2516 RVA: 0x0003D32D File Offset: 0x0003B52D
		// (set) Token: 0x060009D5 RID: 2517 RVA: 0x0003D335 File Offset: 0x0003B535
		public PsoSTRFSection STRFSection { get; set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060009D6 RID: 2518 RVA: 0x0003D33E File Offset: 0x0003B53E
		// (set) Token: 0x060009D7 RID: 2519 RVA: 0x0003D346 File Offset: 0x0003B546
		public PsoSTRSSection STRSSection { get; set; }

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x060009D8 RID: 2520 RVA: 0x0003D34F File Offset: 0x0003B54F
		// (set) Token: 0x060009D9 RID: 2521 RVA: 0x0003D357 File Offset: 0x0003B557
		public PsoPSIGSection PSIGSection { get; set; }

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x060009DA RID: 2522 RVA: 0x0003D360 File Offset: 0x0003B560
		// (set) Token: 0x060009DB RID: 2523 RVA: 0x0003D368 File Offset: 0x0003B568
		public PsoSTRESection STRESection { get; set; }

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x060009DC RID: 2524 RVA: 0x0003D371 File Offset: 0x0003B571
		// (set) Token: 0x060009DD RID: 2525 RVA: 0x0003D379 File Offset: 0x0003B579
		public PsoCHKSSection CHKSSection { get; set; }

		// Token: 0x060009DE RID: 2526 RVA: 0x0003D384 File Offset: 0x0003B584
		public void Load(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				this.Load(fileStream);
			}
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x0003D3BC File Offset: 0x0003B5BC
		public virtual void Load(Stream stream)
		{
			stream.Position = 0L;
			DataReader dataReader = new DataReader(stream, Endianess.BigEndian);
			while (dataReader.Position < dataReader.Length)
			{
				PsoSection psoSection = (PsoSection)dataReader.ReadUInt32();
				int count = dataReader.ReadInt32();
				dataReader.Position -= 8L;
				DataReader reader = new DataReader(new MemoryStream(dataReader.ReadBytes(count)), Endianess.BigEndian);
				if (psoSection <= PsoSection.PSIG)
				{
					if (psoSection <= PsoSection.PMAP)
					{
						if (psoSection != PsoSection.CHKS)
						{
							if (psoSection == PsoSection.PMAP)
							{
								this.DataMappingSection = new PsoDataMappingSection();
								this.DataMappingSection.Read(reader);
							}
						}
						else
						{
							this.CHKSSection = new PsoCHKSSection();
							this.CHKSSection.Read(reader);
						}
					}
					else if (psoSection != PsoSection.PSCH)
					{
						if (psoSection == PsoSection.PSIG)
						{
							this.PSIGSection = new PsoPSIGSection();
							this.PSIGSection.Read(reader);
						}
					}
					else
					{
						this.DefinitionSection = new PsoDefinitionSection();
						this.DefinitionSection.Read(reader);
					}
				}
				else if (psoSection <= PsoSection.STRE)
				{
					if (psoSection != PsoSection.PSIN)
					{
						if (psoSection == PsoSection.STRE)
						{
							this.STRESection = new PsoSTRESection();
							this.STRESection.Read(reader);
						}
					}
					else
					{
						this.DataSection = new PsoDataSection();
						this.DataSection.Read(reader);
					}
				}
				else if (psoSection != PsoSection.STRF)
				{
					if (psoSection == PsoSection.STRS)
					{
						this.STRSSection = new PsoSTRSSection();
						this.STRSSection.Read(reader);
					}
				}
				else
				{
					this.STRFSection = new PsoSTRFSection();
					this.STRFSection.Read(reader);
				}
			}
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x0003D560 File Offset: 0x0003B760
		public void Save(string fileName)
		{
			using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
			{
				this.Save(fileStream);
			}
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x0003D598 File Offset: 0x0003B798
		public virtual void Save(Stream stream)
		{
			DataWriter writer = new DataWriter(stream, Endianess.BigEndian);
			if (this.DataSection != null)
			{
				this.DataSection.Write(writer);
			}
			if (this.DataMappingSection != null)
			{
				this.DataMappingSection.Write(writer);
			}
			if (this.DefinitionSection != null)
			{
				this.DefinitionSection.Write(writer);
			}
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x0003D5EC File Offset: 0x0003B7EC
		public static bool IsPSO(string fileName)
		{
			bool result;
			using (FileStream fileStream = new FileStream(fileName, FileMode.Open))
			{
				result = !PsoFile.IsRBF(fileStream);
			}
			return result;
		}

		// Token: 0x060009E3 RID: 2531 RVA: 0x0003D628 File Offset: 0x0003B828
		public static bool IsPSO(Stream stream)
		{
			return !PsoFile.IsRBF(stream);
		}

		// Token: 0x060009E4 RID: 2532 RVA: 0x0003D633 File Offset: 0x0003B833
		public static bool IsRBF(Stream stream)
		{
			int num = (int)new DataReader(stream, Endianess.BigEndian).ReadUInt32();
			stream.Position = 0L;
			return (num & -256) == 1380075008;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0003D658 File Offset: 0x0003B858
		public PsoDataMappingEntry GetBlock(int id)
		{
			if (this.DataMappingSection == null)
			{
				return null;
			}
			if (this.DataMappingSection.Entries == null)
			{
				return null;
			}
			PsoDataMappingEntry result = null;
			int num = id - 1;
			List<PsoDataMappingEntry> entries = this.DataMappingSection.Entries;
			if (num >= 0 && num < entries.Count)
			{
				result = entries[num];
			}
			return result;
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0003D6A8 File Offset: 0x0003B8A8
		public static explicit operator XmlDocument(PsoFile pso)
		{
			XmlDocument xmlDocument = new XmlDocument();
			string xml = PsoXml.GetXml(pso);
			xmlDocument.LoadXml(xml);
			return xmlDocument;
		}
	}
}
