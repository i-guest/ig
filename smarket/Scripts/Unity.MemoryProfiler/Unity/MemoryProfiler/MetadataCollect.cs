using System;
using Unity.Profiling.Memory;

namespace Unity.MemoryProfiler
{
	public abstract class MetadataCollect : IDisposable
	{
		private bool disposed;

		public abstract void CollectMetadata(MemorySnapshotMetadata data);

		public void Dispose()
		{
		}
	}
}
