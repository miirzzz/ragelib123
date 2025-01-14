using System;
using System.Globalization;

namespace RageLib.GTA5.PSOWrappers.Xml
{
	// Token: 0x0200027A RID: 634
	public static class HexConverter
	{
		// Token: 0x06000AE8 RID: 2792 RVA: 0x000835FF File Offset: 0x000817FF
		public static string ToHex(int value)
		{
			return "0x" + value.ToString("X8");
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00083617 File Offset: 0x00081817
		public static int ToUInt32(string value)
		{
			if (value.StartsWith("0x"))
			{
				return int.Parse(value.Substring(2), NumberStyles.HexNumber);
			}
			return int.Parse(value, NumberStyles.HexNumber);
		}
	}
}
