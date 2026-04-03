using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.UIR
{
	internal class TextureSlotManager
	{
		internal static readonly int k_MaxSlotCount;

		internal static readonly int k_SlotSize;

		internal static int[] slotIds;

		internal static readonly int textureTableId;

		private TextureId[] m_Textures;

		private int[] m_LastUseTime;

		private int m_CurrentTime;

		private int m_BatchTime;

		private Vector4[] m_GpuTextures;

		private int m_SlotCount;

		internal TextureRegistry textureRegistry;

		public int FreeSlots { get; private set; }

		static TextureSlotManager()
		{
		}

		public void Reset()
		{
		}

		private void Unbind(int first, int count = 1)
		{
		}

		public void StartNewBatch(int slotCount)
		{
		}

		public int IndexOf(TextureId id)
		{
			return 0;
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public void MarkUsed(int slotIndex)
		{
		}

		public int FindOldestSlot()
		{
			return 0;
		}

		public void Bind(TextureId id, float sdfScale, float sharpness, bool isPremultiplied, int slot, MaterialPropertyBlock mat, CommandList commandList = null)
		{
		}

		public void SetGpuData(int slotIndex, TextureId id, int textureWidth, int textureHeight, float sdfScale, float sharpness, bool isPremultiplied)
		{
		}
	}
}
