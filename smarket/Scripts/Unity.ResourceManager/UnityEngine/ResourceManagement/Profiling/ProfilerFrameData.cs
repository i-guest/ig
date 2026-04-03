using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.ResourceManagement.Profiling
{
	internal class ProfilerFrameData<T1, T2>
	{
		[CompilerGenerated]
		private sealed class _003CEnumerate_003Ed__17 : IEnumerable<KeyValuePair<T1, T2>>, IEnumerable, IEnumerator<KeyValuePair<T1, T2>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private KeyValuePair<T1, T2> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public ProfilerFrameData<T1, T2> _003C_003E4__this;

			private Dictionary<T1, T2>.Enumerator _003C_003E7__wrap1;

			KeyValuePair<T1, T2> IEnumerator<KeyValuePair<T1, T2>>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(KeyValuePair<T1, T2>);
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
			public _003CEnumerate_003Ed__17(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<KeyValuePair<T1, T2>> IEnumerable<KeyValuePair<T1, T2>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private Dictionary<T1, T2> m_Data;

		private T2[] m_Array;

		private uint m_Version;

		private uint m_ArrayVersion;

		internal Dictionary<T1, T2> Data => null;

		public T2[] Values => null;

		public T2 this[T1 key]
		{
			get
			{
				return default(T2);
			}
			set
			{
			}
		}

		public ProfilerFrameData()
		{
		}

		public ProfilerFrameData(int count)
		{
		}

		public bool Add(T1 key, T2 value)
		{
			return false;
		}

		internal bool Remove(T1 key)
		{
			return false;
		}

		public bool TryGetValue(T1 key, out T2 value)
		{
			value = default(T2);
			return false;
		}

		public bool ContainsKey(T1 key)
		{
			return false;
		}

		[IteratorStateMachine(typeof(ProfilerFrameData<, >._003CEnumerate_003Ed__17))]
		public IEnumerable<KeyValuePair<T1, T2>> Enumerate()
		{
			return null;
		}
	}
}
