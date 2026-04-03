namespace UnityEngine.UIElements
{
	public readonly struct BindingResult
	{
		public BindingStatus status { get; }

		public string message { get; }

		public BindingResult(BindingStatus status, string message = null)
		{
			this.status = default(BindingStatus);
			this.message = null;
		}
	}
}
