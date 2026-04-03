using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	[NativeHeader("Modules/Animation/ScriptBindings/AnimatorControllerParameter.bindings.h")]
	[NativeHeader("Modules/Animation/ScriptBindings/Animator.bindings.h")]
	[NativeHeader("Modules/Animation/Animator.h")]
	public class Animator : Behaviour
	{
		public bool isHuman
		{
			[NativeMethod("IsHuman")]
			get
			{
				return false;
			}
		}

		public bool hasRootMotion
		{
			[NativeMethod("HasRootMotion")]
			get
			{
				return false;
			}
		}

		public Vector3 deltaPosition => default(Vector3);

		public bool applyRootMotion
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int layerCount => 0;

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Transform avatarRoot => null;

		public RuntimeAnimatorController runtimeAnimatorController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool hasBoundPlayables
		{
			[NativeMethod("HasBoundPlayables")]
			get
			{
				return false;
			}
		}

		public Avatar avatar
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool logWarnings => false;

		public float GetFloat(string name)
		{
			return 0f;
		}

		public float GetFloat(int id)
		{
			return 0f;
		}

		public void SetFloat(string name, float value)
		{
		}

		public void SetFloat(string name, float value, float dampTime, float deltaTime)
		{
		}

		public void SetFloat(int id, float value)
		{
		}

		public bool GetBool(string name)
		{
			return false;
		}

		public void SetBool(string name, bool value)
		{
		}

		public void SetBool(int id, bool value)
		{
		}

		public int GetInteger(string name)
		{
			return 0;
		}

		public void SetInteger(string name, int value)
		{
		}

		public void SetInteger(int id, int value)
		{
		}

		public void SetTrigger(string name)
		{
		}

		public void SetTrigger(int id)
		{
		}

		public void ResetTrigger(string name)
		{
		}

		public void ResetTrigger(int id)
		{
		}

		public void SetIKPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
		}

		private void SetGoalPosition(AvatarIKGoal goal, Vector3 goalPosition)
		{
		}

		public void SetIKPositionWeight(AvatarIKGoal goal, float value)
		{
		}

		private void SetGoalWeightPosition(AvatarIKGoal goal, float value)
		{
		}

		public void SetLookAtPosition(Vector3 lookAtPosition)
		{
		}

		[NativeMethod("SetLookAtPosition")]
		private void SetLookAtPositionInternal(Vector3 lookAtPosition)
		{
		}

		public void SetLookAtWeight(float weight)
		{
		}

		[NativeMethod("SetLookAtWeight")]
		private void SetLookAtWeightInternal(float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		public int GetLayerIndex(string layerName)
		{
			return 0;
		}

		public float GetLayerWeight(int layerIndex)
		{
			return 0f;
		}

		public void SetLayerWeight(int layerIndex, float weight)
		{
		}

		private void GetAnimatorStateInfo(int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			info = default(AnimatorStateInfo);
		}

		public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		public AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex)
		{
			return default(AnimatorStateInfo);
		}

		public void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetAnimatorClipInfoInternal", HasExplicitThis = true)]
		private void GetAnimatorClipInfoInternal(int layerIndex, bool isCurrent, object clips)
		{
		}

		public void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips)
		{
		}

		public bool IsInTransition(int layerIndex)
		{
			return false;
		}

		public void CrossFade(string stateName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::CrossFade", HasExplicitThis = true)]
		public void CrossFade(int stateHashName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
		{
		}

		public void Play(string stateName)
		{
		}

		public void Play(string stateName, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::Play", HasExplicitThis = true)]
		public void Play(int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		[NativeMethod(Name = "ScriptingStringToCRC32", IsThreadSafe = true)]
		public static int StringToHash(string name)
		{
			return 0;
		}

		private void CheckIfInIKPass()
		{
		}

		private bool IsInIKPass()
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatString", HasExplicitThis = true)]
		private void SetFloatString(string name, float value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatID", HasExplicitThis = true)]
		private void SetFloatID(int id, float value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetFloatString", HasExplicitThis = true)]
		private float GetFloatString(string name)
		{
			return 0f;
		}

		[FreeFunction(Name = "AnimatorBindings::GetFloatID", HasExplicitThis = true)]
		private float GetFloatID(int id)
		{
			return 0f;
		}

		[FreeFunction(Name = "AnimatorBindings::SetBoolString", HasExplicitThis = true)]
		private void SetBoolString(string name, bool value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetBoolID", HasExplicitThis = true)]
		private void SetBoolID(int id, bool value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetBoolString", HasExplicitThis = true)]
		private bool GetBoolString(string name)
		{
			return false;
		}

		[FreeFunction(Name = "AnimatorBindings::SetIntegerString", HasExplicitThis = true)]
		private void SetIntegerString(string name, int value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetIntegerID", HasExplicitThis = true)]
		private void SetIntegerID(int id, int value)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::GetIntegerString", HasExplicitThis = true)]
		private int GetIntegerString(string name)
		{
			return 0;
		}

		[FreeFunction(Name = "AnimatorBindings::SetTriggerString", HasExplicitThis = true)]
		private void SetTriggerString(string name)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetTriggerID", HasExplicitThis = true)]
		private void SetTriggerID(int id)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::ResetTriggerString", HasExplicitThis = true)]
		private void ResetTriggerString(string name)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::ResetTriggerID", HasExplicitThis = true)]
		private void ResetTriggerID(int id)
		{
		}

		[FreeFunction(Name = "AnimatorBindings::SetFloatStringDamp", HasExplicitThis = true)]
		private void SetFloatStringDamp(string name, float value, float dampTime, float deltaTime)
		{
		}

		public void Rebind()
		{
		}

		private void Rebind(bool writeDefaultValues)
		{
		}

		private static bool get_isHuman_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool get_hasRootMotion_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void get_deltaPosition_Injected(IntPtr _unity_self, out Vector3 ret)
		{
			ret = default(Vector3);
		}

		private static bool get_applyRootMotion_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_applyRootMotion_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static void SetGoalPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, [In] ref Vector3 goalPosition)
		{
		}

		private static void SetGoalWeightPosition_Injected(IntPtr _unity_self, AvatarIKGoal goal, float value)
		{
		}

		private static void SetLookAtPositionInternal_Injected(IntPtr _unity_self, [In] ref Vector3 lookAtPosition)
		{
		}

		private static void SetLookAtWeightInternal_Injected(IntPtr _unity_self, float weight, float bodyWeight, float headWeight, float eyesWeight, float clampWeight)
		{
		}

		private static int get_layerCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetLayerIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper layerName)
		{
			return 0;
		}

		private static float GetLayerWeight_Injected(IntPtr _unity_self, int layerIndex)
		{
			return 0f;
		}

		private static void SetLayerWeight_Injected(IntPtr _unity_self, int layerIndex, float weight)
		{
		}

		private static void GetAnimatorStateInfo_Injected(IntPtr _unity_self, int layerIndex, StateInfoIndex stateInfoIndex, out AnimatorStateInfo info)
		{
			info = default(AnimatorStateInfo);
		}

		private static void GetAnimatorClipInfoInternal_Injected(IntPtr _unity_self, int layerIndex, bool isCurrent, object clips)
		{
		}

		private static bool IsInTransition_Injected(IntPtr _unity_self, int layerIndex)
		{
			return false;
		}

		private static float get_speed_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_speed_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void CrossFade_Injected(IntPtr _unity_self, int stateHashName, float normalizedTransitionDuration, [DefaultValue("-1")] int layer, [DefaultValue("0.0f")] float normalizedTimeOffset, [DefaultValue("0.0f")] float normalizedTransitionTime)
		{
		}

		private static void Play_Injected(IntPtr _unity_self, int stateNameHash, [DefaultValue("-1")] int layer, [DefaultValue("float.NegativeInfinity")] float normalizedTime)
		{
		}

		private static IntPtr get_avatarRoot_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static IntPtr get_runtimeAnimatorController_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_runtimeAnimatorController_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool get_hasBoundPlayables_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static int StringToHash_Injected(ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static IntPtr get_avatar_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_avatar_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static bool IsInIKPass_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void SetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value)
		{
		}

		private static void SetFloatID_Injected(IntPtr _unity_self, int id, float value)
		{
		}

		private static float GetFloatString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return 0f;
		}

		private static float GetFloatID_Injected(IntPtr _unity_self, int id)
		{
			return 0f;
		}

		private static void SetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, bool value)
		{
		}

		private static void SetBoolID_Injected(IntPtr _unity_self, int id, bool value)
		{
		}

		private static bool GetBoolString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return false;
		}

		private static void SetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, int value)
		{
		}

		private static void SetIntegerID_Injected(IntPtr _unity_self, int id, int value)
		{
		}

		private static int GetIntegerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return 0;
		}

		private static void SetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}

		private static void SetTriggerID_Injected(IntPtr _unity_self, int id)
		{
		}

		private static void ResetTriggerString_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
		}

		private static void ResetTriggerID_Injected(IntPtr _unity_self, int id)
		{
		}

		private static void SetFloatStringDamp_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, float value, float dampTime, float deltaTime)
		{
		}

		private static void Rebind_Injected(IntPtr _unity_self, bool writeDefaultValues)
		{
		}

		private static bool get_logWarnings_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
}
