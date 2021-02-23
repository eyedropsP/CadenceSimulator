using System;
using UniRx;
using UnityEngine;

namespace CadenceSimulator
{
	public class InputPresenter : IInputPresenter, IDisposable
	{
		private readonly CompositeDisposable compositeDisposable = new CompositeDisposable();
		private readonly ReactiveProperty<bool> leftRowButtonPressed = new ReactiveProperty<bool>();
		private readonly ReactiveProperty<bool> rightRowButtonPressed = new ReactiveProperty<bool>();

		public IReadOnlyReactiveProperty<bool> LeftRowButtonPressed => leftRowButtonPressed;
		public IReadOnlyReactiveProperty<bool> RightRowButtonPressed => rightRowButtonPressed;

		public InputPresenter()
		{
			Observable.EveryUpdate()
				.ObserveOnMainThread()
				.Select(_ => Input.GetKeyDown(KeyCode.A))
				.DistinctUntilChanged()
				.Subscribe(x => leftRowButtonPressed.Value = x)
				.AddTo(compositeDisposable);

			Observable.EveryUpdate()
				.ObserveOnMainThread()
				.Select(_ => Input.GetKeyDown(KeyCode.D))
				.DistinctUntilChanged()
				.Subscribe(x => rightRowButtonPressed.Value = x)
				.AddTo(compositeDisposable);
		}

		public void Dispose()
		{
			compositeDisposable.Dispose();
		}
	}
}