using System;
using UnityEngine.Localization.Metadata;

namespace UnityEngine.Localization.Tables
{
	[Serializable]
	internal class TableEntryData
	{
		[SerializeField]
		private long m_Id;

		[SerializeField]
		private string m_Localized;

		[SerializeField]
		private MetadataCollection m_Metadata;

		public long Id
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		public string Localized
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public MetadataCollection Metadata
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TableEntryData()
		{
		}

		public TableEntryData(long id)
		{
		}

		public TableEntryData(long id, string localized)
		{
		}
	}
}
