using System;
using UnityEngine.Bindings;

namespace Unity.Scripting.LifecycleManagement
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event, AllowMultiple = true)]
	[VisibleToOtherModules]
	internal sealed class AutoStaticsCleanupOnCodeReloadAttribute : Attribute
	{
	}
}
