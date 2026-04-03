using System;

namespace UnityEngine.UIElements
{
	internal static class PointerDeviceState
	{
		[Flags]
		internal enum LocationFlag
		{
			None = 0,
			OutsidePanel = 1
		}

		private struct PointerLocation
		{
			internal Vector3 Position { get; private set; }

			internal IPanel Panel { get; private set; }

			internal LocationFlag Flags { get; private set; }

			internal void SetLocation(Vector3 position, IPanel panel)
			{
			}
		}

		public class RuntimePointerState
		{
			public struct RaycastHit
			{
				public float distance;

				public Collider collider;

				public UIDocument document;

				public VisualElement element;
			}

			public RaycastHit hit;

			public int updateFrameCount;

			public virtual void Reset()
			{
			}
		}

		public class ScreenPointerState : RuntimePointerState
		{
			public Vector2 mousePosition;

			public int? targetDisplay;

			public override void Reset()
			{
			}
		}

		public class TrackedPointerState : RuntimePointerState
		{
			public Vector3 worldPosition;

			public Quaternion worldOrientation;

			public float maxDistance;

			public Ray worldRay => default(Ray);

			public override void Reset()
			{
			}
		}

		private static RuntimePointerState[] s_RuntimePointerStates;

		private static PointerLocation[] s_PlayerPointerLocations;

		private static int[] s_PressedButtons;

		private static readonly RuntimePanel[] s_PlayerPanelWithSoftPointerCapture;

		private static readonly UIDocument[] s_WorldSpaceDocumentWithSoftPointerCapture;

		private static readonly Camera[] s_CameraWithSoftPointerCapture;

		internal static void RemovePanelData(IPanel panel)
		{
		}

		internal static void RemoveDocumentData(UIDocument document)
		{
		}

		public static void SavePointerPosition(int pointerId, Vector3 position, IPanel panel, ContextType contextType)
		{
		}

		public static void PressButton(int pointerId, int buttonId)
		{
		}

		public static void ReleaseButton(int pointerId, int buttonId)
		{
		}

		public static void ReleaseAllButtons(int pointerId)
		{
		}

		public static Vector3 GetPointerPosition(int pointerId, ContextType contextType)
		{
			return default(Vector3);
		}

		public static Vector3 GetPointerDeltaPosition(int pointerId, ContextType contextType, Vector3 newPosition)
		{
			return default(Vector3);
		}

		public static IPanel GetPanel(int pointerId, ContextType contextType)
		{
			return null;
		}

		private static bool HasFlagFast(LocationFlag flagSet, LocationFlag flag)
		{
			return false;
		}

		public static bool HasLocationFlag(int pointerId, ContextType contextType, LocationFlag flag)
		{
			return false;
		}

		public static int GetPressedButtons(int pointerId)
		{
			return 0;
		}

		internal static bool HasAdditionalPressedButtons(int pointerId, int exceptButtonId)
		{
			return false;
		}

		internal static RuntimePanel GetPlayerPanelWithSoftPointerCapture(int pointerId)
		{
			return null;
		}

		internal static UIDocument GetWorldSpaceDocumentWithSoftPointerCapture(int pointerId)
		{
			return null;
		}

		internal static Camera GetCameraWithSoftPointerCapture(int pointerId)
		{
			return null;
		}

		internal static void SetElementWithSoftPointerCapture(int pointerId, VisualElement element, Camera camera)
		{
		}

		internal static TrackedPointerState GetTrackedState(int pointerId, bool createIfNull = false)
		{
			return null;
		}

		internal static void RemoveTrackedState(int pointerId)
		{
		}

		internal static ScreenPointerState GetScreenPointerState(int pointerId, bool createIfNull = false)
		{
			return null;
		}
	}
}
