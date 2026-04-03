using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct AffineTransform
	{
		public Vector3 translation;

		public Quaternion rotation;

		public static AffineTransform identity { get; }

		public AffineTransform(Vector3 t, Quaternion r)
		{
			translation = default(Vector3);
			rotation = default(Quaternion);
		}

		public void Set(Vector3 t, Quaternion r)
		{
		}

		public Vector3 Transform(Vector3 p)
		{
			return default(Vector3);
		}

		public Vector3 InverseTransform(Vector3 p)
		{
			return default(Vector3);
		}

		public AffineTransform Inverse()
		{
			return default(AffineTransform);
		}

		public AffineTransform InverseMul(AffineTransform transform)
		{
			return default(AffineTransform);
		}

		public static Vector3 operator *(AffineTransform lhs, Vector3 rhs)
		{
			return default(Vector3);
		}

		public static AffineTransform operator *(AffineTransform lhs, AffineTransform rhs)
		{
			return default(AffineTransform);
		}

		public static AffineTransform operator *(Quaternion lhs, AffineTransform rhs)
		{
			return default(AffineTransform);
		}

		public static AffineTransform operator *(AffineTransform lhs, Quaternion rhs)
		{
			return default(AffineTransform);
		}
	}
}
