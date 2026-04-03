using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	internal ref struct HashFNV1A32
	{
		private const uint k_Prime = 16777619u;

		private const uint k_OffsetBasis = 2166136261u;

		private uint m_Hash;

		public int value => 0;

		public static HashFNV1A32 Create()
		{
			return default(HashFNV1A32);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in int input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in uint input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in bool input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in float input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in double input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in Vector2 input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in Vector3 input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append(in Vector4 input)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void Append<T>(T input) where T : struct
		{
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
