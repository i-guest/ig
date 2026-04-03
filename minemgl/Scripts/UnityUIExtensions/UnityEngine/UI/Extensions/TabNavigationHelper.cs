using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(EventSystem))]
	[AddComponentMenu("Event/Extensions/Tab Navigation Helper")]
	public class TabNavigationHelper : MonoBehaviour
	{
		private EventSystem _system;

		private Selectable startingObject;

		private Selectable lastObject;

		[Tooltip("The path to take when user is tabbing through ui components.")]
		public Selectable[] NavigationPath;

		[Tooltip("Use the default Unity navigation system or a manual fixed order using Navigation Path")]
		public NavigationMode NavigationMode;

		[Tooltip("If True, this will loop the tab order from last to first automatically")]
		public bool CircularNavigation;

		private void Start()
		{
			_system = GetComponent<EventSystem>();
			if (_system == null)
			{
				Debug.LogError("Needs to be attached to the Event System component in the scene");
			}
			if (NavigationMode == NavigationMode.Manual && NavigationPath.Length != 0)
			{
				startingObject = NavigationPath[0].gameObject.GetComponent<Selectable>();
			}
			if (startingObject == null && CircularNavigation)
			{
				SelectDefaultObject(out startingObject);
			}
		}

		public void Update()
		{
			Selectable next = null;
			if (lastObject == null && _system.currentSelectedGameObject != null)
			{
				Selectable component = _system.currentSelectedGameObject.GetComponent<Selectable>();
				Stack<Selectable> stack = new Stack<Selectable>();
				stack.Push(component);
				next = component.FindSelectableOnDown();
				while (next != null)
				{
					if (stack.Contains(next))
					{
						lastObject = stack.Pop();
						stack.Clear();
						break;
					}
					lastObject = next;
					stack.Push(next);
					next = next.FindSelectableOnDown();
				}
			}
			if (UIExtensionsInputManager.GetKeyDown(KeyCode.Tab) && UIExtensionsInputManager.GetKey(KeyCode.LeftShift))
			{
				if (NavigationMode == NavigationMode.Manual && NavigationPath.Length != 0)
				{
					for (int num = NavigationPath.Length - 1; num >= 0; num--)
					{
						if (!(_system.currentSelectedGameObject != NavigationPath[num].gameObject))
						{
							next = ((num == 0) ? NavigationPath[NavigationPath.Length - 1] : NavigationPath[num - 1]);
							break;
						}
					}
				}
				else if (_system.currentSelectedGameObject != null)
				{
					next = _system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
					if (next == null && CircularNavigation)
					{
						next = lastObject;
					}
				}
				else
				{
					SelectDefaultObject(out next);
				}
			}
			else if (UIExtensionsInputManager.GetKeyDown(KeyCode.Tab))
			{
				if (NavigationMode == NavigationMode.Manual && NavigationPath.Length != 0)
				{
					for (int i = 0; i < NavigationPath.Length; i++)
					{
						if (!(_system.currentSelectedGameObject != NavigationPath[i].gameObject))
						{
							next = ((i == NavigationPath.Length - 1) ? NavigationPath[0] : NavigationPath[i + 1]);
							break;
						}
					}
				}
				else if (_system.currentSelectedGameObject != null)
				{
					next = _system.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
					if (next == null && CircularNavigation)
					{
						next = startingObject;
					}
				}
				else
				{
					SelectDefaultObject(out next);
				}
			}
			else if (_system.currentSelectedGameObject == null)
			{
				SelectDefaultObject(out next);
			}
			if (CircularNavigation && startingObject == null)
			{
				startingObject = next;
			}
			selectGameObject(next);
		}

		private void SelectDefaultObject(out Selectable next)
		{
			if ((bool)_system.firstSelectedGameObject)
			{
				next = _system.firstSelectedGameObject.GetComponent<Selectable>();
			}
			else
			{
				next = null;
			}
		}

		private void selectGameObject(Selectable selectable)
		{
			if (selectable != null)
			{
				InputField component = selectable.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(_system));
				}
				_system.SetSelectedGameObject(selectable.gameObject, new BaseEventData(_system));
			}
		}
	}
}
