using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using RageLib.Data;
using RageLib.GTA5.RBF;
using RageLib.GTA5.RBF.Types;

namespace RageLib.GTA5.RBFWrappers
{
	// Token: 0x02000200 RID: 512
	public class RbfXmlExporter
	{
		// Token: 0x06000941 RID: 2369 RVA: 0x0003B170 File Offset: 0x00039370
		public void Export(RbfStructure value, string xmlFileName)
		{
			using (FileStream fileStream = new FileStream(xmlFileName, FileMode.Create))
			{
				this.Export(value, fileStream);
			}
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x0003B1AC File Offset: 0x000393AC
		public void Export(RbfStructure value, Stream xmlFileStream)
		{
			XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlFileStream, Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement(value.Name);
			this.WriteStructureContentXml(value, xmlTextWriter);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x0003B1F8 File Offset: 0x000393F8
		private void WriteStructureContentXml(RbfStructure value, XmlTextWriter writer)
		{
			foreach (IRbfType rbfType in value.Children)
			{
				if (rbfType is RbfBytes)
				{
					RbfBytes rbfBytes = (RbfBytes)rbfType;
					RbfString rbfString = null;
					foreach (IRbfType rbfType2 in value.Children)
					{
						if (rbfType2.Name != null && rbfType2.Name.Equals("content"))
						{
							rbfString = (RbfString)rbfType2;
						}
					}
					if (rbfString != null)
					{
						if (rbfString.Value.Equals("char_array"))
						{
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.AppendLine("");
							foreach (byte b in rbfBytes.Value)
							{
								stringBuilder.AppendLine(b.ToString());
							}
							writer.WriteString(stringBuilder.ToString());
						}
						else
						{
							if (!rbfString.Value.Equals("short_array"))
							{
								throw new Exception("Unexpected content type");
							}
							StringBuilder stringBuilder2 = new StringBuilder();
							DataReader dataReader = new DataReader(new MemoryStream(rbfBytes.Value), Endianess.LittleEndian);
							while (dataReader.Position < dataReader.Length)
							{
								stringBuilder2.AppendLine(dataReader.ReadUInt16().ToString());
							}
							writer.WriteString(stringBuilder2.ToString());
						}
					}
					else
					{
						string @string = Encoding.ASCII.GetString(rbfBytes.Value);
						writer.WriteString(@string.Substring(0, @string.Length - 1));
					}
				}
				if (rbfType is RbfFloat)
				{
					writer.WriteStartElement(rbfType.Name);
					RbfFloat rbfFloat = (RbfFloat)rbfType;
					string value3 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", rbfFloat.Value);
					writer.WriteAttributeString("value", value3);
					writer.WriteEndElement();
				}
				if (rbfType is RbfString)
				{
					RbfString rbfString2 = (RbfString)rbfType;
					if (rbfString2.Name.Equals("content"))
					{
						writer.WriteAttributeString("content", rbfString2.Value);
					}
					else
					{
						if (!rbfString2.Name.Equals("type"))
						{
							throw new Exception("Unexpected string content");
						}
						writer.WriteAttributeString("type", rbfString2.Value);
					}
				}
				if (rbfType is RbfStructure)
				{
					writer.WriteStartElement(rbfType.Name);
					this.WriteStructureContentXml((RbfStructure)rbfType, writer);
					writer.WriteEndElement();
				}
				if (rbfType is RbfUint32)
				{
					RbfUint32 rbfUint = (RbfUint32)rbfType;
					writer.WriteStartElement(rbfType.Name);
					writer.WriteAttributeString("value", "0x" + rbfUint.Value.ToString("X8"));
					writer.WriteEndElement();
				}
				if (rbfType is RbfBoolean)
				{
					RbfBoolean rbfBoolean = (RbfBoolean)rbfType;
					writer.WriteStartElement(rbfType.Name);
					writer.WriteAttributeString("value", rbfBoolean.Value ? "true" : "false");
					writer.WriteEndElement();
				}
				if (rbfType is RbfFloat3)
				{
					writer.WriteStartElement(rbfType.Name);
					RbfFloat3 rbfFloat2 = (RbfFloat3)rbfType;
					string value4 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", rbfFloat2.X);
					string value5 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", rbfFloat2.Y);
					string value6 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", rbfFloat2.Z);
					writer.WriteAttributeString("x", value4);
					writer.WriteAttributeString("y", value5);
					writer.WriteAttributeString("z", value6);
					writer.WriteEndElement();
				}
			}
		}
	}
}
