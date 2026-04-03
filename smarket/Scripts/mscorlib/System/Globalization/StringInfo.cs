using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System.Globalization
{
	/// <summary>Provides functionality to split a string into text elements and to iterate through those text elements.</summary>
	[Serializable]
	[ComVisible(true)]
	public class StringInfo
	{
		[OptionalField(VersionAdded = 2)]
		private string m_str;

		[NonSerialized]
		private int[] m_indexes;

		private int[] Indexes => null;

		/// <summary>Gets or sets the value of the current <see cref="T:System.Globalization.StringInfo" /> object.</summary>
		/// <returns>The string that is the value of the current <see cref="T:System.Globalization.StringInfo" /> object.</returns>
		/// <exception cref="T:System.ArgumentNullException">The value in a set operation is <see langword="null" />.</exception>
		public string String
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		/// <summary>Gets the number of text elements in the current <see cref="T:System.Globalization.StringInfo" /> object.</summary>
		/// <returns>The number of base characters, surrogate pairs, and combining character sequences in this <see cref="T:System.Globalization.StringInfo" /> object.</returns>
		public int LengthInTextElements => 0;

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.StringInfo" /> class. </summary>
		public StringInfo()
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.Globalization.StringInfo" /> class to a specified string.</summary>
		/// <param name="value">A string to initialize this <see cref="T:System.Globalization.StringInfo" /> object.</param>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="value" /> is <see langword="null" />.</exception>
		public StringInfo(string value)
		{
		}

		[OnDeserializing]
		private void OnDeserializing(StreamingContext ctx)
		{
		}

		[OnDeserialized]
		private void OnDeserialized(StreamingContext ctx)
		{
		}

		/// <summary>Indicates whether the current <see cref="T:System.Globalization.StringInfo" /> object is equal to a specified object.</summary>
		/// <param name="value">An object.</param>
		/// <returns>
		///     <see langword="true" /> if the <paramref name="value" /> parameter is a <see cref="T:System.Globalization.StringInfo" /> object and its <see cref="P:System.Globalization.StringInfo.String" /> property equals the <see cref="P:System.Globalization.StringInfo.String" /> property of this <see cref="T:System.Globalization.StringInfo" /> object; otherwise, <see langword="false" />.</returns>
		[ComVisible(false)]
		public override bool Equals(object value)
		{
			return false;
		}

		/// <summary>Calculates a hash code for the value of the current <see cref="T:System.Globalization.StringInfo" /> object.</summary>
		/// <returns>A 32-bit signed integer hash code based on the string value of this <see cref="T:System.Globalization.StringInfo" /> object.</returns>
		[ComVisible(false)]
		public override int GetHashCode()
		{
			return 0;
		}

		internal static int GetCurrentTextElementLen(string str, int index, int len, ref UnicodeCategory ucCurrent, ref int currentCharCount)
		{
			return 0;
		}

		/// <summary>Returns the indexes of each base character, high surrogate, or control character within the specified string.</summary>
		/// <param name="str">The string to search. </param>
		/// <returns>An array of integers that contains the zero-based indexes of each base character, high surrogate, or control character within the specified string.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="str" /> is <see langword="null" />. </exception>
		public static int[] ParseCombiningCharacters(string str)
		{
			return null;
		}
	}
}
