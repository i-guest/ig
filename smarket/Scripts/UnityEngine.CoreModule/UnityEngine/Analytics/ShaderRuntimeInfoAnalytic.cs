using System;
using System.Runtime.InteropServices;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	[Serializable]
	[StructLayout((LayoutKind)0)]
	[ExcludeFromDocs]
	[RequiredByNativeCode(GenerateProxy = true)]
	internal class ShaderRuntimeInfoAnalytic : AnalyticsEventBase
	{
		public long VariantsRequested;

		public long VariantsRequestedMissing;

		public long VariantsRequestedUnsupported;

		public long VariantsRequestedCompiled;

		public long VariantsRequestedViaWarmup;

		public long VariantsUnused;

		public int VariantsCompilationTimeTotal;

		public int VariantsCompilationTimeMax;

		public int VariantsCompilationTimeMedian;

		public int VariantsWarmupTimeTotal;

		public int VariantsWarmupTimeMax;

		public int VariantsWarmupTimeMedian;

		public bool UseProgressiveWarmup;

		public int ShaderChunkSizeMin;

		public int ShaderChunkSizeMax;

		public int ShaderChunkSizeAvg;

		public int ShaderChunkCountMin;

		public int ShaderChunkCountMax;

		public int ShaderChunkCountAvg;

		private ShaderRuntimeInfoAnalytic()
			: base(null, 0, default(SendEventOptions), null)
		{
		}

		[RequiredByNativeCode]
		public static ShaderRuntimeInfoAnalytic CreateShaderRuntimeInfoAnalytic()
		{
			return null;
		}
	}
}
