using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	[AddComponentMenu("UI/Extensions/ResetSelectableHighlight", 31)]
	[RequireComponent(typeof(Selectable))]
	public class ResetSelectableHighlight : MonoBehaviour, IPointerExitHandler, IEventSystemHandler
	{
		[SerializeField]
		private Selectable attachedSelectable;

		private void Awake()
		{
			if (attachedSelectable == null || !attachedSelectable)
			{
				attachedSelectable = GetComponent<Selectable>();
			}
		}

		public void OnPointerExit(PointerEventData eventData)
		{
			if (attachedSelectable.interactable)
			{
				attachedSelectable.targetGraphic.CrossFadeColor(attachedSelectable.colors.normalColor, 0f, ignoreTimeScale: true, useAlpha: true);
			}
		}
	}
}
