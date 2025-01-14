using System;
using System.IO;
using System.Text;
using RageLib.Data;
using RageLib.GTA5.RBF;
using RageLib.GTA5.RBF.Types;
using RageLib.GTA5.Utilities;

namespace RageLib.GTA5.ResourceWrappers.PC.RBF
{
	// Token: 0x0200018B RID: 395
	public class RbfXml : MetaXmlBase
	{
		// Token: 0x06000642 RID: 1602 RVA: 0x00028DD6 File Offset: 0x00026FD6
		public static string GetXml(RbfFile rbf)
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"UTF-8\"?>");
			RbfXml.WriteNode(stringBuilder, 0, rbf.current);
			return stringBuilder.ToString();
		}

		// Token: 0x06000643 RID: 1603 RVA: 0x00028DFC File Offset: 0x00026FFC
		private static void WriteNode(StringBuilder sb, int indent, RbfStructure rs)
		{
			if (rs.Children.Count == 0)
			{
				MetaXmlBase.SelfClosingTag(sb, indent, rs.Name);
				return;
			}
			int num = indent + 1;
			bool flag = rs.Children.Count == 1 && rs.Children[0].Name == null;
			MetaXmlBase.OpenTag(sb, indent, rs.Name, !flag, "");
			foreach (IRbfType rbfType in rs.Children)
			{
				if (rbfType is RbfBytes)
				{
					RbfBytes rbfBytes = (RbfBytes)rbfType;
					RbfString rbfString = rs.FindChild("content") as RbfString;
					if (rbfString != null)
					{
						MetaXmlBase.OpenTag(sb, num, "value", true, "");
						int indent2 = num + 1;
						if (rbfString.Value == "char_array")
						{
							foreach (byte b in rbfBytes.Value)
							{
								MetaXmlBase.Indent(sb, indent2);
								sb.AppendLine(b.ToString());
							}
						}
						else if (rbfString.Value.Equals("short_array"))
						{
							DataReader dataReader = new DataReader(new MemoryStream(rbfBytes.Value), Endianess.LittleEndian);
							while (dataReader.Position < dataReader.Length)
							{
								MetaXmlBase.Indent(sb, indent2);
								sb.AppendLine(dataReader.ReadUInt16().ToString());
							}
						}
						else
						{
							MetaXmlBase.ErrorXml(sb, indent2, "Unexpected content type: " + rbfString.Value);
						}
						MetaXmlBase.CloseTag(sb, num, "value", true);
					}
					else
					{
						string @string = Encoding.ASCII.GetString(rbfBytes.Value);
						string value2 = @string.Substring(0, @string.Length - 1);
						sb.Append(value2);
					}
				}
				if (rbfType is RbfFloat)
				{
					RbfFloat rbfFloat = (RbfFloat)rbfType;
					MetaXmlBase.ValueTag(sb, num, rbfType.Name, FloatUtil.ToString(rbfFloat.Value));
				}
				if (rbfType is RbfString)
				{
					RbfString rbfString2 = (RbfString)rbfType;
					MetaXmlBase.StringTag(sb, num, rbfString2.Name, rbfString2.Value);
				}
				if (rbfType is RbfStructure)
				{
					RbfXml.WriteNode(sb, num, rbfType as RbfStructure);
				}
				if (rbfType is RbfUint32)
				{
					RbfUint32 rbfUint = (RbfUint32)rbfType;
					MetaXmlBase.ValueTag(sb, num, rbfUint.Name, MetaXmlBase.UintString(rbfUint.Value));
				}
				if (rbfType is RbfBoolean)
				{
					RbfBoolean rbfBoolean = (RbfBoolean)rbfType;
					MetaXmlBase.ValueTag(sb, num, rbfBoolean.Name, rbfBoolean.Value.ToString());
				}
				if (rbfType is RbfFloat3)
				{
					RbfFloat3 rbfFloat2 = rbfType as RbfFloat3;
					MetaXmlBase.SelfClosingTag(sb, num, string.Concat(new string[]
					{
						rbfFloat2.Name,
						" x=\"",
						FloatUtil.ToString(rbfFloat2.X),
						"\" y=\"",
						FloatUtil.ToString(rbfFloat2.Y),
						"\" z=\"",
						FloatUtil.ToString(rbfFloat2.Z),
						"\""
					}));
				}
			}
			MetaXmlBase.CloseTag(sb, flag ? 0 : indent, rs.Name, true);
		}
	}
}
