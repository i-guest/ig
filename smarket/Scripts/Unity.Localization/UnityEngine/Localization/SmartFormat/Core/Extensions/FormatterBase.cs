namespace UnityEngine.Localization.SmartFormat.Core.Extensions
{
	public abstract class FormatterBase : IFormatter, ISerializationCallbackReceiver
	{
		[SerializeField]
		private string[] m_Names;

		public string[] Names
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string[] DefaultNames { get; }

		public abstract bool TryEvaluateFormat(IFormattingInfo formattingInfo);

		public virtual void OnAfterDeserialize()
		{
		}

		public void OnBeforeSerialize()
		{
		}
	}
}
