using System;

namespace RageLib.Resources.GTA5.PC.VehicleRecords
{
	// Token: 0x02000014 RID: 20
	public class VehicleRecordsEntry : ResourceSystemBlock
	{
		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00002941 File Offset: 0x00000B41
		public override long Length
		{
			get
			{
				return 32L;
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003D9C File Offset: 0x00001F9C
		public override void Read(ResourceDataReader reader, params object[] parameters)
		{
			this.Time = reader.ReadUInt32();
			this.VelocityX = reader.ReadUInt16();
			this.VelocityY = reader.ReadUInt16();
			this.VelocityZ = reader.ReadUInt16();
			this.RightX = reader.ReadByte();
			this.RightY = reader.ReadByte();
			this.RightZ = reader.ReadByte();
			this.TopX = reader.ReadByte();
			this.TopY = reader.ReadByte();
			this.TopZ = reader.ReadByte();
			this.SteeringAngle = reader.ReadByte();
			this.GasPedalPower = reader.ReadByte();
			this.BrakePedalPower = reader.ReadByte();
			this.HandbrakeUsed = reader.ReadByte();
			this.PositionX = reader.ReadSingle();
			this.PositionY = reader.ReadSingle();
			this.PositionZ = reader.ReadSingle();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003E78 File Offset: 0x00002078
		public override void Write(ResourceDataWriter writer, params object[] parameters)
		{
			writer.Write(this.Time);
			writer.Write(this.VelocityX);
			writer.Write(this.VelocityY);
			writer.Write(this.VelocityZ);
			writer.Write(this.RightX);
			writer.Write(this.RightY);
			writer.Write(this.RightZ);
			writer.Write(this.TopX);
			writer.Write(this.TopY);
			writer.Write(this.TopZ);
			writer.Write(this.SteeringAngle);
			writer.Write(this.GasPedalPower);
			writer.Write(this.BrakePedalPower);
			writer.Write(this.HandbrakeUsed);
			writer.Write(this.PositionX);
			writer.Write(this.PositionY);
			writer.Write(this.PositionZ);
		}

		// Token: 0x0400006F RID: 111
		public uint Time;

		// Token: 0x04000070 RID: 112
		public ushort VelocityX;

		// Token: 0x04000071 RID: 113
		public ushort VelocityY;

		// Token: 0x04000072 RID: 114
		public ushort VelocityZ;

		// Token: 0x04000073 RID: 115
		public byte RightX;

		// Token: 0x04000074 RID: 116
		public byte RightY;

		// Token: 0x04000075 RID: 117
		public byte RightZ;

		// Token: 0x04000076 RID: 118
		public byte TopX;

		// Token: 0x04000077 RID: 119
		public byte TopY;

		// Token: 0x04000078 RID: 120
		public byte TopZ;

		// Token: 0x04000079 RID: 121
		public byte SteeringAngle;

		// Token: 0x0400007A RID: 122
		public byte GasPedalPower;

		// Token: 0x0400007B RID: 123
		public byte BrakePedalPower;

		// Token: 0x0400007C RID: 124
		public byte HandbrakeUsed;

		// Token: 0x0400007D RID: 125
		public float PositionX;

		// Token: 0x0400007E RID: 126
		public float PositionY;

		// Token: 0x0400007F RID: 127
		public float PositionZ;
	}
}
