namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	internal struct StyleSyntaxToken
	{
		public StyleSyntaxTokenType type;

		public string text;

		public float number;

		public StyleSyntaxToken(StyleSyntaxTokenType t)
		{
			type = default(StyleSyntaxTokenType);
			text = null;
			number = 0f;
		}

		public StyleSyntaxToken(StyleSyntaxTokenType type, string text)
		{
			this.type = default(StyleSyntaxTokenType);
			this.text = null;
			number = 0f;
		}

		public StyleSyntaxToken(StyleSyntaxTokenType type, float number)
		{
			this.type = default(StyleSyntaxTokenType);
			text = null;
			this.number = 0f;
		}
	}
}
