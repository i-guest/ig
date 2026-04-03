using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Scripting.LifecycleManagement;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[StructLayout((LayoutKind)0)]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
	[RequiredByNativeCode]
	[NativeHeader("Modules/HierarchyCore/HierarchyNodeTypeHandlerBaseBindings.h")]
	public abstract class HierarchyNodeTypeHandlerBase
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToUnmanaged(HierarchyNodeTypeHandlerBase handler)
			{
				return (IntPtr)0;
			}
		}

		[StructLayout((LayoutKind)0, Size = 1)]
		private struct ConstructorScope : IDisposable
		{
			[NoAutoStaticsCleanup]
			[ThreadStatic]
			private static IntPtr m_Ptr;

			[NoAutoStaticsCleanup]
			[ThreadStatic]
			private static Hierarchy m_Hierarchy;

			[NoAutoStaticsCleanup]
			[ThreadStatic]
			private static HierarchyCommandList m_CommandList;

			private static IntPtr Ptr
			{
				set
				{
				}
			}

			private static Hierarchy Hierarchy
			{
				set
				{
				}
			}

			private static HierarchyCommandList CommandList
			{
				set
				{
				}
			}

			public ConstructorScope(IntPtr nativePtr, Hierarchy hierarchy, HierarchyCommandList cmdList)
			{
			}

			public void Dispose()
			{
			}
		}

		internal readonly IntPtr m_Ptr;

		private readonly Hierarchy m_Hierarchy;

		private readonly HierarchyCommandList m_CommandList;

		[AutoStaticsCleanupOnCodeReload]
		private static readonly Dictionary<Type, int> s_NodeTypes;

		protected virtual void Initialize()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		[NativeMethod(IsThreadSafe = true)]
		public virtual string GetNodeTypeName()
		{
			return null;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public virtual int GetNodeHashCode(in HierarchyNode node)
		{
			return 0;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public virtual HierarchyNodeFlags GetDefaultNodeFlags(in HierarchyNode node, HierarchyNodeFlags defaultFlags = HierarchyNodeFlags.None)
		{
			return default(HierarchyNodeFlags);
		}

		protected virtual void SearchBegin(HierarchySearchQueryDescriptor query)
		{
		}

		protected virtual bool SearchMatch(in HierarchyNode node)
		{
			return false;
		}

		protected virtual void SearchEnd()
		{
		}

		protected virtual void ViewModelPostUpdate(HierarchyViewModel viewModel)
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		internal static HierarchyNodeTypeHandlerBase FromIntPtr(IntPtr handlePtr)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal void Internal_SearchBegin(HierarchySearchQueryDescriptor query)
		{
		}

		[RequiredByNativeCode]
		private static IntPtr CreateNodeTypeHandlerFromType(IntPtr nativePtr, Type handlerType, IntPtr hierarchyPtr, IntPtr cmdListPtr)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static bool TryGetStaticNodeType(Type handlerType, out int nodeType)
		{
			nodeType = default(int);
			return false;
		}

		[RequiredByNativeCode]
		private static void InvokeInitialize(IntPtr handlePtr)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeDispose(IntPtr handlePtr)
		{
		}

		[RequiredByNativeCode]
		private static string InvokeGetNodeTypeName(IntPtr handlePtr)
		{
			return null;
		}

		[RequiredByNativeCode]
		private static int InvokeGetNodeHashCode(IntPtr handlePtr, in HierarchyNode node)
		{
			return 0;
		}

		[RequiredByNativeCode]
		private static HierarchyNodeFlags InvokeGetDefaultNodeFlags(IntPtr handlePtr, in HierarchyNode node, HierarchyNodeFlags defaultFlags)
		{
			return default(HierarchyNodeFlags);
		}

		[RequiredByNativeCode]
		private static bool InvokeChangesPending(IntPtr handlePtr)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static bool InvokeIntegrateChanges(IntPtr handlePtr, IntPtr cmdListPtr)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static bool InvokeSearchMatch(IntPtr handlePtr, in HierarchyNode node)
		{
			return false;
		}

		[RequiredByNativeCode]
		private static void InvokeSearchEnd(IntPtr handlePtr)
		{
		}

		[RequiredByNativeCode]
		private static void InvokeViewModelPostUpdate(IntPtr handlePtr, IntPtr viewModelPtr)
		{
		}

		[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::ChangesPending", HasExplicitThis = true, IsThreadSafe = true)]
		[Obsolete("ChangesPending is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", false)]
		protected virtual bool ChangesPending()
		{
			return false;
		}

		[Obsolete("IntegrateChanges is obsolete, it is replaced by adding commands into the hierarchy node type handler's CommandList.", false)]
		[FreeFunction("HierarchyNodeTypeHandlerBaseBindings::IntegrateChanges", HasExplicitThis = true, IsThreadSafe = true)]
		protected virtual bool IntegrateChanges(HierarchyCommandList cmdList)
		{
			return false;
		}

		private static void GetNodeTypeName_Injected(IntPtr _unity_self, out ManagedSpanWrapper ret)
		{
			ret = default(ManagedSpanWrapper);
		}

		private static int GetNodeHashCode_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return 0;
		}

		private static HierarchyNodeFlags GetDefaultNodeFlags_Injected(IntPtr _unity_self, in HierarchyNode node, HierarchyNodeFlags defaultFlags)
		{
			return default(HierarchyNodeFlags);
		}

		private static bool ChangesPending_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool IntegrateChanges_Injected(IntPtr _unity_self, IntPtr cmdList)
		{
			return false;
		}
	}
}
