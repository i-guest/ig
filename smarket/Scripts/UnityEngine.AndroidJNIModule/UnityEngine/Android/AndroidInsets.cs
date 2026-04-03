using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Android
{
	[NativeHeader("Modules/AndroidJNI/Public/AndroidInsets.bindings.h")]
	[StaticAccessor("AndroidInsets", StaticAccessorType.DoubleColon)]
	[RequiredByNativeCode]
	internal class AndroidInsets
	{
		private IntPtr m_NativeHandle;

		[RequiredByNativeCode(GenerateProxy = true)]
		private void SetNativeHandle(IntPtr ptr)
		{
		}
	}
}
