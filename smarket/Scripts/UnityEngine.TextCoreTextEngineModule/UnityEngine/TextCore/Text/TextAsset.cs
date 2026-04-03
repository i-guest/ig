using System;
using System.Collections.Generic;
using UnityEngine.Bindings;
using UnityEngine.Serialization;

namespace UnityEngine.TextCore.Text
{
	[Serializable]
	[ExcludeFromObjectFactory]
	public abstract class TextAsset : ScriptableObject
	{
		[SerializeField]
		internal string m_Version;

		internal int m_InstanceID;

		internal int m_HashCode;

		[FormerlySerializedAs("material")]
		[SerializeField]
		internal Material m_Material;

		internal int m_MaterialHashCode;

		private static Dictionary<int, WeakReference<TextAsset>> kTextAssetByInstanceId;

		public string version
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public int instanceID => 0;

		public int hashCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public Material material
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int materialHashCode
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
		internal static TextAsset GetTextAssetByID(int id)
		{
			return null;
		}

		internal virtual void OnDestroy()
		{
		}

		internal virtual void OnEnable()
		{
		}
	}
}
