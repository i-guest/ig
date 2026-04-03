using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct NavigationEvent : IEventProperties
	{
		public enum Type
		{
			Move = 1,
			Submit = 2,
			Cancel = 3
		}

		public enum Direction
		{
			None = 0,
			Left = 1,
			Up = 2,
			Right = 3,
			Down = 4,
			Next = 5,
			Previous = 6
		}

		public Type type;

		public Direction direction;

		public bool shouldBeUsed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private DiscreteTime _003Ctimestamp_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private uint _003CplayerId_003Ek__BackingField;

		public DiscreteTime timestamp
		{
			[CompilerGenerated]
			set
			{
				_003Ctimestamp_003Ek__BackingField = value;
			}
		}

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

		internal static Direction DetermineMoveDirection(Vector2 vec, float deadZone = 0.6f)
		{
			return default(Direction);
		}
	}
}
