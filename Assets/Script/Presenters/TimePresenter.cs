namespace CadenceSimulator.Presenters
{
	public class TimePresenter
	{
		private readonly ITimePresentation timePresentation;
		
		public TimePresenter(ITimePresentation timePresentation)
		{
			this.timePresentation = timePresentation;
		}
		
		
	}
}