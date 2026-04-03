using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UIElements
{
	[AddComponentMenu("UI Toolkit/World Document Raycaster (UI Toolkit)")]
	public class WorldDocumentRaycaster : BaseRaycaster
	{
		[SerializeField]
		private Camera m_EventCamera;

		private static PhysicsDocumentPicker worldPicker;

		public override Camera eventCamera => null;

		public Camera camera
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void Raycast(PointerEventData eventData, List<RaycastResult> resultAppendList)
		{
		}

		protected virtual bool GetWorldRay(PointerEventData eventData, out Ray worldRay, out float maxDistance, out int layerMask)
		{
			worldRay = default(Ray);
			maxDistance = default(float);
			layerMask = default(int);
			return false;
		}
	}
}
