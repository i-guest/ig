using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XPackageChunkSelector
	{
		internal XPackageChunkSelectorInterop interop;

		internal string _languageOrTagOrFeature;

		public XPackageChunkSelectorType Type
		{
			get
			{
				return default(XPackageChunkSelectorType);
			}
			set
			{
			}
		}

		public string LanguageTagOrFeature
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public uint ChunkId
		{
			get
			{
				return 0u;
			}
			set
			{
			}
		}

		internal XPackageChunkSelector(XPackageChunkSelectorInterop interop)
		{
		}

		public XPackageChunkSelector()
		{
		}
	}
}
