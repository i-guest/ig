using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	public class PackageManagerResolveErrorPackageAnalytic : PackageManagerBaseAnalytic
	{
		public string reason;

		public string action;

		public PackageManagerResolveErrorPackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerResolveErrorPackageAnalytic CreatePackageManagerResolveErrorPackageAnalytic()
		{
			return null;
		}
	}
}
