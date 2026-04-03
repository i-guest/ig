using System;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[StructLayout((LayoutKind)0)]
	[UsedByNativeCode]
	[NativeHeader("Modules/Subsystems/Subsystem.h")]
	public class IntegratedSubsystem : ISubsystem
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToNative(IntegratedSubsystem integratedSubsystem)
			{
				return (IntPtr)0;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.XRModule" })]
		internal IntPtr m_Ptr;

		internal ISubsystemDescriptor m_SubsystemDescriptor;

		public bool running => false;

		internal bool valid => false;

		internal void SetHandle([UnityMarshalAs(NativeType.ScriptingObjectPtr)] IntegratedSubsystem subsystem)
		{
		}

		internal bool IsRunning()
		{
			return false;
		}

		private static void SetHandle_Injected(IntPtr _unity_self, IntegratedSubsystem subsystem)
		{
		}

		private static bool IsRunning_Injected(IntPtr _unity_self)
		{
			return false;
		}
	}
	[UsedByNativeCode("Subsystem_TSubsystemDescriptor")]
	public class IntegratedSubsystem<TSubsystemDescriptor> : IntegratedSubsystem
	{
	}
}
