using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequireComponent(typeof(Transform))]
	[NativeType("Runtime/Graphics/Mesh/SpriteRenderer.h")]
	public sealed class SpriteRenderer : Renderer
	{
		private UnityEvent<SpriteRenderer> m_SpriteChangeEvent;

		internal bool hasSpriteChangeEvents
		{
			set
			{
			}
		}

		public Sprite sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SpriteDrawMode drawMode => default(SpriteDrawMode);

		public Vector2 size => default(Vector2);

		public Color color
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public bool flipX
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool flipY
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void RegisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
		{
		}

		public void UnregisterSpriteChangeCallback(UnityAction<SpriteRenderer> callback)
		{
		}

		[RequiredByNativeCode]
		private void InvokeSpriteChanged()
		{
		}

		private static void set_hasSpriteChangeEvents_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static IntPtr get_sprite_Injected(IntPtr _unity_self)
		{
			return (IntPtr)0;
		}

		private static void set_sprite_Injected(IntPtr _unity_self, IntPtr value)
		{
		}

		private static SpriteDrawMode get_drawMode_Injected(IntPtr _unity_self)
		{
			return default(SpriteDrawMode);
		}

		private static void get_size_Injected(IntPtr _unity_self, out Vector2 ret)
		{
			ret = default(Vector2);
		}

		private static void get_color_Injected(IntPtr _unity_self, out Color ret)
		{
			ret = default(Color);
		}

		private static void set_color_Injected(IntPtr _unity_self, [In] ref Color value)
		{
		}

		private static bool get_flipX_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_flipX_Injected(IntPtr _unity_self, bool value)
		{
		}

		private static bool get_flipY_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static void set_flipY_Injected(IntPtr _unity_self, bool value)
		{
		}
	}
}
