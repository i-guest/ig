using System.Collections.Generic;
using Unity.Collections;
using UnityEngine.TextCore.LowLevel;

namespace UnityEngine.UIElements.UIR
{
	internal interface IMeshGenerator
	{
		VisualElement currentElement { set; }

		TextJobSystem textJobSystem { get; }

		void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Texture2D> atlases, List<GlyphRenderMode> renderModes, List<float> sdfScales);

		void DrawText(List<NativeSlice<Vertex>> vertices, List<NativeSlice<ushort>> indices, List<Material> materials, List<GlyphRenderMode> renderModes);

		void DrawRectangle(MeshGenerator.RectangleParams rectParams);

		void DrawBorder(MeshGenerator.BorderParams borderParams);

		void DrawRectangleRepeat(MeshGenerator.RectangleParams rectParams, Rect totalRect, float scaledPixelsPerPoint);

		void ScheduleJobs(MeshGenerationContext mgc);
	}
}
