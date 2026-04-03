using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UnityConsent
{
	[NativeHeader("Modules/UnityConsent/EndUserConsent.h")]
	public static class EndUserConsent
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<ConsentState> consentStateChanged;

		[NativeMethod("GetConsentStateStatic")]
		public static ConsentState GetConsentState()
		{
			return default(ConsentState);
		}

		[RequiredByNativeCode]
		private static void OnConsentStateChanged()
		{
		}

		private static void GetConsentState_Injected(out ConsentState ret)
		{
			ret = default(ConsentState);
		}
	}
}
