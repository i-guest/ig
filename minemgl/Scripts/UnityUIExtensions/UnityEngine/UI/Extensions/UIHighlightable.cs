using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/UI Highlightable Extension")]
	[RequireComponent(typeof(RectTransform), typeof(Graphic))]
	public class UIHighlightable : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler, IPointerDownHandler, IPointerUpHandler
	{
		[Serializable]
		public class InteractableChangedEvent : UnityEvent<bool>
		{
		}

		[Serializable]
		public class HighlightChangedEvent : UnityEvent<bool>
		{
		}

		[Serializable]
		public class PressChangedEvent : UnityEvent<bool>
		{
		}

		private Graphic m_Graphic;

		private bool m_Highlighted;

		private bool m_Pressed;

		[SerializeField]
		[Tooltip("Can this panel be interacted with or is it disabled? (does not affect child components)")]
		private bool m_Interactable = true;

		[SerializeField]
		[Tooltip("Does the panel remain in the pressed state when clicked? (default false)")]
		private bool m_ClickToHold;

		[Tooltip("The default color for the panel")]
		public Color NormalColor = Color.grey;

		[Tooltip("The color for the panel when a mouse is over it or it is in focus")]
		public Color HighlightedColor = Color.yellow;

		[Tooltip("The color for the panel when it is clicked/held")]
		public Color PressedColor = Color.green;

		[Tooltip("The color for the panel when it is not interactable (see Interactable)")]
		public Color DisabledColor = Color.gray;

		[Tooltip("Event for when the panel is enabled / disabled, to enable disabling / enabling of child or other gameobjects")]
		public InteractableChangedEvent OnInteractableChanged;

		[Tooltip("Event for when the panel highlight state is activated or deactivated")]
		public HighlightChangedEvent OnHighlightChanged;

		[Tooltip("Event for when the panel press state is activated or deactivated")]
		public PressChangedEvent OnPressChanged;

		public bool Interactable
		{
			get
			{
				return m_Interactable;
			}
			set
			{
				m_Interactable = value;
				HighlightInteractable(m_Graphic);
				OnInteractableChanged?.Invoke(m_Interactable);
				if (!m_Interactable)
				{
					if (m_Highlighted)
					{
						m_Highlighted = false;
						OnHighlightChanged?.Invoke(arg0: false);
					}
					if (m_Pressed)
					{
						m_Pressed = false;
						OnPressChanged?.Invoke(arg0: false);
					}
				}
			}
		}

		public bool ClickToHold
		{
			get
			{
				return m_ClickToHold;
			}
			set
			{
				m_ClickToHold = value;
				if (!m_ClickToHold && m_Pressed)
				{
					m_Pressed = false;
					OnPressChanged?.Invoke(arg0: false);
				}
			}
		}

		public bool Highlighted
		{
			get
			{
				return m_Highlighted;
			}
			set
			{
				if (m_Highlighted != value)
				{
					m_Highlighted = value;
					HighlightInteractable(m_Graphic);
					if (m_Interactable)
					{
						OnHighlightChanged?.Invoke(m_Highlighted);
					}
				}
			}
		}

		public bool Pressed
		{
			get
			{
				return m_Pressed;
			}
			set
			{
				if (m_Pressed != value)
				{
					m_Pressed = value;
					m_Graphic.color = (m_Pressed ? PressedColor : NormalColor);
					if (m_Interactable)
					{
						OnPressChanged?.Invoke(m_Pressed);
					}
				}
			}
		}

		private void Awake()
		{
			m_Graphic = GetComponent<Graphic>();
		}

		public void OnPointerEnter(PointerEventData eventData)
		{
			if (Interactable && !m_Pressed)
			{
				m_Highlighted = true;
				m_Graphic.color = HighlightedColor;
				OnHighlightChanged?.Invoke(arg0: true);
			}
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			if (Interactable && !m_Pressed)
			{
				m_Highlighted = false;
				m_Graphic.color = NormalColor;
				OnHighlightChanged?.Invoke(arg0: false);
			}
		}

		public void OnPointerDown(PointerEventData eventData)
		{
			if (!Interactable)
			{
				return;
			}
			m_Graphic.color = PressedColor;
			if (ClickToHold)
			{
				if (m_Pressed)
				{
					m_Pressed = false;
					return;
				}
				m_Pressed = true;
				OnPressChanged?.Invoke(arg0: true);
			}
			else
			{
				OnPressChanged?.Invoke(arg0: true);
			}
		}

		public void OnPointerUp(PointerEventData eventData)
		{
			if (!m_Pressed)
			{
				HighlightInteractable(m_Graphic);
				if (m_Interactable)
				{
					OnPressChanged?.Invoke(arg0: false);
				}
			}
		}

		private void HighlightInteractable(Graphic graphic)
		{
			if (m_Interactable)
			{
				if (m_Highlighted)
				{
					graphic.color = HighlightedColor;
				}
				else
				{
					graphic.color = NormalColor;
				}
			}
			else
			{
				graphic.color = DisabledColor;
			}
		}
	}
}
