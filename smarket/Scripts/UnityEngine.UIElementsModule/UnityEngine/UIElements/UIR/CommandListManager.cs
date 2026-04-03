using System;
using System.Collections.Generic;

namespace UnityEngine.UIElements.UIR
{
	internal class CommandListManager : IDisposable
	{
		private readonly IntPtr m_VertexDecl;

		private readonly IntPtr m_DefaultStencilState;

		private uint m_CurrentIndex;

		private Stack<CommandList> m_CommandListPool;

		private CommandList m_DefaultCommandList;

		private List<CommandList>[] m_CommandListsArray;

		private List<CommandList> m_CurrentFrameCommandLists;

		private List<UIRenderer> m_UIRenderersWithDrawCallData;

		private TextureSlotCount m_TextureSlotCount;

		public CommandList defaultCommandList => null;

		protected bool disposed { get; private set; }

		public CommandListManager(IntPtr vertexDecl, IntPtr defaultStencilState)
		{
		}

		public CommandList GetOrCreateCommandList(VisualElement owner, Material material, CommandFlags commandFlags)
		{
			return null;
		}

		public void AdvanceFrame()
		{
		}

		public void BeginSerialize(TextureSlotCount textureSlotCount)
		{
		}

		public void EndSerialize()
		{
		}

		public void Dispose()
		{
		}

		public void ResetUIRendererDrawCallData()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
