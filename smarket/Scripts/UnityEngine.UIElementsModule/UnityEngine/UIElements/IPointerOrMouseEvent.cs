namespace UnityEngine.UIElements
{
	internal interface IPointerOrMouseEvent
	{
		Vector3 position { get; }

		Vector3 deltaPosition { set; }
	}
}
