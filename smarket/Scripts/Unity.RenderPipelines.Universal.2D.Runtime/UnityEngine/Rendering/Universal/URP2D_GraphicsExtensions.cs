namespace UnityEngine.Rendering.Universal
{
	public static class URP2D_GraphicsExtensions
	{
		public static SpriteMaskInteraction GetSpriteMaskInteraction(this MeshRenderer meshRenderer)
		{
			return default(SpriteMaskInteraction);
		}

		public static SpriteMaskInteraction GetSpriteMaskInteraction(this SkinnedMeshRenderer skinnedMeshRenderer)
		{
			return default(SpriteMaskInteraction);
		}

		public static void SetSpriteMaskInteraction(this MeshRenderer meshRenderer, SpriteMaskInteraction maskInteraction)
		{
		}

		public static void SetSpriteMaskInteraction(this SkinnedMeshRenderer skinnedMeshRenderer, SpriteMaskInteraction maskInteraction)
		{
		}
	}
}
