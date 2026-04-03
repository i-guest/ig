using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsChainDefinition
	{
		[SerializeField]
		private PhysicsShape.SurfaceMaterial m_SurfaceMaterial;

		[SerializeField]
		private PhysicsShape.ContactFilter m_ContactFilter;

		[SerializeField]
		private bool m_IsLoop;

		[SerializeField]
		private bool m_TriggerEvents;

		public static PhysicsChainDefinition defaultDefinition => default(PhysicsChainDefinition);

		public PhysicsChainDefinition()
		{
			m_SurfaceMaterial = default(PhysicsShape.SurfaceMaterial);
			m_ContactFilter = default(PhysicsShape.ContactFilter);
			m_IsLoop = false;
			m_TriggerEvents = false;
		}

		public PhysicsChainDefinition(bool useSettings)
		{
			m_SurfaceMaterial = default(PhysicsShape.SurfaceMaterial);
			m_ContactFilter = default(PhysicsShape.ContactFilter);
			m_IsLoop = false;
			m_TriggerEvents = false;
		}
	}
}
