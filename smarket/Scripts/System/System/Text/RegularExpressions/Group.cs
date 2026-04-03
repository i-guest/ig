using System.Runtime.CompilerServices;

namespace System.Text.RegularExpressions
{
	/// <summary>Represents the results from a single capturing group. </summary>
	[Serializable]
	public class Group : Capture
	{
		internal static readonly Group s_emptyGroup;

		internal readonly int[] _caps;

		internal int _capcount;

		internal CaptureCollection _capcoll;

		[CompilerGenerated]
		private readonly string _003CName_003Ek__BackingField;

		/// <summary>Gets a value indicating whether the match is successful.</summary>
		/// <returns>
		///     <see langword="true" /> if the match is successful; otherwise, <see langword="false" />.</returns>
		public bool Success => false;

		/// <summary>Gets a collection of all the captures matched by the capturing group, in innermost-leftmost-first order (or innermost-rightmost-first order if the regular expression is modified with the <see cref="F:System.Text.RegularExpressions.RegexOptions.RightToLeft" /> option). The collection may have zero or more items.</summary>
		/// <returns>The collection of substrings matched by the group.</returns>
		public CaptureCollection Captures => null;

		internal Group(string text, int[] caps, int capcount, string name)
			: base(null, 0, 0)
		{
		}

		internal Group()
			: base(null, 0, 0)
		{
		}
	}
}
