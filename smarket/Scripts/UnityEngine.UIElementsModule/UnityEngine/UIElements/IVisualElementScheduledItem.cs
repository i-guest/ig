using System;

namespace UnityEngine.UIElements
{
	public interface IVisualElementScheduledItem
	{
		bool isActive { get; }

		void Resume();

		void Pause();

		void ExecuteLater(long delayMs);

		IVisualElementScheduledItem StartingIn(long delayMs);

		IVisualElementScheduledItem Every(long intervalMs);

		IVisualElementScheduledItem Until(Func<bool> stopCondition);
	}
}
