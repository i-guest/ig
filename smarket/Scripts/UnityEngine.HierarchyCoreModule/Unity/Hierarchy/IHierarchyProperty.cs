namespace Unity.Hierarchy
{
	public interface IHierarchyProperty<T>
	{
		T GetValue(in HierarchyNode node);

		void SetValue(in HierarchyNode node, T value);
	}
}
