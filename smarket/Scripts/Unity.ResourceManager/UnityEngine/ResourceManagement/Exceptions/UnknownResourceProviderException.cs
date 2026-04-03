using System;
using System.Runtime.Serialization;
using UnityEngine.ResourceManagement.ResourceLocations;

namespace UnityEngine.ResourceManagement.Exceptions
{
	public class UnknownResourceProviderException : ResourceManagerException
	{
		public IResourceLocation Location { get; private set; }

		public override string Message => null;

		public UnknownResourceProviderException(IResourceLocation location)
		{
		}

		public UnknownResourceProviderException()
		{
		}

		public UnknownResourceProviderException(string message)
		{
		}

		public UnknownResourceProviderException(string message, Exception innerException)
		{
		}

		protected UnknownResourceProviderException(SerializationInfo message, StreamingContext context)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
