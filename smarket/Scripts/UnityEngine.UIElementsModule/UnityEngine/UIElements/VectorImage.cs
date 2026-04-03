using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public sealed class VectorImage : ScriptableObject
	{
		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule" })]
		[SerializeField]
		internal int version;

		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule", "UnityEditor.VectorGraphicsModule" })]
		[SerializeField]
		internal Texture2D atlas;

		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule", "UnityEditor.VectorGraphicsModule" })]
		[SerializeField]
		internal VectorImageVertex[] vertices;

		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule" })]
		[SerializeField]
		internal ushort[] indices;

		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule" })]
		internal GradientSettings[] settings;

		[SerializeField]
		[VisibleToOtherModules(new string[] { "UnityEngine.VectorGraphicsModule" })]
		internal Vector2 size;

		public float width => 0f;

		public float height => 0f;

		private void OnDestroy()
		{
		}
	}
}
