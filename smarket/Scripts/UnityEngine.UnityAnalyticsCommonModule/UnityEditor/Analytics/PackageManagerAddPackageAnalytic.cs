using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEditor.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode(GenerateProxy = true)]
	[ExcludeFromDocs]
	public class PackageManagerAddPackageAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerAddPackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerAddPackageAnalytic CreatePackageManagerAddPackageAnalytic()
		{
			return null;
		}
	}
}
