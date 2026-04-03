using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Runtime/Export/Camera/CullingGroup.bindings.h")]
	public class CullingGroup : IDisposable
	{
		public delegate void StateChanged(CullingGroupEvent sphere);

		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(CullingGroup cullingGroup)
			{
				return (IntPtr)0;
			}
		}

		internal IntPtr m_Ptr;

		private StateChanged m_OnStateChanged;

		public StateChanged onStateChanged
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Camera targetCamera
		{
			set
			{
			}
		}

		~CullingGroup()
		{
		}

		[FreeFunction("CullingGroup_Bindings::Dispose", HasExplicitThis = true)]
		private void DisposeInternal()
		{
		}

		public void Dispose()
		{
		}

		public void SetBoundingSpheres([UnityMarshalAs(NativeType.ScriptingObjectPtr)] BoundingSphere[] array)
		{
		}

		public void SetBoundingSphereCount(int count)
		{
		}

		public int QueryIndices(bool visible, int[] result, int firstIndex)
		{
			return 0;
		}

		[NativeThrows]
		[FreeFunction("CullingGroup_Bindings::QueryIndices", HasExplicitThis = true)]
		private int QueryIndices(bool visible, int distanceIndex, CullingQueryOptions options, int[] result, int firstIndex)
		{
			return 0;
		}

		[FreeFunction("CullingGroup_Bindings::IsVisible", HasExplicitThis = true)]
		[NativeThrows]
		public bool IsVisible(int index)
		{
			return false;
		}

		[NativeThrows]
		[FreeFunction("CullingGroup_Bindings::GetDistance", HasExplicitThis = true)]
		public int GetDistance(int index)
		{
			return 0;
		}

		[FreeFunction("CullingGroup_Bindings::SetBoundingDistances", HasExplicitThis = true)]
		public void SetBoundingDistances(float[] distances)
		{
		}

		[FreeFunction("CullingGroup_Bindings::SetDistanceReferencePoint", HasExplicitThis = true)]
		private void SetDistanceReferencePoint_InternalVector3(Vector3 point)
		{
		}

		[NativeMethod("SetDistanceReferenceTransform")]
		private void SetDistanceReferencePoint_InternalTransform(Transform transform)
		{
		}

		public void SetDistanceReferencePoint(Vector3 point)
		{
		}

		public void SetDistanceReferencePoint(Transform transform)
		{
		}

		[RequiredByNativeCode]
		private static void SendEvents(CullingGroup cullingGroup, IntPtr eventsPtr, int count)
		{
		}

		[FreeFunction("CullingGroup_Bindings::Init")]
		private static IntPtr Init(object scripting)
		{
			return (IntPtr)0;
		}

		[FreeFunction("CullingGroup_Bindings::FinalizerFailure", HasExplicitThis = true, IsThreadSafe = true)]
		private void FinalizerFailure()
		{
		}

		private static void DisposeInternal_Injected(IntPtr _unity_self)
		{
		}

		private static void set_targetCamera_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static void SetBoundingSpheres_Injected(IntPtr _unity_self, BoundingSphere[] array)
		{
		}

		private static void SetBoundingSphereCount_Injected(IntPtr _unity_self, int count)
		{
		}

		private static int QueryIndices_Injected(IntPtr _unity_self, bool visible, int distanceIndex, CullingQueryOptions options, ref ManagedSpanWrapper result, int firstIndex)
		{
			return 0;
		}

		private static bool IsVisible_Injected(IntPtr _unity_self, int index)
		{
			return false;
		}

		private static int GetDistance_Injected(IntPtr _unity_self, int index)
		{
			return 0;
		}

		private static void SetBoundingDistances_Injected(IntPtr _unity_self, ref ManagedSpanWrapper distances)
		{
		}

		private static void SetDistanceReferencePoint_InternalVector3_Injected(IntPtr _unity_self, [In] ref Vector3 point)
		{
		}

		private static void SetDistanceReferencePoint_InternalTransform_Injected(IntPtr _unity_self, IntPtr transform)
		{
		}

		private static void FinalizerFailure_Injected(IntPtr _unity_self)
		{
		}
	}
}
