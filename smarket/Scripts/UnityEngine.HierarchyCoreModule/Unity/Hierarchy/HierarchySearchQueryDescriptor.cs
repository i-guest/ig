using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Scripting.LifecycleManagement;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchySearch.h")]
	[NativeAsStruct]
	[RequiredByNativeCode]
	public sealed class HierarchySearchQueryDescriptor
	{
		[NoAutoStaticsCleanup]
		private static readonly HashSet<string> s_SystemFilters;

		[NoAutoStaticsCleanup]
		private static readonly HierarchySearchQueryDescriptor s_Empty;

		[NoAutoStaticsCleanup]
		private static readonly HierarchySearchQueryDescriptor s_InvalidQuery;

		private string m_Query;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CStrict_003Ek__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private bool _003CInvalid_003Ek__BackingField;

		public HierarchySearchFilter[] SystemFilters { get; private set; }

		public HierarchySearchFilter[] Filters { get; private set; }

		public string[] TextValues { get; private set; }

		public bool Strict
		{
			[CompilerGenerated]
			set
			{
				_003CStrict_003Ek__BackingField = value;
			}
		}

		public bool Invalid
		{
			[CompilerGenerated]
			set
			{
				_003CInvalid_003Ek__BackingField = value;
			}
		}

		public string Query => null;

		public HierarchySearchQueryDescriptor(HierarchySearchFilter[] filters = null, string[] textValues = null)
		{
		}

		public override string ToString()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.HierarchyModule" })]
		internal string BuildFilterQuery()
		{
			return null;
		}

		internal string BuildSystemFilterQuery()
		{
			return null;
		}

		internal string BuildTextQuery()
		{
			return null;
		}

		internal string BuildQuery()
		{
			return null;
		}

		private static T[] Where<T>(IEnumerable<T> src, Func<T, bool> pred)
		{
			return null;
		}
	}
}
