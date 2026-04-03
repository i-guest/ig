using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;

namespace UnityEngine
{
	[NativeHeader("Runtime/Graphics/LineRenderer.h")]
	[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
	public sealed class LineRenderer : Renderer
	{
		public Color startColor
		{
			set
			{
			}
		}

		public Color endColor
		{
			set
			{
			}
		}

		[NativeProperty("PositionsCount")]
		public int positionCount
		{
			set
			{
			}
		}

		public void SetPosition(int index, Vector3 position)
		{
		}

		public void Simplify(float tolerance)
		{
		}

		private static void set_startColor_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static void set_endColor_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static void set_positionCount_Injected(IntPtr _unity_self, int value)
		{
		}

		private static void SetPosition_Injected(IntPtr _unity_self, int index, [In] ref Vector3 position)
		{
		}

		private static void Simplify_Injected(IntPtr _unity_self, float tolerance)
		{
		}
	}
}
