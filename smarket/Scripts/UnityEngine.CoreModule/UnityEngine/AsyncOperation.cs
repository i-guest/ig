using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Scripting/AsyncOperation.bindings.h")]
	[NativeHeader("Runtime/Misc/AsyncOperation.h")]
	public class AsyncOperation : YieldInstruction
	{
		internal static class BindingsMarshaller
		{
			public static AsyncOperation ConvertToManaged(IntPtr ptr)
			{
				return null;
			}

			public static IntPtr ConvertToNative(AsyncOperation asyncOperation)
			{
				return (IntPtr)0;
			}
		}

		[VisibleToOtherModules]
		internal IntPtr m_Ptr;

		private Action<AsyncOperation> m_completeCallback;

		public bool isDone
		{
			[NativeMethod("IsDone")]
			get
			{
				return false;
			}
		}

		public float progress
		{
			[NativeMethod("GetProgress")]
			get
			{
				return 0f;
			}
		}

		public int priority
		{
			[NativeMethod("SetPriority")]
			set
			{
			}
		}

		public bool allowSceneActivation
		{
			[NativeMethod("GetAllowSceneActivation")]
			get
			{
				return false;
			}
			[NativeMethod("SetAllowSceneActivation")]
			set
			{
			}
		}

		public event Action<AsyncOperation> completed
		{
			add
			{
			}
			remove
			{
			}
		}

		[NativeMethod(IsThreadSafe = true)]
		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		private static void InternalDestroy(IntPtr ptr)
		{
		}

		[StaticAccessor("AsyncOperationBindings", StaticAccessorType.DoubleColon)]
		[NativeMethod(IsThreadSafe = true)]
		private static void InternalSetManagedObject(IntPtr ptr, [UnityMarshalAs(NativeType.ScriptingObjectPtr)] AsyncOperation self)
		{
		}

		protected AsyncOperation(IntPtr ptr)
		{
		}

		~AsyncOperation()
		{
		}

		[RequiredByNativeCode]
		internal void InvokeCompletionEvent()
		{
		}

		private static bool get_isDone_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static float get_progress_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_priority_Injected(IntPtr _unity_self, int value)
		{
		}

		private static bool get_allowSceneActivation_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_allowSceneActivation_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
