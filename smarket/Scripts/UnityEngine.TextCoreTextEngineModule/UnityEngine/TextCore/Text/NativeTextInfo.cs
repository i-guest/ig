using System;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule" })]
	[NativeHeader("Modules/TextCoreTextEngine/Native/TextInfo.h")]
	internal struct NativeTextInfo
	{
		private IntPtr m_MeshInfosPtr;

		public int meshInfoCount;

		public int totalWidth;

		public int totalHeight;

		public bool isElided;

		public Span<ATGMeshInfo> meshInfos => default(Span<ATGMeshInfo>);
	}
}
