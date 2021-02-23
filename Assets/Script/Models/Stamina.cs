namespace CadenceSimulator.Models
{
	public class Stamina
	{
		private int value;

		public Stamina(int value)
		{
			this.value = value;
		}

		public override string ToString()
		{
			return $"Stamina : {value}";
		}
	}
}