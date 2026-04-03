using System;
using System.ComponentModel;

namespace UnityEngine.ResourceManagement.ResourceProviders
{
	[DisplayName("Binary Asset Provider")]
	internal class BinaryAssetProvider<TAdapter> : BinaryDataProvider where TAdapter : new()
	{
		public override object Convert(Type type, byte[] data)
		{
			return null;
		}
	}
}
