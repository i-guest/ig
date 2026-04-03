using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.AdaptivePerformance
{
	public sealed class AdaptivePerformanceManagerSettings : ScriptableObject
	{
		[CompilerGenerated]
		private sealed class _003CInitializeLoader_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AdaptivePerformanceManagerSettings _003C_003E4__this;

			private List<AdaptivePerformanceLoader>.Enumerator _003C_003Es__1;

			private AdaptivePerformanceLoader _003Cloader_003E5__2;

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
			public _003CInitializeLoader_003Ed__21(int _003C_003E1__state)
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

		[HideInInspector]
		private bool m_InitializationComplete;

		[SerializeField]
		[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for creating and destroying the appropriate loader instance.")]
		private bool m_AutomaticLoading;

		[Tooltip("Determines if the Adaptive Performance Manager instance is responsible for starting and stopping subsystems for the active loader instance.")]
		[SerializeField]
		private bool m_AutomaticRunning;

		[SerializeField]
		[Tooltip("List of Adaptive Performance Loader instances arranged in desired load order.")]
		private List<AdaptivePerformanceLoader> m_Loaders;

		[HideInInspector]
		private static AdaptivePerformanceLoader s_ActiveLoader;

		public bool automaticLoading
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool automaticRunning
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public List<AdaptivePerformanceLoader> loaders
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool isInitializationComplete => false;

		[HideInInspector]
		public AdaptivePerformanceLoader activeLoader
		{
			get
			{
				return null;
			}
			private set
			{
			}
		}

		public T ActiveLoaderAs<T>()
		{
			return default(T);
		}

		internal void InitializeLoaderSync()
		{
		}

		[IteratorStateMachine(typeof(_003CInitializeLoader_003Ed__21))]
		internal IEnumerator InitializeLoader()
		{
			return null;
		}

		internal void StartSubsystems()
		{
		}

		internal void StopSubsystems()
		{
		}

		internal void DeinitializeLoader()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
