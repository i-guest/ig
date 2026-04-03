using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal class CompilerContextData : IDisposable, RenderGraph.ICompiledGraph
	{
		public ref struct PassIterator
		{
			private readonly CompilerContextData m_Ctx;

			private int m_Index;

			public ref readonly PassData Current
			{
				get
				{
					throw null;
				}
			}

			public PassIterator(CompilerContextData ctx)
			{
				m_Ctx = null;
				m_Index = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public PassIterator GetEnumerator()
			{
				return default(PassIterator);
			}
		}

		public ref struct NativePassIterator
		{
			private readonly CompilerContextData m_Ctx;

			private int m_Index;

			public ref readonly NativePassData Current
			{
				get
				{
					throw null;
				}
			}

			public NativePassIterator(CompilerContextData ctx)
			{
				m_Ctx = null;
				m_Index = 0;
			}

			public bool MoveNext()
			{
				return false;
			}

			public NativePassIterator GetEnumerator()
			{
				return default(NativePassIterator);
			}
		}

		public ResourcesData resources;

		public NativeList<PassData> passData;

		public Dictionary<int, GraphicsFence> fences;

		public DynamicArray<Name> passNames;

		public NativeList<PassInputData> inputData;

		public NativeList<PassOutputData> outputData;

		public NativeList<PassFragmentData> fragmentData;

		public NativeList<ResourceHandle> sampledData;

		public NativeList<ResourceHandle> createData;

		public NativeList<ResourceHandle> destroyData;

		public NativeList<PassRandomWriteData> randomAccessResourceData;

		public NativeList<NativePassData> nativePassData;

		public NativeList<SubPassDescriptor> nativeSubPassData;

		private bool m_AreNativeListsAllocated;

		public PassIterator Passes => default(PassIterator);

		public NativePassIterator NativePasses => default(NativePassIterator);

		private void AllocateNativeDataStructuresIfNeeded(int estimatedNumPasses)
		{
		}

		public void Initialize(RenderGraphResourceRegistry resourceRegistry, int estimatedNumPasses)
		{
		}

		public void Clear()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref ResourceUnversionedData UnversionedResourceData(in ResourceHandle h)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref ResourceVersionedData VersionedResourceData(in ResourceHandle h)
		{
			throw null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ReadOnlySpan<ResourceReaderData> Readers(in ResourceHandle h)
		{
			return default(ReadOnlySpan<ResourceReaderData>);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public ref ResourceReaderData ResourceReader(in ResourceHandle h, int i)
		{
			throw null;
		}

		public bool TryAddToFragmentList(in TextureAccess access, int listFirstIndex, int numItems, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public Name GetFullPassName(int passId)
		{
			return default(Name);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string GetPassName(int passId)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string GetResourceName(in ResourceHandle h)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public string GetResourceVersionedName(in ResourceHandle h)
		{
			return null;
		}

		public bool TryAddToRandomAccessResourceList(in ResourceHandle h, int randomWriteSlotIndex, bool preserveCounterValue, int listFirstIndex, int numItems, out string errorMessage)
		{
			errorMessage = null;
			return false;
		}

		public void TagAllPasses(int value)
		{
		}

		public void CullAllPasses(bool isCulled)
		{
		}

		public TextureUVOrigin GetTextureUVOrigin(in TextureHandle targetHandle)
		{
			return default(TextureUVOrigin);
		}

		internal List<PassData> GetPasses()
		{
			return null;
		}

		internal List<NativePassData> GetNativePasses()
		{
			return null;
		}

		~CompilerContextData()
		{
		}

		public void Dispose()
		{
		}

		private void Cleanup()
		{
		}
	}
}
