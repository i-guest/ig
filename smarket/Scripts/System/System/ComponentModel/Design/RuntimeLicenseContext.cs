using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace System.ComponentModel.Design
{
	internal class RuntimeLicenseContext : LicenseContext
	{
		private static TraceSwitch s_runtimeLicenseContextSwitch;

		internal Hashtable savedLicenseKeys;

		private string GetLocalPath(string fileName)
		{
			return null;
		}

		public override string GetSavedLicenseKey(Type type, Assembly resourceAssembly)
		{
			return null;
		}

		private Stream CaseInsensitiveManifestResourceStreamLookup(Assembly satellite, string name)
		{
			return null;
		}
	}
}
