using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
	/// <summary>Converts a <see cref="T:System.Security.Cryptography.CryptoStream" /> to base 64.</summary>
	[ComVisible(true)]
	public class ToBase64Transform : ICryptoTransform, IDisposable
	{
		/// <summary>Gets the input block size.</summary>
		/// <returns>The size of the input data blocks in bytes.</returns>
		public int InputBlockSize => 0;

		/// <summary>Gets the output block size.</summary>
		/// <returns>The size of the output data blocks in bytes.</returns>
		public int OutputBlockSize => 0;

		/// <summary>Gets a value that indicates whether multiple blocks can be transformed.</summary>
		/// <returns>Always <see langword="false" />.</returns>
		public bool CanTransformMultipleBlocks => false;

		/// <summary>Gets a value indicating whether the current transform can be reused.</summary>
		/// <returns>Always <see langword="true" />.</returns>
		public virtual bool CanReuseTransform => false;

		/// <summary>Converts the specified region of the input byte array to base 64 and copies the result to the specified region of the output byte array.</summary>
		/// <param name="inputBuffer">The input to compute to base 64. </param>
		/// <param name="inputOffset">The offset into the input byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the input byte array to use as data. </param>
		/// <param name="outputBuffer">The output to which to write the result. </param>
		/// <param name="outputOffset">The offset into the output byte array from which to begin writing data. </param>
		/// <returns>The number of bytes written.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current <see cref="T:System.Security.Cryptography.ToBase64Transform" /> object has already been disposed. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">The data size is not valid. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="inputBuffer" /> parameter contains an invalid offset length.-or-The <paramref name="inputCount" /> parameter contains an invalid value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="inputBuffer" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="inputBuffer" /> parameter requires a non-negative number.</exception>
		public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
		{
			return 0;
		}

		/// <summary>Converts the specified region of the specified byte array to base 64.</summary>
		/// <param name="inputBuffer">The input to convert to base 64. </param>
		/// <param name="inputOffset">The offset into the byte array from which to begin using data. </param>
		/// <param name="inputCount">The number of bytes in the byte array to use as data. </param>
		/// <returns>The computed base 64 conversion.</returns>
		/// <exception cref="T:System.ObjectDisposedException">The current <see cref="T:System.Security.Cryptography.ToBase64Transform" /> object has already been disposed. </exception>
		/// <exception cref="T:System.ArgumentException">The <paramref name="inputBuffer" /> parameter contains an invalid offset length.-or-The <paramref name="inputCount" /> parameter contains an invalid value.</exception>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="inputBuffer" /> parameter is <see langword="null" />.</exception>
		/// <exception cref="T:System.ArgumentOutOfRangeException">The <paramref name="inputBuffer" /> parameter requires a non-negative number.</exception>
		public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
		{
			return null;
		}

		/// <summary>Releases all resources used by the current instance of the <see cref="T:System.Security.Cryptography.ToBase64Transform" /> class.</summary>
		public void Dispose()
		{
		}

		/// <summary>Releases all resources used by the <see cref="T:System.Security.Cryptography.ToBase64Transform" />.</summary>
		public void Clear()
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.ToBase64Transform" /> and optionally releases the managed resources.</summary>
		/// <param name="disposing">
		///       <see langword="true" /> to release both managed and unmanaged resources; <see langword="false" /> to release only unmanaged resources. </param>
		protected virtual void Dispose(bool disposing)
		{
		}

		/// <summary>Releases the unmanaged resources used by the <see cref="T:System.Security.Cryptography.ToBase64Transform" />.</summary>
		~ToBase64Transform()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Security.Cryptography.ToBase64Transform" /> class. </summary>
		public ToBase64Transform()
		{
		}
	}
}
