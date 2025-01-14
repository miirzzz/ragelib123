using System;
using System.Text;
using RageLib.GTA5.Utilities;
using RageLib.Hash;
using RageLib.Resources.GTA5.PC.Meta;
using SharpDX;

namespace RageLib.GTA5.ResourceWrappers.PC
{
	// Token: 0x0200018A RID: 394
	public class MetaXmlBase
	{
		// Token: 0x0600062B RID: 1579 RVA: 0x00028900 File Offset: 0x00026B00
		public static void Indent(StringBuilder sb, int indent)
		{
			for (int i = 0; i < indent; i++)
			{
				sb.Append(" ");
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00028925 File Offset: 0x00026B25
		public static void ErrorXml(StringBuilder sb, int indent, string msg)
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("<error>");
			sb.Append(msg);
			sb.Append("</error>");
			sb.AppendLine();
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x00028958 File Offset: 0x00026B58
		public static void OpenTag(StringBuilder sb, int indent, string name, bool appendLine = true, string nameAttribute = "")
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("<");
			sb.Append(name);
			if (string.IsNullOrWhiteSpace(nameAttribute))
			{
				sb.Append(">");
			}
			else
			{
				sb.Append(" name=\"" + nameAttribute + "\">");
			}
			if (appendLine)
			{
				sb.AppendLine();
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x000289B9 File Offset: 0x00026BB9
		public static void CloseTag(StringBuilder sb, int indent, string name, bool appendLine = true)
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("</");
			sb.Append(name);
			sb.Append(">");
			if (appendLine)
			{
				sb.AppendLine();
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x000289EC File Offset: 0x00026BEC
		public static void ValueTag(StringBuilder sb, int indent, string name, string val)
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("<");
			sb.Append(name);
			sb.Append(" value=\"");
			sb.Append(val);
			sb.Append("\" />");
			sb.AppendLine();
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x00028A3C File Offset: 0x00026C3C
		public static void OneLineTag(StringBuilder sb, int indent, string name, string text)
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("<");
			sb.Append(name);
			sb.Append(">");
			sb.Append(text);
			sb.Append("</");
			sb.Append(name);
			sb.Append(">");
			sb.AppendLine();
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x00028A9F File Offset: 0x00026C9F
		public static void SelfClosingTag(StringBuilder sb, int indent, string val)
		{
			MetaXmlBase.Indent(sb, indent);
			sb.Append("<");
			sb.Append(val);
			sb.Append(" />");
			sb.AppendLine();
		}

		// Token: 0x06000632 RID: 1586 RVA: 0x00028ACF File Offset: 0x00026CCF
		public static void StringTag(StringBuilder sb, int indent, string name, string text)
		{
			if (!string.IsNullOrEmpty(text))
			{
				MetaXmlBase.OneLineTag(sb, indent, name, text);
				return;
			}
			MetaXmlBase.SelfClosingTag(sb, indent, name);
		}

		// Token: 0x06000633 RID: 1587 RVA: 0x00028AEC File Offset: 0x00026CEC
		public static void WriteRawArray<T>(StringBuilder sb, T[] arr, int ind, string name, string typeName, Func<T, string> formatter = null, int arrRowSize = 10) where T : struct
		{
			int num = (arr != null) ? arr.Length : 0;
			int indent = ind + 1;
			if (num <= 0)
			{
				MetaXmlBase.SelfClosingTag(sb, ind, name);
				return;
			}
			if (num <= arrRowSize)
			{
				MetaXmlBase.OpenTag(sb, ind, name, false, "");
				for (int i = 0; i < num; i++)
				{
					if (i > 0)
					{
						sb.Append(" ");
					}
					string value = (formatter != null) ? formatter(arr[i]) : arr[i].ToString();
					sb.Append(value);
				}
				MetaXmlBase.CloseTag(sb, 0, name, true);
				return;
			}
			MetaXmlBase.OpenTag(sb, ind, name, true, "");
			for (int j = 0; j < num; j++)
			{
				int num2 = j % arrRowSize;
				if (num2 == 0)
				{
					MetaXmlBase.Indent(sb, indent);
				}
				if (num2 > 0)
				{
					sb.Append(" ");
				}
				string value2 = (formatter != null) ? formatter(arr[j]) : arr[j].ToString();
				sb.Append(value2);
				bool flag = num2 == arrRowSize - 1;
				bool flag2 = j == num - 1;
				if (flag || flag2)
				{
					sb.AppendLine();
				}
			}
			MetaXmlBase.CloseTag(sb, ind, name, true);
		}

		// Token: 0x06000634 RID: 1588 RVA: 0x00028C1C File Offset: 0x00026E1C
		public static void WriteItemArray<T>(StringBuilder sb, T[] arr, int ind, string name, string typeName, Func<T, string> formatter) where T : struct
		{
			int num = (arr != null) ? arr.Length : 0;
			int indent = ind + 1;
			if (num > 0)
			{
				MetaXmlBase.OpenTag(sb, ind, name, true, "");
				for (int i = 0; i < num; i++)
				{
					MetaXmlBase.Indent(sb, indent);
					sb.Append("<Item>");
					sb.Append(formatter(arr[i]));
					sb.AppendLine("</Item>");
				}
				MetaXmlBase.CloseTag(sb, ind, name, true);
				return;
			}
			MetaXmlBase.SelfClosingTag(sb, ind, name);
		}

		// Token: 0x06000635 RID: 1589 RVA: 0x00028C9D File Offset: 0x00026E9D
		public static string FormatHash(MetaName h)
		{
			return MetaXmlBase.HashString(h);
		}

		// Token: 0x06000636 RID: 1590 RVA: 0x00028CA5 File Offset: 0x00026EA5
		public static string FormatVector2(Vector2 v)
		{
			return FloatUtil.GetVector2String(v);
		}

		// Token: 0x06000637 RID: 1591 RVA: 0x00028CAD File Offset: 0x00026EAD
		public static string FormatVector3(Vector3 v)
		{
			return FloatUtil.GetVector3String(v);
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x00028CB5 File Offset: 0x00026EB5
		public static string FormatVector4(Vector3 v)
		{
			return FloatUtil.GetVector4String((Vector4)v);
		}

		// Token: 0x06000639 RID: 1593 RVA: 0x00028CC2 File Offset: 0x00026EC2
		public static string FormatVector4(Vector4 v)
		{
			return FloatUtil.GetVector4String(v);
		}

		// Token: 0x0600063A RID: 1594 RVA: 0x00028CCC File Offset: 0x00026ECC
		public static string FormatHashSwap(MetaName h)
		{
			return MetaUtils.SwapBytes((uint)h).ToString();
		}

		// Token: 0x0600063B RID: 1595 RVA: 0x00028CE7 File Offset: 0x00026EE7
		public static string FormatVector2Swap(Vector2 v)
		{
			return FloatUtil.GetVector2String(MetaUtils.SwapBytes(v));
		}

		// Token: 0x0600063C RID: 1596 RVA: 0x00028CF4 File Offset: 0x00026EF4
		public static string FormatVector3Swap(Vector3 v)
		{
			return FloatUtil.GetVector3String(MetaUtils.SwapBytes(v));
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x00028D01 File Offset: 0x00026F01
		public static string FormatVector4Swap(Vector4 v)
		{
			return FloatUtil.GetVector4String(MetaUtils.SwapBytes(v));
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00028D0E File Offset: 0x00026F0E
		public static string FormatVector4SwapXYZOnly(Vector4 v)
		{
			return FloatUtil.GetVector3String(MetaUtils.SwapBytes((Vector3)v));
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00028D20 File Offset: 0x00026F20
		public static string HashString(MetaName h)
		{
			if (Enum.IsDefined(typeof(MetaName), h))
			{
				return h.ToString();
			}
			uint num = (uint)h;
			if (num == 0U)
			{
				return "";
			}
			string text = Jenkins.TryGetString(num);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
			return "hash_" + num.ToString("X").PadLeft(8, '0');
		}

		// Token: 0x06000640 RID: 1600 RVA: 0x00028D8C File Offset: 0x00026F8C
		public static string UintString(uint h)
		{
			if (Enum.IsDefined(typeof(MetaName), h))
			{
				MetaName metaName = (MetaName)h;
				return metaName.ToString();
			}
			return "0x" + h.ToString("X");
		}

		// Token: 0x040036DD RID: 14045
		public const string XmlHeader = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";

		// Token: 0x020002C0 RID: 704
		public enum XmlTagMode
		{
			// Token: 0x040040FC RID: 16636
			None,
			// Token: 0x040040FD RID: 16637
			Structure,
			// Token: 0x040040FE RID: 16638
			Item,
			// Token: 0x040040FF RID: 16639
			ItemAndType
		}
	}
}
