using System;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct GeometryPoolHandle : IEquatable<GeometryPoolHandle>
	{
		public int index;

		public static readonly GeometryPoolHandle Invalid;

		public readonly bool valid => false;

		public bool Equals(GeometryPoolHandle other)
		{
			return false;
		}
	}
}
