namespace System.Drawing
{
	/// <summary>Stores an ordered pair of integers, which specify a <see cref="P:System.Drawing.Size.Height" /> and <see cref="P:System.Drawing.Size.Width" />.</summary>
	[Serializable]
	public struct Size : IEquatable<Size>
	{
		private int width;

		private int height;

		/// <summary>Gets or sets the horizontal component of this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <returns>The horizontal component of this <see cref="T:System.Drawing.Size" /> structure, typically measured in pixels.</returns>
		public int Width => 0;

		/// <summary>Gets or sets the vertical component of this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <returns>The vertical component of this <see cref="T:System.Drawing.Size" /> structure, typically measured in pixels.</returns>
		public int Height => 0;

		/// <summary>Tests whether two <see cref="T:System.Drawing.Size" /> structures are equal.</summary>
		/// <param name="sz1">The <see cref="T:System.Drawing.Size" /> structure on the left side of the equality operator. </param>
		/// <param name="sz2">The <see cref="T:System.Drawing.Size" /> structure on the right of the equality operator. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="sz1" /> and <paramref name="sz2" /> have equal width and height; otherwise, <see langword="false" />.</returns>
		public static bool operator ==(Size sz1, Size sz2)
		{
			return false;
		}

		/// <summary>Tests to see whether the specified object is a <see cref="T:System.Drawing.Size" /> structure with the same dimensions as this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to test. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Size" /> and has the same width and height as this <see cref="T:System.Drawing.Size" />; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Size other)
		{
			return false;
		}

		/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.Size" /> structure.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Creates a human-readable string that represents this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <returns>A string that represents this <see cref="T:System.Drawing.Size" />.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
