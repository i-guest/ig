using System.Diagnostics;

namespace System.ComponentModel
{
	internal static class CompModSwitches
	{
		private static BooleanSwitch commonDesignerServices;

		private static TraceSwitch eventLog;

		public static BooleanSwitch CommonDesignerServices => null;

		public static TraceSwitch EventLog => null;
	}
}
