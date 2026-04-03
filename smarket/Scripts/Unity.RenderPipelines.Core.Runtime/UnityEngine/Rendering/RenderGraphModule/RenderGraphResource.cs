using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[DebuggerDisplay("Resource ({GetType().Name}:{GetName()})")]
	internal abstract class RenderGraphResource<DescType, ResType> : IRenderGraphResource where DescType : struct where ResType : class
	{
		public DescType desc;

		public bool validDesc;

		public ResType graphicsResource;

		protected RenderGraphResourcePool<ResType> m_Pool;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Reset(IRenderGraphResourcePool pool = null)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override bool IsCreated()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void ReleaseGraphicsResource()
		{
		}

		public override void CreatePooledGraphicsResource(bool forceResourceCreation)
		{
		}

		public override void ReleasePooledGraphicsResource(int frameIndex)
		{
		}
	}
}
