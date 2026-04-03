using System;
using System.Reflection;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[UxmlObject]
	public class DataBinding : Binding, IDataSourceProvider
	{
		private static MethodInfo s_UpdateUIMethodInfo;

		private BindingMode m_BindingMode;

		private ConverterGroup m_SourceToUiConverters;

		private ConverterGroup m_UiToSourceConverters;

		internal static MethodInfo updateUIMethod => null;

		[CreateProperty]
		public object dataSource { get; set; }

		public Type dataSourceType { get; set; }

		[CreateProperty]
		public PropertyPath dataSourcePath { get; set; }

		[CreateProperty]
		public BindingMode bindingMode
		{
			get
			{
				return default(BindingMode);
			}
			set
			{
			}
		}

		[CreateProperty(ReadOnly = true)]
		public ConverterGroup sourceToUiConverters => null;

		[CreateProperty(ReadOnly = true)]
		public ConverterGroup uiToSourceConverters => null;

		private static MethodInfo CacheReflectionInfo()
		{
			return null;
		}

		public void ApplyConverterGroupToSource(ConverterGroup group)
		{
		}

		public void ApplyConverterGroupToUI(ConverterGroup group)
		{
		}

		protected internal virtual BindingResult UpdateUI<TValue>(in BindingContext context, ref TValue value)
		{
			return default(BindingResult);
		}

		protected internal virtual BindingResult UpdateSource<TValue>(in BindingContext context, ref TValue value)
		{
			return default(BindingResult);
		}

		internal static string GetSetValueErrorString<TValue>(VisitReturnCode returnCode, object source, in PropertyPath sourcePath, object target, in BindingId targetPath, TValue extractedValueFromSource)
		{
			return null;
		}
	}
}
