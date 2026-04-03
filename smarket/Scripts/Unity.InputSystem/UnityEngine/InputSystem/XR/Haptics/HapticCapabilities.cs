namespace UnityEngine.InputSystem.XR.Haptics
{
	public struct HapticCapabilities
	{
		public uint numChannels { get; }

		public bool supportsImpulse { get; }

		public bool supportsBuffer { get; }

		public uint frequencyHz { get; }

		public uint maxBufferSize { get; }

		public uint optimalBufferSize { get; }

		public HapticCapabilities(uint numChannels, bool supportsImpulse, bool supportsBuffer, uint frequencyHz, uint maxBufferSize, uint optimalBufferSize)
		{
			this.numChannels = 0u;
			this.supportsImpulse = false;
			this.supportsBuffer = false;
			this.frequencyHz = 0u;
			this.maxBufferSize = 0u;
			this.optimalBufferSize = 0u;
		}

		public HapticCapabilities(uint numChannels, uint frequencyHz, uint maxBufferSize)
		{
			this.numChannels = 0u;
			supportsImpulse = false;
			supportsBuffer = false;
			this.frequencyHz = 0u;
			this.maxBufferSize = 0u;
			optimalBufferSize = 0u;
		}
	}
}
