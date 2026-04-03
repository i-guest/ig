using System.Runtime.CompilerServices;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal struct ResourceUnversionedData
	{
		public readonly bool isImported;

		public bool isShared;

		public int tag;

		public int lastUsePassID;

		public int lastWritePassID;

		public int firstUsePassID;

		public bool memoryLess;

		public readonly int width;

		public readonly int height;

		public readonly int volumeDepth;

		public readonly int msaaSamples;

		public readonly GraphicsFormat graphicsFormat;

		public int latestVersionNumber;

		public readonly bool clear;

		public readonly bool discard;

		public readonly bool bindMS;

		public TextureUVOriginSelection textureUVOrigin;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string GetName(CompilerContextData ctx, in ResourceHandle h)
		{
			return null;
		}

		public ResourceUnversionedData(TextureResource rll, ref RenderTargetInfo info, ref TextureDesc desc, bool isResourceShared)
		{
			isImported = false;
			isShared = false;
			tag = 0;
			lastUsePassID = 0;
			lastWritePassID = 0;
			firstUsePassID = 0;
			memoryLess = false;
			width = 0;
			height = 0;
			volumeDepth = 0;
			msaaSamples = 0;
			graphicsFormat = default(GraphicsFormat);
			latestVersionNumber = 0;
			clear = false;
			discard = false;
			bindMS = false;
			textureUVOrigin = default(TextureUVOriginSelection);
		}

		public ResourceUnversionedData(IRenderGraphResource rll, ref BufferDesc _, bool isResourceShared)
		{
			isImported = false;
			isShared = false;
			tag = 0;
			lastUsePassID = 0;
			lastWritePassID = 0;
			firstUsePassID = 0;
			memoryLess = false;
			width = 0;
			height = 0;
			volumeDepth = 0;
			msaaSamples = 0;
			graphicsFormat = default(GraphicsFormat);
			latestVersionNumber = 0;
			clear = false;
			discard = false;
			bindMS = false;
			textureUVOrigin = default(TextureUVOriginSelection);
		}

		public ResourceUnversionedData(IRenderGraphResource rll, ref RayTracingAccelerationStructureDesc _, bool isResourceShared)
		{
			isImported = false;
			isShared = false;
			tag = 0;
			lastUsePassID = 0;
			lastWritePassID = 0;
			firstUsePassID = 0;
			memoryLess = false;
			width = 0;
			height = 0;
			volumeDepth = 0;
			msaaSamples = 0;
			graphicsFormat = default(GraphicsFormat);
			latestVersionNumber = 0;
			clear = false;
			discard = false;
			bindMS = false;
			textureUVOrigin = default(TextureUVOriginSelection);
		}

		public void InitializeNullResource()
		{
		}
	}
}
