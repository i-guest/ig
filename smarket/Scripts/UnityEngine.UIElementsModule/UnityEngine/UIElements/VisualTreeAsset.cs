using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using UnityEngine.Pool;

namespace UnityEngine.UIElements
{
	[Serializable]
	[HelpURL("UIE-VisualTree-landing")]
	public class VisualTreeAsset : ScriptableObject
	{
		[Serializable]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal struct UsingEntry
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal static readonly IComparer<UsingEntry> comparer;

			[SerializeField]
			public string alias;

			[SerializeField]
			public string path;

			[SerializeField]
			public VisualTreeAsset asset;

			public UsingEntry(string alias, string path)
			{
				this.alias = null;
				this.path = null;
				asset = null;
			}

			public UsingEntry(string alias, VisualTreeAsset asset)
			{
				this.alias = null;
				path = null;
				this.asset = null;
			}
		}

		private class UsingEntryComparer : IComparer<UsingEntry>
		{
			public int Compare(UsingEntry x, UsingEntry y)
			{
				return 0;
			}
		}

		[Serializable]
		internal struct SlotDefinition
		{
			[SerializeField]
			public string name;

			[SerializeField]
			public int insertionPointId;
		}

		[Serializable]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal struct SlotUsageEntry
		{
			[SerializeField]
			public string slotName;

			[SerializeField]
			public int assetId;
		}

		[Serializable]
		private struct AssetEntry
		{
			[SerializeField]
			private string m_Path;

			[SerializeField]
			private string m_TypeFullName;

			[SerializeField]
			private LazyLoadReference<Object> m_AssetReference;

			[SerializeField]
			private int m_InstanceID;

			private Type m_CachedType;

			public Type type => null;

			public string path => null;

			public Object asset => null;

