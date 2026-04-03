namespace UnityEngine.UIElements
{
	public readonly struct DataSourceContextChanged
	{
		private readonly VisualElement m_TargetElement;

		private readonly BindingId m_BindingId;

		private readonly DataSourceContext m_PreviousContext;

		private readonly DataSourceContext m_NewContext;

		internal DataSourceContextChanged(VisualElement element, in BindingId bindingId, in DataSourceContext previousContext, in DataSourceContext newContext)
		{
			m_TargetElement = null;
			m_BindingId = default(BindingId);
			m_PreviousContext = default(DataSourceContext);
			m_NewContext = default(DataSourceContext);
		}
	}
}
