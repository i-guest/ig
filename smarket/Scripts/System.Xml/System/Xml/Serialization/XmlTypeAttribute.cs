using System.Text;

namespace System.Xml.Serialization
{
	/// <summary>Controls the XML schema that is generated when the attribute target is serialized by the <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface)]
	public class XmlTypeAttribute : Attribute
	{
		private bool includeInSchema;

		private string ns;

		private string typeName;

		private bool anonymousType;

		/// <summary>Gets or sets a value that determines whether the resulting schema type is an XSD anonymous type.</summary>
		/// <returns>
		///     <see langword="true" />, if the resulting schema type is an XSD anonymous type; otherwise, <see langword="false" />.</returns>
		public bool AnonymousType
		{
			set
			{
			}
		}

		/// <summary>Gets or sets a value that indicates whether to include the type in XML schema documents.</summary>
		/// <returns>
		///     <see langword="true" /> to include the type in XML schema documents; otherwise, <see langword="false" />.</returns>
		public bool IncludeInSchema => false;

		/// <summary>Gets or sets the namespace of the XML type.</summary>
		/// <returns>The namespace of the XML type.</returns>
		public string Namespace => null;

		/// <summary>Gets or sets the name of the XML type.</summary>
		/// <returns>The name of the XML type.</returns>
		public string TypeName => null;

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.Serialization.XmlTypeAttribute" /> class.</summary>
		public XmlTypeAttribute()
		{
		}

		internal void AddKeyHash(StringBuilder sb)
		{
		}
	}
}
