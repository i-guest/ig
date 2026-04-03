using System;

namespace UnityEngine.Rendering
{
	public static class RenderGraphGraphicsAutomatedTests
	{
		private static bool activatedFromCommandLine => false;

		[Obsolete]
		public static bool enabled { get; set; }

		public static bool? forceRenderGraphState { get; set; }
	}
}
