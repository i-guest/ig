using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Internal;

namespace UnityEngine
{
	[NativeHeader("Runtime/Export/Gizmos/Gizmos.bindings.h")]
	[StaticAccessor("GizmoBindings", StaticAccessorType.DoubleColon)]
	public sealed class Gizmos
	{
		public static Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static Matrix4x4 matrix
		{
			set
			{
			}
		}

		[NativeThrows]
		public static void DrawLine(Vector3 from, Vector3 to)
		{
		}

		[NativeThrows]
		public static void DrawWireSphere(Vector3 center, float radius)
		{
		}

		[NativeThrows]
		public static void DrawSphere(Vector3 center, float radius)
		{
		}

		[NativeThrows]
		public static void DrawWireCube(Vector3 center, Vector3 size)
		{
		}

		[NativeThrows]
		public static void DrawCube(Vector3 center, Vector3 size)
		{
		}

		[NativeThrows]
		public static void DrawIcon(Vector3 center, string name, [DefaultValue("true")] bool allowScaling, [DefaultValue("Color(255,255,255,255)")] Color tint)
		{
		}

		public static void DrawFrustum(Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
		}

		private static void DrawLine_Injected([In] ref Vector3 from, [In] ref Vector3 to)
		{
		}

		private static void DrawWireSphere_Injected([In] ref Vector3 center, float radius)
		{
		}

		private static void DrawSphere_Injected([In] ref Vector3 center, float radius)
		{
		}

		private static void DrawWireCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
		{
		}

		private static void DrawCube_Injected([In] ref Vector3 center, [In] ref Vector3 size)
		{
		}

		private static void DrawIcon_Injected([In] ref Vector3 center, ref ManagedSpanWrapper name, [DefaultValue("true")] bool allowScaling, [In][DefaultValue("Color(255,255,255,255)")] ref Color tint)
		{
		}

		private static void get_color_Injected(out Color ret)
		{
			ret = default(Color);
		}

		private static void set_color_Injected([In] ref Color value)
		{
		}

		private static void set_matrix_Injected([In] ref Matrix4x4 value)
		{
		}

		private static void DrawFrustum_Injected([In] ref Vector3 center, float fov, float maxRange, float minRange, float aspect)
		{
		}
	}
}
