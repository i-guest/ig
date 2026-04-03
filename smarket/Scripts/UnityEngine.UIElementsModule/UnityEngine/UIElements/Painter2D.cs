using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Profiling;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements
{
	public class Painter2D : IDisposable
	{
		private struct Painter2DJobData
		{
			public UnsafeMeshGenerationNode node;

			public int snapshotIndex;

			public IntPtr vectorImagePtr;

			public IntPtr texturePtr;
		}

		private struct Painter2DJob : IJobParallelFor
		{
			[NativeDisableUnsafePtrRestriction]
			public IntPtr painterHandle;

			[ReadOnly]
			public TempMeshAllocator allocator;

			[ReadOnly]
			public NativeSlice<Painter2DJobData> jobParameters;

			public void Execute(int i)
			{
			}
		}

		private static readonly MemoryLabel k_MemoryLabel;

		private MeshGenerationContext m_Ctx;

		internal DetachedAllocator m_DetachedAllocator;

		internal SafeHandleAccess m_Handle;

		private FillGradient m_FillGradient;

		private Texture2D m_FillTexture;

		private FillGradient m_StrokeFillGradient;

		private List<Painter2DJobData> m_JobSnapshots;

		private List<VectorImage> m_VectorImageToRelease;

		private NativeArray<Painter2DJobData> m_JobParameters;

		private bool m_Disposed;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static bool _003CisPainterActive_003Ek__BackingField;

		private static readonly ProfilerMarker s_StrokeMarker;

		private static readonly ProfilerMarker s_FillMarker;

		private MeshGenerationCallback m_OnMeshGenerationDelegate;

		internal static bool isPainterActive
		{
			[CompilerGenerated]
			set
			{
				_003CisPainterActive_003Ek__BackingField = value;
			}
		}

		internal Painter2D(MeshGenerationContext ctx)
		{
		}

		public Painter2D()
		{
		}

		internal void Reset()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		internal void ScheduleJobs(MeshGenerationContext mgc)
		{
		}

		private void OnMeshGeneration(MeshGenerationContext ctx, object data)
		{
		}
	}
}
