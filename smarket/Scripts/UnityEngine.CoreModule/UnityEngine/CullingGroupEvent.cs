namespace UnityEngine
{
	public struct CullingGroupEvent
	{
		private int m_Index;

		private byte m_PrevState;

		private byte m_ThisState;

		public int index => 0;

		public int currentDistance => 0;

		public int previousDistance => 0;
	}
}
