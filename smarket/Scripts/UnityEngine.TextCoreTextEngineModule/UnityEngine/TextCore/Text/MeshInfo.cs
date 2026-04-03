using UnityEngine.Bindings;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.IMGUIModule", "UnityEngine.UIElementsModule" })]
	internal struct MeshInfo
	{
		public int vertexCount;

		public TextCoreVertex[] vertexData;

		public Material material;

		[Ignore]
		public int vertexBufferSize;

		[Ignore]
		public bool applySDF;

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal GlyphRenderMode glyphRenderMode;

		public MeshInfo(int size, bool isIMGUI)
		{
			vertexCount = 0;
			vertexData = null;
			material = null;
			vertexBufferSize = 0;
			applySDF = false;
			glyphRenderMode = default(GlyphRenderMode);
		}

		internal void ResizeMeshInfo(int size, bool isIMGUI)
		{
		}

		internal void Clear(bool uploadChanges)
		{
		}

		internal void ClearUnusedVertices()
		{
		}
	}
}
