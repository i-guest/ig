using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR
{
	internal class CommandList : IDisposable
	{
		private static readonly MemoryLabel k_MemoryLabel;

		public VisualElement m_Owner;

		public UIRenderer m_Renderer;

		private readonly IntPtr m_VertexDecl;

		private readonly IntPtr m_StencilState;

		public MaterialPropertyBlock constantProps;

		public GCHandle handle;

		public Material m_Material;

		public CommandFlags flags;

		private List<SerializedCommand> m_Commands;

		private Vector4[] m_GpuTextureData;

		private NativeList<DrawBufferRange> m_DrawRanges;

		protected bool disposed { get; private set; }

		public CommandList(IntPtr vertexDecl, IntPtr stencilState)
		{
		}

		public void Reset()
		{
		}

		public void Init(VisualElement owner, Material material, CommandFlags commandFlags)
		{
		}

		public void Execute()
		{
		}

		public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1)
		{
		}

		public void ApplyUserProps(MaterialPropertyBlock userProps)
		{
		}

		public void ApplyBatchProps()
		{
		}

		public void DrawRanges(Utility.GPUBuffer<ushort> ib, Utility.GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges)
		{
		}

		public void Dispose()
		{
		}

		protected void Dispose(bool disposing)
		{
		}
	}
}
