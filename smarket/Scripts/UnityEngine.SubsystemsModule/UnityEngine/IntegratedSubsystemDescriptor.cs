using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode("SubsystemDescriptorBase")]
	public abstract class IntegratedSubsystemDescriptor : ISubsystemDescriptor
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.XRModule" })]
		internal IntPtr m_Ptr;

		public string id => null;
	}
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode("SubsystemDescriptor")]
	[NativeHeader("Modules/Subsystems/SubsystemDescriptor.h")]
	public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor
	{
	}
}
