using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct PointerEvent : IEventProperties
	{
		public enum Type
		{
			PointerMoved = 1,
			Scroll = 2,
			ButtonPressed = 3,
			ButtonReleased = 4,
			State = 5,
			TouchCanceled = 6,
			TrackedCanceled = 6
		}

		[Flags]
		public enum Button : uint
		{
			None = 0u,
			Primary = 1u,
			FingerInTouch = 1u,
			PenTipInTouch = 1u,
			PenEraserInTouch = 2u,
			PenBarrelButton = 4u,
			MouseLeft = 1u,
			MouseRight = 2u,
			MouseMiddle = 4u,
			MouseForward = 8u,
			MouseBack = 0x10u
		}

		public struct ButtonsState
		{
			private uint _state;

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Set(Button button, bool pressed)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public bool Get(Button button)
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			public void Reset()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public Type type;

		public int pointerIndex;

		public Vector2 position;

		public Vector2 deltaPosition;

		public Vector3 worldPosition;

		public Quaternion worldOrientation;

		public float maxDistance;

		public Vector2 scroll;

		public int displayIndex;

		public Vector2 tilt;

		public float twist;

		public float pressure;

		public bool isInverted;

		public Button button;

		public ButtonsState buttonsState;

		public int clickCount;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint _003CplayerId_003Ek__BackingField;

		public bool isPrimaryPointer => false;

		public Ray worldRay => default(Ray);

		public float azimuth => 0f;

		public float altitude => 0f;

		public DiscreteTime timestamp { get; set; }

		public EventSource eventSource { get; set; }

		public uint playerId
		{
			[CompilerGenerated]
			set
			{
				_003CplayerId_003Ek__BackingField = value;
			}
		}

		public EventModifiers eventModifiers { get; set; }

		public override string ToString()
		{
			return null;
		}

		internal static Button ButtonFromButtonIndex(int index)
		{
			return default(Button);
		}
	}
}
