using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Schema;

namespace System.Xml.XPath
{
	/// <summary>Provides a cursor model for navigating and editing XML data.</summary>
	[DebuggerDisplay("{debuggerDisplayProxy}")]
	public abstract class XPathNavigator : XPathItem, ICloneable, IXmlNamespaceResolver
	{
		internal static readonly XPathNavigatorKeyComparer comparer;

		internal static readonly char[] NodeTypeLetter;

		internal static readonly char[] UniqueIdTbl;

		internal static readonly int[] ContentKindMasks;

		/// <summary>Gets the <see cref="T:System.Xml.Schema.XmlSchemaType" /> information for the current node.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.XmlSchemaType" /> object; default is <see langword="null" />.</returns>
		public override XmlSchemaType XmlType => null;

		/// <summary>Gets the current node as a boxed object of the most appropriate .NET Framework type.</summary>
		/// <returns>The current node as a boxed object of the most appropriate .NET Framework type.</returns>
		public override object TypedValue => null;

		/// <summary>Gets the .NET Framework <see cref="T:System.Type" /> of the current node.</summary>
		/// <returns>The .NET Framework <see cref="T:System.Type" /> of the current node. The default value is <see cref="T:System.String" />.</returns>
		public override Type ValueType => null;

		/// <summary>Gets the current node's value as a <see cref="T:System.Boolean" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.Boolean" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Boolean" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Boolean" /> is not valid.</exception>
		public override bool ValueAsBoolean => false;

		/// <summary>Gets the current node's value as a <see cref="T:System.DateTime" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.DateTime" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.DateTime" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.DateTime" /> is not valid.</exception>
		public override DateTime ValueAsDateTime => default(DateTime);

		/// <summary>Gets the current node's value as a <see cref="T:System.Double" />.</summary>
		/// <returns>The current node's value as a <see cref="T:System.Double" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Double" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Double" /> is not valid.</exception>
		public override double ValueAsDouble => 0.0;

		/// <summary>Gets the current node's value as an <see cref="T:System.Int32" />.</summary>
		/// <returns>The current node's value as an <see cref="T:System.Int32" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Int32" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int32" /> is not valid.</exception>
		public override int ValueAsInt => 0;

		/// <summary>Gets the current node's value as an <see cref="T:System.Int64" />.</summary>
		/// <returns>The current node's value as an <see cref="T:System.Int64" />.</returns>
		/// <exception cref="T:System.FormatException">The current node's string value cannot be converted to a <see cref="T:System.Int64" />.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast to <see cref="T:System.Int64" /> is not valid.</exception>
		public override long ValueAsLong => 0L;

		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XmlNameTable" /> of the <see cref="T:System.Xml.XPath.XPathNavigator" />.</summary>
		/// <returns>An <see cref="T:System.Xml.XmlNameTable" /> object enabling you to get the atomized version of a <see cref="T:System.String" /> within the XML document.</returns>
		public abstract XmlNameTable NameTable { get; }

		/// <summary>When overridden in a derived class, gets the <see cref="T:System.Xml.XPath.XPathNodeType" /> of the current node.</summary>
		/// <returns>One of the <see cref="T:System.Xml.XPath.XPathNodeType" /> values representing the current node.</returns>
		public abstract XPathNodeType NodeType { get; }

		/// <summary>When overridden in a derived class, gets the <see cref="P:System.Xml.XPath.XPathNavigator.Name" /> of the current node without any namespace prefix.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the local name of the current node, or <see cref="F:System.String.Empty" /> if the current node does not have a name (for example, text or comment nodes).</returns>
		public abstract string LocalName { get; }

		/// <summary>When overridden in a derived class, gets the namespace URI of the current node.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace URI of the current node, or <see cref="F:System.String.Empty" /> if the current node has no namespace URI.</returns>
		public abstract string NamespaceURI { get; }

		/// <summary>When overridden in a derived class, gets the namespace prefix associated with the current node.</summary>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace prefix associated with the current node.</returns>
		public abstract string Prefix { get; }

		/// <summary>Used by <see cref="T:System.Xml.XPath.XPathNavigator" /> implementations which provide a "virtualized" XML view over a store, to provide access to underlying objects.</summary>
		/// <returns>The default is <see langword="null" />.</returns>
		public virtual object UnderlyingObject => null;

		/// <summary>Gets the schema information that has been assigned to the current node as a result of schema validation.</summary>
		/// <returns>An <see cref="T:System.Xml.Schema.IXmlSchemaInfo" /> object that contains the schema information for the current node.</returns>
		public virtual IXmlSchemaInfo SchemaInfo => null;

