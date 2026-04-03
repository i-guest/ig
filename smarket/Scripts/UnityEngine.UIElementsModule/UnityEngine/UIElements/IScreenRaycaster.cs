using System.Collections.Generic;

namespace UnityEngine.UIElements
{
	internal interface IScreenRaycaster
	{
		void Update();

		IEnumerable<(Ray, Camera, bool)> MakeRay(Vector2 mousePosition, int pointerId, int? targetDisplay);
	}
}
