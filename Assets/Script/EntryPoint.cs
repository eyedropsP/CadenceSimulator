using UniRx;
using UnityEngine;

namespace CadenceSimulator
{
	public class EntryPoint : MonoBehaviour
	{
		private IInputPresenter inputPresenter;

		private void Awake()
		{
			inputPresenter = new InputPresenter();
		}

		private void Start()
		{
			inputPresenter.LeftRowButtonPressed
				.Where(x => x)
				.Subscribe(_ => Debug.Log("left row")).AddTo(this);

			inputPresenter.RightRowButtonPressed
				.Where(x => x)
				.Subscribe(_ => Debug.Log("right row")).AddTo(this);
		}
	}
}