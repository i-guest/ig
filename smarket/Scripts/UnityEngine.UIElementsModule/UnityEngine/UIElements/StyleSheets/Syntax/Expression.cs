using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal class Expression
	{
		public ExpressionType type;

		public ExpressionMultiplier multiplier;

		public DataType dataType;

		public ExpressionCombinator combinator;

		public Expression[] subExpressions;

		public float min;

		public float max;

		public string keyword;

		public Expression(ExpressionType type)
		{
		}
	}
}
