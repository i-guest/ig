using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/Cooldown Button")]
	public class CooldownButton : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, ISubmitHandler
	{
		[Serializable]
		public class CooldownButtonEvent : UnityEvent<GameObject>
		{
		}

		[SerializeField]
		private float cooldownTimeout;

		[SerializeField]
		private float cooldownSpeed = 1f;

		[SerializeField]
		[ReadOnly]
		private bool cooldownActive;

		[SerializeField]
		[ReadOnly]
		private bool cooldownInEffect;

		[SerializeField]
		[ReadOnly]
		private float cooldownTimeElapsed;

		[SerializeField]
		[ReadOnly]
		private float cooldownTimeRemaining;

		[SerializeField]
		[ReadOnly]
		private int cooldownPercentRemaining;

		[SerializeField]
		[ReadOnly]
		private int cooldownPercentComplete;

		private BaseEventData buttonSource;

		[Tooltip("Event that fires when a button is initially pressed down")]
		public CooldownButtonEvent OnCooldownStart;

		[Tooltip("Event that fires when a button is released")]
		public CooldownButtonEvent OnButtonClickDuringCooldown;

		[Tooltip("Event that continually fires while a button is held down")]
		public CooldownButtonEvent OnCoolDownFinish;

		public float CooldownTimeout
		{
			get
			{
				return cooldownTimeout;
			}
			set
			{
				cooldownTimeout = value;
			}
		}

		public float CooldownSpeed
		{
			get
			{
				return cooldownSpeed;
			}
			set
			{
				cooldownSpeed = value;
			}
		}

		public bool CooldownInEffect => cooldownInEffect;

		public bool CooldownActive
		{
			get
			{
				return cooldownActive;
			}
			set
			{
				cooldownActive = value;
			}
		}

		public float CooldownTimeElapsed
		{
			get
			{
				return cooldownTimeElapsed;
			}
			set
			{
				cooldownTimeElapsed = value;
			}
		}

		public float CooldownTimeRemaining => cooldownTimeRemaining;

		public int CooldownPercentRemaining => cooldownPercentRemaining;

		public int CooldownPercentComplete => cooldownPercentComplete;

		private void Update()
		{
			if (CooldownActive)
			{
				cooldownTimeRemaining -= Time.deltaTime * cooldownSpeed;
				cooldownTimeElapsed = CooldownTimeout - CooldownTimeRemaining;
				if (cooldownTimeRemaining < 0f)
				{
					StopCooldown();
					return;
				}
				cooldownPercentRemaining = (int)(100f * cooldownTimeRemaining * CooldownTimeout / 100f);
				cooldownPercentComplete = (int)((CooldownTimeout - cooldownTimeRemaining) / CooldownTimeout * 100f);
			}
		}

		public void PauseCooldown()
		{
			if (CooldownInEffect)
			{
				CooldownActive = false;
			}
		}

		public void RestartCooldown()
		{
			if (CooldownInEffect)
			{
				CooldownActive = true;
			}
		}

		public void StartCooldown()
		{
			BaseEventData baseEventData = (buttonSource = new BaseEventData(EventSystem.current));
			OnCooldownStart.Invoke(baseEventData.selectedObject);
			cooldownTimeRemaining = cooldownTimeout;
			CooldownActive = (cooldownInEffect = true);
		}

		public void StopCooldown()
		{
			cooldownTimeElapsed = CooldownTimeout;
			cooldownTimeRemaining = 0f;
			cooldownPercentRemaining = 0;
			cooldownPercentComplete = 100;
			cooldownActive = (cooldownInEffect = false);
			OnCoolDownFinish?.Invoke(buttonSource.selectedObject);
		}

		public void CancelCooldown()
		{
			cooldownActive = (cooldownInEffect = false);
		}

		void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
		{
			HandleButtonClick(eventData);
		}

		public void OnSubmit(BaseEventData eventData)
		{
			HandleButtonClick(eventData);
		}

		public void HandleButtonClick(BaseEventData eventData)
		{
			buttonSource = eventData;
			if (CooldownInEffect)
			{
				OnButtonClickDuringCooldown?.Invoke(buttonSource.selectedObject);
			}
			if (!CooldownInEffect)
			{
				OnCooldownStart?.Invoke(buttonSource.selectedObject);
				cooldownTimeRemaining = cooldownTimeout;
				cooldownActive = (cooldownInEffect = true);
			}
		}
	}
}
