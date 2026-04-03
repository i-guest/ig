using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Profiling;

namespace UnityEngine.UIElements.Layout
{
	internal class LayoutManager : IDisposable
	{
		private enum SharedManagerState
		{
			Uninitialized = 0,
			Initialized = 1,
			Shutdown = 2
		}

		private static SharedManagerState s_Initialized;

		private static bool s_AppDomainUnloadRegistered;

		private static LayoutManager s_SharedInstance;

		private static readonly List<LayoutManager> s_Managers;

		private readonly int m_Index;

		private LayoutDataStore m_Nodes;

		private LayoutDataStore m_Configs;

		private readonly ConcurrentQueue<LayoutHandle> m_NodesToFree;

		private readonly LayoutHandle m_DefaultConfig;

		private readonly ManagedObjectStore<LayoutMeasureFunction> m_ManagedMeasureFunctions;

		private readonly ManagedObjectStore<LayoutBaselineFunction> m_ManagedBaselineFunctions;

		private readonly ManagedObjectStore<GCHandle> m_ManagedOwners;

		private readonly ProfilerMarker m_CollectMarker;

		private int m_HighMark;

		public static bool IsSharedManagerCreated => false;

		public static LayoutManager SharedManager => null;

		private static int DefaultCapacity => 0;

		private static void Initialize()
		{
		}

		private static void Shutdown()
		{
		}

		internal static LayoutManager GetManager(int index)
		{
			return null;
		}

		public LayoutManager(Allocator allocator)
		{
		}

		public LayoutManager(Allocator allocator, int initialNodeCapacity)
		{
		}

		public void Dispose()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private LayoutDataAccess GetAccess()
		{
			return default(LayoutDataAccess);
		}

		public LayoutConfig GetDefaultConfig()
		{
			return default(LayoutConfig);
		}

		public LayoutConfig CreateConfig()
		{
			return default(LayoutConfig);
		}

		public void DestroyConfig(ref LayoutConfig config)
		{
		}

		public LayoutNode CreateNode()
		{
			return default(LayoutNode);
		}

		private LayoutNode CreateNodeInternal(LayoutHandle configHandle)
		{
			return default(LayoutNode);
		}

		private void TryRecycleSingleNode()
		{
		}

		private void TryRecycleNodes()
		{
		}

		public void EnqueueNodeForRecycling(ref LayoutNode node)
		{
		}

		private void FreeNode(LayoutHandle handle)
		{
		}

		public void Collect()
		{
		}

		public VisualElement GetOwner(LayoutHandle handle)
		{
			return null;
		}

		public void SetOwner(LayoutHandle handle, VisualElement value)
		{
		}

		public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle)
		{
			return null;
		}

		public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value)
		{
		}

		public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle)
		{
			return null;
		}
	}
}
