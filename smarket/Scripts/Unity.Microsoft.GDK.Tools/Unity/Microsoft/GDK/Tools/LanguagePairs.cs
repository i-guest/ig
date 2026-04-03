using System;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.Microsoft.GDK.Tools
{
	[Serializable]
	public class LanguagePairs : ISerializationCallbackReceiver
	{
		private Dictionary<string, bool> _dict;

		[SerializeField]
		private List<string> keys;

		[SerializeField]
		private List<bool> values;

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}

		public void Clear()
		{
		}

		public void SetLanguagePair(GameConfigLanguages lang, bool isActive)
		{
		}

		public void SetLanguagePair(string langName, bool isActive)
		{
		}

		public bool IsLanguagePairSet(GameConfigLanguages lang)
		{
			return false;
		}

		public bool IsLanguagePairSet(string langName)
		{
			return false;
		}

		public void ImportFromXml(Game xmlGameConfig)
		{
		}

		public void ExportToXml(Game xmlGameConfig)
		{
		}

		private string EnumName(GameConfigLanguages lang)
		{
			return null;
		}
	}
}
