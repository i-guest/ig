using UnityEngine.EventSystems;

namespace UnityEngine.InputSystem.UI
{
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.inputsystem@1.18/manual/UISupport.html#multiplayer-uis")]
	public class MultiplayerEventSystem : EventSystem
	{
		[Tooltip("If set, only process mouse and navigation events for any game objects which are children of this game object.")]
		[SerializeField]
		private GameObject m_PlayerRoot;

		public GameObject playerRoot
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDisable()
		{
		}

		private void InitializePlayerRoot()
		{
		}

		protected override void Update()
		{
		}
	}
}
