using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
	[StructLayout((LayoutKind)0, Size = 1)]
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public struct RenderGraphProfilingScope : IDisposable
	{
		public RenderGraphProfilingScope(RenderGraph renderGraph, ProfilingSampler sampler)
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}
	}
}
