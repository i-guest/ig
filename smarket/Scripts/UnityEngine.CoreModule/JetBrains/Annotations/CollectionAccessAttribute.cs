using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace JetBrains.Annotations
{
	[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property)]
	public sealed class CollectionAccessAttribute : Attribute
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly CollectionAccessType _003CCollectionAccessType_003Ek__BackingField;

		public CollectionAccessAttribute(CollectionAccessType collectionAccessType)
		{
		}
	}
}
