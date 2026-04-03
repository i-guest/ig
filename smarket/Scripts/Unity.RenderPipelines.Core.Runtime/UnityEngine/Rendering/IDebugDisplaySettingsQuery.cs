namespace UnityEngine.Rendering
{
	public interface IDebugDisplaySettingsQuery
	{
		bool AreAnySettingsActive { get; }

		bool IsPostProcessingAllowed => false;

		bool IsLightingActive => false;

		bool TryGetScreenClearColor(ref Color color)
		{
			return false;
		}
	}
}
