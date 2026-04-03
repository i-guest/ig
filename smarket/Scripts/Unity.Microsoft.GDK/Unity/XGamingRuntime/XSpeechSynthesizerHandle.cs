using System;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XSpeechSynthesizerHandle : EquatableHandle
	{
		public int CloseResult { get; private set; }

		public override bool IsInvalid => false;

		public XSpeechSynthesizerHandle(IntPtr handle)
			: base((IntPtr)0, ownsHandle: false, (IntPtr)0)
		{
		}

		protected override bool ReleaseHandle()
		{
			return false;
		}
	}
}
