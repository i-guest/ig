using System.Configuration;

namespace System.Net.Configuration
{
	/// <summary>Represents the maximum length for response headers. This class cannot be inherited.</summary>
	public sealed class HttpWebRequestElement : ConfigurationElement
	{
		/// <summary>Gets or sets the maximum allowed length of an error response.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length in kilobytes (1024 bytes) of the error response. The default value is 64.</returns>
		public int MaximumErrorResponseLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the maximum allowed length of the response headers.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length in kilobytes (1024 bytes) of the response headers. The default value is 64.</returns>
		public int MaximumResponseHeadersLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the maximum length of an upload in response to an unauthorized error code.</summary>
		/// <returns>A 32-bit signed integer containing the maximum length (in multiple of 1,024 byte units) of an upload in response to an unauthorized error code. A value of -1 indicates that no size limit will be imposed on the upload. Setting the <see cref="P:System.Net.Configuration.HttpWebRequestElement.MaximumUnauthorizedUploadLength" /> property to any other value will only send the request body if it is smaller than the number of bytes specified. So a value of 1 would indicate to only send the request body if it is smaller than 1,024 bytes. The default value for this property is -1.</returns>
		public int MaximumUnauthorizedUploadLength
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected override ConfigurationPropertyCollection Properties => null;

		/// <summary>Setting this property ignores validation errors that occur during HTTP parsing.</summary>
		/// <returns>Boolean that indicates whether this property has been set. </returns>
		public bool UseUnsafeHeaderParsing
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Net.Configuration.HttpWebRequestElement" /> class. </summary>
		public HttpWebRequestElement()
		{
		}

		protected override void PostDeserialize()
		{
		}
	}
}
