using System;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	[NativeHeader("Modules/TextCoreTextEngine/Native/ATGMeshInfo.h")]
	internal struct ATGMeshInfo
	{
		private IntPtr m_TextElementInfosPtr;

		private int m_TextElementCount;

		public int textAssetId;

		public Span<NativeTextElementInfo> textElementInfos => default(Span<NativeTextElementInfo>);
	}
}
