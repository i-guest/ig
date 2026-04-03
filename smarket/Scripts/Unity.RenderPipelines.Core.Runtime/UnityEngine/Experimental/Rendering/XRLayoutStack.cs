using System;
using System.Collections.Generic;

namespace UnityEngine.Experimental.Rendering
{
	internal class XRLayoutStack : IDisposable
	{
		private readonly Stack<XRLayout> m_Stack;

		public XRLayout top => null;

		public XRLayout New()
		{
			return null;
		}

		public void Release()
		{
		}

		public void Dispose()
		{
		}
	}
}
