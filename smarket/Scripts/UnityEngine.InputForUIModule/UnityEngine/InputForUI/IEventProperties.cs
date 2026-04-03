namespace UnityEngine.InputForUI
{
	internal interface IEventProperties
	{
		EventSource eventSource { get; }

		EventModifiers eventModifiers { get; }
	}
}
