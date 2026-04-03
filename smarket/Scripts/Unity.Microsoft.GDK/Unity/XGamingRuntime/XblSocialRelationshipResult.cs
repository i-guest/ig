using System;
using Unity.XGamingRuntime.Interop;
using UnityEngine.Scripting.APIUpdating;

namespace Unity.XGamingRuntime
{
	[MovedFrom("Unity.GameCore")]
	public class XblSocialRelationshipResult : IDisposable
	{
		private bool _disposed;

		internal XblSocialRelationshipResultHandle InteropHandle { get; set; }

		internal XblSocialRelationshipResult(XblSocialRelationshipResultHandle interopHandle)
		{
		}

		~XblSocialRelationshipResult()
		{
		}

		public void Dispose()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
