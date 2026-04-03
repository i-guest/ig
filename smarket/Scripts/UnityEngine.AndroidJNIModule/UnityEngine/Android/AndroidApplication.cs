using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	[StaticAccessor("AndroidApplication", StaticAccessorType.DoubleColon)]
	[NativeHeader("Modules/AndroidJNI/Public/AndroidApplication.bindings.h")]
	public static class AndroidApplication
	{
		private static SynchronizationContext m_MainThreadSynchronizationContext;

		private static AndroidConfiguration m_CurrentConfiguration;

		private static AndroidInsets m_CurrentAndroidInsets;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<AndroidConfiguration> onConfigurationChanged;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<AndroidInsets> onInsetsChanged;

		internal static IntPtr UnityPlayerRaw
		{
			[ThreadSafe]
			get
			{
				return (IntPtr)0;
			}
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static void AcquireMainThreadSynchronizationContext()
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static void SetCurrentConfiguration(AndroidConfiguration config)
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static AndroidConfiguration GetCurrentConfiguration()
		{
			return null;
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static void DispatchConfigurationChanged(bool notifySubscribers)
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static void SetCurrentInsets(AndroidInsets insets)
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static AndroidInsets GetCurrentInsets()
		{
			return null;
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private static void DispatchInsetsChanged()
		{
		}
	}
}
