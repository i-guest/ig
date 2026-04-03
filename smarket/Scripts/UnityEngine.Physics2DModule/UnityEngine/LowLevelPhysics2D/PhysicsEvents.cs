using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine.LowLevelPhysics2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[RequiredByNativeCode(GenerateProxy = true)]
	public readonly struct PhysicsEvents
	{
		public readonly struct BodyUpdateEvent
		{
			private readonly IntPtr m_UserData;

			private readonly PhysicsTransform m_Transform;

			private readonly PhysicsBody m_Body;

			private readonly bool m_FellAsleep;

			public PhysicsTransform transform => default(PhysicsTransform);

			public PhysicsBody body => default(PhysicsBody);

			public bool fellAsleep => false;

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct TriggerBeginEvent
		{
			private readonly PhysicsShape m_TriggerShape;

			private readonly PhysicsShape m_VisitorShape;

			public PhysicsShape triggerShape => default(PhysicsShape);

			public PhysicsShape visitorShape => default(PhysicsShape);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct TriggerEndEvent
		{
			private readonly PhysicsShape m_TriggerShape;

			private readonly PhysicsShape m_VisitorShape;

			public PhysicsShape triggerShape => default(PhysicsShape);

			public PhysicsShape visitorShape => default(PhysicsShape);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct ContactBeginEvent
		{
			private readonly PhysicsShape m_ShapeA;

			private readonly PhysicsShape m_ShapeB;

			private readonly PhysicsShape.ContactId m_ContactId;

			public PhysicsShape shapeA => default(PhysicsShape);

			public PhysicsShape shapeB => default(PhysicsShape);

			public PhysicsShape.ContactId contactId => default(PhysicsShape.ContactId);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct ContactEndEvent
		{
			private readonly PhysicsShape m_ShapeA;

			private readonly PhysicsShape m_ShapeB;

			private readonly PhysicsShape.ContactId m_ContactId;

			public PhysicsShape shapeA => default(PhysicsShape);

			public PhysicsShape shapeB => default(PhysicsShape);

			public PhysicsShape.ContactId contactId => default(PhysicsShape.ContactId);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct ContactFilterEvent
		{
			private readonly PhysicsWorld m_PhysicsWorld;

			private readonly PhysicsShape m_ShapeA;

			private readonly PhysicsShape m_ShapeB;

			public PhysicsWorld physicsWorld => default(PhysicsWorld);

			public PhysicsShape shapeA => default(PhysicsShape);

			public PhysicsShape shapeB => default(PhysicsShape);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct PreSolveEvent
		{
			private readonly PhysicsWorld m_PhysicsWorld;

			private readonly PhysicsShape m_ShapeA;

			private readonly PhysicsShape m_ShapeB;

			private readonly Vector2 m_Point;

			private readonly Vector2 m_Normal;

			public PhysicsWorld physicsWorld => default(PhysicsWorld);

			public PhysicsShape shapeA => default(PhysicsShape);

			public PhysicsShape shapeB => default(PhysicsShape);

			public Vector2 point => default(Vector2);

			public Vector2 normal => default(Vector2);

			public override string ToString()
			{
				return null;
			}
		}

		public readonly struct JointThresholdEvent
		{
			private readonly PhysicsJoint m_Joint;

			private readonly IntPtr m_UserData;

			public PhysicsJoint joint => default(PhysicsJoint);

			public override string ToString()
			{
				return null;
			}
		}

		public delegate void PreSimulateEventHandler(PhysicsWorld world, float deltaTime);

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static PreSimulateEventHandler s_PreSimulate;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static PreSimulateEventHandler s_PostSimulate;

		[RequiredByNativeCode]
		private static void InvokePreSimulate(PhysicsWorld world, float deltaTime)
		{
		}

		[RequiredByNativeCode]
		private static void InvokePostSimulate(PhysicsWorld world, float deltaTime)
		{
		}

		[RequiredByNativeCode]
		private static bool SendContactFilterCallback(object callbackTarget, ContactFilterEvent contactFilterEvent)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static bool SendPreSolveCallback(object callbackTarget, PreSolveEvent preSolveEvent)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void SendBodyUpdateCallbacks(PhysicsWorld world)
		{
		}

		[RequiredByNativeCode]
		private static void SendContactCallbacks(PhysicsWorld world)
		{
		}

		[RequiredByNativeCode]
		private static void SendTriggerCallbacks(PhysicsWorld world)
		{
		}

		[RequiredByNativeCode]
		private static void SendJointThresholdCallbacks(PhysicsWorld world)
		{
		}
	}
}
