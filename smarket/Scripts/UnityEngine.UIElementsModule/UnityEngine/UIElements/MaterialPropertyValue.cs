using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct MaterialPropertyValue : IEquatable<MaterialPropertyValue>
	{
		public string name;

		public MaterialPropertyValueType type;

		public Vector4 packedValue;

		public Texture textureValue;

		public float GetFloat()
		{
			return 0f;
		}

		public Vector4 GetVector()
		{
			return default(Vector4);
		}

		public Color GetColor()
		{
			return default(Color);
		}

		public override string ToString()
		{
			return null;
		}

		public static bool operator !=(MaterialPropertyValue lhs, MaterialPropertyValue rhs)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(MaterialPropertyValue other)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
