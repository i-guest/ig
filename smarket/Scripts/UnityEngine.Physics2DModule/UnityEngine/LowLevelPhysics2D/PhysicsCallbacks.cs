using System;
using System.Runtime.InteropServices;

namespace UnityEngine.LowLevelPhysics2D
{
	[StructLayout((LayoutKind)0, Size = 1)]
	public readonly struct PhysicsCallbacks
	{
		public interface IBodyUpdateCallback
		{
			void OnBodyUpdate2D(PhysicsEvents.BodyUpdateEvent bodyUpdateEvent);
		}

		public interface IContactFilterCallback
		{
			bool OnContactFilter2D(PhysicsEvents.ContactFilterEvent contactFilterEvent);
		}

		public interface IPreSolveCallback
		{
			bool OnPreSolve2D(PhysicsEvents.PreSolveEvent preSolveEvent);
		}

		public interface ITriggerCallback
		{
			void OnTriggerBegin2D(PhysicsEvents.TriggerBeginEvent beginEvent);

			void OnTriggerEnd2D(PhysicsEvents.TriggerEndEvent endEvent);
		}

		public interface IContactCallback
		{
			void OnContactBegin2D(PhysicsEvents.ContactBeginEvent beginEvent);

			void OnContactEnd2D(PhysicsEvents.ContactEndEvent endEvent);
		}

		public interface IJointThresholdCallback
		{
			void OnJointThreshold2D(PhysicsEvents.JointThresholdEvent thresholdEvent);
		}

		public readonly struct BodyUpdateCallbackTargets : IDisposable
		{
			public readonly struct BodyUpdateTarget
			{
				private readonly PhysicsEvents.BodyUpdateEvent m_BodyUpdateEvent;

				public PhysicsEvents.BodyUpdateEvent bodyUpdateEvent => default(PhysicsEvents.BodyUpdateEvent);

				public IBodyUpdateCallback bodyTarget => null;
			}

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_BodyUpdateCallbackTargets;

			public ReadOnlySpan<BodyUpdateTarget> bodyUpdateCallbackTargets => default(ReadOnlySpan<BodyUpdateTarget>);

			public void Dispose()
			{
			}
		}

		public readonly struct TriggerCallbackTargets : IDisposable
		{
			public readonly struct TriggerBeginTarget
			{
				private readonly PhysicsEvents.TriggerBeginEvent m_BeginEvent;

				public PhysicsEvents.TriggerBeginEvent beginEvent => default(PhysicsEvents.TriggerBeginEvent);

				public ITriggerCallback triggerShapeTarget => null;

				public ITriggerCallback visitorShapeTarget => null;
			}

			public readonly struct TriggerEndTarget
			{
				private readonly PhysicsEvents.TriggerEndEvent m_EndEvent;

				public PhysicsEvents.TriggerEndEvent endEvent => default(PhysicsEvents.TriggerEndEvent);

				public ITriggerCallback triggerShapeTarget => null;

				public ITriggerCallback visitorShapeTarget => null;
			}

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_BeginCallbackTargets;

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_EndCallbackTargets;

			public ReadOnlySpan<TriggerBeginTarget> BeginCallbackTargets => default(ReadOnlySpan<TriggerBeginTarget>);

			public ReadOnlySpan<TriggerEndTarget> EndCallbackTargets => default(ReadOnlySpan<TriggerEndTarget>);

			public void Dispose()
			{
			}
		}

		public readonly struct ContactCallbackTargets : IDisposable
		{
			public readonly struct ContactBeginTarget
			{
				private readonly PhysicsEvents.ContactBeginEvent m_BeginEvent;

				public PhysicsEvents.ContactBeginEvent beginEvent => default(PhysicsEvents.ContactBeginEvent);

				public IContactCallback shapeTargetA => null;

				public IContactCallback shapeTargetB => null;
			}

			public readonly struct ContactEndTarget
			{
				private readonly PhysicsEvents.ContactEndEvent m_EndEvent;

				public PhysicsEvents.ContactEndEvent endEvent => default(PhysicsEvents.ContactEndEvent);

				public IContactCallback shapeTargetA => null;

				public IContactCallback shapeTargetB => null;
			}

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_BeginCallbackTargets;

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_EndCallbackTargets;

			public ReadOnlySpan<ContactBeginTarget> BeginCallbackTargets => default(ReadOnlySpan<ContactBeginTarget>);

			public ReadOnlySpan<ContactEndTarget> EndCallbackTargets => default(ReadOnlySpan<ContactEndTarget>);

			public void Dispose()
			{
			}
		}

		public readonly struct JointThresholdCallbackTargets : IDisposable
		{
			public readonly struct JointThresholdTarget
			{
				private readonly PhysicsEvents.JointThresholdEvent m_JointThresholdEvent;

				public PhysicsEvents.JointThresholdEvent jointThresholdEvent => default(PhysicsEvents.JointThresholdEvent);

				public IJointThresholdCallback jointTarget => null;
			}

			private readonly PhysicsLowLevelScripting2D.PhysicsBuffer m_JointThresholdCallbackTargets;

			public ReadOnlySpan<JointThresholdTarget> jointThresholdCallbackTargets => default(ReadOnlySpan<JointThresholdTarget>);

			public void Dispose()
			{
			}
		}
	}
}