		/// <summary>Gets the text value of the current node.</summary>
		/// <returns>A <see langword="string" /> that contains the text value of the current node.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Gets the current node's value as the <see cref="T:System.Type" /> specified, using the <see cref="T:System.Xml.IXmlNamespaceResolver" /> object specified to resolve namespace prefixes.</summary>
		/// <param name="returnType">The <see cref="T:System.Type" /> to return the current node's value as.</param>
		/// <param name="nsResolver">The <see cref="T:System.Xml.IXmlNamespaceResolver" /> object used to resolve namespace prefixes.</param>
		/// <returns>The value of the current node as the <see cref="T:System.Type" /> requested.</returns>
		/// <exception cref="T:System.FormatException">The current node's value is not in the correct format for the target type.</exception>
		/// <exception cref="T:System.InvalidCastException">The attempted cast is not valid.</exception>
		public override object ValueAs(Type returnType, IXmlNamespaceResolver nsResolver)
		{
			return null;
		}

		/// <summary>Creates a new copy of the <see cref="T:System.Xml.XPath.XPathNavigator" /> object.</summary>
		/// <returns>A new copy of the <see cref="T:System.Xml.XPath.XPathNavigator" /> object.</returns>
		object ICloneable.Clone()
		{
			return null;
		}

		/// <summary>Gets the namespace URI for the specified prefix.</summary>
		/// <param name="prefix">The prefix whose namespace URI you want to resolve. To match the default namespace, pass <see cref="F:System.String.Empty" />.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace URI assigned to the namespace prefix specified; <see langword="null" /> if no namespace URI is assigned to the prefix specified. The <see cref="T:System.String" /> returned is atomized.</returns>
		public virtual string LookupNamespace(string prefix)
		{
			return null;
		}

		/// <summary>Gets the prefix declared for the specified namespace URI.</summary>
		/// <param name="namespaceURI">The namespace URI to resolve for the prefix.</param>
		/// <returns>A <see cref="T:System.String" /> that contains the namespace prefix assigned to the namespace URI specified; otherwise, <see cref="F:System.String.Empty" /> if no prefix is assigned to the namespace URI specified. The <see cref="T:System.String" /> returned is atomized.</returns>
		public virtual string LookupPrefix(string namespaceURI)
		{
			return null;
		}

		/// <summary>Returns the in-scope namespaces of the current node.</summary>
		/// <param name="scope">An <see cref="T:System.Xml.XmlNamespaceScope" /> value specifying the namespaces to return.</param>
		/// <returns>An <see cref="T:System.Collections.Generic.IDictionary`2" /> collection of namespace names keyed by prefix.</returns>
		public virtual IDictionary<string, string> GetNamespacesInScope(XmlNamespaceScope scope)
		{
			return null;
		}

		/// <summary>When overridden in a derived class, creates a new <see cref="T:System.Xml.XPath.XPathNavigator" /> positioned at the same node as this <see cref="T:System.Xml.XPath.XPathNavigator" />.</summary>
		/// <returns>A new <see cref="T:System.Xml.XPath.XPathNavigator" /> positioned at the same node as this <see cref="T:System.Xml.XPath.XPathNavigator" />.</returns>
		public abstract XPathNavigator Clone();

		/// <summary>Moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the namespace node with the specified namespace prefix.</summary>
		/// <param name="name">The namespace prefix of the namespace node.</param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the specified namespace; <see langword="false" /> if a matching namespace node was not found, or if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is not positioned on an element node. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		public virtual bool MoveToNamespace(string name)
		{
			return false;
		}

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the first namespace node that matches the <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> specified.</summary>
		/// <param name="namespaceScope">An <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> value describing the namespace scope. </param>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the first namespace node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		public abstract bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the next namespace node matching the <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> specified.</summary>
		/// <param name="namespaceScope">An <see cref="T:System.Xml.XPath.XPathNamespaceScope" /> value describing the namespace scope. </param>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the next namespace node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		public abstract bool MoveToNextNamespace(XPathNamespaceScope namespaceScope);

		/// <summary>When overridden in a derived class, moves the <see cref="T:System.Xml.XPath.XPathNavigator" /> to the parent node of the current node.</summary>
		/// <returns>Returns <see langword="true" /> if the <see cref="T:System.Xml.XPath.XPathNavigator" /> is successful moving to the parent node of the current node; otherwise, <see langword="false" />. If <see langword="false" />, the position of the <see cref="T:System.Xml.XPath.XPathNavigator" /> is unchanged.</returns>
		public abstract bool MoveToParent();

		/// <summary>When overridden in a derived class, determines whether the current <see cref="T:System.Xml.XPath.XPathNavigator" /> is at the same position as the specified <see cref="T:System.Xml.XPath.XPathNavigator" />.</summary>
		/// <param name="other">The <see cref="T:System.Xml.XPath.XPathNavigator" /> to compare to this <see cref="T:System.Xml.XPath.XPathNavigator" />.</param>
		/// <returns>
		///     <see langword="true" /> if the two <see cref="T:System.Xml.XPath.XPathNavigator" /> objects have the same position; otherwise, <see langword="false" />.</returns>
		public abstract bool IsSamePosition(XPathNavigator other);

		internal static bool IsText(XPathNodeType type)
		{
			return false;
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Xml.XPath.XPathNavigator" /> class.</summary>
		protected XPathNavigator()
		{
		}
	}
}
