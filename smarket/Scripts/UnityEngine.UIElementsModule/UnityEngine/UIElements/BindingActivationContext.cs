namespace UnityEngine.UIElements
{
	public readonly struct BindingActivationContext
	{
		private readonly VisualElement m_TargetElement;

		private readonly BindingId m_BindingId;

		internal BindingActivationContext(VisualElement element, in BindingId property)
		{
			m_TargetElement = null;
			m_BindingId = default(BindingId);
		}
	}
}
