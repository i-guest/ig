using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Rotate : IEquatable<Rotate>
	{
		internal class PropertyBag : ContainerPropertyBag<Rotate>
		{
			private class AngleProperty : Property<Rotate, Angle>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Angle GetValue(ref Rotate container)
				{
					return default(Angle);
				}

				public override void SetValue(ref Rotate container, Angle value)
				{
				}
			}

			private class AxisProperty : Property<Rotate, Vector3>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Vector3 GetValue(ref Rotate container)
				{
					return default(Vector3);
				}

				public override void SetValue(ref Rotate container, Vector3 value)
				{
				}
			}
		}

		[SerializeField]
		private Angle m_Angle;

		[SerializeField]
		private Vector3 m_Axis;

		[SerializeField]
		private bool m_IsNone;

		public Angle angle
		{
			get
			{
				return default(Angle);
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal Vector3 axis
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Rotate(Angle angle, Vector3 axis)
		{
			m_Angle = default(Angle);
			m_Axis = default(Vector3);
			m_IsNone = false;
		}

		public Rotate(Angle angle)
		{
			m_Angle = default(Angle);
			m_Axis = default(Vector3);
			m_IsNone = false;
		}

		public Rotate(Quaternion quaternion)
		{
			m_Angle = default(Angle);
			m_Axis = default(Vector3);
			m_IsNone = false;
		}

		internal static Rotate Initial()
		{
			return default(Rotate);
		}

		public static Rotate None()
		{
			return default(Rotate);
		}

		public static bool operator ==(Rotate lhs, Rotate rhs)
		{
			return false;
		}

		public static bool operator !=(Rotate lhs, Rotate rhs)
		{
			return false;
		}

		public bool Equals(Rotate other)
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

		internal Quaternion ToQuaternion()
		{
			return default(Quaternion);
		}
	}
}
