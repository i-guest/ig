using System;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine.Rendering.RenderGraphModule
{
	internal class DebugMessageHandler : ScriptableObject
	{
		public enum MessageType : byte
		{
			Activate = 0,
			DebugData = 1,
			AnalyticsData = 2
		}

		public abstract class IPayload
		{
			public int version;

			public bool isCompatible => false;
		}

		public class DebugDataPayload : IPayload
		{
			public string graphName;

			public EntityId executionId;

			public RenderGraph.DebugData debugData;
		}

		public class AnalyticsPayload : IPayload
		{
			public GraphicsDeviceType graphicsDeviceType;

			public DeviceType deviceType;

			public string deviceModel;

			public string gpuVendor;

			public string gpuName;
		}

		internal const int k_Version = 1;

		private static readonly Guid s_EditorToPlayerGuid;

		private static readonly Guid s_PlayerToEditorGuid;

		private Action<MessageType, IPayload> m_UserCallback;

		private void InternalCallback(MessageEventArgs msg)
		{
		}

		public void Register(Action<MessageType, IPayload> callback)
		{
		}

		public void UnregisterAll()
		{
		}

		public void Send(MessageType messageType, IPayload payload = null)
		{
		}

		internal static byte[] SerializeMessage(MessageType type, IPayload payload = null)
		{
			return null;
		}

		internal static (MessageType, IPayload) DeserializeMessage(byte[] data)
		{
			return default((MessageType, IPayload));
		}
	}
}
