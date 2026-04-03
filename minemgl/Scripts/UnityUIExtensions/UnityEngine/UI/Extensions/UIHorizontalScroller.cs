using TMPro;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("Layout/Extensions/Horizontal Scroller")]
	public class UIHorizontalScroller : MonoBehaviour
	{
		private float[] distReposition;

		private float[] distance;

		[SerializeField]
		[Tooltip("desired ScrollRect")]
		private ScrollRect scrollRect;

		[SerializeField]
		[Tooltip("Elements to populate inside the scroller")]
		private GameObject[] arrayOfElements;

		[SerializeField]
		[Tooltip("Center display area (position of zoomed content)")]
		private RectTransform center;

		[SerializeField]
		[Tooltip("Size / spacing of elements")]
		private RectTransform elementSize;

		[SerializeField]
		[Tooltip("Scale = 1/ (1+distance from center * shrinkage)")]
		private Vector2 elementShrinkage = new Vector2(0.005f, 0.005f);

		[SerializeField]
		[Tooltip("Minimum element scale (furthest from center)")]
		private Vector2 minScale = new Vector2(0.7f, 0.7f);

		[SerializeField]
		[Tooltip("Select the item to be in center on start. (optional)")]
		private int startingIndex = -1;

		[SerializeField]
		[Tooltip("Stop scrolling past last element from inertia.")]
		private bool stopMomentumOnEnd = true;

		[SerializeField]
		[Tooltip("Set Items out of center to not interactible.")]
		private bool disableUnfocused = true;

		[SerializeField]
		[Tooltip("Button to go to the next page. (optional)")]
		private GameObject scrollLeftButton;

		[SerializeField]
		[Tooltip("Button to go to the previous page. (optional)")]
		private GameObject scrollRightButton;

		[SerializeField]
		[Tooltip("Event fired when a specific item is clicked, exposes index number of item. (optional)")]
		private UnityEvent<int> onButtonClicked;

		[SerializeField]
		[Tooltip("Event fired when the focused item is Changed. (optional)")]
		private UnityEvent<int> onFocusChanged;

		public int FocusedElementIndex { get; private set; }

		public RectTransform Center
		{
			get
			{
				return center;
			}
			set
			{
				center = value;
			}
		}

		public RectTransform ScrollingPanel => scrollRect.content;

		public string Result { get; private set; }

		public UIHorizontalScroller()
		{
		}

		public UIHorizontalScroller(RectTransform center, RectTransform elementSize, ScrollRect scrollRect, GameObject[] arrayOfElements)
		{
			this.scrollRect = scrollRect;
			this.elementSize = elementSize;
			this.arrayOfElements = arrayOfElements;
			this.center = center;
		}

		public void Awake()
		{
			if (!scrollRect)
			{
				scrollRect = GetComponent<ScrollRect>();
			}
			if (!center)
			{
				Debug.LogError("Please define the RectTransform for the Center viewport of the scrollable area");
			}
			if (!elementSize)
			{
				elementSize = center;
			}
			if (arrayOfElements != null && arrayOfElements.Length != 0)
			{
				return;
			}
			int childCount = scrollRect.content.childCount;
			if (childCount > 0)
			{
				arrayOfElements = new GameObject[childCount];
				for (int i = 0; i < childCount; i++)
				{
					arrayOfElements[i] = scrollRect.content.GetChild(i).gameObject;
				}
			}
		}

		public void Start()
		{
			if ((bool)scrollLeftButton)
			{
				scrollLeftButton.GetComponent<Button>().onClick.AddListener(delegate
				{
					ScrollLeft();
				});
			}
			if ((bool)scrollRightButton)
			{
				scrollRightButton.GetComponent<Button>().onClick.AddListener(delegate
				{
					ScrollRight();
				});
			}
			UpdateChildren(startingIndex, arrayOfElements);
		}

		public void UpdateChildren(int startingIndex = -1, GameObject[] arrayOfElements = null)
		{
			if (arrayOfElements != null)
			{
				this.arrayOfElements = arrayOfElements;
			}
			else
			{
				this.arrayOfElements = new GameObject[ScrollingPanel.childCount];
				for (int i = 0; i < ScrollingPanel.childCount; i++)
				{
					this.arrayOfElements[i] = ScrollingPanel.GetChild(i).gameObject;
				}
			}
			for (int j = 0; j < this.arrayOfElements.Length; j++)
			{
				AddListener(arrayOfElements[j], j);
				RectTransform component = this.arrayOfElements[j].GetComponent<RectTransform>();
				Vector2 vector = (component.pivot = new Vector2(0.5f, 0.5f));
				Vector2 anchorMax = (component.anchorMin = vector);
				component.anchorMax = anchorMax;
				component.localPosition = new Vector2((float)j * elementSize.rect.size.x, 0f);
				component.sizeDelta = elementSize.rect.size;
			}
			distance = new float[this.arrayOfElements.Length];
			distReposition = new float[this.arrayOfElements.Length];
			FocusedElementIndex = -1;
			if (startingIndex > -1)
			{
				startingIndex = ((startingIndex > this.arrayOfElements.Length) ? (this.arrayOfElements.Length - 1) : startingIndex);
				SnapToElement(startingIndex);
			}
		}

		private void AddListener(GameObject button, int index)
		{
			Button component = button.GetComponent<Button>();
			component.onClick.RemoveAllListeners();
			component.onClick.AddListener(delegate
			{
				onButtonClicked?.Invoke(index);
			});
		}

		public void Update()
		{
			if (arrayOfElements.Length < 1)
			{
				return;
			}
			for (int i = 0; i < arrayOfElements.Length; i++)
			{
				RectTransform component = arrayOfElements[i].GetComponent<RectTransform>();
				distReposition[i] = center.position.x - component.position.x;
				distance[i] = Mathf.Abs(distReposition[i]);
				Vector2 vector = Vector2.Max(minScale, new Vector2(1f / (1f + distance[i] * elementShrinkage.x), 1f / (1f + distance[i] * elementShrinkage.y)));
				component.transform.localScale = new Vector3(vector.x, vector.y, 1f);
			}
			float num = Mathf.Min(distance);
			int focusedElementIndex = FocusedElementIndex;
			for (int j = 0; j < arrayOfElements.Length; j++)
			{
				arrayOfElements[j].GetComponent<CanvasGroup>().interactable = !disableUnfocused || num == distance[j];
				if (num == distance[j])
				{
					FocusedElementIndex = j;
					TMP_Text componentInChildren = arrayOfElements[j].GetComponentInChildren<TMP_Text>();
					if (componentInChildren != null)
					{
						Result = componentInChildren.text;
					}
				}
			}
			if (FocusedElementIndex != focusedElementIndex && onFocusChanged != null)
			{
				onFocusChanged.Invoke(FocusedElementIndex);
			}
			if (!UIExtensionsInputManager.GetMouseButton(0))
			{
				ScrollingElements();
			}
			if (stopMomentumOnEnd && (arrayOfElements[0].GetComponent<RectTransform>().position.x > center.position.x || arrayOfElements[arrayOfElements.Length - 1].GetComponent<RectTransform>().position.x < center.position.x))
			{
				scrollRect.velocity = Vector2.zero;
			}
		}

		private void ScrollingElements()
		{
			float x = Mathf.Lerp(ScrollingPanel.anchoredPosition.x, ScrollingPanel.anchoredPosition.x + distReposition[FocusedElementIndex], Time.deltaTime * 2f);
			Vector2 anchoredPosition = new Vector2(x, ScrollingPanel.anchoredPosition.y);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}

		public void SnapToElement(int element)
		{
			float num = elementSize.rect.width / 1.2f * (float)element;
			Vector2 anchoredPosition = new Vector2(0f - num, ScrollingPanel.anchoredPosition.y);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}

		public void ScrollLeft()
		{
			float num = elementSize.rect.width / 1.2f;
			Vector2 b = new Vector2(ScrollingPanel.anchoredPosition.x - num, ScrollingPanel.anchoredPosition.y);
			ScrollingPanel.anchoredPosition = Vector2.Lerp(ScrollingPanel.anchoredPosition, b, 1f);
		}

		public void ScrollRight()
		{
			float num = elementSize.rect.width / 1.2f;
			Vector2 anchoredPosition = new Vector2(ScrollingPanel.anchoredPosition.x + num, ScrollingPanel.anchoredPosition.y);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}
	}
}
