using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.Hierarchy
{
	[StructLayout((LayoutKind)0)]
	[RequiredByNativeCode]
	[NativeHeader("Modules/HierarchyCore/Public/HierarchyNodeTypeHandlerBase.h")]
	[NativeHeader("Modules/HierarchyCore/Public/Hierarchy.h")]
	[NativeHeader("Modules/HierarchyCore/HierarchyBindings.h")]
	public sealed class Hierarchy : IDisposable
	{
		internal static class BindingsMarshaller
		{
			public static IntPtr ConvertToUnmanaged(Hierarchy hierarchy)
			{
				return (IntPtr)0;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		internal delegate void HandlerCreatedEventHandler(HierarchyNodeTypeHandlerBase handler);

		private IntPtr m_Ptr;

		private readonly IntPtr m_RootPtr;

		private readonly IntPtr m_VersionPtr;

		private readonly bool m_IsOwner;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private HandlerCreatedEventHandler HandlerCreated;

		public bool IsCreated => false;

		public ref readonly HierarchyNode Root
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				throw null;
			}
		}

		public bool UpdateNeeded
		{
			[NativeMethod("UpdateNeeded", IsThreadSafe = true)]
			get
			{
				return false;
			}
		}

		internal int Version
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			get
			{
				return 0;
			}
		}

		public Hierarchy()
		{
		}

		private Hierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr)
		{
		}

		~Hierarchy()
		{
		}

		public void Dispose()
		{
		}

		private void Dispose(bool disposing)
		{
		}

		public HierarchyNodeTypeHandlerBaseEnumerable EnumerateNodeTypeHandlersBase()
		{
			return default(HierarchyNodeTypeHandlerBaseEnumerable);
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public bool Exists(in HierarchyNode node)
		{
			return false;
		}

		public HierarchyNode Add(in HierarchyNode parent)
		{
			return default(HierarchyNode);
		}

		public void SetParent(in HierarchyNode node, in HierarchyNode parent)
		{
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public HierarchyNode GetParent(in HierarchyNode node)
		{
			return default(HierarchyNode);
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public HierarchyNode[] GetChildren(in HierarchyNode node)
		{
			return null;
		}

		public HierarchyNodeChildren EnumerateChildren(in HierarchyNode node)
		{
			return default(HierarchyNodeChildren);
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public int GetChildrenCount(in HierarchyNode node)
		{
			return 0;
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public void SetSortIndex(in HierarchyNode node, int sortIndex)
		{
		}

		[NativeMethod(IsThreadSafe = true, ThrowsException = true)]
		public void SortChildren(in HierarchyNode node)
		{
		}

		public HierarchyPropertyUnmanaged<T> GetOrCreatePropertyUnmanaged<T>(string name, HierarchyPropertyStorageType type = HierarchyPropertyStorageType.Dense) where T : struct
		{
			return default(HierarchyPropertyUnmanaged<T>);
		}

		[NativeMethod(IsThreadSafe = true)]
		public void Update()
		{
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static Hierarchy FromIntPtr(IntPtr handlePtr)
		{
			return null;
		}

		[FreeFunction("HierarchyBindings::Create", IsThreadSafe = true)]
		private static IntPtr Create(IntPtr handlePtr, out IntPtr rootPtr, out IntPtr versionPtr)
		{
			rootPtr = default(IntPtr);
			versionPtr = default(IntPtr);
			return (IntPtr)0;
		}

		[FreeFunction("HierarchyBindings::Destroy", IsThreadSafe = true)]
		private static void Destroy(IntPtr nativePtr)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseCount", HasExplicitThis = true, IsThreadSafe = true)]
		internal int GetNodeTypeHandlersBaseCount()
		{
			return 0;
		}

		[FreeFunction("HierarchyBindings::GetNodeTypeHandlersBaseSpan", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		[VisibleToOtherModules(new string[] { "UnityEngine.HierarchyModule" })]
		internal int GetNodeTypeHandlersBaseSpan(Span<IntPtr> outHandlers)
		{
			return 0;
		}

		[FreeFunction("HierarchyBindings::AddNode", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private HierarchyNode AddNode(in HierarchyNode parent)
		{
			return default(HierarchyNode);
		}

		[FreeFunction("HierarchyBindings::SetNodeParent", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private void SetNodeParent(in HierarchyNode node, in HierarchyNode parent)
		{
		}

		[FreeFunction("HierarchyBindings::EnumerateChildrenPtr", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private IntPtr EnumerateChildrenPtr(in HierarchyNode node)
		{
			return (IntPtr)0;
		}

		[FreeFunction("HierarchyBindings::GetOrCreateProperty", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		private HierarchyPropertyId GetOrCreateProperty(string name, in HierarchyPropertyDescriptor descriptor)
		{
			return default(HierarchyPropertyId);
		}

		[FreeFunction("HierarchyBindings::SetPropertyRaw", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		internal unsafe void SetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, void* ptr, int size)
		{
		}

		[FreeFunction("HierarchyBindings::GetPropertyRaw", HasExplicitThis = true, IsThreadSafe = true, ThrowsException = true)]
		internal unsafe void* GetPropertyRaw(in HierarchyPropertyId property, in HierarchyNode node, out int size)
		{
			size = default(int);
			return null;
		}

		[RequiredByNativeCode]
		private static IntPtr CreateHierarchy(IntPtr nativePtr, IntPtr rootPtr, IntPtr versionPtr)
		{
			return (IntPtr)0;
		}

		[RequiredByNativeCode]
		private static void InvokeHandlerCreated(IntPtr hierarchyPtr, IntPtr handlerPtr)
		{
		}

		private static bool get_UpdateNeeded_Injected(IntPtr _unity_self)
		{
			return false;
		}

		private static bool Exists_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return false;
		}

		private static void GetParent_Injected(IntPtr _unity_self, in HierarchyNode node, out HierarchyNode ret)
		{
			ret = default(HierarchyNode);
		}

		private static void GetChildren_Injected(IntPtr _unity_self, in HierarchyNode node, out BlittableArrayWrapper ret)
		{
			ret = default(BlittableArrayWrapper);
		}

		private static int GetChildrenCount_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return 0;
		}

		private static void SetSortIndex_Injected(IntPtr _unity_self, in HierarchyNode node, int sortIndex)
		{
		}

		private static void SortChildren_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
		}

		private static void Update_Injected(IntPtr _unity_self)
		{
		}

		private static int GetNodeTypeHandlersBaseCount_Injected(IntPtr _unity_self)
		{
			return 0;
		}

		private static int GetNodeTypeHandlersBaseSpan_Injected(IntPtr _unity_self, ref ManagedSpanWrapper outHandlers)
		{
			return 0;
		}

		private static void AddNode_Injected(IntPtr _unity_self, in HierarchyNode parent, out HierarchyNode ret)
		{
			ret = default(HierarchyNode);
		}

		private static void SetNodeParent_Injected(IntPtr _unity_self, in HierarchyNode node, in HierarchyNode parent)
		{
		}

		private static IntPtr EnumerateChildrenPtr_Injected(IntPtr _unity_self, in HierarchyNode node)
		{
			return (IntPtr)0;
		}

		private static void GetOrCreateProperty_Injected(IntPtr _unity_self, ref ManagedSpanWrapper name, in HierarchyPropertyDescriptor descriptor, out HierarchyPropertyId ret)
		{
			ret = default(HierarchyPropertyId);
		}

		private unsafe static void SetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, void* ptr, int size)
		{
		}

		private unsafe static void* GetPropertyRaw_Injected(IntPtr _unity_self, in HierarchyPropertyId property, in HierarchyNode node, out int size)
		{
			size = default(int);
			return null;
		}
	}
}
