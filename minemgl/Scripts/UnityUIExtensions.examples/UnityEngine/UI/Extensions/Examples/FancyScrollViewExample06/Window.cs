namespace UnityEngine.UI.Extensions.Examples.FancyScrollViewExample06
{
	internal class Window : MonoBehaviour
	{
		[SerializeField]
		private SlideScreenTransition transition;

		public void In(MovementDirection direction)
		{
			transition?.In(direction);
		}

		public void Out(MovementDirection direction)
		{
			transition?.Out(direction);
		}
	}
}
