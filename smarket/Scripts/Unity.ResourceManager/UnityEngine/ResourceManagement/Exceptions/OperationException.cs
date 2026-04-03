using System;

namespace UnityEngine.ResourceManagement.Exceptions
{
	public class OperationException : Exception
	{
		public OperationException(string message, Exception innerException = null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
