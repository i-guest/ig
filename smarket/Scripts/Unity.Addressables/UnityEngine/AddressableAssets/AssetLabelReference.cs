using System;
using UnityEngine.Serialization;

namespace UnityEngine.AddressableAssets
{
	[Serializable]
	public class AssetLabelReference : IKeyEvaluator
	{
		[FormerlySerializedAs("m_labelString")]
		[SerializeField]
		private string m_LabelString;

		public string labelString
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public object RuntimeKey => null;

		public bool RuntimeKeyIsValid()
		{
			return false;
		}

		public override int GetHashCode()
		{
			return 0;
		}
	}
}