			public AssetEntry(string path, Type type, Object asset)
			{
				m_Path = null;
				m_TypeFullName = null;
				m_AssetReference = default(LazyLoadReference<Object>);
				m_InstanceID = 0;
				m_CachedType = null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDepthFirstTraversal_003Ed__88 : IEnumerable<UxmlAsset>, IEnumerable, IEnumerator<UxmlAsset>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private UxmlAsset _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private UxmlAsset asset;

			public UxmlAsset _003C_003E3__asset;

			public VisualTreeAsset _003C_003E4__this;

			private int _003Ci_003E5__1;

			private IEnumerator<UxmlAsset> _003C_003Es__2;

			private UxmlAsset _003Cchild_003E5__3;

			UxmlAsset IEnumerator<UxmlAsset>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDepthFirstTraversal_003Ed__88(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<UxmlAsset> IEnumerable<UxmlAsset>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003CDepthFirstTraversalOfType_003Ed__87<T> : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private T _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VisualTreeAsset _003C_003E4__this;

			private IEnumerable<UxmlAsset> _003Celements_003E5__1;

			private IEnumerator<UxmlAsset> _003C_003Es__2;

			private UxmlAsset _003Celement_003E5__3;

			private T _003CtElement_003E5__4;

			T IEnumerator<T>.Current
			{
				[DebuggerHidden]
				get
				{
					return default(T);
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDepthFirstTraversalOfType_003Ed__87(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_stylesheets_003Ed__40 : IEnumerable<StyleSheet>, IEnumerable, IEnumerator<StyleSheet>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private StyleSheet _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VisualTreeAsset _003C_003E4__this;

			private PooledObject<HashSet<StyleSheet>> _003CsetHandle_003E5__1;

			private HashSet<StyleSheet> _003Csent_003E5__2;

			private PooledObject<List<UxmlAsset>> _003C__003E5__3;

			private List<UxmlAsset> _003Clist_003E5__4;

			private List<UxmlAsset>.Enumerator _003C_003Es__5;

			private UxmlAsset _003Casset_003E5__6;

			private VisualElementAsset _003Cvea_003E5__7;

			private List<StyleSheet>.Enumerator _003C_003Es__8;

			private StyleSheet _003Cstylesheet_003E5__9;

			private List<string>.Enumerator _003C_003Es__10;

			private string _003CstylesheetPath_003E5__11;

			private StyleSheet _003Cstylesheet_003E5__12;

			StyleSheet IEnumerator<StyleSheet>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_stylesheets_003Ed__40(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			private void _003C_003Em__Finally2()
			{
			}

			private void _003C_003Em__Finally3()
			{
			}

			private void _003C_003Em__Finally4()
			{
			}

			private void _003C_003Em__Finally5()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<StyleSheet> IEnumerable<StyleSheet>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[CompilerGenerated]
		private sealed class _003Cget_templateDependencies_003Ed__30 : IEnumerable<VisualTreeAsset>, IEnumerable, IEnumerator<VisualTreeAsset>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private VisualTreeAsset _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public VisualTreeAsset _003C_003E4__this;

			private HashSet<VisualTreeAsset> _003Csent_003E5__1;

			private List<UsingEntry>.Enumerator _003C_003Es__2;

			private UsingEntry _003Centry_003E5__3;

			private VisualTreeAsset _003Cvta_003E5__4;

			VisualTreeAsset IEnumerator<VisualTreeAsset>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003Cget_templateDependencies_003Ed__30(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<VisualTreeAsset> IEnumerable<VisualTreeAsset>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static string NoRegisteredFactoryErrorMessage;

		internal const string TemplateAliasExistsError = "VisualTreeAsset: could not register a template alias for asset `{0}`, alias is already defined for asset '{1}'";

		[SerializeField]
		private bool m_ImportedWithErrors;

		[SerializeField]
		private bool m_HasEditorElements;

		[SerializeField]
		private bool m_HasUpdatedUrls;

		[SerializeField]
		private bool m_ImportedWithWarnings;

		private static readonly Dictionary<string, VisualElement> s_TemporarySlotInsertionPoints;

		private static readonly List<int> s_VeaIdsPath;

		[SerializeField]
		private List<UsingEntry> m_Usings;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[SerializeField]
		internal StyleSheet inlineSheet;

		[SerializeReference]
		private VisualElementAsset m_VisualTree;

		[SerializeField]
		private List<AssetEntry> m_AssetEntries;

		[SerializeField]
		private List<SlotDefinition> m_Slots;

		[SerializeField]
		private int m_ContentContainerId;

		[SerializeField]
		private int m_ContentHash;

		public bool importedWithErrors
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		internal bool hasEditorElements
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool importerWithUpdatedUrls
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool importedWithWarnings
		{
			get
			{
				return false;
			}
			internal set
			{
			}
		}

		internal List<UsingEntry> usings
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		public IEnumerable<VisualTreeAsset> templateDependencies
		{
			[IteratorStateMachine(typeof(_003Cget_templateDependencies_003Ed__30))]
			get
			{
				return null;
			}
		}

		internal VisualElementAsset visualTreeNoAlloc
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal VisualElementAsset visualTree
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		public IEnumerable<StyleSheet> stylesheets
		{
			[IteratorStateMachine(typeof(_003Cget_stylesheets_003Ed__40))]
			get
			{
				return null;
			}
		}

		internal List<SlotDefinition> slots => null;

		internal int contentContainerId
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int contentHash
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int GetNextChildSerialNumber()
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleSheet GetOrCreateInlineStyleSheet()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SetRootAsset(VisualElementAsset root)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal UxmlObjectAsset AddUxmlObject(UxmlAsset parent, string fieldUxmlName, string fullTypeName, UxmlNamespaceDefinition xmlNamespace = default(UxmlNamespaceDefinition))
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int GetNextUxmlAssetId(int parentId)
		{
			return 0;
		}

		private void Awake__Internal()
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SetupReferences()
		{
		}

		internal List<T> GetUxmlObjects<T>(IUxmlAttributes asset, CreationContext cc) where T : new()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool AssetEntryExists(string path, Type type)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void RegisterAssetEntry(string path, Type type, Object asset)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void TransferAssetEntries(VisualTreeAsset otherVta)
		{
		}

		internal T GetAsset<T>(string path) where T : Object
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Object GetAsset(string path, Type type)
		{
			return null;
		}

		internal Type GetAssetType(string path)
		{
			return null;
		}

		internal IBaseUxmlObjectFactory GetUxmlObjectFactory(UxmlObjectAsset uxmlObjectAsset)
		{
			return null;
		}

		public TemplateContainer Instantiate()
		{
			return null;
		}

		public TemplateContainer Instantiate(string bindingPath)
		{
			return null;
		}

		public TemplateContainer CloneTree()
		{
			return null;
		}

		public TemplateContainer CloneTree(string bindingPath)
		{
			return null;
		}

		public void CloneTree(VisualElement target)
		{
		}

		public void CloneTree(VisualElement target, out int firstElementIndex, out int elementAddedCount)
		{
			firstElementIndex = default(int);
			elementAddedCount = default(int);
		}

		internal void CloneTree(VisualElement target, CreationContext cc)
		{
		}

		private VisualElement CloneSetupRecursively(VisualElementAsset asset, CreationContext context)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryGetSlotInsertionPoint(int insertionPointId, out string slotName)
		{
			slotName = null;
			return false;
		}

		internal bool TryGetUsingEntry(string templateName, out UsingEntry entry)
		{
			entry = default(UsingEntry);
			return false;
		}

		private void RemoveUsingEntry(UsingEntry entry)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualTreeAsset ResolveTemplate(string templateName)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TemplateExists(string templateName)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void RegisterTemplate(string templateName, string path)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void RegisterTemplate(string templateName, VisualTreeAsset asset)
		{
		}

		internal bool TryRegisterTemplate(string templateName, VisualTreeAsset asset)
		{
			return false;
		}

		internal bool TryUnregisterTemplate(string templateName)
		{
			return false;
		}

		private void InsertUsingEntry(UsingEntry entry)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static VisualElement Create(VisualElementAsset asset, CreationContext ctx)
		{
			return null;
		}

		private static void AssignClassListFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}

		private static void AssignStyleSheetFromAssetToElement(VisualElementAsset asset, VisualElement element)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal IEnumerable<UxmlAsset> DepthFirstTraversal()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[IteratorStateMachine(typeof(_003CDepthFirstTraversalOfType_003Ed__87<>))]
		internal IEnumerable<T> DepthFirstTraversalOfType<T>()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDepthFirstTraversal_003Ed__88))]
		internal IEnumerable<UxmlAsset> DepthFirstTraversal(UxmlAsset asset)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int DepthFirstTraversalIndexOf(UxmlAsset uxmlAsset)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal int GenerateNewId(VisualElementAsset vea)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualElementAsset AddElementToDocument(VisualElementAsset vea, VisualElementAsset parent)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualElementAsset ReparentElementInDocument(VisualElementAsset vea, VisualElementAsset newParent, int index = -1)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void Swallow(VisualElementAsset parent, VisualTreeAsset other)
		{
		}

		private static void UpdateUxmlObjectAssetsParentId(VisualElementAsset visualElementAsset)
		{
		}

		internal static void SwallowStyleRule(VisualTreeAsset previous, VisualTreeAsset next, VisualElementAsset vea)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal VisualElementAsset AddElementOfType(VisualElementAsset parent, string fullTypeName)
		{
			return null;
		}
	}
}
