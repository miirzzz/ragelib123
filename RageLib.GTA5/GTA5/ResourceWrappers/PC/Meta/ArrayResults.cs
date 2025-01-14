using System;
using System.Collections.Generic;
using RageLib.Resources.GTA5.PC.Meta;

namespace RageLib.GTA5.ResourceWrappers.PC.Meta
{
	// Token: 0x0200019A RID: 410
	internal struct ArrayResults
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x0002CDA8 File Offset: 0x0002AFA8
		public void WriteArrays(byte[] data)
		{
			foreach (KeyValuePair<int, Array_Structure> keyValuePair in this.Structures)
			{
				byte[] array = MetaUtils.ConvertToBytes<Array_Structure>(keyValuePair.Value);
				Buffer.BlockCopy(array, 0, data, keyValuePair.Key, array.Length);
			}
			foreach (KeyValuePair<int, Array_StructurePointer> keyValuePair2 in this.StructurePointers)
			{
				byte[] array2 = MetaUtils.ConvertToBytes<Array_StructurePointer>(keyValuePair2.Value);
				Buffer.BlockCopy(array2, 0, data, keyValuePair2.Key, array2.Length);
			}
			foreach (KeyValuePair<int, Array_uint> keyValuePair3 in this.UInts)
			{
				byte[] array3 = MetaUtils.ConvertToBytes<Array_uint>(keyValuePair3.Value);
				Buffer.BlockCopy(array3, 0, data, keyValuePair3.Key, array3.Length);
			}
			foreach (KeyValuePair<int, Array_ushort> keyValuePair4 in this.UShorts)
			{
				byte[] array4 = MetaUtils.ConvertToBytes<Array_ushort>(keyValuePair4.Value);
				Buffer.BlockCopy(array4, 0, data, keyValuePair4.Key, array4.Length);
			}
			foreach (KeyValuePair<int, Array_byte> keyValuePair5 in this.UBytes)
			{
				byte[] array5 = MetaUtils.ConvertToBytes<Array_byte>(keyValuePair5.Value);
				Buffer.BlockCopy(array5, 0, data, keyValuePair5.Key, array5.Length);
			}
			foreach (KeyValuePair<int, Array_float> keyValuePair6 in this.Floats)
			{
				byte[] array6 = MetaUtils.ConvertToBytes<Array_float>(keyValuePair6.Value);
				Buffer.BlockCopy(array6, 0, data, keyValuePair6.Key, array6.Length);
			}
			foreach (KeyValuePair<int, Array_Vector3> keyValuePair7 in this.Float_XYZs)
			{
				byte[] array7 = MetaUtils.ConvertToBytes<Array_Vector3>(keyValuePair7.Value);
				Buffer.BlockCopy(array7, 0, data, keyValuePair7.Key, array7.Length);
			}
			foreach (KeyValuePair<int, Array_uint> keyValuePair8 in this.Hashes)
			{
				byte[] array8 = MetaUtils.ConvertToBytes<Array_uint>(keyValuePair8.Value);
				Buffer.BlockCopy(array8, 0, data, keyValuePair8.Key, array8.Length);
			}
		}

		// Token: 0x040036E9 RID: 14057
		public Dictionary<int, Array_Structure> Structures;

		// Token: 0x040036EA RID: 14058
		public Dictionary<int, Array_StructurePointer> StructurePointers;

		// Token: 0x040036EB RID: 14059
		public Dictionary<int, Array_uint> UInts;

		// Token: 0x040036EC RID: 14060
		public Dictionary<int, Array_ushort> UShorts;

		// Token: 0x040036ED RID: 14061
		public Dictionary<int, Array_byte> UBytes;

		// Token: 0x040036EE RID: 14062
		public Dictionary<int, Array_float> Floats;

		// Token: 0x040036EF RID: 14063
		public Dictionary<int, Array_Vector3> Float_XYZs;

		// Token: 0x040036F0 RID: 14064
		public Dictionary<int, Array_uint> Hashes;
	}
}
