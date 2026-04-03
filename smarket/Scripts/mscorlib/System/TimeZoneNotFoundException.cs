using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace System
{
	/// <summary>The exception that is thrown when a time zone cannot be found.</summary>
	[Serializable]
	[TypeForwardedFrom("System.Core, Version=2.0.5.0, Culture=Neutral, PublicKeyToken=7cec85d7bea7798e")]
	public class TimeZoneNotFoundException : Exception
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class with a system-supplied message.</summary>
		public TimeZoneNotFoundException()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.TimeZoneNotFoundException" /> class from serialized data.</summary>
		/// <param name="info">The object that contains the serialized data.</param>
		/// <param name="context">The stream that contains the serialized data.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <see langword="null" />.-or-The <paramref name="context" /> parameter is <see langword="null" />.</exception>
		protected TimeZoneNotFoundException(SerializationInfo info, StreamingContext context)
		{
		}
	}
}
