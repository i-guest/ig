using System;
using System.Collections;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[ExtensionOfNativeClass]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Scripting/DelayedCallUtility.h")]
	[NativeHeader("Runtime/Mono/MonoBehaviour.h")]
	public class MonoBehaviour : Behaviour
	{
		private CancellationTokenSource m_CancellationTokenSource;

		public CancellationToken destroyCancellationToken => default(CancellationToken);

		public bool useGUILayout
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool didStart => false;

		public bool didAwake => false;

		[RequiredByNativeCode]
		private void RaiseCancellation()
		{
		}

		public bool IsInvoking()
		{
			return false;
		}

		public void CancelInvoke()
		{
		}

		public void Invoke(string methodName, float time)
		{
		}

		public void InvokeRepeating(string methodName, float time, float repeatRate)
		{
		}

		public void CancelInvoke(string methodName)
		{
		}

		public bool IsInvoking(string methodName)
		{
			return false;
		}

		[ExcludeFromDocs]
		public Coroutine StartCoroutine(string methodName)
		{
			return null;
		}

		public Coroutine StartCoroutine(string methodName, [DefaultValue("null")] object value)
		{
			return null;
		}

		public Coroutine StartCoroutine(IEnumerator routine)
		{
			return null;
		}

		[Obsolete("StartCoroutine_Auto has been deprecated. Use StartCoroutine instead (UnityUpgradable) -> StartCoroutine([mscorlib] System.Collections.IEnumerator)", false)]
		public Coroutine StartCoroutine_Auto(IEnumerator routine)
		{
			return null;
		}

		public void StopCoroutine(IEnumerator routine)
		{
		}

		public void StopCoroutine(Coroutine routine)
		{
		}

		public void StopCoroutine(string methodName)
		{
		}

		public void StopAllCoroutines()
		{
		}

		public static void print(object message)
		{
		}

		[FreeFunction("CancelInvoke")]
		private static void Internal_CancelInvokeAll([NotNull] MonoBehaviour self)
		{
		}

		[FreeFunction("IsInvoking")]
		private static bool Internal_IsInvokingAll([NotNull] MonoBehaviour self)
		{
			return false;
		}

		[FreeFunction]
		private static void InvokeDelayed([NotNull] MonoBehaviour self, string methodName, float time, float repeatRate)
		{
		}

		[FreeFunction]
		private static void CancelInvoke([NotNull] MonoBehaviour self, string methodName)
		{
		}

		[FreeFunction]
		private static bool IsInvoking([NotNull] MonoBehaviour self, string methodName)
		{
			return false;
		}

		[FreeFunction]
		private static bool IsObjectMonoBehaviour([NotNull] Object obj)
		{
			return false;
		}

		private Coroutine StartCoroutineManaged(string methodName, object value)
		{
			return null;
		}

		private Coroutine StartCoroutineManaged2(IEnumerator enumerator)
		{
			return null;
		}

		private void StopCoroutineManaged(Coroutine routine)
		{
		}

		private void StopCoroutineFromEnumeratorManaged(IEnumerator routine)
		{
		}

		internal string GetScriptClassName()
		{
			return null;
		}

		private void OnCancellationTokenCreated()
		{
		}

		private static void StopCoroutine_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName)
		{
		}

		private static void StopAllCoroutines_Injected(IntPtr _unity_self)
		{
		}

		private static bool get_useGUILayout_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_useGUILayout_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_didStart_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_didAwake_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void Internal_CancelInvokeAll_Injected(IntPtr self)
		{
		}

		private static bool Internal_IsInvokingAll_Injected(IntPtr self)
		{
			return false;
		}

		private static void InvokeDelayed_Injected(IntPtr self, ref ManagedSpanWrapper methodName, float time, float repeatRate)
		{
		}

		private static void CancelInvoke_Injected(IntPtr self, ref ManagedSpanWrapper methodName)
		{
		}

		private static bool IsInvoking_Injected(IntPtr self, ref ManagedSpanWrapper methodName)
		{
			return false;
		}

		private static bool IsObjectMonoBehaviour_Injected(IntPtr obj)
		{
			return false;
		}

		private static Coroutine StartCoroutineManaged_Injected(IntPtr _unity_self, ref ManagedSpanWrapper methodName, object value)
		{
			return null;
		}

		private static Coroutine StartCoroutineManaged2_Injected(IntPtr _unity_self, IEnumerator enumerator)
		{
			return null;
		}

		private static void StopCoroutineManaged_Injected(IntPtr _unity_self, IntPtr routine)
		{
		}

		private static void StopCoroutineFromEnumeratorManaged_Injected(IntPtr _unity_self, IEnumerator routine)
		{
		}

		private static void GetScriptClassName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static void OnCancellationTokenCreated_Injected(IntPtr _unity_self)
		{
		}
	}
}
