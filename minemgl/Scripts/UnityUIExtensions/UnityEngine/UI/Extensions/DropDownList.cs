using System;
using System.Collections.Generic;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(RectTransform))]
	[AddComponentMenu("UI/Extensions/ComboBox/Dropdown List")]
	public class DropDownList : MonoBehaviour
	{
		[Serializable]
		public class SelectionChangedEvent : UnityEvent<int>
		{
		}

		[Serializable]
		public class ControlDisabledEvent : UnityEvent<bool>
		{
		}

		public Color disabledTextColor;

		[Header("Dropdown List Items")]
		public List<DropDownListItem> Items;

		[Header("Properties")]
		[SerializeField]
		private bool isActive = true;

		public bool OverrideHighlighted = true;

		private bool _isPanelActive;

		private bool _hasDrawnOnce;

		private DropDownListButton _mainButton;

		private RectTransform _rectTransform;

		private RectTransform _overlayRT;

		private RectTransform _scrollPanelRT;

		private RectTransform _scrollBarRT;

		private RectTransform _slidingAreaRT;

		private RectTransform _scrollHandleRT;

		private RectTransform _itemsPanelRT;

		private Canvas _canvas;

		private RectTransform _canvasRT;

		private ScrollRect _scrollRect;

		private List<DropDownListButton> _panelItems = new List<DropDownListButton>();

		private GameObject _itemTemplate;

		private bool _initialized;

		private string _defaultMainButtonCaption;

		private Color _defaultNormalColor;

		[SerializeField]
		private float _scrollBarWidth = 20f;

		private int _selectedIndex = -1;

		[SerializeField]
		private int _itemsToDisplay;

		[SerializeField]
		private float dropdownOffset;

		[SerializeField]
		private bool _displayPanelAbove;

		public bool SelectFirstItemOnStart;

		[SerializeField]
		private int selectItemIndexOnStart;

		[Header("Events")]
		public SelectionChangedEvent OnSelectionChanged;

		public ControlDisabledEvent OnControlDisabled;

		public DropDownListItem SelectedItem { get; private set; }

		public float ScrollBarWidth
		{
			get
			{
				return _scrollBarWidth;
			}
			set
			{
				_scrollBarWidth = value;
				RedrawPanel();
			}
		}

		public int ItemsToDisplay
		{
			get
			{
				return _itemsToDisplay;
			}
			set
			{
				_itemsToDisplay = value;
				RedrawPanel();
			}
		}

		private bool shouldSelectItemOnStart
		{
			get
			{
				if (!SelectFirstItemOnStart)
				{
					return selectItemIndexOnStart > 0;
				}
				return true;
			}
		}

		public void Start()
		{
			Initialize();
			if (shouldSelectItemOnStart && Items.Count > 0)
			{
				SelectItemIndex((!SelectFirstItemOnStart) ? selectItemIndexOnStart : 0);
			}
			RedrawPanel();
		}

		private bool Initialize()
		{
			if (_initialized)
			{
				return true;
			}
			bool result = true;
			try
			{
				_rectTransform = GetComponent<RectTransform>();
				_mainButton = new DropDownListButton(_rectTransform.Find("MainButton").gameObject);
				_defaultMainButtonCaption = _mainButton.txt.text;
				_defaultNormalColor = _mainButton.btn.colors.normalColor;
				_overlayRT = _rectTransform.Find("Overlay").GetComponent<RectTransform>();
				_overlayRT.gameObject.SetActive(value: false);
				_scrollPanelRT = _overlayRT.Find("ScrollPanel").GetComponent<RectTransform>();
				_scrollBarRT = _scrollPanelRT.Find("Scrollbar").GetComponent<RectTransform>();
				_slidingAreaRT = _scrollBarRT.Find("SlidingArea").GetComponent<RectTransform>();
				_scrollHandleRT = _slidingAreaRT.Find("Handle").GetComponent<RectTransform>();
				_itemsPanelRT = _scrollPanelRT.Find("Items").GetComponent<RectTransform>();
				_canvas = GetComponentInParent<Canvas>();
				_canvasRT = _canvas.GetComponent<RectTransform>();
				_scrollRect = _scrollPanelRT.GetComponent<ScrollRect>();
				_scrollRect.scrollSensitivity = _rectTransform.sizeDelta.y / 2f;
				_scrollRect.movementType = ScrollRect.MovementType.Clamped;
				_scrollRect.content = _itemsPanelRT;
				_itemTemplate = _rectTransform.Find("ItemTemplate").gameObject;
				_itemTemplate.SetActive(value: false);
			}
			catch (NullReferenceException exception)
			{
				Debug.LogException(exception);
				Debug.LogError("Something is setup incorrectly with the dropdownlist component causing a Null Reference Exception");
				result = false;
			}
			_initialized = true;
			RebuildPanel();
			RedrawPanel();
			return result;
		}

		public void SelectItemIndex(int index)
		{
			ToggleDropdownPanel();
			OnItemClicked(index);
		}

		public void RefreshItems(params object[] list)
		{
			Items.Clear();
			List<DropDownListItem> list2 = new List<DropDownListItem>();
			foreach (object obj in list)
			{
				if (obj is DropDownListItem)
				{
					list2.Add((DropDownListItem)obj);
					continue;
				}
				if (obj is string)
				{
					list2.Add(new DropDownListItem((string)obj));
					continue;
				}
				if (obj is Sprite)
				{
					list2.Add(new DropDownListItem("", "", (Sprite)obj));
					continue;
				}
				throw new Exception("Only ComboBoxItems, Strings, and Sprite types are allowed");
			}
			Items.AddRange(list2);
			RebuildPanel();
			RedrawPanel();
		}

		public void AddItem(DropDownListItem item)
		{
			Items.Add(item);
			RebuildPanel();
			RedrawPanel();
		}

		public void AddItem(string item)
		{
			Items.Add(new DropDownListItem(item));
			RebuildPanel();
			RedrawPanel();
		}

		public void AddItem(Sprite item)
		{
			Items.Add(new DropDownListItem("", "", item));
			RebuildPanel();
			RedrawPanel();
		}

		public void RemoveItem(DropDownListItem item)
		{
			Items.Remove(item);
			RebuildPanel();
			RedrawPanel();
		}

		public void RemoveItem(string item)
		{
			Items.Remove(new DropDownListItem(item));
			RebuildPanel();
			RedrawPanel();
		}

		public void RemoveItem(Sprite item)
		{
			Items.Remove(new DropDownListItem("", "", item));
			RebuildPanel();
			RedrawPanel();
		}

		public void ResetDropDown()
		{
			if (_initialized)
			{
				_mainButton.txt.text = _defaultMainButtonCaption;
				for (int i = 0; i < _itemsPanelRT.childCount; i++)
				{
					_panelItems[i].btnImg.color = _defaultNormalColor;
				}
				_selectedIndex = -1;
				_initialized = false;
				Initialize();
			}
		}

		public void ResetItems()
		{
			Items.Clear();
			RebuildPanel();
			RedrawPanel();
		}

		private void RebuildPanel()
		{
			if (Items.Count == 0)
			{
				return;
			}
			if (!_initialized)
			{
				Start();
			}
			int num = _panelItems.Count;
			while (_panelItems.Count < Items.Count)
			{
				GameObject gameObject = Object.Instantiate(_itemTemplate);
				gameObject.name = "Item " + num;
				gameObject.transform.SetParent(_itemsPanelRT, worldPositionStays: false);
				_panelItems.Add(new DropDownListButton(gameObject));
				num++;
			}
			for (int i = 0; i < _panelItems.Count; i++)
			{
				if (i < Items.Count)
				{
					DropDownListItem item = Items[i];
					_panelItems[i].txt.text = item.Caption;
					if (item.IsDisabled)
					{
						_panelItems[i].txt.color = disabledTextColor;
					}
					if (_panelItems[i].btnImg != null)
					{
						_panelItems[i].btnImg.sprite = null;
					}
					_panelItems[i].img.sprite = item.Image;
					_panelItems[i].img.color = ((item.Image == null) ? new Color(1f, 1f, 1f, 0f) : (item.IsDisabled ? new Color(1f, 1f, 1f, 0.5f) : Color.white));
					int ii = i;
					_panelItems[i].btn.onClick.RemoveAllListeners();
					_panelItems[i].btn.onClick.AddListener(delegate
					{
						OnItemClicked(ii);
						if (item.OnSelect != null)
						{
							item.OnSelect();
						}
					});
				}
				_panelItems[i].gameobject.SetActive(i < Items.Count);
			}
		}

		private void OnItemClicked(int indx)
		{
			if (indx != _selectedIndex && OnSelectionChanged != null)
			{
				OnSelectionChanged.Invoke(indx);
			}
			_selectedIndex = indx;
			ToggleDropdownPanel();
			UpdateSelected();
		}

		private void UpdateSelected()
		{
			SelectedItem = ((_selectedIndex > -1 && _selectedIndex < Items.Count) ? Items[_selectedIndex] : null);
			if (SelectedItem == null)
			{
				return;
			}
			if (SelectedItem.Image != null)
			{
				_mainButton.img.sprite = SelectedItem.Image;
				_mainButton.img.color = Color.white;
			}
			else
			{
				_mainButton.img.sprite = null;
			}
			_mainButton.txt.text = SelectedItem.Caption;
			if (OverrideHighlighted)
			{
				for (int i = 0; i < _itemsPanelRT.childCount; i++)
				{
					_panelItems[i].btnImg.color = ((_selectedIndex == i) ? _mainButton.btn.colors.highlightedColor : new Color(0f, 0f, 0f, 0f));
				}
			}
		}

		private void RedrawPanel()
		{
			float num = ((_panelItems.Count > ItemsToDisplay) ? _scrollBarWidth : 0f);
			_scrollBarRT.gameObject.SetActive(_panelItems.Count > ItemsToDisplay);
			float num2 = ((_itemsToDisplay > 0) ? (_rectTransform.sizeDelta.y * (float)Mathf.Min(_itemsToDisplay, _panelItems.Count)) : (_rectTransform.sizeDelta.y * (float)_panelItems.Count));
			num2 += dropdownOffset;
			if (!_hasDrawnOnce || _rectTransform.sizeDelta != _mainButton.rectTransform.sizeDelta)
			{
				_hasDrawnOnce = true;
				_mainButton.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _rectTransform.sizeDelta.x);
				_mainButton.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, _rectTransform.sizeDelta.y);
				int num3 = _panelItems.Count - ItemsToDisplay;
				num3 = ((num3 >= 0) ? num3 : 0);
				_scrollPanelRT.SetParent(base.transform, worldPositionStays: true);
				_scrollPanelRT.anchoredPosition = (_displayPanelAbove ? new Vector2(0f, dropdownOffset + num2) : new Vector2(0f, 0f - (dropdownOffset + _rectTransform.sizeDelta.y)));
				_overlayRT.SetParent(_canvas.transform, worldPositionStays: false);
				_overlayRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _canvasRT.sizeDelta.x);
				_overlayRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, _canvasRT.sizeDelta.y);
				_overlayRT.SetParent(base.transform, worldPositionStays: true);
				_scrollPanelRT.SetParent(_overlayRT, worldPositionStays: true);
			}
			if (_panelItems.Count >= 1)
			{
				_scrollPanelRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
				_scrollPanelRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _rectTransform.sizeDelta.x);
				_itemsPanelRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, _scrollPanelRT.sizeDelta.x - num - 5f);
				_itemsPanelRT.anchoredPosition = new Vector2(5f, 0f);
				_scrollBarRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, num);
				_scrollBarRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2);
				if (num == 0f)
				{
					_scrollHandleRT.gameObject.SetActive(value: false);
				}
				else
				{
					_scrollHandleRT.gameObject.SetActive(value: true);
				}
				_slidingAreaRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, 0f);
				_slidingAreaRT.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, num2 - _scrollBarRT.sizeDelta.x);
			}
		}

		[Obsolete("DirectClick Parameter is no longer required")]
		public void ToggleDropdownPanel(bool directClick = false)
		{
			ToggleDropdownPanel();
		}

		public void ToggleDropdownPanel()
		{
			if (isActive)
			{
				_overlayRT.transform.localScale = new Vector3(1f, 1f, 1f);
				_scrollBarRT.transform.localScale = new Vector3(1f, 1f, 1f);
				_isPanelActive = !_isPanelActive;
				_overlayRT.gameObject.SetActive(_isPanelActive);
				if (_isPanelActive)
				{
					base.transform.SetAsLastSibling();
				}
			}
		}

		public void HideDropDownPanel()
		{
			if (_isPanelActive)
			{
				ToggleDropdownPanel();
			}
		}

		public void SetActive(bool status)
		{
			if (status != isActive)
			{
				isActive = status;
				OnControlDisabled?.Invoke(isActive);
				_mainButton.btn.enabled = isActive;
			}
		}
	}
}
