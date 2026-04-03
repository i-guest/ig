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
	public class PackageManagerEmbedPackageAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerEmbedPackageAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerEmbedPackageAnalytic CreatePackageManagerEmbedPackageAnalytic()
		{
			return null;
		}
	}
}
