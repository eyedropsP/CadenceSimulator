namespace CadenceSimulator.Models
{
	public class HeartRate
	{
		private float value;
		public HeartRate(float value)
		{
			this.value = value;
		}
		public override string ToString()
		{
			return $"Heart Rate : {value} bpm";
		}
	}
}