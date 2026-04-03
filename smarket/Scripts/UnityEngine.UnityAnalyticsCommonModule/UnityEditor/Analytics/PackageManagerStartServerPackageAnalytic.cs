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
	public class PackageManagerStartServerPackageAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerStartServerPackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerStartServerPackageAnalytic CreatePackageManagerStartServerPackageAnalytic()
		{
			return null;
		}
	}
}
