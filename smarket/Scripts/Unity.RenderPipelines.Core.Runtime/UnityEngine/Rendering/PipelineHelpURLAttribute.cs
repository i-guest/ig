using System;
using System.Diagnostics;

namespace UnityEngine.Rendering
{
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Enum, AllowMultiple = true)]
	public class PipelineHelpURLAttribute : HelpURLAttribute
	{
		private string pipelineName { get; }

		private string pageName { get; }

		private string pageHash { get; }

		public override string URL => null;

		public PipelineHelpURLAttribute(string pipelineName, string pageName, string pageHash = "")
			: base(null)
		{
		}
	}
}
