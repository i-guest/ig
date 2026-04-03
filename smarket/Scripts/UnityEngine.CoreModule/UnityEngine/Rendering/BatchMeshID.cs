using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode(Optional = true, GenerateProxy = true)]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	[NativeClass("BatchMeshID")]
	public struct BatchMeshID : IEquatable<BatchMeshID>
	{
		public static readonly BatchMeshID Null;

		public uint value;

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(BatchMeshID other)
		{
			return false;
		}

		public static bool operator ==(BatchMeshID a, BatchMeshID b)
		{
			return false;
		}
	}
}
