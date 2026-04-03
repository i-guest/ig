using System.Xml;
using System.Xml.XPath;

namespace MS.Internal.Xml.Cache
{
	internal sealed class XPathDocumentNavigator : XPathNavigator, IXmlLineInfo
	{
		private XPathNode[] _pageCurrent;

		private XPathNode[] _pageParent;

		private int _idxCurrent;

		private int _idxParent;

		public override string Value => null;

		public override XPathNodeType NodeType => default(XPathNodeType);

		public override string LocalName => null;

		public override string NamespaceURI => null;

		public override string Prefix => null;

		public override XmlNameTable NameTable => null;

		public override object UnderlyingObject => null;

		public int LineNumber => 0;

		public int LinePosition => 0;

		public XPathDocumentNavigator(XPathNode[] pageCurrent, int idxCurrent, XPathNode[] pageParent, int idxParent)
		{
		}

		public override XPathNavigator Clone()
		{
			return null;
		}

		public override bool MoveToFirstNamespace(XPathNamespaceScope namespaceScope)
		{
			return false;
		}

		public override bool MoveToNextNamespace(XPathNamespaceScope scope)
		{
			return false;
		}

		public override bool MoveToParent()
		{
			return false;
		}

		public override bool IsSamePosition(XPathNavigator other)
		{
			return false;
		}

		public bool HasLineInfo()
		{
			return false;
		}

		public int GetPositionHashCode()
		{
			return 0;
		}
	}
}
