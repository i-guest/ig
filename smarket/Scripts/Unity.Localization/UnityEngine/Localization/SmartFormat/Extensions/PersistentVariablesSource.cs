using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.PersistentVariables;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class PersistentVariablesSource : ISource, IDictionary<string, VariablesGroupAsset>, ICollection<KeyValuePair<string, VariablesGroupAsset>>, IEnumerable<KeyValuePair<string, VariablesGroupAsset>>, IEnumerable, ISerializationCallbackReceiver
	{
		[Serializable]
		private class NameValuePair
		{
			public string name;

			[SerializeReference]
			public VariablesGroupAsset group;
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		public struct ScopedUpdate : IDisposable
		{
			public void Dispose()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PersistentVariablesSource _003C_003E4__this;

			private Dictionary<string, NameValuePair>.Enumerator _003C_003E7__wrap1;

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
			public _003CGetEnumerator_003Ed__35(int _003C_003E1__state)
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
		private List<NameValuePair> m_Groups;

		private Dictionary<string, NameValuePair> m_GroupLookup;

		internal static int s_IsUpdating;

		public static bool IsUpdating => false;

		public int Count => 0;

		public bool IsReadOnly => false;

		public ICollection<string> Keys => null;

		public ICollection<VariablesGroupAsset> Values => null;

		public VariablesGroupAsset this[string name]
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static event Action EndUpdate
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public PersistentVariablesSource(SmartFormatter formatter)
		{
		}

		public static void BeginUpdating()
		{
		}

		public static void EndUpdating()
		{
		}

		public static IDisposable UpdateScope()
		{
			return null;
		}

		public bool TryGetValue(string name, out VariablesGroupAsset value)
		{
			value = null;
			return false;
		}

		public void Add(string name, VariablesGroupAsset group)
		{
		}

		public void Add(KeyValuePair<string, VariablesGroupAsset> item)
		{
		}

		public bool Remove(string name)
		{
			return false;
		}

		public bool Remove(KeyValuePair<string, VariablesGroupAsset> item)
		{
			return false;
		}

		public void Clear()
		{
		}

		public bool ContainsKey(string name)
		{
			return false;
		}

		public bool Contains(KeyValuePair<string, VariablesGroupAsset> item)
		{
			return false;
		}

		public void CopyTo(KeyValuePair<string, VariablesGroupAsset>[] array, int arrayIndex)
		{
		}

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DCollections_002DGeneric_002DKeyValuePair_003CSystem_002DString_005C_002CUnityEngine_002DLocalization_002DSmartFormat_002DPersistentVariables_002DVariablesGroupAsset_003E_003E_002DGetEnumerator_003Ed__34))]
		IEnumerator<KeyValuePair<string, VariablesGroupAsset>> IEnumerable<KeyValuePair<string, VariablesGroupAsset>>.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__35))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			return false;
		}

		private static bool EvaluateLocalGroup(ISelectorInfo selectorInfo, IVariableGroup variablleGroup)
		{
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
