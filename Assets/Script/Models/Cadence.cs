namespace CadenceSimulator.Models
{
	public class Cadence
	{
		private float value;
		
		public Cadence(float value)
		{
			this.value = value;
		}

		public override string ToString()
		{
			return $"Cadence : {value} rpm";
		}
	}
}