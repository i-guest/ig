using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat.Core.Extensions;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UIElements;

namespace UnityEngine.Localization
{
	[Serializable]
	[UxmlObject]
	public class LocalizedString : LocalizedReference, IVariableGroup, IDictionary<string, IVariable>, ICollection<KeyValuePair<string, IVariable>>, IEnumerable<KeyValuePair<string, IVariable>>, IEnumerable, IVariableValueChanged, IVariable, IDisposable
	{
		public delegate void ChangeHandler(string value);

		private struct StringTableEntryVariable : IVariableGroup
		{
			private readonly string m_Localized;

			private readonly StringTableEntry m_StringTableEntry;

			public StringTableEntryVariable(string localized, StringTableEntry entry)
			{
				m_Localized = null;
				m_StringTableEntry = null;
			}

			public bool TryGetValue(string key, out IVariable value)
			{
				value = null;
				return false;
			}

			public override string ToString()
			{
				return null;
			}
		}

		private struct ChainedLocalVariablesGroup : IVariableGroup
		{
			private IVariableGroup ParentGroup { get; set; }

			private IVariableGroup Group { get; set; }

			public ChainedLocalVariablesGroup(IVariableGroup group, IVariableGroup parent)
			{
				ParentGroup = null;
				Group = null;
			}

			public bool TryGetValue(string key, out IVariable value)
			{
				value = null;
				return false;
			}
		}

		[Serializable]
		public new class UxmlSerializedData : LocalizedReference.UxmlSerializedData
		{
			[UxmlObjectReference("variables")]
			[SerializeReference]
			private List<LocalVariable.UxmlSerializedData> LocalVariablesUXML;

			[SerializeField]
			[UxmlIgnore]
			[HideInInspector]
			private UxmlAttributeFlags LocalVariablesUXML_UxmlAttributeFlags;

			[RegisterUxmlCache]
			[Conditional("UNITY_EDITOR")]
			public new static void Register()
			{
			}

			public override object CreateInstance()
			{
				return null;
			}

			public override void Deserialize(object obj)
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CGetEnumerator_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LocalizedString _003C_003E4__this;

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
			public _003CGetEnumerator_003Ed__58(int _003C_003E1__state)
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
		private List<VariableNameValuePair> m_LocalVariables;

		private CallbackArray<ChangeHandler> m_ChangeHandler;

		private string m_CurrentStringChangedValue;

		private readonly Dictionary<string, VariableNameValuePair> m_VariableLookup;

		private readonly List<IVariableValueChanged> m_UsedVariables;

		private readonly Action<IVariable> m_OnVariableChanged;

		private readonly Action<Locale> m_SelectedLocaleChanged;

		private readonly Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>> m_AutomaticLoadingCompleted;

		private readonly Action<AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult>> m_CompletedSourceValue;

		private bool m_WaitingForVariablesEndUpdate;

		private List<LocalVariable> m_UxmlLocalVariables;

		internal override bool ForceSynchronous => false;

		public IList<object> Arguments { get; set; }

		public AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> CurrentLoadingOperationHandle { get; internal set; }

		public bool HasChangeHandler => false;

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

		[UxmlObjectReference("variables")]
		internal List<LocalVariable> LocalVariablesUXML
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event Action<IVariable> ValueChanged
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

		public event ChangeHandler StringChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public LocalizedString()
		{
		}

		public LocalizedString(TableReference tableReference, TableEntryReference entryReference)
		{
		}

		public bool RefreshString()
		{
			return false;
		}

		public AsyncOperationHandle<string> GetLocalizedStringAsync()
		{
			return default(AsyncOperationHandle<string>);
		}

		public string GetLocalizedString()
		{
			return null;
		}

		public AsyncOperationHandle<string> GetLocalizedStringAsync(params object[] arguments)
		{
			return default(AsyncOperationHandle<string>);
		}

		public string GetLocalizedString(params object[] arguments)
		{
			return null;
		}

		public string GetLocalizedString(IList<object> arguments)
		{
			return null;
		}

		public AsyncOperationHandle<string> GetLocalizedStringAsync(IList<object> arguments)
		{
			return default(AsyncOperationHandle<string>);
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

		[IteratorStateMachine(typeof(_003CSystem_002DCollections_002DGeneric_002DIEnumerable_003CSystem_002DCollections_002DGeneric_002DKeyValuePair_003CSystem_002DString_005C_002CUnityEngine_002DLocalization_002DSmartFormat_002DPersistentVariables_002DIVariable_003E_003E_002DGetEnumerator_003Ed__57))]
		IEnumerator<KeyValuePair<string, IVariable>> IEnumerable<KeyValuePair<string, IVariable>>.GetEnumerator()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CGetEnumerator_003Ed__58))]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		public void Clear()
		{
		}

		public object GetSourceValue(ISelectorInfo selector)
		{
			return null;
		}

		private void CompletedSourceValue(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> _)
		{
		}

		protected internal override void ForceUpdate()
		{
		}

		private void ClearVariableListeners()
		{
		}

		private void UpdateVariableListeners(List<IVariableValueChanged> variables)
		{
		}

		private void OnVariableChanged(IVariable globalVariable)
		{
		}

		private void OnVariablesSourceUpdateCompleted()
		{
		}

		private void InvokeChangeHandler(string value)
		{
		}

		private void HandleLocaleChange(Locale locale)
		{
		}

		private void AutomaticLoadingCompleted(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> loadOperation)
		{
		}

		private void ClearLoadingOperation()
		{
		}

		protected override void Reset()
		{
		}

		public override void OnAfterDeserialize()
		{
		}

		~LocalizedString()
		{
		}

		void IDisposable.Dispose()
		{
		}

		protected override void Initialize()
		{
		}

		protected override void Cleanup()
		{
		}

		protected override BindingResult Update(in BindingContext context)
		{
			return default(BindingResult);
		}

		private void UpdateBindingValue(string _)
		{
		}
	}
}
