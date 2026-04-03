using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Text;

namespace System.ComponentModel
{
	/// <summary>Represents a mask-parsing service that can be used by any number of controls that support masking, such as the <see cref="T:System.Windows.Forms.MaskedTextBox" /> control.</summary>
	public class MaskedTextProvider : ICloneable
	{
		private enum CaseConversion
		{
			None = 0,
			ToLower = 1,
			ToUpper = 2
		}

		[Flags]
		private enum CharType
		{
			EditOptional = 1,
			EditRequired = 2,
			Separator = 4,
			Literal = 8,
			Modifier = 0x10
		}

		private class CharDescriptor
		{
			public int MaskPosition;

			public CaseConversion CaseConversion;

			public CharType CharType;

			public bool IsAssigned;

			public CharDescriptor(int maskPos, CharType charType)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private const char SPACE_CHAR = ' ';

		private const char DEFAULT_PROMPT_CHAR = '_';

		private const char NULL_PASSWORD_CHAR = '\0';

		private const bool DEFAULT_ALLOW_PROMPT = true;

		private const int INVALID_INDEX = -1;

		private const byte EDIT_ANY = 0;

		private const byte EDIT_UNASSIGNED = 1;

		private const byte EDIT_ASSIGNED = 2;

		private const bool FORWARD = true;

		private const bool BACKWARD = false;

		private static int s_ASCII_ONLY;

		private static int s_ALLOW_PROMPT_AS_INPUT;

		private static int s_INCLUDE_PROMPT;

		private static int s_INCLUDE_LITERALS;

		private static int s_RESET_ON_PROMPT;

		private static int s_RESET_ON_LITERALS;

		private static int s_SKIP_SPACE;

		private static Type s_maskTextProviderType;

		private BitVector32 _flagState;

		private StringBuilder _testString;

		private int _requiredCharCount;

		private int _requiredEditChars;

		private int _optionalEditChars;

		private char _passwordChar;

		private char _promptChar;

		private List<CharDescriptor> _stringDescriptor;

		/// <summary>Gets a value indicating whether the prompt character should be treated as a valid input character or not.</summary>
		/// <returns>
		///     <see langword="true" /> if the user can enter <see cref="P:System.ComponentModel.MaskedTextProvider.PromptChar" /> into the control; otherwise, <see langword="false" />. The default is <see langword="true" />. </returns>
		public bool AllowPromptAsInput => false;

		/// <summary>Gets the number of editable character positions that have already been successfully assigned an input value.</summary>
		/// <returns>An <see cref="T:System.Int32" /> containing the number of editable character positions in the input mask that have already been assigned a character value in the formatted string.</returns>
		public int AssignedEditPositionCount { get; private set; }

		/// <summary>Gets the number of editable character positions in the input mask that have not yet been assigned an input value.</summary>
		/// <returns>An <see cref="T:System.Int32" /> containing the number of editable character positions that not yet been assigned a character value.</returns>
		public int AvailableEditPositionCount => 0;

		/// <summary>Gets the culture that determines the value of the localizable separators and placeholders in the input mask.</summary>
		/// <returns>A <see cref="T:System.Globalization.CultureInfo" /> containing the culture information associated with the input mask.</returns>
		public CultureInfo Culture { get; }

		/// <summary>Gets the default password character used obscure user input. </summary>
		/// <returns>A <see cref="T:System.Char" /> that represents the default password character.</returns>
		public static char DefaultPasswordChar => '\0';

		/// <summary>Gets the number of editable positions in the formatted string.</summary>
		/// <returns>An <see cref="T:System.Int32" /> containing the number of editable positions in the formatted string.</returns>
		public int EditPositionCount => 0;

		/// <summary>Gets a newly created enumerator for the editable positions in the formatted string. </summary>
		/// <returns>An <see cref="T:System.Collections.IEnumerator" /> that supports enumeration over the editable positions in the formatted string.</returns>
		public IEnumerator EditPositions => null;

