namespace UnityEngine.Bindings
{
	[VisibleToOtherModules]
	internal readonly ref struct ManagedSpanWrapper
	{
		public unsafe readonly void* begin;

		public readonly int length;

		public unsafe ManagedSpanWrapper(void* begin, int length)
		{
			this.begin = null;
			this.length = 0;
		}
	}
}
