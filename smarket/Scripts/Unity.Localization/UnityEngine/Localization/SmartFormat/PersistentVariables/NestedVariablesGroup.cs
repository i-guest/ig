namespace UnityEngine.Localization.SmartFormat.PersistentVariables
{
	[DisplayName("Nested Variables Group", null)]
	public class NestedVariablesGroup : Variable<VariablesGroupAsset>, IVariableGroup
	{
		public bool TryGetValue(string name, out IVariable value)
		{
			value = null;
			return false;
		}
	}
}
