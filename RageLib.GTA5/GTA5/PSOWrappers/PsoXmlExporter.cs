using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml;
using RageLib.GTA5.PSO;
using RageLib.GTA5.PSOWrappers.Types;

namespace RageLib.GTA5.PSOWrappers
{
	// Token: 0x02000274 RID: 628
	public class PsoXmlExporter
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000A92 RID: 2706 RVA: 0x0008252F File Offset: 0x0008072F
		// (set) Token: 0x06000A93 RID: 2707 RVA: 0x00082537 File Offset: 0x00080737
		public Dictionary<int, string> HashMapping { get; set; }

		// Token: 0x06000A94 RID: 2708 RVA: 0x00082540 File Offset: 0x00080740
		public PsoXmlExporter()
		{
			this.HashMapping = new Dictionary<int, string>();
		}

		// Token: 0x06000A95 RID: 2709 RVA: 0x00082554 File Offset: 0x00080754
		public void Export(IPsoValue value, string xmlFileName)
		{
			using (FileStream fileStream = new FileStream(xmlFileName, FileMode.Create))
			{
				this.Export(value, fileStream);
			}
		}

		// Token: 0x06000A96 RID: 2710 RVA: 0x00082590 File Offset: 0x00080790
		public void Export(IPsoValue value, Stream xmlFileStream)
		{
			PsoStructure psoStructure = (PsoStructure)value;
			XmlTextWriter xmlTextWriter = new XmlTextWriter(xmlFileStream, Encoding.UTF8);
			xmlTextWriter.Formatting = Formatting.Indented;
			xmlTextWriter.WriteStartDocument();
			xmlTextWriter.WriteStartElement(this.GetNameForHash(psoStructure.entryIndexInfo.NameHash));
			this.WriteStructureContentXml(psoStructure, xmlTextWriter);
			xmlTextWriter.WriteEndElement();
			xmlTextWriter.WriteEndDocument();
			xmlTextWriter.Flush();
		}

