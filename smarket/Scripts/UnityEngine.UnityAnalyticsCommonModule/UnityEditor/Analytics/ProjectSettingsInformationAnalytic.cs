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
	public class ProjectSettingsInformationAnalytic : AnalyticsEventBase
	{
		private int agent_types_count;

		private int areas_count;

		public ProjectSettingsInformationAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		internal static ProjectSettingsInformationAnalytic CreateProjectSettingsInformationAnalytic()
		{
			return null;
		}
	}
}
