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
	public class PackageManagerTestAnalytic : PackageManagerBaseAnalytic
	{
		public PackageManagerTestAnalytic()
			: base(null)
		{
		}

		[RequiredByNativeCode]
		internal static PackageManagerTestAnalytic CreatePackageManagerTestAnalytic()
		{
			return null;
		}
	}
}