		// Token: 0x06000A97 RID: 2711 RVA: 0x000825F0 File Offset: 0x000807F0
		private void WriteStructureContentXml(PsoStructure value, XmlTextWriter writer)
		{
			foreach (KeyValuePair<int, IPsoValue> keyValuePair in value.Values)
			{
				int key = keyValuePair.Key;
				IPsoValue value2 = keyValuePair.Value;
				string nameForHash = this.GetNameForHash(key);
				writer.WriteStartElement(nameForHash);
				this.WriteStructureElementContentXml(value2, writer);
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x0008266C File Offset: 0x0008086C
		private void WriteStructureContentXml(PsoStructure3 value, XmlTextWriter writer)
		{
			if (value.Value != null)
			{
				writer.WriteAttributeString("type", this.GetNameForHash(value.Value.entryIndexInfo.NameHash));
				foreach (KeyValuePair<int, IPsoValue> keyValuePair in value.Value.Values)
				{
					int key = keyValuePair.Key;
					IPsoValue value2 = keyValuePair.Value;
					string nameForHash = this.GetNameForHash(key);
					writer.WriteStartElement(nameForHash);
					this.WriteStructureElementContentXml(value2, writer);
					writer.WriteEndElement();
				}
			}
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x00082718 File Offset: 0x00080918
		private void WriteStructureElementContentXml(IPsoValue value, XmlTextWriter writer)
		{
			if (value is PsoArray0)
			{
				this.WriteArrayContent(writer, (PsoArray0)value);
				return;
			}
			if (value is PsoArray1)
			{
				this.WriteArrayContent(writer, (PsoArray1)value);
				return;
			}
			if (value is PsoArray4)
			{
				this.WriteArrayContent(writer, (PsoArray4)value);
				return;
			}
			if (value is PsoBoolean)
			{
				this.WriteBooleanContent(writer, (PsoBoolean)value);
				return;
			}
			if (value is PsoByte)
			{
				this.WriteByteContent(writer, (PsoByte)value);
				return;
			}
			if (value is PsoEnumByte)
			{
				this.WriteEnumContent(writer, (PsoEnumByte)value);
				return;
			}
			if (value is PsoEnumInt)
			{
				this.WriteEnumContent(writer, (PsoEnumInt)value);
				return;
			}
			if (value is PsoFlagsByte)
			{
				this.WriteFlagsContent(writer, (PsoFlagsByte)value);
				return;
			}
			if (value is PsoFlagsShort)
			{
				this.WriteFlagsContent(writer, (PsoFlagsShort)value);
				return;
			}
			if (value is PsoFlagsInt)
			{
				this.WriteFlagsContent(writer, (PsoFlagsInt)value);
				return;
			}
			if (value is PsoFloat)
			{
				this.WriteFloatContent(writer, (PsoFloat)value);
				return;
			}
			if (value is PsoFloat2)
			{
				this.WriteFloatContent(writer, (PsoFloat2)value);
				return;
			}
			if (value is PsoFloat3)
			{
				this.WriteFloatContent(writer, (PsoFloat3)value);
				return;
			}
			if (value is PsoFloat4A)
			{
				this.WriteFloatContent(writer, (PsoFloat4A)value);
				return;
			}
			if (value is PsoFloat4B)
			{
				this.WriteFloatContent(writer, (PsoFloat4B)value);
				return;
			}
			if (value is PsoIntSigned)
			{
				this.WriteIntegerContent(writer, (PsoIntSigned)value);
				return;
			}
			if (value is PsoIntUnsigned)
			{
				this.WriteIntegerContent(writer, (PsoIntUnsigned)value);
				return;
			}
			if (value is PsoMap)
			{
				this.WriteMapContent(writer, (PsoMap)value);
				return;
			}
			if (value is PsoString0)
			{
				this.WriteStringContent(writer, (PsoString0)value);
				return;
			}
			if (value is PsoString1)
			{
				this.WriteStringContent(writer, (PsoString1)value);
				return;
			}
			if (value is PsoString2)
			{
				this.WriteStringContent(writer, (PsoString2)value);
				return;
			}
			if (value is PsoString3)
			{
				this.WriteStringContent(writer, (PsoString3)value);
				return;
			}
			if (value is PsoString7)
			{
				this.WriteStringContent(writer, (PsoString7)value);
				return;
			}
			if (value is PsoString8)
			{
				this.WriteStringContent(writer, (PsoString8)value);
				return;
			}
			if (value is PsoType5)
			{
				PsoType5 value2 = value as PsoType5;
				this.Write5Content(writer, value2);
				return;
			}
			if (value is PsoStructure)
			{
				PsoStructure value3 = value as PsoStructure;
				this.WriteStructureContentXml(value3, writer);
				return;
			}
			if (value is PsoStructure3)
			{
				PsoStructure3 value4 = value as PsoStructure3;
				this.WriteStructureContentXml(value4, writer);
				return;
			}
			if (value is PsoXXHalf)
			{
				throw new NotImplementedException();
			}
			if (value is PsoType4)
			{
				throw new NotImplementedException();
			}
			if (value is PsoType9)
			{
				throw new NotImplementedException();
			}
			if (value is PsoType32)
			{
				throw new NotImplementedException();
			}
			if (value is PsoType3)
			{
				throw new NotImplementedException();
			}
			if (value is PsoXXByte)
			{
				throw new NotImplementedException();
			}
			throw new Exception("Unknown type");
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000829DC File Offset: 0x00080BDC
		private void WriteArrayContent(XmlTextWriter writer, PsoArray0 arrayValue)
		{
			if (arrayValue.Entries != null)
			{
				foreach (IPsoValue psoValue in arrayValue.Entries)
				{
					writer.WriteStartElement("Item");
					if (psoValue is PsoStructure)
					{
						this.WriteStructureContentXml((PsoStructure)psoValue, writer);
					}
					else if (psoValue is PsoStructure3)
					{
						this.WriteStructureContentXml((PsoStructure3)psoValue, writer);
					}
					else
					{
						this.WriteStructureElementContentXml(psoValue, writer);
					}
					writer.WriteEndElement();
				}
			}
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x00082A78 File Offset: 0x00080C78
		private void WriteArrayContent(XmlTextWriter writer, PsoArray1 arrayValue)
		{
			foreach (IPsoValue psoValue in arrayValue.Entries)
			{
				writer.WriteStartElement("Item");
				if (psoValue is PsoStructure)
				{
					this.WriteStructureContentXml((PsoStructure)psoValue, writer);
				}
				else if (psoValue is PsoStructure3)
				{
					this.WriteStructureContentXml((PsoStructure3)psoValue, writer);
				}
				else
				{
					this.WriteStructureElementContentXml(psoValue, writer);
				}
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00082B0C File Offset: 0x00080D0C
		private void WriteArrayContent(XmlTextWriter writer, PsoArray4 arrayValue)
		{
			foreach (IPsoValue psoValue in arrayValue.Entries)
			{
				writer.WriteStartElement("Item");
				if (psoValue is PsoStructure)
				{
					this.WriteStructureContentXml((PsoStructure)psoValue, writer);
				}
				else if (psoValue is PsoStructure3)
				{
					this.WriteStructureContentXml((PsoStructure3)psoValue, writer);
				}
				else
				{
					this.WriteStructureElementContentXml(psoValue, writer);
				}
				writer.WriteEndElement();
			}
		}

		// Token: 0x06000A9D RID: 2717 RVA: 0x00082BA0 File Offset: 0x00080DA0
		private void WriteBooleanContent(XmlTextWriter writer, PsoBoolean value)
		{
			if (value.Value)
			{
				writer.WriteAttributeString("value", "true");
				return;
			}
			writer.WriteAttributeString("value", "false");
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x00082BCC File Offset: 0x00080DCC
		private void WriteByteContent(XmlTextWriter writer, PsoByte value)
		{
			writer.WriteAttributeString("value", value.Value.ToString());
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00082BF4 File Offset: 0x00080DF4
		private void WriteEnumContent(XmlTextWriter writer, PsoEnumByte value)
		{
			PsoEnumEntryInfo psoEnumEntryInfo = null;
			foreach (PsoEnumEntryInfo psoEnumEntryInfo2 in value.TypeInfo.Entries)
			{
				if (psoEnumEntryInfo2.EntryKey == (int)value.Value)
				{
					psoEnumEntryInfo = psoEnumEntryInfo2;
				}
			}
			if (psoEnumEntryInfo != null)
			{
				string nameForHash = this.GetNameForHash(psoEnumEntryInfo.EntryNameHash);
				writer.WriteString(nameForHash);
			}
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x00082C70 File Offset: 0x00080E70
		private void WriteEnumContent(XmlTextWriter writer, PsoEnumInt value)
		{
			PsoEnumEntryInfo psoEnumEntryInfo = null;
			foreach (PsoEnumEntryInfo psoEnumEntryInfo2 in value.TypeInfo.Entries)
			{
				if (psoEnumEntryInfo2.EntryKey == value.Value)
				{
					psoEnumEntryInfo = psoEnumEntryInfo2;
				}
			}
			if (psoEnumEntryInfo != null)
			{
				string nameForHash = this.GetNameForHash(psoEnumEntryInfo.EntryNameHash);
				writer.WriteString(nameForHash);
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00082CEC File Offset: 0x00080EEC
		private void WriteFlagsContent(XmlTextWriter writer, PsoFlagsByte value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 8; i++)
			{
				if (((int)value.Value & 1 << i) != 0)
				{
					PsoEnumEntryInfo psoEnumEntryInfo = null;
					foreach (PsoEnumEntryInfo psoEnumEntryInfo2 in value.TypeInfo.Entries)
					{
						if (psoEnumEntryInfo2.EntryKey == i)
						{
							psoEnumEntryInfo = psoEnumEntryInfo2;
						}
					}
					string nameForHash = this.GetNameForHash(psoEnumEntryInfo.EntryNameHash);
					stringBuilder.Append(nameForHash + " ");
				}
			}
			string text = stringBuilder.ToString().Trim();
			writer.WriteString(text);
		}

		// Token: 0x06000AA2 RID: 2722 RVA: 0x00082DA4 File Offset: 0x00080FA4
		private void WriteFlagsContent(XmlTextWriter writer, PsoFlagsShort value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 16; i++)
			{
				if (((int)value.Value & 1 << i) != 0)
				{
					PsoEnumEntryInfo psoEnumEntryInfo = null;
					foreach (PsoEnumEntryInfo psoEnumEntryInfo2 in value.TypeInfo.Entries)
					{
						if (psoEnumEntryInfo2.EntryKey == i)
						{
							psoEnumEntryInfo = psoEnumEntryInfo2;
						}
					}
					string nameForHash = this.GetNameForHash(psoEnumEntryInfo.EntryNameHash);
					stringBuilder.Append(nameForHash + " ");
				}
			}
			string text = stringBuilder.ToString().Trim();
			writer.WriteString(text);
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x00082E5C File Offset: 0x0008105C
		private void WriteFlagsContent(XmlTextWriter writer, PsoFlagsInt value)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < 32; i++)
			{
				if ((value.Value & 1 << i) != 0)
				{
					PsoEnumEntryInfo psoEnumEntryInfo = null;
					foreach (PsoEnumEntryInfo psoEnumEntryInfo2 in value.TypeInfo.Entries)
					{
						if (psoEnumEntryInfo2.EntryKey == i)
						{
							psoEnumEntryInfo = psoEnumEntryInfo2;
						}
					}
					string nameForHash = this.GetNameForHash(psoEnumEntryInfo.EntryNameHash);
					stringBuilder.Append(nameForHash + " ");
				}
			}
			string text = stringBuilder.ToString().Trim();
			writer.WriteString(text);
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x00082F14 File Offset: 0x00081114
		private void WriteFloatContent(XmlTextWriter writer, PsoFloat value)
		{
			string value2 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Value);
			writer.WriteAttributeString("value", value2);
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00082F48 File Offset: 0x00081148
		private void WriteFloatContent(XmlTextWriter writer, PsoFloat2 value)
		{
			string value2 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.X);
			string value3 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Y);
			writer.WriteAttributeString("x", value2);
			writer.WriteAttributeString("y", value3);
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00082FA4 File Offset: 0x000811A4
		private void WriteFloatContent(XmlTextWriter writer, PsoFloat3 value)
		{
			string value2 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.X);
			string value3 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Y);
			string value4 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Z);
			writer.WriteAttributeString("x", value2);
			writer.WriteAttributeString("y", value3);
			writer.WriteAttributeString("z", value4);
		}

		// Token: 0x06000AA7 RID: 2727 RVA: 0x00083028 File Offset: 0x00081228
		private void WriteFloatContent(XmlTextWriter writer, PsoFloat4A value)
		{
			string value2 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.X);
			string value3 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Y);
			string value4 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Z);
			string value5 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.W);
			writer.WriteAttributeString("x", value2);
			writer.WriteAttributeString("y", value3);
			writer.WriteAttributeString("z", value4);
			writer.WriteAttributeString("w", value5);
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x000830D4 File Offset: 0x000812D4
		private void WriteFloatContent(XmlTextWriter writer, PsoFloat4B value)
		{
			string value2 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.X);
			string value3 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Y);
			string value4 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.Z);
			string value5 = string.Format(CultureInfo.InvariantCulture, "{0:0.0###########}", value.W);
			writer.WriteAttributeString("x", value2);
			writer.WriteAttributeString("y", value3);
			writer.WriteAttributeString("z", value4);
			writer.WriteAttributeString("w", value5);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00083180 File Offset: 0x00081380
		private void WriteIntegerContent(XmlTextWriter writer, PsoIntSigned value)
		{
			writer.WriteAttributeString("value", value.Value.ToString());
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x000831A8 File Offset: 0x000813A8
		private void WriteIntegerContent(XmlTextWriter writer, PsoIntUnsigned value)
		{
			writer.WriteAttributeString("value", value.Value.ToString("X8"));
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x000831D4 File Offset: 0x000813D4
		private void WriteMapContent(XmlTextWriter writer, PsoMap value)
		{
			if (value.Entries != null)
			{
				foreach (PsoStructure psoStructure in value.Entries)
				{
					writer.WriteStartElement("Item");
					PsoString7 psoString = (PsoString7)psoStructure.Values[1620616462];
					writer.WriteAttributeString("key", this.GetNameForHash(psoString.Value));
					IPsoValue psoValue = psoStructure.Values[104834034];
					if (psoValue is PsoStructure)
					{
						this.WriteStructureContentXml((PsoStructure)psoValue, writer);
					}
					else if (psoValue is PsoStructure3)
					{
						this.WriteStructureContentXml((PsoStructure3)psoValue, writer);
					}
					else
					{
						this.WriteStructureElementContentXml(psoValue, writer);
					}
					writer.WriteEndElement();
				}
			}
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x000832B4 File Offset: 0x000814B4
		private void WriteStringContent(XmlTextWriter writer, PsoString0 value)
		{
			if (value.Value != null)
			{
				writer.WriteString(value.Value.Replace("\0", ""));
			}
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x000832D9 File Offset: 0x000814D9
		private void WriteStringContent(XmlTextWriter writer, PsoString1 value)
		{
			if (value.Value != null)
			{
				writer.WriteString(value.Value.Replace("\0", ""));
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x000832FE File Offset: 0x000814FE
		private void WriteStringContent(XmlTextWriter writer, PsoString2 value)
		{
			if (value.Value != null)
			{
				writer.WriteString(value.Value.Replace("\0", ""));
			}
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00083323 File Offset: 0x00081523
		private void WriteStringContent(XmlTextWriter writer, PsoString3 value)
		{
			if (value.Value != null)
			{
				writer.WriteString(value.Value.Replace("\0", ""));
			}
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00083348 File Offset: 0x00081548
		private void WriteStringContent(XmlTextWriter writer, PsoString7 value)
		{
			if (value.Value != 0)
			{
				writer.WriteString(this.GetNameForHash(value.Value));
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00083364 File Offset: 0x00081564
		private void WriteStringContent(XmlTextWriter writer, PsoString8 value)
		{
			if (value.Value != 0)
			{
				writer.WriteString(this.GetNameForHash(value.Value));
			}
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00083380 File Offset: 0x00081580
		private void Write5Content(XmlTextWriter writer, PsoType5 value)
		{
			writer.WriteAttributeString("value", value.Value.ToString());
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x000833A6 File Offset: 0x000815A6
		private string GetNameForHash(int hash)
		{
			if (this.HashMapping.ContainsKey(hash))
			{
				return this.HashMapping[hash];
			}
			throw new Exception("Hash 0x" + hash.ToString("X8") + "could not be replaced by a string.");
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x000833E4 File Offset: 0x000815E4
		public string ByteArrayToString(byte[] b)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; i < b.Length; i++)
			{
				stringBuilder.Append(b[i].ToString());
				if (i != b.Length - 1)
				{
					stringBuilder.Append(" ");
				}
			}
			return stringBuilder.ToString();
		}
	}
}
