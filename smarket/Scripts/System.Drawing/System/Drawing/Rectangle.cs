namespace System.Drawing
{
	/// <summary>Stores a set of four integers that represent the location and size of a rectangle</summary>
	[Serializable]
	public struct Rectangle : IEquatable<Rectangle>
	{
		private int x;

		private int y;

		private int width;

		private int height;

		/// <summary>Gets or sets the x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
		/// <returns>The x-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
		public int X => 0;

		/// <summary>Gets or sets the y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
		/// <returns>The y-coordinate of the upper-left corner of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
		public int Y => 0;

		/// <summary>Gets or sets the width of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
		/// <returns>The width of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
		public int Width => 0;

		/// <summary>Gets or sets the height of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
		/// <returns>The height of this <see cref="T:System.Drawing.Rectangle" /> structure. The default is 0.</returns>
		public int Height => 0;

		/// <summary>Tests whether <paramref name="obj" /> is a <see cref="T:System.Drawing.Rectangle" /> structure with the same location and size of this <see cref="T:System.Drawing.Rectangle" /> structure.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to test. </param>
		/// <returns>This method returns <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Rectangle" /> structure and its <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" />, and <see cref="P:System.Drawing.Rectangle.Height" /> properties are equal to the corresponding properties of this <see cref="T:System.Drawing.Rectangle" /> structure; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Rectangle other)
		{
			return false;
		}

		/// <summary>Tests whether two <see cref="T:System.Drawing.Rectangle" /> structures have equal location and size.</summary>
		/// <param name="left">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the left of the equality operator. </param>
		/// <param name="right">The <see cref="T:System.Drawing.Rectangle" /> structure that is to the right of the equality operator. </param>
		/// <returns>This operator returns <see langword="true" /> if the two <see cref="T:System.Drawing.Rectangle" /> structures have equal <see cref="P:System.Drawing.Rectangle.X" />, <see cref="P:System.Drawing.Rectangle.Y" />, <see cref="P:System.Drawing.Rectangle.Width" />, and <see cref="P:System.Drawing.Rectangle.Height" /> properties.</returns>
		public static bool operator ==(Rectangle left, Rectangle right)
		{
			return false;
		}

		/// <summary>Returns the hash code for this <see cref="T:System.Drawing.Rectangle" /> structure. For information about the use of hash codes, see <see cref="M:System.Object.GetHashCode" /> .</summary>
		/// <returns>An integer that represents the hash code for this rectangle.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Converts the attributes of this <see cref="T:System.Drawing.Rectangle" /> to a human-readable string.</summary>
		/// <returns>A string that contains the position, width, and height of this <see cref="T:System.Drawing.Rectangle" /> structure ¾ for example, {X=20, Y=20, Width=100, Height=50} </returns>
		public override string ToString()
		{
			return null;
		}
	}
}
