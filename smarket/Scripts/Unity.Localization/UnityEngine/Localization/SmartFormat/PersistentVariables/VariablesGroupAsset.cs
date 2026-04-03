using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[CreateAssetMenu(menuName = "Localization/Variables Group")]
	public class VariablesGroupAsset : ScriptableObject, IVariableGroup, IVariable, IDictionary<string, IVariable>, ICollection<KeyValuePair<string, IVariable>>, IEnumerable<KeyValuePair<string, IVariable>>, IEnumerable, ISerializationCallbackReceiver
	{
		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public VariablesGroupAsset _003C_003E4__this;

			private Dictionary<string, VariableNameValuePair>.Enumerator _003C_003E7__wrap1;

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
			public _003CGetEnumerator_003Ed__23(int _003C_003E1__state)
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
		}

		[SerializeField]
		internal List<VariableNameValuePair> m_Variables;

		private Dictionary<string, VariableNameValuePair> m_VariableLookup;

		public int Count => 0;

		public ICollection<string> Keys => null;

		public ICollection<IVariable> Values => null;

		public bool IsReadOnly => false;

		public IVariable this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object GetSourceValue(ISelectorInfo _)
		{
			return null;
		}

		public bool TryGetValue(string name, out IVariable value)
		{
			value = null;
			return false;
		}

		public void Add(string name, IVariable variable)
		{
		}

		public void Add(KeyValuePair<string, IVariable> item)
		{
		}

		public bool Remove(string name)
		{
			return false;
		}

		public bool Remove(KeyValuePair<string, IVariable> item)
		{
			return false;
		}

		public bool ContainsKey(string name)
		{
			return false;
		}

		public bool Contains(KeyValuePair<string, IVariable> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, IVariable>[] array, int arrayIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DCollections_002DGeneric_002DKeyValuePair_003CSystem_002DString_005C_002CUnityEngine_002DLocalization_002DSmartFormat_002DPersistentVariables_002DIVariable_003E_003E_002DGetEnumerator_003Ed__22))]
		IEnumerator<KeyValuePair<string, IVariable>> IEnumerable<KeyValuePair<string, IVariable>>.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__23))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[Obsolete("Please use ContainsKey instead.", false)]
		public bool ContainsName(string name)
		{
			return false;
		}

		public void Clear()
		{
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
