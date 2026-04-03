namespace UnityEngine.Rendering.Universal
{
	public struct PostProcessingData
	{
		private ContextContainer frameData;

		internal UniversalPostProcessingData universalPostProcessingData => null;

		public ref ColorGradingMode gradingMode
		{
			get
			{
				throw null;
			}
		}

		public ref int lutSize
		{
			get
			{
				throw null;
			}
		}

		public ref bool useFastSRGBLinearConversion
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportScreenSpaceLensFlare
		{
			get
			{
				throw null;
			}
		}

		public ref bool supportDataDrivenLensFlare
		{
			get
			{
				throw null;
			}
		}

		internal PostProcessingData(ContextContainer frameData)
		{
			this.frameData = null;
		}
	}
}
