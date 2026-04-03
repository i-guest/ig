using System.Collections.Generic;
using UnityEngine.Rendering;
using UnityEngine.Rendering.RenderGraphModule;
using UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler;

internal class RenderGraphCompilationCache
{
	private struct HashEntry<T>
	{
		public int hash;

		public int lastFrameUsed;

		public T compiledGraph;
	}

	private DynamicArray<HashEntry<RenderGraph.CompiledGraph>> m_HashEntries;

	private DynamicArray<HashEntry<CompilerContextData>> m_NativeHashEntries;

	private Stack<RenderGraph.CompiledGraph> m_CompiledGraphPool;

	private Stack<CompilerContextData> m_NativeCompiledGraphPool;

	private static DynamicArray<HashEntry<RenderGraph.CompiledGraph>>.SortComparer s_EntryComparer;

	private static DynamicArray<HashEntry<CompilerContextData>>.SortComparer s_NativeEntryComparer;

	private const int k_CachedGraphCount = 20;

	private static int s_Hash;

	private static int HashEntryComparer<T>(HashEntry<T> a, HashEntry<T> b)
	{
		return 0;
	}

	private bool GetCompilationCache<T>(int hash, int frameIndex, out T outGraph, DynamicArray<HashEntry<T>> hashEntries, Stack<T> pool, DynamicArray<HashEntry<T>>.SortComparer comparer) where T : RenderGraph.ICompiledGraph
	{
		outGraph = default(T);
		return false;
	}

	public bool GetCompilationCache(int hash, int frameIndex, out RenderGraph.CompiledGraph outGraph)
	{
		outGraph = null;
		return false;
	}

	public bool GetCompilationCache(int hash, int frameIndex, out CompilerContextData outGraph)
	{
		outGraph = null;
		return false;
	}

	public void Clear()
	{
	}

	public void Cleanup()
	{
	}
}
