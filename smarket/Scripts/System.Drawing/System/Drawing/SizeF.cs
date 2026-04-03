namespace System.Drawing
{
	/// <summary>Stores an ordered pair of floating-point numbers, typically the width and height of a rectangle.</summary>
	[Serializable]
	public struct SizeF : IEquatable<SizeF>
	{
		private float width;

		private float height;

		/// <summary>Gets or sets the horizontal component of this <see cref="T:System.Drawing.SizeF" /> structure.</summary>
		/// <returns>The horizontal component of this <see cref="T:System.Drawing.SizeF" /> structure, typically measured in pixels.</returns>
		public float Width => 0f;

		/// <summary>Gets or sets the vertical component of this <see cref="T:System.Drawing.SizeF" /> structure.</summary>
		/// <returns>The vertical component of this <see cref="T:System.Drawing.SizeF" /> structure, typically measured in pixels.</returns>
		public float Height => 0f;

		/// <summary>Tests whether two <see cref="T:System.Drawing.SizeF" /> structures are equal.</summary>
		/// <param name="sz1">The <see cref="T:System.Drawing.SizeF" /> structure on the left side of the equality operator. </param>
		/// <param name="sz2">The <see cref="T:System.Drawing.SizeF" /> structure on the right of the equality operator. </param>
		/// <returns>This operator returns <see langword="true" /> if <paramref name="sz1" /> and <paramref name="sz2" /> have equal width and height; otherwise, <see langword="false" />.</returns>
		public static bool operator ==(SizeF sz1, SizeF sz2)
		{
			return false;
		}

		/// <summary>Tests to see whether the specified object is a <see cref="T:System.Drawing.SizeF" /> structure with the same dimensions as this <see cref="T:System.Drawing.SizeF" /> structure.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to test. </param>
		/// <returns>This method returns <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.SizeF" /> and has the same width and height as this <see cref="T:System.Drawing.SizeF" />; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(SizeF other)
		{
			return false;
		}

		/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Size" /> structure.</summary>
		/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.Size" /> structure.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Creates a human-readable string that represents this <see cref="T:System.Drawing.SizeF" /> structure.</summary>
		/// <returns>A string that represents this <see cref="T:System.Drawing.SizeF" /> structure.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
