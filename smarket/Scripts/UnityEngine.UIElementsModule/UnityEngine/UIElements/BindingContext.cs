using Unity.Properties;

namespace UnityEngine.UIElements
{
	public readonly struct BindingContext
	{
		private readonly VisualElement m_TargetElement;

		private readonly BindingId m_BindingId;

		private readonly PropertyPath m_DataSourcePath;

		private readonly object m_DataSource;

		public VisualElement targetElement => null;

		public BindingId bindingId => default(BindingId);

		public PropertyPath dataSourcePath => default(PropertyPath);

		public object dataSource => null;

		internal BindingContext(VisualElement targetElement, in BindingId bindingId, in PropertyPath resolvedDataSourcePath, object resolvedDataSource)
		{
			m_TargetElement = null;
			m_BindingId = default(BindingId);
			m_DataSourcePath = default(PropertyPath);
			m_DataSource = null;
		}
	}
}
