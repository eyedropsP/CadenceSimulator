using CadenceSimulator.Models;
using CadenceSimulator.Presenters;
using TMPro;
using UnityEngine;

namespace CadenceSimulator.Views
{
    public class ParameterView : MonoBehaviour, IParameterPresentation
    {
        [SerializeField] private TextMeshProUGUI cadenceTMP;
        [SerializeField] private TextMeshProUGUI heartRateTMP;
        [SerializeField] private TextMeshProUGUI staminaTMP;

        private ParameterPresenter presenter;
        
        private void Start()
        {
            presenter = new ParameterPresenter(this);
        }

        public void Show(Cadence cadence, HeartRate heartRate, Stamina stamina)
        {
            cadenceTMP.text = cadence.ToString();
            heartRateTMP.text = heartRate.ToString();
            staminaTMP.text = stamina.ToString();
        }
    }
}