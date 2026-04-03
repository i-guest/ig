using System;
using System.Collections.Generic;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Serializable]
	public struct MaterialDefinition : IEquatable<MaterialDefinition>
	{
		internal class PropertyBag : ContainerPropertyBag<MaterialDefinition>
		{
			private class MaterialProperty : Property<MaterialDefinition, Material>
			{
				public override string Name { get; }

				public override bool IsReadOnly { get; }

				public override Material GetValue(ref MaterialDefinition container)
				{
					return null;
				}

				public override void SetValue(ref MaterialDefinition container, Material value)
				{
				}
			}
		}

		[SerializeField]
		private Material m_Material;

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		[SerializeField]
		internal List<MaterialPropertyValue> propertyValues;

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		internal MaterialDefinition(MaterialDefinition other)
		{
			m_Material = null;
			propertyValues = null;
		}

		public static MaterialDefinition FromMaterial(Material m)
		{
			return default(MaterialDefinition);
		}

		[VisibleToOtherModules(new string[] { "UnityEditor.UIToolkitAuthoringModule" })]
		internal static MaterialDefinition FromObject(object obj)
		{
			return default(MaterialDefinition);
		}

		internal MaterialPropertyBlock BuildPropertyBlock()
		{
			return null;
		}

		public static bool operator ==(MaterialDefinition lhs, MaterialDefinition rhs)
		{
			return false;
		}

		public static bool operator !=(MaterialDefinition lhs, MaterialDefinition rhs)
		{
			return false;
		}

		public static implicit operator MaterialDefinition(Material m)
		{
			return default(MaterialDefinition);
		}

		public bool Equals(MaterialDefinition other)
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
