using System;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/GameCode/AsyncInstantiate/AsyncInstantiateOperation.h")]
	[RequiredByNativeCode]
	public class AsyncInstantiateOperation : AsyncOperation
	{
		internal static CancellationTokenSource s_GlobalCancellation;

		internal Object[] m_Result;

		private CancellationToken m_CancellationToken;

		protected AsyncInstantiateOperation(IntPtr ptr, CancellationToken cancellationToken)
			: base((IntPtr)0)
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private bool IsCancellationRequested()
		{
			return false;
		}

		internal virtual Object[] CreateResultArray(int size)
		{
			return null;
		}
	}
	public class AsyncInstantiateOperation<T> : AsyncInstantiateOperation
	{
		internal AsyncInstantiateOperation(IntPtr ptr, CancellationToken cancellationToken)
			: base((IntPtr)0, default(CancellationToken))
		{
		}

		internal override Object[] CreateResultArray(int size)
		{
			return null;
		}
	}
}
