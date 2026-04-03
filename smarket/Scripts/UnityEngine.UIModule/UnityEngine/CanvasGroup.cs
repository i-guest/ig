using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Modules/UI/CanvasGroup.h")]
	[NativeClass("UI::CanvasGroup")]
	public sealed class CanvasGroup : Behaviour, ICanvasRaycastFilter
	{
		[NativeProperty("Alpha", false, TargetType.Function)]
		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[NativeProperty("Interactable", false, TargetType.Function)]
		public bool interactable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("BlocksRaycasts", false, TargetType.Function)]
		public bool blocksRaycasts
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[NativeProperty("IgnoreParentGroups", false, TargetType.Function)]
		public bool ignoreParentGroups
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsRaycastLocationValid(Vector2 sp, Camera eventCamera)
		{
			return false;
		}

		private static float get_alpha_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_alpha_Injected(IntPtr _unity_self, float value)
		{
		}

		private static bool get_interactable_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_interactable_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_blocksRaycasts_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_blocksRaycasts_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_ignoreParentGroups_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_ignoreParentGroups_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
