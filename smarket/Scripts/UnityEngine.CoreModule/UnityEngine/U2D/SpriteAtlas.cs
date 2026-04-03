using System;
using UnityEngine.Bindings;

namespace UnityEngine.U2D
{
	[NativeType(Header = "Runtime/2D/SpriteAtlas/SpriteAtlas.h")]
	[NativeHeader("Runtime/Graphics/SpriteFrame.h")]
	public class SpriteAtlas : Object
	{
		public bool CanBindTo([NotNull] Sprite sprite)
		{
			return false;
		}

		public Sprite GetSprite(string name)
		{
			return null;
		}

		private static bool CanBindTo_Injected(IntPtr _unity_self, IntPtr sprite)
		{
			return false;
		}

		private static IntPtr GetSprite_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name)
		{
			return (IntPtr)0;
		}
	}
}
