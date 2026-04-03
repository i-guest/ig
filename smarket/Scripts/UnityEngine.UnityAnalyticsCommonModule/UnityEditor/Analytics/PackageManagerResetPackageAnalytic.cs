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
	public class PackageManagerResetPackageAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerResetPackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerResetPackageAnalytic CreatePackageManagerResetPackageAnalytic()
		{
			return null;
		}
	}
}
