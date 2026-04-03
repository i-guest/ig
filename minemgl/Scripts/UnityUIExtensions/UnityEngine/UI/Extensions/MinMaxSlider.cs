using System;
using TMPro;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/Sliders/MinMax Slider")]
	public class MinMaxSlider : Selectable, IBeginDragHandler, IEventSystemHandler, IDragHandler, IEndDragHandler
	{
		private enum DragState
		{
			Both = 0,
			Min = 1,
			Max = 2
		}

		[Serializable]
		public class SliderEvent : UnityEvent<float, float>
		{
		}

		[Header("UI Controls")]
		[SerializeField]
		private Camera customCamera;

		[SerializeField]
		private RectTransform sliderBounds;

		[SerializeField]
		private RectTransform minHandle;

		[SerializeField]
		private RectTransform maxHandle;

		[SerializeField]
		private RectTransform middleGraphic;

		[Header("Display Text (Optional)")]
		[SerializeField]
		private TextMeshProUGUI minText;

		[SerializeField]
		private TextMeshProUGUI maxText;

		[SerializeField]
		private string textFormat = "0";

		[Header("Limits")]
		[SerializeField]
		private float minLimit;

		[SerializeField]
		private float maxLimit = 100f;

		[Header("Values")]
		public bool wholeNumbers;

		[SerializeField]
		private float minValue = 25f;

		[SerializeField]
		private float maxValue = 75f;

		public SliderEvent onValueChanged = new SliderEvent();

		private Vector2 dragStartPosition;

		private float dragStartMinValue01;

		private float dragStartMaxValue01;

		private DragState dragState;

		private bool passDragEvents;

		private Camera mainCamera;

		private Canvas parentCanvas;

		private bool isOverlayCanvas;

		public MinMaxValues Values => new MinMaxValues(minValue, maxValue, minLimit, maxLimit);

		public RectTransform SliderBounds
		{
			get
			{
				return sliderBounds;
			}
			set
			{
				sliderBounds = value;
			}
		}

		public RectTransform MinHandle
		{
			get
			{
				return minHandle;
			}
			set
			{
				minHandle = value;
			}
		}

		public RectTransform MaxHandle
		{
			get
			{
				return maxHandle;
			}
			set
			{
				maxHandle = value;
			}
		}

		public RectTransform MiddleGraphic
		{
			get
			{
				return middleGraphic;
			}
			set
			{
				middleGraphic = value;
			}
		}

		public TextMeshProUGUI MinText
		{
			get
			{
				return minText;
			}
			set
			{
				minText = value;
			}
		}

		public TextMeshProUGUI MaxText
		{
			get
			{
				return maxText;
			}
			set
			{
				maxText = value;
			}
		}

		protected override void Start()
		{
			base.Start();
			if (!sliderBounds)
			{
				sliderBounds = base.transform as RectTransform;
			}
			parentCanvas = GetComponentInParent<Canvas>();
			isOverlayCanvas = parentCanvas.renderMode == RenderMode.ScreenSpaceOverlay;
			mainCamera = ((customCamera != null) ? customCamera : Camera.main);
		}

		public void SetLimits(float minLimit, float maxLimit)
		{
			this.minLimit = (wholeNumbers ? ((float)Mathf.RoundToInt(minLimit)) : minLimit);
			this.maxLimit = (wholeNumbers ? ((float)Mathf.RoundToInt(maxLimit)) : maxLimit);
		}

		public void SetValues(MinMaxValues values, bool notify = true)
		{
			SetValues(values.minValue, values.maxValue, values.minLimit, values.maxLimit, notify);
		}

		public void SetValues(float minValue, float maxValue, bool notify = true)
		{
			SetValues(minValue, maxValue, minLimit, maxLimit, notify);
		}

		public void SetValues(float minValue, float maxValue, float minLimit, float maxLimit, bool notify = true)
		{
			this.minValue = (wholeNumbers ? ((float)Mathf.RoundToInt(minValue)) : minValue);
			this.maxValue = (wholeNumbers ? ((float)Mathf.RoundToInt(maxValue)) : maxValue);
			SetLimits(minLimit, maxLimit);
			RefreshSliders();
			UpdateText();
			UpdateMiddleGraphic();
			if (notify)
			{
				onValueChanged.Invoke(this.minValue, this.maxValue);
			}
		}

		private void RefreshSliders()
		{
			SetSliderAnchors();
			float input = Mathf.Clamp(minValue, minLimit, maxLimit);
			SetMinHandleValue01(minHandle, GetPercentage(minLimit, maxLimit, input));
			float input2 = Mathf.Clamp(maxValue, minLimit, maxLimit);
			SetMaxHandleValue01(maxHandle, GetPercentage(minLimit, maxLimit, input2));
		}

		private void SetSliderAnchors()
		{
			minHandle.anchorMin = new Vector2(0f, 0.5f);
			minHandle.anchorMax = new Vector2(0f, 0.5f);
			minHandle.pivot = new Vector2(0.5f, 0.5f);
			maxHandle.anchorMin = new Vector2(1f, 0.5f);
			maxHandle.anchorMax = new Vector2(1f, 0.5f);
			maxHandle.pivot = new Vector2(0.5f, 0.5f);
		}

		private void UpdateText()
		{
			if ((bool)minText)
			{
				minText.SetText(minValue.ToString(textFormat));
			}
			if ((bool)maxText)
			{
				maxText.SetText(maxValue.ToString(textFormat));
			}
		}

		private void UpdateMiddleGraphic()
		{
			if ((bool)middleGraphic)
			{
				middleGraphic.anchorMin = Vector2.zero;
				middleGraphic.anchorMax = Vector2.one;
				middleGraphic.offsetMin = new Vector2(minHandle.anchoredPosition.x, 0f);
				middleGraphic.offsetMax = new Vector2(maxHandle.anchoredPosition.x, 0f);
			}
		}

		public void OnBeginDrag(PointerEventData eventData)
		{
			passDragEvents = Math.Abs(eventData.delta.x) < Math.Abs(eventData.delta.y);
			if (passDragEvents)
			{
				PassDragEvents(delegate(IBeginDragHandler x)
				{
					x.OnBeginDrag(eventData);
				});
				return;
			}
			Camera cam = (isOverlayCanvas ? null : mainCamera);
			RectTransformUtility.ScreenPointToLocalPointInRectangle(sliderBounds, eventData.position, cam, out dragStartPosition);
			float valueOfPointInSliderBounds = GetValueOfPointInSliderBounds01(dragStartPosition);
			dragStartMinValue01 = GetMinHandleValue01(minHandle);
			dragStartMaxValue01 = GetMaxHandleValue01(maxHandle);
			if (valueOfPointInSliderBounds < dragStartMinValue01 || RectTransformUtility.RectangleContainsScreenPoint(minHandle, eventData.position, cam))
			{
				dragState = DragState.Min;
				minHandle.SetAsLastSibling();
			}
			else if (valueOfPointInSliderBounds > dragStartMaxValue01 || RectTransformUtility.RectangleContainsScreenPoint(maxHandle, eventData.position, cam))
			{
				dragState = DragState.Max;
				maxHandle.SetAsLastSibling();
			}
			else
			{
				dragState = DragState.Both;
			}
		}

		public void OnDrag(PointerEventData eventData)
		{
			if (passDragEvents)
			{
				PassDragEvents(delegate(IDragHandler x)
				{
					x.OnDrag(eventData);
				});
			}
			else
			{
				if (!minHandle || !maxHandle)
				{
					return;
				}
				RectTransformUtility.ScreenPointToLocalPointInRectangle(sliderBounds, eventData.position, isOverlayCanvas ? null : mainCamera, out var localPoint);
				SetSliderAnchors();
				if (dragState == DragState.Min || dragState == DragState.Max)
				{
					float valueOfPointInSliderBounds = GetValueOfPointInSliderBounds01(localPoint);
					float minHandleValue = GetMinHandleValue01(minHandle);
					float maxHandleValue = GetMaxHandleValue01(maxHandle);
					if (dragState == DragState.Min)
					{
						SetMinHandleValue01(minHandle, Mathf.Clamp(valueOfPointInSliderBounds, 0f, maxHandleValue));
					}
					else if (dragState == DragState.Max)
					{
						SetMaxHandleValue01(maxHandle, Mathf.Clamp(valueOfPointInSliderBounds, minHandleValue, 1f));
					}
				}
				else
				{
					float num = (localPoint.x - dragStartPosition.x) / sliderBounds.rect.width;
					SetMinHandleValue01(minHandle, dragStartMinValue01 + num);
					SetMaxHandleValue01(maxHandle, dragStartMaxValue01 + num);
				}
				float num2 = Mathf.Lerp(minLimit, maxLimit, GetMinHandleValue01(minHandle));
				float num3 = Mathf.Lerp(minLimit, maxLimit, GetMaxHandleValue01(maxHandle));
				SetValues(num2, num3);
				UpdateText();
				UpdateMiddleGraphic();
			}
		}

		public void OnEndDrag(PointerEventData eventData)
		{
			if (passDragEvents)
			{
				PassDragEvents(delegate(IEndDragHandler x)
				{
					x.OnEndDrag(eventData);
				});
				return;
			}
			float minHandleValue = GetMinHandleValue01(minHandle);
			float maxHandleValue = GetMaxHandleValue01(maxHandle);
			if (Math.Abs(minHandleValue) < 0.01f && Math.Abs(maxHandleValue) < 0.01f)
			{
				maxHandle.SetAsLastSibling();
			}
			else if (Math.Abs(minHandleValue - 1f) < 0.01f && Math.Abs(maxHandleValue - 1f) < 0.01f)
			{
				minHandle.SetAsLastSibling();
			}
		}

		private void PassDragEvents<T>(Action<T> callback) where T : IEventSystemHandler
		{
			Transform parent = base.transform.parent;
			while (parent != null)
			{
				Component[] components = parent.GetComponents<Component>();
				foreach (Component component in components)
				{
					if (component is T)
					{
						callback((T)(IEventSystemHandler)component);
						return;
					}
				}
				parent = parent.parent;
			}
		}

		private void SetMaxHandleValue01(RectTransform handle, float value01)
		{
			handle.anchoredPosition = new Vector2(value01 * sliderBounds.rect.width - sliderBounds.rect.width + sliderBounds.offsetMax.x, handle.anchoredPosition.y);
		}

		private void SetMinHandleValue01(RectTransform handle, float value01)
		{
			handle.anchoredPosition = new Vector2(value01 * sliderBounds.rect.width + sliderBounds.offsetMin.x, handle.anchoredPosition.y);
		}

		private float GetMaxHandleValue01(RectTransform handle)
		{
			return 1f + (handle.anchoredPosition.x - sliderBounds.offsetMax.x) / sliderBounds.rect.width;
		}

		private float GetMinHandleValue01(RectTransform handle)
		{
			return (handle.anchoredPosition.x - sliderBounds.offsetMin.x) / sliderBounds.rect.width;
		}

		private float GetValueOfPointInSliderBounds01(Vector2 position)
		{
			float width = sliderBounds.rect.width;
			return Mathf.Clamp((position.x + width / 2f) / width, 0f, 1f);
		}

		private static float GetPercentage(float min, float max, float input)
		{
			return (input - min) / (max - min);
		}
	}
}
