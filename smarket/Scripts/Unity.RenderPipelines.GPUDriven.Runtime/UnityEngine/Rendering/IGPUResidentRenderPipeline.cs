namespace UnityEngine.Rendering
{
	public interface IGPUResidentRenderPipeline
	{
		GPUResidentDrawerSettings gpuResidentDrawerSettings { get; }

		GPUResidentDrawerMode gpuResidentDrawerMode { get; set; }

		static void ReinitializeGPUResidentDrawer()
		{
		}

		bool IsGPUResidentDrawerSupportedBySRP(bool logReason = false)
		{
			return false;
		}

		bool IsGPUResidentDrawerSupportedBySRP(out string message, out LogType severity)
		{
			message = null;
			severity = default(LogType);
			return false;
		}

		static bool IsGPUResidentDrawerSupportedByProjectConfiguration(bool logReason = false)
		{
			return false;
		}

		static bool IsGPUResidentDrawerEnabled()
		{
			return false;
		}
	}
}
