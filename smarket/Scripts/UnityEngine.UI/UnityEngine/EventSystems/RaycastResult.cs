using UnityEngine.UIElements;

namespace UnityEngine.EventSystems
{
	public struct RaycastResult
	{
		private GameObject m_GameObject;

		public BaseRaycaster module;

		public float distance;

		public float index;

		public int depth;

		public int sortingGroupID;

		public int sortingGroupOrder;

		public int sortingLayer;

		public int sortingOrder;

		public Vector3 origin;

		public Vector3 worldPosition;

		public Vector3 worldNormal;

		public Vector2 screenPosition;

		public int displayIndex;

		public UIDocument document;

		public VisualElement element;

		public GameObject gameObject
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isValid => false;

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
