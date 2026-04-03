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
	public class PackageManagerRemovePackageAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerRemovePackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerRemovePackageAnalytic CreatePackageManagerRemovePackageAnalytic()
		{
			return null;
		}
	}
}
