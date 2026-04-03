using TMPro;

namespace UnityEngine.UI.Extensions
{
	[RequireComponent(typeof(TMP_Text))]
	[AddComponentMenu("UI/Extensions/PPIViewer")]
	public class PPIViewer : MonoBehaviour
	{
		private TMP_Text label;

		private void Awake()
		{
			label = GetComponentInChildren<TMP_Text>();
		}

		private void Start()
		{
			if (label != null)
			{
				label.text = "PPI: " + Screen.dpi;
			}
		}
	}
}
