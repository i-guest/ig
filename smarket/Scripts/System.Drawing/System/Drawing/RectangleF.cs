namespace System.Drawing
{
	/// <summary>Stores a set of four floating-point numbers that represent the location and size of a rectangle. For more advanced region functions, use a <see cref="T:System.Drawing.Region" /> object.</summary>
	[Serializable]
	public struct RectangleF : IEquatable<RectangleF>
	{
		private float x;

		private float y;

		private float width;

		private float height;

		/// <summary>Gets or sets the x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
		/// <returns>The x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
		public float X => 0f;

		/// <summary>Gets or sets the y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
		/// <returns>The y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
		public float Y => 0f;

		/// <summary>Gets or sets the width of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
		/// <returns>The width of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
		public float Width => 0f;

		/// <summary>Gets or sets the height of this <see cref="T:System.Drawing.RectangleF" /> structure.</summary>
		/// <returns>The height of this <see cref="T:System.Drawing.RectangleF" /> structure. The default is 0.</returns>
		public float Height => 0f;

		/// <summary>Tests whether <paramref name="obj" /> is a <see cref="T:System.Drawing.RectangleF" /> with the same location and size of this <see cref="T:System.Drawing.RectangleF" />.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to test. </param>
		/// <returns>This method returns <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.RectangleF" /> and its <see langword="X" />, <see langword="Y" />, <see langword="Width" />, and <see langword="Height" /> properties are equal to the corresponding properties of this <see cref="T:System.Drawing.RectangleF" />; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(RectangleF other)
		{
			return false;
		}

		/// <summary>Tests whether two <see cref="T:System.Drawing.RectangleF" /> structures have equal location and size.</summary>
		/// <param name="left">The <see cref="T:System.Drawing.RectangleF" /> structure that is to the left of the equality operator. </param>
		/// <param name="right">The <see cref="T:System.Drawing.RectangleF" /> structure that is to the right of the equality operator. </param>
		/// <returns>This operator returns <see langword="true" /> if the two specified <see cref="T:System.Drawing.RectangleF" /> structures have equal <see cref="P:System.Drawing.RectangleF.X" />, <see cref="P:System.Drawing.RectangleF.Y" />, <see cref="P:System.Drawing.RectangleF.Width" />, and <see cref="P:System.Drawing.RectangleF.Height" /> properties.</returns>
		public static bool operator ==(RectangleF left, RectangleF right)
		{
			return false;
		}

		/// <summary>Gets the hash code for this <see cref="T:System.Drawing.RectangleF" /> structure. For information about the use of hash codes, see <see langword="Object.GetHashCode" />.</summary>
		/// <returns>The hash code for this <see cref="T:System.Drawing.RectangleF" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Converts the <see langword="Location" /> and <see cref="T:System.Drawing.Size" /> of this <see cref="T:System.Drawing.RectangleF" /> to a human-readable string.</summary>
		/// <returns>A string that contains the position, width, and height of this <see cref="T:System.Drawing.RectangleF" /> structure. For example, "{X=20, Y=20, Width=100, Height=50}".</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
