using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.XR
{
	[StaticAccessor("XRInputDevices::Get()", StaticAccessorType.Dot)]
	[NativeHeader("Modules/XR/Subsystems/Input/Public/XRInputDevices.h")]
	[NativeHeader("Modules/XR/XRPrefix.h")]
	[NativeHeader("XRScriptingClasses.h")]
	[NativeConditional("ENABLE_VR")]
	[RequiredByNativeCode]
	public struct Hand : IEquatable<Hand>
	{
		private ulong m_DeviceId;

		private uint m_FeatureIndex;

		internal ulong deviceId => 0uL;

		internal uint featureIndex => 0u;

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Hand other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
