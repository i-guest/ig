using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct KeyEvent : IEventProperties
	{
		public enum Type
		{
			KeyPressed = 1,
			KeyRepeated = 2,
			KeyReleased = 3,
			State = 4
		}

		public struct ButtonsState
		{
			[CompilerGenerated]
			private sealed class _003CGetAllPressed_003Ed__8 : IEnumerable<KeyCode>, IEnumerable, IEnumerator<KeyCode>, IEnumerator, IDisposable
			{
				private int _003C_003E1__state;

				private KeyCode _003C_003E2__current;

				private int _003C_003El__initialThreadId;

				public ButtonsState _003C_003E4__this;

				public ButtonsState _003C_003E3___003C_003E4__this;

				private uint _003Cindex_003E5__1;

				KeyCode IEnumerator<KeyCode>.Current
				{
					[DebuggerHidden]
					get
					{
						return default(KeyCode);
					}
				}

				object IEnumerator.Current
				{
					[DebuggerHidden]
					get
					{
						return null;
					}
				}

				[DebuggerHidden]
				public _003CGetAllPressed_003Ed__8(int _003C_003E1__state)
				{
				}

				[DebuggerHidden]
				void IDisposable.Dispose()
				{
				}

				private bool MoveNext()
				{
					return false;
				}

				bool IEnumerator.MoveNext()
				{
					//ILSpy generated this explicit interface implementation from .override directive in MoveNext
					return this.MoveNext();
				}

				[DebuggerHidden]
				void IEnumerator.Reset()
				{
				}

				[DebuggerHidden]
				IEnumerator<KeyCode> IEnumerable<KeyCode>.GetEnumerator()
				{
					return null;
				}

				[DebuggerHidden]
				IEnumerator IEnumerable.GetEnumerator()
				{
					return null;
				}
			}

			private unsafe fixed byte buttons[40];

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			internal static bool ShouldBeProcessed(KeyCode keyCode)
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private bool GetUnchecked(uint index)
			{
				return false;
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void SetUnchecked(uint index)
			{
			}

			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			private void ClearUnchecked(uint index)
			{
			}

			public bool IsPressed(KeyCode keyCode)
			{
				return false;
			}

			[IteratorStateMachine(typeof(_003CGetAllPressed_003Ed__8))]
			public IEnumerable<KeyCode> GetAllPressed()
			{
				return null;
			}

			public void SetPressed(KeyCode keyCode, bool pressed)
			{
			}

			public void Reset()
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public Type type;

		public KeyCode keyCode;

		public ButtonsState buttonsState;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
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
