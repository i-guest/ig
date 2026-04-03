using System;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct Scale : IEquatable<Scale>
	{
		internal class PropertyBag : ContainerPropertyBag<Scale>
		{
			private class ValueProperty : Property<Scale, Vector3>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Vector3 GetValue(ref Scale container)
				{
					return default(Vector3);
				}

				public override void SetValue(ref Scale container, Vector3 value)
				{
				}
			}
		}

		[SerializeField]
		private Vector3 m_Scale;

		[SerializeField]
		private bool m_IsNone;

		public Vector3 value
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Scale(Vector3 scale)
		{
			m_Scale = default(Vector3);
			m_IsNone = false;
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static Scale Initial()
		{
			return default(Scale);
		}

		public static Scale None()
		{
			return default(Scale);
		}

		public static bool operator ==(Scale lhs, Scale rhs)
		{
			return false;
		}

		public static bool operator !=(Scale lhs, Scale rhs)
		{
			return false;
		}

		public bool Equals(Scale other)
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
