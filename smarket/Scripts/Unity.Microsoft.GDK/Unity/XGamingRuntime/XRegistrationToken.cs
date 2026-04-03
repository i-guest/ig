using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	[Obsolete("XRegistrationToken has been removed. If you are upgrading from a legacy package, please refer to the migration guide.", true)]
	public class XRegistrationToken
	{
	}
	public abstract class XRegistrationToken<T> : CallbackWrapper<T> where T : Delegate
	{
		public ulong Token;

		public bool IsValid => false;

		protected XRegistrationToken(T callback, IntPtr context, T staticCallback)
			: base((T)null, (IntPtr)0, (T)null)
		{
		}

		protected override void Dispose(bool disposing)
		{
		}

		protected abstract void DisposeInternal(bool disposing);
	}
}
