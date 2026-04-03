using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	[ExcludeFromDocs]
	public class SubsystemsAnalyticStart : SubsystemsAnalyticBase
	{
		public SubsystemsAnalyticStart()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static SubsystemsAnalyticStart CreateSubsystemsAnalyticStart()
		{
			return null;
		}
	}
}
