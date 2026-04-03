using System;
using System.Collections;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeHeader("Configuration/UnityConfigure.h")]
	[NativeHeader("Runtime/Transform/Transform.h")]
	[NativeHeader("Runtime/Transform/ScriptBindings/TransformScriptBindings.h")]
	public class Transform : Component, IEnumerable
	{
		private class Enumerator : IEnumerator
		{
			private Transform outer;

			private int currentIndex;

			public object Current => null;

			internal Enumerator(Transform outer)
			{
			}

			public bool MoveNext()
			{
				return false;
			}

			public void Reset()
			{
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localPosition
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 eulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 localEulerAngles
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Vector3 right => default(Vector3);

		public Vector3 up => default(Vector3);

		public Vector3 forward
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Quaternion rotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Quaternion localRotation
		{
			get
			{
				return default(Quaternion);
			}
			set
			{
			}
		}

		public Vector3 localScale
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Transform parent
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		internal Transform parentInternal
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Matrix4x4 worldToLocalMatrix => default(Matrix4x4);

		public Matrix4x4 localToWorldMatrix => default(Matrix4x4);

		public int childCount
		{
			[NativeMethod("GetChildrenCount")]
			get
			{
				return 0;
			}
		}

		public Vector3 lossyScale
		{
			[NativeMethod("GetWorldScaleLossy")]
			get
			{
				return default(Vector3);
			}
		}

		[NativeProperty("HasChangedDeprecated")]
		public bool hasChanged
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int hierarchyCapacity
		{
			set
			{
			}
		}

		protected Transform()
		{
		}

		private Transform GetParent()
		{
			return null;
		}

		public void SetParent(Transform p)
		{
		}

		[FreeFunction("SetParent", HasExplicitThis = true)]
		public void SetParent(Transform parent, bool worldPositionStays)
		{
		}

		public void SetPositionAndRotation(Vector3 position, Quaternion rotation)
		{
		}

		public void SetLocalPositionAndRotation(Vector3 localPosition, Quaternion localRotation)
		{
		}

		public void GetPositionAndRotation(out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		public void Translate(Vector3 translation, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		public void Translate(Vector3 translation)
		{
		}

		public void Rotate(Vector3 eulers, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		public void Rotate(Vector3 eulers)
		{
		}

		public void Rotate(float xAngle, float yAngle, float zAngle, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		public void Rotate(float xAngle, float yAngle, float zAngle)
		{
		}

		[NativeMethod("RotateAround")]
		internal void RotateAroundInternal(Vector3 axis, float angle)
		{
		}

		public void Rotate(Vector3 axis, float angle, [DefaultValue("Space.Self")] Space relativeTo)
		{
		}

		public void LookAt(Transform target, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
		}

		public void LookAt(Transform target)
		{
		}

		public void LookAt(Vector3 worldPosition, [DefaultValue("Vector3.up")] Vector3 worldUp)
		{
		}

		public void LookAt(Vector3 worldPosition)
		{
		}

		[FreeFunction("Internal_LookAt", HasExplicitThis = true)]
		private void Internal_LookAt(Vector3 worldPosition, Vector3 worldUp)
		{
		}

		public Vector3 TransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformDirection(Vector3 direction)
		{
			return default(Vector3);
		}

		public Vector3 TransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformVector(Vector3 vector)
		{
			return default(Vector3);
		}

		public Vector3 TransformPoint(Vector3 position)
		{
			return default(Vector3);
		}

		public Vector3 TransformPoint(float x, float y, float z)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransformPoint(Vector3 position)
		{
			return default(Vector3);
		}

		[FreeFunction("DetachChildren", HasExplicitThis = true)]
		public void DetachChildren()
		{
		}

		public void SetAsFirstSibling()
		{
		}

		public void SetSiblingIndex(int index)
		{
		}

		public int GetSiblingIndex()
		{
			return 0;
		}

		[FreeFunction(HasExplicitThis = true)]
		private Transform FindRelativeTransformWithPath(string path, [DefaultValue("false")] bool isActiveOnly)
		{
			return null;
		}

		public Transform Find(string n)
		{
			return null;
		}

		[FreeFunction("Internal_IsChildOrSameAsOtherTransform", HasExplicitThis = true)]
		public bool IsChildOf([NotNull] Transform parent)
		{
			return false;
		}

		public IEnumerator GetEnumerator()
		{
			return null;
		}

		[NativeThrows]
		[FreeFunction("GetChild", HasExplicitThis = true)]
		public Transform GetChild(int index)
		{
			return null;
		}

		[FreeFunction("SetHierarchyCapacity", HasExplicitThis = true)]
		private void internal_setHierarchyCapacity(int value)
		{
		}

		private static void get_position_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_position_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_localPosition_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_localPosition_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static void get_rotation_Injected(IntPtr _unity_self, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void set_rotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
		{
		}

		private static void get_localRotation_Injected(IntPtr _unity_self, out Quaternion ret)
		{
			ret = default(Quaternion);
		}

		private static void set_localRotation_Injected(IntPtr _unity_self, [In] ref Quaternion value)
		{
		}

		private static void get_localScale_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void set_localScale_Injected(IntPtr _unity_self, [In] ref Vector3 value)
		{
		}

		private static IntPtr GetParent_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void SetParent_Injected(IntPtr _unity_self, IntPtr parent, bool worldPositionStays)
		{
		}

		private static void get_worldToLocalMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void get_localToWorldMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret)
		{
			ret = default(Matrix4x4);
		}

		private static void SetPositionAndRotation_Injected(IntPtr _unity_self, [In] ref Vector3 position, [In] ref Quaternion rotation)
		{
		}

		private static void SetLocalPositionAndRotation_Injected(IntPtr _unity_self, [In] ref Vector3 localPosition, [In] ref Quaternion localRotation)
		{
		}

		private static void GetPositionAndRotation_Injected(IntPtr _unity_self, out Vector3 position, out Quaternion rotation)
		{
			position = default(Vector3);
			rotation = default(Quaternion);
		}

		private static void RotateAroundInternal_Injected(IntPtr _unity_self, [In] ref Vector3 axis, float angle)
		{
		}

		private static void Internal_LookAt_Injected(IntPtr _unity_self, [In] ref Vector3 worldPosition, [In] ref Vector3 worldUp)
		{
		}

		private static void TransformDirection_Injected(IntPtr _unity_self, [In] ref Vector3 direction, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void InverseTransformDirection_Injected(IntPtr _unity_self, [In] ref Vector3 direction, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void TransformVector_Injected(IntPtr _unity_self, [In] ref Vector3 vector, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void InverseTransformVector_Injected(IntPtr _unity_self, [In] ref Vector3 vector, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void TransformPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static void InverseTransformPoint_Injected(IntPtr _unity_self, [In] ref Vector3 position, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static int get_childCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static void DetachChildren_Injected(IntPtr _unity_self)
		{
		}

		private static void SetAsFirstSibling_Injected(IntPtr _unity_self)
		{
		}

		private static void SetSiblingIndex_Injected(IntPtr _unity_self, int index)
		{
		}

		private static int GetSiblingIndex_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static IntPtr FindRelativeTransformWithPath_Injected(IntPtr _unity_self, ref ManagedSpanWrapper path, [DefaultValue("false")] bool isActiveOnly)
		{
			return (IntPtr)0;
		}

		private static void get_lossyScale_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static bool IsChildOf_Injected(IntPtr _unity_self, IntPtr parent)
		{
			return false;
		}

		private static bool get_hasChanged_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_hasChanged_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static IntPtr GetChild_Injected(IntPtr _unity_self, int index)
		{
			return (IntPtr)0;
		}

		private static void internal_setHierarchyCapacity_Injected(IntPtr _unity_self, int value)
		{
		}
	}
}
