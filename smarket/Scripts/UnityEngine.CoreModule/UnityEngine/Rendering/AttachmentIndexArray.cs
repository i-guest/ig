namespace UnityEngine.Rendering
{
	public struct AttachmentIndexArray
	{
		public static AttachmentIndexArray Emtpy;

		private int a0;

		private int a1;

		private int a2;

		private int a3;

		private int a4;

		private int a5;

		private int a6;

		private int a7;

		private int activeAttachments;

		public int this[int index]
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Length => 0;

		public AttachmentIndexArray(int numAttachments)
		{
			a0 = 0;
			a1 = 0;
			a2 = 0;
			a3 = 0;
			a4 = 0;
			a5 = 0;
			a6 = 0;
			a7 = 0;
			activeAttachments = 0;
		}
	}
}
