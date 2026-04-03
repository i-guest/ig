using System;
using Unity.Scripting.LifecycleManagement;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[Serializable]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
	[RequiredByNativeCode]
	public struct HierarchySearchFilter
	{
		private static readonly char[] s_WhiteSpaces;

		[NoAutoStaticsCleanup]
		private static readonly HierarchySearchFilter s_Invalid;

		public static ref readonly HierarchySearchFilter Invalid
		{
			get
			{
				throw null;
			}
		}

		public bool IsValid => false;

		public string Name { get; }

		public string Value { get; }

		public float NumValue { get; }

		public HierarchySearchFilterOperator Op { get; }

		public static string ToString(HierarchySearchFilterOperator op)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		internal static string QuoteStringIfNeeded(string s)
		{
			return null;
		}
	}
}
