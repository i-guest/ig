using TMPro;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("Layout/Extensions/Vertical Scroller")]
	public class UIVerticalScroller : MonoBehaviour
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
		[Tooltip("Select the item to be in center on start.")]
		private int startingIndex = -1;

		[SerializeField]
		[Tooltip("Stop scrolling past last element from inertia.")]
		private bool stopMomentumOnEnd = true;

		[SerializeField]
		[Tooltip("Set Items out of center to not interactible.")]
		private bool disableUnfocused = true;

		[SerializeField]
		[Tooltip("Button to go to the next page. (optional)")]
		private GameObject scrollUpButton;

		[SerializeField]
		[Tooltip("Button to go to the previous page. (optional)")]
		private GameObject scrollDownButton;

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

		public string Result { get; private set; }

		public RectTransform ScrollingPanel => scrollRect.content;

		public UIVerticalScroller(RectTransform center, RectTransform elementSize, ScrollRect scrollRect, GameObject[] arrayOfElements)
		{
			this.center = center;
			this.elementSize = elementSize;
			this.scrollRect = scrollRect;
			this.arrayOfElements = arrayOfElements;
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
			int childCount = ScrollingPanel.childCount;
			if (childCount > 0)
			{
				arrayOfElements = new GameObject[childCount];
				for (int i = 0; i < childCount; i++)
				{
					arrayOfElements[i] = ScrollingPanel.GetChild(i).gameObject;
				}
			}
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
				component.localPosition = new Vector2(0f, (float)j * elementSize.rect.size.y);
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

		public void Start()
		{
			if ((bool)scrollUpButton)
			{
				scrollUpButton.GetComponent<Button>().onClick.AddListener(delegate
				{
					ScrollUp();
				});
			}
			if ((bool)scrollDownButton)
			{
				scrollDownButton.GetComponent<Button>().onClick.AddListener(delegate
				{
					ScrollDown();
				});
			}
			UpdateChildren(startingIndex, arrayOfElements);
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
				distReposition[i] = center.position.y - component.position.y;
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
			if (FocusedElementIndex != focusedElementIndex)
			{
				onFocusChanged?.Invoke(FocusedElementIndex);
			}
			if (!UIExtensionsInputManager.GetMouseButton(0))
			{
				ScrollingElements();
			}
			if (stopMomentumOnEnd && (arrayOfElements[0].GetComponent<RectTransform>().position.y > center.position.y || arrayOfElements[arrayOfElements.Length - 1].GetComponent<RectTransform>().position.y < center.position.y))
			{
				scrollRect.velocity = Vector2.zero;
			}
		}

		private void ScrollingElements()
		{
			float y = Mathf.Lerp(ScrollingPanel.anchoredPosition.y, ScrollingPanel.anchoredPosition.y + distReposition[FocusedElementIndex], Time.deltaTime * 2f);
			Vector2 anchoredPosition = new Vector2(ScrollingPanel.anchoredPosition.x, y);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}

		public void SnapToElement(int element)
		{
			float num = elementSize.rect.height * (float)element;
			Vector2 anchoredPosition = new Vector2(ScrollingPanel.anchoredPosition.x, 0f - num);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}

		public void ScrollUp()
		{
			float num = elementSize.rect.height / 1.2f;
			Vector2 b = new Vector2(ScrollingPanel.anchoredPosition.x, ScrollingPanel.anchoredPosition.y - num);
			ScrollingPanel.anchoredPosition = Vector2.Lerp(ScrollingPanel.anchoredPosition, b, 1f);
		}

		public void ScrollDown()
		{
			float num = elementSize.rect.height / 1.2f;
			Vector2 anchoredPosition = new Vector2(ScrollingPanel.anchoredPosition.x, ScrollingPanel.anchoredPosition.y + num);
			ScrollingPanel.anchoredPosition = anchoredPosition;
		}
	}
}
