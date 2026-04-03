using System;
using System.Runtime.InteropServices;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class HCWebsocketHandle : EquatableHandle
	{
		internal Unity.XGamingRuntime.Interop.HCWebSocketMessageFunction messageFunc;

		internal Unity.XGamingRuntime.Interop.HCWebSocketBinaryMessageFunction binaryMessageFunc;

		internal Unity.XGamingRuntime.Interop.HCWebSocketCloseEventFunction closeFunc;

		internal HCWebSocketMessageFunction messageCallback;

		internal HCWebSocketBinaryMessageFunction binaryMessageCallback;

		internal HCWebSocketCloseEventFunction closeCallback;

		internal GCHandle cbHandle;

		public HCWebSocketMessageFunction MessageFunction => null;

		public HCWebSocketBinaryMessageFunction BinaryMessageFunction => null;

		public HCWebSocketCloseEventFunction CloseFunction => null;

		public override bool IsInvalid => false;

		internal HCWebsocketHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal HCWebsocketHandle(IntPtr handle, bool ownsHandle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		internal static int WrapAndReturnHResult(int hresult, IntPtr interopHandle, out HCWebsocketHandle handle, GCHandle callbackHandle)
		{
			handle = null;
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}

		public static bool operator ==(HCWebsocketHandle handle1, HCWebsocketHandle handle2)
		{
			return false;
		}

		public static bool operator !=(HCWebsocketHandle handle1, HCWebsocketHandle handle2)
		{
			return false;
		}
	}
}
