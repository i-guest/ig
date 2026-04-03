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
	public class SubsystemsAnalyticInfo : SubsystemsAnalyticBase
	{
		private string id;

		private string plugin_name;

		private string version;

		private string library_name;

		public SubsystemsAnalyticInfo()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static SubsystemsAnalyticInfo CreateSubsystemsAnalyticInfo()
		{
			return null;
		}
	}
}
