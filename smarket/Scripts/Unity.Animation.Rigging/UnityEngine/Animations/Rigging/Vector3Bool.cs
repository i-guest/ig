using System;

namespace UnityEngine.Animations.Rigging
{
	[Serializable]
	public struct Vector3Bool
	{
		public bool x;

		public bool y;

		public bool z;

		public Vector3Bool(bool val)
		{
			x = false;
			y = false;
			z = false;
		}

		public Vector3Bool(bool x, bool y, bool z)
		{
			this.x = false;
			this.y = false;
			this.z = false;
		}
	}
}
