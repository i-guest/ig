using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
	public class SkinnedMeshRenderer : Renderer
	{
		public SkinQuality quality
		{
			get
			{
				return default(SkinQuality);
			}
			set
			{
			}
		}

		public bool updateWhenOffscreen
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Transform rootBone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Transform[] bones
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("Mesh")]
		public Mesh sharedMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[NativeProperty("SkinnedMeshMotionVectors")]
		public bool skinnedMotionVectors
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float GetBlendShapeWeight(int index)
		{
			return 0f;
		}

		public void SetBlendShapeWeight(int index, float value)
		{
		}

		private static SkinQuality get_quality_Injected(IntPtr _unity_self)
		{
			return default(SkinQuality);
		}

		private static void set_quality_Injected(IntPtr _unity_self, SkinQuality value)
		{
		}

		private static bool get_updateWhenOffscreen_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static IntPtr get_rootBone_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_rootBone_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static Transform[] get_bones_Injected(IntPtr _unity_self)
		{
			return null;
		}

		private static void set_bones_Injected(IntPtr _unity_self, Transform[] value)
		{
		}

		private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool get_skinnedMotionVectors_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_skinnedMotionVectors_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static float GetBlendShapeWeight_Injected(IntPtr _unity_self, int index)
		{
			return 0f;
		}

		private static void SetBlendShapeWeight_Injected(IntPtr _unity_self, int index, float value)
		{
		}
	}
}
