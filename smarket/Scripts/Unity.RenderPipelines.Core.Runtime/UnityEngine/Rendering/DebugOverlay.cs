namespace UnityEngine.Rendering
{
	public class DebugOverlay
	{
		private int m_InitialPositionX;

		private int m_ScreenWidth;

		public int x { get; private set; }

		public int y { get; private set; }

		public int overlaySize { get; private set; }

		public void StartOverlay(int initialX, int initialY, int overlaySize, int screenWidth)
		{
		}

		public Rect Next(float aspect = 1f)
		{
			return default(Rect);
		}

		public void SetViewport(CommandBuffer cmd)
		{
		}
	}
}
