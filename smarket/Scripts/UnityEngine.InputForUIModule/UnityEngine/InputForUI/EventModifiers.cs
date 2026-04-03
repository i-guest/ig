using System;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal struct EventModifiers
	{
		[Flags]
		public enum Modifiers : uint
		{
			LeftShift = 1u,
			RightShift = 2u,
			Shift = 3u,
			LeftCtrl = 4u,
			RightCtrl = 8u,
			Ctrl = 0xCu,
			LeftAlt = 0x10u,
			RightAlt = 0x20u,
			Alt = 0x30u,
			LeftMeta = 0x40u,
			RightMeta = 0x80u,
			Meta = 0xC0u,
			CapsLock = 0x100u,
			Numlock = 0x200u,
			FunctionKey = 0x400u,
			Numeric = 0x800u
		}

		private uint _state;

		public bool isShiftPressed => false;

		public bool isCtrlPressed => false;

		public bool isAltPressed => false;

		public bool isMetaPressed => false;

		public bool isCapsLockEnabled => false;

		public bool isFunctionKeyPressed => false;

		public bool isNumericPressed => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public bool IsPressed(Modifiers mod)
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetPressed(Modifiers modifier, bool pressed)
		{
		}

		public void Reset()
		{
		}

		private static void Append(ref string str, string value)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
