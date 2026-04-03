using System.Collections.Generic;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.Pool;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Operations
{
	internal class GetLocalizedStringOperation : WaitForCurrentOperationAsyncOperationBase<string>
	{
		private LocalizedStringDatabase m_Database;

		private AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> m_TableEntryOperation;

		private TableReference m_TableReference;

		private TableEntryReference m_TableEntryReference;

		private Locale m_SelectedLocale;

		private IList<object> m_Arguments;

		private IVariableGroup m_LocalVariables;

		private bool m_AutoRelease;

		public static readonly ObjectPool<GetLocalizedStringOperation> Pool;

		public void Init(AsyncOperationHandle<LocalizedDatabase<StringTable, StringTableEntry>.TableEntryResult> tableEntryOperation, Locale locale, LocalizedStringDatabase database, TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, IVariableGroup localVariables, bool autoRelease)
		{
		}

		protected override void Execute()
		{
		}

		public void CompleteAndRelease(string result, bool success, string errorMsg)
		{
		}

		protected override void Destroy()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
