using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace UnityEngine.UIElements.Layout
{
	[DefaultMember("Item")]
	internal struct LayoutNode : IEquatable<LayoutNode>
	{
		private const int k_DefaultChildCapacity = 4;

		private readonly LayoutDataAccess m_Access;

		private readonly LayoutHandle m_Handle;

		public float LayoutX => 0f;

		public float LayoutY => 0f;

		public float LayoutRight => 0f;

		public float LayoutBottom => 0f;

		public float LayoutWidth => 0f;

		public float LayoutHeight => 0f;

		public float LayoutMarginLeft => 0f;

		public float LayoutMarginTop => 0f;

		public float LayoutMarginRight => 0f;

		public float LayoutMarginBottom => 0f;

		public float LayoutPaddingLeft => 0f;

		public float LayoutPaddingTop => 0f;

		public float LayoutPaddingRight => 0f;

		public float LayoutPaddingBottom => 0f;

		public float LayoutBorderLeft => 0f;

		public float LayoutBorderTop => 0f;

		public float LayoutBorderRight => 0f;

		public float LayoutBorderBottom => 0f;

		public float ComputedFlexBasis => 0f;

		public LayoutNode Parent
		{
			get
			{
				return default(LayoutNode);
			}
			set
			{
			}
		}

		private LayoutList<LayoutHandle> Children => default(LayoutList<LayoutHandle>);

		public int Count => 0;

		public LayoutFlexDirection FlexDirection
		{
			set
			{
			}
		}

		public LayoutJustify JustifyContent
		{
			set
			{
			}
		}

		public LayoutDisplay Display
		{
			set
			{
			}
		}

		public LayoutAlign AlignItems
		{
			set
			{
			}
		}

		public LayoutAlign AlignSelf
		{
			set
			{
			}
		}

		public LayoutAlign AlignContent
		{
			set
			{
			}
		}

		public LayoutPositionType PositionType
		{
			set
			{
			}
		}

		public LayoutWrap Wrap
		{
			set
			{
			}
		}

		public float FlexGrow
		{
			set
			{
			}
		}

		public float FlexShrink
		{
			set
			{
			}
		}

		public LayoutValue FlexBasis
		{
			set
			{
			}
		}

		public LayoutValue Width
		{
			set
			{
			}
		}

		public LayoutValue Height
		{
			set
			{
			}
		}

		public LayoutValue MaxWidth
		{
			set
			{
			}
		}

		public LayoutValue MaxHeight
		{
			set
			{
			}
		}

		public LayoutValue MinWidth
		{
			set
			{
			}
		}

		public LayoutValue MinHeight
		{
			set
			{
			}
		}

		public float AspectRatio
		{
			set
			{
			}
		}

		public LayoutOverflow Overflow
		{
			set
			{
			}
		}

		public LayoutValue Left
		{
			set
			{
			}
		}

		public LayoutValue Top
		{
			set
			{
			}
		}

		public LayoutValue Right
		{
			set
			{
			}
		}

		public LayoutValue Bottom
		{
			set
			{
			}
		}

		public LayoutValue MarginLeft
		{
			set
			{
			}
		}

		public LayoutValue MarginTop
		{
			set
			{
			}
		}

		public LayoutValue MarginRight
		{
			set
			{
			}
		}

		public LayoutValue MarginBottom
		{
			set
			{
			}
		}

		public LayoutValue PaddingLeft
		{
			set
			{
			}
		}

		public LayoutValue PaddingTop
		{
			set
			{
			}
		}

		public LayoutValue PaddingRight
		{
			set
			{
			}
		}

		public LayoutValue PaddingBottom
		{
			set
			{
			}
		}

		public float BorderLeftWidth
		{
			set
			{
			}
		}

		public float BorderTopWidth
		{
			set
			{
			}
		}

		public float BorderRightWidth
		{
			set
			{
			}
		}

		public float BorderBottomWidth
		{
			set
			{
			}
		}

		public static LayoutNode Undefined => default(LayoutNode);

		public bool IsUndefined => false;

		public LayoutHandle Handle => default(LayoutHandle);

		public ref LayoutComputedData Layout
		{
			get
			{
				throw null;
			}
		}

		public ref LayoutStyleData Style
		{
			get
			{
				throw null;
			}
		}

		internal ref LayoutCacheData Cache
		{
			get
			{
				throw null;
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

		public LayoutConfig Config
		{
			get
			{
				return default(LayoutConfig);
			}
			set
			{
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe float GetLayoutValue(float* buffer, LayoutEdge edge)
		{
			return 0f;
		}

		public void Insert(int index, LayoutNode child)
		{
		}

		public void RemoveAt(int index)
		{
		}

		public void Clear()
		{
		}

		private void SetValue(ref float currentValue, float newValue)
		{
		}

		private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue)
		{
		}

		private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue)
		{
		}

		private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue)
		{
		}

		private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue)
		{
		}

		private void SetStyleValueAuto(ref LayoutValue currentValue)
		{
		}

		private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value)
		{
		}

		private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value)
		{
		}

		private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value)
		{
		}

		private void StyleEdgeSetPercent(ref LayoutValue value, float newValue)
		{
		}

		private void StyleEdgeSetAuto(ref LayoutValue value)
		{
		}

		private void StyleEdgeSetPoint(ref LayoutValue value, float newValue)
		{
		}

		internal LayoutNode(LayoutDataAccess access, LayoutHandle handle)
		{
			m_Access = default(LayoutDataAccess);
			m_Handle = default(LayoutHandle);
		}

		public void SetOwner(VisualElement func)
		{
		}

		public VisualElement GetOwner()
		{
			return null;
		}

		public void MarkDirty()
		{
		}

		public void MarkLayoutSeen()
		{
		}

		public void CopyFromComputedStyle(ComputedStyle style)
		{
		}

		public void SoftReset()
		{
		}

		public bool Equals(LayoutNode other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public static bool operator ==(LayoutNode lhs, LayoutNode rhs)
		{
			return false;
		}

		public static bool operator !=(LayoutNode lhs, LayoutNode rhs)
		{
			return false;
		}

		public void CalculateLayout(float width = 0f / 0f, float height = 0f / 0f)
		{
		}
	}
}
