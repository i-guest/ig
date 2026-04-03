namespace UnityEngine.Rendering.Universal
{
	internal struct ShadowEdge
	{
		public int v0;

		public int v1;

		public ShadowEdge(int indexA, int indexB)
		{
			v0 = 0;
			v1 = 0;
		}

		public void Reverse()
		{
		}
	}
}
