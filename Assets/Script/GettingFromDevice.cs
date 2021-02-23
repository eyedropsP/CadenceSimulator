using UnityEngine;
using UnityEngine.InputSystem;

namespace CadenceSimulator
{
	public class GettingFromDevice : MonoBehaviour
	{
		[SerializeField] private InputAction jumpInput;
		[SerializeField] private InputAction moveInput;

		private void Awake()
		{
			jumpInput.performed += context =>
			{
				var value = context.ReadValue<float>();
				if (value > 0)
				{
					Debug.Log("Jump");
				}
			};

			moveInput.performed += context =>
			{
				var value = context.ReadValue<Vector2>();
				Debug.Log($"position {value.x}, {value.y}");
			};
		}

		private void OnEnable()
		{
			jumpInput.Enable();
			moveInput.Enable();
		}

		private void OnDestroy()
		{
			jumpInput.Disable();
			moveInput.Disable();
		}
	}
}