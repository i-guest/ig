namespace Steamworks.Data
{
	internal struct NumericalFilter
	{
		public string Key { get; internal set; }

		public int Value { get; internal set; }

		public LobbyComparison Comparer { get; internal set; }

		internal NumericalFilter(string k, int v, LobbyComparison c)
		{
			Key = null;
			Value = 0;
			Comparer = default(LobbyComparison);
		}
	}
}
