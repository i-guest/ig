namespace System.Drawing
{
	/// <summary>Represents an ordered pair of integer x- and y-coordinates that defines a point in a two-dimensional plane.</summary>
	[Serializable]
	public struct Point : IEquatable<Point>
	{
		private int x;

		private int y;

		/// <summary>Gets or sets the x-coordinate of this <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>The x-coordinate of this <see cref="T:System.Drawing.Point" />.</returns>
		public int X => 0;

		/// <summary>Gets or sets the y-coordinate of this <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>The y-coordinate of this <see cref="T:System.Drawing.Point" />.</returns>
		public int Y => 0;

		/// <summary>Compares two <see cref="T:System.Drawing.Point" /> objects. The result specifies whether the values of the <see cref="P:System.Drawing.Point.X" /> and <see cref="P:System.Drawing.Point.Y" /> properties of the two <see cref="T:System.Drawing.Point" /> objects are equal.</summary>
		/// <param name="left">A <see cref="T:System.Drawing.Point" /> to compare. </param>
		/// <param name="right">A <see cref="T:System.Drawing.Point" /> to compare. </param>
		/// <returns>
		///     <see langword="true" /> if the <see cref="P:System.Drawing.Point.X" /> and <see cref="P:System.Drawing.Point.Y" /> values of <paramref name="left" /> and <paramref name="right" /> are equal; otherwise, <see langword="false" />.</returns>
		public static bool operator ==(Point left, Point right)
		{
			return false;
		}

		/// <summary>Specifies whether this <see cref="T:System.Drawing.Point" /> contains the same coordinates as the specified <see cref="T:System.Object" />.</summary>
		/// <param name="obj">The <see cref="T:System.Object" /> to test. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Point" /> and has the same coordinates as this <see cref="T:System.Drawing.Point" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Point other)
		{
			return false;
		}

		/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Point" />.</summary>
		/// <returns>An integer value that specifies a hash value for this <see cref="T:System.Drawing.Point" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}

		/// <summary>Converts this <see cref="T:System.Drawing.Point" /> to a human-readable string.</summary>
		/// <returns>A string that represents this <see cref="T:System.Drawing.Point" />.</returns>
		public override string ToString()
		{
			return null;
		}
	}
}
