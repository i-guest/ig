using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Localization.PropertyVariants.TrackedObjects;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization.PropertyVariants
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	public class GameObjectLocalizer : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CStart_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GameObjectLocalizer _003C_003E4__this;

			private AsyncOperationHandle<Locale> _003ClocaleOp_003E5__2;

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
			public _003CStart_003Ed__10(int _003C_003E1__state)
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

		[SerializeReference]
		private List<TrackedObject> m_TrackedObjects;

		private Locale m_CurrentLocale;

		private LocalizedString.ChangeHandler m_LocalizedStringChanged;

		private bool m_IgnoreChange;

		internal AsyncOperationHandle CurrentOperation { get; set; }

		public List<TrackedObject> TrackedObjects => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[IteratorStateMachine(typeof(_003CStart_003Ed__10))]
		private IEnumerator Start()
		{
			return null;
		}

		private void SelectedLocaleChanged(Locale locale)
		{
		}

		public T GetTrackedObject<T>(Object target, bool create = true) where T : new()
		{
			return default(T);
		}

		public TrackedObject GetTrackedObject(Object target)
		{
			return null;
		}

		public AsyncOperationHandle ApplyLocaleVariant(Locale locale)
		{
			return default(AsyncOperationHandle);
		}

		public AsyncOperationHandle ApplyLocaleVariant(Locale locale, Locale fallback)
		{
			return default(AsyncOperationHandle);
		}

		private void RegisterChanges()
		{
		}

		private void UnregisterChanges()
		{
		}

		internal void RequestUpdate()
		{
		}
	}
}
