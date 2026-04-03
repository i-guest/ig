using System.Collections.Generic;
using MS.Internal.Xml.Cache;

namespace System.Xml.XPath
{
	/// <summary>Provides a fast, read-only, in-memory representation of an XML document by using the XPath data model.</summary>
	public class XPathDocument
	{
		private XPathNode[] pageXmlNmsp;

		private int idxXmlNmsp;

		private XmlNameTable nameTable;

		private bool hasLineInfo;

		private Dictionary<XPathNodeRef, XPathNodeRef> mapNmsp;

		internal XmlNameTable NameTable => null;

		internal bool HasLineInfo => false;

		internal int GetXmlNamespaceNode(out XPathNode[] pageXmlNmsp)
		{
			pageXmlNmsp = null;
			return 0;
		}

		internal int LookupNamespaces(XPathNode[] pageElem, int idxElem, out XPathNode[] pageNmsp)
		{
			pageNmsp = null;
			return 0;
		}
	}
}
