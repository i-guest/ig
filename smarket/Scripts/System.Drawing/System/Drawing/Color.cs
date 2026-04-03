using System.Diagnostics;

namespace System.Drawing
{
	/// <summary>Represents an ARGB (alpha, red, green, blue) color.</summary>
	[Serializable]
	[DebuggerDisplay("{NameAndARGBValue}")]
	public readonly struct Color : IEquatable<Color>
	{
		private readonly string name;

		private readonly long value;

		private readonly short knownColor;

		private readonly short state;

		/// <summary>Gets the red component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>The red component value of this <see cref="T:System.Drawing.Color" />.</returns>
		public byte R => 0;

		/// <summary>Gets the green component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>The green component value of this <see cref="T:System.Drawing.Color" />.</returns>
		public byte G => 0;

		/// <summary>Gets the blue component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>The blue component value of this <see cref="T:System.Drawing.Color" />.</returns>
		public byte B => 0;

		/// <summary>Gets the alpha component value of this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>The alpha component value of this <see cref="T:System.Drawing.Color" />.</returns>
		public byte A => 0;

		/// <summary>Gets a value indicating whether this <see cref="T:System.Drawing.Color" /> structure is a predefined color. Predefined colors are represented by the elements of the <see cref="T:System.Drawing.KnownColor" /> enumeration.</summary>
		/// <returns>
		///     <see langword="true" /> if this <see cref="T:System.Drawing.Color" /> was created from a predefined color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, <see langword="false" />.</returns>
		public bool IsKnownColor => false;

		/// <summary>Gets the name of this <see cref="T:System.Drawing.Color" />.</summary>
		/// <returns>The name of this <see cref="T:System.Drawing.Color" />.</returns>
		public string Name => null;

		private long Value => 0L;

		/// <summary>Converts this <see cref="T:System.Drawing.Color" /> structure to a human-readable string.</summary>
		/// <returns>A string that is the name of this <see cref="T:System.Drawing.Color" />, if the <see cref="T:System.Drawing.Color" /> is created from a predefined color by using either the <see cref="M:System.Drawing.Color.FromName(System.String)" /> method or the <see cref="M:System.Drawing.Color.FromKnownColor(System.Drawing.KnownColor)" /> method; otherwise, a string that consists of the ARGB component names and their values.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Tests whether two specified <see cref="T:System.Drawing.Color" /> structures are equivalent.</summary>
		/// <param name="left">The <see cref="T:System.Drawing.Color" /> that is to the left of the equality operator. </param>
		/// <param name="right">The <see cref="T:System.Drawing.Color" /> that is to the right of the equality operator. </param>
		/// <returns>
		///     <see langword="true" /> if the two <see cref="T:System.Drawing.Color" /> structures are equal; otherwise, <see langword="false" />.</returns>
		public static bool operator ==(Color left, Color right)
		{
			return false;
		}

		/// <summary>Tests whether the specified object is a <see cref="T:System.Drawing.Color" /> structure and is equivalent to this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <param name="obj">The object to test. </param>
		/// <returns>
		///     <see langword="true" /> if <paramref name="obj" /> is a <see cref="T:System.Drawing.Color" /> structure equivalent to this <see cref="T:System.Drawing.Color" /> structure; otherwise, <see langword="false" />.</returns>
		public override bool Equals(object obj)
		{
			return false;
		}

		public bool Equals(Color other)
		{
			return false;
		}

		/// <summary>Returns a hash code for this <see cref="T:System.Drawing.Color" /> structure.</summary>
		/// <returns>An integer value that specifies the hash code for this <see cref="T:System.Drawing.Color" />.</returns>
		public override int GetHashCode()
		{
			return 0;
		}
	}
}
