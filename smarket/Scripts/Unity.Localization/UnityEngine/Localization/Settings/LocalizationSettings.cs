using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.Metadata;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.Settings
{
	public class LocalizationSettings : ScriptableObject, IReset, IDisposable
	{
		[CompilerGenerated]
		private sealed class _003CInitializeAndCallSelectedLocaleChangedCoroutine_003Ed__79 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public LocalizationSettings _003C_003E4__this;

			public Locale locale;

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
			public _003CInitializeAndCallSelectedLocaleChangedCoroutine_003Ed__79(int _003C_003E1__state)
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
		}

		internal const string ConfigName = "com.unity.localization.settings";

		internal const string ConfigEditorLocale = "com.unity.localization-edit-locale";

		internal const string IgnoreSettings = "IgnoreSettings";

		internal const string LocaleLabel = "Locale";

		internal const string PreloadLabel = "Preload";

		[SerializeReference]
		private List<IStartupLocaleSelector> m_StartupSelectors;

		[SerializeReference]
		private ILocalesProvider m_AvailableLocales;

		[SerializeReference]
		private LocalizedAssetDatabase m_AssetDatabase;

		[SerializeReference]
		private LocalizedStringDatabase m_StringDatabase;

		[MetadataType(MetadataType.LocalizationSettings)]
		[SerializeField]
		private MetadataCollection m_Metadata;

		[SerializeField]
		internal LocaleIdentifier m_ProjectLocaleIdentifier;

		[SerializeField]
		private PreloadBehavior m_PreloadBehavior;

		[SerializeField]
		private bool m_InitializeSynchronously;

		internal AsyncOperationHandle<LocalizationSettings> m_InitializingOperationHandle;

		private AsyncOperationHandle<Locale> m_SelectedLocaleAsync;

		private Locale m_ProjectLocale;

		private CallbackArray<Action<Locale>> m_SelectedLocaleChanged;

		internal static LocalizationSettings s_Instance;

		internal bool IsChangingSelectedLocale { get; private set; }

		internal bool HasSelectedLocaleChangedSubscribers => false;

		public static bool HasSettings => false;

		public static AsyncOperationHandle<LocalizationSettings> InitializationOperation => default(AsyncOperationHandle<LocalizationSettings>);

		public static LocalizationSettings Instance
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static List<IStartupLocaleSelector> StartupLocaleSelectors => null;

		public static ILocalesProvider AvailableLocales
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static LocalizedAssetDatabase AssetDatabase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static LocalizedStringDatabase StringDatabase
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static MetadataCollection Metadata => null;

		public static Locale SelectedLocale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static AsyncOperationHandle<Locale> SelectedLocaleAsync => default(AsyncOperationHandle<Locale>);

		public static Locale ProjectLocale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool InitializeSynchronously
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public static PreloadBehavior PreloadBehavior
		{
			get
			{
				return default(PreloadBehavior);
			}
			set
			{
			}
		}

		internal virtual RuntimePlatform Platform => default(RuntimePlatform);

		public event Action<Locale> OnSelectedLocaleChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		public static event Action<Locale> SelectedLocaleChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		internal virtual void OnEnable()
		{
		}

		internal static void ValidateSettingsExist(string error = "")
		{
		}

		public virtual AsyncOperationHandle<LocalizationSettings> GetInitializationOperation()
		{
			return default(AsyncOperationHandle<LocalizationSettings>);
		}

		public List<IStartupLocaleSelector> GetStartupLocaleSelectors()
		{
			return null;
		}

		public void SetAvailableLocales(ILocalesProvider available)
		{
		}

		public virtual ILocalesProvider GetAvailableLocales()
		{
			return null;
		}

		public void SetAssetDatabase(LocalizedAssetDatabase database)
		{
		}

		public virtual LocalizedAssetDatabase GetAssetDatabase()
		{
			return null;
		}

		public void SetStringDatabase(LocalizedStringDatabase database)
		{
		}

		public virtual LocalizedStringDatabase GetStringDatabase()
		{
			return null;
		}

		public MetadataCollection GetMetadata()
		{
			return null;
		}

		public void ForceRefresh()
		{
		}

		internal void SendLocaleChangedEvents(Locale locale)
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeAndCallSelectedLocaleChangedCoroutine_003Ed__79))]
		private IEnumerator InitializeAndCallSelectedLocaleChangedCoroutine(Locale locale)
		{
			return null;
		}

		private void InvokeSelectedLocaleChanged(Locale locale)
		{
		}

		private Locale SelectActiveLocale()
		{
			return null;
		}

		protected internal virtual Locale SelectLocaleUsingStartupSelectors()
		{
			return null;
		}

		public void SetSelectedLocale(Locale locale)
		{
		}

		public virtual AsyncOperationHandle<Locale> GetSelectedLocaleAsync()
		{
			return default(AsyncOperationHandle<Locale>);
		}

		public virtual Locale GetSelectedLocale()
		{
			return null;
		}

		public virtual void OnLocaleRemoved(Locale locale)
		{
		}

		public void ResetState()
		{
		}

		void IDisposable.Dispose()
		{
		}

		public static LocalizationSettings GetInstanceDontCreateDefault()
		{
			return null;
		}

		private static LocalizationSettings GetOrCreateSettings()
		{
			return null;
		}
	}
}
