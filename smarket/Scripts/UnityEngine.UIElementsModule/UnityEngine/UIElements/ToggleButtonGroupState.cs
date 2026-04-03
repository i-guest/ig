using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct ToggleButtonGroupState : IEquatable<ToggleButtonGroupState>, IComparable<ToggleButtonGroupState>
	{
		[SerializeField]
		private ulong m_Data;

		[SerializeField]
		private int m_Length;

		public int length
		{
			get
			{
				return 0;
			}
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			internal set
			{
			}
		}

		internal ulong data => 0uL;

		public bool this[int index]
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public ToggleButtonGroupState(ulong optionsBitMask, int length)
		{
			m_Data = 0uL;
			m_Length = 0;
		}

		public Span<int> GetActiveOptions(Span<int> activeOptionsIndices)
		{
			return default(Span<int>);
		}

		public void ResetAllOptions()
		{
		}

		public int CompareTo(ToggleButtonGroupState other)
		{
			return 0;
		}

		private void ResetOptions(int startingIndex)
		{
		}

		public static bool operator ==(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs)
		{
			return false;
		}

		public static bool operator !=(ToggleButtonGroupState lhs, ToggleButtonGroupState rhs)
		{
			return false;
		}

		public bool Equals(ToggleButtonGroupState other)
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

		public override string ToString()
		{
			return null;
		}
	}
}
