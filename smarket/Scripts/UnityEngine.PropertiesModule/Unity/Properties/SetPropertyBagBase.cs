using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Unity.Properties
{
	public class SetPropertyBagBase<TSet, TElement> : PropertyBag<TSet>, ISetPropertyBag<TSet, TElement>, ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, IKeyedProperties<TSet, object>
	{
		private class SetElementProperty : Property<TSet, TElement>, ISetElementProperty
		{
			internal TElement m_Value;

			public override string Name => null;

			public override bool IsReadOnly => false;

			public object ObjectKey => null;

			public override TElement GetValue(ref TSet container)
			{
				return default(TElement);
			}

			public override void SetValue(ref TSet container, TElement value)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetPropertiesEnumerable_003Ed__4 : IEnumerable<IProperty<TSet>>, IEnumerable, IEnumerator<IProperty<TSet>>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private IProperty<TSet> _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private TSet container;

			public TSet _003C_003E3__container;

			public SetPropertyBagBase<TSet, TElement> _003C_003E4__this;

			private IEnumerator<TElement> _003C_003Es__1;

			private TElement _003Celement_003E5__2;

			IProperty<TSet> IEnumerator<IProperty<TSet>>.Current
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<IProperty<TSet>> IEnumerable<IProperty<TSet>>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private readonly SetElementProperty m_Property;

		public override PropertyCollection<TSet> GetProperties()
		{
			return default(PropertyCollection<TSet>);
		}

		public override PropertyCollection<TSet> GetProperties(ref TSet container)
		{
			return default(PropertyCollection<TSet>);
		}

		[IteratorStateMachine(typeof(SetPropertyBagBase<, >._003CGetPropertiesEnumerable_003Ed__4))]
		private IEnumerable<IProperty<TSet>> GetPropertiesEnumerable(TSet container)
		{
			return null;
		}

		void ICollectionPropertyBagAccept<TSet>.Accept(ICollectionPropertyBagVisitor visitor, ref TSet container)
		{
		}

		void ISetPropertyBagAccept<TSet>.Accept(ISetPropertyBagVisitor visitor, ref TSet container)
		{
		}

		public bool TryGetProperty(ref TSet container, object key, out IProperty<TSet> property)
		{
			property = null;
			return false;
		}
	}
}
