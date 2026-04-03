using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[StructLayout((LayoutKind)0)]
	[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
	[RequiredByNativeCode]
	public class VFXExpressionValues
	{
		internal IntPtr m_Ptr;

		private VFXExpressionValues()
		{
		}

		[RequiredByNativeCode]
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr)
		{
			return null;
		}
	}
}
