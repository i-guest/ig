using System;
using System.Runtime.Serialization;

namespace UnityEngine.ResourceManagement.Exceptions
{
	public class ResourceManagerException : Exception
	{
		public ResourceManagerException()
		{
		}

		public ResourceManagerException(string message)
		{
		}

		public ResourceManagerException(string message, Exception innerException)
		{
		}

		protected ResourceManagerException(SerializationInfo message, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
