using System;
using UnityEngine.Bindings;

namespace UnityEngine.TextCore.Text
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule", "UnityEngine.IMGUIModule", "UnityEditor.GraphToolsFoundationModule" })]
	internal readonly struct RenderedText : IEquatable<RenderedText>, IEquatable<string>
	{
		public struct Enumerator
		{
			private readonly RenderedText m_Source;

			private int m_Stage;

			private int m_StageIndex;

			private char m_Current;

			public char Current => '\0';

			public Enumerator(in RenderedText source)
			{
				m_Source = default(RenderedText);
				m_Stage = 0;
				m_StageIndex = 0;
				m_Current = '\0';
			}

			public bool MoveNext()
			{
				return false;
			}
		}

		public readonly string value;

		public readonly int valueStart;

		public readonly int valueLength;

		public readonly string suffix;

		public readonly char repeat;

		public readonly int repeatCount;

		public int CharacterCount => 0;

		public RenderedText(string value)
		{
			this.value = null;
			valueStart = 0;
			valueLength = 0;
			suffix = null;
			repeat = '\0';
			repeatCount = 0;
		}

		public RenderedText(string value, string suffix)
		{
			this.value = null;
			valueStart = 0;
			valueLength = 0;
			this.suffix = null;
			repeat = '\0';
			repeatCount = 0;
		}

		public RenderedText(string value, int start, int length, string suffix = null)
		{
			this.value = null;
			valueStart = 0;
			valueLength = 0;
			this.suffix = null;
			repeat = '\0';
			repeatCount = 0;
		}

		public RenderedText(char repeat, int repeatCount, string suffix = null)
		{
			value = null;
			valueStart = 0;
			valueLength = 0;
			this.suffix = null;
			this.repeat = '\0';
			this.repeatCount = 0;
		}

		public Enumerator GetEnumerator()
		{
			return default(Enumerator);
		}

		public string CreateString()
		{
			return null;
		}

		public bool Equals(RenderedText other)
		{
			return false;
		}

		public bool Equals(string other)
		{
			return false;
		}

		public override bool Equals(object obj)
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
