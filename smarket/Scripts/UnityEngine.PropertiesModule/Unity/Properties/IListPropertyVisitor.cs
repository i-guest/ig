namespace Unity.Properties
{
	public interface IListPropertyVisitor
	{
		void Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list);
	}
}
