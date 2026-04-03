using System;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
	public sealed class AssetReferenceUILabelRestriction : AssetReferenceUIRestriction
	{
		public string[] m_AllowedLabels;

		public string m_CachedToString;

		public AssetReferenceUILabelRestriction(params string[] allowedLabels)
		{
		}

		public override bool ValidateAsset(Object obj)
		{
			return false;
		}

		public override bool ValidateAsset(string path)
		{
			return false;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
