using System.Runtime.CompilerServices;

namespace UnityEngine.Rendering
{
	public static class RenderPipelineGraphicsSettingsExtensions
	{
		public static void SetValueAndNotify<T>(this IRenderPipelineGraphicsSettings settings, ref T currentPropertyValue, T newValue, [CallerMemberName] string propertyName = null)
		{
		}
	}
}
