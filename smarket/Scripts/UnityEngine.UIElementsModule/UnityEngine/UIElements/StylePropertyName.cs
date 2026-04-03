using System;
using Unity.Properties;
using UnityEngine.Bindings;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements
{
	public struct StylePropertyName : IEquatable<StylePropertyName>
	{
		internal class PropertyBag : ContainerPropertyBag<StylePropertyName>
		{
			private class IdProperty : Property<StylePropertyName, StylePropertyId>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override StylePropertyId GetValue(ref StylePropertyName container)
				{
					return default(StylePropertyId);
				}

				public override void SetValue(ref StylePropertyName container, StylePropertyId value)
				{
				}
			}

			private class NameProperty : Property<StylePropertyName, string>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override string GetValue(ref StylePropertyName container)
				{
					return null;
				}

				public override void SetValue(ref StylePropertyName container, string value)
				{
				}
			}
		}

		internal StylePropertyId id
		{
			[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
			get;
		}

		private string name { get; }

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal static StylePropertyId StylePropertyIdFromString(string name)
		{
			return default(StylePropertyId);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal StylePropertyName(StylePropertyId stylePropertyId)
		{
			id = default(StylePropertyId);
			name = null;
		}

		public StylePropertyName(string name)
		{
			id = default(StylePropertyId);
			this.name = null;
		}

		public static bool operator ==(StylePropertyName lhs, StylePropertyName rhs)
		{
			return false;
		}

		public static bool operator !=(StylePropertyName lhs, StylePropertyName rhs)
		{
			return false;
		}

		public static implicit operator StylePropertyName(string name)
		{
			return default(StylePropertyName);
		}

		public override int GetHashCode()
		{
			return 0;
		}

		public override bool Equals(object other)
		{
			return false;
		}

		public bool Equals(StylePropertyName other)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
