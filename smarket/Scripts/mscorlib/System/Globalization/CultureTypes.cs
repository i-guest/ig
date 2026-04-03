namespace System.Globalization
{
	/// <summary>Defines the types of culture lists that can be retrieved using the <see cref="M:System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes)" /> method.</summary>
	[Flags]
	public enum CultureTypes
	{
		/// <summary>Cultures that are associated with a language but are not specific to a country/region. The names of .NET Framework cultures consist of the lowercase two-letter code derived from ISO 639-1. For example: "en" (English) is a neutral culture. </summary>
		NeutralCultures = 1,
		/// <summary>Cultures that are specific to a country/region. The names of these cultures follow RFC 4646 (Windows Vista and later). The format is "&lt;languagecode2&gt;-&lt;country/regioncode2&gt;", where &lt;languagecode2&gt; is a lowercase two-letter code derived from ISO 639-1 and &lt;country/regioncode2&gt; is an uppercase two-letter code derived from ISO 3166. For example, "en-US" for English (United States) is a specific culture.</summary>
		SpecificCultures = 2,
		/// <summary>All cultures that are installed in the Windows operating system. Note that not all cultures supported by the .NET Framework are installed in the operating system.</summary>
		InstalledWin32Cultures = 4,
		/// <summary>All cultures that ship with the .NET Framework, including neutral and specific cultures, cultures installed in the Windows operating system, and custom cultures created by the user.
		///     <see cref="F:System.Globalization.CultureTypes.AllCultures" /> is a composite field that includes the <see cref="F:System.Globalization.CultureTypes.NeutralCultures" />, <see cref="F:System.Globalization.CultureTypes.SpecificCultures" />, and <see cref="F:System.Globalization.CultureTypes.InstalledWin32Cultures" /> values. </summary>
		AllCultures = 7,
		/// <summary>Custom cultures created by the user.</summary>
		UserCustomCulture = 8,
		/// <summary>Custom cultures created by the user that replace cultures shipped with the .NET Framework.</summary>
		ReplacementCultures = 0x10,
		/// <summary>This member is deprecated. If it is used as an argument to the <see cref="M:System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes)" /> method, the method returns an empty array. </summary>
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		WindowsOnlyCultures = 0x20,
		/// <summary>This member is deprecated; using this value with <see cref="M:System.Globalization.CultureInfo.GetCultures(System.Globalization.CultureTypes)" />  returns neutral and specific cultures shipped with the .NET Framework 2.0. </summary>
		[Obsolete("This value has been deprecated.  Please use other values in CultureTypes.")]
		FrameworkCultures = 0x40
	}
}
