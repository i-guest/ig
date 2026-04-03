namespace UnityEngine.Rendering.Universal
{
	internal struct ShaderBitArray
	{
		private const int k_BitsPerElement = 32;

		private const int k_ElementShift = 5;

		private const int k_ElementMask = 31;

		private float[] m_Data;

		public int elemLength => 0;

		public int bitCapacity => 0;

		public float[] data => null;

		public bool this[int index]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public void Resize(int bitCount)
		{
		}

		public void Clear()
		{
		}

		private void GetElementIndexAndBitOffset(int index, out int elemIndex, out int bitOffset)
		{
			elemIndex = default(int);
			bitOffset = default(int);
		}

		public override string ToString()
		{
			return null;
		}
	}
}
