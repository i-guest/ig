using System;
using System.Runtime.InteropServices;
using UnityEngine.Analytics;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class MetalPatchShaderComputeBufferAnalytic : AnalyticsEventBase
	{
		public MetalPatchShaderComputeBufferAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static MetalPatchShaderComputeBufferAnalytic CreateMetalPatchShaderComputeBufferAnalytic()
		{
			return null;
		}
	}
}
