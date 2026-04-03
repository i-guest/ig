using TMPro;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(RectTransform))]
	[RequireComponent(typeof(TMP_Text))]
	[AddComponentMenu("UI/Effects/Extensions/Curly UI Text")]
	public class CUIText : CUIGraphic
	{
		public override void ReportSet()
		{
			if (uiGraphic == null)
			{
				uiGraphic = GetComponent<TMP_Text>();
			}
			base.ReportSet();
		}
	}
}
