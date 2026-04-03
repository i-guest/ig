using System;

namespace Unity.XGamingRuntime.Interop
{
	internal struct XPackageFeature
	{
		internal string id;

		internal string displayName;

		internal string tags;

		internal bool hidden;

		internal uint storeIdCount;

		internal IntPtr storeIds;
	}
}
