using System.Runtime.CompilerServices;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.Layout
{
	[RequiredByNativeCode]
	internal readonly struct LayoutDataAccess
	{
		private readonly int m_Manager;

		private readonly LayoutDataStore m_Nodes;

		private readonly LayoutDataStore m_Configs;

		internal LayoutDataAccess(int manager, LayoutDataStore nodes, LayoutDataStore configs)
		{
			m_Manager = 0;
			m_Nodes = default(LayoutDataStore);
			m_Configs = default(LayoutDataStore);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref T GetTypedNodeDataRef<T>(LayoutHandle handle, LayoutNodeDataType type) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private ref T GetTypedConfigDataRef<T>(LayoutHandle handle, LayoutConfigDataType type) where T : struct
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref LayoutNodeData GetNodeData(LayoutHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref LayoutStyleData GetStyleData(LayoutHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref LayoutComputedData GetComputedData(LayoutHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref LayoutCacheData GetCacheData(LayoutHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref LayoutConfigData GetConfigData(LayoutHandle handle)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public LayoutMeasureFunction GetMeasureFunction(LayoutHandle handle)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetMeasureFunction(LayoutHandle handle, LayoutMeasureFunction value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public VisualElement GetOwner(LayoutHandle handle)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void SetOwner(LayoutHandle handle, VisualElement value)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public LayoutBaselineFunction GetBaselineFunction(LayoutHandle handle)
		{
			return null;
		}
	}
}
