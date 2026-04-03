using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Localization.SmartFormat.Core.Extensions;

namespace UnityEngine.Localization.SmartFormat.Extensions
{
	[Serializable]
	public class ReflectionSource : ISource
	{
		private static readonly object[] k_Empty;

		private Dictionary<(Type, string), (FieldInfo field, MethodInfo method)> m_TypeCache;

		private Dictionary<(Type, string), (FieldInfo field, MethodInfo method)> TypeCache => null;

		public ReflectionSource(SmartFormatter formatter)
		{
		}

		public bool TryEvaluateSelector(ISelectorInfo selectorInfo)
		{
			return false;
		}
	}
}
