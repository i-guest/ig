using System;

namespace UnityEngine.UIElements.Layout
{
	internal struct LayoutNodeData
	{
		[Flags]
		internal enum FlexStatus
		{
			IsDirty = 1,
			HasNewLayout = 4,
			DependsOnParentSize = 0x40,
			UsesMeasure = 0x80,
			UsesBaseline = 0x100,
			Fixed = 8,
			MinViolation = 0x10,
			MaxViolation = 0x20
		}

		public FixedBuffer2<LayoutValue> ResolvedDimensions;

		private float TargetSize;

		public int ManagedOwnerIndex;

		public int LineIndex;

		public LayoutHandle Config;

		public LayoutHandle Parent;

		public LayoutHandle NextChild;

		public LayoutList<LayoutHandle> Children;

		private FlexStatus Status;

		public bool HasNewLayout
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool IsDirty
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UsesMeasure
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool UsesBaseline
		{
			set
			{
			}
		}
	}
}
