using System;
using Unity.Properties;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct PostProcessingMargins
	{
		[DontCreateProperty]
		[SerializeField]
		private float m_Left;

		[DontCreateProperty]
		[SerializeField]
		private float m_Top;

		[DontCreateProperty]
		[SerializeField]
		private float m_Right;

		[SerializeField]
		[DontCreateProperty]
		private float m_Bottom;

		[CreateProperty]
		public float left
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float top
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float right
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[CreateProperty]
		public float bottom
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}
	}
}
