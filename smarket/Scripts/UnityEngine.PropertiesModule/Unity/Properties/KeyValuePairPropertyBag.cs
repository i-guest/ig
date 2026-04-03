using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	public class KeyValuePairPropertyBag<TKey, TValue> : PropertyBag<KeyValuePair<TKey, TValue>>, INamedProperties<KeyValuePair<TKey, TValue>>
	{
		[CompilerGenerated]
		private sealed class _003CGetPropertiesEnumerable_003Ed__4 : IEnumerable<IProperty<KeyValuePair<TKey, TValue>>>, IEnumerable, IEnumerator<IProperty<KeyValuePair<TKey, TValue>>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private IProperty<KeyValuePair<TKey, TValue>> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			IProperty<KeyValuePair<TKey, TValue>> IEnumerator<IProperty<KeyValuePair<TKey, TValue>>>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
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
			public _003CGetPropertiesEnumerable_003Ed__4(int _003C_003E1__state)
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
			IEnumerator<IProperty<KeyValuePair<TKey, TValue>>> IEnumerable<IProperty<KeyValuePair<TKey, TValue>>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TKey> s_KeyProperty;

		private static readonly DelegateProperty<KeyValuePair<TKey, TValue>, TValue> s_ValueProperty;

		public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties()
		{
			return default(PropertyCollection<KeyValuePair<TKey, TValue>>);
		}

		public override PropertyCollection<KeyValuePair<TKey, TValue>> GetProperties(ref KeyValuePair<TKey, TValue> container)
		{
			return default(PropertyCollection<KeyValuePair<TKey, TValue>>);
		}

		[IteratorStateMachine(typeof(KeyValuePairPropertyBag<, >._003CGetPropertiesEnumerable_003Ed__4))]
		private static IEnumerable<IProperty<KeyValuePair<TKey, TValue>>> GetPropertiesEnumerable()
		{
			return null;
		}

		public bool TryGetProperty(ref KeyValuePair<TKey, TValue> container, string name, out IProperty<KeyValuePair<TKey, TValue>> property)
		{
			property = null;
			return false;
		}
	}
}
