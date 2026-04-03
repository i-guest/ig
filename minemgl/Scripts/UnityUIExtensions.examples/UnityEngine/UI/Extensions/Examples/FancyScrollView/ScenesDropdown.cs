using System;
using System.Linq;
using UnityEngine.SceneManagement;

namespace UnityEngine.UI.Extensions.Examples.FancyScrollView
{
	[RequireComponent(typeof(Dropdown))]
	internal class ScenesDropdown : MonoBehaviour
	{
		private readonly string[] scenes = new string[9] { "01_Basic", "02_FocusOn", "03_InfiniteScroll", "04_Metaball", "05_Voronoi", "06_LoopTabBar", "07_ScrollRect", "08_GridView", "09_LoadTexture" };

		private void Start()
		{
			Dropdown component = GetComponent<Dropdown>();
			component.AddOptions(scenes.Select((string x) => new Dropdown.OptionData(x)).ToList());
			component.value = Mathf.Max(0, Array.IndexOf(scenes, SceneManager.GetActiveScene().name));
			component.onValueChanged.AddListener(delegate(int value)
			{
				SceneManager.LoadScene(scenes[value], LoadSceneMode.Single);
			});
		}
	}
}
