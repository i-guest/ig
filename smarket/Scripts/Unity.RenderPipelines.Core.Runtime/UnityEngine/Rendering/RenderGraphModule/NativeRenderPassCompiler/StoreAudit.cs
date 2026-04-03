using System.Diagnostics;

namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	[DebuggerDisplay("{reason} : {passId} / MSAA {msaaReason} : {msaaPassId}")]
	internal readonly struct StoreAudit
	{
		public static readonly string[] StoreReasonMessages;

		public readonly StoreReason reason;

		public readonly int passId;

		public readonly StoreReason msaaReason;

		public readonly int msaaPassId;

		public StoreAudit(StoreReason setReason, int setPassId = -1, StoreReason setMsaaReason = StoreReason.NoMSAABuffer, int setMsaaPassId = -1)
		{
			reason = default(StoreReason);
			passId = 0;
			msaaReason = default(StoreReason);
			msaaPassId = 0;
		}
	}
}
