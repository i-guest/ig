namespace UnityEngine.Rendering.Universal
{
	public class UniversalPostProcessingData : ContextItem
	{
		public bool isEnabled;

		public ColorGradingMode gradingMode;

		public int lutSize;

		public bool useFastSRGBLinearConversion;

		public bool supportScreenSpaceLensFlare;

		public bool supportDataDrivenLensFlare;

		public override void Reset()
		{
		}
	}
}
