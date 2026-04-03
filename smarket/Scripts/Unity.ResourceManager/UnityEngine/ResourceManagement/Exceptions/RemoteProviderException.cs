using System;
using UnityEngine.ResourceManagement.ResourceLocations;
using UnityEngine.ResourceManagement.Util;

namespace UnityEngine.ResourceManagement.Exceptions
{
	public class RemoteProviderException : ProviderException
	{
		public override string Message => null;

		public UnityWebRequestResult WebRequestResult { get; }

		public RemoteProviderException(string message, IResourceLocation location = null, UnityWebRequestResult uwrResult = null, Exception innerException = null)
			: base(null)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
