using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.Localization.SmartFormat.Utilities
{
	public static class TupleExtensions
	{
		[CompilerGenerated]
		private sealed class _003CGetValueTupleItemObjectsFlattened_003Ed__6 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private object tuple;

			public object _003C_003E3__tuple;

			private IEnumerator<object> _003C_003E7__wrap1;

			private IEnumerator<object> _003C_003E7__wrap2;

			object IEnumerator<object>.Current
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
			public _003CGetValueTupleItemObjectsFlattened_003Ed__6(int _003C_003E1__state)
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

			private void _003C_003Em__Finally2()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<object> IEnumerable<object>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		private static readonly HashSet<Type> ValueTupleTypes;

		public static bool IsValueTuple(this object obj)
		{
			return false;
		}

		public static bool IsValueTupleType(this Type type)
		{
			return false;
		}

		public static IEnumerable<object> GetValueTupleItemObjects(this object tuple)
		{
			return null;
		}

		public static IEnumerable<Type> GetValueTupleItemTypes(this Type tupleType)
		{
			return null;
		}

		public static List<FieldInfo> GetValueTupleItemFields(this Type tupleType)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetValueTupleItemObjectsFlattened_003Ed__6))]
		public static IEnumerable<object> GetValueTupleItemObjectsFlattened(this object tuple)
		{
			return null;
		}
	}
}
