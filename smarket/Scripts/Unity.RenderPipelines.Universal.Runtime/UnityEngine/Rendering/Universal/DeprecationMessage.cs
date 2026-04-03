using System.Runtime.InteropServices;

namespace UnityEngine.Rendering.Universal
{
	[StructLayout((LayoutKind)0, Size = 1)]
	internal struct DeprecationMessage
	{
		internal const string CompatibilityScriptingAPIObsolete = "This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead.";

		internal const string CompatibilityScriptingAPIObsoleteFrom2023_3 = "This rendering path is for compatibility mode only (when Render Graph is disabled). Use Render Graph API instead. #from(2023.3)";

		internal const string CompatibilityScriptingAPIConsoleWarning = "Your project uses Compatibility Mode, which disables the render graph system. Compatibility Mode is deprecated. Migrate your ScriptableRenderPasses to the Render Graph API instead. After you migrate, go to Edit > Project Settings > Player and remove the URP_COMPATIBILITY_MODE define from the Scripting Define Symbols. If you don't remove the define, build time and build size are slightly increased.";
	}
}
