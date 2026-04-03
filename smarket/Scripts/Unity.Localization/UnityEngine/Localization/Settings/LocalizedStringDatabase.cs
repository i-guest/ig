using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.SmartFormat;
using UnityEngine.Localization.SmartFormat.PersistentVariables;
using UnityEngine.Localization.Tables;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	[Serializable]
	public class LocalizedStringDatabase : LocalizedDatabase<StringTable, StringTableEntry>
	{
		public delegate void MissingTranslation(string key, long keyId, TableReference tableReference, StringTable table, Locale locale, string noTranslationFoundMessage);

		[SerializeField]
		private MissingTranslationBehavior m_MissingTranslationState;

		private const string k_DefaultNoTranslationMessage = "No translation found for '{key}' in {table.TableCollectionName}";

		[SerializeField]
		[Tooltip("The string that will be used when a localized value is missing. This is a Smart String which has access to the following placeholders:\n\t{key}: The name of the key\n\t{keyId}: The numeric Id of the key\n\t{table}: The table object, this can be further queried, for example {table.TableCollectionName}\n\t{locale}: The locale asset, this can be further queried, for example {locale.name}")]
		private string m_NoTranslationFoundMessage;

		[SerializeReference]
		private SmartFormatter m_SmartFormat;

		private StringTable m_MissingTranslationTable;

		public string NoTranslationFoundMessage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MissingTranslationBehavior MissingTranslationState
		{
			get
			{
				return default(MissingTranslationBehavior);
			}
			set
			{
			}
		}

		public SmartFormatter SmartFormatter
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event MissingTranslation TranslationNotFound
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

		public AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, params object[] arguments)
		{
			return default(AsyncOperationHandle<string>);
		}

		public string GetLocalizedString(TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, params object[] arguments)
		{
			return null;
		}

		public AsyncOperationHandle<string> GetLocalizedStringAsync(TableEntryReference tableEntryReference, IList<object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return default(AsyncOperationHandle<string>);
		}

		public string GetLocalizedString(TableEntryReference tableEntryReference, IList<object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return null;
		}

		public virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, params object[] arguments)
		{
			return default(AsyncOperationHandle<string>);
		}

		public virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, params object[] arguments)
		{
			return null;
		}

		public virtual AsyncOperationHandle<string> GetLocalizedStringAsync(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, IVariableGroup localVariables = null)
		{
			return default(AsyncOperationHandle<string>);
		}

		internal virtual AsyncOperationHandle<string> GetLocalizedStringAsyncInternal(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings, IVariableGroup localVariables = null, bool autoRelease = true)
		{
			return default(AsyncOperationHandle<string>);
		}

		public virtual string GetLocalizedString(TableReference tableReference, TableEntryReference tableEntryReference, IList<object> arguments, Locale locale = null, FallbackBehavior fallbackBehavior = FallbackBehavior.UseProjectSettings)
		{
			return null;
		}

		protected internal virtual string GenerateLocalizedString(StringTable table, StringTableEntry entry, TableReference tableReference, TableEntryReference tableEntryReference, Locale locale, IList<object> arguments)
		{
			return null;
		}

		private StringTable GetUntranslatedTextTempTable(TableReference tableReference)
		{
			return null;
		}

		internal string ProcessUntranslatedText(string key, long keyId, TableReference tableReference, StringTable table, Locale locale)
		{
			return null;
		}
	}
}
