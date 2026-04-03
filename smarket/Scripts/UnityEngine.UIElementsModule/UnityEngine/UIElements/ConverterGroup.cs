using System.Diagnostics;
using System.Runtime.CompilerServices;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	public class ConverterGroup
	{
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly string _003Cid_003Ek__BackingField;

		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string _003CdisplayName_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private readonly string _003Cdescription_003Ek__BackingField;

		internal TypeConverterRegistry registry { get; }

		public ConverterGroup(string id, string displayName = null, string description = null)
		{
		}

		public bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
		{
			destination = default(TDestination);
			return false;
		}

		public bool TrySetValue<TContainer, TValue>(ref TContainer container, in PropertyPath path, TValue value, out VisitReturnCode returnCode)
		{
			returnCode = default(VisitReturnCode);
			return false;
		}
	}
}
