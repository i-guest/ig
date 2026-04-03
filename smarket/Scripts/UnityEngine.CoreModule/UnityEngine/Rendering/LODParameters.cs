using System;

namespace UnityEngine.Rendering
{
	public struct LODParameters : IEquatable<LODParameters>
	{
		private int m_IsOrthographic;

		private Vector3 m_CameraPosition;

		private float m_FieldOfView;

		private float m_OrthoSize;

		private int m_CameraPixelHeight;

		public bool isOrthographic
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector3 cameraPosition => default(Vector3);

		public float fieldOfView => 0f;

		public float orthoSize => 0f;

		public int cameraPixelHeight => 0;

		public bool Equals(LODParameters other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
