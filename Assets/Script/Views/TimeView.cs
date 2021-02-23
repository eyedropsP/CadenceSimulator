using CadenceSimulator.Presenters;
using TMPro;
using UnityEngine;

namespace CadenceSimulator.Views
{
	public class TimeView : MonoBehaviour, ITimePresentation
	{
		[SerializeField] private TextMeshProUGUI countDownTimeTMP;
		[SerializeField] private TextMeshProUGUI gameTimeTMP;

		private TimePresenter timePresentation;

		private void Start()
		{
			timePresentation = new TimePresenter(this);
		}

		public void ShowCountDown(int time)
		{
			countDownTimeTMP.text = time.ToString();
		}

		public void ShowGameTime(float time)
		{
			gameTimeTMP.text = $"残り時間 : {time:F}";
		}
	}
}