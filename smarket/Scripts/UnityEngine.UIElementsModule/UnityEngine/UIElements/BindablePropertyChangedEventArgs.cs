namespace UnityEngine.UIElements
{
	public readonly struct BindablePropertyChangedEventArgs
	{
		private readonly BindingId m_PropertyName;

		public BindingId propertyName => default(BindingId);

		public BindablePropertyChangedEventArgs(in BindingId propertyName)
		{
			m_PropertyName = default(BindingId);
		}
	}
}
