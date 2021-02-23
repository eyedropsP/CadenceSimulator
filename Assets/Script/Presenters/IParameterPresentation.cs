using CadenceSimulator.Models;

namespace CadenceSimulator.Presenters
{
	public interface IParameterPresentation
	{
		void Show(Cadence cadence, HeartRate heartRate, Stamina stamina);
	}
}