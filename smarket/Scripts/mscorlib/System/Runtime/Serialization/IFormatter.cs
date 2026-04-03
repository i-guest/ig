using System.IO;
using System.Runtime.InteropServices;

namespace System.Runtime.Serialization
{
	/// <summary>Provides functionality for formatting serialized objects.</summary>
	[ComVisible(true)]
	public interface IFormatter
	{
		/// <summary>Deserializes the data on the provided stream and reconstitutes the graph of objects.</summary>
		/// <param name="serializationStream">The stream that contains the data to deserialize. </param>
		/// <returns>The top object of the deserialized graph.</returns>
		object Deserialize(Stream serializationStream);
	}
}
