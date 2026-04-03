namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public struct InstantiationParameters
	{
		private Vector3 m_Position;

		private Quaternion m_Rotation;

		private Transform m_Parent;

		private bool m_InstantiateInWorldPosition;

		private bool m_SetPositionRotation;

		public Vector3 Position => default(Vector3);

		public Quaternion Rotation => default(Quaternion);

		public Transform Parent => null;

		public bool InstantiateInWorldPosition => false;

		public bool SetPositionRotation => false;

		public InstantiationParameters(Transform parent, bool instantiateInWorldSpace)
		{
			m_Position = default(Vector3);
			m_Rotation = default(Quaternion);
			m_Parent = null;
			m_InstantiateInWorldPosition = false;
			m_SetPositionRotation = false;
		}

		public InstantiationParameters(Vector3 position, Quaternion rotation, Transform parent)
		{
			m_Position = default(Vector3);
			m_Rotation = default(Quaternion);
			m_Parent = null;
			m_InstantiateInWorldPosition = false;
			m_SetPositionRotation = false;
		}

		public TObject Instantiate<TObject>(TObject source)
		{
			return default(TObject);
		}
	}
}
