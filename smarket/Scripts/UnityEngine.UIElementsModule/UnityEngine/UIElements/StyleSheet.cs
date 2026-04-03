using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	[Serializable]
	[HelpURL("UIE-USS")]
	public class StyleSheet : ScriptableObject
	{
		[Flags]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal enum RebuildOptions
		{
			None = 0,
			Synchronous = 1
		}

		[Serializable]
		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal struct ImportStruct
		{
			public StyleSheet styleSheet;

			public string[] mediaQueries;
		}

		internal enum OrderedSelectorType
		{
			None = -1,
			Name = 0,
			Type = 1,
			Class = 2,
			Length = 3
		}

		[NonSerialized]
		private bool m_RequiresRebuild;

		[SerializeField]
		private bool m_ImportedWithErrors;

		[SerializeField]
		private bool m_ImportedWithWarnings;

		[SerializeField]
		private StyleRule[] m_Rules;

		[SerializeField]
		internal float[] floats;

		[SerializeField]
		internal Dimension[] dimensions;

		[SerializeField]
		internal Color[] colors;

		[SerializeField]
		internal string[] strings;

		[SerializeField]
		internal Object[] assets;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[SerializeField]
		internal ImportStruct[] imports;

		[SerializeField]
		private List<StyleSheet> m_FlattenedImportedStyleSheets;

		[SerializeField]
		private int m_ContentHash;

		[SerializeField]
		internal ScalableImage[] scalableImages;

		[NonSerialized]
		internal Dictionary<string, StyleComplexSelector>[] m_Tables;

		[NonSerialized]
		internal int nonEmptyTablesMask;

		[NonSerialized]
		internal StyleComplexSelector firstRootSelector;

		[NonSerialized]
		internal StyleComplexSelector firstWildCardSelector;

		[NonSerialized]
		private bool m_IsDefaultStyleSheet;

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

		internal StyleRule[] rules
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
			}
		}

		internal List<StyleSheet> flattenedRecursiveImports
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get
			{
				return null;
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

		internal Dictionary<string, StyleComplexSelector>[] tables => null;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool isDefaultStyleSheet
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private bool TryCheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle, out T value)
		{
			value = default(T);
			return false;
		}

		private T CheckAccess<T>(T[] list, StyleValueType type, StyleValueHandle handle)
		{
			return default(T);
		}

		internal virtual void OnEnable()
		{
		}

		internal void FlattenImportedStyleSheetsRecursive()
		{
		}

		private void FlattenImportedStyleSheetsRecursive(StyleSheet sheet)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleRule AddRule()
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleRule AddRuleAtIndex(int index)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleRule AddRule(string selector)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleRule AddRuleAtIndex(int index, string selector)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool RemoveRule(StyleRule rule)
		{
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void RemoveRule(int ruleIndex)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void SetRules(StyleRule[] newRules)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void RequestRebuild(RebuildOptions options = RebuildOptions.None)
		{
		}

		internal void RebuildIfNecessary()
		{
		}

		internal void SetupReferences()
		{
		}

		private int AddValueToArray<T>(ref T[] array, T value)
		{
			return 0;
		}

		private int InsertValueInArray<T>(ref T[] array, int index, T value)
		{
			return 0;
		}

		internal int AddValue(StyleValueKeyword keyword)
		{
			return 0;
		}

		internal int AddValue(StyleValueFunction function)
		{
			return 0;
		}

		internal int AddValue(float value)
		{
			return 0;
		}

		internal int AddValue(Dimension value)
		{
			return 0;
		}

		internal int AddValue(Color value)
		{
			return 0;
		}

		internal int AddValue(ScalableImage value)
		{
			return 0;
		}

		internal int AddValue(string value)
		{
			return 0;
		}

		internal int AddValue(Object value)
		{
			return 0;
		}

		internal int AddValue(Enum value)
		{
			return 0;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleValueKeyword ReadKeyword(StyleValueHandle handle)
		{
			return default(StyleValueKeyword);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryReadKeyword(StyleValueHandle handle, out StyleValueKeyword value)
		{
			value = default(StyleValueKeyword);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal float ReadFloat(StyleValueHandle handle)
		{
			return 0f;
		}

		internal bool TryReadFloat(StyleValueHandle handle, out float value)
		{
			value = default(float);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Dimension ReadDimension(StyleValueHandle handle)
		{
			return default(Dimension);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryReadDimension(StyleValueHandle handle, out Dimension value)
		{
			value = default(Dimension);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Color ReadColor(StyleValueHandle handle)
		{
			return default(Color);
		}

		internal bool TryReadColor(StyleValueHandle handle, out Color value)
		{
			value = default(Color);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadString(StyleValueHandle handle)
		{
			return null;
		}

		internal bool TryReadString(StyleValueHandle handle, out string value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadEnum(StyleValueHandle handle)
		{
			return null;
		}

		internal bool TryReadEnum(StyleValueHandle handle, out string value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal TEnum ReadEnum<TEnum>(StyleValueHandle handle) where TEnum : struct, Enum
		{
			return default(TEnum);
		}

		internal bool TryReadEnum<TEnum>(StyleValueHandle handle, out TEnum value) where TEnum : struct, Enum
		{
			value = default(TEnum);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadVariable(StyleValueHandle handle)
		{
			return null;
		}

		internal bool TryReadVariable(StyleValueHandle handle, out string value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadResourcePath(StyleValueHandle handle)
		{
			return null;
		}

		internal bool TryReadResourcePath(StyleValueHandle handle, out string value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Object ReadAssetReference(StyleValueHandle handle)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadMissingAssetReferenceUrl(StyleValueHandle handle)
		{
			return null;
		}

		internal bool TryReadMissingAssetReferenceUrl(StyleValueHandle handle, out string value)
		{
			value = null;
			return false;
		}

		internal bool TryReadAssetReference(StyleValueHandle handle, out Object value)
		{
			value = null;
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StyleValueFunction ReadFunction(StyleValueHandle handle)
		{
			return default(StyleValueFunction);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryReadFunction(StyleValueHandle handle, out StyleValueFunction value)
		{
			value = default(StyleValueFunction);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal string ReadFunctionName(StyleValueHandle handle)
		{
			return null;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal ScalableImage ReadScalableImage(StyleValueHandle handle)
		{
			return default(ScalableImage);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal bool TryReadScalableImage(StyleValueHandle handle, out ScalableImage value)
		{
			value = default(ScalableImage);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StylePropertyName ReadStylePropertyName(StyleValueHandle handle)
		{
			return default(StylePropertyName);
		}

		internal bool TryReadStylePropertyName(StyleValueHandle handle, out StylePropertyName value)
		{
			value = default(StylePropertyName);
			return false;
		}

		internal Length ReadLength(StyleValueHandle handle)
		{
			return default(Length);
		}

		internal bool TryReadLength(StyleValueHandle handle, out Length value)
		{
			value = default(Length);
			return false;
		}

		internal Angle ReadAngle(StyleValueHandle handle)
		{
			return default(Angle);
		}

		internal bool TryReadAngle(StyleValueHandle handle, out Angle value)
		{
			value = default(Angle);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal TimeValue ReadTimeValue(StyleValueHandle handle)
		{
			return default(TimeValue);
		}

		internal bool TryReadTimeValue(StyleValueHandle handle, out TimeValue value)
		{
			value = default(TimeValue);
			return false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteKeyword(ref StyleValueHandle handle, StyleValueKeyword value)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteFloat(ref StyleValueHandle handle, float value)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteDimension(ref StyleValueHandle handle, Dimension dimension)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteColor(ref StyleValueHandle handle, Color color)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteString(ref StyleValueHandle handle, string value)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteEnum<TEnum>(ref StyleValueHandle handle, TEnum value) where TEnum : Enum
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteEnumAsString(ref StyleValueHandle handle, string valueStr)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteVariable(ref StyleValueHandle handle, string variableName)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteResourcePath(ref StyleValueHandle handle, string resourcePath)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteAssetReference(ref StyleValueHandle handle, Object value)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteMissingAssetReferenceUrl(ref StyleValueHandle handle, string assetReference)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteFunction(ref StyleValueHandle handle, StyleValueFunction function)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteScalableImage(ref StyleValueHandle handle, ScalableImage scalableImage)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteStylePropertyName(ref StyleValueHandle handle, StylePropertyName propertyName)
		{
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal void WriteCommaSeparator(ref StyleValueHandle handle)
		{
		}

		internal void WriteLength(ref StyleValueHandle handle, Length value)
		{
		}

		internal void WriteAngle(ref StyleValueHandle handle, Angle value)
		{
		}

		internal void WriteTimeValue(ref StyleValueHandle handle, TimeValue value)
		{
		}

		private void MarkAsChanged()
		{
		}
	}
}
