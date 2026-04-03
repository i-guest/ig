using System;

namespace UnityEngine.Localization.Metadata
{
	[AttributeUsage(AttributeTargets.Class)]
	public class MetadataAttribute : Attribute
	{
		public string MenuItem { get; set; }

		public bool AllowMultiple { get; set; }

		public MetadataType AllowedTypes { get; set; }
	}
}
