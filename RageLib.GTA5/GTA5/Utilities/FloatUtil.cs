using System;
using System.Globalization;
using SharpDX;

namespace RageLib.GTA5.Utilities
{
	// Token: 0x02000189 RID: 393
	public static class FloatUtil
	{
		// Token: 0x0600061F RID: 1567 RVA: 0x00028518 File Offset: 0x00026718
		public static bool TryParse(string s, out float f)
		{
			f = 0f;
			return float.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out f);
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00028538 File Offset: 0x00026738
		public static float Parse(string s)
		{
			float result;
			FloatUtil.TryParse(s, out result);
			return result;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00028550 File Offset: 0x00026750
		public static string ToString(float f)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return f.ToString(invariantCulture);
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0002856C File Offset: 0x0002676C
		public static string GetVector2String(Vector2 v)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return v.X.ToString(invariantCulture) + ", " + v.Y.ToString(invariantCulture);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000285A4 File Offset: 0x000267A4
		public static string GetVector3String(Vector3 v)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Concat(new string[]
			{
				v.X.ToString(invariantCulture),
				", ",
				v.Y.ToString(invariantCulture),
				", ",
				v.Z.ToString(invariantCulture)
			});
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x00028604 File Offset: 0x00026804
		public static string GetVector3String(Vector3 v, string format)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Concat(new string[]
			{
				v.X.ToString(format, invariantCulture),
				", ",
				v.Y.ToString(format, invariantCulture),
				", ",
				v.Z.ToString(format, invariantCulture)
			});
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00028668 File Offset: 0x00026868
		public static string GetVector3XmlString(Vector3 v)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Format("x=\"{0}\" y=\"{1}\" z=\"{2}\"", v.X.ToString(invariantCulture), v.Y.ToString(invariantCulture), v.Z.ToString(invariantCulture));
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x000286AC File Offset: 0x000268AC
		public static string GetVector4XmlString(Vector4 v)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Format("x=\"{0}\" y=\"{1}\" z=\"{2}\" w=\"{3}\"", new object[]
			{
				v.X.ToString(invariantCulture),
				v.Y.ToString(invariantCulture),
				v.Z.ToString(invariantCulture),
				v.W.ToString(invariantCulture)
			});
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00028710 File Offset: 0x00026910
		public static string GetQuaternionXmlString(Quaternion q)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Format("x=\"{0}\" y=\"{1}\" z=\"{2}\" w=\"{3}\"", new object[]
			{
				q.X.ToString(invariantCulture),
				q.Y.ToString(invariantCulture),
				q.Z.ToString(invariantCulture),
				q.W.ToString(invariantCulture)
			});
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x00028774 File Offset: 0x00026974
		public static Vector3 ParseVector3String(string s)
		{
			Vector3 result = new Vector3(0f);
			string[] array = s.Split(new char[]
			{
				','
			});
			if (array.Length != 0)
			{
				FloatUtil.TryParse(array[0].Trim(), out result.X);
			}
			if (array.Length > 1)
			{
				FloatUtil.TryParse(array[1].Trim(), out result.Y);
			}
			if (array.Length > 2)
			{
				FloatUtil.TryParse(array[2].Trim(), out result.Z);
			}
			return result;
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x000287F0 File Offset: 0x000269F0
		public static string GetVector4String(Vector4 v)
		{
			CultureInfo invariantCulture = CultureInfo.InvariantCulture;
			return string.Concat(new string[]
			{
				v.X.ToString(invariantCulture),
				", ",
				v.Y.ToString(invariantCulture),
				", ",
				v.Z.ToString(invariantCulture),
				", ",
				v.W.ToString(invariantCulture)
			});
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00028868 File Offset: 0x00026A68
		public static Vector4 ParseVector4String(string s)
		{
			Vector4 result = new Vector4(0f);
			string[] array = s.Split(new char[]
			{
				','
			});
			if (array.Length != 0)
			{
				FloatUtil.TryParse(array[0].Trim(), out result.X);
			}
			if (array.Length > 1)
			{
				FloatUtil.TryParse(array[1].Trim(), out result.Y);
			}
			if (array.Length > 2)
			{
				FloatUtil.TryParse(array[2].Trim(), out result.Z);
			}
			if (array.Length > 3)
			{
				FloatUtil.TryParse(array[3].Trim(), out result.W);
			}
			return result;
		}
	}
}
