namespace UnityEngine.Localization.Tables
{
	public class SequentialIDGenerator : IKeyGenerator
	{
		[SerializeField]
		private long m_NextAvailableId;

		public long NextAvailableId => 0L;

		public SequentialIDGenerator()
		{
		}

		public SequentialIDGenerator(long startingId)
		{
		}

		public long GetNextKey()
		{
			return 0L;
		}
	}
}
