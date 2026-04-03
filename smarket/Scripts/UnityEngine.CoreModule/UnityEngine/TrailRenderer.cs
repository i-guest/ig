using System;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/TrailRenderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class TrailRenderer : Renderer
	{
		public float time
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float startWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float endWidth
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void Clear()
		{
		}

		private static float get_time_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_time_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_startWidth_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_startWidth_Injected(IntPtr _unity_self, float value)
		{
		}

		private static float get_endWidth_Injected(IntPtr _unity_self)
		{
			return 0f;
		}

		private static void set_endWidth_Injected(IntPtr _unity_self, float value)
		{
		}

		private static void Clear_Injected(IntPtr _unity_self)
		{
		}
	}
}
