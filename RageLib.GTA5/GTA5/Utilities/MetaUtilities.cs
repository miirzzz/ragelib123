using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using HtmlAgilityPack;
using RageLib.Archives;
using RageLib.Cryptography;
using RageLib.GTA5.Archives;
using RageLib.GTA5.Cryptography;
using RageLib.GTA5.PSO;
using RageLib.GTA5.Resources.PC;
using RageLib.Hash;
using RageLib.Resources.GTA5;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000184 RID: 388
	public static class MetaUtilities
	{
		// Token: 0x06000607 RID: 1543 RVA: 0x00027C74 File Offset: 0x00025E74
		public static HashSet<int> GetAllHashesFromMetas(string gameDirectoryName)
		{
			HashSet<int> hashSet = new HashSet<int>();
			foreach (int item in MetaUtilities.GetAllHashesFromResourceMetas(gameDirectoryName))
			{
				hashSet.Add(item);
			}
			foreach (int item2 in MetaUtilities.GetAllHashesFromPsoMetas(gameDirectoryName))
			{
				hashSet.Add(item2);
			}
			return hashSet;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x00027D14 File Offset: 0x00025F14
		public static HashSet<int> GetAllHashesFromResourceMetas(string gameDirectoryName)
		{
			HashSet<int> hashes = new HashSet<int>();
			ArchiveUtilities.ForEachResourceFile(gameDirectoryName, delegate(string fullFileName, IArchiveResourceFile file, RageArchiveEncryption7 encryption)
			{
				if (file.Name.EndsWith(ResourceFileTypes_GTA5_pc.Meta.Extension, StringComparison.OrdinalIgnoreCase) || file.Name.EndsWith(ResourceFileTypes_GTA5_pc.Types.Extension, StringComparison.OrdinalIgnoreCase) || file.Name.EndsWith(ResourceFileTypes_GTA5_pc.Maps.Extension, StringComparison.OrdinalIgnoreCase))
				{
					MemoryStream memoryStream = new MemoryStream();
					file.Export(memoryStream);
					memoryStream.Position = 0L;
					ResourceFile_GTA5_pc<MetaFile> resourceFile_GTA5_pc = new ResourceFile_GTA5_pc<MetaFile>();
					resourceFile_GTA5_pc.Load(memoryStream);
					MetaFile resourceData = resourceFile_GTA5_pc.ResourceData;
					if (resourceData.StructureInfos != null)
					{
						foreach (StructureInfo structureInfo in resourceData.StructureInfos)
						{
							hashes.Add(structureInfo.StructureKey);
							hashes.Add(structureInfo.StructureNameHash);
							foreach (StructureEntryInfo structureEntryInfo in structureInfo.Entries)
							{
								if (structureEntryInfo.EntryNameHash != 256)
								{
									hashes.Add(structureEntryInfo.EntryNameHash);
								}
							}
						}
					}
					if (resourceData.EnumInfos != null)
					{
						foreach (EnumInfo enumInfo in resourceData.EnumInfos)
						{
							hashes.Add(enumInfo.EnumKey);
							hashes.Add(enumInfo.EnumNameHash);
							foreach (EnumEntryInfo enumEntryInfo in enumInfo.Entries)
							{
								hashes.Add(enumEntryInfo.EntryNameHash);
							}
						}
					}
					Console.WriteLine(file.Name);
				}
			}, null);
			return hashes;
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x00027D4C File Offset: 0x00025F4C
		public static HashSet<int> GetAllHashesFromPsoMetas(string gameDirectoryName)
		{
			HashSet<int> hashes = new HashSet<int>();
			ArchiveUtilities.ForEachBinaryFile(gameDirectoryName, delegate(string fullFileName, IArchiveBinaryFile file, RageArchiveEncryption7 encryption)
			{
				if (file.Name.EndsWith(".ymf") || file.Name.EndsWith(".ymt"))
				{
					MemoryStream memoryStream = new MemoryStream();
					file.Export(memoryStream);
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Position = 0L;
					memoryStream.Read(array, 0, array.Length);
					if (file.IsEncrypted)
					{
						if (encryption == RageArchiveEncryption7.AES)
						{
							array = AesEncryption.DecryptData(array, GTA5Constants.PC_AES_KEY, 1);
						}
						else
						{
							uint num = (GTA5Hash.CalculateHash(file.Name) + (uint)file.UncompressedSize + 61U) % 101U;
							array = GTA5Crypto.Decrypt(array, GTA5Constants.PC_NG_KEYS[(int)num]);
						}
					}
					if (file.IsCompressed)
					{
						Stream stream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
						byte[] array2 = new byte[file.UncompressedSize];
						stream.Read(array2, 0, (int)file.UncompressedSize);
						array = array2;
					}
					MemoryStream stream2 = new MemoryStream(array);
					if (PsoFile.IsPSO(stream2))
					{
						PsoFile psoFile = new PsoFile();
						psoFile.Load(stream2);
						foreach (PsoElementIndexInfo psoElementIndexInfo in psoFile.DefinitionSection.EntriesIdx)
						{
							hashes.Add(psoElementIndexInfo.NameHash);
						}
						foreach (PsoElementInfo psoElementInfo in psoFile.DefinitionSection.Entries)
						{
							if (psoElementInfo is PsoStructureInfo)
							{
								foreach (PsoStructureEntryInfo psoStructureEntryInfo in ((PsoStructureInfo)psoElementInfo).Entries)
								{
									hashes.Add(psoStructureEntryInfo.EntryNameHash);
								}
							}
							if (psoElementInfo is PsoEnumInfo)
							{
								foreach (PsoEnumEntryInfo psoEnumEntryInfo in ((PsoEnumInfo)psoElementInfo).Entries)
								{
									hashes.Add(psoEnumEntryInfo.EntryNameHash);
								}
							}
						}
						Console.WriteLine(file.Name);
					}
				}
			}, null);
			return hashes;
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x00027D84 File Offset: 0x00025F84
		public static HashSet<string> GetAllStringsFromAllXmls(string gameDirectoryName)
		{
			HashSet<string> xmlStrings = new HashSet<string>();
			ArchiveUtilities.ForEachBinaryFile(gameDirectoryName, delegate(string fullFileName, IArchiveBinaryFile file, RageArchiveEncryption7 encryption)
			{
				if (file.Name.EndsWith(".meta", StringComparison.OrdinalIgnoreCase) || file.Name.EndsWith(".xml", StringComparison.OrdinalIgnoreCase))
				{
					MemoryStream memoryStream = new MemoryStream();
					file.Export(memoryStream);
					byte[] array = new byte[memoryStream.Length];
					memoryStream.Position = 0L;
					memoryStream.Read(array, 0, array.Length);
					if (file.IsEncrypted)
					{
						if (encryption == RageArchiveEncryption7.AES)
						{
							array = AesEncryption.DecryptData(array, GTA5Constants.PC_AES_KEY, 1);
						}
						else
						{
							uint num = (GTA5Hash.CalculateHash(file.Name) + (uint)file.UncompressedSize + 61U) % 101U;
							array = GTA5Crypto.Decrypt(array, GTA5Constants.PC_NG_KEYS[(int)num]);
						}
					}
					if (file.IsCompressed)
					{
						Stream stream = new DeflateStream(new MemoryStream(array), CompressionMode.Decompress);
						byte[] array2 = new byte[file.UncompressedSize];
						stream.Read(array2, 0, (int)file.UncompressedSize);
						array = array2;
					}
					foreach (string item in MetaUtilities.GetAllStringsFromXml(new MemoryStream(array)))
					{
						xmlStrings.Add(item);
					}
					Console.WriteLine(file.Name);
				}
			}, null);
			return xmlStrings;
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x00027DBC File Offset: 0x00025FBC
		public static HashSet<string> GetAllStringsFromXml(string xmlFileName)
		{
			HashSet<string> allStringsFromXml;
			using (FileStream fileStream = new FileStream(xmlFileName, FileMode.Open))
			{
				allStringsFromXml = MetaUtilities.GetAllStringsFromXml(fileStream);
			}
			return allStringsFromXml;
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x00027DF8 File Offset: 0x00025FF8
		public static HashSet<string> GetAllStringsFromXml(Stream xmlFileStream)
		{
			HashSet<string> hashSet = new HashSet<string>();
			HtmlDocument htmlDocument = new HtmlDocument();
			htmlDocument.OptionOutputOriginalCase = true;
			htmlDocument.OptionWriteEmptyNodes = true;
			htmlDocument.Load(xmlFileStream);
			Stack<HtmlNode> stack = new Stack<HtmlNode>();
			stack.Push(htmlDocument.DocumentNode);
			while (stack.Count > 0)
			{
				HtmlNode htmlNode = stack.Pop();
				foreach (HtmlNode item in htmlNode.Descendants())
				{
					stack.Push(item);
				}
				if (htmlNode.NodeType == HtmlNodeType.Text)
				{
					hashSet.Add(htmlNode.InnerText.Trim());
					foreach (string text in htmlNode.InnerText.Split(new char[]
					{
						' ',
						'\t',
						'\n'
					}, StringSplitOptions.RemoveEmptyEntries))
					{
						hashSet.Add(text.Trim());
					}
				}
				if (htmlNode.NodeType == HtmlNodeType.Element)
				{
					hashSet.Add(htmlNode.OriginalName.Trim());
					foreach (HtmlAttribute htmlAttribute in ((IEnumerable<HtmlAttribute>)htmlNode.Attributes))
					{
						hashSet.Add(htmlAttribute.OriginalName.Trim());
						hashSet.Add(htmlAttribute.Value.Trim());
					}
				}
			}
			return hashSet;
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x00027F78 File Offset: 0x00026178
		public static HashSet<string> GetAllStringsThatMatchAHash(IEnumerable<string> listOfStrings, ISet<int> listOfHashes)
		{
			HashSet<string> hashSet = new HashSet<string>();
			foreach (string text in listOfStrings)
			{
				int item = (int)Jenkins.Hash(text);
				if (listOfHashes.Contains(item))
				{
					hashSet.Add(text);
				}
			}
			return hashSet;
		}
	}
}
