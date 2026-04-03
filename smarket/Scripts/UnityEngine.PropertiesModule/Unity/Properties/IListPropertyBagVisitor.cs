namespace Unity.Properties
{
	public interface IListPropertyBagVisitor
	{
		void Visit<TList, TElement>(IListPropertyBag<TList, TElement> properties, ref TList container);
	}
}
