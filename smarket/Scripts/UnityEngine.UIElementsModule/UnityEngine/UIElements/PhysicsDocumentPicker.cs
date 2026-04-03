namespace UnityEngine.UIElements
{
	internal class PhysicsDocumentPicker
	{
		private void Pick(Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement pickedElement, out float distance)
		{
			collider = null;
			document = null;
			pickedElement = null;
			distance = default(float);
		}

		public bool TryPickWithCapture(int pointerId, Ray worldRay, float maxDistance, int layerMask, out Collider collider, out UIDocument document, out VisualElement elementUnderPointer, out float distance, out bool captured)
		{
			collider = null;
			document = null;
			elementUnderPointer = null;
			distance = default(float);
			captured = default(bool);
			return false;
		}

		private bool GetCapturingDocument(int pointerId, out UIDocument capturingDocument)
		{
			capturingDocument = null;
			return false;
		}
	}
}
