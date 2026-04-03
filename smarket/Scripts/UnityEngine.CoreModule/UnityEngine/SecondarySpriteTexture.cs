using System;

namespace UnityEngine
{
	[Serializable]
	public struct SecondarySpriteTexture : IEquatable<SecondarySpriteTexture>
	{
		public string name;

		public Texture2D texture;

		public bool Equals(SecondarySpriteTexture other)
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

		public static bool operator ==(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs)
		{
			return false;
		}

		public static bool operator !=(SecondarySpriteTexture lhs, SecondarySpriteTexture rhs)
		{
			return false;
		}
	}
}
