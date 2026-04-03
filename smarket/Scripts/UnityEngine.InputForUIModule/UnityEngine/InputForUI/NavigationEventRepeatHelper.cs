using Unity.IntegerTime;

namespace UnityEngine.InputForUI
{
	internal class NavigationEventRepeatHelper
	{
		private int m_ConsecutiveMoveCount;

		private NavigationEvent.Direction m_LastDirection;

		private DiscreteTime m_PrevActionTime;

		private readonly DiscreteTime m_InitialRepeatDelay;

		private readonly DiscreteTime m_ConsecutiveRepeatDelay;

		public void Reset()
		{
		}

		public bool ShouldSendMoveEvent(DiscreteTime timestamp, NavigationEvent.Direction direction, bool axisButtonsWherePressedThisFrame)
		{
			return false;
		}
	}
}
