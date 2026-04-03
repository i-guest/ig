using Unity.Collections;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	public struct FixedAttachmentArray<DataType> where DataType : struct
	{
		public static FixedAttachmentArray<DataType> Empty;

		public const int MaxAttachments = 8;

		private DataType a0;

		private DataType a1;

		private DataType a2;

		private DataType a3;

		private DataType a4;

		private DataType a5;

		private DataType a6;

		private DataType a7;

		private int activeAttachments;

		public int size => 0;

		public ref DataType this[int index]
		{
			get
			{
				throw null;
			}
		}

		public FixedAttachmentArray(int numAttachments)
		{
			a0 = default(DataType);
			a1 = default(DataType);
			a2 = default(DataType);
			a3 = default(DataType);
			a4 = default(DataType);
			a5 = default(DataType);
			a6 = default(DataType);
			a7 = default(DataType);
			activeAttachments = 0;
		}

		public FixedAttachmentArray(DataType[] attachments)
		{
			a0 = default(DataType);
			a1 = default(DataType);
			a2 = default(DataType);
			a3 = default(DataType);
			a4 = default(DataType);
			a5 = default(DataType);
			a6 = default(DataType);
			a7 = default(DataType);
			activeAttachments = 0;
		}

		public FixedAttachmentArray(NativeArray<DataType> attachments)
		{
			a0 = default(DataType);
			a1 = default(DataType);
			a2 = default(DataType);
			a3 = default(DataType);
			a4 = default(DataType);
			a5 = default(DataType);
			a6 = default(DataType);
			a7 = default(DataType);
			activeAttachments = 0;
		}

		public void Clear()
		{
		}

		public int Add(in DataType data)
		{
			return 0;
		}
	}
}
