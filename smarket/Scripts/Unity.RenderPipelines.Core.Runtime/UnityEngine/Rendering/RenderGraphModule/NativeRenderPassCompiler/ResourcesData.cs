using System.Runtime.CompilerServices;
using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal class ResourcesData
	{
		public NativeList<ResourceUnversionedData>[] unversionedData;

		public NativeList<ResourceVersionedData>[] versionedData;

		public NativeList<ResourceReaderData>[] readerData;

		public int[] MaxVersions;

		public int[] MaxReaders;

		public DynamicArray<Name>[] resourceNames;

		public ref ResourceVersionedData this[ResourceHandle h]
		{
			get
			{
				throw null;
			}
		}

		public void Clear()
		{
		}

		private void AllocateAndResizeNativeListIfNeeded<T>(ref NativeList<T> nativeList, int size, NativeArrayOptions options) where T : struct
		{
		}

		public void Initialize(RenderGraphResourceRegistry resources)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int Index(in ResourceHandle h)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public int IndexReader(in ResourceHandle h, int readerID)
		{
			return 0;
		}

		public void Dispose()
		{
		}
	}
}
