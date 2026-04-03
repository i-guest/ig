using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct TextInputEvent : IEventProperties
	{
		public char character;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private DiscreteTime _003Ctimestamp_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
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
	}
}
