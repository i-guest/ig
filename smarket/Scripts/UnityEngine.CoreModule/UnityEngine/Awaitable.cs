using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Threading;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Pool;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[AsyncMethodBuilder(typeof(AwaitableAsyncMethodBuilder))]
	[NativeHeader("Runtime/Mono/Awaitable.h")]
	[NativeHeader("Runtime/Mono/AsyncOperationAwaitable.h")]
	[NativeHeader("Runtime/Mono/DelayedCallAwaitable.h")]
	public class Awaitable : IEnumerator
	{
		internal enum AwaiterCompletionThreadAffinity
		{
			None = 0,
			MainThread = 1,
			BackgroundThread = 2
		}

		[ExcludeFromDocs]
		public struct AwaitableAsyncMethodBuilder
		{
			private interface IStateMachineBox : IDisposable
			{
			}

			private IStateMachineBox _stateMachineBox;

			private Awaitable _resultingCoroutine;
		}

		private readonly struct AwaitableHandle
		{
			private readonly IntPtr _handle;

			public static AwaitableHandle ManagedHandle;

			public static AwaitableHandle NullHandle;

			public bool IsNull => false;

			public bool IsManaged => false;

			public AwaitableHandle(IntPtr handle)
			{
				_handle = (IntPtr)0;
			}

			public static implicit operator IntPtr(AwaitableHandle handle)
			{
				return (IntPtr)0;
			}
		}

		private struct AwaitableAndFrameIndex
		{
			public Awaitable Awaitable { get; }

			public int FrameIndex { get; }
		}

		private class DoubleBufferedAwaitableList
		{
			private List<AwaitableAndFrameIndex> _awaitables;

			private List<AwaitableAndFrameIndex> _scratch;

			public void SwapAndComplete()
			{
			}

			public void Clear()
			{
			}
		}

		private SpinLock _spinLock;

		private static readonly ThreadLocal<ObjectPool<Awaitable>> _pool;

		private AwaitableHandle _handle;

		private ExceptionDispatchInfo _exceptionToRethrow;

		private bool _managedAwaitableDone;

		private AwaiterCompletionThreadAffinity _completionThreadAffinity;

		private Action _continuation;

		private CancellationTokenRegistration? _cancelTokenRegistration;

		private DoubleBufferedAwaitableList _managedCompletionQueue;

		private static bool _nextFrameAndEndOfFrameWiredUp;

		private static CancellationTokenRegistration _nextFrameAndEndOfFrameWiredUpCTRegistration;

		private static readonly DoubleBufferedAwaitableList _nextFrameAwaitables;

		private static readonly DoubleBufferedAwaitableList _endOfFrameAwaitables;

		private static SynchronizationContext _synchronizationContext;

		private static int _mainThreadId;

		private bool IsCompletedNoLock => false;

		public bool IsCompleted => false;

		internal bool IsDettachedOrCompleted => false;

		object IEnumerator.Current => null;

		[RequiredByNativeCode(GenerateProxy = true)]
		private void SetExceptionFromNative(Exception ex)
		{
		}

		[RequiredByNativeCode(GenerateProxy = true)]
		private void RunContinuation()
		{
		}

		[FreeFunction("Scripting::Awaitables::Release", IsThreadSafe = true)]
		private static void ReleaseNativeAwaitable(IntPtr nativeAwaitable)
		{
		}

		[FreeFunction("Scripting::Awaitables::IsCompleted", IsThreadSafe = true)]
		private static int IsNativeAwaitableCompleted(IntPtr nativeAwaitable)
		{
			return 0;
		}

		private Awaitable()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool MatchCompletionThreadAffinity(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity)
		{
			return false;
		}

		private void RunOrScheduleContinuation(AwaiterCompletionThreadAffinity awaiterCompletionThreadAffinity, Action continuation)
		{
		}

		private static void DoRunContinuationOnSynchonizationContext(object continuation)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void RaiseManagedCompletion()
		{
		}

		internal void PropagateExceptionAndRelease()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private AwaitableHandle CheckPointerValidity()
		{
			return default(AwaitableHandle);
		}

		bool IEnumerator.MoveNext()
		{
			return false;
		}

		void IEnumerator.Reset()
		{
		}

		[RequiredByNativeCode]
		private static void OnDelayedCallManagerCleared()
		{
		}

		[RequiredByNativeCode]
		private static void OnUpdate()
		{
		}

		[RequiredByNativeCode]
		private static void OnEndOfFrame()
		{
		}

		internal static void SetSynchronizationContext(UnitySynchronizationContext synchronizationContext)
		{
		}
	}
}
