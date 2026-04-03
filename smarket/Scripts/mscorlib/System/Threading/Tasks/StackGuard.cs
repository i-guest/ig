namespace System.Threading.Tasks
{
	internal class StackGuard
	{
		private int m_inliningDepth;

		internal bool TryBeginInliningScope()
		{
			return false;
		}

		internal void EndInliningScope()
		{
		}
	}
}
