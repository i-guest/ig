using System;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsShapeDefinition
	{
		public PhysicsShape.SurfaceMaterial surfaceMaterial;

		public PhysicsShape.ContactFilter contactFilter;

		public PhysicsShape.MoverData moverData;

		[Min(0f)]
		[SerializeField]
		private float m_Density;

		[SerializeField]
		private bool m_IsTrigger;

		[SerializeField]
		private bool m_TriggerEvents;

		[SerializeField]
		private bool m_ContactEvents;

		[SerializeField]
		private bool m_HitEvents;

		[SerializeField]
		private bool m_ContactFilterCallbacks;

		[SerializeField]
		private bool m_PreSolveCallbacks;

		[SerializeField]
		private bool m_StartStaticContacts;

		[SerializeField]
		private bool m_StartMassUpdate;

		public static PhysicsShapeDefinition defaultDefinition => default(PhysicsShapeDefinition);

		public PhysicsShapeDefinition()
		{
			surfaceMaterial = default(PhysicsShape.SurfaceMaterial);
			contactFilter = default(PhysicsShape.ContactFilter);
			moverData = default(PhysicsShape.MoverData);
			m_Density = 0f;
			m_IsTrigger = false;
			m_TriggerEvents = false;
			m_ContactEvents = false;
			m_HitEvents = false;
			m_ContactFilterCallbacks = false;
			m_PreSolveCallbacks = false;
			m_StartStaticContacts = false;
			m_StartMassUpdate = false;
		}

		public PhysicsShapeDefinition(bool useSettings)
		{
			surfaceMaterial = default(PhysicsShape.SurfaceMaterial);
			contactFilter = default(PhysicsShape.ContactFilter);
			moverData = default(PhysicsShape.MoverData);
			m_Density = 0f;
			m_IsTrigger = false;
			m_TriggerEvents = false;
			m_ContactEvents = false;
			m_HitEvents = false;
			m_ContactFilterCallbacks = false;
			m_PreSolveCallbacks = false;
			m_StartStaticContacts = false;
			m_StartMassUpdate = false;
		}
	}
}