		/// <summary>Gets or sets a value that indicates whether literal characters in the input mask should be included in the formatted string.</summary>
		/// <returns>
		///     <see langword="true" /> if literals are included; otherwise, <see langword="false" />. The default is <see langword="true" />. </returns>
		public bool IncludeLiterals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether <see cref="P:System.Windows.Forms.MaskedTextBox.PromptChar" /> is used to represent the absence of user input when displaying the formatted string. </summary>
		/// <returns>
		///     <see langword="true" /> if the prompt character is used to represent the positions where no user input was provided; otherwise, <see langword="false" />. The default is <see langword="true" />.</returns>
		public bool IncludePrompt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets a value indicating whether the mask accepts characters outside of the ASCII character set.</summary>
		/// <returns>
		///     <see langword="true" /> if only ASCII is accepted; <see langword="false" /> if <see cref="T:System.ComponentModel.MaskedTextProvider" /> can accept any arbitrary Unicode character. The default is <see langword="false" />.</returns>
		public bool AsciiOnly => false;

		/// <summary>Gets or sets a value that determines whether password protection should be applied to the formatted string.</summary>
		/// <returns>
		///     <see langword="true" /> if the input string is to be treated as a password string; otherwise, <see langword="false" />. The default is <see langword="false" />.</returns>
		public bool IsPassword
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the upper bound of the range of invalid indexes.</summary>
		/// <returns>A value representing the largest invalid index, as determined by the provider implementation. For example, if the lowest valid index is 0, this property will return -1.</returns>
		public static int InvalidIndex => 0;

		/// <summary>Gets the index in the mask of the rightmost input character that has been assigned to the mask.</summary>
		/// <returns>If at least one input character has been assigned to the mask, an <see cref="T:System.Int32" /> containing the index of rightmost assigned position; otherwise, if no position has been assigned, <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int LastAssignedPosition => 0;

		/// <summary>Gets the length of the mask, absent any mask modifier characters.</summary>
		/// <returns>An <see cref="T:System.Int32" /> containing the number of positions in the mask, excluding characters that modify mask input. </returns>
		public int Length => 0;

		/// <summary>Gets the input mask.</summary>
		/// <returns>A <see cref="T:System.String" /> containing the full mask.</returns>
		public string Mask { get; }

		/// <summary>Gets a value indicating whether all required inputs have been entered into the formatted string.</summary>
		/// <returns>
		///     <see langword="true" /> if all required input has been entered into the mask; otherwise, <see langword="false" />.</returns>
		public bool MaskCompleted => false;

		/// <summary>Gets a value indicating whether all required and optional inputs have been entered into the formatted string. </summary>
		/// <returns>
		///     <see langword="true" /> if all required and optional inputs have been entered; otherwise, <see langword="false" />. </returns>
		public bool MaskFull => false;

