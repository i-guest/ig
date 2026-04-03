using System;
using System.Runtime.Serialization;

namespace UnityEngine
{
	[Serializable]
	public class MissingComponentException : Exception
	{
		public MissingComponentException()
		{
		}

		public MissingComponentException(string message)
		{
		}

		protected MissingComponentException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
