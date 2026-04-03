using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Runtime/Export/Math/Gradient.bindings.h")]
	public class Gradient : IEquatable<Gradient>
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(Gradient graident)
			{
				return (IntPtr)0;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule" })]
		internal IntPtr m_Ptr;

		private bool m_RequiresNativeCleanup;

		public GradientColorKey[] colorKeys
		{
			[FreeFunction("Gradient_Bindings::GetColorKeysArray", IsThreadSafe = true, HasExplicitThis = true)]
			get
			{
				return null;
			}
			[FreeFunction("Gradient_Bindings::SetColorKeysWithSpan", IsThreadSafe = true, HasExplicitThis = true)]
			set
			{
			}
		}

		public GradientAlphaKey[] alphaKeys
		{
			[FreeFunction("Gradient_Bindings::GetAlphaKeysArray", IsThreadSafe = true, HasExplicitThis = true)]
			get
			{
				return null;
			}
			[FreeFunction("Gradient_Bindings::SetAlphaKeysWithSpan", IsThreadSafe = true, HasExplicitThis = true)]
			set
			{
			}
		}

		[NativeProperty(IsThreadSafe = true)]
		public GradientMode mode
		{
			get
			{
				return default(GradientMode);
			}
			set
			{
			}
		}

		[NativeProperty(IsThreadSafe = true)]
		public ColorSpace colorSpace
		{
			get
			{
				return default(ColorSpace);
			}
			set
			{
			}
		}

		[FreeFunction(Name = "Gradient_Bindings::Init", IsThreadSafe = true)]
		private static IntPtr Init()
		{
			return (IntPtr)0;
		}

		[FreeFunction(Name = "Gradient_Bindings::Cleanup", IsThreadSafe = true, HasExplicitThis = true)]
		private void Cleanup()
		{
		}

		[FreeFunction("Gradient_Bindings::Internal_Equals", IsThreadSafe = true, HasExplicitThis = true)]
		private bool Internal_Equals(IntPtr other)
		{
			return false;
		}

		[RequiredByNativeCode]
		public Gradient()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.ParticleSystemModule" })]
		internal Gradient(IntPtr ptr)
		{
		}

		~Gradient()
		{
		}

		[FreeFunction(Name = "Gradient_Bindings::Evaluate", IsThreadSafe = true, HasExplicitThis = true)]
		public Color Evaluate(float time)
		{
			return default(Color);
		}

		public void SetKeys(GradientColorKey[] colorKeys, GradientAlphaKey[] alphaKeys)
		{
		}

		[FreeFunction(Name = "Gradient_Bindings::SetKeysWithSpans", HasExplicitThis = true, IsThreadSafe = true)]
		public void SetKeys(ReadOnlySpan<GradientColorKey> colorKeys, ReadOnlySpan<GradientAlphaKey> alphaKeys)
		{
		}

		public override bool Equals(object o)
		{
			return false;
		}

		public bool Equals(Gradient other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		private static void Cleanup_Injected(IntPtr _unity_self)
		{
		}

		private static bool Internal_Equals_Injected(IntPtr _unity_self, IntPtr other)
		{
			return false;
		}

		private static void Evaluate_Injected(IntPtr _unity_self, float time, out Color ret)
		{
			ret = default(Color);
		}

		private static void get_colorKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void set_colorKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static void get_alphaKeys_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static void set_alphaKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value)
		{
		}

		private static GradientMode get_mode_Injected(IntPtr _unity_self)
		{
			return default(GradientMode);
		}

		private static void set_mode_Injected(IntPtr _unity_self, GradientMode value)
		{
		}

		private static ColorSpace get_colorSpace_Injected(IntPtr _unity_self)
		{
			return default(ColorSpace);
		}

		private static void set_colorSpace_Injected(IntPtr _unity_self, ColorSpace value)
		{
		}

		private static void SetKeys_Injected(IntPtr _unity_self, ref ManagedSpanWrapper colorKeys, ref ManagedSpanWrapper alphaKeys)
		{
		}
	}
}
