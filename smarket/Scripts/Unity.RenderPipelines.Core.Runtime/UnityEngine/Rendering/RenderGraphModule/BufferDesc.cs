namespace UnityEngine.Rendering.RenderGraphModule
{
	public struct BufferDesc
	{
		public int count;

		public int stride;

		public string name;

		public GraphicsBuffer.Target target;

		public GraphicsBuffer.UsageFlags usageFlags;

		public BufferDesc(int count, int stride)
		{
			this.count = 0;
			this.stride = 0;
			name = null;
			target = default(GraphicsBuffer.Target);
			usageFlags = default(GraphicsBuffer.UsageFlags);
		}

		public BufferDesc(int count, int stride, GraphicsBuffer.Target target)
		{
			this.count = 0;
			this.stride = 0;
			name = null;
			this.target = default(GraphicsBuffer.Target);
			usageFlags = default(GraphicsBuffer.UsageFlags);
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
