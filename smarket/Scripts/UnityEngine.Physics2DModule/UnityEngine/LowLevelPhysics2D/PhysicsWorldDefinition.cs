using System;
using UnityEngine.Serialization;

namespace UnityEngine.LowLevelPhysics2D
{
	[Serializable]
	public struct PhysicsWorldDefinition
	{
		[SerializeField]
		private Vector2 m_Gravity;

		[FormerlySerializedAs("m_SimulationMode")]
		[SerializeField]
		private PhysicsWorld.SimulationType m_SimulationType;

		[Min(1f)]
		[SerializeField]
		private int m_SimulationSubSteps;

		[Range(0f, 64f)]
		[SerializeField]
		private int m_SimulationWorkers;

		[SerializeField]
		private PhysicsWorld.TransformWriteMode m_TransformWriteMode;

		[SerializeField]
		private PhysicsWorld.TransformPlane m_TransformPlane;

		[SerializeField]
		private bool m_TransformTweening;

		[SerializeField]
		private bool m_SleepingAllowed;

		[SerializeField]
		private bool m_ContinuousAllowed;

		[SerializeField]
		private bool m_ContactFilterCallbacks;

		[SerializeField]
		private bool m_PreSolveCallbacks;

		[SerializeField]
		private bool m_AutoBodyUpdateCallbacks;

		[SerializeField]
		private bool m_AutoContactCallbacks;

		[SerializeField]
		private bool m_AutoTriggerCallbacks;

		[SerializeField]
		private bool m_AutoJointThresholdCallbacks;

		[SerializeField]
		[Min(0f)]
		private float m_BounceThreshold;

		[SerializeField]
		[Min(0f)]
		private float m_ContactHitEventThreshold;

		[Min(0f)]
		[SerializeField]
		private float m_ContactFrequency;

		[Min(0f)]
		[SerializeField]
		private float m_ContactDamping;

		[Min(0f)]
		[SerializeField]
		private float m_ContactSpeed;

		[Min(0f)]
		[SerializeField]
		private float m_MaximumLinearSpeed;

		[SerializeField]
		private PhysicsWorld.DrawOptions m_DrawOptions;

		[SerializeField]
		private PhysicsWorld.DrawFillOptions m_DrawFillOptions;

		[SerializeField]
		[Range(1f, 10f)]
		private float m_DrawThickness;

		[SerializeField]
		[Range(0f, 1f)]
		private float m_DrawFillAlpha;

		[Range(0.001f, 10f)]
		[SerializeField]
		private float m_DrawPointScale;

		[Range(0.001f, 10f)]
		[SerializeField]
		private float m_DrawNormalScale;

		[SerializeField]
		[Range(0.001f, 10f)]
		private float m_DrawImpulseScale;

		[SerializeField]
		[Min(0f)]
		private int m_DrawCapacity;

		[SerializeField]
		private PhysicsWorld.DrawColors m_DrawColors;

		public static PhysicsWorldDefinition defaultDefinition => default(PhysicsWorldDefinition);

		public PhysicsWorldDefinition()
		{
			m_Gravity = default(Vector2);
			m_SimulationType = default(PhysicsWorld.SimulationType);
			m_SimulationSubSteps = 0;
			m_SimulationWorkers = 0;
			m_TransformWriteMode = default(PhysicsWorld.TransformWriteMode);
			m_TransformPlane = default(PhysicsWorld.TransformPlane);
			m_TransformTweening = false;
			m_SleepingAllowed = false;
			m_ContinuousAllowed = false;
			m_ContactFilterCallbacks = false;
			m_PreSolveCallbacks = false;
			m_AutoBodyUpdateCallbacks = false;
			m_AutoContactCallbacks = false;
			m_AutoTriggerCallbacks = false;
			m_AutoJointThresholdCallbacks = false;
			m_BounceThreshold = 0f;
			m_ContactHitEventThreshold = 0f;
			m_ContactFrequency = 0f;
			m_ContactDamping = 0f;
			m_ContactSpeed = 0f;
			m_MaximumLinearSpeed = 0f;
			m_DrawOptions = default(PhysicsWorld.DrawOptions);
			m_DrawFillOptions = default(PhysicsWorld.DrawFillOptions);
			m_DrawThickness = 0f;
			m_DrawFillAlpha = 0f;
			m_DrawPointScale = 0f;
			m_DrawNormalScale = 0f;
			m_DrawImpulseScale = 0f;
			m_DrawCapacity = 0;
			m_DrawColors = default(PhysicsWorld.DrawColors);
		}

		public PhysicsWorldDefinition(bool useSettings)
		{
			m_Gravity = default(Vector2);
			m_SimulationType = default(PhysicsWorld.SimulationType);
			m_SimulationSubSteps = 0;
			m_SimulationWorkers = 0;
			m_TransformWriteMode = default(PhysicsWorld.TransformWriteMode);
			m_TransformPlane = default(PhysicsWorld.TransformPlane);
			m_TransformTweening = false;
			m_SleepingAllowed = false;
			m_ContinuousAllowed = false;
			m_ContactFilterCallbacks = false;
			m_PreSolveCallbacks = false;
			m_AutoBodyUpdateCallbacks = false;
			m_AutoContactCallbacks = false;
			m_AutoTriggerCallbacks = false;
			m_AutoJointThresholdCallbacks = false;
			m_BounceThreshold = 0f;
			m_ContactHitEventThreshold = 0f;
			m_ContactFrequency = 0f;
			m_ContactDamping = 0f;
			m_ContactSpeed = 0f;
			m_MaximumLinearSpeed = 0f;
			m_DrawOptions = default(PhysicsWorld.DrawOptions);
			m_DrawFillOptions = default(PhysicsWorld.DrawFillOptions);
			m_DrawThickness = 0f;
			m_DrawFillAlpha = 0f;
			m_DrawPointScale = 0f;
			m_DrawNormalScale = 0f;
			m_DrawImpulseScale = 0f;
			m_DrawCapacity = 0;
			m_DrawColors = default(PhysicsWorld.DrawColors);
		}
	}
}
