using System;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StaticAccessor("GetObjectDispatcher()", StaticAccessorType.Dot)]
	[NativeHeader("Runtime/Misc/ObjectDispatcher.h")]
	[RequiredByNativeCode]
	internal sealed class ObjectDispatcher : IDisposable
	{
		public enum TransformTrackingType
		{
			GlobalTRS = 0,
			LocalTRS = 1,
			Hierarchy = 2
		}

		[Flags]
		public enum TypeTrackingFlags
		{
			SceneObjects = 1,
			Assets = 2,
			EditorOnlyObjects = 4,
			Default = 3,
			All = 7
		}

		private IntPtr m_Ptr;

		private Allocator m_DispatchAllocator;

		private TypeDispatchData m_TypeDispatchData;

		private TransformDispatchData m_TransformDispatchData;

		private Component[] m_TransformedComponents;

		private Action<TypeDispatchData> m_TypeDataCallback;

		private Action<TransformDispatchData> m_TransformDataCallback;

		private Action<Component[]> m_TransformComponentCallback;

		private static Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> s_TypeDispatch;

		private static Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> s_TransformDispatch;

		public bool valid => false;

		~ObjectDispatcher()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		private void ValidateSystemHandleAndThrow()
		{
		}

		private void ValidateTypeAndThrow(Type type)
		{
		}

		private void ValidateComponentTypeAndThrow(Type type)
		{
		}

		private void DispatchCallback(TypeDispatchData data)
		{
		}

		private void DispatchCallback(TransformDispatchData data)
		{
		}

		private void DispatchCallback(Component[] components)
		{
		}

		public void DispatchTypeChangesAndClear(Type type, Action<TypeDispatchData> callback, bool sortByInstanceID = false, bool noScriptingArray = false)
		{
		}

		public void DispatchTransformChangesAndClear(Type type, TransformTrackingType trackingType, Action<TransformDispatchData> callback)
		{
		}

		public TypeDispatchData GetTypeChangesAndClear(Type type, Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false)
		{
			return default(TypeDispatchData);
		}

		public TransformDispatchData GetTransformChangesAndClear(Type type, TransformTrackingType trackingType, Allocator allocator)
		{
			return default(TransformDispatchData);
		}

		public void EnableTypeTracking(TypeTrackingFlags typeTrackingMask, params Type[] types)
		{
		}

		public void EnableTransformTracking(TransformTrackingType trackingType, params Type[] types)
		{
		}

		public TypeDispatchData GetTypeChangesAndClear<T>(Allocator allocator, bool sortByInstanceID = false, bool noScriptingArray = false) where T : Object
		{
			return default(TypeDispatchData);
		}

		public TransformDispatchData GetTransformChangesAndClear<T>(TransformTrackingType trackingType, Allocator allocator) where T : Object
		{
			return default(TransformDispatchData);
		}

		public void EnableTypeTracking<T>(TypeTrackingFlags typeTrackingMask = TypeTrackingFlags.Default) where T : Object
		{
		}

		public void EnableTransformTracking<T>(TransformTrackingType trackingType) where T : Object
		{
		}

		private static IntPtr CreateDispatchSystemHandle()
		{
			return (IntPtr)0;
		}

		[ThreadSafe]
		private static void DestroyDispatchSystemHandle(IntPtr ptr)
		{
		}

		private static void EnableTypeTracking(IntPtr ptr, Type type, TypeTrackingFlags typeTrackingMask)
		{
		}

		private static void EnableTransformTracking(IntPtr ptr, Type type, TransformTrackingType trackingType)
		{
		}

		private static void DispatchTypeChangesAndClear(IntPtr ptr, Type type, Action<Object[], IntPtr, IntPtr, int, int, Action<TypeDispatchData>> callback, bool sortByInstanceID, bool noScriptingArray, Action<TypeDispatchData> param)
		{
		}

		private static void DispatchTransformDataChangesAndClear(IntPtr ptr, Type type, TransformTrackingType trackingType, Action<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, IntPtr, int, Action<TransformDispatchData>> callback, Action<TransformDispatchData> param)
		{
		}
	}
}
