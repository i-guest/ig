namespace Steamworks.Data
{
	public struct Image
	{
		public uint Width;

		public uint Height;

		public byte[] Data;

		public Color GetPixel(int x, int y)
		{
			return default(Color);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
