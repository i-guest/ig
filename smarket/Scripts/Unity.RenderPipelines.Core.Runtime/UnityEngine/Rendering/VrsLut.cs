using System;

namespace UnityEngine.Rendering
{
	[Serializable]
	public class VrsLut
	{
		[SerializeField]
		private Color[] m_Data;

		private const uint Rate1x = 0u;

		private const uint Rate2x = 1u;

		private const uint Rate4x = 2u;

		public Color this[ShadingRateFragmentSize fragmentSize]
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public static VrsLut CreateDefault()
		{
			return null;
		}

		public GraphicsBuffer CreateBuffer(bool forVisualization = false)
		{
			return null;
		}

		private uint MapFragmentShadingRateToBinary(ShadingRateFragmentSize fs)
		{
			return 0u;
		}

		private uint EncodeShadingRate(uint x, uint y)
		{
			return 0u;
		}
	}
}
