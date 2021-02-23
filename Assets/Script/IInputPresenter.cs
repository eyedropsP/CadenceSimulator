using UniRx;

namespace CadenceSimulator
{
	public interface IInputPresenter
	{
		public IReadOnlyReactiveProperty<bool> LeftRowButtonPressed { get; }
		public IReadOnlyReactiveProperty<bool> RightRowButtonPressed { get; }
	}
}