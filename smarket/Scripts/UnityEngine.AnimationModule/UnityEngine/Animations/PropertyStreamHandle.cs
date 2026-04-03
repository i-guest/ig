using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Animations
{
	[NativeHeader("Modules/Animation/Director/AnimationStreamHandles.h")]
	[MovedFrom("UnityEngine.Experimental.Animations")]
	public struct PropertyStreamHandle
	{
		private uint m_AnimatorBindingsVersion;

		private int handleIndex;

		private int valueArrayIndex;

		private int bindType;

		private bool createdByNative => false;

		private bool hasHandleIndex => false;

		private bool hasValueArrayIndex => false;

		private bool hasBindType => false;

		internal uint animatorBindingsVersion => 0u;

		private bool IsValidInternal(ref AnimationStream stream)
		{
			return false;
		}

		private bool IsSameVersionAsStream(ref AnimationStream stream)
		{
			return false;
		}

		private bool IsResolvedInternal(ref AnimationStream stream)
		{
			return false;
		}

		private void CheckIsValidAndResolve(ref AnimationStream stream)
		{
		}

		public float GetFloat(AnimationStream stream)
		{
			return 0f;
		}

		public void SetFloat(AnimationStream stream, float value)
		{
		}

		public int GetInt(AnimationStream stream)
		{
			return 0;
		}

		public void SetInt(AnimationStream stream, int value)
		{
		}

		public EntityId GetEntityId(AnimationStream stream)
		{
			return default(EntityId);
		}

		public void SetEntityId(AnimationStream stream, EntityId value)
		{
		}

		public bool GetBool(AnimationStream stream)
		{
			return false;
		}

		public void SetBool(AnimationStream stream, bool value)
		{
		}

		[NativeMethod(Name = "Resolve", IsThreadSafe = true)]
		private void ResolveInternal(ref AnimationStream stream)
		{
		}

		[NativeMethod(Name = "GetFloat", IsThreadSafe = true)]
		private float GetFloatInternal(ref AnimationStream stream)
		{
			return 0f;
		}

		[NativeMethod(Name = "SetFloat", IsThreadSafe = true)]
		private void SetFloatInternal(ref AnimationStream stream, float value)
		{
		}

		[NativeMethod(Name = "GetInt", IsThreadSafe = true)]
		private int GetIntInternal(ref AnimationStream stream)
		{
			return 0;
		}

		[NativeMethod(Name = "SetInt", IsThreadSafe = true)]
		private void SetIntInternal(ref AnimationStream stream, int value)
		{
		}

		[NativeMethod(Name = "GetEntityId", IsThreadSafe = true)]
		private EntityId GetEntityIdInternal(ref AnimationStream stream)
		{
			return default(EntityId);
		}

		[NativeMethod(Name = "SetEntityId", IsThreadSafe = true)]
		private void SetEntityIdInternal(ref AnimationStream stream, EntityId value)
		{
		}

		[NativeMethod(Name = "GetBool", IsThreadSafe = true)]
		private bool GetBoolInternal(ref AnimationStream stream)
		{
			return false;
		}

		[NativeMethod(Name = "SetBool", IsThreadSafe = true)]
		private void SetBoolInternal(ref AnimationStream stream, bool value)
		{
		}

		private static void GetEntityIdInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, out EntityId ret)
		{
			ret = default(EntityId);
		}

		private static void SetEntityIdInternal_Injected(ref PropertyStreamHandle _unity_self, ref AnimationStream stream, [In] ref EntityId value)
		{
		}
	}
}
