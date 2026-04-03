using UnityEngine.Localization.Events;

namespace UnityEngine.Localization.Components
{
	[AddComponentMenu("Localization/Asset/Localize Prefab Event")]
	public class LocalizedGameObjectEvent : LocalizedAssetEvent<GameObject, LocalizedGameObject, UnityEventGameObject>
	{
		private GameObject m_Current;

		protected override void UpdateAsset(GameObject localizedAsset)
		{
		}
	}
}
