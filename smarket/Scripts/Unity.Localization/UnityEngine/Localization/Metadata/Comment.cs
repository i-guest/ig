using System;

namespace UnityEngine.Localization.Metadata
{
	[Serializable]
	[Metadata]
	public class Comment : IMetadata
	{
		[SerializeField]
		[TextArea(1, 2147483647)]
		private string m_CommentText;

		public string CommentText
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override string ToString()
		{
			return null;
		}
	}
}
