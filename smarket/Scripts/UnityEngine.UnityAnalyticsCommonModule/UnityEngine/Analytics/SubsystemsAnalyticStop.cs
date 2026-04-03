using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class SubsystemsAnalyticStop : SubsystemsAnalyticBase
	{
		public SubsystemsAnalyticStop()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static SubsystemsAnalyticStop CreateSubsystemsAnalyticStop()
		{
			return null;
		}
	}
}
