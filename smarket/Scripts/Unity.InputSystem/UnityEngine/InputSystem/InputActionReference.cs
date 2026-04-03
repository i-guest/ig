using System;

namespace UnityEngine.InputSystem
{
	public class InputActionReference : ScriptableObject
	{
		[SerializeField]
		internal InputActionAsset m_Asset;

		[SerializeField]
		internal string m_ActionId;

		[NonSerialized]
		private InputAction m_Action;

		public InputActionAsset asset => null;

		public InputAction action => null;

		public void Set(InputAction action)
		{
		}

		public void Set(InputActionAsset asset, string mapName, string actionName)
		{
		}

		private void SetInternal(InputActionAsset assetArg, InputAction actionArg)
		{
		}

		public override string ToString()
		{
			return null;
		}

		private static string GetDisplayName(InputAction action)
		{
			return null;
		}

		internal string ToDisplayName()
		{
			return null;
		}

		public static implicit operator InputAction(InputActionReference reference)
		{
			return null;
		}

		public static InputActionReference Create(InputAction action)
		{
			return null;
		}

		internal static void InvalidateAll()
		{
		}

		internal void Invalidate()
		{
		}

		public InputAction ToInputAction()
		{
			return null;
		}

		private void CheckImmutableReference()
		{
		}
	}
}