		/// <summary>Gets or sets the character to be substituted for the actual input characters.</summary>
		/// <returns>The <see cref="T:System.Char" /> value used as the password character.</returns>
		/// <exception cref="T:System.InvalidOperationException">The password character specified when setting this property is the same as the current prompt character, <see cref="P:System.ComponentModel.MaskedTextProvider.PromptChar" />. The two are required to be different.</exception>
		/// <exception cref="T:System.ArgumentException">The character specified when setting this property is not a valid password character, as determined by the <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidPasswordChar(System.Char)" /> method.</exception>
		public char PasswordChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		/// <summary>Gets or sets the character used to represent the absence of user input for all available edit positions.</summary>
		/// <returns>The character used to prompt the user for input. The default is an underscore (_). </returns>
		/// <exception cref="T:System.InvalidOperationException">The prompt character specified when setting this property is the same as the current password character, <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" />. The two are required to be different.</exception>
		/// <exception cref="T:System.ArgumentException">The character specified when setting this property is not a valid password character, as determined by the <see cref="M:System.ComponentModel.MaskedTextProvider.IsValidPasswordChar(System.Char)" /> method.</exception>
		public char PromptChar
		{
			get
			{
				return '\0';
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that determines how an input character that matches the prompt character should be handled.</summary>
		/// <returns>
		///     <see langword="true" /> if the prompt character entered as input causes the current editable position in the mask to be reset; otherwise, <see langword="false" /> to indicate that the prompt character is to be processed as a normal input character. The default is <see langword="true" />.</returns>
		public bool ResetOnPrompt
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value that determines how a space input character should be handled.</summary>
		/// <returns>
		///     <see langword="true" /> if the space input character causes the current editable position in the mask to be reset; otherwise, <see langword="false" /> to indicate that it is to be processed as a normal input character. The default is <see langword="true" />.</returns>
		public bool ResetOnSpace
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets or sets a value indicating whether literal character positions in the mask can be overwritten by their same values.</summary>
		/// <returns>
		///     <see langword="true" /> to allow literals to be added back; otherwise, <see langword="false" /> to not allow the user to overwrite literal characters. The default is <see langword="true" />.</returns>
		public bool SkipLiterals
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		/// <summary>Gets the element at the specified position in the formatted string.</summary>
		/// <param name="index">A zero-based index of the element to retrieve. </param>
		/// <returns>The <see cref="T:System.Char" /> at the specified position in the formatted string.</returns>
		/// <exception cref="T:System.IndexOutOfRangeException">
		///         <paramref name="index" /> is less than zero or greater than or equal to the <see cref="P:System.ComponentModel.MaskedTextProvider.Length" /> of the mask.</exception>
		public char this[int index] => '\0';

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		public MaskedTextProvider(string mask)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask and ASCII restriction value.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="restrictToAscii">
		///       <see langword="true" /> to restrict input to ASCII-compatible characters; otherwise <see langword="false" /> to allow the entire Unicode set. </param>
		public MaskedTextProvider(string mask, bool restrictToAscii)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask and culture.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that is used to set region-sensitive separator characters.</param>
		public MaskedTextProvider(string mask, CultureInfo culture)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask, culture, and ASCII restriction value.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that is used to set region-sensitive separator characters.</param>
		/// <param name="restrictToAscii">
		///       <see langword="true" /> to restrict input to ASCII-compatible characters; otherwise <see langword="false" /> to allow the entire Unicode set. </param>
		public MaskedTextProvider(string mask, CultureInfo culture, bool restrictToAscii)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask, password character, and prompt usage value.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="passwordChar">A <see cref="T:System.Char" /> that will be displayed for characters entered into a password string.</param>
		/// <param name="allowPromptAsInput">
		///       <see langword="true" /> to allow the prompt character as input; otherwise <see langword="false" />. </param>
		public MaskedTextProvider(string mask, char passwordChar, bool allowPromptAsInput)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask, culture, password character, and prompt usage value.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that is used to set region-sensitive separator characters.</param>
		/// <param name="passwordChar">A <see cref="T:System.Char" /> that will be displayed for characters entered into a password string.</param>
		/// <param name="allowPromptAsInput">
		///       <see langword="true" /> to allow the prompt character as input; otherwise <see langword="false" />. </param>
		public MaskedTextProvider(string mask, CultureInfo culture, char passwordChar, bool allowPromptAsInput)
		{
		}

		/// <summary>Initializes a new instance of the <see cref="T:System.ComponentModel.MaskedTextProvider" /> class using the specified mask, culture, prompt usage value, prompt character, password character, and ASCII restriction value.</summary>
		/// <param name="mask">A <see cref="T:System.String" /> that represents the input mask. </param>
		/// <param name="culture">A <see cref="T:System.Globalization.CultureInfo" /> that is used to set region-sensitive separator characters.</param>
		/// <param name="allowPromptAsInput">A <see cref="T:System.Boolean" /> value that specifies whether the prompt character should be allowed as a valid input character. </param>
		/// <param name="promptChar">A <see cref="T:System.Char" /> that will be displayed as a placeholder for user input.</param>
		/// <param name="passwordChar">A <see cref="T:System.Char" /> that will be displayed for characters entered into a password string.</param>
		/// <param name="restrictToAscii">
		///       <see langword="true" /> to restrict input to ASCII-compatible characters; otherwise <see langword="false" /> to allow the entire Unicode set. </param>
		/// <exception cref="T:System.ArgumentException">The mask parameter is <see langword="null" /> or <see cref="F:System.String.Empty" />.-or-The mask contains one or more non-printable characters. </exception>
		public MaskedTextProvider(string mask, CultureInfo culture, bool allowPromptAsInput, char promptChar, char passwordChar, bool restrictToAscii)
		{
		}

		private void Initialize()
		{
		}

		/// <summary>Creates a copy of the current <see cref="T:System.ComponentModel.MaskedTextProvider" />.</summary>
		/// <returns>The <see cref="T:System.ComponentModel.MaskedTextProvider" /> object this method creates, cast as an object.</returns>
		public object Clone()
		{
			return null;
		}

		/// <summary>Adds the specified input character to the end of the formatted string.</summary>
		/// <param name="input">A <see cref="T:System.Char" /> value to be appended to the formatted string. </param>
		/// <returns>
		///     <see langword="true" /> if the input character was added successfully; otherwise <see langword="false" />.</returns>
		public bool Add(char input)
		{
			return false;
		}

		/// <summary>Adds the specified input character to the end of the formatted string, and then outputs position and descriptive information.</summary>
		/// <param name="input">A <see cref="T:System.Char" /> value to be appended to the formatted string.</param>
		/// <param name="testPosition">The zero-based position in the formatted string where the attempt was made to add the character. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the input character was added successfully; otherwise <see langword="false" />.</returns>
		public bool Add(char input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Adds the characters in the specified input string to the end of the formatted string.</summary>
		/// <param name="input">A <see cref="T:System.String" /> containing character values to be appended to the formatted string. </param>
		/// <returns>
		///     <see langword="true" /> if all the characters from the input string were added successfully; otherwise <see langword="false" /> to indicate that no characters were added.</returns>
		/// <exception cref="T:System.ArgumentNullException">The<paramref name=" input" /> parameter is <see langword="null" />.</exception>
		public bool Add(string input)
		{
			return false;
		}

		/// <summary>Adds the characters in the specified input string to the end of the formatted string, and then outputs position and descriptive information.</summary>
		/// <param name="input">A <see cref="T:System.String" /> containing character values to be appended to the formatted string. </param>
		/// <param name="testPosition">The zero-based position in the formatted string where the attempt was made to add the character. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters from the input string were added successfully; otherwise <see langword="false" /> to indicate that no characters were added.</returns>
		public bool Add(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Clears all the editable input characters from the formatted string, replacing them with prompt characters.</summary>
		public void Clear()
		{
		}

		/// <summary>Clears all the editable input characters from the formatted string, replacing them with prompt characters, and then outputs descriptive information.</summary>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter. </param>
		public void Clear(out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
		}

		/// <summary>Returns the position of the first assigned editable position after the specified position using the specified search direction.</summary>
		/// <param name="position">The zero-based position in the formatted string to start the search.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first assigned editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindAssignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		/// <summary>Returns the position of the first assigned editable position between the specified positions using the specified search direction.</summary>
		/// <param name="startPosition">The zero-based position in the formatted string where the search starts.</param>
		/// <param name="endPosition">The zero-based position in the formatted string where the search ends.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first assigned editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindAssignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		/// <summary>Returns the position of the first editable position after the specified position using the specified search direction.</summary>
		/// <param name="position">The zero-based position in the formatted string to start the search.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		/// <summary>Returns the position of the first editable position between the specified positions using the specified search direction.</summary>
		/// <param name="startPosition">The zero-based position in the formatted string where the search starts.</param>
		/// <param name="endPosition">The zero-based position in the formatted string where the search ends.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		private int FindEditPositionInRange(int startPosition, int endPosition, bool direction, byte assignedStatus)
		{
			return 0;
		}

		/// <summary>Returns the position of the first non-editable position after the specified position using the specified search direction.</summary>
		/// <param name="position">The zero-based position in the formatted string to start the search.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first literal position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindNonEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		/// <summary>Returns the position of the first non-editable position between the specified positions using the specified search direction.</summary>
		/// <param name="startPosition">The zero-based position in the formatted string where the search starts.</param>
		/// <param name="endPosition">The zero-based position in the formatted string where the search ends.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first literal position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindNonEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		private int FindPositionInRange(int startPosition, int endPosition, bool direction, CharType charTypeFlags)
		{
			return 0;
		}

		/// <summary>Returns the position of the first unassigned editable position after the specified position using the specified search direction.</summary>
		/// <param name="position">The zero-based position in the formatted string to start the search.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first unassigned editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindUnassignedEditPositionFrom(int position, bool direction)
		{
			return 0;
		}

		/// <summary>Returns the position of the first unassigned editable position between the specified positions using the specified search direction.</summary>
		/// <param name="startPosition">The zero-based position in the formatted string where the search starts.</param>
		/// <param name="endPosition">The zero-based position in the formatted string where the search ends.</param>
		/// <param name="direction">A <see cref="T:System.Boolean" /> indicating the search direction; either <see langword="true" /> to search forward or <see langword="false" /> to search backward.</param>
		/// <returns>If successful, an <see cref="T:System.Int32" /> representing the zero-based position of the first unassigned editable position encountered; otherwise <see cref="P:System.ComponentModel.MaskedTextProvider.InvalidIndex" />.</returns>
		public int FindUnassignedEditPositionInRange(int startPosition, int endPosition, bool direction)
		{
			return 0;
		}

		/// <summary>Determines whether the specified <see cref="T:System.ComponentModel.MaskedTextResultHint" /> denotes success or failure.</summary>
		/// <param name="hint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> value typically obtained as an output parameter from a previous operation. </param>
		/// <returns>
		///     <see langword="true" /> if the specified <see cref="T:System.ComponentModel.MaskedTextResultHint" /> value represents a success; otherwise, <see langword="false" /> if it represents failure.</returns>
		public static bool GetOperationResultFromHint(MaskedTextResultHint hint)
		{
			return false;
		}

		/// <summary>Inserts the specified character at the specified position within the formatted string.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> to be inserted. </param>
		/// <param name="position">The zero-based position in the formatted string to insert the character.</param>
		/// <returns>
		///     <see langword="true" /> if the insertion was successful; otherwise, <see langword="false" />.</returns>
		public bool InsertAt(char input, int position)
		{
			return false;
		}

		/// <summary>Inserts the specified character at the specified position within the formatted string, returning the last insertion position and the status of the operation.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> to be inserted. </param>
		/// <param name="position">The zero-based position in the formatted string to insert the character.</param>
		/// <param name="testPosition">If the method is successful, the last position where a character was inserted; otherwise, the first position where the insertion failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the insertion operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the insertion was successful; otherwise, <see langword="false" />.</returns>
		public bool InsertAt(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Inserts the specified string at a specified position within the formatted string. </summary>
		/// <param name="input">The <see cref="T:System.String" /> to be inserted. </param>
		/// <param name="position">The zero-based position in the formatted string to insert the input string.</param>
		/// <returns>
		///     <see langword="true" /> if the insertion was successful; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> parameter is <see langword="null" />.</exception>
		public bool InsertAt(string input, int position)
		{
			return false;
		}

		/// <summary>Inserts the specified string at a specified position within the formatted string, returning the last insertion position and the status of the operation. </summary>
		/// <param name="input">The <see cref="T:System.String" /> to be inserted. </param>
		/// <param name="position">The zero-based position in the formatted string to insert the input string.</param>
		/// <param name="testPosition">If the method is successful, the last position where a character was inserted; otherwise, the first position where the insertion failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the insertion operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the insertion was successful; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> parameter is <see langword="null" />.</exception>
		public bool InsertAt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool InsertAtInt(string input, int position, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private static bool IsAscii(char c)
		{
			return false;
		}

		private static bool IsAciiAlphanumeric(char c)
		{
			return false;
		}

		private static bool IsAlphanumeric(char c)
		{
			return false;
		}

		private static bool IsAsciiLetter(char c)
		{
			return false;
		}

		/// <summary>Determines whether the specified position is available for assignment.</summary>
		/// <param name="position">The zero-based position in the mask to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified position in the formatted string is editable and has not been assigned to yet; otherwise <see langword="false" />.</returns>
		public bool IsAvailablePosition(int position)
		{
			return false;
		}

		/// <summary>Determines whether the specified position is editable. </summary>
		/// <param name="position">The zero-based position in the mask to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified position in the formatted string is editable; otherwise <see langword="false" />.</returns>
		public bool IsEditPosition(int position)
		{
			return false;
		}

		private static bool IsEditPosition(CharDescriptor charDescriptor)
		{
			return false;
		}

		private static bool IsLiteralPosition(CharDescriptor charDescriptor)
		{
			return false;
		}

		private static bool IsPrintableChar(char c)
		{
			return false;
		}

		/// <summary>Determines whether the specified character is a valid input character.</summary>
		/// <param name="c">The <see cref="T:System.Char" /> value to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified character contains a valid input value; otherwise <see langword="false" />.</returns>
		public static bool IsValidInputChar(char c)
		{
			return false;
		}

		/// <summary>Determines whether the specified character is a valid mask character.</summary>
		/// <param name="c">The <see cref="T:System.Char" /> value to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified character contains a valid mask value; otherwise <see langword="false" />.</returns>
		public static bool IsValidMaskChar(char c)
		{
			return false;
		}

		/// <summary>Determines whether the specified character is a valid password character.</summary>
		/// <param name="c">The <see cref="T:System.Char" /> value to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified character contains a valid password value; otherwise <see langword="false" />.</returns>
		public static bool IsValidPasswordChar(char c)
		{
			return false;
		}

		/// <summary>Removes the last assigned character from the formatted string.</summary>
		/// <returns>
		///     <see langword="true" /> if the character was successfully removed; otherwise, <see langword="false" />.</returns>
		public bool Remove()
		{
			return false;
		}

		/// <summary>Removes the last assigned character from the formatted string, and then outputs the removal position and descriptive information.</summary>
		/// <param name="testPosition">The zero-based position in the formatted string where the character was actually removed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully removed; otherwise, <see langword="false" />.</returns>
		public bool Remove(out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Removes the assigned character at the specified position from the formatted string.</summary>
		/// <param name="position">The zero-based position of the assigned character to remove.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully removed; otherwise, <see langword="false" />.</returns>
		public bool RemoveAt(int position)
		{
			return false;
		}

		/// <summary>Removes the assigned characters between the specified positions from the formatted string.</summary>
		/// <param name="startPosition">The zero-based index of the first assigned character to remove.</param>
		/// <param name="endPosition">The zero-based index of the last assigned character to remove.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully removed; otherwise, <see langword="false" />.</returns>
		public bool RemoveAt(int startPosition, int endPosition)
		{
			return false;
		}

		/// <summary>Removes the assigned characters between the specified positions from the formatted string, and then outputs the removal position and descriptive information.</summary>
		/// <param name="startPosition">The zero-based index of the first assigned character to remove.</param>
		/// <param name="endPosition">The zero-based index of the last assigned character to remove.</param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string of where the characters were actually removed; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully removed; otherwise, <see langword="false" />.</returns>
		public bool RemoveAt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool RemoveAtInt(int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint, bool testOnly)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Replaces a single character at or beyond the specified position with the specified character value.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> value that replaces the existing value.</param>
		/// <param name="position">The zero-based position to search for the first editable character to replace.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully replaced; otherwise, <see langword="false" />.</returns>
		public bool Replace(char input, int position)
		{
			return false;
		}

		/// <summary>Replaces a single character at or beyond the specified position with the specified character value, and then outputs the removal position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> value that replaces the existing value.</param>
		/// <param name="position">The zero-based position to search for the first editable character to replace.</param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string where the last character was actually replaced; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the replacement operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully replaced; otherwise, <see langword="false" />.</returns>
		public bool Replace(char input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Replaces a single character between the specified starting and ending positions with the specified character value, and then outputs the removal position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> value that replaces the existing value.</param>
		/// <param name="startPosition">The zero-based position in the formatted string where the replacement starts. </param>
		/// <param name="endPosition">The zero-based position in the formatted string where the replacement ends. </param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string where the last character was actually replaced; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the replacement operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the character was successfully replaced; otherwise, <see langword="false" />.</returns>
		public bool Replace(char input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Replaces a range of editable characters starting at the specified position with the specified string.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value used to replace the existing editable characters.</param>
		/// <param name="position">The zero-based position to search for the first editable character to replace.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters were successfully replaced; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="input" /> parameter is <see langword="null" />.</exception>
		public bool Replace(string input, int position)
		{
			return false;
		}

		/// <summary>Replaces a range of editable characters starting at the specified position with the specified string, and then outputs the removal position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value used to replace the existing editable characters.</param>
		/// <param name="position">The zero-based position to search for the first editable character to replace.</param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string where the last character was actually replaced; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the replacement operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters were successfully replaced; otherwise, <see langword="false" />.</returns>
		public bool Replace(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Replaces a range of editable characters between the specified starting and ending positions with the specified string, and then outputs the removal position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value used to replace the existing editable characters.</param>
		/// <param name="startPosition">The zero-based position in the formatted string where the replacement starts. </param>
		/// <param name="endPosition">The zero-based position in the formatted string where the replacement ends. </param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string where the last character was actually replaced; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the replacement operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters were successfully replaced; otherwise, <see langword="false" />.</returns>
		public bool Replace(string input, int startPosition, int endPosition, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private void ResetChar(int testPosition)
		{
		}

		private void ResetString(int startPosition, int endPosition)
		{
		}

		/// <summary>Sets the formatted string to the specified input string.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value used to set the formatted string.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters were successfully set; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The<paramref name=" input" /> parameter is <see langword="null" />.</exception>
		public bool Set(string input)
		{
			return false;
		}

		/// <summary>Sets the formatted string to the specified input string, and then outputs the removal position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value used to set the formatted string.</param>
		/// <param name="testPosition">If successful, the zero-based position in the formatted string where the last character was actually set; otherwise, the first position where the operation failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the set operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if all the characters were successfully set; otherwise, <see langword="false" />.</returns>
		/// <exception cref="T:System.ArgumentNullException">The<paramref name=" input" /> parameter is <see langword="null" />.</exception>
		public bool Set(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private void SetChar(char input, int position)
		{
		}

		private void SetChar(char input, int position, CharDescriptor charDescriptor)
		{
		}

		private void SetString(string input, int testPosition)
		{
		}

		private bool TestChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestEscapeChar(char input, int position)
		{
			return false;
		}

		private bool TestEscapeChar(char input, int position, CharDescriptor charDex)
		{
			return false;
		}

		private bool TestSetChar(char input, int position, out MaskedTextResultHint resultHint)
		{
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestSetString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		private bool TestString(string input, int position, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Returns the formatted string in a displayable form.</summary>
		/// <returns>The formatted <see cref="T:System.String" /> that includes prompts and mask literals.</returns>
		public string ToDisplayString()
		{
			return null;
		}

		/// <summary>Returns the formatted string that includes all the assigned character values.</summary>
		/// <returns>The formatted <see cref="T:System.String" /> that includes all the assigned character values.</returns>
		public override string ToString()
		{
			return null;
		}

		/// <summary>Returns the formatted string, optionally including password characters.</summary>
		/// <param name="ignorePasswordChar">
		///       <see langword="true" /> to return the actual editable characters; otherwise, <see langword="false" /> to indicate that the <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" /> property is to be honored.</param>
		/// <returns>The formatted <see cref="T:System.String" /> that includes literals, prompts, and optionally password characters.</returns>
		public string ToString(bool ignorePasswordChar)
		{
			return null;
		}

		/// <summary>Returns a substring of the formatted string.</summary>
		/// <param name="startPosition">The zero-based position in the formatted string where the output begins. </param>
		/// <param name="length">The number of characters to return.</param>
		/// <returns>If successful, a substring of the formatted <see cref="T:System.String" />, which includes all the assigned character values; otherwise the <see cref="F:System.String.Empty" /> string.</returns>
		public string ToString(int startPosition, int length)
		{
			return null;
		}

		/// <summary>Returns a substring of the formatted string, optionally including password characters.</summary>
		/// <param name="ignorePasswordChar">
		///       <see langword="true" /> to return the actual editable characters; otherwise, <see langword="false" /> to indicate that the <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" /> property is to be honored.</param>
		/// <param name="startPosition">The zero-based position in the formatted string where the output begins. </param>
		/// <param name="length">The number of characters to return.</param>
		/// <returns>If successful, a substring of the formatted <see cref="T:System.String" />, which includes literals, prompts, and optionally password characters; otherwise the <see cref="F:System.String.Empty" /> string.</returns>
		public string ToString(bool ignorePasswordChar, int startPosition, int length)
		{
			return null;
		}

		/// <summary>Returns the formatted string, optionally including prompt and literal characters.</summary>
		/// <param name="includePrompt">
		///       <see langword="true" /> to include prompt characters in the return string; otherwise, <see langword="false" />.</param>
		/// <param name="includeLiterals">
		///       <see langword="true" /> to include literal characters in the return string; otherwise, <see langword="false" />.</param>
		/// <returns>The formatted <see cref="T:System.String" /> that includes all the assigned character values and optionally includes literals and prompts.</returns>
		public string ToString(bool includePrompt, bool includeLiterals)
		{
			return null;
		}

		/// <summary>Returns a substring of the formatted string, optionally including prompt and literal characters.</summary>
		/// <param name="includePrompt">
		///       <see langword="true" /> to include prompt characters in the return string; otherwise, <see langword="false" />.</param>
		/// <param name="includeLiterals">
		///       <see langword="true" /> to include literal characters in the return string; otherwise, <see langword="false" />.</param>
		/// <param name="startPosition">The zero-based position in the formatted string where the output begins. </param>
		/// <param name="length">The number of characters to return.</param>
		/// <returns>If successful, a substring of the formatted <see cref="T:System.String" />, which includes all the assigned character values and optionally includes literals and prompts; otherwise the <see cref="F:System.String.Empty" /> string.</returns>
		public string ToString(bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		/// <summary>Returns a substring of the formatted string, optionally including prompt, literal, and password characters.</summary>
		/// <param name="ignorePasswordChar">
		///       <see langword="true" /> to return the actual editable characters; otherwise, <see langword="false" /> to indicate that the <see cref="P:System.ComponentModel.MaskedTextProvider.PasswordChar" /> property is to be honored.</param>
		/// <param name="includePrompt">
		///       <see langword="true" /> to include prompt characters in the return string; otherwise, <see langword="false" />.</param>
		/// <param name="includeLiterals">
		///       <see langword="true" /> to return literal characters in the return string; otherwise, <see langword="false" />.</param>
		/// <param name="startPosition">The zero-based position in the formatted string where the output begins. </param>
		/// <param name="length">The number of characters to return.</param>
		/// <returns>If successful, a substring of the formatted <see cref="T:System.String" />, which includes all the assigned character values and optionally includes literals, prompts, and password characters; otherwise the <see cref="F:System.String.Empty" /> string.</returns>
		public string ToString(bool ignorePasswordChar, bool includePrompt, bool includeLiterals, int startPosition, int length)
		{
			return null;
		}

		/// <summary>Tests whether the specified character could be set successfully at the specified position.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> value to test.</param>
		/// <param name="position">The position in the mask to test the input character against.</param>
		/// <param name="hint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the specified character is valid for the specified position; otherwise, <see langword="false" />.</returns>
		public bool VerifyChar(char input, int position, out MaskedTextResultHint hint)
		{
			hint = default(MaskedTextResultHint);
			return false;
		}

		/// <summary>Tests whether the specified character would be escaped at the specified position.</summary>
		/// <param name="input">The <see cref="T:System.Char" /> value to test.</param>
		/// <param name="position">The position in the mask to test the input character against.</param>
		/// <returns>
		///     <see langword="true" /> if the specified character would be escaped at the specified position; otherwise, <see langword="false" />.</returns>
		public bool VerifyEscapeChar(char input, int position)
		{
			return false;
		}

		/// <summary>Tests whether the specified string could be set successfully.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value to test.</param>
		/// <returns>
		///     <see langword="true" /> if the specified string represents valid input; otherwise, <see langword="false" />.</returns>
		public bool VerifyString(string input)
		{
			return false;
		}

		/// <summary>Tests whether the specified string could be set successfully, and then outputs position and descriptive information.</summary>
		/// <param name="input">The <see cref="T:System.String" /> value to test.</param>
		/// <param name="testPosition">If successful, the zero-based position of the last character actually tested; otherwise, the first position where the test failed. An output parameter.</param>
		/// <param name="resultHint">A <see cref="T:System.ComponentModel.MaskedTextResultHint" /> that succinctly describes the result of the test operation. An output parameter.</param>
		/// <returns>
		///     <see langword="true" /> if the specified string represents valid input; otherwise, <see langword="false" />. </returns>
		public bool VerifyString(string input, out int testPosition, out MaskedTextResultHint resultHint)
		{
			testPosition = default(int);
			resultHint = default(MaskedTextResultHint);
			return false;
		}
	}
}
